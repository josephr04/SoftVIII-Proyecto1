<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        OpenFileDialog1 = New OpenFileDialog()
        HopeTabPage1 = New ReaLTaiizor.Controls.HopeTabPage()
        Consultas = New TabPage()
        PoisonDateTime2 = New ReaLTaiizor.Controls.PoisonDateTime()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        BigLabel1 = New ReaLTaiizor.Controls.BigLabel()
        TextBox1 = New ReaLTaiizor.Controls.AloneTextBox()
        PoisonDateTime1 = New ReaLTaiizor.Controls.PoisonDateTime()
        BuscarTodos = New ReaLTaiizor.Controls.CyberButton()
        Buscar = New ReaLTaiizor.Controls.CyberButton()
        MaterialListView1 = New ReaLTaiizor.Controls.MaterialListView()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        LabelTotal = New Label()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        Label3 = New Label()
        Personal = New TabPage()
        CodigosComboBox = New ComboBox()
        Label2 = New Label()
        btnEliminarRegistro = New ReaLTaiizor.Controls.Button()
        btnCancelarCambios = New ReaLTaiizor.Controls.CyberButton()
        btnGuardarCambios = New ReaLTaiizor.Controls.CyberButton()
        btnCrearPersonal = New ReaLTaiizor.Controls.Button()
        DataGridView2 = New DataGridView()
        cod_marcacion = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        apellido = New DataGridViewTextBoxColumn()
        cedula = New DataGridViewTextBoxColumn()
        BigLabel2 = New ReaLTaiizor.Controls.BigLabel()
        Archivos = New TabPage()
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        Label6 = New Label()
        btnCancelar = New ReaLTaiizor.Controls.CyberButton()
        btnProcesarArchivo = New ReaLTaiizor.Controls.CyberButton()
        btnAbrirArchivo = New ReaLTaiizor.Controls.CyberButton()
        BigLabel3 = New ReaLTaiizor.Controls.BigLabel()
        Label5 = New Label()
        Dias = New TabPage()
        FechasComboBox = New ComboBox()
        Label7 = New Label()
        btnEliminarDia = New ReaLTaiizor.Controls.Button()
        btnCrearDia = New ReaLTaiizor.Controls.Button()
        DataGridView3 = New DataGridView()
        Fecha = New DataGridViewTextBoxColumn()
        Detalle = New DataGridViewTextBoxColumn()
        BigLabel4 = New ReaLTaiizor.Controls.BigLabel()
        HopeTabPage1.SuspendLayout()
        Consultas.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Personal.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Archivos.SuspendLayout()
        Dias.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Todos los archivos (*.*)|*.*"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Selecciona un archivo"
        ' 
        ' HopeTabPage1
        ' 
        HopeTabPage1.BaseColor = Color.FromArgb(CByte(44), CByte(55), CByte(66))
        HopeTabPage1.Controls.Add(Consultas)
        HopeTabPage1.Controls.Add(Personal)
        HopeTabPage1.Controls.Add(Archivos)
        HopeTabPage1.Controls.Add(Dias)
        HopeTabPage1.Font = New Font("Segoe UI", 12F)
        HopeTabPage1.ForeColorA = Color.Silver
        HopeTabPage1.ForeColorB = Color.Gray
        HopeTabPage1.ForeColorC = Color.FromArgb(CByte(150), CByte(255), CByte(255), CByte(255))
        HopeTabPage1.ItemSize = New Size(120, 40)
        HopeTabPage1.Location = New Point(0, 0)
        HopeTabPage1.Name = "HopeTabPage1"
        HopeTabPage1.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        HopeTabPage1.SelectedIndex = 0
        HopeTabPage1.Size = New Size(914, 646)
        HopeTabPage1.SizeMode = TabSizeMode.Fixed
        HopeTabPage1.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        HopeTabPage1.TabIndex = 30
        HopeTabPage1.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        HopeTabPage1.ThemeColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        HopeTabPage1.ThemeColorB = Color.FromArgb(CByte(150), CByte(64), CByte(158), CByte(255))
        HopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal
        ' 
        ' Consultas
        ' 
        Consultas.Controls.Add(PoisonDateTime2)
        Consultas.Controls.Add(Label10)
        Consultas.Controls.Add(Label9)
        Consultas.Controls.Add(Label8)
        Consultas.Controls.Add(BigLabel1)
        Consultas.Controls.Add(TextBox1)
        Consultas.Controls.Add(PoisonDateTime1)
        Consultas.Controls.Add(BuscarTodos)
        Consultas.Controls.Add(Buscar)
        Consultas.Controls.Add(MaterialListView1)
        Consultas.Controls.Add(LabelTotal)
        Consultas.Controls.Add(DataGridView1)
        Consultas.Controls.Add(Label4)
        Consultas.Controls.Add(Label3)
        Consultas.Location = New Point(0, 40)
        Consultas.Name = "Consultas"
        Consultas.Padding = New Padding(3)
        Consultas.Size = New Size(914, 606)
        Consultas.TabIndex = 0
        Consultas.Text = "Consultas"
        Consultas.UseVisualStyleBackColor = True
        ' 
        ' PoisonDateTime2
        ' 
        PoisonDateTime2.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        PoisonDateTime2.Location = New Point(556, 143)
        PoisonDateTime2.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        PoisonDateTime2.MinDate = New Date(1999, 1, 1, 0, 0, 0, 0)
        PoisonDateTime2.MinimumSize = New Size(0, 30)
        PoisonDateTime2.Name = "PoisonDateTime2"
        PoisonDateTime2.Size = New Size(223, 34)
        PoisonDateTime2.TabIndex = 52
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(484, 144)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 28)
        Label10.TabIndex = 51
        Label10.Text = "Hasta:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(521, 509)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 28)
        Label9.TabIndex = 50
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(264, 509)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 28)
        Label8.TabIndex = 49
        ' 
        ' BigLabel1
        ' 
        BigLabel1.AutoSize = True
        BigLabel1.BackColor = Color.Transparent
        BigLabel1.Font = New Font("Segoe UI", 25F)
        BigLabel1.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel1.Location = New Point(50, 15)
        BigLabel1.Name = "BigLabel1"
        BigLabel1.Size = New Size(205, 57)
        BigLabel1.TabIndex = 48
        BigLabel1.Text = "Consultas"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Transparent
        TextBox1.EnabledCalc = True
        TextBox1.Font = New Font("Segoe UI", 9F)
        TextBox1.ForeColor = Color.FromArgb(CByte(124), CByte(133), CByte(142))
        TextBox1.Location = New Point(343, 87)
        TextBox1.MaxLength = 32767
        TextBox1.MultiLine = False
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = False
        TextBox1.Size = New Size(121, 36)
        TextBox1.TabIndex = 47
        TextBox1.TextAlign = HorizontalAlignment.Left
        TextBox1.UseSystemPasswordChar = False
        ' 
        ' PoisonDateTime1
        ' 
        PoisonDateTime1.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        PoisonDateTime1.Location = New Point(556, 88)
        PoisonDateTime1.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        PoisonDateTime1.MinDate = New Date(1999, 1, 1, 0, 0, 0, 0)
        PoisonDateTime1.MinimumSize = New Size(0, 30)
        PoisonDateTime1.Name = "PoisonDateTime1"
        PoisonDateTime1.Size = New Size(223, 34)
        PoisonDateTime1.TabIndex = 46
        ' 
        ' BuscarTodos
        ' 
        BuscarTodos.Alpha = 20
        BuscarTodos.BackColor = Color.Transparent
        BuscarTodos.Background = True
        BuscarTodos.Background_WidthPen = 4F
        BuscarTodos.BackgroundPen = True
        BuscarTodos.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        BuscarTodos.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        BuscarTodos.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        BuscarTodos.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        BuscarTodos.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        BuscarTodos.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        BuscarTodos.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        BuscarTodos.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        BuscarTodos.Effect_1 = True
        BuscarTodos.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        BuscarTodos.Effect_1_Transparency = 25
        BuscarTodos.Effect_2 = True
        BuscarTodos.Effect_2_ColorBackground = Color.White
        BuscarTodos.Effect_2_Transparency = 20
        BuscarTodos.Font = New Font("Arial", 11F)
        BuscarTodos.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        BuscarTodos.Lighting = False
        BuscarTodos.LinearGradient_Background = False
        BuscarTodos.LinearGradientPen = False
        BuscarTodos.Location = New Point(302, 137)
        BuscarTodos.Name = "BuscarTodos"
        BuscarTodos.PenWidth = 15
        BuscarTodos.Rounding = True
        BuscarTodos.RoundingInt = 70
        BuscarTodos.Size = New Size(162, 43)
        BuscarTodos.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        BuscarTodos.TabIndex = 45
        BuscarTodos.Tag = "Cyber"
        BuscarTodos.TextButton = "Buscar Todos"
        BuscarTodos.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        BuscarTodos.Timer_Effect_1 = 5
        BuscarTodos.Timer_RGB = 300
        ' 
        ' Buscar
        ' 
        Buscar.Alpha = 20
        Buscar.BackColor = Color.Transparent
        Buscar.Background = True
        Buscar.Background_WidthPen = 4F
        Buscar.BackgroundPen = True
        Buscar.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        Buscar.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        Buscar.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        Buscar.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        Buscar.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        Buscar.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        Buscar.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        Buscar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        Buscar.Effect_1 = True
        Buscar.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        Buscar.Effect_1_Transparency = 25
        Buscar.Effect_2 = True
        Buscar.Effect_2_ColorBackground = Color.White
        Buscar.Effect_2_Transparency = 20
        Buscar.Font = New Font("Arial", 11F)
        Buscar.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        Buscar.Lighting = False
        Buscar.LinearGradient_Background = False
        Buscar.LinearGradientPen = False
        Buscar.Location = New Point(137, 137)
        Buscar.Name = "Buscar"
        Buscar.PenWidth = 15
        Buscar.Rounding = True
        Buscar.RoundingInt = 70
        Buscar.Size = New Size(134, 43)
        Buscar.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Buscar.TabIndex = 44
        Buscar.Tag = "Cyber"
        Buscar.TextButton = "Buscar Uno"
        Buscar.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Buscar.Timer_Effect_1 = 5
        Buscar.Timer_RGB = 300
        ' 
        ' MaterialListView1
        ' 
        MaterialListView1.AutoSizeTable = False
        MaterialListView1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialListView1.BorderStyle = BorderStyle.None
        MaterialListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader5, ColumnHeader6, ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        MaterialListView1.Depth = 0
        MaterialListView1.FullRowSelect = True
        MaterialListView1.Location = New Point(181, 205)
        MaterialListView1.MinimumSize = New Size(200, 100)
        MaterialListView1.MouseLocation = New Point(-1, -1)
        MaterialListView1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT
        MaterialListView1.Name = "MaterialListView1"
        MaterialListView1.OwnerDraw = True
        MaterialListView1.Size = New Size(574, 242)
        MaterialListView1.TabIndex = 43
        MaterialListView1.UseCompatibleStateImageBehavior = False
        MaterialListView1.View = View.Details
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Fecha"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = ""
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Entrada"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = ""
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Salida"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Observación"
        ColumnHeader4.Width = 120
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Location = New Point(198, 450)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(0, 28)
        LabelTotal.TabIndex = 40
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(181, 205)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(574, 235)
        DataGridView1.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(484, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 28)
        Label4.TabIndex = 37
        Label4.Text = "Desde:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(134, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(203, 28)
        Label3.TabIndex = 33
        Label3.Text = "Código de marcación:"
        ' 
        ' Personal
        ' 
        Personal.Controls.Add(CodigosComboBox)
        Personal.Controls.Add(Label2)
        Personal.Controls.Add(btnEliminarRegistro)
        Personal.Controls.Add(btnCancelarCambios)
        Personal.Controls.Add(btnGuardarCambios)
        Personal.Controls.Add(btnCrearPersonal)
        Personal.Controls.Add(DataGridView2)
        Personal.Controls.Add(BigLabel2)
        Personal.Location = New Point(0, 40)
        Personal.Name = "Personal"
        Personal.Padding = New Padding(3)
        Personal.Size = New Size(914, 606)
        Personal.TabIndex = 1
        Personal.Text = "Personal"
        Personal.UseVisualStyleBackColor = True
        ' 
        ' CodigosComboBox
        ' 
        CodigosComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CodigosComboBox.Font = New Font("Segoe UI", 10F)
        CodigosComboBox.FormattingEnabled = True
        CodigosComboBox.Location = New Point(279, 106)
        CodigosComboBox.Name = "CodigosComboBox"
        CodigosComboBox.Size = New Size(80, 31)
        CodigosComboBox.TabIndex = 69
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(116, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 28)
        Label2.TabIndex = 66
        Label2.Text = "Eliminar Registro:"
        ' 
        ' btnEliminarRegistro
        ' 
        btnEliminarRegistro.BackColor = Color.Transparent
        btnEliminarRegistro.BorderColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnEliminarRegistro.EnteredBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarRegistro.EnteredColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarRegistro.Font = New Font("Microsoft Sans Serif", 10F)
        btnEliminarRegistro.Image = Nothing
        btnEliminarRegistro.ImageAlign = ContentAlignment.MiddleLeft
        btnEliminarRegistro.InactiveColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnEliminarRegistro.Location = New Point(368, 104)
        btnEliminarRegistro.Name = "btnEliminarRegistro"
        btnEliminarRegistro.PressedBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarRegistro.PressedColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarRegistro.Size = New Size(89, 35)
        btnEliminarRegistro.TabIndex = 65
        btnEliminarRegistro.Text = "Eliminar"
        btnEliminarRegistro.TextAlignment = StringAlignment.Center
        ' 
        ' btnCancelarCambios
        ' 
        btnCancelarCambios.Alpha = 20
        btnCancelarCambios.BackColor = Color.Transparent
        btnCancelarCambios.Background = True
        btnCancelarCambios.Background_WidthPen = 4F
        btnCancelarCambios.BackgroundPen = True
        btnCancelarCambios.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnCancelarCambios.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnCancelarCambios.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnCancelarCambios.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        btnCancelarCambios.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnCancelarCambios.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnCancelarCambios.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnCancelarCambios.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnCancelarCambios.Effect_1 = True
        btnCancelarCambios.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnCancelarCambios.Effect_1_Transparency = 25
        btnCancelarCambios.Effect_2 = True
        btnCancelarCambios.Effect_2_ColorBackground = Color.White
        btnCancelarCambios.Effect_2_Transparency = 20
        btnCancelarCambios.Font = New Font("Arial", 11F)
        btnCancelarCambios.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnCancelarCambios.Lighting = False
        btnCancelarCambios.LinearGradient_Background = False
        btnCancelarCambios.LinearGradientPen = False
        btnCancelarCambios.Location = New Point(639, 507)
        btnCancelarCambios.Name = "btnCancelarCambios"
        btnCancelarCambios.PenWidth = 15
        btnCancelarCambios.Rounding = True
        btnCancelarCambios.RoundingInt = 70
        btnCancelarCambios.Size = New Size(137, 45)
        btnCancelarCambios.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnCancelarCambios.TabIndex = 62
        btnCancelarCambios.Tag = "Cyber"
        btnCancelarCambios.TextButton = "Cancelar"
        btnCancelarCambios.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnCancelarCambios.Timer_Effect_1 = 5
        btnCancelarCambios.Timer_RGB = 300
        btnCancelarCambios.Visible = False
        ' 
        ' btnGuardarCambios
        ' 
        btnGuardarCambios.Alpha = 20
        btnGuardarCambios.BackColor = Color.Transparent
        btnGuardarCambios.Background = True
        btnGuardarCambios.Background_WidthPen = 4F
        btnGuardarCambios.BackgroundPen = True
        btnGuardarCambios.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnGuardarCambios.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnGuardarCambios.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnGuardarCambios.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        btnGuardarCambios.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnGuardarCambios.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnGuardarCambios.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnGuardarCambios.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnGuardarCambios.Effect_1 = True
        btnGuardarCambios.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnGuardarCambios.Effect_1_Transparency = 25
        btnGuardarCambios.Effect_2 = True
        btnGuardarCambios.Effect_2_ColorBackground = Color.White
        btnGuardarCambios.Effect_2_Transparency = 20
        btnGuardarCambios.Font = New Font("Arial", 11F)
        btnGuardarCambios.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnGuardarCambios.Lighting = False
        btnGuardarCambios.LinearGradient_Background = False
        btnGuardarCambios.LinearGradientPen = False
        btnGuardarCambios.Location = New Point(139, 507)
        btnGuardarCambios.Name = "btnGuardarCambios"
        btnGuardarCambios.PenWidth = 15
        btnGuardarCambios.Rounding = True
        btnGuardarCambios.RoundingInt = 70
        btnGuardarCambios.Size = New Size(198, 45)
        btnGuardarCambios.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnGuardarCambios.TabIndex = 61
        btnGuardarCambios.Tag = "Cyber"
        btnGuardarCambios.TextButton = "Guardar Cambios"
        btnGuardarCambios.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnGuardarCambios.Timer_Effect_1 = 5
        btnGuardarCambios.Timer_RGB = 300
        btnGuardarCambios.Visible = False
        ' 
        ' btnCrearPersonal
        ' 
        btnCrearPersonal.BackColor = Color.Transparent
        btnCrearPersonal.BorderColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnCrearPersonal.EnteredBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnCrearPersonal.EnteredColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnCrearPersonal.Font = New Font("Microsoft Sans Serif", 12F)
        btnCrearPersonal.Image = Nothing
        btnCrearPersonal.ImageAlign = ContentAlignment.MiddleLeft
        btnCrearPersonal.InactiveColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnCrearPersonal.Location = New Point(660, 34)
        btnCrearPersonal.Name = "btnCrearPersonal"
        btnCrearPersonal.PressedBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnCrearPersonal.PressedColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnCrearPersonal.Size = New Size(191, 40)
        btnCrearPersonal.TabIndex = 59
        btnCrearPersonal.Text = "Registrar Personal"
        btnCrearPersonal.TextAlignment = StringAlignment.Center
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToOrderColumns = True
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {cod_marcacion, nombre, apellido, cedula})
        DataGridView2.Location = New Point(139, 175)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(637, 308)
        DataGridView2.TabIndex = 58
        ' 
        ' cod_marcacion
        ' 
        cod_marcacion.HeaderText = "Código de Marcación"
        cod_marcacion.MinimumWidth = 6
        cod_marcacion.Name = "cod_marcacion"
        cod_marcacion.ReadOnly = True
        cod_marcacion.Width = 175
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "Nombre"
        nombre.MinimumWidth = 6
        nombre.Name = "nombre"
        nombre.Width = 125
        ' 
        ' apellido
        ' 
        apellido.HeaderText = "Apellido"
        apellido.MinimumWidth = 6
        apellido.Name = "apellido"
        apellido.Width = 125
        ' 
        ' cedula
        ' 
        cedula.HeaderText = "Cédula"
        cedula.MinimumWidth = 6
        cedula.Name = "cedula"
        cedula.Width = 125
        ' 
        ' BigLabel2
        ' 
        BigLabel2.AutoSize = True
        BigLabel2.BackColor = Color.Transparent
        BigLabel2.Font = New Font("Segoe UI", 25F)
        BigLabel2.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel2.Location = New Point(58, 17)
        BigLabel2.Name = "BigLabel2"
        BigLabel2.Size = New Size(182, 57)
        BigLabel2.TabIndex = 55
        BigLabel2.Text = "Personal"
        ' 
        ' Archivos
        ' 
        Archivos.Controls.Add(Label1)
        Archivos.Controls.Add(ProgressBar1)
        Archivos.Controls.Add(Label6)
        Archivos.Controls.Add(btnCancelar)
        Archivos.Controls.Add(btnProcesarArchivo)
        Archivos.Controls.Add(btnAbrirArchivo)
        Archivos.Controls.Add(BigLabel3)
        Archivos.Controls.Add(Label5)
        Archivos.Location = New Point(0, 40)
        Archivos.Name = "Archivos"
        Archivos.Padding = New Padding(3)
        Archivos.Size = New Size(914, 606)
        Archivos.TabIndex = 2
        Archivos.Text = "Archivos"
        Archivos.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(120, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 28)
        Label1.TabIndex = 58
        Label1.Text = "Escoja un archivo:"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(264, 369)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(375, 29)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 57
        ProgressBar1.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(368, 325)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 28)
        Label6.TabIndex = 56
        Label6.Text = "Procesando Datos"
        Label6.Visible = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Alpha = 20
        btnCancelar.BackColor = Color.Transparent
        btnCancelar.Background = True
        btnCancelar.Background_WidthPen = 4F
        btnCancelar.BackgroundPen = True
        btnCancelar.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnCancelar.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnCancelar.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnCancelar.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        btnCancelar.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnCancelar.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnCancelar.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnCancelar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnCancelar.Effect_1 = True
        btnCancelar.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnCancelar.Effect_1_Transparency = 25
        btnCancelar.Effect_2 = True
        btnCancelar.Effect_2_ColorBackground = Color.White
        btnCancelar.Effect_2_Transparency = 20
        btnCancelar.Font = New Font("Arial", 11F)
        btnCancelar.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnCancelar.Lighting = False
        btnCancelar.LinearGradient_Background = False
        btnCancelar.LinearGradientPen = False
        btnCancelar.Location = New Point(706, 98)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.PenWidth = 15
        btnCancelar.Rounding = True
        btnCancelar.RoundingInt = 70
        btnCancelar.Size = New Size(108, 43)
        btnCancelar.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnCancelar.TabIndex = 51
        btnCancelar.Tag = "Cyber"
        btnCancelar.TextButton = "Cancelar"
        btnCancelar.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnCancelar.Timer_Effect_1 = 5
        btnCancelar.Timer_RGB = 300
        btnCancelar.Visible = False
        ' 
        ' btnProcesarArchivo
        ' 
        btnProcesarArchivo.Alpha = 20
        btnProcesarArchivo.BackColor = Color.Transparent
        btnProcesarArchivo.Background = True
        btnProcesarArchivo.Background_WidthPen = 4F
        btnProcesarArchivo.BackgroundPen = True
        btnProcesarArchivo.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnProcesarArchivo.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnProcesarArchivo.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnProcesarArchivo.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        btnProcesarArchivo.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnProcesarArchivo.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnProcesarArchivo.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnProcesarArchivo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnProcesarArchivo.Effect_1 = True
        btnProcesarArchivo.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnProcesarArchivo.Effect_1_Transparency = 25
        btnProcesarArchivo.Effect_2 = True
        btnProcesarArchivo.Effect_2_ColorBackground = Color.White
        btnProcesarArchivo.Effect_2_Transparency = 20
        btnProcesarArchivo.Font = New Font("Arial", 11F)
        btnProcesarArchivo.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnProcesarArchivo.Lighting = False
        btnProcesarArchivo.LinearGradient_Background = False
        btnProcesarArchivo.LinearGradientPen = False
        btnProcesarArchivo.Location = New Point(581, 98)
        btnProcesarArchivo.Name = "btnProcesarArchivo"
        btnProcesarArchivo.PenWidth = 15
        btnProcesarArchivo.Rounding = True
        btnProcesarArchivo.RoundingInt = 70
        btnProcesarArchivo.Size = New Size(108, 43)
        btnProcesarArchivo.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnProcesarArchivo.TabIndex = 50
        btnProcesarArchivo.Tag = "Cyber"
        btnProcesarArchivo.TextButton = "Procesar"
        btnProcesarArchivo.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnProcesarArchivo.Timer_Effect_1 = 5
        btnProcesarArchivo.Timer_RGB = 300
        btnProcesarArchivo.Visible = False
        ' 
        ' btnAbrirArchivo
        ' 
        btnAbrirArchivo.Alpha = 20
        btnAbrirArchivo.BackColor = Color.Transparent
        btnAbrirArchivo.Background = True
        btnAbrirArchivo.Background_WidthPen = 4F
        btnAbrirArchivo.BackgroundPen = True
        btnAbrirArchivo.ColorBackground = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnAbrirArchivo.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnAbrirArchivo.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnAbrirArchivo.ColorBackground_Pen = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        btnAbrirArchivo.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnAbrirArchivo.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnAbrirArchivo.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnAbrirArchivo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnAbrirArchivo.Effect_1 = True
        btnAbrirArchivo.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnAbrirArchivo.Effect_1_Transparency = 25
        btnAbrirArchivo.Effect_2 = True
        btnAbrirArchivo.Effect_2_ColorBackground = Color.White
        btnAbrirArchivo.Effect_2_Transparency = 20
        btnAbrirArchivo.Font = New Font("Arial", 11F)
        btnAbrirArchivo.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnAbrirArchivo.Lighting = False
        btnAbrirArchivo.LinearGradient_Background = False
        btnAbrirArchivo.LinearGradientPen = False
        btnAbrirArchivo.Location = New Point(299, 98)
        btnAbrirArchivo.Name = "btnAbrirArchivo"
        btnAbrirArchivo.PenWidth = 15
        btnAbrirArchivo.Rounding = True
        btnAbrirArchivo.RoundingInt = 70
        btnAbrirArchivo.Size = New Size(137, 43)
        btnAbrirArchivo.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnAbrirArchivo.TabIndex = 49
        btnAbrirArchivo.Tag = "Cyber"
        btnAbrirArchivo.TextButton = "Abrir Archivo"
        btnAbrirArchivo.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnAbrirArchivo.Timer_Effect_1 = 5
        btnAbrirArchivo.Timer_RGB = 300
        ' 
        ' BigLabel3
        ' 
        BigLabel3.AutoSize = True
        BigLabel3.BackColor = Color.Transparent
        BigLabel3.Font = New Font("Segoe UI", 25F)
        BigLabel3.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel3.Location = New Point(60, 19)
        BigLabel3.Name = "BigLabel3"
        BigLabel3.Size = New Size(336, 57)
        BigLabel3.TabIndex = 48
        BigLabel3.Text = "Procesar Archivo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(120, 163)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 28)
        Label5.TabIndex = 47
        ' 
        ' Dias
        ' 
        Dias.Controls.Add(FechasComboBox)
        Dias.Controls.Add(Label7)
        Dias.Controls.Add(btnEliminarDia)
        Dias.Controls.Add(btnCrearDia)
        Dias.Controls.Add(DataGridView3)
        Dias.Controls.Add(BigLabel4)
        Dias.Location = New Point(0, 40)
        Dias.Name = "Dias"
        Dias.Padding = New Padding(3)
        Dias.Size = New Size(914, 606)
        Dias.TabIndex = 3
        Dias.Text = "Días Libres"
        Dias.UseVisualStyleBackColor = True
        ' 
        ' FechasComboBox
        ' 
        FechasComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        FechasComboBox.Font = New Font("Segoe UI", 10F)
        FechasComboBox.FormattingEnabled = True
        FechasComboBox.Location = New Point(251, 110)
        FechasComboBox.Name = "FechasComboBox"
        FechasComboBox.Size = New Size(124, 31)
        FechasComboBox.TabIndex = 72
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(110, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 28)
        Label7.TabIndex = 71
        Label7.Text = "Eliminar Fecha:"
        ' 
        ' btnEliminarDia
        ' 
        btnEliminarDia.BackColor = Color.Transparent
        btnEliminarDia.BorderColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnEliminarDia.EnteredBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarDia.EnteredColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarDia.Font = New Font("Microsoft Sans Serif", 10F)
        btnEliminarDia.Image = Nothing
        btnEliminarDia.ImageAlign = ContentAlignment.MiddleLeft
        btnEliminarDia.InactiveColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnEliminarDia.Location = New Point(387, 106)
        btnEliminarDia.Name = "btnEliminarDia"
        btnEliminarDia.PressedBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarDia.PressedColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnEliminarDia.Size = New Size(89, 35)
        btnEliminarDia.TabIndex = 70
        btnEliminarDia.Text = "Eliminar"
        btnEliminarDia.TextAlignment = StringAlignment.Center
        ' 
        ' btnCrearDia
        ' 
        btnCrearDia.BackColor = Color.Transparent
        btnCrearDia.BorderColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnCrearDia.EnteredBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnCrearDia.EnteredColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnCrearDia.Font = New Font("Microsoft Sans Serif", 12F)
        btnCrearDia.Image = Nothing
        btnCrearDia.ImageAlign = ContentAlignment.MiddleLeft
        btnCrearDia.InactiveColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnCrearDia.Location = New Point(662, 39)
        btnCrearDia.Name = "btnCrearDia"
        btnCrearDia.PressedBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnCrearDia.PressedColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        btnCrearDia.Size = New Size(172, 40)
        btnCrearDia.TabIndex = 60
        btnCrearDia.Text = "Crear Día Libre"
        btnCrearDia.TextAlignment = StringAlignment.Center
        btnCrearDia.UseWaitCursor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {Fecha, Detalle})
        DataGridView3.Location = New Point(142, 173)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.Size = New Size(643, 268)
        DataGridView3.TabIndex = 50
        ' 
        ' Fecha
        ' 
        Fecha.HeaderText = "Fecha"
        Fecha.MinimumWidth = 6
        Fecha.Name = "Fecha"
        Fecha.ReadOnly = True
        Fecha.Width = 125
        ' 
        ' Detalle
        ' 
        Detalle.HeaderText = "Detalle"
        Detalle.MinimumWidth = 6
        Detalle.Name = "Detalle"
        Detalle.ReadOnly = True
        Detalle.Width = 125
        ' 
        ' BigLabel4
        ' 
        BigLabel4.AutoSize = True
        BigLabel4.BackColor = Color.Transparent
        BigLabel4.Font = New Font("Segoe UI", 25F)
        BigLabel4.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        BigLabel4.Location = New Point(56, 22)
        BigLabel4.Name = "BigLabel4"
        BigLabel4.Size = New Size(225, 57)
        BigLabel4.TabIndex = 49
        BigLabel4.Text = "Días Libres"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(914, 646)
        Controls.Add(HopeTabPage1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistema de Registros"
        TransparencyKey = Color.Fuchsia
        HopeTabPage1.ResumeLayout(False)
        Consultas.ResumeLayout(False)
        Consultas.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Personal.ResumeLayout(False)
        Personal.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Archivos.ResumeLayout(False)
        Archivos.PerformLayout()
        Dias.ResumeLayout(False)
        Dias.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents HopeTabPage1 As ReaLTaiizor.Controls.HopeTabPage
    Friend WithEvents Consultas As TabPage
    Friend WithEvents Personal As TabPage
    Friend WithEvents LabelTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialListView1 As ReaLTaiizor.Controls.MaterialListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Buscar As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents BuscarTodos As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents Archivos As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As ReaLTaiizor.Controls.AloneTextBox
    Friend WithEvents PoisonDateTime1 As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents BigLabel1 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents BigLabel2 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnCrearPersonal As ReaLTaiizor.Controls.Button
    Friend WithEvents cod_marcacion As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardarCambios As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents btnCancelarCambios As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents btnEliminarRegistro As ReaLTaiizor.Controls.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CodigosComboBox As ComboBox
    Friend WithEvents BigLabel3 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents btnAbrirArchivo As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents btnProcesarArchivo As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents btnCancelar As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Dias As TabPage
    Friend WithEvents BigLabel4 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnCrearDia As ReaLTaiizor.Controls.Button
    Friend WithEvents FechasComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEliminarDia As ReaLTaiizor.Controls.Button
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Detalle As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PoisonDateTime2 As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label10 As Label

End Class
