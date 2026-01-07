Imports System.IO
Imports MySql.Data.MySqlClient
Imports ReaLTaiizor.Controls

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCodigosMarcacion()
        CargarEmpleados()
        CargarDias()
        CargarFechas()
    End Sub

    Private cargandoDatos As Boolean = True

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim cod = TextBox1.Text.Trim
        Dim fechaDesde As String = PoisonDateTime1.Value.ToString("yyyy-MM-dd")
        Dim fechaHasta As String = PoisonDateTime2.Value.ToString("yyyy-MM-dd")

        If cod = "" Then
            MessageBox.Show("Por favor ingresa un código de marcación.")
            Exit Sub
        End If

        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim query = "SELECT id_registro, cod_marcacion, fecha, hora 
                             FROM logger 
                             WHERE cod_marcacion = @cod 
                               AND fecha BETWEEN @fechaDesde AND @fechaHasta"


                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cod", cod)
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde)
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta)

                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    DataGridView1.DataSource = dt
                    LabelTotal.Text = "Registros encontrados: " & dt.Rows.Count.ToString

                    ' Limpiamos los ítems anteriores
                    MaterialListView1.Items.Clear()

                    Dim horaOficialEntrada = TimeSpan.FromHours(7) ' 7:00 AM

                    ' Agrupamos por fecha y por cod_marcacion (internamente)
                    Dim grupos = dt.AsEnumerable _
                                   .GroupBy(Function(r) New With {
                                               Key .fecha = Convert.ToDateTime(r("fecha")),
                                               Key .codigo = r("cod_marcacion")
                                           })

                    For Each grupo In grupos
                        Dim fechaValor = grupo.Key.fecha

                        ' Obtenemos todas las horas de este grupo
                        Dim horas = grupo.Select(Function(r)
                                                     Dim h = r("hora")
                                                     If TypeOf h Is TimeSpan Then
                                                         Return CType(h, TimeSpan)
                                                     Else
                                                         Return Convert.ToDateTime(h).TimeOfDay
                                                     End If
                                                 End Function) _
                                         .OrderBy(Function(h) h).ToList

                        ' Hora de entrada y salida
                        Dim horaEntrada As TimeSpan? = If(horas.Count > 0, horas.First, Nothing)
                        Dim horaSalida As TimeSpan? = If(horas.Count > 0, horas.Last, Nothing)

                        ' Creamos ítem
                        Dim item As New ListViewItem(fechaValor.ToString("yyyy-MM-dd"))

                        ' Día abreviado
                        Dim diaSemana = fechaValor.ToString("ddd", New Globalization.CultureInfo("es-ES"))
                        diaSemana = StrConv(diaSemana, VbStrConv.ProperCase) & "."
                        item.SubItems.Add(diaSemana)

                        ' Hora entrada
                        item.SubItems.Add(If(horaEntrada.HasValue, horaEntrada.Value.ToString("hh\:mm\:ss"), ""))

                        ' Tardanza
                        Dim tardanza = ""
                        If horaEntrada.HasValue AndAlso horaEntrada.Value > horaOficialEntrada Then
                            tardanza = "(T)"
                        End If
                        item.SubItems.Add(tardanza)

                        ' Hora salida
                        item.SubItems.Add(If(horaSalida.HasValue, horaSalida.Value.ToString("hh\:mm\:ss"), ""))



                        MaterialListView1.Items.Add(item)

                        ' Contar asistencias y tardanzas
                        Dim totalAsistencias As Integer = MaterialListView1.Items.Count
                        Dim totalTardanzas As Integer = MaterialListView1.Items.Cast(Of ListViewItem)() _
                                .Count(Function(i) i.SubItems(3).Text = "(T)")

                        Label8.Text = "Asistencias: " & totalAsistencias.ToString()
                        Label9.Text = "Tardanzas: " & totalTardanzas.ToString()

                    Next
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BuscarTodos_Click(sender As Object, e As EventArgs) Handles BuscarTodos.Click
        Dim fechaDesde As String = PoisonDateTime1.Value.ToString("yyyy-MM-dd")
        Dim fechaHasta As String = PoisonDateTime2.Value.ToString("yyyy-MM-dd")

        Try
            Using conn = ObtenerConexion()
                conn.Open()

                Dim query = "SELECT id_registro, cod_marcacion, fecha, hora 
                     FROM logger 
                     WHERE fecha BETWEEN @fechaDesde AND @fechaHasta"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde)
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta)

                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    DataGridView1.DataSource = dt
                    LabelTotal.Text = "Registros encontrados: " & dt.Rows.Count.ToString

                    ' Limpiamos los ítems anteriores
                    MaterialListView1.Items.Clear()

                    ' Horarios oficiales
                    Dim horaEntradaMañana = TimeSpan.FromHours(7)      ' 7:00 AM
                    Dim horaSalidaMañana = TimeSpan.FromHours(12)      ' 12:00 PM (mediodía)
                    Dim horaEntradaTarde = New TimeSpan(12, 20, 0)     ' 12:20 PM
                    Dim horaSalidaTarde = New TimeSpan(17, 20, 0)      ' 17:20 PM (5:20 PM)

                    ' Agrupamos por fecha y por cod_marcacion (internamente)
                    Dim grupos = dt.AsEnumerable _
               .GroupBy(Function(r) New With {
                           Key .fecha = Convert.ToDateTime(r("fecha")),
                           Key .codigo = r("cod_marcacion")
                       })

                    For Each grupo In grupos
                        Dim fechaValor = grupo.Key.fecha

                        ' Obtenemos todas las horas de este grupo
                        Dim horas = grupo.Select(Function(r)
                                                     Dim h = r("hora")
                                                     If TypeOf h Is TimeSpan Then
                                                         Return CType(h, TimeSpan)
                                                     Else
                                                         Return Convert.ToDateTime(h).TimeOfDay
                                                     End If
                                                 End Function) _
                     .OrderBy(Function(h) h).ToList

                        ' Hora de entrada y salida
                        Dim horaEntrada As TimeSpan? = If(horas.Count > 0, horas.First, Nothing)
                        Dim horaSalida As TimeSpan? = If(horas.Count > 0, horas.Last, Nothing)

                        ' Creamos ítem
                        Dim item As New ListViewItem(fechaValor.ToString("yyyy-MM-dd"))

                        ' Día abreviado
                        Dim diaSemana = fechaValor.ToString("ddd", New Globalization.CultureInfo("es-ES"))
                        diaSemana = StrConv(diaSemana, VbStrConv.ProperCase) & "."
                        item.SubItems.Add(diaSemana)

                        ' Hora entrada
                        item.SubItems.Add(If(horaEntrada.HasValue, horaEntrada.Value.ToString("hh\:mm\:ss"), ""))

                        ' Tardanza - Verificar en ambos turnos
                        Dim tardanza = ""
                        If horaEntrada.HasValue Then
                            ' Determinar si es turno mañana o tarde
                            If horaEntrada.Value <= horaSalidaMañana Then
                                ' Es turno de mañana (entrada antes o igual a 12:00 PM)
                                If horaEntrada.Value > horaEntradaMañana Then
                                    tardanza = "(T)"
                                End If
                            ElseIf horaEntrada.Value >= horaEntradaTarde Then
                                ' Es turno de tarde (entrada después o igual a 12:20 PM)
                                If horaEntrada.Value > horaEntradaTarde Then
                                    tardanza = "(T)"
                                End If
                            End If
                        End If
                        item.SubItems.Add(tardanza)

                        ' Hora salida
                        item.SubItems.Add(If(horaSalida.HasValue, horaSalida.Value.ToString("hh\:mm\:ss"), ""))

                        MaterialListView1.Items.Add(item)

                        ' Contar asistencias y tardanzas
                        Dim totalAsistencias As Integer = MaterialListView1.Items.Count
                        Dim totalTardanzas As Integer = MaterialListView1.Items.Cast(Of ListViewItem)() _
                                .Count(Function(i) i.SubItems(3).Text = "(T)")

                        Label8.Text = "Asistencias: " & totalAsistencias.ToString()
                        Label9.Text = "Tardanzas: " & totalTardanzas.ToString()
                    Next

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
