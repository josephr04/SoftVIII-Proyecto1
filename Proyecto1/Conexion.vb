Imports MySql.Data.MySqlClient

Module Conexion
    Private ReadOnly connectionString As String = "Server=127.0.0.1;Database=asistencia;Uid=root;Pwd=;Port=3306;"

    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Module
