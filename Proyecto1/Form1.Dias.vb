Imports MySql.Data.MySqlClient

Partial Public Class Form1

    ' Cargar los días en el DataGridView
    Public Sub CargarDias()
        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim query = "SELECT fecha, detalle FROM dias_libres"
                Using cmd As New MySqlCommand(query, conn)
                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    DataGridView3.AutoGenerateColumns = False
                    DataGridView3.DataSource = dt

                    DataGridView3.Columns("fecha").DataPropertyName = "fecha"
                    DataGridView3.Columns("detalle").DataPropertyName = "detalle"

                    DataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar días libres: " & ex.Message)
        End Try
    End Sub

    ' Abrir formulario para crear un nuevo día libre
    Private Sub btnCrearDia_Click(sender As Object, e As EventArgs) Handles btnCrearDia.Click
        Dim f As New Form3() ' o FormDiasLibres si usas ese nombre
        f.StartPosition = FormStartPosition.CenterParent
        f.FormPadre = Me
        If f.ShowDialog() = DialogResult.OK Then
            CargarDias()
            CargarFechas()
        End If
    End Sub

    ' Cargar fechas en el ComboBox
    Public Sub CargarFechas()
        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim query As String = "SELECT fecha FROM dias_libres ORDER BY fecha ASC"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        FechasComboBox.Items.Clear()
                        While reader.Read()
                            ' Guardar el DateTime directamente en el ComboBox
                            Dim fecha As Date = reader.GetDateTime("fecha")
                            FechasComboBox.Items.Add(fecha)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar fechas: " & ex.Message)
        End Try
    End Sub

    ' Eliminar un día libre seleccionado desde el ComboBox
    Private Sub btnEliminarDia_Click(sender As Object, e As EventArgs) Handles btnEliminarDia.Click
        ' Verificar si hay una fecha seleccionada
        If FechasComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una fecha para eliminar.")
            Return
        End If

        ' Obtener la fecha seleccionada desde el ComboBox (ya es DateTime)
        Dim fechaSeleccionada As Date = CType(FechasComboBox.SelectedItem, Date)

        ' Confirmar eliminación
        Dim result As DialogResult = MessageBox.Show(
            $"¿Está seguro que desea eliminar el día libre del {fechaSeleccionada:dd/MM/yyyy}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If result = DialogResult.No Then Return

        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim queryDelete As String = "DELETE FROM dias_libres WHERE fecha = @fecha"
                Using cmdDelete As New MySqlCommand(queryDelete, conn)
                    cmdDelete.Parameters.AddWithValue("@fecha", fechaSeleccionada)
                    Dim filasAfectadas As Integer = cmdDelete.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Día libre eliminado correctamente.")
                    Else
                        MessageBox.Show("No se encontró un registro con esa fecha.")
                    End If
                End Using
            End Using

            ' Recargar los datos después de eliminar
            CargarDias()
            CargarFechas()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar día libre: " & ex.Message)
        End Try
    End Sub

End Class
