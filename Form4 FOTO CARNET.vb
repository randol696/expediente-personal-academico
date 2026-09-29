Public Class Form4
    Dim ruta As String 'alamacenar la imagen
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form42_DOCUMENTOS_DE_EXPDEDIENTES_PERSONALES.Show()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Using openFileDialog As New OpenFileDialog()
            ' Configuración del cuadro de diálogo único
            openFileDialog.Title = "Selecciona la imagen del carnet"
            openFileDialog.FileName = Nothing
            openFileDialog.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            openFileDialog.RestoreDirectory = True

            ' Si el usuario selecciona la imagen y acepta
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Guardar la ruta del archivo seleccionado
                ruta = openFileDialog.FileName

                ' Cargar la imagen en todos los PictureBox correspondientes
                PictureBox1.Load(ruta)
                PictureBox2.Load(ruta)
                PictureBox1.Image = Image.FromFile(ruta)

                ' Configurar el modo de visualización para que la imagen no se deforme
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form42_DOCUMENTOS_DE_EXPDEDIENTES_PERSONALES.Show()
    End Sub
End Class