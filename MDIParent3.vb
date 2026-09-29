Imports System.Windows.Forms

Public Class MDIParent3
    Public periodo(50) As String
    Public nombre(50) As String
    Public apellido(50) As String
    Public cedula(50) As String
    Public nota1(50) As String
    Public nota2(50) As String
    Public nota3(50) As String
    Public nota4(50) As String
    Public nota5(50) As String
    Public nota6(50) As String
    Public nota7(50) As String
    Public nota8(50) As String
    Public nota9(50) As String
    Public nota10(50) As String
    Public nota11(50) As String
    Public nota12(50) As String
    Public nota13(50) As String
    Public nota14(50) As String
    Public nota15(50) As String
    Public nota16(50) As String
    Public p1(50) As String
    Public p2(50) As String
    Public p3(50) As String
    Public p4(50) As String
    Public p5(50) As String
    Public p6(50) As String
    Public p7(50) As String
    Public p8(50) As String
    Public p9(50) As String
    Public p10(50) As String
    Public p11(50) As String
    Public p12(50) As String
    Public p13(50) As String
    Public p14(50) As String
    Public p15(50) As String
    Public p16(50) As String
    Public prof1(50) As String
    Public prof2(50) As String
    Public prof3(50) As String
    Public prof4(50) As String
    Public prof5(50) As String
    Public prof6(50) As String
    Public prof7(50) As String
    Public prof8(50) As String
    Public porf9(50) As String
    Public prof10(50) As String
    Public prof11(50) As String
    Public prof12(50) As String
    Public prof13(50) As String
    Public prof14(50) As String
    Public prof15(50) As String
    Public prof16(50) As String
    Public ASIG1(50) As String
    Public ASIG2(50) As String
    Public ASIG3(50) As String
    Public ASIG4(50) As String
    Public ASIG5(50) As String
    Public ASIG6(50) As String
    Public ASIG7(50) As String
    Public ASIG8(50) As String
    Public ASIG9(50) As String
    Public ASIG10(50) As String
    Public ASIG11(50) As String
    Public ASIG12(50) As String
    Public ASIG13(50) As String
    Public ASIG14(50) As String
    Public ASIG15(50) As String
    Public ASIG16(50) As String
    Public carrera(50) As String
    Public posicion As String

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
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

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

    Private Sub MDIParent3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ViewMenu_Click(sender As Object, e As EventArgs) Handles ViewMenu.Click
        COMUNICACIÓN_ORAL_Y_ESCRITA_001.Hide()
        OFIMÁTICA_002.Hide()
        INTRODUCCIÓN_A_LOS_AMBIENTES_VIRTUALES_003.Hide()
        HISTORIA_DE_PANAMÁ_019.Hide()
        INGLES.Hide()
        LA_COMUNICACION_DE_ENTORNOS_VIRTUALES.Hide()
        TUTORIA_EN_ENTORNOS_VIRTUALES.Hide()
        MATERIAL_DIDACTICO_EN_ENTORNOS_VIRTUALES_I.Hide()
        MATERIAL_DIDACTICO_EN_ENTORNOS_VIRTUALES_II.Hide()
        HERRAMIENTAS_TECNOLOGICAS_PARA_ENTORNOS_VIRTUALES.Hide()
        EL_APRENDIZAJE_EN_ENTORNOS_VIRTUALES.Hide()
        ETICA_Y_MORAL.Hide()
        MANEJO_DE_LAS_PLATAFORMAS_PARA_ENTORNOS_VIRTUALES.Hide()
        PLANIFICACION_Y_EVALUACION_DE_PROYECTOS.Hide()
        GEOGRAFIA_DE_PANAMA.Hide()
        TRABAJO_DE_GRADUACION.Hide()
    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click

    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub
End Class
