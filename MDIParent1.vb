Imports System.Windows.Forms

Public Class MDIParent1
    Public numero(50) As Integer
    Public nombre(50) As String
    Public nombre2(50) As String
    Public apellido(50) As String
    Public apellido2(50) As String
    Public cedula(50) As String
    Public tecnico(50) As String
    Public edad(50) As Integer
    Public fechadia(50) As String
    Public fechames(50) As String
    Public fechanaño(50) As String
    Public correoelectronico(50) As String
    Public telefono(50) As String
    Public direccion(50) As String
    Public colegio(50) As String
    Public distrito(50) As String
    Public corregimiento(50) As String
    Public genero(50) As String
    Public provincia(50) As String
    Public comarca(50) As String
    Public pais(50) As String
    Public bachiller(50) As String
    Public imagen(50) As Integer

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO.)|*.accdb|Todos los archivos (*.*)|*.*"
        OpenFileDialog.Filter = "Archivos de texto (Libro1.)|*.xls|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO)|*.accdb|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer






    Private Sub ACCESSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCESSToolStripMenuItem.Click
        ' Configura el diálogo de apertura de archivos
        OpenFileDialog2.Filter = "Archivos de texto (*.BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO)|*.accdb|Todos los archivos (*.*)|*.*" ' Define los filtros de archivo
        OpenFileDialog2.Title = "Seleccionar un archivo" ' Título del diálogo

        ' Muestra el diálogo
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            ' Si el usuario hizo clic en OK, obtén el nombre del archivo
            Dim rutaArchivo As String = OpenFileDialog1.FileName
            MessageBox.Show("Archivo seleccionado: " & rutaArchivo)
            ' Puedes usar 'rutaArchivo' para leer o procesar el archivo
        End If
    End Sub

    Private Sub EXCELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXCELToolStripMenuItem.Click
        ' Configura el diálogo de apertura de archivos
        OpenFileDialog1.Filter = "Archivos de texto (*.Libro1)|*.xls|Todos los archivos (*.*)|*.*" ' Define los filtros de archivo
        OpenFileDialog1.Title = "Seleccionar un archivo" ' Título del diálogo

        ' Muestra el diálogo
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Si el usuario hizo clic en OK, obtén el nombre del archivo
            Dim rutaArchivo As String = OpenFileDialog1.FileName
            MessageBox.Show("Archivo seleccionado: " & rutaArchivo)
            ' Puedes usar 'rutaArchivo' para leer o procesar el archivo
        End If
    End Sub

    Private Sub ARCHIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARCHIVOToolStripMenuItem.Click
        OpenFileDialog2.Filter = "Archivos de texto (*.BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO)|*.accdb|Todos los archivos (*.*)|*.*"
    End Sub

    Private Sub EXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Archivos de texto (*.Libro1)|*.xls|Todos los archivos (*.*)|*.*"
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMOSTRARPDF_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Filter = "Archivos PDF |*.pdf "
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PdfDocument.src = OpenFileDialog1.FileNames
        End If
    End Sub

    Private Sub ViewMenu_Click(sender As Object, e As EventArgs) Handles ViewMenu.Click

    End Sub

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click

    End Sub

    Private Sub ToolsMenu_Click(sender As Object, e As EventArgs) Handles ToolsMenu.Click

    End Sub
End Class
