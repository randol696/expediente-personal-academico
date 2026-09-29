<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_INGRESO_ALUMNO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1_INGRESO_ALUMNO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.cbTecnico = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtColegio = New System.Windows.Forms.TextBox()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnGenerarCarnet = New System.Windows.Forms.Button()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.btnGUARDAR = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnVALIDAR = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEdad = New System.Windows.Forms.ComboBox()
        Me.btnValidarTelefono = New System.Windows.Forms.Button()
        Me.btnValidarCorreo = New System.Windows.Forms.Button()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbGENERO = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbFechaAÑO = New System.Windows.Forms.ComboBox()
        Me.cbFechaMES = New System.Windows.Forms.ComboBox()
        Me.cbFechaDIA = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbCorregimiento = New System.Windows.Forms.ComboBox()
        Me.cbDistrito = New System.Windows.Forms.ComboBox()
        Me.cbComarca = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbPAIS = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbBachiller = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnPREGUARDAR = New System.Windows.Forms.Button()
        Me.btnOTROS = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1089, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INSTITUTO SUPERIOR CYC TECHNOLOGIES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NÚMERO DE CARNET DE ESTUDIANTE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRES:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(566, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "APELLIDOS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1140, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CÉDULA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 741)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CARRERA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "EDAD:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(281, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(291, 27)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "FECHA DE NACIMIENTO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "SECTOR:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 27)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "DISTRITO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(221, 27)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "CORREGIMIENTO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(292, 27)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "COLEGIO SECUNDARIO:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(302, 27)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CORREO ELECTRÓNICO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1041, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 27)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "TELÉFONO:"
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(494, 149)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 35)
        Me.txtNumero.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(148, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 35)
        Me.txtNombre.TabIndex = 15
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(722, 34)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(193, 35)
        Me.txtApellido.TabIndex = 16
        '
        'txtCedula
        '
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(1269, 32)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(201, 35)
        Me.txtCedula.TabIndex = 17
        '
        'cbTecnico
        '
        Me.cbTecnico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTecnico.FormattingEnabled = True
        Me.cbTecnico.Items.AddRange(New Object() {"EN EDUCACIÓN:", "TÉCNICO SUPERIOR EN INGLÉS COMPUTACIONAL PARA DOCENTE.", "TÉCNICO SUPERIOR EN CUIDADOS DEL INFANTE #1", "TÉCNICO SUPERIOR EN CUIDADOS DEL INFANTE #2", "", "EN TECNOLOGÍA:", "TÉCNICO SUPERIOR EN ENTORNOS VIRTUALES.", "TÉCNICO SUPERIOR EN INFORMÁTICA PARA LA APLICACIÓN PARA LA EDUCACIÓN.", "", "EN INGLÉS:", "TÉCNICO SUPERIOR EN INGLÉS COMPUTACIONAL.", "TÉCNICO SUPERIOR EN INGLÉS CONVERSACIONAL.", "", "EN INFORMÁTICA:", "TÉCNICO SUPERIOR EN SISTEMAS INFORMÁTICOS.", "TÉCNICO SUPERIOR EN SOFTWARE E INTERNET.", "TÉCNICO SUPERIOR EN TECNOLOGÍA E INFORMÁTICA.", "", "OTRAS ÁREAS:", "TÉCNICO SUPERIOR EN GESTIÓN AMBIENTAL.", "TÉCNICO SUPERIOR EN RECURSOS NATURALES Y MEDIO AMBIENTE.", "TÉCNICO SUPERIOR EN REGISTROS CONTABLES.", "TÉCNICO SUPERIOR EN RELACIONES HUMANAS.", "TÉCNICO SUPERIOR EN SALUD OCUPACIONAL.", "TÉCNICO SUPERIOR EN TURISMO NACIONAL."})
        Me.cbTecnico.Location = New System.Drawing.Point(160, 735)
        Me.cbTecnico.Name = "cbTecnico"
        Me.cbTecnico.Size = New System.Drawing.Size(1016, 35)
        Me.cbTecnico.TabIndex = 18
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(148, 249)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(757, 35)
        Me.txtDireccion.TabIndex = 21
        '
        'txtColegio
        '
        Me.txtColegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColegio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColegio.Location = New System.Drawing.Point(316, 46)
        Me.txtColegio.Name = "txtColegio"
        Me.txtColegio.Size = New System.Drawing.Size(737, 35)
        Me.txtColegio.TabIndex = 24
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreoElectronico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(314, 141)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(323, 35)
        Me.txtCorreoElectronico.TabIndex = 25
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(1197, 139)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(230, 35)
        Me.txtTelefono.TabIndex = 26
        '
        'btnGenerarCarnet
        '
        Me.btnGenerarCarnet.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerarCarnet.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGenerarCarnet.FlatAppearance.BorderSize = 2
        Me.btnGenerarCarnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerarCarnet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCarnet.ForeColor = System.Drawing.Color.White
        Me.btnGenerarCarnet.Location = New System.Drawing.Point(632, 140)
        Me.btnGenerarCarnet.Name = "btnGenerarCarnet"
        Me.btnGenerarCarnet.Size = New System.Drawing.Size(472, 47)
        Me.btnGenerarCarnet.TabIndex = 27
        Me.btnGenerarCarnet.Text = "GENERAR CARNET"
        Me.btnGenerarCarnet.UseVisualStyleBackColor = False
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExaminar.FlatAppearance.BorderSize = 2
        Me.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExaminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.White
        Me.btnExaminar.Location = New System.Drawing.Point(1640, 798)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(209, 108)
        Me.btnExaminar.TabIndex = 29
        Me.btnExaminar.Text = "SELECCIONAR IMAGEN"
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'btnGUARDAR
        '
        Me.btnGUARDAR.BackColor = System.Drawing.Color.Blue
        Me.btnGUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGUARDAR.FlatAppearance.BorderSize = 2
        Me.btnGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGUARDAR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGUARDAR.ForeColor = System.Drawing.Color.White
        Me.btnGUARDAR.Location = New System.Drawing.Point(12, 921)
        Me.btnGUARDAR.Name = "btnGUARDAR"
        Me.btnGUARDAR.Size = New System.Drawing.Size(356, 73)
        Me.btnGUARDAR.TabIndex = 35
        Me.btnGUARDAR.Text = "GUARDAR DATOS"
        Me.btnGUARDAR.UseVisualStyleBackColor = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Blue
        Me.btnSALIR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSALIR.FlatAppearance.BorderSize = 2
        Me.btnSALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSALIR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.White
        Me.btnSALIR.Location = New System.Drawing.Point(1556, 921)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(356, 73)
        Me.btnSALIR.TabIndex = 36
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
        Me.btnLIMPIAR.Location = New System.Drawing.Point(1174, 921)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(356, 73)
        Me.btnLIMPIAR.TabIndex = 37
        Me.btnLIMPIAR.Text = "LIMPIAR"
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnVALIDAR
        '
        Me.btnVALIDAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVALIDAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVALIDAR.FlatAppearance.BorderSize = 2
        Me.btnVALIDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVALIDAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVALIDAR.ForeColor = System.Drawing.Color.White
        Me.btnVALIDAR.Location = New System.Drawing.Point(1476, 20)
        Me.btnVALIDAR.Name = "btnVALIDAR"
        Me.btnVALIDAR.Size = New System.Drawing.Size(418, 47)
        Me.btnVALIDAR.TabIndex = 42
        Me.btnVALIDAR.Text = "VALIDAR CÉDULA"
        Me.btnVALIDAR.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(695, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(547, 33)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "INGRESO DE DATOS DE ESTUDIANTES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEdad)
        Me.GroupBox1.Controls.Add(Me.btnValidarTelefono)
        Me.GroupBox1.Controls.Add(Me.btnValidarCorreo)
        Me.GroupBox1.Controls.Add(Me.txtApellido2)
        Me.GroupBox1.Controls.Add(Me.txtNombre2)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cbGENERO)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.cbFechaAÑO)
        Me.GroupBox1.Controls.Add(Me.cbFechaMES)
        Me.GroupBox1.Controls.Add(Me.cbFechaDIA)
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
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElectronico)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1900, 192)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN PERSONAL"
        '
        'cbEdad
        '
        Me.cbEdad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEdad.FormattingEnabled = True
        Me.cbEdad.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cbEdad.Location = New System.Drawing.Point(105, 90)
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
        Me.btnValidarTelefono.Location = New System.Drawing.Point(1487, 133)
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
        Me.btnValidarCorreo.Location = New System.Drawing.Point(658, 133)
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
        Me.txtApellido2.Location = New System.Drawing.Point(926, 34)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(193, 35)
        Me.txtApellido2.TabIndex = 51
        '
        'txtNombre2
        '
        Me.txtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(360, 38)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(193, 35)
        Me.txtNombre2.TabIndex = 50
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(963, 97)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 27)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "DE:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(664, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 27)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "DE:"
        '
        'cbGENERO
        '
        Me.cbGENERO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGENERO.FormattingEnabled = True
        Me.cbGENERO.Items.AddRange(New Object() {"MASCULINO", "FEMENINO "})
        Me.cbGENERO.Location = New System.Drawing.Point(1345, 87)
        Me.cbGENERO.Name = "cbGENERO"
        Me.cbGENERO.Size = New System.Drawing.Size(235, 35)
        Me.cbGENERO.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1216, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 27)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "GÉNERO:"
        '
        'cbFechaAÑO
        '
        Me.cbFechaAÑO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFechaAÑO.FormattingEnabled = True
        Me.cbFechaAÑO.Items.AddRange(New Object() {"1800", "1801", "1802", "1803", "1804", "1805", "1806", "1807", "1808", "1809", "1810", "1811", "1812", "1813", "1814", "1815", "1816", "1817", "1818", "1819", "1820", "1821", "1822", "1823", "1824", "1825", "1826", "1827", "1828", "1829", "1830", "1831", "1832", "1833", "1834", "1835", "1836", "1837", "1838", "1839", "1840", "1841", "1842", "1843", "1844", "1845", "1846", "1847", "1848", "1849", "1850", "1851", "1852", "1853", "1854", "1855", "1856", "1857", "1858", "1859", "1860", "1861", "1862", "1863", "1864", "1865", "1866", "1867", "1868", "1869", "1870", "1871", "1872", "1873", "1874", "1875", "1876", "1877", "1878", "1879", "1880", "1881", "1882", "1883", "1884", "1885", "1886", "1887", "1888", "1889", "1890", "1891", "1892", "1893", "1894", "1895", "1896", "1897", "1898", "1899", "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026"})
        Me.cbFechaAÑO.Location = New System.Drawing.Point(1021, 92)
        Me.cbFechaAÑO.Name = "cbFechaAÑO"
        Me.cbFechaAÑO.Size = New System.Drawing.Size(121, 35)
        Me.cbFechaAÑO.TabIndex = 45
        '
        'cbFechaMES
        '
        Me.cbFechaMES.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFechaMES.FormattingEnabled = True
        Me.cbFechaMES.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbFechaMES.Location = New System.Drawing.Point(722, 92)
        Me.cbFechaMES.Name = "cbFechaMES"
        Me.cbFechaMES.Size = New System.Drawing.Size(235, 35)
        Me.cbFechaMES.TabIndex = 44
        '
        'cbFechaDIA
        '
        Me.cbFechaDIA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFechaDIA.FormattingEnabled = True
        Me.cbFechaDIA.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbFechaDIA.Location = New System.Drawing.Point(588, 92)
        Me.cbFechaDIA.Name = "cbFechaDIA"
        Me.cbFechaDIA.Size = New System.Drawing.Size(70, 35)
        Me.cbFechaDIA.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCorregimiento)
        Me.GroupBox2.Controls.Add(Me.cbDistrito)
        Me.GroupBox2.Controls.Add(Me.cbComarca)
        Me.GroupBox2.Controls.Add(Me.cbProvincia)
        Me.GroupBox2.Controls.Add(Me.cbPAIS)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 412)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1567, 307)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIRECCIÓN PERSONAL"
        '
        'cbCorregimiento
        '
        Me.cbCorregimiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCorregimiento.FormattingEnabled = True
        Me.cbCorregimiento.Items.AddRange(New Object() {"A", "AGUA BUENA", "AGUA FRÍA", "AGUADULCE (CABECERA)", "ALANJE (CABECERA)", "ALCALDE DÍAZ", "ALMIRANTE (CABECERA)", "ALTO BOQUETE", "ANCÓN", "ANTÓN (CABECERA)", "ARRAIJÁN (CABECERA)", "ATALAYA (CABECERA)", "B", "BACO", "BAJO BOQUETE", "BALBOA", "BARRIO BALBOA", "BARRIO COLÓN", "BASTIMENTOS", "BELLA VISTA", "BELISARIO PORRAS", "BETANIA", "BOCAS DEL TORO (CABECERA)", "BOQUERÓN (CABECERA)", "BUGABA (CABECERA)", "C", "CALIDONIA", "CALOBRE (CABECERA)", "CAÑAZAS (CABECERA)", "CAPIRA (CABECERA)", "CATIVÁ", "CHAME (CABECERA)", "CHANGUINOLA (CABECERA)", "CHEPO (CABECERA)", "CHIMÁN (CABECERA)", "CHITRÉ (CABECERA)", "CHILIBRE", "CRISTÓBAL", "D", "DAVID (CABECERA)", "DAVID ESTE", "DAVID SUR", "DIVALÁ", "DOLEGA (CABECERA)", "DONOSO (CABECERA)", "E", "EL CHORRILLO", "EL COCO", "EL CRISTO", "EL EJIDO", "EL EMPALME", "EL LLANO", "EL REAL DE SANTA MARÍA", "EL VALLE DE ANTÓN", "G", "GUABITO", "GUADALUPE", "GUALACA (CABECERA)", "GUARARÉ (CABECERA)", "J", "JOSÉ DOMINGO ESPINAR", "JUAN DÍAZ", "JUAN DEMÓSTENES AROSEMENA", "L", "LA CHORRERA (CABECERA)", "LA CONCEPCIÓN", "LA CUMBRES", "LA DOÑA", "LA ESPIGADILLA", "LA MESA (CABECERA)", "LA PINTADA (CABECERA)", "LA VILLA DE LOS SANTOS", "LAS GARZAS", "LAS MAÑANITAS", "LAS MINAS (CABECERA)", "LAS TABLAS (CABECERA)", "LOS POZOS (CABECERA)", "LL", "LLANO LARGO", "LLANO GRANDE", "LLANO ABAJO ", "LLANO BONITO", "M", "MACARACAS (CABECERA)", "MATEO ITURRALDE", "MONAGRILLO", "MONTIJO (CABECERA)", "N", "NATÁ (CABECERA)", "NOEMÍ", "NUEVA PROVIDENCIA", "O", "OCÚ (CABECERA)", "OLÁ (CABECERA)", "OMAR TORRIJOS", "PACORA", "P", "POCRÍ", "PANAMÁ (SAN FELIPE - CENTRO HISTÓRICO)", "PARQUE LEFEVRE", "PEDASÍ (CABECERA)", "PEDREGAL", "PENONOMÉ (CABECERA)", "PESÉ (CABECERA)", "PLAYA LEONA", "PORTOBELO (CABECERA)", "PUEBLO NUEVO", "PUERTO ARMUELLES", "PUERTO CAIMITO", "R", "REMEDIOS (CABECERA)", "RENACIMIENTO (CABECERA)", "RÍO ABAJO", "RÍO HATO", "RÍO DE JESÚS (CABECERA)", "S", "SABANITAS", "SAN CARLOS (CABECERA)", "SAN FELIPE", "SAN FRANCISCO", "SAN FÉLIX (CABECERA)", "SAN LORENZO (CABECERA)", "SAN MIGUELITO (CABECERA)", "SANTA ANA", "SANTA FÉ (CABECERA)", "SANTA MARÍA (CABECERA)", "SANTIAGO (CABECERA)", "SONÁ (CABECERA)", "T", "TABOGA (CABECERA)", "TOCUMEN", "TOLÉ (CABECERA)", "TRES QUEBRADAS", "TONOSÍ (CABECERA)", "TORTÍ", "V", "VACAMONTE", "VALLE DE LA UNIÓN", "VISTA ALEGRE", "VOLCÁN"})
        Me.cbCorregimiento.Location = New System.Drawing.Point(238, 193)
        Me.cbCorregimiento.Name = "cbCorregimiento"
        Me.cbCorregimiento.Size = New System.Drawing.Size(777, 35)
        Me.cbCorregimiento.TabIndex = 31
        '
        'cbDistrito
        '
        Me.cbDistrito.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDistrito.FormattingEnabled = True
        Me.cbDistrito.Items.AddRange(New Object() {"A", "AGUADULCE", "ALANJE", "ALMIRANTE", "ANTÓN", "ARRAIJÁN", "ATALAYA ", "B", "BALBOA", "BARÚ", "BOCAS DEL TORO", "BOQUERÓN", "BOQUETE", "BUGABA ", "C", "CALOBRE", "CAÑAZAS", "CAPIRA", "CHAGRES", "CHAME", "CHANGUINOLA", "CHEPIGANA", "CHEPO", "CHIMÁN", "CHIRIQUÍ GRANDE", "CHITRÉ", "COCLÉ (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ)", "COLÓN ", "D", "DAVID", "DOLEGA", "DONOSO", "G", "GUALACA", "GUARARÉ ", "J", "JIRONDAI (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ)", "K", "KANKINTÚ (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ)", "KUSAPÍN (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ)", "L", "LA CHORRERA", "LA MESA", "LA PALMA (DISTRITO DE LA COMARCA EMBERÁ-WOUNAAN)", "LA PINTADA", "LAS MINAS", "LAS PALMAS", "LAS TABLAS", "LOS POZOS", "LOS SANTOS ", "M", "MACARACAS", "MARIATO", "MIRONÓ (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ)", "MONTIJO", "MÜNA (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ) ", "N", "NOLE DUIMA (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ)", "NATÁ", "NURÜM (DISTRITO DE LA COMARCA NGÄBE-BUGLÉ) ", "O", "OCÚ", "OLÁ", "OMAR TORRIJOS HERRERA ", "P", "PANAMÁ", "PARITA", "PEDASÍ", "PENONOMÉ", "PESÉ", "PINOGANA", "POCRÍ", "PORTOBELO ", "R", "REMEDIOS", "RENACIMIENTO", "RÍO DE JESÚS ", "S", "SAMBÚ (DISTRITO DE LA COMARCA EMBERÁ-WOUNAAN)", "SAN CARLOS", "SAN FÉLIX", "SAN FRANCISCO", "SAN LORENZO", "SAN MIGUELITO", "SANTA FÉ (DARIÉN)", "SANTA FÉ (VERAGUAS)", "SANTA ISABEL", "SANTA MARÍA", "SANTIAGO", "SONÁ ", "T", "TABOGA", "TOLÉ", "TONOSÍ "})
        Me.cbDistrito.Location = New System.Drawing.Point(166, 135)
        Me.cbDistrito.Name = "cbDistrito"
        Me.cbDistrito.Size = New System.Drawing.Size(849, 35)
        Me.cbDistrito.TabIndex = 30
        '
        'cbComarca
        '
        Me.cbComarca.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbComarca.FormattingEnabled = True
        Me.cbComarca.Items.AddRange(New Object() {"KUNA YALA", "EMBERÁ WOOUNAM", "NGÄBE BUGLÉ", "NO APLICA"})
        Me.cbComarca.Location = New System.Drawing.Point(735, 76)
        Me.cbComarca.Name = "cbComarca"
        Me.cbComarca.Size = New System.Drawing.Size(384, 35)
        Me.cbComarca.TabIndex = 29
        '
        'cbProvincia
        '
        Me.cbProvincia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Items.AddRange(New Object() {"BOCAS DEL TORO ", "COCLÉ", "COLÓN ", "CHIRIQUÍ", "DARIÉN ", "HERRERA", "LOS SANTOS ", "PANAMÁ ", "PANAMÁ OESTE ", "VERAGUAS", "NO APLICA"})
        Me.cbProvincia.Location = New System.Drawing.Point(166, 83)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(356, 35)
        Me.cbProvincia.TabIndex = 28
        '
        'cbPAIS
        '
        Me.cbPAIS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPAIS.FormattingEnabled = True
        Me.cbPAIS.Items.AddRange(New Object() {"A", "AFGANISTÁN", "ALBANIA", "ALEMANIA", "ANDORRA", "ANGOLA", "ANTIGUA Y BARBUDA", "ARABIA SAUDITA", "ARGELIA", "ARGENTINA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIYÁN", "B", "BAHAMAS", "BANGLADÉS", "BARBADOS", "BARÉIN", "BÉLGICA", "BELICE", "BENÍN", "BIELORRUSIA", "BIRMANIA / MYANMAR", "BOLIVIA", "BOSNIA Y HERZEGOVINA", "BOTSUANA", "BRASIL", "BRUNÉI", "BULGARIA", "BURKINA FASO", "BURUNDI", "BUTÁN", "C", "CABO VERDE", "CAMBOYA", "CAMERÚN", "CANADÁ", "CATAR", "CHILE", "CHINA", "CHIPRE", "CIUDAD DEL VATICANO", "COLOMBIA", "COMORAS", "COREA DEL NORTE", "COREA DEL SUR", "COSTA DE MARFIL", "COSTA RICA", "CROACIA", "CUBA", "D", "DINAMARCA", "DOMINICA", "E", "ECUADOR", "EGIPTO", "EL SALVADOR", "EMIRATOS ÁRABES UNIDOS", "ERITREA", "ESLOVAQUIA", "ESLOVENIA", "ESPAÑA", "ESTADOS UNIDOS", "ESTONIA", "ETIOPÍA", "F", "FILIPINAS", "FINLANDIA", "FIYI", "FRANCIA", "G", "GABÓN", "GAMBIA", "GEORGIA", "GHANA", "GRANADA", "GRECIA", "GUATEMALA", "GUINEA", "GUINEA-BISÁU", "GUINEA ECUATORIAL", "GUYANA", "H", "HAITÍ", "HONDURAS", "HUNGRÍA", "I", "INDIA", "INDONESIA", "IRAK", "IRÁN", "IRLANDA", "ISLANDIA", "ISLAS MARSHALL", "ISLAS SALOMÓN", "ISRAEL", "ITALIA", "J", "JAMAICA", "JAPÓN", "JORDANIA", "K", "KAZAJISTÁN", "KENIA", "KIRGUISTÁN", "KIRIBATI", "KUWAIT", "L", "LAOS", "LESOTO", "LETONIA", "LÍBANO", "LIBERIA", "LIBIA", "LIECHTENSTEIN", "LITUANIA", "LUXEMBURGO", "M", "MACEDONIA DEL NORTE", "MADAGASCAR", "MALASIA", "MALAUI", "MALDIVAS", "MALÍ", "MALTA", "MARRUECOS", "MAURICIO", "MAURITANIA", "MÉXICO", "MICRONESIA", "MOLDAVIA", "MÓNACO", "MONGOLIA", "MONTENEGRO", "MOZAMBIQUE", "N", "NAMIBIA", "NAURU ", "NEPAL", "NICARAGUA", "NÍGER", "NIGERIA", "NORUEGA", "NUEVA ZELANDA ", "O", "OMÁN", "P", "PAÍSES BAJOS", "PAKISTÁN", "PALAOS", "PALESTINA", "PANAMÁ", "PAPÚA NUEVA GUINEA", "PARAGUAY", "PERÚ", "POLONIA", "PORTUGAL", "R", "REINO UNIDO", "REPÚBLICA CENTROAFRICANA", "REPÚBLICA CHECA", "REPÚBLICA DEL CONGO", "REPÚBLICA DEMOCRÁTICA DEL CONGO", "REPÚBLICA DOMINICANA", "RUANDA", "RUMANIA", "RUSIA", "S", "SAMOA", "SAN CRISTÓBAL Y NIEVES", "SAN MARINO", "SAN VICENTE Y LAS GRANADINAS", "SANTA LUCÍA", "SANTO TOMÉ Y PRÍNCIPE", "SENEGAL", "SERBIA", "SEYCHELLES", "SIERRA LEONA", "SINGAPUR", "SIRIA", "SOMALIA", "SRI LANKA", "SUAZILANDIA / ESWATINI", "SUDÁFRICA", "SUDÁN", "SUDÁN DEL SUR", "SUECIA", "SUIZA ", "SURINAM ", "T", "TAILANDIA", "TAIWÁN", "TANZANIA", "TAYIKISTÁN", "TOGO", "TONGA", "TRINIDAD Y TOBAGO", "TÚNEZ", "TURKMENISTÁN", "TURQUÍA", "TUVALU", "U", "UCRANIA", "UGANDA", "URUGUAY", "UZBEQUISTÁN", "V", "VANUATU", "VENEZUELA", "VIETNAM", "Y", "YEMEN", "YIBUTI", "Z", "ZAMBIA", "ZIMBABUE"})
        Me.cbPAIS.Location = New System.Drawing.Point(307, 33)
        Me.cbPAIS.Name = "cbPAIS"
        Me.cbPAIS.Size = New System.Drawing.Size(583, 35)
        Me.cbPAIS.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(591, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 27)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "COMARCA:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 27)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "PROVINCIA:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(290, 27)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "PAÍS DE PROCEDENCIA:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbBachiller)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtColegio)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 797)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1567, 109)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN ACADÉMICA"
        '
        'cbBachiller
        '
        Me.cbBachiller.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBachiller.FormattingEnabled = True
        Me.cbBachiller.Items.AddRange(New Object() {"AGROPECUARIA ", "CIENCIAS", "COMERCIO ", "CONTABILIDAD", "HUMANIDADES ", "INFORMÁTICA ", "LETRAS", "TURISMO"})
        Me.cbBachiller.Location = New System.Drawing.Point(1260, 45)
        Me.cbBachiller.Name = "cbBachiller"
        Me.cbBachiller.Size = New System.Drawing.Size(286, 35)
        Me.cbBachiller.TabIndex = 26
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1105, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(149, 27)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "BACHILLER:"
        '
        'btnPREGUARDAR
        '
        Me.btnPREGUARDAR.BackColor = System.Drawing.Color.Blue
        Me.btnPREGUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPREGUARDAR.FlatAppearance.BorderSize = 2
        Me.btnPREGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPREGUARDAR.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPREGUARDAR.ForeColor = System.Drawing.Color.White
        Me.btnPREGUARDAR.Location = New System.Drawing.Point(399, 921)
        Me.btnPREGUARDAR.Name = "btnPREGUARDAR"
        Me.btnPREGUARDAR.Size = New System.Drawing.Size(356, 73)
        Me.btnPREGUARDAR.TabIndex = 47
        Me.btnPREGUARDAR.Text = "PRE-GUARDAR"
        Me.btnPREGUARDAR.UseVisualStyleBackColor = False
        '
        'btnOTROS
        '
        Me.btnOTROS.BackColor = System.Drawing.Color.Blue
        Me.btnOTROS.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOTROS.FlatAppearance.BorderSize = 2
        Me.btnOTROS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOTROS.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOTROS.ForeColor = System.Drawing.Color.White
        Me.btnOTROS.Location = New System.Drawing.Point(786, 921)
        Me.btnOTROS.Name = "btnOTROS"
        Me.btnOTROS.Size = New System.Drawing.Size(356, 73)
        Me.btnOTROS.TabIndex = 48
        Me.btnOTROS.Text = "GUARDAR OTROS"
        Me.btnOTROS.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox3.Location = New System.Drawing.Point(1740, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(166, 115)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox2.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 115)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'pbImagen
        '
        Me.pbImagen.Image = Global.WindowsApp1.My.Resources.Resources.CARNET
        Me.pbImagen.Location = New System.Drawing.Point(1585, 400)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(321, 389)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 28
        Me.pbImagen.TabStop = False
        '
        'Form1_INGRESO_ALUMNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnOTROS)
        Me.Controls.Add(Me.btnPREGUARDAR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.btnLIMPIAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnGUARDAR)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbTecnico)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.btnGenerarCarnet)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1_INGRESO_ALUMNO"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1 INGRESO_ALUMNO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents cbTecnico As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtColegio As TextBox
    Friend WithEvents txtCorreoElectronico As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnGenerarCarnet As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents btnGUARDAR As Button
    Friend WithEvents btnSALIR As Button
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnVALIDAR As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbFechaAÑO As ComboBox
    Friend WithEvents cbFechaMES As ComboBox
    Friend WithEvents cbFechaDIA As ComboBox
    Friend WithEvents cbGENERO As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbDistrito As ComboBox
    Friend WithEvents cbComarca As ComboBox
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbPAIS As ComboBox
    Friend WithEvents cbCorregimiento As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbBachiller As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnPREGUARDAR As Button
    Friend WithEvents btnOTROS As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnValidarTelefono As Button
    Friend WithEvents btnValidarCorreo As Button
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents cbEdad As ComboBox
End Class
