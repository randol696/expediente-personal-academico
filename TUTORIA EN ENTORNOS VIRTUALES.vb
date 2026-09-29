Imports System.Data.OleDb
Imports System.Xml
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Cryptography.X509Certificates

Public Class TUTORIA_EN_ENTORNOS_VIRTUALES
    Public pos As String
    Dim con As New OleDbConnection
    Dim sql As New OleDbCommand
    Dim consulta As String = ""
    Dim dr As OleDbDataAdapter
    Dim ord As DataSet
    Dim busca As Byte
    Dim numero As Integer
    Dim conexion As String
    Dim comando As String
    Dim posicion As String

    Private Sub btnGRABAR_Click(sender As Object, e As EventArgs) Handles btnGRABAR.Click

        MessageBox.Show("Esta Seguro de los Datos", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        lvDATOS.Items.Add(txtNOMBRECURSO.Text)
        lvDATOS.Items.Add(txtPERIODO.Text)
        lvDATOS.Items.Add(txtNOMBREESTUDIANTE.Text)
        lvDATOS.Items.Add(txtAPELLIDO.Text)
        lvDATOS.Items.Add(txtNUMEROCEDULA.Text)
        lvDATOS.Items.Add(txtNOTA.Text)
        lvDATOS.Items.Add(txtPUNTUACION.Text)
        lvDATOS.Items.Add(txtCARRERA.Text)
        lvDATOS.Items.Add(txtPROFE.Text)
        Dim f8 As New Form8()
    End Sub



    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        If MessageBox.Show("DESEA SALIR DEL FORMULARIO DE HISTORIA DE PANAMÁ 019", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
        NOTAS_DE_ENVIO_ENTORNOS_VIRTUALES.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        txtNOMBRECURSO.Text = " "
        txtPERIODO.Text = " "
        txtNOMBREESTUDIANTE.Text = " "
        txtAPELLIDO.Text = " "
        txtNUMEROCEDULA.Text = " "
        txtNOTA.Text = " "
        txtPUNTUACION.Text = " "
        txtCARRERA.Text = " "
        txtPROFE.Text = " "
    End Sub

    Private Sub lvDATOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDATOS.SelectedIndexChanged
        Dim f8 As New Form8()
    End Sub

    Private Sub btnENVIAR_Click(sender As Object, e As EventArgs) Handles btnENVIAR.Click
        ' 1. Crear una subrutina interna para asignar los datos a cualquier módulo
        Dim asignarDatos = Sub(mod_curso As String, ByRef m_curso As String, ByRef m_per As String, ByRef m_nom As String, ByRef m_ape As String, ByRef m_ced As String, ByRef m_nota As String, ByRef m_punt As String, ByRef m_car As String, ByRef m_prof As String)
                               m_curso = txtNOMBRECURSO.Text
                               m_per = txtPERIODO.Text
                               m_nom = txtNOMBREESTUDIANTE.Text
                               m_ape = txtAPELLIDO.Text
                               m_ced = txtNUMEROCEDULA.Text
                               m_nota = txtNOTA.Text
                               m_punt = txtPUNTUACION.Text
                               m_car = txtCARRERA.Text
                               m_prof = txtPROFE.Text
                           End Sub

        ' 2. Asignar los valores a cada uno de tus módulos de forma directa
        asignarDatos(txtNOMBRECURSO.Text, Module4.curso, Module4.periodo, Module4.nombre, Module4.apellido, Module4.cedula, Module4.nota1, Module4.p1, Module4.carrera, Module4.profesor)


        ' 3. Crear y abrir una sola instancia de Form8 al final del proceso
        Dim f8 As New Form8()
    End Sub


    Private Sub COMUNICACIÓN_ORAL_Y_ESCRITA_001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"
            con.Open()
            MsgBox("CONECTADA CORRECTAMENTE", MsgBoxStyle.Information, "AVISO")
        Catch ex As Exception
            MsgBox("ERROR CORREXION", MsgBoxStyle.Critical, "AVISO")
        End Try
    End Sub

    Private Sub btnVERIFICAR_Click(sender As Object, e As EventArgs) Handles btnVERIFICARNOTA.Click
        numero = txtNUMEROCEDULA.Text
        For x = 0 To 50
            If numero = MDIParent4.cedula(x) Then
                posicion = x
            End If
        Next
        txtNOMBRECURSO.Text = MDIParent4.curso(posicion)
        txtNOMBREESTUDIANTE.Text = MDIParent4.nombre(posicion)
        txtAPELLIDO.Text = MDIParent4.apellido(posicion)
        txtNUMEROCEDULA.Text = MDIParent4.cedula(posicion)
        txtCARRERA.Text = MDIParent4.carrera(posicion)
        txtPERIODO.Text = MDIParent4.periodo(posicion)
        txtPROFE.Text = MDIParent4.profesor(posicion)
        txtPUNTUACION.Text = MDIParent4.puntuacion7(posicion)
        txtNOTA.Text = MDIParent4.nota7(pos)
        Dim rutaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"

        ' 1. SENTENCIA SQL: 6 columnas declaradas y exactamente 6 signos de interrogación
        Dim sql As String = "INSERT INTO [NOTA DEL ESTUDIANTE COMUNICACIÓN ORAL Y ESCRITA 001] " &
                     "([NOMBRE DEL CURSO], PERIODO, [NOMBRE DEL ESTUDIANTE], [APELLIDO DEL ESTUDIANTE], [NÚMERO DE CÉDULA], NOTA) " &
                     "VALUES (?, ?, ?, ?, ?, ?)"

        ' 2. USO DE BLOQUE USING: Asegura el cierre de la conexión de forma automática
        Using conexion As New OleDbConnection(rutaConexion)
            Using comando As New OleDbCommand(sql, conexion)

                ' 3. PARÁMETROS EN EL ORDEN EXACTO DE LAS COLUMNAS REQUERIDAS
                comando.Parameters.AddWithValue("?", txtNOMBRECURSO.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtPERIODO.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtNOMBREESTUDIANTE.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAPELLIDO.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtNUMEROCEDULA.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtNOTA.Text.ToUpper().Trim()) ' Mover al final para que coincida con la columna NOTA
                comando.Parameters.AddWithValue("?", txtPROFE.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtPUNTUACION.Text.ToUpper().Trim())

                ' 4. CONTROL DE ERRORES Y EJECUCIÓN
                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub

End Class