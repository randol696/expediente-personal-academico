Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Imports AxAcroPDFLib

Public Class FORMULARIO_CONSULTA_PROFESORES
    Dim cedula As String
    Dim posicion As Integer
    Dim conection As String
    Dim ruta As String ' almacenar la imagen
    Public Property PdfWriter As Object
    Public Property AxAcroPDF1 As Object

    Private Sub btnVERIFICARDATOSPROFESORES_Click(sender As Object, e As EventArgs) Handles btnVERIFICARDATOSPROFESORES.Click
        cedula = txtCedula.Text
        For x = 0 To 50
            If cedula = MDIParent2.cedulaprofesor(x) Then
                posicion = x
            End If
        Next

        txtNombre.Text = MDIParent2.nombreprofesor(posicion)
        txtNombre2.Text = MDIParent2.nombreprofesor2(posicion)
        txtApellido.Text = MDIParent2.apellidoprofesor(posicion)
        txtApellido2.Text = MDIParent2.apellidoprofesor2(posicion)
        txtCedula.Text = MDIParent2.cedulaprofesor(posicion)
        txtEDADPROFESOR.Text = MDIParent2.edadprofesor(posicion)
        txtTelefonoProfesor.Text = MDIParent1.telefono(posicion)
        txtCURSOPROFESOR.Text = MDIParent2.curso(posicion)
        txtPROVINCIAPROFESOR.Text = MDIParent2.provinciaprofesor(posicion)
        txtCOMARCAPROFESOR.Text = MDIParent2.comarcaprofesor(posicion)
        txtPAISPROFESOR.Text = MDIParent2.paisprofesor(posicion)
        txtTelefonoProfesor.Text = MDIParent2.telefonoprofesor(posicion)
        txtCorreoElectronicoProfesor.Text = MDIParent2.correoelectronicoprofesor(posicion)
        txtGENEROPROFESOR.Text = MDIParent2.generoprofesor(posicion)
        pbImagen.Load(MDIParent2.imagen(posicion))
    End Sub

    Private Sub btnSALIRAACADEMICA_Click(sender As Object, e As EventArgs) Handles btnSALIRAACADEMICA.Click
        Me.Hide()
        Form41_PERSONAL.Show()
    End Sub


    Private Sub pbImagen3_Click(sender As Object, e As EventArgs) Handles pbImagen.Click
        With OpenFileDialog1
            .Title = “SELECCIONA UNA IMAGEN”
            .FileName = Nothing
            .Filter = “JPG|*.jpg”
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If (.ShowDialog = DialogResult.OK) Then
                pbImagen.Load(.FileName)
                ruta = .FileName
            End If
        End With
    End Sub

    Private Sub btnEXPORTAR_Click(sender As Object, e As EventArgs) Handles btnEXPORTAR.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    ' También puedes cargar un archivo directamente si conoces la ruta:
    Private Sub LoadSpecificPdf()
        Dim pdfPath As String = "C:\Ruta\Completa\De\Tu\Documento.pdf"
        If System.IO.File.Exists(pdfPath) Then
            AxAcroPDF1.LoadFile(pdfPath)
        Else
            MessageBox.Show("El archivo PDF no se encontró.")
        End If
        ' Crear el documento PDF
        Dim doc As New Document()

        Try
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            ' Agregar contenido: títulos, y datos de tus controles de formulario
            doc.Add(New Paragraph("Reporte de Datos del FORMULARIO CONSULTA PROFESORES"))
            doc.Add(New Paragraph("----------------------------------"))

            ' Ejemplo: Asumiendo que tienes TextBox llamados txtNombre, txtEdad, etc.
            doc.Add(New Paragraph("Cedula: " & Me.txtCedula.Text))
            doc.Add(New Paragraph("Nombre: " & Me.txtNombre.Text))
            doc.Add(New Paragraph("Apellido: " & Me.txtApellido2.Text))
            doc.Add(New Paragraph("Edad: " & Me.txtEDADPROFESOR.Text))
            doc.Add(New Paragraph("Telefono: " & Me.txtTelefonoProfesor.Text))
            doc.Add(New Paragraph("Correo Electronico: " & Me.txtCorreoElectronicoProfesor.Text))
            doc.Add(New Paragraph("Curso: " & Me.txtCURSOPROFESOR.Text))
            doc.Add(New Paragraph("Genero: " & Me.txtGENEROPROFESOR.Text))
            doc.Add(New Paragraph("Provincia o Comarca: " & Me.txtPROVINCIAPROFESOR.Text))
            doc.Add(New Paragraph("Pais: " & Me.txtPAISPROFESOR.Text))
            ' Continúa agregando todos tus campos...

            doc.Close()
            MessageBox.Show("PDF generado con éxito en " & savePath(), "Éxito")

        Catch ex As Exception
            MessageBox.Show("Error al generar PDF: " & ex.Message, "Error")
        End Try

    End Sub

    Private Function savePath() As String
        Throw New NotImplementedException()
    End Function

    Private Sub btnPRINT_Click(sender As Object, e As EventArgs) Handles btnPRINT.Click
        PrintDialog1.Document = PrintDocument1

        ' Show the PrintDialog and check if the user clicked OK
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            ' Initiate the printing process, which raises the PrintPage event
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Usar "Using" asegura que las fuentes se liberen de la memoria correctamente
        Using fontNormal As New Font("Arial", 12, FontStyle.Regular),
          fontBold As New Font("Arial", 12, FontStyle.Bold),
          fontTitulo As New Font("Arial", 14, FontStyle.Bold)

            ' Usamos una sola variable 'g' para todo el dibujo (hace el código más limpio)
            Dim g As Graphics = e.Graphics
            Dim x As Integer = 100
            Dim y As Integer = 50
            Dim intervalo As Integer = 25
            Dim anchoPagina As Integer = e.PageBounds.Width

            ' ==== 1. LOGO (Centrado) ====
            Try
                If System.IO.File.Exists("C:\Users\FS\Downloads\images cc.jpg") Then
                    Using logo As Image = Image.FromFile("C:\Users\FS\Downloads\images cc.jpg")
                        Dim logoAncho As Integer = 120
                        Dim logoAlto As Integer = 120
                        g.DrawImage(logo, CInt((anchoPagina - logoAncho) / 2), y, logoAncho, logoAlto)
                        y += logoAlto + 15
                    End Using
                End If
            Catch ex As Exception
                y += 20
            End Try

            ' ==== 2. ENCABEZADO CENTRADO ====
            Dim encabezado As String() = {
            "INSTITUTO SUPERIOR C&C TECHNOLOGIES.",
            "Dirección: CALLE JUAN B. BURGOS, CHITRE, HERRERA",
            "Teléfono: 6087-5729"
        }

            For Each linea In encabezado
                Dim f As Font = If(linea.Contains("INSTITUTO"), fontTitulo, fontNormal)
                Dim xCentrado As Single = (anchoPagina - g.MeasureString(linea, f).Width) / 2
                g.DrawString(linea, f, Brushes.Black, xCentrado, y)
                y += 25
            Next

            y += 20

            ' ==== 3. TITULO (CORREGIDO: Se cambiaron las 'g' faltantes y 'xInicio') ====
            Dim titulo As String = "INFORMACIÓN DE DATOS DEL PROFESOR"
            Dim xTitulo As Single = (anchoPagina - g.MeasureString(titulo, fontTitulo).Width) / 2
            g.DrawString(titulo, fontTitulo, Brushes.DarkBlue, xTitulo, y) ' Usamos azul oscuro para resaltar
            y += 25

            ' Línea divisoria horizontal usando los márgenes establecidos
            g.DrawLine(Pens.Black, x, y, anchoPagina - x, y)
            y += 20

            ' ==== 4. FOTO DEL PROFESOR (Centrada) ====
            If pbImagen.Image IsNot Nothing Then
                Dim fotoAncho As Integer = 120
                Dim fotoAlto As Integer = 120
                Dim xFoto As Integer = CInt((anchoPagina - fotoAncho) / 2) ' Centramos la foto en la página

                g.DrawImage(pbImagen.Image, xFoto, y, fotoAncho, fotoAlto)
                g.DrawRectangle(Pens.Black, xFoto, y, fotoAncho, fotoAlto)
                y += fotoAlto + 25
            End If

            ' ==== 5. DATOS DEL PROFESOR ====
            Dim campos As String(,) = {
           {"CÉDULA: ", txtCedula.Text},
           {"--- INFORMACIÓN PERSONAL DEL PROFESOR ---", "SECCION"},
           {"1ER NOMBRE: ", txtNombre.Text},
           {"2DO NOMBRE: ", txtNombre2.Text},
           {"APELLIDO PAT: ", txtApellido.Text},
           {"APELLIDO MAT: ", txtApellido2.Text},
           {"EDAD: ", txtEDADPROFESOR.Text},
           {"GÉNERO: ", txtGENEROPROFESOR.Text},
           {"CORREO: ", txtCorreoElectronicoProfesor.Text},
           {"TELÉFONO: ", txtTelefonoProfesor.Text},
           {"CURSO ASIGNADO: ", txtCURSOPROFESOR.Text},
           {"--- DIRECCIÓN PERSONAL DEL PROFESOR ---", "SECCION"},
           {"PAÍS: ", txtPAISPROFESOR.Text},
           {"PROVINCIA: ", txtPROVINCIAPROFESOR.Text},
           {"COMARCA: ", txtCOMARCAPROFESOR.Text}
        }

            Dim columnaValor As Integer = 160 ' Un poco más de espacio para que no choque la etiqueta con el valor

            For i As Integer = 0 To campos.GetUpperBound(0)
                Dim etiqueta As String = campos(i, 0)
                Dim valor As String = campos(i, 1)

                ' CORREGIDO: Si es una sección, la centramos de forma elegante en lugar de imprimir guiones
                If valor = "SECCION" Then
                    y += 10
                    Dim xSeccion As Single = (anchoPagina - g.MeasureString(etiqueta, fontBold).Width) / 2
                    g.DrawString(etiqueta, fontBold, Brushes.DarkBlue, xSeccion, y)
                    y += intervalo + 5
                Else
                    ' Dibujamos fila normal de datos en columnas
                    g.DrawString(etiqueta, fontBold, Brushes.Black, x, y)
                    g.DrawString(valor, fontNormal, Brushes.Black, x + columnaValor, y)
                    y += intervalo
                End If
            Next

            ' ==== 6. MENSAJE FINAL / PIE DE PÁGINA ====
            y += 35
            Dim strFinal As String = "Gracias por su confianza en el C&C TECHNOLOGIES."
            Dim strFecha As String = "Fecha de reporte: " & DateTime.Now.ToString("dd/MM/yyyy")

            Dim xFinal As Single = (anchoPagina - g.MeasureString(strFinal, fontNormal).Width) / 2
            g.DrawString(strFinal, fontNormal, Brushes.Black, xFinal, y)

            y += 20
            Dim xFecha As Single = (anchoPagina - g.MeasureString(strFecha, fontNormal).Width) / 2
            g.DrawString(strFecha, fontNormal, Brushes.Gray, xFecha, y)
        End Using
    End Sub

    Private Sub btnPREVIEW_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnLIMPIARDATOSPROFESORES_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        txtNombre.Text = ""
        txtNombre2.Text = ""
        txtApellido.Text = ""
        txtApellido2.Text = ""
        txtCedula.Text = ""
        txtEDADPROFESOR.Text = ""
        txtGENEROPROFESOR.Text = ""
        txtCorreoElectronicoProfesor.Text = ""
        txtTelefonoProfesor.Text = ""
        txtPAISPROFESOR.Text = ""
        txtPROVINCIAPROFESOR.Text = ""
        txtCURSOPROFESOR.Text = ""
        pbImagen.Image = Nothing
        MessageBox.Show("SUS DATOS ESTÁN BORRADOS", "TITULO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnINGRESARDATOSPROFESORES_Click(sender As Object, e As EventArgs) Handles btnINGRESAR.Click
        ' 1. Conexión limpia a la base de datos Access
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FS\Documents\PROYECTO BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb")

        ' 2. Consulta SQL con exactamente 13 campos y 13 signos (?)
        Dim sql As String = "INSERT INTO [CONSULTA DE DATOS DE LOS PROFESORES] " &
                     "(CÉDULA, [PRIMER NOMBRE], [SEGUNDO NOMBRE], [APELLIDO PATERNO], [APELLIDO MATERNO], EDAD, GÉNERO, [CORREO ELECTRÓNICO], TELÉFONO, CURSO, PROVINCIA, COMARCA, [PAÍS DE PROCEDENCIA]) " &
                     "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" ' <- Corregido a exactamente 13 signos

        Dim comando As New OleDbCommand(sql, conexion)

        ' 3. Parámetros agregados en el ORDEN EXACTO (13 parámetros totales)
        comando.Parameters.AddWithValue("?", txtCedula.Text.ToUpper().Trim())   ' Mapea a CÉDULA
        comando.Parameters.AddWithValue("?", txtNombre.Text.ToUpper().Trim())   ' Mapea a NOMBRE
        comando.Parameters.AddWithValue("?", txtNombre2.Text.ToUpper().Trim())   ' Mapea a NOMBRE
        comando.Parameters.AddWithValue("?", txtApellido.Text.ToUpper().Trim())  ' Mapea a APELLIDO
        comando.Parameters.AddWithValue("?", txtApellido2.Text.ToUpper().Trim())  ' Mapea a APELLIDO
        comando.Parameters.AddWithValue("?", txtEDADPROFESOR.Text.ToUpper().Trim())     ' Mapea a EDAD
        comando.Parameters.AddWithValue("?", txtGENEROPROFESOR.Text.ToUpper().Trim())   ' Mapea a GÉNERO
        comando.Parameters.AddWithValue("?", txtCorreoElectronicoProfesor.Text.ToUpper().Trim()) ' Mapea a CORREO ELECTRÓNICO
        comando.Parameters.AddWithValue("?", txtTelefonoProfesor.Text.ToUpper().Trim()) ' Mapea a TELÉFONO
        comando.Parameters.AddWithValue("?", txtCURSOPROFESOR.Text.ToUpper().Trim())    ' Mapea a CURSO
        comando.Parameters.AddWithValue("?", txtPROVINCIAPROFESOR.Text.ToUpper().Trim()) ' Mapea a PROVINCIA
        comando.Parameters.AddWithValue("?", txtCOMARCAPROFESOR.Text.ToUpper().Trim())   ' Mapea a COMARCA
        comando.Parameters.AddWithValue("?", txtPAISPROFESOR.Text.ToUpper().Trim())      ' Mapea a PAÍS DE PROCEDENCIA

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

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class