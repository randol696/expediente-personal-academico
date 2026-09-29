Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Drawing.Text
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AxAcroPDFLib

Public Class Form2
    Dim cedula As String
    Dim posicion As Integer
    Dim conection As String
    Dim link As String
    Dim ruta As Integer ' almacenar la imagen

    Public Property PdfWriter As Object
    Public Property AxAcroPDF1 As Object

    Private Sub btnVERIFICARDATOSClick(sender As Object, e As EventArgs) Handles btnVERIFICARDATOS.Click
        cedula = txtCedula.Text
        For x = 0 To 50
            If cedula = MDIParent1.cedula(x) Then
                posicion = x
            End If
        Next
        txtNombre.Text = MDIParent1.nombre(posicion)
        txtNombre2.Text = MDIParent1.nombre2(posicion)
        txtApellido.Text = MDIParent1.apellido(posicion)
        txtAPELLIDO2.Text = MDIParent1.apellido2(posicion)
        txtCedula.Text = MDIParent1.cedula(posicion)
        txtTecnico.Text = MDIParent1.tecnico(posicion)
        txtEdad.Text = MDIParent1.edad(posicion)
        txtFECHADIA.Text = MDIParent1.fechadia(posicion)
        txtFECHAMES.Text = MDIParent1.fechames(posicion)
        txtFECHAAÑO.Text = MDIParent1.fechanaño(posicion)
        txtCorreo.Text = MDIParent1.correoelectronico(posicion)
        txtTelefono.Text = MDIParent1.telefono(posicion)
        txtDireccion.Text = MDIParent1.direccion(posicion)
        txtColegio.Text = MDIParent1.colegio(posicion)
        txtDistrito.Text = MDIParent1.distrito(posicion)
        txtCorregimiento.Text = MDIParent1.corregimiento(posicion)
        txtGenero.Text = MDIParent1.genero(posicion)
        txtProvincia.Text = MDIParent1.provincia(posicion)
        txtComarca.Text = MDIParent1.comarca(posicion)
        txtPais.Text = MDIParent1.pais(posicion)
        txtBachiller.Text = MDIParent1.bachiller(posicion)
    End Sub


    Private Sub pbImagen_Click(sender As Object, e As EventArgs) Handles pbImagen2.Click
        With OpenFileDialog2
            .Title = "SELECCIONA UNA IMAGEN"
            .FileName = Nothing
            .Filter = "Archivos JPG|*.jpg"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures

            If (.ShowDialog() = DialogResult.OK) Then
                pbImagen2.Load(.FileName)
                ruta = .FileName
            End If
        End With
    End Sub


    Private Sub Form2_FontChange(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Close()
    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Hide()
        Form41_PERSONAL.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnINGRESAR.Click
        ' 1. Conexión y Consulta SQL limpia con exactamente 20 campos y 20 signos (?)
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb")

        Dim sql As String = "INSERT INTO [CONSULTA DE DATOS DE LOS ESTUDIANTES] " &
                    "(CÉDULA, [PRIMER NOMBRE], [SEGUNDO NOMBRE], [APELLIDO PATERNO], [APELLIDO MATERNO], CARRERA, EDAD, [FECHA DE NACIMIENTO], DIRECCIÓN, DISTRITO, CORREGIMIENTO, [COLEGIO SECUNDARIO], [CORREO ELECTRÓNICO], TELÉFONO, GÉNERO, PROVINCIA, COMARCA, [PAÍS DE PROCEDENCIA], ESCUELA, BACHILLER) " &
                    "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Dim comando As New OleDbCommand(sql, conexion)

        ' 2. Consolidación de la fecha
        Dim fechaNacimiento As String = $"{txtFECHADIA.Text}/{txtFECHAMES.Text}/{txtFECHAAÑO.Text}"

        ' 3. Parámetros agregados en el ORDEN EXACTO de los campos de arriba
        comando.Parameters.AddWithValue("?", txtCedula.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtNombre.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtNombre2.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtApellido.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtApellido2.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtTecnico.Text.ToUpper()) ' Mapea a CARRERA
        comando.Parameters.AddWithValue("?", txtEdad.Text.ToUpper())
        comando.Parameters.AddWithValue("?", fechaNacimiento.ToUpper())
        comando.Parameters.AddWithValue("?", txtDireccion.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtDistrito.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtCorregimiento.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtColegio.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtCorreo.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtTelefono.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtGenero.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtProvincia.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtComarca.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtPais.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtBachiller.Text.ToUpper())

        ' 4. Control de conexión y ejecución segura
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Cierra la conexión de forma correcta siempre
            conexion.Close()
        End Try

    End Sub


    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
        txtTecnico.Text = ""
        txtEdad.Text = ""
        txtFECHADIA.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtColegio.Text = ""
        txtDistrito.Text = ""
        txtCorregimiento.Text = ""
        txtGenero.Text = ""
        txtProvincia.Text = ""
        txtPais.Text = ""
        txtBachiller.Text = ""
        pbImagen2.Image = Nothing
    End Sub

    ' Asegúrate de tener las referencias y los controles en tu formulario
    ' (ChartControl, GridControl, etc.)

    Private Sub btnEXPORTAR_Click(sender As Object, d As EventArgs) Handles btnEXPORTAR.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    ' También puedes cargar un archivo directamente si conoces la ruta:

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub btnPRINT_Click(sender As Object, e As EventArgs) Handles btnPRINT.Click
        PrintDialog1.Document = PrintDocument1

        ' Show the PrintDialog and check if the user clicked OK
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            ' Initiate the printing process, which raises the PrintPage event
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' CORREGIDO: Ahora asigna el documento correcto (PrintDocument3)
        PrintPreviewDialog1.Document = PrintDocument3
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument3.PrintPage
        ' Usar "Using" asegura que las fuentes se liberen de la memoria correctamente
        Using fontNormal As New Font("Arial", 12, FontStyle.Regular),
              fontBold As New Font("Arial", 12, FontStyle.Bold),
              fontTitulo As New Font("Arial", 14, FontStyle.Bold)

            Dim g As Graphics = e.Graphics
            Dim anchoPagina As Integer = e.PageBounds.Width
            Dim xInicio As Integer = 50
            Dim y As Integer = 30
            Dim intervalo As Integer = 20

            ' ==== 1. LOGO (Centrado) ====
            Try
                If System.IO.File.Exists("C:\Users\FS\Downloads\images cc.jpg") Then
                    Using logo As Image = Image.FromFile("C:\Users\FS\Downloads\images cc.jpg")
                        Dim logoAncho As Integer = 100
                        Dim logoAlto As Integer = 100
                        g.DrawImage(logo, CInt((anchoPagina - logoAncho) / 2), y, logoAncho, logoAlto)
                        y += logoAlto + 10
                    End Using
                End If
            Catch
                y += 10
            End Try

            ' ==== 2. ENCABEZADO ====
            Dim encabezado() As String = {
                "INSTITUTO SUPERIOR C&C TECHNOLOGIES",
                "Dirección: CALLE JUAN B. BURGOS, CHITRÉ, HERRERA",
                "Teléfono: 6087-5729"
            }

            For i As Integer = 0 To encabezado.Length - 1
                Dim f As Font = If(i = 0, fontTitulo, fontNormal)
                Dim xCentrado As Single = (anchoPagina - g.MeasureString(encabezado(i), f).Width) / 2
                g.DrawString(encabezado(i), f, Brushes.Black, xCentrado, y)
                y += If(i = 0, 25, 18)
            Next
            y += 10

            ' ==== 3. TITULO (CORREGIDO: Ahora sí se dibuja) ====
            Dim titulo As String = "INFORMACIÓN DE DATOS DEL ESTUDIANTE"
            Dim xTitulo As Single = (anchoPagina - g.MeasureString(titulo, fontBold).Width) / 2
            g.DrawString(titulo, fontBold, Brushes.Black, xTitulo, y)
            y += 20

            g.DrawLine(Pens.Black, xInicio, y, anchoPagina - xInicio, y)
            y += 15

            ' ==== 4. FOTO DEL ESTUDIANTE ====
            Dim yInicioDatos As Integer = y
            Dim fotoAncho As Integer = 100
            Dim fotoAlto As Integer = 120
            Dim xFoto As Integer = anchoPagina - xInicio - fotoAncho

            If pbImagen2.Image IsNot Nothing Then
                g.DrawImage(pbImagen2.Image, xFoto, y, fotoAncho, fotoAlto)
                g.DrawRectangle(Pens.Black, xFoto, y, fotoAncho, fotoAlto)
            End If

            ' ==== 5. DATOS DEL ESTUDIANTE ====
            Dim campos As String(,) = {
                {"CÉDULA: ", txtCedula.Text},
                {"--- INFORMACIÓN PERSONAL ---", "SECCION"},
                {"1ER NOMBRE: ", txtNombre.Text},
                {"2DO NOMBRE: ", txtNombre2.Text},
                {"APELLIDO PAT: ", txtApellido.Text},
                {"APELLIDO MAT: ", txtApellido2.Text},
                {"EDAD: ", txtEdad.Text},
                {"FECHA NAC: ", txtFECHADIA.Text & "/" & txtFECHAMES.Text & "/" & txtFECHAAÑO.Text},
                {"GÉNERO: ", txtGenero.Text},
                {"TELÉFONO: ", txtTelefono.Text},
                {"CORREO: ", txtCorreo.Text},
                {"--- DIRECCIÓN PERSONAL ---", "SECCION"},
                {"PAÍS: ", txtPais.Text},
                {"PROVINCIA: ", txtProvincia.Text},
                {"COMARCA: ", txtComarca.Text},
                {"DISTRITO: ", txtDistrito.Text},
                {"CORREGIMIENTO: ", txtCorregimiento.Text},
                {"SECTOR: ", txtDireccion.Text},
                {"--- INFORMACIÓN ACADÉMICA ---", "SECCION"},
                {"CARRERA: ", txtTecnico.Text},
                {"COLEGIO: ", txtColegio.Text},
                {"BACHILLER: ", txtBachiller.Text}
            }

            Dim columnaValor As Integer = 150

            For i As Integer = 0 To campos.GetUpperBound(0)
                If campos(i, 1) = "SECCION" Then
                    y += 8
                    ' Centramos la sección en el espacio disponible a la izquierda de la foto si estamos en su rango de altura
                    Dim xSeccion As Single
                    If y < (yInicioDatos + fotoAlto) AndAlso pbImagen2.Image IsNot Nothing Then
                        xSeccion = xInicio + ((xFoto - xInicio) - g.MeasureString(campos(i, 0), fontBold).Width) / 2
                    Else
                        xSeccion = (anchoPagina - g.MeasureString(campos(i, 0), fontBold).Width) / 2
                    End If

                    g.DrawString(campos(i, 0), fontBold, Brushes.DarkBlue, xSeccion, y)
                    y += intervalo
                Else
                    ' Imprimir fila normal de datos
                    g.DrawString(campos(i, 0), fontBold, Brushes.Black, xInicio, y)
                    g.DrawString(campos(i, 1), fontNormal, Brushes.Black, xInicio + columnaValor, y)
                    y += intervalo
                End If
            Next

            ' Asegurar que el pie de página no se monte si la lista es corta
            If pbImagen2.Image IsNot Nothing AndAlso y < (yInicioDatos + fotoAlto) Then
                y = yInicioDatos + fotoAlto
            End If

            ' ==== 6. PIE DE PÁGINA ====
            y += 30
            Dim strFinal As String = "Gracias por su confianza en C&C TECHNOLOGIES."
            g.DrawString(strFinal, fontNormal, Brushes.Black, (anchoPagina - g.MeasureString(strFinal, fontNormal).Width) / 2, y)

            Dim strFecha As String = "Generado el: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            g.DrawString(strFecha, fontNormal, Brushes.Gray, (anchoPagina - g.MeasureString(strFecha, fontNormal).Width) / 2, y + 18)
        End Using
    End Sub


    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub btnSeletIMAGEN_Click(sender As Object, e As EventArgs) Handles btnSeletIMAGEN.Click
        Dim ruta As String ' almacenar la imagen
        With OpenFileDialog1
            .Title = "Selecciona una imagen"
            .FileName = Nothing
            .Filter = "JPG|*.jpg"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If (.ShowDialog = DialogResult.OK) Then
                pbImagen2.Load(.FileName)
                ruta = .FileName
            End If
        End With
    End Sub
End Class
