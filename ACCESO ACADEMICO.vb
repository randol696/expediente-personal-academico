Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ACCESO_ACADEMICO

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FS\Documents\PROYECTO BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"

        ' Se corrige el marcador a '?' y se agrega la condición de la contraseña
        Dim consulta As String = "SELECT COUNT(*) FROM [ACCESO ACADEMICO] WHERE [NOMBRE DE USUARIO] = @NOMBREDEUSUARIO"
        Dim loginExitoso As Boolean = False

        Using conexion As New OleDbConnection(cadenaConexion)
            Try
                conexion.Open()
                Using comando As New OleDbCommand(consulta, conexion)
                    ' Los parámetros se agregan en el ORDEN ESTRICTO en que aparecen en el SQL
                    comando.Parameters.AddWithValue("?", txtNOMBREACACADEMICO.Text.Trim())
                    comando.Parameters.AddWithValue("?", txtCONTRASEÑAACADEMICO.Text.Trim())

                    Dim cantidad As Integer = Convert.ToInt32(comando.ExecuteScalar())
                    If cantidad > 0 Then
                        loginExitoso = True
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS: " & ex.Message, "ERROR DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Using

        ' Lógica de acceso corregida
        If loginExitoso Then
            MessageBox.Show("INICIO DE SESIÓN EXITOSO. BIENVENIDO.", "ACCESO PERMITIDO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar campos discretamente para cuando el usuario cierre el formulario Form44
            txtNOMBREACACADEMICO.Clear()
            txtCONTRASEÑAACADEMICO.Clear()

            ' Redirección directa sin alertas molestas
            Form44_ACADEMICO.Show()
            Me.Hide()
        Else
            MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS.", "ERROR DE SEGURIDAD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNOMBREACACADEMICO.Clear()
            txtCONTRASEÑAACADEMICO.Clear()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        SISTEMA.Show()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class
