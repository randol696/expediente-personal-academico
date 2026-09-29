<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form47
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form47))
        Me.lbEstudiante = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEstudiante = New System.Windows.Forms.TextBox()
        Me.txtA1 = New System.Windows.Forms.TextBox()
        Me.txtA2 = New System.Windows.Forms.TextBox()
        Me.txtA3 = New System.Windows.Forms.TextBox()
        Me.txtA4 = New System.Windows.Forms.TextBox()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.txtPuntuacion = New System.Windows.Forms.TextBox()
        Me.cbTecnico = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNOTA = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbEstudiante
        '
        Me.lbEstudiante.AutoSize = True
        Me.lbEstudiante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstudiante.Location = New System.Drawing.Point(209, 114)
        Me.lbEstudiante.Name = "lbEstudiante"
        Me.lbEstudiante.Size = New System.Drawing.Size(173, 29)
        Me.lbEstudiante.TabIndex = 0
        Me.lbEstudiante.Text = "ESTUDIANTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TÉCNICO SUPERIOR:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ASIGNATURA 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(211, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ASIGNATURA 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(209, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ASIGNATURA 3:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 481)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 29)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ASIGNATURA 4:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(211, 618)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 37)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "PROMEDIO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1028, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 45)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PUNTUACIÓN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtEstudiante
        '
        Me.txtEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstudiante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstudiante.Location = New System.Drawing.Point(381, 108)
        Me.txtEstudiante.Name = "txtEstudiante"
        Me.txtEstudiante.Size = New System.Drawing.Size(875, 35)
        Me.txtEstudiante.TabIndex = 9
        '
        'txtA1
        '
        Me.txtA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA1.Location = New System.Drawing.Point(413, 254)
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(295, 35)
        Me.txtA1.TabIndex = 10
        '
        'txtA2
        '
        Me.txtA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA2.Location = New System.Drawing.Point(415, 330)
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(295, 35)
        Me.txtA2.TabIndex = 11
        '
        'txtA3
        '
        Me.txtA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3.Location = New System.Drawing.Point(413, 402)
        Me.txtA3.Name = "txtA3"
        Me.txtA3.Size = New System.Drawing.Size(295, 35)
        Me.txtA3.TabIndex = 12
        '
        'txtA4
        '
        Me.txtA4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA4.Location = New System.Drawing.Point(413, 477)
        Me.txtA4.Name = "txtA4"
        Me.txtA4.Size = New System.Drawing.Size(295, 35)
        Me.txtA4.TabIndex = 13
        '
        'txtPromedio
        '
        Me.txtPromedio.BackColor = System.Drawing.Color.Blue
        Me.txtPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPromedio.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromedio.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPromedio.Location = New System.Drawing.Point(413, 611)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(271, 53)
        Me.txtPromedio.TabIndex = 15
        '
        'txtPuntuacion
        '
        Me.txtPuntuacion.BackColor = System.Drawing.Color.Red
        Me.txtPuntuacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPuntuacion.Font = New System.Drawing.Font("Arial Black", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuntuacion.ForeColor = System.Drawing.Color.White
        Me.txtPuntuacion.Location = New System.Drawing.Point(1070, 240)
        Me.txtPuntuacion.Multiline = True
        Me.txtPuntuacion.Name = "txtPuntuacion"
        Me.txtPuntuacion.Size = New System.Drawing.Size(186, 125)
        Me.txtPuntuacion.TabIndex = 16
        '
        'cbTecnico
        '
        Me.cbTecnico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTecnico.FormattingEnabled = True
        Me.cbTecnico.Items.AddRange(New Object() {"TÉCNICO SUPERIOR EN RELACIONES HUMANAS Y ADMINISTRACIÓN DE EMPRESA.", "TÉCNICO SUPERIOR EN ADMINISTRACIÓN ESCOLAR.", "TÉCNICO SUPERIOR EN INFORMÁTICA CON ÉNFASIS EN MANEJO DE SOFTWARE E INTERNET.", "TÉCNICO SUPERIOR EN INFORMÁTICA EDUCATIVA.", "TÉCNICO SUPERIOR EN REPARACIÓN Y MANTENIMIENTO DE COMPUTADORAS.", "TÉCNICO SUPERIOR EN ENTORNOS VIRTUALES.", "TÉCNICO SUPERIOR EN CUIDADOS DEL INFANTE #1", "TÉCNICO SUPERIOR EN CUIDADOS DEL INFANTE #2", "TÉCNICO SUPERIOR EN SISTEMAS INFORMÁTICOS.", "TÉCNICO SUPERIOR EN REGISTROS CONTABLES.", "TÉCNICO SUPERIOR EN COSMETOLOGÍA Y ESTÉTICA.", "TÉCNICO SUPERIOR EN CORTE Y CONFECCIÓN.", "TÉCNICO SUPERIOR EN RECURSOS NATURALES Y MEDIO AMBIENTE.", "TÉCNICO SUPERIOR EN INGLES COMPUTACIONAL PARA DOCENTE.", "TÉCNICO SUPERIOR EN INGLES COMPUTACIONAL.", "TÉCNICO SUPERIOR EN ELECTRÓNICA.", "TÉCNICO SUPERIOR EN ARTES CULINARIAS.", "TÉCNICO SUPERIOR EN TURISMO NACIONAL.", "TÉCNICO SUPERIOR EN MANEJO Y CUIDADO ANIMAL.", "TÉCNICO SUPERIOR EN CUIDADOS DEL ADULTO MAYOR."})
        Me.cbTecnico.Location = New System.Drawing.Point(473, 175)
        Me.cbTecnico.Name = "cbTecnico"
        Me.cbTecnico.Size = New System.Drawing.Size(1167, 35)
        Me.cbTecnico.TabIndex = 17
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcular.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(323, 712)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(260, 105)
        Me.btnCalcular.TabIndex = 18
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(735, 712)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(260, 105)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(1159, 712)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(260, 105)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(456, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1006, 73)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "REGISTRO ACADÉMICO DE NOTAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.images_cc
        Me.PictureBox1.Location = New System.Drawing.Point(23, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1100, 567)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 45)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "NOTA"
        '
        'txtNOTA
        '
        Me.txtNOTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOTA.Font = New System.Drawing.Font("Arial Black", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOTA.Location = New System.Drawing.Point(1100, 455)
        Me.txtNOTA.Multiline = True
        Me.txtNOTA.Name = "txtNOTA"
        Me.txtNOTA.Size = New System.Drawing.Size(119, 98)
        Me.txtNOTA.TabIndex = 24
        '
        'Form47
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1722, 965)
        Me.Controls.Add(Me.txtNOTA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.cbTecnico)
        Me.Controls.Add(Me.txtPuntuacion)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.txtA4)
        Me.Controls.Add(Me.txtA3)
        Me.Controls.Add(Me.txtA2)
        Me.Controls.Add(Me.txtA1)
        Me.Controls.Add(Me.txtEstudiante)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbEstudiante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form47"
        Me.Text = "PROMEDIO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbEstudiante As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEstudiante As TextBox
    Friend WithEvents txtA1 As TextBox
    Friend WithEvents txtA2 As TextBox
    Friend WithEvents txtA3 As TextBox
    Friend WithEvents txtA4 As TextBox
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents txtPuntuacion As TextBox
    Friend WithEvents cbTecnico As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNOTA As TextBox
End Class
