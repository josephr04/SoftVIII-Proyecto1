Imports System.IO
Imports MySql.Data.MySqlClient

Partial Public Class Form1
    Private rutaArchivo As String = ""

    Private Sub btnAbrirArchivo_Click(sender As Object, e As EventArgs) Handles btnAbrirArchivo.Click
        Dim openFile As New OpenFileDialog
        If openFile.ShowDialog = DialogResult.OK Then
            rutaArchivo = openFile.FileName
            Label5.Text = "Archivo seleccionado: " & Path.GetFileName(rutaArchivo)
            btnProcesarArchivo.Visible = True
            btnCancelar.Visible = True
        End If
    End Sub

    Private Async Sub btnProcesarArchivo_Click(sender As Object, e As EventArgs) Handles btnProcesarArchivo.Click
        If String.IsNullOrWhiteSpace(rutaArchivo) Then
            MessageBox.Show("Selecciona un archivo primero")
            Exit Sub
        End If

        ' Mostrar loader (ReaLTaiizor CyberProgressBar + Label)
        Label6.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 40
        ProgressBar1.Visible = True

        Try
            ' Ejecutar lógica en otro hilo (para no congelar la UI)
            Dim resultado = Await Task.Run(Function() ProcesarArchivo())

            ' Mostrar resumen
            If resultado.Errores.Count > 0 Then
                MessageBox.Show($"Proceso finalizado." & vbCrLf &
                            $"Insertados: {resultado.Insertados}" & vbCrLf &
                            $"Ignorados (duplicados): {resultado.Ignorados}" & vbCrLf &
                            $"Errores: {resultado.Errores.Count}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show($"Proceso finalizado." & vbCrLf &
                            $"Insertados: {resultado.Insertados}" & vbCrLf &
                            $"Ignorados (duplicados): {resultado.Ignorados}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            LimpiarSeleccionArchivo()

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ocultar loader
            Label6.Visible = False
            ProgressBar1.Visible = False
        End Try
    End Sub

    Private Class ResultadoProceso
        Public Property Insertados As Integer
        Public Property Ignorados As Integer
        Public Property Errores As List(Of String)
    End Class

    Private Function ProcesarArchivo() As ResultadoProceso
        Dim insertados As Integer = 0
        Dim ignorados As Integer = 0
        Dim errores As New List(Of String)

        Try
            Dim lineas = File.ReadAllLines(rutaArchivo)
            Using conn = ObtenerConexion()
                conn.Open()

                ' --- Cargar registros existentes en memoria ---
                Dim registrosExistentes As New HashSet(Of String)
                Dim queryExistentes = "SELECT cod_marcacion, fecha, hora FROM logger2"
                Using cmd As New MySqlCommand(queryExistentes, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim key As String = $"{reader("cod_marcacion")}-{CDate(reader("fecha")).ToString("yyyy-MM-dd")}-{reader("hora")}"
                            registrosExistentes.Add(key)
                        End While
                    End Using
                End Using

                Using trans = conn.BeginTransaction()
                    Dim cmdInsert As New MySqlCommand("INSERT INTO logger2 (cod_marcacion, fecha, hora) VALUES (@cod, @fecha, @hora)", conn, trans)
                    cmdInsert.Parameters.Add("@cod", MySqlDbType.Int32)
                    cmdInsert.Parameters.Add("@fecha", MySqlDbType.Date)
                    cmdInsert.Parameters.Add("@hora", MySqlDbType.Time)

                    For i As Integer = 0 To lineas.Length - 1
                        Dim linea = lineas(i).Trim()
                        If linea = "" Then Continue For

                        Dim partes = System.Text.RegularExpressions.Regex.Split(linea, "\s+")
                        If partes.Length < 3 Then
                            errores.Add($"Línea {i + 1}: estructura inválida -> '{linea}'")
                            Continue For
                        End If

                        Dim cod_marcacion As Integer
                        If Not Integer.TryParse(partes(0).Trim(), cod_marcacion) Then
                            errores.Add($"Línea {i + 1}: código inválido -> '{partes(0)}'")
                            Continue For
                        End If

                        Dim fecha As Date
                        If Not Date.TryParse(partes(1).Trim(), fecha) Then
                            errores.Add($"Línea {i + 1}: fecha inválida -> '{partes(1)}'")
                            Continue For
                        End If

                        Dim hora As TimeSpan
                        If Not TimeSpan.TryParse(partes(2).Trim(), hora) Then
                            errores.Add($"Línea {i + 1}: hora inválida -> '{partes(2)}'")
                            Continue For
                        End If

                        Dim key As String = $"{cod_marcacion}-{fecha:yyyy-MM-dd}-{hora}"
                        If registrosExistentes.Contains(key) Then
                            ignorados += 1
                            Continue For
                        End If

                        cmdInsert.Parameters("@cod").Value = cod_marcacion
                        cmdInsert.Parameters("@fecha").Value = fecha
                        cmdInsert.Parameters("@hora").Value = hora
                        cmdInsert.ExecuteNonQuery()

                        registrosExistentes.Add(key)
                        insertados += 1
                    Next

                    trans.Commit()
                End Using
            End Using
        Catch ex As Exception
            errores.Add("Error crítico: " & ex.Message)
        End Try

        Return New ResultadoProceso With {
        .insertados = insertados,
        .ignorados = ignorados,
        .errores = errores
    }
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarSeleccionArchivo()
    End Sub

    Private Sub LimpiarSeleccionArchivo()
        rutaArchivo = ""
        Label5.Text = ""
        btnProcesarArchivo.Visible = False
        btnCancelar.Visible = False
    End Sub

End Class