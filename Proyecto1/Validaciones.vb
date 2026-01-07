Module Validaciones

    ' Validación para solo letras en TextBox
    Public Sub SoloLetrasTextBox(sender As Object, e As EventArgs)
        Dim tb As ReaLTaiizor.Controls.AloneTextBox = CType(sender, ReaLTaiizor.Controls.AloneTextBox)
        Dim txt = tb.Text
        Dim nuevoTexto = ""
        For Each c As Char In txt
            If Char.IsLetter(c) OrElse Char.IsWhiteSpace(c) OrElse "áéíóúÁÉÍÓÚñÑ".Contains(c) Then
                nuevoTexto &= c
            End If
        Next
        If nuevoTexto <> txt Then
            tb.Text = nuevoTexto
        End If
    End Sub

    ' Validación para cédula
    Public Sub SoloLetrasNumerosGuion(sender As Object, e As EventArgs)
        Dim tb As ReaLTaiizor.Controls.AloneTextBox = CType(sender, ReaLTaiizor.Controls.AloneTextBox)
        Dim txt = tb.Text
        Dim nuevoTexto = ""
        For Each c As Char In txt
            If Char.IsLetterOrDigit(c) OrElse c = "-"c Then
                nuevoTexto &= c
            End If
        Next
        If nuevoTexto <> txt Then
            tb.Text = nuevoTexto
        End If
    End Sub

    ' Validación para solo numeros en TextBox
    Public Sub SoloNumeros(sender As Object, e As EventArgs)
        Dim tb As ReaLTaiizor.Controls.AloneTextBox = CType(sender, ReaLTaiizor.Controls.AloneTextBox)
        Dim txt = tb.Text
        Dim nuevoTexto = ""
        For Each c As Char In txt
            If Char.IsDigit(c) Then
                nuevoTexto &= c
            End If
        Next
        If nuevoTexto <> txt Then
            tb.Text = nuevoTexto
        End If
    End Sub

End Module
