Public Class Form6
    Dim ruta As String 'alamacenar la imagen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form42_DOCUMENTOS_DE_EXPDEDIENTES_PERSONALES.Show()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Using openFileDialog As New OpenFileDialog()
            ' Configuración de la ventana única
            openFileDialog.Title = "Selecciona la imagen del diploma"
            openFileDialog.FileName = Nothing
            openFileDialog.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            openFileDialog.RestoreDirectory = True

            ' Cargar la imagen si el usuario acepta
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ruta = openFileDialog.FileName

                ' Cargar en los PictureBox
                PictureBox1.Load(ruta)
                PictureBox1.Image = Image.FromFile(ruta)

                ' Ajustar visualización
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub
End Class