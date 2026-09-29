Public Class Form3
    Dim ruta As String 'alamacenar la imagen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form42_DOCUMENTOS_DE_EXPDEDIENTES_PERSONALES.Show()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Using openFileDialog1 As New OpenFileDialog()
            ' Configuración del cuadro de diálogo
            openFileDialog1.Title = "Selecciona la imagen de la cédula"
            openFileDialog1.FileName = Nothing
            openFileDialog1.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            openFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            openFileDialog1.RestoreDirectory = True

            ' Si el usuario selecciona una imagen y presiona OK
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Guardar la ruta en la variable global
                ruta = openFileDialog1.FileName

                ' Cargar la imagen en el primer PictureBox
                PictureBox1.Load(ruta)

                ' Cargar la imagen en el segundo PictureBox con ajuste Zoom
                PictureBox1.Image = Image.FromFile(ruta)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        ' 1. Creamos la instancia del nuevo formulario
        Dim f7 As New Form7_LISTA_DE_ENTORNOS_VIRTUALES()

        ' 2. Lo mostramos en la pantalla de forma interactiva
        f7.Show()
    End Sub
End Class