<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SISTEMA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SISTEMA))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnADMINISTRADOR = New System.Windows.Forms.Button()
        Me.btnACADEMICO = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.PictureBox1.Location = New System.Drawing.Point(498, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(954, 663)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1732, 136)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SISTEMA INTEGRAL DE GESTIÓN DE EXPEDIENTE PERSONAL Y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                    ACADÉM" &
    "ICO DE LOS ESTUDIANTES"
        '
        'btnADMINISTRADOR
        '
        Me.btnADMINISTRADOR.BackColor = System.Drawing.Color.Blue
        Me.btnADMINISTRADOR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnADMINISTRADOR.FlatAppearance.BorderSize = 2
        Me.btnADMINISTRADOR.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADMINISTRADOR.ForeColor = System.Drawing.Color.White
        Me.btnADMINISTRADOR.Location = New System.Drawing.Point(169, 878)
        Me.btnADMINISTRADOR.Name = "btnADMINISTRADOR"
        Me.btnADMINISTRADOR.Size = New System.Drawing.Size(512, 92)
        Me.btnADMINISTRADOR.TabIndex = 6
        Me.btnADMINISTRADOR.Text = "ADMINISTRADOR"
        Me.btnADMINISTRADOR.UseVisualStyleBackColor = False
        '
        'btnACADEMICO
        '
        Me.btnACADEMICO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnACADEMICO.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnACADEMICO.FlatAppearance.BorderSize = 2
        Me.btnACADEMICO.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnACADEMICO.ForeColor = System.Drawing.Color.White
        Me.btnACADEMICO.Location = New System.Drawing.Point(721, 878)
        Me.btnACADEMICO.Name = "btnACADEMICO"
        Me.btnACADEMICO.Size = New System.Drawing.Size(512, 92)
        Me.btnACADEMICO.TabIndex = 7
        Me.btnACADEMICO.Text = "ACADÉMICO"
        Me.btnACADEMICO.UseVisualStyleBackColor = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Red
        Me.btnSALIR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSALIR.FlatAppearance.BorderSize = 2
        Me.btnSALIR.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.White
        Me.btnSALIR.Location = New System.Drawing.Point(1272, 878)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(512, 92)
        Me.btnSALIR.TabIndex = 8
        Me.btnSALIR.Text = "SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'SISTEMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.btnACADEMICO)
        Me.Controls.Add(Me.btnADMINISTRADOR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SISTEMA"
        Me.Text = "SISTEMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnADMINISTRADOR As Button
    Friend WithEvents btnACADEMICO As Button
    Friend WithEvents btnSALIR As Button
End Class
