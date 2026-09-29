<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class ACCESO_ACADEMICO
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACCESO_ACADEMICO))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtCONTRASEÑAACADEMICO = New System.Windows.Forms.TextBox()
        Me.txtNOMBREACACADEMICO = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(779, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 43)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ACCESO ACADÉMICO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1280, 73)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "INSTITUTO SUPERIOR CYC TECHNOLOGIES"
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Blue
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(1051, 946)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(580, 100)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "CANCELAR"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Blue
        Me.OK.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(320, 946)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(580, 100)
        Me.OK.TabIndex = 13
        Me.OK.Text = "ACEPTAR"
        Me.OK.UseVisualStyleBackColor = False
        '
        'txtCONTRASEÑAACADEMICO
        '
        Me.txtCONTRASEÑAACADEMICO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCONTRASEÑAACADEMICO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTRASEÑAACADEMICO.Location = New System.Drawing.Point(891, 887)
        Me.txtCONTRASEÑAACADEMICO.Name = "txtCONTRASEÑAACADEMICO"
        Me.txtCONTRASEÑAACADEMICO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCONTRASEÑAACADEMICO.Size = New System.Drawing.Size(376, 35)
        Me.txtCONTRASEÑAACADEMICO.TabIndex = 12
        '
        'txtNOMBREACACADEMICO
        '
        Me.txtNOMBREACACADEMICO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBREACACADEMICO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREACACADEMICO.Location = New System.Drawing.Point(927, 827)
        Me.txtNOMBREACACADEMICO.Name = "txtNOMBREACACADEMICO"
        Me.txtNOMBREACACADEMICO.Size = New System.Drawing.Size(376, 35)
        Me.txtNOMBREACACADEMICO.TabIndex = 10
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(691, 887)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(194, 35)
        Me.PasswordLabel.TabIndex = 11
        Me.PasswordLabel.Text = "CONTRASEÑA:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(628, 827)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(293, 35)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "NOMBRE DE USUARIO:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.White
        Me.LogoPictureBox.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.LogoPictureBox.Location = New System.Drawing.Point(589, 184)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(781, 613)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'ACCESO_ACADEMICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtCONTRASEÑAACADEMICO)
        Me.Controls.Add(Me.txtNOMBREACACADEMICO)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACCESO_ACADEMICO"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ACCESO_ACADEMICO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents txtCONTRASEÑAACADEMICO As TextBox
    Friend WithEvents txtNOMBREACACADEMICO As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
End Class
