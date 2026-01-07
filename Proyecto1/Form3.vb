Imports MySql.Data.MySqlClient

Public Class Form3
    Public Property FormPadre As Form1

    Private Sub FormDiasLibres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer formato corto para el selector de fecha (opcional)
        PoisonDateTime1.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub BtnRegistrarDia_Click(sender As Object, e As EventArgs) Handles BtnCrearDia.Click
        Dim fecha As Date = PoisonDateTime1.Value.Date
        Dim detalle As String = TextBoxDetalle.Text.Trim()

        ' Validar campos
        If detalle = "" Then
            MessageBox.Show("Por favor completa el detalle del día libre.")
            Exit Sub
        End If

        Try
            Using conn = ObtenerConexion()
                conn.Open()

                ' Verificar si ya existe un registro con la misma fecha
                Dim queryCheck = "SELECT COUNT(*) FROM dias_libres WHERE fecha = @fecha"
                Using cmdCheck As New MySqlCommand(queryCheck, conn)
                    cmdCheck.Parameters.AddWithValue("@fecha", fecha)
                    Dim existe = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If existe > 0 Then
                        MessageBox.Show("Ya existe un registro con esa fecha.")
                        Exit Sub
                    End If
                End Using

                ' Insertar nuevo día libre
                Dim queryInsert = "INSERT INTO dias_libres (fecha, detalle) VALUES (@fecha, @detalle)"
                Using cmdInsert As New MySqlCommand(queryInsert, conn)
                    cmdInsert.Parameters.AddWithValue("@fecha", fecha)
                    cmdInsert.Parameters.AddWithValue("@detalle", detalle)
                    cmdInsert.ExecuteNonQuery()
                End Using
            End Using

            ' Si el formulario padre tiene una función para recargar la lista, llámala
            FormPadre?.CargarDias()

            ' Limpiar campos
            PoisonDateTime1.Value = Date.Today
            TextBoxDetalle.Text = ""

            MessageBox.Show("Día libre registrado correctamente.")
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al registrar día libre: " & ex.Message)
        End Try
    End Sub
End Class
