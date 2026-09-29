<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class ACCESO_ADMINISTRADOR
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtNOMBREADMINISTRADOR As System.Windows.Forms.TextBox
    Friend WithEvents txtCONTRASEÑAADMINISTRADOR As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACCESO_ADMINISTRADOR))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtNOMBREADMINISTRADOR = New System.Windows.Forms.TextBox()
        Me.txtCONTRASEÑAADMINISTRADOR = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(697, 831)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(290, 35)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "NOMBRE DE USUARIO:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(755, 888)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(194, 35)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "CONTRASEÑA:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNOMBREADMINISTRADOR
        '
        Me.txtNOMBREADMINISTRADOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBREADMINISTRADOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBREADMINISTRADOR.Location = New System.Drawing.Point(984, 831)
        Me.txtNOMBREADMINISTRADOR.Name = "txtNOMBREADMINISTRADOR"
        Me.txtNOMBREADMINISTRADOR.Size = New System.Drawing.Size(359, 35)
        Me.txtNOMBREADMINISTRADOR.TabIndex = 1
        '
        'txtCONTRASEÑAADMINISTRADOR
        '
        Me.txtCONTRASEÑAADMINISTRADOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCONTRASEÑAADMINISTRADOR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTRASEÑAADMINISTRADOR.Location = New System.Drawing.Point(955, 888)
        Me.txtCONTRASEÑAADMINISTRADOR.Name = "txtCONTRASEÑAADMINISTRADOR"
        Me.txtCONTRASEÑAADMINISTRADOR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCONTRASEÑAADMINISTRADOR.Size = New System.Drawing.Size(359, 35)
        Me.txtCONTRASEÑAADMINISTRADOR.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Blue
        Me.OK.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(349, 946)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(580, 100)
        Me.OK.TabIndex = 4
        Me.OK.Text = "ACEPTAR"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Blue
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(1096, 946)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(580, 100)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "CANCELAR"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.White
        Me.LogoPictureBox.Image = Global.WindowsApp1.My.Resources.Resources.IMG_2897___Editado
        Me.LogoPictureBox.Location = New System.Drawing.Point(593, 215)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(836, 580)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1280, 73)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "INSTITUTO SUPERIOR CYC TECHNOLOGIES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(779, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(483, 43)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ACCESO ADMINISTRADOR"
        '
        'ACCESO_ADMINISTRADOR
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtCONTRASEÑAADMINISTRADOR)
        Me.Controls.Add(Me.txtNOMBREADMINISTRADOR)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACCESO_ADMINISTRADOR"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ACCESO_ADMINISTRADOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
