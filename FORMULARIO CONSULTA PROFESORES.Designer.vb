<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMULARIO_CONSULTA_PROFESORES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORMULARIO_CONSULTA_PROFESORES))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnVERIFICARDATOSPROFESORES = New System.Windows.Forms.Button()
        Me.btnSALIRAACADEMICA = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.btnINGRESAR = New System.Windows.Forms.Button()
        Me.btnEXPORTAR = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnPRINT = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCOMARCAPROFESOR = New System.Windows.Forms.TextBox()
        Me.txtPROVINCIAPROFESOR = New System.Windows.Forms.TextBox()
        Me.txtPAISPROFESOR = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGENEROPROFESOR = New System.Windows.Forms.TextBox()
        Me.txtEDADPROFESOR = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTelefonoProfesor = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorreoElectronicoProfesor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtCURSOPROFESOR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(608, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(741, 33)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "INFORMACIÓN DE DATOS DE LOS PROFESORES (AS)"
        '
        'btnVERIFICARDATOSPROFESORES
        '
        Me.btnVERIFICARDATOSPROFESORES.BackColor = System.Drawing.Color.Blue
        Me.btnVERIFICARDATOSPROFESORES.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVERIFICARDATOSPROFESORES.FlatAppearance.BorderSize = 2
        Me.btnVERIFICARDATOSPROFESORES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVERIFICARDATOSPROFESORES.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVERIFICARDATOSPROFESORES.ForeColor = System.Drawing.Color.White
        Me.btnVERIFICARDATOSPROFESORES.Location = New System.Drawing.Point(441, 162)
        Me.btnVERIFICARDATOSPROFESORES.Name = "btnVERIFICARDATOSPROFESORES"
        Me.btnVERIFICARDATOSPROFESORES.Size = New System.Drawing.Size(305, 81)
        Me.btnVERIFICARDATOSPROFESORES.TabIndex = 70
        Me.btnVERIFICARDATOSPROFESORES.Text = "VERIFICAR DATOS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PROFESORES"
        Me.btnVERIFICARDATOSPROFESORES.UseVisualStyleBackColor = False
        '
        'btnSALIRAACADEMICA
        '
        Me.btnSALIRAACADEMICA.BackColor = System.Drawing.Color.Red
        Me.btnSALIRAACADEMICA.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSALIRAACADEMICA.FlatAppearance.BorderSize = 2
        Me.btnSALIRAACADEMICA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSALIRAACADEMICA.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIRAACADEMICA.ForeColor = System.Drawing.Color.White
        Me.btnSALIRAACADEMICA.Location = New System.Drawing.Point(379, 885)
        Me.btnSALIRAACADEMICA.Name = "btnSALIRAACADEMICA"
        Me.btnSALIRAACADEMICA.Size = New System.Drawing.Size(1162, 85)
        Me.btnSALIRAACADEMICA.TabIndex = 90
        Me.btnSALIRAACADEMICA.Text = "REGRESA AL SISTEMA PERSONAL"
        Me.btnSALIRAACADEMICA.UseVisualStyleBackColor = False
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.White
        Me.pbImagen.Image = Global.WindowsApp1.My.Resources.Resources.CARNET
        Me.pbImagen.Location = New System.Drawing.Point(1552, 218)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(335, 402)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 89
        Me.pbImagen.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox1.Location = New System.Drawing.Point(1722, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox3.Location = New System.Drawing.Point(31, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(181, 121)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 58
        Me.PictureBox3.TabStop = False
        '
        'btnLIMPIAR
        '
        Me.btnLIMPIAR.BackColor = System.Drawing.Color.Silver
        Me.btnLIMPIAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLIMPIAR.FlatAppearance.BorderSize = 2
        Me.btnLIMPIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLIMPIAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIMPIAR.ForeColor = System.Drawing.Color.Black
        Me.btnLIMPIAR.Location = New System.Drawing.Point(770, 162)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(305, 77)
        Me.btnLIMPIAR.TabIndex = 93
        Me.btnLIMPIAR.Text = "LIMPIAR DATOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PROFESORES"
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'btnINGRESAR
        '
        Me.btnINGRESAR.BackColor = System.Drawing.Color.Red
        Me.btnINGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnINGRESAR.FlatAppearance.BorderSize = 2
        Me.btnINGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnINGRESAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINGRESAR.ForeColor = System.Drawing.Color.White
        Me.btnINGRESAR.Location = New System.Drawing.Point(1106, 162)
        Me.btnINGRESAR.Name = "btnINGRESAR"
        Me.btnINGRESAR.Size = New System.Drawing.Size(305, 81)
        Me.btnINGRESAR.TabIndex = 94
        Me.btnINGRESAR.Text = "INGRESAR A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCESS"
        Me.btnINGRESAR.UseVisualStyleBackColor = False
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
        Me.btnEXPORTAR.Location = New System.Drawing.Point(1552, 750)
        Me.btnEXPORTAR.Name = "btnEXPORTAR"
        Me.btnEXPORTAR.Size = New System.Drawing.Size(114, 106)
        Me.btnEXPORTAR.TabIndex = 95
        Me.btnEXPORTAR.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnPRINT
        '
        Me.btnPRINT.BackColor = System.Drawing.Color.Blue
        Me.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPRINT.FlatAppearance.BorderSize = 2
        Me.btnPRINT.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPRINT.ForeColor = System.Drawing.Color.White
        Me.btnPRINT.Location = New System.Drawing.Point(1672, 750)
        Me.btnPRINT.Name = "btnPRINT"
        Me.btnPRINT.Size = New System.Drawing.Size(215, 106)
        Me.btnPRINT.TabIndex = 108
        Me.btnPRINT.Text = "PRINT"
        Me.btnPRINT.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCOMARCAPROFESOR)
        Me.GroupBox2.Controls.Add(Me.txtPROVINCIAPROFESOR)
        Me.GroupBox2.Controls.Add(Me.txtPAISPROFESOR)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(83, 592)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1435, 192)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIRECCIÓN PERSONAL DE PROFESOR (A)"
        '
        'txtCOMARCAPROFESOR
        '
        Me.txtCOMARCAPROFESOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOMARCAPROFESOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOMARCAPROFESOR.Location = New System.Drawing.Point(758, 137)
        Me.txtCOMARCAPROFESOR.Name = "txtCOMARCAPROFESOR"
        Me.txtCOMARCAPROFESOR.Size = New System.Drawing.Size(401, 35)
        Me.txtCOMARCAPROFESOR.TabIndex = 29
        '
        'txtPROVINCIAPROFESOR
        '
        Me.txtPROVINCIAPROFESOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPROVINCIAPROFESOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPROVINCIAPROFESOR.Location = New System.Drawing.Point(164, 136)
        Me.txtPROVINCIAPROFESOR.Name = "txtPROVINCIAPROFESOR"
        Me.txtPROVINCIAPROFESOR.Size = New System.Drawing.Size(394, 35)
        Me.txtPROVINCIAPROFESOR.TabIndex = 28
        '
        'txtPAISPROFESOR
        '
        Me.txtPAISPROFESOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPAISPROFESOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAISPROFESOR.Location = New System.Drawing.Point(305, 66)
        Me.txtPAISPROFESOR.Name = "txtPAISPROFESOR"
        Me.txtPAISPROFESOR.Size = New System.Drawing.Size(854, 35)
        Me.txtPAISPROFESOR.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(614, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 27)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "COMARCA:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 27)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "PROVINCIA:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(290, 27)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "PAÍS DE PROCEDENCIA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 829)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 27)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "CURSO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGENEROPROFESOR)
        Me.GroupBox1.Controls.Add(Me.txtEDADPROFESOR)
        Me.GroupBox1.Controls.Add(Me.txtApellido2)
        Me.GroupBox1.Controls.Add(Me.txtNombre2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoProfesor)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElectronicoProfesor)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(83, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1435, 278)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN PERSONAL DE PROFESOR (A)"
        '
        'txtGENEROPROFESOR
        '
        Me.txtGENEROPROFESOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGENEROPROFESOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGENEROPROFESOR.Location = New System.Drawing.Point(477, 134)
        Me.txtGENEROPROFESOR.Name = "txtGENEROPROFESOR"
        Me.txtGENEROPROFESOR.Size = New System.Drawing.Size(230, 35)
        Me.txtGENEROPROFESOR.TabIndex = 53
        '
        'txtEDADPROFESOR
        '
        Me.txtEDADPROFESOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEDADPROFESOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEDADPROFESOR.Location = New System.Drawing.Point(116, 134)
        Me.txtEDADPROFESOR.Name = "txtEDADPROFESOR"
        Me.txtEDADPROFESOR.Size = New System.Drawing.Size(112, 35)
        Me.txtEDADPROFESOR.TabIndex = 52
        '
        'txtApellido2
        '
        Me.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(1157, 62)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(193, 35)
        Me.txtApellido2.TabIndex = 51
        '
        'txtNombre2
        '
        Me.txtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(380, 62)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(193, 35)
        Me.txtNombre2.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(338, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 27)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "GÉNERO:"
        '
        'txtTelefonoProfesor
        '
        Me.txtTelefonoProfesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoProfesor.Location = New System.Drawing.Point(182, 220)
        Me.txtTelefonoProfesor.Name = "txtTelefonoProfesor"
        Me.txtTelefonoProfesor.Size = New System.Drawing.Size(230, 35)
        Me.txtTelefonoProfesor.TabIndex = 26
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(953, 62)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(193, 35)
        Me.txtApellido.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRES:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(797, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "APELLIDOS:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(168, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 35)
        Me.txtNombre.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(786, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(302, 27)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CORREO ELECTRÓNICO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 27)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "TELÉFONO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "EDAD:"
        '
        'txtCorreoElectronicoProfesor
        '
        Me.txtCorreoElectronicoProfesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreoElectronicoProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoElectronicoProfesor.Location = New System.Drawing.Point(1095, 134)
        Me.txtCorreoElectronicoProfesor.Name = "txtCorreoElectronicoProfesor"
        Me.txtCorreoElectronicoProfesor.Size = New System.Drawing.Size(323, 35)
        Me.txtCorreoElectronicoProfesor.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CÉDULA:"
        '
        'txtCedula
        '
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(214, 205)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(201, 35)
        Me.txtCedula.TabIndex = 17
        '
        'txtCURSOPROFESOR
        '
        Me.txtCURSOPROFESOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCURSOPROFESOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCURSOPROFESOR.Location = New System.Drawing.Point(223, 821)
        Me.txtCURSOPROFESOR.Name = "txtCURSOPROFESOR"
        Me.txtCURSOPROFESOR.Size = New System.Drawing.Size(1269, 35)
        Me.txtCURSOPROFESOR.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1089, 62)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "INSTITUTO SUPERIOR CYC TECHNOLOGIES"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1552, 635)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(335, 110)
        Me.Button1.TabIndex = 129
        Me.Button1.Text = "PRINT PREVIEW"
        Me.Button1.UseVisualStyleBackColor = False
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
        'FORMULARIO_CONSULTA_PROFESORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCURSOPROFESOR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPRINT)
        Me.Controls.Add(Me.btnEXPORTAR)
        Me.Controls.Add(Me.btnINGRESAR)
        Me.Controls.Add(Me.btnLIMPIAR)
        Me.Controls.Add(Me.btnSALIRAACADEMICA)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.btnVERIFICARDATOSPROFESORES)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCedula)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FORMULARIO_CONSULTA_PROFESORES"
        Me.Text = "FORMULARIO_CONSULTA_PROFESORES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnVERIFICARDATOSPROFESORES As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnSALIRAACADEMICA As Button
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents btnINGRESAR As Button
    Friend WithEvents btnEXPORTAR As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnPRINT As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGENEROPROFESOR As TextBox
    Friend WithEvents txtEDADPROFESOR As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTelefonoProfesor As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorreoElectronicoProfesor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtCOMARCAPROFESOR As TextBox
    Friend WithEvents txtPROVINCIAPROFESOR As TextBox
    Friend WithEvents txtPAISPROFESOR As TextBox
    Friend WithEvents txtCURSOPROFESOR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
