<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtTecnico = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.btnVERIFICARDATOS = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFECHADIA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtBachiller = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCorregimiento = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtColegio = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnINGRESAR = New System.Windows.Forms.Button()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.btnEXPORTAR = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pbImagen2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BasE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet1 = New WindowsApp1.BASE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet()
        Me.btnPRINT = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFECHAAÑO = New System.Windows.Forms.TextBox()
        Me.txtFECHAMES = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtComarca = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.btnSeletIMAGEN = New System.Windows.Forms.Button()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(557, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(683, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INFORMACIÓN DE DATOS DE LOS ESTUDIANTES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRES:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(621, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDOS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CÉDULA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 734)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CARRERA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1251, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "EDAD:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(302, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CORREO ELECTRÓNICO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(753, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 27)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TELÉFONO:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(148, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 35)
        Me.txtNombre.TabIndex = 9
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.White
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(780, 26)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(182, 35)
        Me.txtApellido.TabIndex = 10
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.White
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(436, 175)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(285, 35)
        Me.txtCedula.TabIndex = 11
        '
        'txtTecnico
        '
        Me.txtTecnico.BackColor = System.Drawing.Color.White
        Me.txtTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTecnico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTecnico.Location = New System.Drawing.Point(176, 728)
        Me.txtTecnico.Name = "txtTecnico"
        Me.txtTecnico.Size = New System.Drawing.Size(1329, 35)
        Me.txtTecnico.TabIndex = 12
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.Color.White
        Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(1344, 26)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(108, 35)
        Me.txtEdad.TabIndex = 13
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(321, 139)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(382, 35)
        Me.txtCorreo.TabIndex = 14
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(909, 133)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(240, 35)
        Me.txtTelefono.TabIndex = 15
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'btnVERIFICARDATOS
        '
        Me.btnVERIFICARDATOS.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnVERIFICARDATOS.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVERIFICARDATOS.FlatAppearance.BorderSize = 2
        Me.btnVERIFICARDATOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnVERIFICARDATOS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVERIFICARDATOS.Location = New System.Drawing.Point(743, 144)
        Me.btnVERIFICARDATOS.Name = "btnVERIFICARDATOS"
        Me.btnVERIFICARDATOS.Size = New System.Drawing.Size(297, 89)
        Me.btnVERIFICARDATOS.TabIndex = 16
        Me.btnVERIFICARDATOS.Text = "VEDIFICAR DATOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESTUDIANTES"
        Me.btnVERIFICARDATOS.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 27)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "FECHA DE NACIMIENTO:"
        '
        'txtFECHADIA
        '
        Me.txtFECHADIA.BackColor = System.Drawing.Color.White
        Me.txtFECHADIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFECHADIA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFECHADIA.Location = New System.Drawing.Point(321, 84)
        Me.txtFECHADIA.Name = "txtFECHADIA"
        Me.txtFECHADIA.Size = New System.Drawing.Size(89, 35)
        Me.txtFECHADIA.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1075, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 27)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "GÉNERO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 27)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "PROVINCIA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(290, 27)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "PAÍS DE PROCEDENCIA:"
        '
        'txtGenero
        '
        Me.txtGenero.BackColor = System.Drawing.Color.White
        Me.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenero.Location = New System.Drawing.Point(1208, 84)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(244, 35)
        Me.txtGenero.TabIndex = 26
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.White
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(176, 85)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(480, 35)
        Me.txtProvincia.TabIndex = 27
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.Color.White
        Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPais.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(321, 35)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(482, 35)
        Me.txtPais.TabIndex = 28
        '
        'txtBachiller
        '
        Me.txtBachiller.BackColor = System.Drawing.Color.White
        Me.txtBachiller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBachiller.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBachiller.Location = New System.Drawing.Point(1225, 47)
        Me.txtBachiller.Name = "txtBachiller"
        Me.txtBachiller.Size = New System.Drawing.Size(244, 35)
        Me.txtBachiller.TabIndex = 30
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(176, 210)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(857, 35)
        Me.txtDireccion.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(702, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(221, 27)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "CORREGIMIENTO:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 27)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "DISTRITO:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(22, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 27)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "SECTOR:"
        '
        'txtCorregimiento
        '
        Me.txtCorregimiento.BackColor = System.Drawing.Color.White
        Me.txtCorregimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorregimiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorregimiento.Location = New System.Drawing.Point(933, 147)
        Me.txtCorregimiento.Name = "txtCorregimiento"
        Me.txtCorregimiento.Size = New System.Drawing.Size(510, 35)
        Me.txtCorregimiento.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(292, 27)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "COLEGIO SECUNDARIO:"
        '
        'txtColegio
        '
        Me.txtColegio.BackColor = System.Drawing.Color.White
        Me.txtColegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColegio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColegio.Location = New System.Drawing.Point(321, 49)
        Me.txtColegio.Name = "txtColegio"
        Me.txtColegio.Size = New System.Drawing.Size(651, 35)
        Me.txtColegio.TabIndex = 46
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1061, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(149, 27)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "BACHILLER:"
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Red
        Me.btnSALIR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSALIR.FlatAppearance.BorderSize = 2
        Me.btnSALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSALIR.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.White
        Me.btnSALIR.Location = New System.Drawing.Point(406, 895)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(1162, 85)
        Me.btnSALIR.TabIndex = 52
        Me.btnSALIR.Text = "REGRESA AL SISTEMA PERSONAL"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'btnINGRESAR
        '
        Me.btnINGRESAR.BackColor = System.Drawing.Color.AliceBlue
        Me.btnINGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnINGRESAR.FlatAppearance.BorderSize = 2
        Me.btnINGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnINGRESAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINGRESAR.ForeColor = System.Drawing.Color.Black
        Me.btnINGRESAR.Location = New System.Drawing.Point(1355, 144)
        Me.btnINGRESAR.Name = "btnINGRESAR"
        Me.btnINGRESAR.Size = New System.Drawing.Size(277, 90)
        Me.btnINGRESAR.TabIndex = 54
        Me.btnINGRESAR.Text = "INGRESAR A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCESS"
        Me.btnINGRESAR.UseVisualStyleBackColor = False
        '
        'btnLIMPIAR
        '
        Me.btnLIMPIAR.BackColor = System.Drawing.Color.SpringGreen
        Me.btnLIMPIAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLIMPIAR.FlatAppearance.BorderSize = 2
        Me.btnLIMPIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLIMPIAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIMPIAR.ForeColor = System.Drawing.Color.Black
        Me.btnLIMPIAR.Location = New System.Drawing.Point(1055, 144)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(281, 89)
        Me.btnLIMPIAR.TabIndex = 57
        Me.btnLIMPIAR.Text = "LIMPIAR DATOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESTUDIANTES"
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'txtDistrito
        '
        Me.txtDistrito.BackColor = System.Drawing.Color.White
        Me.txtDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrito.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrito.Location = New System.Drawing.Point(154, 149)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(325, 35)
        Me.txtDistrito.TabIndex = 43
        '
        'btnEXPORTAR
        '
        Me.btnEXPORTAR.BackColor = System.Drawing.Color.Blue
        Me.btnEXPORTAR.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.pdf
        Me.btnEXPORTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEXPORTAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEXPORTAR.FlatAppearance.BorderSize = 2
        Me.btnEXPORTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnEXPORTAR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXPORTAR.ForeColor = System.Drawing.Color.White
        Me.btnEXPORTAR.Location = New System.Drawing.Point(1537, 807)
        Me.btnEXPORTAR.Name = "btnEXPORTAR"
        Me.btnEXPORTAR.Size = New System.Drawing.Size(112, 82)
        Me.btnEXPORTAR.TabIndex = 58
        Me.btnEXPORTAR.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox1.Location = New System.Drawing.Point(1638, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox3.Location = New System.Drawing.Point(28, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(236, 186)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'pbImagen2
        '
        Me.pbImagen2.Image = Global.WindowsApp1.My.Resources.Resources.CARNET
        Me.pbImagen2.Location = New System.Drawing.Point(1518, 245)
        Me.pbImagen2.Name = "pbImagen2"
        Me.pbImagen2.Size = New System.Drawing.Size(361, 371)
        Me.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen2.TabIndex = 8
        Me.pbImagen2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BasE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet1
        '
        Me.BasE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet1.DataSetName = "BASE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet"
        Me.BasE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPRINT
        '
        Me.btnPRINT.BackColor = System.Drawing.Color.Blue
        Me.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPRINT.FlatAppearance.BorderSize = 2
        Me.btnPRINT.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPRINT.ForeColor = System.Drawing.Color.White
        Me.btnPRINT.Location = New System.Drawing.Point(1655, 807)
        Me.btnPRINT.Name = "btnPRINT"
        Me.btnPRINT.Size = New System.Drawing.Size(211, 82)
        Me.btnPRINT.TabIndex = 59
        Me.btnPRINT.Text = "PRINT"
        Me.btnPRINT.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtFECHAAÑO)
        Me.GroupBox1.Controls.Add(Me.txtFECHAMES)
        Me.GroupBox1.Controls.Add(Me.txtApellido2)
        Me.GroupBox1.Controls.Add(Me.txtNombre2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFECHADIA)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtGenero)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1469, 192)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN PERSONAL"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(753, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 27)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "DE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(416, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 27)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "DE"
        '
        'txtFECHAAÑO
        '
        Me.txtFECHAAÑO.BackColor = System.Drawing.Color.White
        Me.txtFECHAAÑO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFECHAAÑO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFECHAAÑO.Location = New System.Drawing.Point(804, 84)
        Me.txtFECHAAÑO.Name = "txtFECHAAÑO"
        Me.txtFECHAAÑO.Size = New System.Drawing.Size(132, 35)
        Me.txtFECHAAÑO.TabIndex = 22
        '
        'txtFECHAMES
        '
        Me.txtFECHAMES.BackColor = System.Drawing.Color.White
        Me.txtFECHAMES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFECHAMES.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFECHAMES.Location = New System.Drawing.Point(467, 84)
        Me.txtFECHAMES.Name = "txtFECHAMES"
        Me.txtFECHAMES.Size = New System.Drawing.Size(273, 35)
        Me.txtFECHAMES.TabIndex = 21
        '
        'txtApellido2
        '
        Me.txtApellido2.BackColor = System.Drawing.Color.White
        Me.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(977, 26)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(182, 35)
        Me.txtApellido2.TabIndex = 12
        '
        'txtNombre2
        '
        Me.txtNombre2.BackColor = System.Drawing.Color.White
        Me.txtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(342, 34)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(182, 35)
        Me.txtNombre2.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComarca)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtPais)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtProvincia)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCorregimiento)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtDistrito)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 444)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1469, 269)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIRECCIÓN PERSONAL "
        '
        'txtComarca
        '
        Me.txtComarca.BackColor = System.Drawing.Color.White
        Me.txtComarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComarca.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComarca.Location = New System.Drawing.Point(977, 83)
        Me.txtComarca.Name = "txtComarca"
        Me.txtComarca.Size = New System.Drawing.Size(466, 35)
        Me.txtComarca.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(827, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 27)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "COMARCA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtColegio)
        Me.GroupBox3.Controls.Add(Me.txtBachiller)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(28, 784)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1493, 105)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN ACADÉMICA"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1537, 718)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 81)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "PRINT PREVIEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(416, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(1089, 62)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "INSTITUTO SUPERIOR CYC TECHNOLOGIES"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument3
        '
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'btnSeletIMAGEN
        '
        Me.btnSeletIMAGEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSeletIMAGEN.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSeletIMAGEN.FlatAppearance.BorderSize = 2
        Me.btnSeletIMAGEN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSeletIMAGEN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeletIMAGEN.ForeColor = System.Drawing.Color.White
        Me.btnSeletIMAGEN.Location = New System.Drawing.Point(1537, 637)
        Me.btnSeletIMAGEN.Name = "btnSeletIMAGEN"
        Me.btnSeletIMAGEN.Size = New System.Drawing.Size(329, 75)
        Me.btnSeletIMAGEN.TabIndex = 80
        Me.btnSeletIMAGEN.Text = "SELECCIONAR IMAGEN"
        Me.btnSeletIMAGEN.UseVisualStyleBackColor = False
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog3"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnSeletIMAGEN)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPRINT)
        Me.Controls.Add(Me.btnEXPORTAR)
        Me.Controls.Add(Me.btnLIMPIAR)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnINGRESAR)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.btnVERIFICARDATOS)
        Me.Controls.Add(Me.txtTecnico)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.pbImagen2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "CONSULTA DE DATOS DE LOS ESTUDIANTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pbImagen2 As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtTecnico As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents btnVERIFICARDATOS As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFECHADIA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtBachiller As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCorregimiento As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtColegio As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnSALIR As Button
    Friend WithEvents btnINGRESAR As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents btnEXPORTAR As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BasE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet1 As BASE_DE_DATOS_SISTEMA_DE_EXPEDIENTE_PERSONAL_Y_ACADEMICODataSet
    Friend WithEvents btnPRINT As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents txtFECHAAÑO As TextBox
    Friend WithEvents txtFECHAMES As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtComarca As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents btnSeletIMAGEN As Button
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
End Class
