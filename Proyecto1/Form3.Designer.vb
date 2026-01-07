<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DungeonHeaderLabel1 = New ReaLTaiizor.Controls.DungeonHeaderLabel()
        BtnCrearDia = New ReaLTaiizor.Controls.CyberButton()
        TextBoxDetalle = New ReaLTaiizor.Controls.AloneTextBox()
        Label9 = New Label()
        Label10 = New Label()
        PoisonDateTime1 = New ReaLTaiizor.Controls.PoisonDateTime()
        SuspendLayout()
        ' 
        ' DungeonHeaderLabel1
        ' 
        DungeonHeaderLabel1.AutoSize = True
        DungeonHeaderLabel1.BackColor = Color.Transparent
        DungeonHeaderLabel1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        DungeonHeaderLabel1.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(77))
        DungeonHeaderLabel1.Location = New Point(86, 25)
        DungeonHeaderLabel1.Name = "DungeonHeaderLabel1"
        DungeonHeaderLabel1.Size = New Size(144, 25)
        DungeonHeaderLabel1.TabIndex = 51
        DungeonHeaderLabel1.Text = "Crear Día Libre"
        ' 
        ' BtnCrearDia
        ' 
        BtnCrearDia.Alpha = 20
        BtnCrearDia.BackColor = Color.Transparent
        BtnCrearDia.Background = True
        BtnCrearDia.Background_WidthPen = 4F
        BtnCrearDia.BackgroundPen = True
        BtnCrearDia.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        BtnCrearDia.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        BtnCrearDia.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        BtnCrearDia.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        BtnCrearDia.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        BtnCrearDia.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        BtnCrearDia.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        BtnCrearDia.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        BtnCrearDia.Effect_1 = True
        BtnCrearDia.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        BtnCrearDia.Effect_1_Transparency = 25
        BtnCrearDia.Effect_2 = True
        BtnCrearDia.Effect_2_ColorBackground = Color.White
        BtnCrearDia.Effect_2_Transparency = 20
        BtnCrearDia.Font = New Font("Arial", 11F)
        BtnCrearDia.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        BtnCrearDia.Lighting = False
        BtnCrearDia.LinearGradient_Background = False
        BtnCrearDia.LinearGradientPen = False
        BtnCrearDia.Location = New Point(95, 203)
        BtnCrearDia.Name = "BtnCrearDia"
        BtnCrearDia.PenWidth = 15
        BtnCrearDia.Rounding = True
        BtnCrearDia.RoundingInt = 70
        BtnCrearDia.Size = New Size(115, 45)
        BtnCrearDia.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        BtnCrearDia.TabIndex = 50
        BtnCrearDia.Tag = "Cyber"
        BtnCrearDia.TextButton = "Crear"
        BtnCrearDia.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        BtnCrearDia.Timer_Effect_1 = 5
        BtnCrearDia.Timer_RGB = 300
        ' 
        ' TextBoxDetalle
        ' 
        TextBoxDetalle.BackColor = Color.Transparent
        TextBoxDetalle.EnabledCalc = True
        TextBoxDetalle.Font = New Font("Segoe UI", 9F)
        TextBoxDetalle.ForeColor = Color.FromArgb(CByte(124), CByte(133), CByte(142))
        TextBoxDetalle.Location = New Point(94, 136)
        TextBoxDetalle.MaxLength = 32767
        TextBoxDetalle.MultiLine = False
        TextBoxDetalle.Name = "TextBoxDetalle"
        TextBoxDetalle.ReadOnly = False
        TextBoxDetalle.Size = New Size(190, 28)
        TextBoxDetalle.TabIndex = 47
        TextBoxDetalle.TextAlign = HorizontalAlignment.Left
        TextBoxDetalle.UseSystemPasswordChar = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Location = New Point(29, 89)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 20)
        Label9.TabIndex = 42
        Label9.Text = "Fecha:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(29, 141)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 20)
        Label10.TabIndex = 43
        Label10.Text = "Detalle:"
        ' 
        ' PoisonDateTime1
        ' 
        PoisonDateTime1.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        PoisonDateTime1.Location = New Point(94, 85)
        PoisonDateTime1.MinimumSize = New Size(0, 30)
        PoisonDateTime1.Name = "PoisonDateTime1"
        PoisonDateTime1.Size = New Size(190, 30)
        PoisonDateTime1.TabIndex = 52
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 270)
        Controls.Add(PoisonDateTime1)
        Controls.Add(DungeonHeaderLabel1)
        Controls.Add(BtnCrearDia)
        Controls.Add(TextBoxDetalle)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Name = "Form3"
        Text = "Crear Día Libre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DungeonHeaderLabel1 As ReaLTaiizor.Controls.DungeonHeaderLabel
    Friend WithEvents BtnCrearDia As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents TextBoxDetalle As ReaLTaiizor.Controls.AloneTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PoisonDateTime1 As ReaLTaiizor.Controls.PoisonDateTime
End Class
