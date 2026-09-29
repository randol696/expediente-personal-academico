<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.btnELIMINAR = New System.Windows.Forms.Button()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.cbCEDULA = New System.Windows.Forms.ComboBox()
        Me.cbDIPLOMAMEDIA = New System.Windows.Forms.ComboBox()
        Me.cbCREDITOBACH = New System.Windows.Forms.ComboBox()
        Me.cbFOTOCARNET = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCEDULAID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAPELLIDO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNUMERO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.BackColor = System.Drawing.Color.Silver
        Me.btnELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnELIMINAR.FlatAppearance.BorderSize = 2
        Me.btnELIMINAR.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAR.ForeColor = System.Drawing.Color.Black
        Me.btnELIMINAR.Location = New System.Drawing.Point(589, 891)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(307, 82)
        Me.btnELIMINAR.TabIndex = 134
        Me.btnELIMINAR.Text = "ELIMINAR"
        Me.btnELIMINAR.UseVisualStyleBackColor = False
        '
        'btnLIMPIAR
        '
        Me.btnLIMPIAR.BackColor = System.Drawing.Color.Blue
        Me.btnLIMPIAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLIMPIAR.FlatAppearance.BorderSize = 2
        Me.btnLIMPIAR.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIMPIAR.ForeColor = System.Drawing.Color.White
        Me.btnLIMPIAR.Location = New System.Drawing.Point(950, 891)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(307, 82)
        Me.btnLIMPIAR.TabIndex = 133
        Me.btnLIMPIAR.Text = "LIMPIAR"
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'cbCEDULA
        '
        Me.cbCEDULA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCEDULA.FormattingEnabled = True
        Me.cbCEDULA.Items.AddRange(New Object() {"✓", "✗", "vencida"})
        Me.cbCEDULA.Location = New System.Drawing.Point(195, 289)
        Me.cbCEDULA.Name = "cbCEDULA"
        Me.cbCEDULA.Size = New System.Drawing.Size(219, 35)
        Me.cbCEDULA.TabIndex = 132
        '
        'cbDIPLOMAMEDIA
        '
        Me.cbDIPLOMAMEDIA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDIPLOMAMEDIA.FormattingEnabled = True
        Me.cbDIPLOMAMEDIA.Items.AddRange(New Object() {"✓", "✗"})
        Me.cbDIPLOMAMEDIA.Location = New System.Drawing.Point(1694, 289)
        Me.cbDIPLOMAMEDIA.Name = "cbDIPLOMAMEDIA"
        Me.cbDIPLOMAMEDIA.Size = New System.Drawing.Size(121, 35)
        Me.cbDIPLOMAMEDIA.TabIndex = 131
        '
        'cbCREDITOBACH
        '
        Me.cbCREDITOBACH.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCREDITOBACH.FormattingEnabled = True
        Me.cbCREDITOBACH.Items.AddRange(New Object() {"✓", "✗"})
        Me.cbCREDITOBACH.Location = New System.Drawing.Point(1241, 289)
        Me.cbCREDITOBACH.Name = "cbCREDITOBACH"
        Me.cbCREDITOBACH.Size = New System.Drawing.Size(121, 35)
        Me.cbCREDITOBACH.TabIndex = 130
        '
        'cbFOTOCARNET
        '
        Me.cbFOTOCARNET.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFOTOCARNET.FormattingEnabled = True
        Me.cbFOTOCARNET.Items.AddRange(New Object() {"✓", "✗"})
        Me.cbFOTOCARNET.Location = New System.Drawing.Point(703, 289)
        Me.cbFOTOCARNET.Name = "cbFOTOCARNET"
        Me.cbFOTOCARNET.Size = New System.Drawing.Size(121, 35)
        Me.cbFOTOCARNET.TabIndex = 129
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1473, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 29)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "DIPLOMA MEDIA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(913, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(312, 29)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "CRÉDITO DE BACHILLER:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(499, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 29)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "FOTO CARNET:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(70, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 29)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "CÉDULA:"
        '
        'txtCEDULAID
        '
        Me.txtCEDULAID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCEDULAID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEDULAID.Location = New System.Drawing.Point(1566, 225)
        Me.txtCEDULAID.Name = "txtCEDULAID"
        Me.txtCEDULAID.Size = New System.Drawing.Size(230, 35)
        Me.txtCEDULAID.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1411, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 29)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "CÉDULA ID:"
        '
        'txtAPELLIDO
        '
        Me.txtAPELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAPELLIDO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPELLIDO.Location = New System.Drawing.Point(1130, 225)
        Me.txtAPELLIDO.Name = "txtAPELLIDO"
        Me.txtAPELLIDO.Size = New System.Drawing.Size(230, 35)
        Me.txtAPELLIDO.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(983, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "APELLIDO:"
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE.Location = New System.Drawing.Point(648, 225)
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(230, 35)
        Me.txtNOMBRE.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(516, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 29)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "NOMBRE:"
        '
        'txtNUMERO
        '
        Me.txtNUMERO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO.Location = New System.Drawing.Point(216, 225)
        Me.txtNUMERO.Name = "txtNUMERO"
        Me.txtNUMERO.Size = New System.Drawing.Size(230, 35)
        Me.txtNUMERO.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "NÚMERO:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(42, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1822, 484)
        Me.DataGridView1.TabIndex = 116
        '
        'Column1
        '
        Me.Column1.HeaderText = "NUMERO"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "APELLIDO"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "CEDULA ID"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "CEDULA"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "FOTO CARNET"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "CREDITO DE BACHILLER"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "DIPLOMA MEDIA"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox3.Location = New System.Drawing.Point(1682, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(197, 139)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 115
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox2.Location = New System.Drawing.Point(42, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 147)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 114
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1186, 68)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "INSTITUTO SUPERIOR CYC TECHNOLOGIES"
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAGREGAR.FlatAppearance.BorderSize = 2
        Me.btnAGREGAR.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR.ForeColor = System.Drawing.Color.White
        Me.btnAGREGAR.Location = New System.Drawing.Point(229, 891)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(307, 82)
        Me.btnAGREGAR.TabIndex = 112
        Me.btnAGREGAR.Text = "AGREGAR"
        Me.btnAGREGAR.UseVisualStyleBackColor = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Red
        Me.btnSALIR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSALIR.FlatAppearance.BorderSize = 2
        Me.btnSALIR.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.White
        Me.btnSALIR.Location = New System.Drawing.Point(1309, 891)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(307, 82)
        Me.btnSALIR.TabIndex = 111
        Me.btnSALIR.Text = "SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(513, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(931, 45)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "TÉCNICO SUPERIOR EN SISTEMAS INFORMÁTICOS."
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnELIMINAR)
        Me.Controls.Add(Me.btnLIMPIAR)
        Me.Controls.Add(Me.cbCEDULA)
        Me.Controls.Add(Me.cbDIPLOMAMEDIA)
        Me.Controls.Add(Me.cbCREDITOBACH)
        Me.Controls.Add(Me.cbFOTOCARNET)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCEDULAID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAPELLIDO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNOMBRE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNUMERO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAGREGAR)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form16"
        Me.Text = "TÉCNICO SUPERIOR EN SISTEMAS INFORMÁTICOS."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnELIMINAR As Button
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents cbCEDULA As ComboBox
    Friend WithEvents cbDIPLOMAMEDIA As ComboBox
    Friend WithEvents cbCREDITOBACH As ComboBox
    Friend WithEvents cbFOTOCARNET As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCEDULAID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAPELLIDO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNOMBRE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNUMERO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAGREGAR As Button
    Friend WithEvents btnSALIR As Button
    Friend WithEvents Label1 As Label
End Class
