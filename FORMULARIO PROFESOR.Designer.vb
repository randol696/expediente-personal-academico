<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMULARIO_PROFESOR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORMULARIO_PROFESOR))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbIMAGEN = New System.Windows.Forms.PictureBox()
        Me.btnEXAMINAR = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEdad = New System.Windows.Forms.ComboBox()
        Me.btnValidarTelefono = New System.Windows.Forms.Button()
        Me.btnValidarCorreo = New System.Windows.Forms.Button()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.cbGENERO = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVALIDAR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.btnGenerarCarnet = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCURSO = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbComarca = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbPAIS = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnOTROS = New System.Windows.Forms.Button()
        Me.btnPREGUARDAR = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.btnGUARDAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIMAGEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(734, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(566, 37)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "INGRESO DE DATOS DE PROFESOR"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox2.Location = New System.Drawing.Point(1712, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox1.Location = New System.Drawing.Point(48, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'pbIMAGEN
        '
        Me.pbIMAGEN.Image = Global.WindowsApp1.My.Resources.Resources.CARNET
        Me.pbIMAGEN.Location = New System.Drawing.Point(1521, 239)
        Me.pbIMAGEN.Name = "pbIMAGEN"
        Me.pbIMAGEN.Size = New System.Drawing.Size(349, 433)
        Me.pbIMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIMAGEN.TabIndex = 106
        Me.pbIMAGEN.TabStop = False
        '
        'btnEXAMINAR
        '
        Me.btnEXAMINAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEXAMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEXAMINAR.FlatAppearance.BorderSize = 2
        Me.btnEXAMINAR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXAMINAR.ForeColor = System.Drawing.Color.White
        Me.btnEXAMINAR.Location = New System.Drawing.Point(1563, 697)
        Me.btnEXAMINAR.Name = "btnEXAMINAR"
        Me.btnEXAMINAR.Size = New System.Drawing.Size(259, 104)
        Me.btnEXAMINAR.TabIndex = 107
        Me.btnEXAMINAR.Text = "SELECIONAR IMAGEN"
        Me.btnEXAMINAR.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(407, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1186, 68)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "INSTITUTO SUPERIOR CYC TECHNOLOGIES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEdad)
        Me.GroupBox1.Controls.Add(Me.btnValidarTelefono)
        Me.GroupBox1.Controls.Add(Me.btnValidarCorreo)
        Me.GroupBox1.Controls.Add(Me.txtApellido2)
        Me.GroupBox1.Controls.Add(Me.txtNombre2)
        Me.GroupBox1.Controls.Add(Me.cbGENERO)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnVALIDAR)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElectronico)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1442, 371)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN PERSONAL DE PROFESOR (A)"
        '
        'cbEdad
        '
        Me.cbEdad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEdad.FormattingEnabled = True
        Me.cbEdad.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cbEdad.Location = New System.Drawing.Point(963, 96)
        Me.cbEdad.Name = "cbEdad"
        Me.cbEdad.Size = New System.Drawing.Size(121, 35)
        Me.cbEdad.TabIndex = 54
        '
        'btnValidarTelefono
        '
        Me.btnValidarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnValidarTelefono.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnValidarTelefono.FlatAppearance.BorderSize = 2
        Me.btnValidarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnValidarTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarTelefono.ForeColor = System.Drawing.Color.White
        Me.btnValidarTelefono.Location = New System.Drawing.Point(424, 301)
        Me.btnValidarTelefono.Name = "btnValidarTelefono"
        Me.btnValidarTelefono.Size = New System.Drawing.Size(382, 47)
        Me.btnValidarTelefono.TabIndex = 53
        Me.btnValidarTelefono.Text = "VALIDAR TELÉFONO"
        Me.btnValidarTelefono.UseVisualStyleBackColor = False
        '
        'btnValidarCorreo
        '
        Me.btnValidarCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnValidarCorreo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnValidarCorreo.FlatAppearance.BorderSize = 2
        Me.btnValidarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnValidarCorreo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarCorreo.ForeColor = System.Drawing.Color.White
        Me.btnValidarCorreo.Location = New System.Drawing.Point(672, 229)
        Me.btnValidarCorreo.Name = "btnValidarCorreo"
        Me.btnValidarCorreo.Size = New System.Drawing.Size(344, 47)
        Me.btnValidarCorreo.TabIndex = 52
        Me.btnValidarCorreo.Text = "VALIDAR CORREO"
        Me.btnValidarCorreo.UseVisualStyleBackColor = False
        '
        'txtApellido2
        '
        Me.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(1210, 34)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(193, 35)
        Me.txtApellido2.TabIndex = 51
        '
        'txtNombre2
        '
        Me.txtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(371, 38)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(193, 35)
        Me.txtNombre2.TabIndex = 50
        '
        'cbGENERO
        '
        Me.cbGENERO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGENERO.FormattingEnabled = True
        Me.cbGENERO.Items.AddRange(New Object() {"MASCULINO", "FEMENINO "})
        Me.cbGENERO.Location = New System.Drawing.Point(148, 166)
        Me.cbGENERO.Name = "cbGENERO"
        Me.cbGENERO.Size = New System.Drawing.Size(235, 35)
        Me.cbGENERO.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 27)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "GÉNERO:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(175, 310)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(230, 35)
        Me.txtTelefono.TabIndex = 26
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(1006, 34)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(193, 35)
        Me.txtApellido.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRES:"
        '
        'btnVALIDAR
        '
        Me.btnVALIDAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVALIDAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVALIDAR.FlatAppearance.BorderSize = 2
        Me.btnVALIDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVALIDAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVALIDAR.ForeColor = System.Drawing.Color.White
        Me.btnVALIDAR.Location = New System.Drawing.Point(355, 88)
        Me.btnVALIDAR.Name = "btnVALIDAR"
        Me.btnVALIDAR.Size = New System.Drawing.Size(418, 47)
        Me.btnVALIDAR.TabIndex = 42
        Me.btnVALIDAR.Text = "VALIDAR CÉDULA"
        Me.btnVALIDAR.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(850, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "APELLIDOS:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(159, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 35)
        Me.txtNombre.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(302, 27)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CORREO ELECTRÓNICO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CÉDULA:"
        '
        'txtCedula
        '
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(148, 100)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(201, 35)
        Me.txtCedula.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 27)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "TELÉFONO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(864, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "EDAD:"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreoElectronico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(328, 237)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(323, 35)
        Me.txtCorreoElectronico.TabIndex = 25
        '
        'btnGenerarCarnet
        '
        Me.btnGenerarCarnet.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerarCarnet.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGenerarCarnet.FlatAppearance.BorderSize = 2
        Me.btnGenerarCarnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerarCarnet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCarnet.ForeColor = System.Drawing.Color.White
        Me.btnGenerarCarnet.Location = New System.Drawing.Point(670, 167)
        Me.btnGenerarCarnet.Name = "btnGenerarCarnet"
        Me.btnGenerarCarnet.Size = New System.Drawing.Size(472, 47)
        Me.btnGenerarCarnet.TabIndex = 118
        Me.btnGenerarCarnet.Text = "GENERAR CARNET"
        Me.btnGenerarCarnet.UseVisualStyleBackColor = False
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(532, 176)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 35)
        Me.txtNumero.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(449, 27)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "NÚMERO DE CARNET DE PROFESOR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 849)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 27)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "CURSO:"
        '
        'cbCURSO
        '
        Me.cbCURSO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCURSO.FormattingEnabled = True
        Me.cbCURSO.Items.AddRange(New Object() {"ÁREA DE IDIOMAS E INGLÉS ESPECIALIZADO", "TÉCNICO SUPERIOR EN INGLÉS COMPUTACIONAL PARA DOCENTE", "I CUATRIMESTRE", "INGLÉS INTEGRADO I", "FONÉTICA Y FONOLOGÍA INGLESA", "FUNDAMENTOS DE LA EDUCACIÓN BÁSICA", "INFORMÁTICA GENERAL PARA DOCENTES", "II CUATRIMESTRE", "INGLÉS INTEGRADO II", "GRAMÁTICA INGLESA APLICADA", "METODOLOGÍA DE LA ENSEÑANZA DEL IDIOMA", "HERRAMIENTAS TECNOLÓGICAS DE SOPORTE EDUCATIVO", "III CUATRIMESTRE", "PLANIFICACIÓN CURRICULAR DEL IDIOMA", "CREACIÓN Y EVALUACIÓN DE RECURSOS DIDÁCTICOS DIGITALES EN INGLÉS", "LITERATURA INFANTIL EN INGLÉS", "IV CUATRIMESTRE", "EVALUACIÓN DEL APRENDIZAJE LINGÜÍSTICO", "SOFTWARE EDUCATIVO PARA LA ENSEÑANZA DE IDIOMAS", "PROYECTO FINAL Y PRÁCTICA DOCENTE BILINGÜE ASISTIDA", "", "TÉCNICO SUPERIOR EN INGLÉS COMPUTACIONAL", "I CUATRIMESTRE", "INGLÉS TÉCNICO I", "INTRODUCCIÓN A LA INFORMÁTICA", "GRAMÁTICA ESTRUCTURAL Y COMPRENSIÓN LECTORAS", "HERRAMIENTAS DE OFIMÁTICA", "II CUATRIMESTRE", "INGLÉS TÉCNICO II", "REDACCIÓN DE INFORMES TÉCNICOS", "PRINCIPIOS DE SISTEMAS OPERATIVOS", "VOCABULARIO INFORMÁTICO Y DE SOPORTE", "III CUATRIMESTRE", "COMUNICACIÓN ORAL EN ENTORNOS TECNOLÓGICOS", "SOPORTE TÉCNICO BILINGÜE", "GESTIÓN DE DOCUMENTACIÓN DIGITAL", "TÉCNICAS DE TRADUCCIÓN TÉCNICA", "IV CUATRIMESTRE", "INGLÉS PARA NEGOCIOS Y CORPORACIONES TECNOLÓGICAS", "ADMINISTRACIÓN DE PLATAFORMAS VIRTUALES AVANZADAS", "PROYECTO INTEGRADOR", "PRÁCTICA TÉCNICA EXTERNA", "", "TÉCNICO SUPERIOR EN INGLÉS CONVERSACIONAL", "I CUATRIMESTRE", "LISTENING AND SPEAKING I", "READING AND WRITING I", "FONÉTICA PRÁCTICA DEL INGLÉS", "EXPRESIÓN ORAL Y MODISMOS BÁSICOS", "II CUATRIMESTRE", "LISTENING AND SPEAKING II", "CONVERSACIÓN FLUIDA INTERMEDIA", "GRAMÁTICA COMUNICATIVA", "EXPRESIONES CULTURALES ANGLOFONAS", "III CUATRIMESTRE", "TÉCNICAS DE DEBATE Y ARGUMENTACIÓN", "ESTRATEGIAS DE FLUIDEZ VERBAL AVANZADA", "INGLÉS PARA LA COMUNICACIÓN GLOBAL", "REDACCIÓN ESTRUCTURADA", "IV CUATRIMESTRE", "TÉCNICAS DE NEGOCIACIÓN Y ORATORIA EN INGLÉS", "TALLER DE CONVERSACIÓN AVANZADA EN ENTORNOS DE NEGOCIOS", "SEMINARIO PROFESIONAL", "EXAMEN FINAL ORAL", "", "ÁREA DE CUIDADO INFANTIL Y EDUCACIÓN PRIMARIA", "", "TÉCNICO SUPERIOR EN CUIDADOS DEL INFANTE #1", "(ENFOQUE: CUIDADO DEL RECIÉN NACIDO, SALUD MATERNA Y LACTANCIA)", "I CUATRIMESTRE", "PSICOLOGÍA EVOLUTIVA DEL INFANTE", "NUTRICIÓN Y SALUD MATERNO-INFANTIL", "FUNDAMENTOS DE LA ATENCIÓN A LA PRIMERA INFANCIA", "PRIMEROS AUXILIOS PEDIÁTRICOS", "II CUATRIMESTRE", "ESTIMULACIÓN TEMPRANA I", "DESARROLLO SOCIOAFECTIVO Y MORAL EN LACTANTES", "CUIDADO DE LA SALUD E HIGIENE DEL NEONATO", "EXPRESIÓN PLÁSTICA INFANTIL", "III CUATRIMESTRE", "PLANIFICACIÓN DE RUTINAS DE CUIDADO DIARIO", "LITERATURA Y CUENTACUENTOS EN LA INFANCIA", "PSICOMOTRICIDAD FINA Y GRUESA I", "EXPRESIÓN CORPORAL", "IV CUATRIMESTRE", "ORGANIZACIÓN Y NORMAS DE CENTROS DE CUIDADO", "TALLER DE MATERIALES DIDÁCTICOS DE RECICLAJE", "RELACIÓN FAMILIA-CUIDADOR", "PRÁCTICA PROFESIONAL EN GUARDERÍAS", "", "TÉCNICO SUPERIOR EN CUIDADOS DEL INFANTE #2", "(ENFOQUE: DESARROLLO COGNITIVO, CONDUCTA Y CENTROS DE ESTIMULACIÓN TEMPRANA)", "I CUATRIMESTRE", "INTRODUCCIÓN A LA PSICOLOGÍA EDUCATIVA", "FUNDAMENTOS DE LA EDUCACIÓN PARVULARIA", "CUIDADO GENERAL Y SALUD INFANTIL", "PRIMEROS AUXILIOS INFANTILES", "II CUATRIMESTRE", "MODIFICACIÓN DE CONDUCTA Y DESARROLLO SOCIOAFECTIVO", "TÉCNICAS DE ESTIMULACIÓN TEMPRANA II", "JUEGOS CLÍNICOS Y RECREATIVOS", "CUIDADO DE LA HIGIENE ESCOLAR", "III CUATRIMESTRE", "DETECCIÓN DE PROBLEMAS DEL DESARROLLO INFANTIL", "PSICOMOTRICIDAD FINA Y GRUESA II", "LITERATURA Y EXPRESIÓN MUSICAL INFANTIL", "PLANIFICACIÓN DE ACTIVIDADES", "IV CUATRIMESTRE", "ADMINISTRACIÓN Y GESTIÓN DE CENTROS DE ESTIMULACIÓN INFANTIL", "ÉTICA EN EL CUIDADO DEL INFANTE", "TALLER DE RELACIÓN ESCUELA-FAMILIA", "PRÁCTICA PROFESIONAL DIRIGIDA", "", "TÉCNICO SUPERIOR EN INFORMÁTICA PARA LA APLICACIÓN PARA LA EDUCACIÓN", "I CUATRIMESTRE", "INTRODUCCIÓN A LA INFORMÁTICA", "USO DE INTERNET Y NAVEGACIÓN SEGURA", "PEDAGOGÍA GENERAL", "TEORÍAS CONTEMPORÁNEAS DEL APRENDIZAJE", "II CUATRIMESTRE", "DESARROLLO Y EVALUACIÓN DE SOFTWARE EDUCATIVO", "GESTIÓN DE PLATAFORMAS VIRTUALES DE APRENDIZAJE (LMS)", "RECURSOS MULTIMEDIA EDUCATIVOS", "DIDÁCTICA TECNOLÓGICA APLICADA", "III CUATRIMESTRE", "ENTORNOS VIRTUALES DE APRENDIZAJE (EVA)", "DISEÑO CURRICULAR COMPUTACIONAL", "GAMIFICACIÓN Y APRENDIZAJE BASADO EN JUEGOS", "HERRAMIENTAS DEL DOCENTE DIGITAL", "IV CUATRIMESTRE", "FORMULACIÓN DE PROYECTOS EDUCATIVOS DIGITALES", "TALLER DE CREACIÓN DE CONTENIDOS INTERACTIVOS", "SEMINARIO DE INNOVACIÓN", "PRÁCTICA SUPERVISADA EN AULA", "", "ÁREA DE TECNOLOGÍA Y SISTEMAS INFORMÁTICOS", "", "TÉCNICO SUPERIOR EN SISTEMAS INFORMÁTICOS", "I CUATRIMESTRE", "COMUNICACIÓN ORAL Y ESCRITA", "INTRODUCCIÓN A LA INFORMÁTICA", "FUNDAMENTOS DE LA ADMINISTRACIÓN", "INGLÉS BÁSICO", "INTRODUCCIÓN A LAS TECNOLOGÍAS WEB", "II CUATRIMESTRE", "ARQUITECTURA Y ENSAMBLAJE DEL COMPUTADOR", "LÓGICA DE PROGRAMACIÓN", "ESTRUCTURAS DE DATOS COMPUTACIONALES", "ANÁLISIS DE SISTEMAS", "SISTEMAS OPERATIVOS I", "III CUATRIMESTRE", "REDES Y CONECTIVIDAD", "PROGRAMACIÓN ORIENTADA A OBJETOS", "SISTEMAS DE BASES DE DATOS", "FUNDAMENTOS DE SEGURIDAD INFORMÁTICA", "ÉTICA PROFESIONAL", "IV CUATRIMESTRE", "FORMULACIÓN DE PROYECTOS TECNOLÓGICOS", "ADMINISTRACIÓN DE SERVIDORES DE RED", "AUDITORÍA BÁSICA DE SISTEMAS", "PRÁCTICA PROFESIONAL DE CAMPO", "", "TÉCNICO SUPERIOR EN ENTORNOS VIRTUALES", "I CUATRIMESTRE", "COMUNICACIÓN ORAL Y ESCRITA 001", "OFIMÁTICA 002", "INTRODUCCIÓN A LOS AMBIENTES VIRTUALES 003", "HISTORIA DE PANAMÁ 019", "II CUATRIMESTRE", "INGLÉS", "LA COMUNICACIÓN EN ENTORNOS VIRTUALES", "TUTORÍA EN ENTORNOS VIRTUALES", "LISTA DE NOTA MATERIAL DIDÁCTICO EN ENTORNOS VIRTUALES I", "III CUATRIMESTRE", "MATERIAL DIDÁCTICO EN ENTORNOS VIRTUALES II", "HERRAMIENTAS TECNOLÓGICAS PARA ENTORNOS VIRTUALES", "EL APRENDIZAJE EN ENTORNOS VIRTUALES", "ÉTICA Y MORAL", "IV CUATRIMESTRE", "MANEJO DE LAS PLATAFORMAS PARA ENTORNOS VIRTUALES", "PLANIFICACIÓN Y EVALUACIÓN DE PROYECTOS", "GEOGRAFÍA DE PANAMÁ", "TRABAJO DE GRADUACIÓN", "", "TÉCNICO SUPERIOR EN SOFTWARE E INTERNET", "I CUATRIMESTRE", "INTRODUCCIÓN A LA COMPUTACIÓN", "ALGORITMOS BÁSICOS", "MATEMÁTICA COMPUTACIONAL", "INGLÉS TÉCNICO PARA DESARROLLADORES", "II CUATRIMESTRE", "LÓGICA DE PROGRAMACIÓN APLICADA", "FUNDAMENTOS Y MODELADO DE BASES DE DATOS", "ENTORNOS DE DESARROLLO DE SOFTWARE", "DISEÑO GRÁFICO E INTERFACES", "III CUATRIMESTRE", "DESARROLLO DE PÁGINAS WEB (HTML5/CSS3/JAVASCRIPT)", "PROGRAMACIÓN PARA INTERNET", "ARQUITECTURA Y SERVIDORES WEB", "INGENIERÍA DE SOFTWARE", "IV CUATRIMESTRE", "FUNDAMENTOS DE COMERCIO ELECTRÓNICO (E-COMMERCE)", "SEGURIDAD EN REDES Y APLICACIONES WEB", "SEMINARIO DE ACTUALIZACIÓN", "PRÁCTICA PROFESIONAL EN DESARROLLO", "", "TÉCNICO SUPERIOR EN TECNOLOGÍA E INFORMÁTICA", "I CUATRIMESTRE", "ESPAÑOL GENERAL", "INTRODUCCIÓN A LA INFORMÁTICA", "FUNDAMENTOS DE TECNOLOGÍA EDUCATIVA", "INGLÉS INICIAL TÉCNICO", "II CUATRIMESTRE", "HERRAMIENTAS DE PRODUCTIVIDAD DE OFICINAS", "PRINCIPIOS DE HARDWARE Y PERIFÉRICOS", "METODOLOGÍAS DE APRENDIZAJE TECNOLÓGICO", "LÓGICA MATEMÁTICA", "III CUATRIMESTRE", "PROGRAMACIÓN BÁSICA DE SCRIPTS", "MULTIMEDIA APLICADA", "CONFIGURACIÓN DE REDES DE ÁREA LOCAL (LAN)", "ADMINISTRACIÓN DE RECURSOS TECNOLÓGICOS", "IV CUATRIMESTRE", "PROYECTOS DE INTEGRACIÓN TECNOLÓGICA", "MANTENIMIENTO PREVENTIVO DE SISTEMAS", "PROYECTO FINAL DE INNOVACIÓN", "PRÁCTICA TÉCNICA SUPERVISADA", "", "ÁREA AMBIENTAL Y DE RECURSOS NATURALES", "", "TÉCNICO SUPERIOR EN GESTIÓN AMBIENTAL", "I CUATRIMESTRE", "COMUNICACIÓN ORAL Y ESCRITA", "INGLÉS BÁSICO AMBIENTAL", "INTRODUCCIÓN A LA BIOLOGÍA GENERAL", "FUNDAMENTOS Y CIENCIAS AMBIENTALES", "II CUATRIMESTRE", "RECURSOS NATURALES Y SOSTENIBILIDAD", "AMBIENTE Y SOCIEDAD", "ECOLOGÍA GENERAL Y DE POBLACIONES", "GEOGRAFÍA FÍSICA DE PANAMÁ", "III CUATRIMESTRE", "EVALUACIÓN DE IMPACTO AMBIENTAL (EIA)", "SISTEMAS DE INFORMACIÓN GEOGRÁFICA (SIG)", "CONSERVACIÓN Y MANEJO DE SUELOS Y AGUAS", "GESTIÓN DE FLORA Y FAUNA", "IV CUATRIMESTRE", "LEGISLACIÓN AMBIENTAL PANAMEÑA", "GESTIÓN Y TRATAMIENTO DE RESIDUOS SÓLIDOS", "AUDITORÍA AMBIENTAL BÁSICA", "PRÁCTICA TÉCNICA DE CAMPO", "", "TÉCNICO SUPERIOR EN RECURSOS NATURALES Y MEDIO AMBIENTE", "I CUATRIMESTRE", "BIOLOGÍA GENERAL", "QUÍMICA AMBIENTAL BÁSICA", "INTRODUCCIÓN AL ESTUDIO DE RECURSOS NATURALES", "ESPAÑOL Y REDACCIÓN TÉCNICA", "II CUATRIMESTRE", "CLIMATOLOGÍA Y METEOROLOGÍA", "ECOLOGÍA DE ECOSISTEMAS TROPICALES", "BOTÁNICA Y ZOOLOGÍA GENERAL DE PANAMÁ", "CARTOGRAFÍA BÁSICA", "III CUATRIMESTRE", "EVALUACIÓN DE IMPACTO AMBIENTAL (EIA)", "MANEJO DE CUENCAS HIDROGRÁFICAS", "CONSERVACIÓN DE SUELOS Y AGUAS", "LEGISLACIÓN DE RECURSOS NATURALES", "IV CUATRIMESTRE", "ÁREAS PROTEGIDAS Y BIODIVERSIDAD", "EDUCACIÓN Y CONCIENCIACIÓN AMBIENTAL", "PROYECTO DE CONSERVACIÓN", "PRÁCTICA PROFESIONAL DE CAMPO", "", "ÁREA ADMINISTRATIVA, COMERCIAL Y DE SALUD", "", "TÉCNICO SUPERIOR EN REGISTROS CONTABLES", "I CUATRIMESTRE", "INTRODUCCIÓN A LA CONTABILIDAD FINANCIERA", "MATEMÁTICA FINANCIERA BÁSICA", "ADMINISTRACIÓN DE EMPRESAS GENERAL", "GESTIÓN DE DOCUMENTACIÓN COMERCIAL", "II CUATRIMESTRE", "CONTABILIDAD DE COSTOS", "SISTEMAS DE INFORMACIÓN CONTABLE (USO DE SOFTWARE)", "LEGISLACIÓN FISCAL E IMPUESTOS PANAMEÑOS", "ESTADÍSTICAS APLICADAS", "III CUATRIMESTRE", "CONTABILIDAD BANCARIA Y COMERCIAL", "PLANILLAS Y PRESTACIONES LABORALES", "CONTROL INTERNO Y AUDITORÍA BÁSICA", "PRESUPUESTOS EMPRESARIALES", "IV CUATRIMESTRE", "ANÁLISIS E INTERPRETACIÓN DE ESTADOS FINANCIEROS", "ÉTICA DEL CONTADOR", "SEMINARIO DE ACTUALIZACIÓN CONTABLE", "PRÁCTICA PROFESIONAL EN CONTABILIDAD", "", "TÉCNICO SUPERIOR EN RELACIONES HUMANAS", "I CUATRIMESTRE", "RELACIONES HUMANAS Y ADMINISTRACIÓN", "PSICOLOGÍA GENERAL", "TÉCNICAS DE COMUNICACIÓN EFECTIVA", "FUNDAMENTOS SOCIOLÓGICOS DE LAS ORGANIZACIONES", "II CUATRIMESTRE", "PSICOLOGÍA LABORAL", "COMPORTAMIENTO ORGANIZACIONAL", "TÉCNICAS DE MOTIVACIÓN Y LIDERAZGO EFICAZ", "DINÁMICAS DE GRUPO Y CONVIVIENCIA", "III CUATRIMESTRE", "GESTIÓN DE CONFLICTOS Y MEDIACIÓN", "CULTURA Y CLIMA ORGANIZACIONAL", "ÉTICA Y VALORES EN EL TRABAJO", "FUNDAMENTOS DE ADMINISTRACIÓN DE RECURSOS HUMANOS", "IV CUATRIMESTRE", "RELACIONES PÚBLICAS EMPRESARIALES", "TALLER DE TRABAJO EN EQUIPO Y PRODUCTIVIDAD", "PROYECTO DE DESARROLLO HUMANO", "PRÁCTICA PROFESIONAL EN RRHH", "", "TÉCNICO SUPERIOR EN SALUD OCUPACIONAL", "I CUATRIMESTRE", "INTRODUCCIÓN A LA SALUD OCUPACIONAL", "ANATOMÍA Y FISIOLOGÍA BÁSICA DE TRABAJO", "PRIMEROS AUXILIOS DE EMERGENCIA", "MARCO LEGAL DE LA SEGURIDAD EN PANAMÁ", "II CUATRIMESTRE", "HIGIENE INDUSTRIAL I (RIESGOS FÍSICOS)", "PREVENCIÓN Y CONTROL DE RIESGOS DE TRABAJO", "ERGONOMÍA LABORAL", "PSICOLOGÍA DE LA SEGURIDAD", "III CUATRIMESTRE", "HIGIENE INDUSTRIAL II (RIESGOS QUÍMICOS/BIOLÓGICOS)", "PLANES DE EMERGENCIA Y EVACUACIÓN", "TÉCNICAS DE INSPECCIÓN DE SEGURIDAD", "MEDICINA DEL TRABAJO", "IV CUATRIMESTRE", "GESTIÓN DE LA SEGURIDAD Y SALUD EN EL TRABAJO (ISO 45001)", "INVESTIGACIÓN DE ACCIDENTES LABORALES", "PROYECTO DE PREVENCIÓN", "PRÁCTICA SUPERVISADA", "", "TÉCNICO SUPERIOR EN TURISMO NACIONAL", "I CUATRIMESTRE", "INTRODUCCIÓN A LA INDUSTRIA DEL TURISMO", "GEOGRAFÍA TURÍSTICA DE PANAMÁ", "INGLÉS TURÍSTICO I", "HISTORIA DE PANAMÁ Y PATRIMONIO CULTURAL", "II CUATRIMESTRE", "TÉCNICAS DE CONDUCCIÓN Y GUÍA TURÍSTICA", "OPERACIONES Y GESTIÓN DE AGENCIAS DE VIAJES", "INGLÉS TURÍSTICO II", "HOSPITALIDAD Y SERVICIO AL CLIENTE", "III CUATRIMESTRE", "ADMINISTRACIÓN DE SERVICIOS DE HOTELERÍA", "ECOTURISMO Y TURISMO SOSTENIBLE", "DISEÑO DE CIRCUITOS TURÍSTICOS NACIONALES", "MERCADEO TURÍSTICO DIGITAL", "IV CUATRIMESTRE", "ORGANIZACIÓN DE EVENTOS, CONGRESOS Y CONVENCIONES", "LEGISLACIÓN TURÍSTICA PANAMEÑA", "FORMULACIÓN DE PROYECTOS TURÍSTICOS", "PRÁCTICA PROFESIONAL DE CAMPO"})
        Me.cbCURSO.Location = New System.Drawing.Point(166, 842)
        Me.cbCURSO.Name = "cbCURSO"
        Me.cbCURSO.Size = New System.Drawing.Size(1324, 35)
        Me.cbCURSO.TabIndex = 121
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbComarca)
        Me.GroupBox2.Controls.Add(Me.cbProvincia)
        Me.GroupBox2.Controls.Add(Me.cbPAIS)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(48, 635)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1442, 186)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIRECCIÓN PERSONAL DE PROFESOR (A)"
        '
        'cbComarca
        '
        Me.cbComarca.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbComarca.FormattingEnabled = True
        Me.cbComarca.Items.AddRange(New Object() {"KUNA YALA", "EMBERÁ WOOUNAM", "NGÄBE BUGLÉ", "NO APLICA"})
        Me.cbComarca.Location = New System.Drawing.Point(1022, 116)
        Me.cbComarca.Name = "cbComarca"
        Me.cbComarca.Size = New System.Drawing.Size(384, 35)
        Me.cbComarca.TabIndex = 29
        '
        'cbProvincia
        '
        Me.cbProvincia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Items.AddRange(New Object() {"BOCAS DEL TORO ", "COCLÉ", "COLÓN ", "CHIRIQUÍ", "DARIÉN ", "HERRERA", "LOS SANTOS ", "PANAMÁ ", "PANAMÁ OESTE ", "VERAGUAS", "NO APLICA"})
        Me.cbProvincia.Location = New System.Drawing.Point(172, 118)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(356, 35)
        Me.cbProvincia.TabIndex = 28
        '
        'cbPAIS
        '
        Me.cbPAIS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPAIS.FormattingEnabled = True
        Me.cbPAIS.Items.AddRange(New Object() {"A", "AFGANISTÁN", "ALBANIA", "ALEMANIA", "ANDORRA", "ANGOLA", "ANTIGUA Y BARBUDA", "ARABIA SAUDITA", "ARGELIA", "ARGENTINA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIYÁN", "B", "BAHAMAS", "BANGLADÉS", "BARBADOS", "BARÉIN", "BÉLGICA", "BELICE", "BENÍN", "BIELORRUSIA", "BIRMANIA / MYANMAR", "BOLIVIA", "BOSNIA Y HERZEGOVINA", "BOTSUANA", "BRASIL", "BRUNÉI", "BULGARIA", "BURKINA FASO", "BURUNDI", "BUTÁN", "C", "CABO VERDE", "CAMBOYA", "CAMERÚN", "CANADÁ", "CATAR", "CHILE", "CHINA", "CHIPRE", "CIUDAD DEL VATICANO", "COLOMBIA", "COMORAS", "COREA DEL NORTE", "COREA DEL SUR", "COSTA DE MARFIL", "COSTA RICA", "CROACIA", "CUBA", "D", "DINAMARCA", "DOMINICA", "E", "ECUADOR", "EGIPTO", "EL SALVADOR", "EMIRATOS ÁRABES UNIDOS", "ERITREA", "ESLOVAQUIA", "ESLOVENIA", "ESPAÑA", "ESTADOS UNIDOS", "ESTONIA", "ETIOPÍA", "F", "FILIPINAS", "FINLANDIA", "FIYI", "FRANCIA", "G", "GABÓN", "GAMBIA", "GEORGIA", "GHANA", "GRANADA", "GRECIA", "GUATEMALA", "GUINEA", "GUINEA-BISÁU", "GUINEA ECUATORIAL", "GUYANA", "H", "HAITÍ", "HONDURAS", "HUNGRÍA", "I", "INDIA", "INDONESIA", "IRAK", "IRÁN", "IRLANDA", "ISLANDIA", "ISLAS MARSHALL", "ISLAS SALOMÓN", "ISRAEL", "ITALIA", "J", "JAMAICA", "JAPÓN", "JORDANIA", "K", "KAZAJISTÁN", "KENIA", "KIRGUISTÁN", "KIRIBATI", "KUWAIT", "L", "LAOS", "LESOTO", "LETONIA", "LÍBANO", "LIBERIA", "LIBIA", "LIECHTENSTEIN", "LITUANIA", "LUXEMBURGO", "M", "MACEDONIA DEL NORTE", "MADAGASCAR", "MALASIA", "MALAUI", "MALDIVAS", "MALÍ", "MALTA", "MARRUECOS", "MAURICIO", "MAURITANIA", "MÉXICO", "MICRONESIA", "MOLDAVIA", "MÓNACO", "MONGOLIA", "MONTENEGRO", "MOZAMBIQUE", "N", "NAMIBIA", "NAURU ", "NEPAL", "NICARAGUA", "NÍGER", "NIGERIA", "NORUEGA", "NUEVA ZELANDA ", "O", "OMÁN", "P", "PAÍSES BAJOS", "PAKISTÁN", "PALAOS", "PALESTINA", "PANAMÁ", "PAPÚA NUEVA GUINEA", "PARAGUAY", "PERÚ", "POLONIA", "PORTUGAL", "R", "REINO UNIDO", "REPÚBLICA CENTROAFRICANA", "REPÚBLICA CHECA", "REPÚBLICA DEL CONGO", "REPÚBLICA DEMOCRÁTICA DEL CONGO", "REPÚBLICA DOMINICANA", "RUANDA", "RUMANIA", "RUSIA", "S", "SAMOA", "SAN CRISTÓBAL Y NIEVES", "SAN MARINO", "SAN VICENTE Y LAS GRANADINAS", "SANTA LUCÍA", "SANTO TOMÉ Y PRÍNCIPE", "SENEGAL", "SERBIA", "SEYCHELLES", "SIERRA LEONA", "SINGAPUR", "SIRIA", "SOMALIA", "SRI LANKA", "SUAZILANDIA / ESWATINI", "SUDÁFRICA", "SUDÁN", "SUDÁN DEL SUR", "SUECIA", "SUIZA ", "SURINAM ", "T", "TAILANDIA", "TAIWÁN", "TANZANIA", "TAYIKISTÁN", "TOGO", "TONGA", "TRINIDAD Y TOBAGO", "TÚNEZ", "TURKMENISTÁN", "TURQUÍA", "TUVALU", "U", "UCRANIA", "UGANDA", "URUGUAY", "UZBEQUISTÁN", "V", "VANUATU", "VENEZUELA", "VIETNAM", "Y", "YEMEN", "YIBUTI", "Z", "ZAMBIA", "ZIMBABUE"})
        Me.cbPAIS.Location = New System.Drawing.Point(305, 43)
        Me.cbPAIS.Name = "cbPAIS"
        Me.cbPAIS.Size = New System.Drawing.Size(583, 35)
        Me.cbPAIS.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(878, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 27)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "COMARCA:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 27)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "PROVINCIA:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(290, 27)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "PAÍS DE PROCEDENCIA:"
        '
        'btnOTROS
        '
        Me.btnOTROS.BackColor = System.Drawing.Color.Blue
        Me.btnOTROS.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOTROS.FlatAppearance.BorderSize = 2
        Me.btnOTROS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOTROS.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOTROS.ForeColor = System.Drawing.Color.White
        Me.btnOTROS.Location = New System.Drawing.Point(817, 910)
        Me.btnOTROS.Name = "btnOTROS"
        Me.btnOTROS.Size = New System.Drawing.Size(356, 73)
        Me.btnOTROS.TabIndex = 127
        Me.btnOTROS.Text = "GUARDAR OTROS"
        Me.btnOTROS.UseVisualStyleBackColor = False
        '
        'btnPREGUARDAR
        '
        Me.btnPREGUARDAR.BackColor = System.Drawing.Color.Blue
        Me.btnPREGUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPREGUARDAR.FlatAppearance.BorderSize = 2
        Me.btnPREGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPREGUARDAR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPREGUARDAR.ForeColor = System.Drawing.Color.White
        Me.btnPREGUARDAR.Location = New System.Drawing.Point(430, 910)
        Me.btnPREGUARDAR.Name = "btnPREGUARDAR"
        Me.btnPREGUARDAR.Size = New System.Drawing.Size(356, 73)
        Me.btnPREGUARDAR.TabIndex = 126
        Me.btnPREGUARDAR.Text = "PRE-GUARDAR"
        Me.btnPREGUARDAR.UseVisualStyleBackColor = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Blue
        Me.btnSALIR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSALIR.FlatAppearance.BorderSize = 2
        Me.btnSALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSALIR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.White
        Me.btnSALIR.Location = New System.Drawing.Point(1587, 910)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(296, 73)
        Me.btnSALIR.TabIndex = 124
        Me.btnSALIR.Text = "SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'btnLIMPIAR
        '
        Me.btnLIMPIAR.BackColor = System.Drawing.Color.Blue
        Me.btnLIMPIAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLIMPIAR.FlatAppearance.BorderSize = 2
        Me.btnLIMPIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnLIMPIAR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIMPIAR.ForeColor = System.Drawing.Color.White
        Me.btnLIMPIAR.Location = New System.Drawing.Point(1205, 910)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(357, 73)
        Me.btnLIMPIAR.TabIndex = 125
        Me.btnLIMPIAR.Text = "LIMPIAR"
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'btnGUARDAR
        '
        Me.btnGUARDAR.BackColor = System.Drawing.Color.Blue
        Me.btnGUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGUARDAR.FlatAppearance.BorderSize = 2
        Me.btnGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGUARDAR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGUARDAR.ForeColor = System.Drawing.Color.White
        Me.btnGUARDAR.Location = New System.Drawing.Point(43, 910)
        Me.btnGUARDAR.Name = "btnGUARDAR"
        Me.btnGUARDAR.Size = New System.Drawing.Size(356, 73)
        Me.btnGUARDAR.TabIndex = 123
        Me.btnGUARDAR.Text = "GUARDAR DATOS"
        Me.btnGUARDAR.UseVisualStyleBackColor = False
        '
        'FORMULARIO_PROFESOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnOTROS)
        Me.Controls.Add(Me.btnPREGUARDAR)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.btnLIMPIAR)
        Me.Controls.Add(Me.btnGUARDAR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbCURSO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGenerarCarnet)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnEXAMINAR)
        Me.Controls.Add(Me.pbIMAGEN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FORMULARIO_PROFESOR"
        Me.Text = "FORMULARIO INGRESO PROFESOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIMAGEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents pbIMAGEN As PictureBox
    Friend WithEvents btnEXAMINAR As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbEdad As ComboBox
    Friend WithEvents btnValidarTelefono As Button
    Friend WithEvents btnValidarCorreo As Button
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents cbGENERO As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVALIDAR As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorreoElectronico As TextBox
    Friend WithEvents btnGenerarCarnet As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCURSO As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbComarca As ComboBox
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbPAIS As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnOTROS As Button
    Friend WithEvents btnPREGUARDAR As Button
    Friend WithEvents btnSALIR As Button
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents btnGUARDAR As Button
End Class
