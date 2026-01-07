Imports MySql.Data.MySqlClient

Public Class Form2
    Public Property FormPadre As Form1

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler TextBoxNombre.TextChanged, AddressOf SoloLetrasTextBox
        AddHandler TextBoxApellido.TextChanged, AddressOf SoloLetrasTextBox
        AddHandler TextBoxCedula.TextChanged, AddressOf SoloLetrasNumerosGuion
        AddHandler TextBoxCodigo.TextChanged, AddressOf SoloNumeros
    End Sub

    Private Sub BtnRegistrarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEmpleado.Click
        Dim nombre = TextBoxNombre.Text.Trim
        Dim apellido = TextBoxApellido.Text.Trim
        Dim cedula = TextBoxCedula.Text.Trim
        Dim cod_marcacion = TextBoxCodigo.Text.Trim

        If nombre = "" Or apellido = "" Or cedula = "" Or cod_marcacion = "" Then
            MessageBox.Show("Por favor completa todos los campos.")
            Exit Sub
        End If

        Try
            Using conn = ObtenerConexion()
                conn.Open()

                ' Verificar si ya existe un empleado con la misma cédula o código
                Dim queryCheck = "SELECT COUNT(*) FROM empleado WHERE cedula=@cedula OR cod_marcacion=@cod"
                Using cmdCheck As New MySqlCommand(queryCheck, conn)
                    cmdCheck.Parameters.AddWithValue("@cedula", cedula)
                    cmdCheck.Parameters.AddWithValue("@cod", cod_marcacion)
                    Dim existe = Convert.ToInt32(cmdCheck.ExecuteScalar)

                    If existe > 0 Then
                        MessageBox.Show("Ya existe un empleado con esa cédula o código de marcación.")
                        Exit Sub
                    End If
                End Using

                ' Insertar el nuevo empleado
                Dim queryInsert = "INSERT INTO empleado (nombre, apellido, cedula, cod_marcacion) 
                                   VALUES (@nombre, @apellido, @cedula, @cod_marcacion)"
                Using cmdInsert As New MySqlCommand(queryInsert, conn)
                    cmdInsert.Parameters.AddWithValue("@nombre", nombre)
                    cmdInsert.Parameters.AddWithValue("@apellido", apellido)
                    cmdInsert.Parameters.AddWithValue("@cedula", cedula)
                    cmdInsert.Parameters.AddWithValue("@cod_marcacion", cod_marcacion)
                    cmdInsert.ExecuteNonQuery()
                End Using
            End Using

            FormPadre?.CargarEmpleados()

            ' Limpiar los TextBox
            TextBoxNombre.Text = ""
            TextBoxApellido.Text = ""
            TextBoxCedula.Text = ""
            TextBoxCodigo.Text = ""

            FormPadre.CargarCodigosMarcacion()
            MessageBox.Show("Empleado registrado correctamente.")
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al registrar empleado: " & ex.Message)
        End Try
    End Sub

End Class
