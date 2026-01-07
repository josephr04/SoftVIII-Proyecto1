Imports MySql.Data.MySqlClient

Partial Public Class Form1

    Public Sub CargarEmpleados()
        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim query = "SELECT cod_marcacion, nombre, apellido, cedula FROM empleado"
                Using cmd As New MySqlCommand(query, conn)
                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    DataGridView2.AutoGenerateColumns = False
                    DataGridView2.DataSource = dt

                    DataGridView2.Columns("cod_marcacion").DataPropertyName = "cod_marcacion"
                    DataGridView2.Columns("nombre").DataPropertyName = "nombre"
                    DataGridView2.Columns("apellido").DataPropertyName = "apellido"
                    DataGridView2.Columns("cedula").DataPropertyName = "cedula"

                    DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar empleados: " & ex.Message)
        Finally
            cargandoDatos = False
        End Try
    End Sub

    Private Sub btnCrearPersonal_Click(sender As Object, e As EventArgs) Handles btnCrearPersonal.Click
        Dim f As New Form2()
        f.StartPosition = FormStartPosition.CenterParent
        f.FormPadre = Me
        If f.ShowDialog() = DialogResult.OK Then
            CargarEmpleados()
        End If
    End Sub

    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        If cargandoDatos Then Exit Sub
        btnGuardarCambios.Visible = True
        btnCancelarCambios.Visible = True
    End Sub

    Private Sub DataGridView2_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView2.CurrentCellDirtyStateChanged
        If DataGridView2.IsCurrentCellDirty Then
            DataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Try
            ' Validar TODAS las filas antes de guardar
            For Each row As DataGridViewRow In DataGridView2.Rows
                If Not row.IsNewRow Then
                    Dim nombre = If(row.Cells("nombre").Value?.ToString().Trim(), "")
                    Dim apellido = If(row.Cells("apellido").Value?.ToString().Trim(), "")
                    Dim cedula = If(row.Cells("cedula").Value?.ToString().Trim(), "")

                    If nombre = "" OrElse apellido = "" OrElse cedula = "" Then
                        MessageBox.Show($"No se puede guardar. No pueden haber campos vacíos.",
                                    "Campos vacíos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning)
                        ' Salir completamente sin guardar NADA
                        Return
                    End If
                End If
            Next

            Using conn = ObtenerConexion()
                conn.Open()
                For Each row As DataGridViewRow In DataGridView2.Rows
                    If Not row.IsNewRow Then
                        Dim query As String = "UPDATE empleado SET nombre=@nombre, apellido=@apellido, cedula=@cedula WHERE cod_marcacion=@cod"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@nombre", row.Cells("nombre").Value.ToString().Trim())
                            cmd.Parameters.AddWithValue("@apellido", row.Cells("apellido").Value.ToString().Trim())
                            cmd.Parameters.AddWithValue("@cedula", row.Cells("cedula").Value.ToString().Trim())
                            cmd.Parameters.AddWithValue("@cod", row.Cells("cod_marcacion").Value)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using

            ' Solo ocultar botones y mostrar éxito si TODO se guardó
            btnGuardarCambios.Visible = False
            btnCancelarCambios.Visible = False
            MessageBox.Show("Cambios guardados correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al guardar cambios: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancelarCambios_Click(sender As Object, e As EventArgs) Handles btnCancelarCambios.Click
        CargarEmpleados()
        btnGuardarCambios.Visible = False
        btnCancelarCambios.Visible = False
    End Sub

    Public Sub CargarCodigosMarcacion()
        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim query As String = "SELECT cod_marcacion FROM empleado"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        CodigosComboBox.Items.Clear()
                        While reader.Read()
                            CodigosComboBox.Items.Add(reader("cod_marcacion").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar códigos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistro.Click
        If CodigosComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un código para eliminar.")
            Return
        End If

        Dim codigo As String = CodigosComboBox.SelectedItem.ToString()
        Dim nombreCompleto As String = ""

        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim queryNombre As String = "SELECT nombre, apellido FROM empleado WHERE cod_marcacion = @codigo"
                Using cmd As New MySqlCommand(queryNombre, conn)
                    cmd.Parameters.AddWithValue("@codigo", codigo)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            nombreCompleto = reader("nombre").ToString() & " " & reader("apellido").ToString()
                        Else
                            MessageBox.Show("No se encontró el registro.")
                            Return
                        End If
                    End Using
                End Using

                Dim result As DialogResult = MessageBox.Show(
                    $"¿Está seguro que desea eliminar a {nombreCompleto} (código {codigo})?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

                If result = DialogResult.Yes Then
                    Dim queryDelete As String = "DELETE FROM empleado WHERE cod_marcacion = @codigo"
                    Using cmdDelete As New MySqlCommand(queryDelete, conn)
                        cmdDelete.Parameters.AddWithValue("@codigo", codigo)
                        cmdDelete.ExecuteNonQuery()
                    End Using

                    CargarEmpleados()
                    CargarCodigosMarcacion()
                    MessageBox.Show("Registro eliminado correctamente.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
    End Sub

End Class