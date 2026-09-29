Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form40
    Dim conexion As String
    Dim con As New OleDbConnection
    Dim sql As New OleDbCommand
    Dim posicion As Integer
    Dim consulta As String = ""
    Dim dr As OleDbDataAdapter
    Dim ord As DataSet
    Dim busca As Byte
    Private Sub btnCALCULAR_Click(sender As Object, e As EventArgs) Handles btnCALCULAR.Click
        If String.IsNullOrWhiteSpace(txtNombreEstudiante.Text) OrElse
           String.IsNullOrWhiteSpace(txtApellidoEstudiante.Text) OrElse
           String.IsNullOrWhiteSpace(txtCarrera.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura1.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura2.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura3.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura4.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura5.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura6.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura7.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura8.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura9.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura10.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura11.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura12.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura13.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura14.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura15.Text) OrElse
           String.IsNullOrWhiteSpace(txtAsignatura16.Text) OrElse
           String.IsNullOrWhiteSpace(txtN1.Text) OrElse
           String.IsNullOrWhiteSpace(txtN2.Text) OrElse
           String.IsNullOrWhiteSpace(txtN3.Text) OrElse
           String.IsNullOrWhiteSpace(txtN4.Text) OrElse
           String.IsNullOrWhiteSpace(txtN5.Text) OrElse
           String.IsNullOrWhiteSpace(txtN6.Text) OrElse
           String.IsNullOrWhiteSpace(txtN7.Text) OrElse
           String.IsNullOrWhiteSpace(txtN8.Text) OrElse
           String.IsNullOrWhiteSpace(txtN9.Text) OrElse
           String.IsNullOrWhiteSpace(txtN10.Text) OrElse
           String.IsNullOrWhiteSpace(txtN11.Text) OrElse
           String.IsNullOrWhiteSpace(txtN12.Text) OrElse
           String.IsNullOrWhiteSpace(txtN13.Text) OrElse
           String.IsNullOrWhiteSpace(txtN14.Text) OrElse
           String.IsNullOrWhiteSpace(txtN15.Text) OrElse
           String.IsNullOrWhiteSpace(txtN16.Text) Then
            MessageBox.Show("¡ERROR! EXISTEN CAMPOS OBLIGATORIOS VACÍOS. POR FAVOR, COMPLETE TODO EL FORMULARIO.",
                            "DATOS INCOMPLETOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. VALIDACIÓN DE CARACTERES (Ejemplo con nombre y apellido)
        ' Puedes añadir más validaciones personalizadas aquí
        Dim esValido As Boolean = True
        For Each caracter As Char In txtNombreEstudiante.Text & txtApellidoEstudiante.Text
            If Not Char.IsLetter(caracter) AndAlso Not Char.IsWhiteSpace(caracter) Then
                esValido = False
                Exit For
            End If
        Next

        Dim A, B, C, D, F, G, H, I, J, K, L, M, N, Ñ, O, P As Integer
        Dim estudiante As Integer
        Dim tecnico As String
        Dim promedio As Single
        Dim nota As String

        A = txtAsignatura1.Text
        B = txtAsignatura2.Text
        C = txtAsignatura3.Text
        D = txtAsignatura4.Text
        F = txtAsignatura5.Text
        G = txtAsignatura6.Text
        H = txtAsignatura7.Text
        I = txtAsignatura8.Text
        J = txtAsignatura9.Text
        K = txtAsignatura10.Text
        L = txtAsignatura11.Text
        M = txtAsignatura12.Text
        N = txtAsignatura13.Text
        Ñ = txtAsignatura14.Text
        O = txtAsignatura15.Text
        P = txtAsignatura16.Text
        txtPromedio.Text = (A + B + C + D + F + G + H + I + J + K + L + M + N + Ñ + O + P) / 16
        txtPuntuacion.Text = (A + B + C + D + F + G + H + I + J + K + L + M + N + Ñ + O + P)

        ' 1. Capturar los valores numéricos de las cajas de texto

        ' 2. Evaluar y asignar la letra para la Asignatura 1 (txtN1)
        If A >= 91 And A <= 100 Then
            txtN1.Text = "A"
        ElseIf A >= 81 And A <= 90 Then
            txtN1.Text = "B"
        ElseIf A >= 71 And A <= 80 Then
            txtN1.Text = "C"
        ElseIf A >= 61 And A <= 70 Then
            txtN1.Text = "D"
        Else
            txtN1.Text = "F"
        End If

        ' 3. Evaluar y asignar la letra para la Asignatura 2 (txtN2)
        If B >= 91 And B <= 100 Then
            txtN2.Text = "A"
        ElseIf B >= 81 And B <= 90 Then
            txtN2.Text = "B"
        ElseIf B >= 71 And B <= 80 Then
            txtN2.Text = "C"
        ElseIf B >= 61 And B <= 70 Then
            txtN2.Text = "D"
        Else
            txtN2.Text = "F"
        End If

        ' 4. Evaluar y asignar la letra para la Asignatura 3 (txtN3)
        If C >= 91 And C <= 100 Then
            txtN3.Text = "A"
        ElseIf C >= 81 And C <= 90 Then
            txtN3.Text = "B"
        ElseIf C >= 71 And C <= 80 Then
            txtN3.Text = "C"
        ElseIf C >= 61 And C <= 70 Then
            txtN3.Text = "D"
        Else
            txtN3.Text = "F"
        End If

        ' 5. Evaluar y asignar la letra para la Asignatura 4 (txtN4)
        If D >= 91 And D <= 100 Then
            txtN4.Text = "A"
        ElseIf D >= 81 And D <= 90 Then
            txtN4.Text = "B"
        ElseIf D >= 71 And D <= 80 Then
            txtN4.Text = "C"
        ElseIf D >= 61 And D <= 70 Then
            txtN4.Text = "D"
        Else
            txtN4.Text = "F"
        End If

        ' 6. Evaluar y asignar la letra para la Asignatura 5 (txtN5)
        If A >= 91 And A <= 100 Then
            txtN5.Text = "A"
        ElseIf A >= 81 And A <= 90 Then
            txtN5.Text = "B"
        ElseIf A >= 71 And A <= 80 Then
            txtN5.Text = "C"
        ElseIf A >= 61 And A <= 70 Then
            txtN5.Text = "D"
        Else
            txtN5.Text = "F"
        End If

        ' 7. Evaluar y asignar la letra para la Asignatura 6 (txtN6)
        If B >= 91 And B <= 100 Then
            txtN6.Text = "A"
        ElseIf B >= 81 And B <= 90 Then
            txtN6.Text = "B"
        ElseIf B >= 71 And B <= 80 Then
            txtN6.Text = "C"
        ElseIf B >= 61 And B <= 70 Then
            txtN6.Text = "D"
        Else
            txtN6.Text = "F"
        End If

        ' 8. Evaluar y asignar la letra para la Asignatura 7 (txtN7)
        If C >= 91 And C <= 100 Then
            txtN7.Text = "A"
        ElseIf C >= 81 And C <= 90 Then
            txtN7.Text = "B"
        ElseIf C >= 71 And C <= 80 Then
            txtN7.Text = "C"
        ElseIf C >= 61 And C <= 70 Then
            txtN7.Text = "D"
        Else
            txtN7.Text = "F"
        End If

        ' 9. Evaluar y asignar la letra para la Asignatura 8 (txtN8)
        If D >= 91 And D <= 100 Then
            txtN8.Text = "A"
        ElseIf D >= 81 And D <= 90 Then
            txtN8.Text = "B"
        ElseIf D >= 71 And D <= 80 Then
            txtN8.Text = "C"
        ElseIf D >= 61 And D <= 70 Then
            txtN8.Text = "D"
        Else
            txtN8.Text = "F"
        End If

        ' 10. Evaluar y asignar la letra para la Asignatura 9 (txtN9)
        If A >= 91 And A <= 100 Then
            txtN9.Text = "A"
        ElseIf A >= 81 And A <= 90 Then
            txtN9.Text = "B"
        ElseIf A >= 71 And A <= 80 Then
            txtN9.Text = "C"
        ElseIf A >= 61 And A <= 70 Then
            txtN9.Text = "D"
        Else
            txtN9.Text = "F"
        End If

        ' 11. Evaluar y asignar la letra para la Asignatura 10 (txtN10)
        If B >= 91 And B <= 100 Then
            txtN10.Text = "A"
        ElseIf B >= 81 And B <= 90 Then
            txtN10.Text = "B"
        ElseIf B >= 71 And B <= 80 Then
            txtN10.Text = "C"
        ElseIf B >= 61 And B <= 70 Then
            txtN10.Text = "D"
        Else
            txtN10.Text = "F"
        End If

        ' 12. Evaluar y asignar la letra para la Asignatura 11 (txtN11)
        If C >= 91 And C <= 100 Then
            txtN11.Text = "A"
        ElseIf C >= 81 And C <= 90 Then
            txtN11.Text = "B"
        ElseIf C >= 71 And C <= 80 Then
            txtN11.Text = "C"
        ElseIf C >= 61 And C <= 70 Then
            txtN11.Text = "D"
        Else
            txtN11.Text = "F"
        End If

        ' 13. Evaluar y asignar la letra para la Asignatura 12 (txtN12)
        If D >= 91 And D <= 100 Then
            txtN12.Text = "A"
        ElseIf D >= 81 And D <= 90 Then
            txtN12.Text = "B"
        ElseIf D >= 71 And D <= 80 Then
            txtN12.Text = "C"
        ElseIf D >= 61 And D <= 70 Then
            txtN12.Text = "D"
        Else
            txtN12.Text = "F"
        End If

        ' 14. Evaluar y asignar la letra para la Asignatura 13 (txtN13)
        If A >= 91 And A <= 100 Then
            txtN13.Text = "A"
        ElseIf A >= 81 And A <= 90 Then
            txtN13.Text = "B"
        ElseIf A >= 71 And A <= 80 Then
            txtN13.Text = "C"
        ElseIf A >= 61 And A <= 70 Then
            txtN13.Text = "D"
        Else
            txtN13.Text = "F"
        End If

        ' 15. Evaluar y asignar la letra para la Asignatura 14 (txtN14)
        If B >= 91 And B <= 100 Then
            txtN14.Text = "A"
        ElseIf B >= 81 And B <= 90 Then
            txtN14.Text = "B"
        ElseIf B >= 71 And B <= 80 Then
            txtN14.Text = "C"
        ElseIf B >= 61 And B <= 70 Then
            txtN14.Text = "D"
        Else
            txtN14.Text = "F"
        End If

        ' 16. Evaluar y asignar la letra para la Asignatura 15 (txtN15)
        If C >= 91 And C <= 100 Then
            txtN15.Text = "A"
        ElseIf C >= 81 And C <= 90 Then
            txtN15.Text = "B"
        ElseIf C >= 71 And C <= 80 Then
            txtN15.Text = "C"
        ElseIf C >= 61 And C <= 70 Then
            txtN15.Text = "D"
        Else
            txtN15.Text = "F"
        End If

        ' 17. Evaluar y asignar la letra para la Asignatura 16 (txtN16)
        If D >= 91 And D <= 100 Then
            txtN16.Text = "A"
        ElseIf D >= 81 And D <= 90 Then
            txtN16.Text = "B"
        ElseIf D >= 71 And D <= 80 Then
            txtN16.Text = "C"
        ElseIf D >= 61 And D <= 70 Then
            txtN16.Text = "D"
        Else
            txtN16.Text = "F"
        End If
        ' 18. Calcular y mostrar el promedio general final
        txtPromedio.Text = promedio.ToString()


        promedio = (A + B + C + D + F + G + H + I + J + K + L + M + N + Ñ + O + P) / 16

        txtPromedio.Text = promedio.ToString("F2")
        txtNota.Text = promedio
        If (promedio >= 91 And 100) Then
            txtNota.Text = "A"
            MessageBox.Show("Aprobado", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If (promedio >= 81 And 90) Then
                txtNota.Text = "B"
                MessageBox.Show("Aprobado", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If (promedio >= 71 And 80) Then
                    txtNota.Text = "C"
                    MessageBox.Show("Aprobado", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If (promedio >= 61 And 70) Then
                        txtNota.Text = "D"
                        MessageBox.Show("Reprobado", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If (promedio >= 0 And 60) Then
                            txtNota.Text = "F"
                            MessageBox.Show("Reprobado", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        txtNombreEstudiante.Text = ""
        txtApellidoEstudiante.Text = ""
        txtCEDULA.Text = ""
        txtCARRERA.Text = ""
        txtPeriodo.Text = ""
        txtAsignatura1.Text = ""
        txtAsignatura2.Text = ""
        txtAsignatura3.Text = ""
        txtAsignatura4.Text = ""
        txtAsignatura5.Text = ""
        txtAsignatura6.Text = ""
        txtAsignatura7.Text = ""
        txtAsignatura8.Text = ""
        txtAsignatura9.Text = ""
        txtAsignatura10.Text = ""
        txtAsignatura11.Text = ""
        txtAsignatura12.Text = ""
        txtAsignatura13.Text = ""
        txtAsignatura14.Text = ""
        txtAsignatura15.Text = ""
        txtAsignatura16.Text = ""
        txtPromedio.Text = ""
        txtPuntuacion.Text = ""
        txtNota.Text = ""
        txtAsignatura1.Focus()
        txtAsignatura2.Focus()
        txtAsignatura3.Focus()
        txtAsignatura4.Focus()
        txtAsignatura5.Focus()
        txtAsignatura6.Focus()
        txtAsignatura7.Focus()
        txtAsignatura8.Focus()
        txtAsignatura9.Focus()
        txtAsignatura10.Focus()
        txtAsignatura11.Focus()
        txtAsignatura12.Focus()
        txtAsignatura13.Focus()
        txtAsignatura14.Focus()
        txtAsignatura15.Focus()
        txtAsignatura16.Focus()
        txtN1.Text = ""
        txtN2.Text = ""
        txtN3.Text = ""
        txtN4.Text = ""
        txtN5.Text = ""
        txtN6.Text = ""
        txtN7.Text = ""
        txtN8.Text = ""
        txtN9.Text = ""
        txtN10.Text = ""
        txtN11.Text = ""
        txtN12.Text = ""
        txtN13.Text = ""
        txtN14.Text = ""
        txtN15.Text = ""
        txtN16.Text = ""
        pbIMAGEN3.Image = Nothing
        MessageBox.Show("SUS DATOS ESTAN BORRADOS", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        If MessageBox.Show("DESEA SALIR DEL FORMULARIO DE PROMEDIO", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
        Form44_ACADEMICO.Show()
    End Sub

    Private Sub btnPRINTPREVIEW_Click(sender As Object, e As EventArgs) Handles btnPRINTPREVIEW.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' Asegúrate de tener las referencias y los controles en tu formulario
    ' (ChartControl, GridControl, etc.)

    Private Sub btnEXPORTAR_Click(sender As Object, d As EventArgs) Handles btnEXPORTAR.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub btnPRINT_Click(sender As Object, e As EventArgs) Handles btnPRINT.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Usar "Using" asegura que las fuentes se liberen de la memoria correctamente al terminar
        Using fontNormal As New Font("Arial", 12, FontStyle.Regular),
              fontBold As New Font("Arial", 12, FontStyle.Bold),
              fontTitulo As New Font("Arial", 14, FontStyle.Bold),
              fontNota As New Font("Arial", 12, FontStyle.Bold)

            Dim g As Graphics = e.Graphics
            Dim xInicio As Integer = 50
            Dim y As Integer = 40
            Dim intervalo As Integer = 25
            Dim anchoPagina As Integer = e.PageBounds.Width

            ' ==== 1. LOGO (Centrado con liberación de memoria) ====
            Try
                If System.IO.File.Exists("C:\Users\FS\Downloads\images cc.jpg") Then
                    Using logo As Image = Image.FromFile("C:\Users\FS\Downloads\images cc.jpg")
                        Dim logoAncho As Integer = 90
                        Dim logoAlto As Integer = 90
                        g.DrawImage(logo, CInt((anchoPagina - logoAncho) / 2), y, logoAncho, logoAlto)
                        y += logoAlto + 10
                    End Using
                Else
                    y += 20
                End If
            Catch ex As Exception
                y += 20
            End Try

            ' ==== 2. ENCABEZADO ====
            Dim encabezado() As String = {
                "INSTITUTO SUPERIOR C&C TECHNOLOGIES.",
                "REPORTE OFICIAL DE CALIFICACIONES - 2026",
                "Dirección: CALLE JUAN B. BURGOS, CHITRE, HERRERA"
            }

            For i As Integer = 0 To encabezado.Length - 1
                Dim f As Font = If(i = 0, fontTitulo, fontNormal)
                Dim xCentrado As Single = (anchoPagina - g.MeasureString(encabezado(i), f).Width) / 2
                g.DrawString(encabezado(i), f, Brushes.Black, xCentrado, y)
                y += 25
            Next

            y += 15
            g.DrawLine(Pens.Black, xInicio, y, anchoPagina - xInicio, y)
            y += 25

            ' ==== 3. TITULO DE SECCIÓN ====
            Dim titulo As String = "PROMEDIO DEL ESTUDIANTE"
            Dim xTitulo As Single = (anchoPagina - g.MeasureString(titulo, fontTitulo).Width) / 2
            g.DrawString(titulo, fontTitulo, Brushes.DarkBlue, xTitulo, y)
            y += 30

            ' ==== 4. FOTO DEL ESTUDIANTE (ALINEADA AL CENTRO) ====
            Dim yInicioDatos As Integer = y
            Dim anchoFoto As Integer = 110
            Dim altoFoto As Integer = 130

            If pbIMAGEN3.Image IsNot Nothing Then
                Dim xFoto As Integer = CInt((anchoPagina - anchoFoto) / 2)
                g.DrawImage(pbIMAGEN3.Image, xFoto, y, anchoFoto, altoFoto)
                g.DrawRectangle(Pens.Black, xFoto, y, anchoFoto, altoFoto)
                y += altoFoto + 25
            Else
                y += 10
            End If

            ' ==== 5. DATOS Y CALIFICACIONES ====
            ' Ajustamos el offset a 330 para dar espacio a los nombres largos de asignaturas
            Dim offsetValor As Integer = 330

            ' CORREGIDO: Estructura limpia usando banderas de "SECCION" en lugar de cadenas de guiones
            Dim campos As String(,) = {
    {"--- DATOS DEL ESTUDIANTE ---", "SECCION"},
    {"NOMBRES:", txtNombreEstudiante.Text.ToUpper()},
    {"APELLIDOS:", txtApellidoEstudiante.Text.ToUpper()},
    {"TÉCNICO SUPERIOR:", txtCarrera.Text.ToUpper()},
    {"CÉDULA:", txtCEDULA.Text},
    {"--- NOTAS I CUATRIMESTRE ---", "SECCION"},
    {"COMUNICACIÓN ORAL Y ESCRITA 001:", "Nota: " & txtN1.Text},
    {"OFIMÁTICA 002:", "Nota: " & txtN2.Text},
    {"INT. AMBIENTES VIRTUALES 003:", "Nota: " & txtN3.Text},
    {"HISTORIA DE PANAMÁ 019:", "Nota: " & txtN4.Text},
    {"--- NOTAS II CUATRIMESTRE ---", "SECCION"},
    {"INGLÉS:", "Nota: " & txtN5.Text}, ' CORREGIDO: Caja de texto asignada al Cuatrimestre 2
    {"LA COMUNICACIÓN EN ENTORNOS VIRTUALES:", "Nota: " & txtN6.Text},
    {"TUTORÍA EN ENTORNOS VIRTUALES:", "Nota: " & txtN7.Text},
    {"MATERIAL DIDÁCTICO EN ENTORNOS VIRTUALES I:", "Nota: " & txtN8.Text},
    {"--- NOTAS III CUATRIMESTRE ---", "SECCION"},
    {"MATERIAL DIDÁCTICO EN ENTORNOS VIRTUALES II:", "Nota: " & txtN9.Text}, ' CORREGIDO: Caja de texto asignada al Cuatrimestre 3
    {"HERRAMIENTAS TECNOLÓGICAS PARA ENTORNOS VIRTUALES:", "Nota: " & txtN10.Text},
    {"EL APRENDIZAJE EN ENTORNOS VIRTUALES:", "Nota: " & txtN11.Text},
    {"ÉTICA Y MORAL:", "Nota: " & txtN12.Text},
    {"--- NOTAS IV CUATRIMESTRE ---", "SECCION"},
    {"MANEJO DE LAS PLATAFORMAS PARA ENTORNOS VIRTUALES:", "Nota: " & txtN13.Text}, ' CORREGIDO: Caja de texto asignada al Cuatrimestre 4
    {"PLANIFICACIÓN Y EVALUACIÓN DE PROYECTOS:", "Nota: " & txtN14.Text},
    {"GEOGRAFÍA DE PANAMÁ:", "Nota: " & txtN15.Text},
    {"TRABAJO DE GRADUACIÓN:", "Nota: " & txtN16.Text},
    {"--- NOTA FINAL ---", "SECCION"},
    {"PROMEDIO FINAL:", txtPromedio.Text},
    {"PUNTUACIÓN TOTAL:", txtPuntuacion.Text},
    {"CALIFICACIÓN (LETRA):", txtNota.Text}
}

            For i As Integer = 0 To campos.GetUpperBound(0)
                Dim etiqueta As String = campos(i, 0)
                Dim valor As String = campos(i, 1)

                If valor = "SECCION" Then
                    y += 10
                    Dim xSeccion As Single = (anchoPagina - g.MeasureString(etiqueta, fontBold).Width) / 2
                    g.DrawString(etiqueta, fontBold, Brushes.DarkBlue, xSeccion, y)
                    y += intervalo + 5
                Else
                    ' CORREGIDO: El índice real donde empiezan las notas finales es el 11
                    Dim fEtiqueta As Font = If(i >= 11, fontNota, fontBold)
                    Dim fValor As Font = If(i >= 11, fontNota, fontNormal)

                    ' Color destacado (NEGRO) únicamente para el bloque de promedios finales
                    Dim pincelTexto As Brush = If(i >= 11, Brushes.Red, Brushes.Black)
                    Dim pincelValor As Brush = If(i >= 11, Brushes.Red, Brushes.DarkBlue)

                    g.DrawString(etiqueta, fEtiqueta, pincelTexto, xInicio, y)
                    g.DrawString(valor, fValor, pincelValor, xInicio + offsetValor, y)
                    y += intervalo
                End If
            Next

            ' ==== 6. PIE DE PÁGINA ====
            y = Math.Max(y, yInicioDatos + 150) + 40

            Dim strFinal As String = "Certificación generada por el Sistema Académico C&C"
            Dim xFinal As Single = (anchoPagina - g.MeasureString(strFinal, fontNormal).Width) / 2
            g.DrawString(strFinal, fontNormal, Brushes.Black, xFinal, y)

            Dim strFecha As String = "Fecha de emisión: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            Dim xFecha As Single = (anchoPagina - g.MeasureString(strFecha, fontNormal).Width) / 2
            g.DrawString(strFecha, fontNormal, Brushes.Gray, xFecha, y + 20)
        End Using
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btnSELECIMAGEN_Click(sender As Object, e As EventArgs) Handles btnSeletIMAGEN.Click
        Dim ruta As String ' almacenar la imagen
        With OpenFileDialog1
            .Title = "Selecciona una imagen"
            .FileName = Nothing
            .Filter = "JPG|*.jpg"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If (.ShowDialog = DialogResult.OK) Then
                pbIMAGEN3.Load(.FileName)
                ruta = .FileName
            End If
        End With
    End Sub

    Private Sub btnVALIDAR_Click(sender As Object, e As EventArgs) Handles btnVERIFICAR.Click
        Dim cadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FS\Documents\PROYECTO BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"
        Dim consulta As String = "SELECT COUNT(*) FROM [PROMEDIO DE LOS ESTUDIANTES] WHERE CEDULA = @CEDULA"

        Using conexion As New OleDbConnection(cadenaConexion)
            Try
                conexion.Open()
                Using comando As New OleDbCommand(consulta, conexion)
                    ' Pasamos el parámetro de la cédula para evitar inyección SQL
                    comando.Parameters.AddWithValue("@CEDULA", txtCEDULA.Text.Trim())

                    Dim cantidad As Integer = Convert.ToInt32(comando.ExecuteScalar())

                    ' 4. VERIFICACIÓN DE RESULTADOS
                    If cantidad > 0 Then
                        MessageBox.Show("¡REGISTRO ENCONTRADO! LOS DATOS COINCIDEN CON UN REGISTRO PREVIO EN LA BASE DE DATOS.",
                                        "VERIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("NO SE ENCONTRARON REGISTROS COINCIDENTES EN LA BASE DE DATOS CON ESA CÉDULA. LOS DATOS INGRESADOS PARECEN SER NUEVOS.",
                                        "SIN RESULTADOS", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS: " & ex.Message,
                  "ERROR DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                conexion.Close()
            End Try
        End Using
        ' Obtenemos el valor y eliminamos espacios accidentales
        Dim documento As String = txtCEDULA.Text.Trim()

        ' Llamada a la función de validación
        If ValidarDocumentoPanama(documento) Then
            MessageBox.Show("Documento de identidad válido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Formato no válido." & vbCrLf &
                        "Nacionales: 8-888-8888" & vbCrLf &
                        "Extranjeros: E-8-888888" & vbCrLf &
                        "Nacidos Ext: PE-8-888", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidarDocumentoPanama(valor As String) As Boolean
        ' EXPLICACIÓN DEL PATRÓN (Regex):
        ' ^(E|PE|N|[1-9]|1[0-3])  -> Empieza con E, PE, N o provincia del 1 al 13
        ' -\d{1,4}-               -> Un guion, seguido de 1 a 4 dígitos (tomo), otro guion
        ' \d{1,6}$                -> Finaliza con 1 a 6 dígitos (asiento)
        Dim patron As String = "^(E|PE|N|[1-9]|1[0-3])-\d{1,4}-\d{1,6}$"

        Return Regex.IsMatch(valor, patron)
    End Function

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ' Ruta y proveedor de la base de datos
        Dim rutaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FS\Documents\PROYECTO BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"

        ' SENTENCIA SQL CORREGIDA: 11 columnas y exactamente 11 signos de interrogación
        Dim sqlInsert As String = "INSERT INTO [PROMEDIO DE LOS ESTUDIANTES] " &
"(NOMBRES, APELLIDOS, CEDULA, [TECNICO SUPERIOR], [ASIGNATURA 1], [ASIGNATURA 2], [ASIGNATURA 3], [ASIGNATURA 4], PROMEDIO, PUNTUACION, NOTA) " &
"VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"



        ' 2. USO DE BLOQUE USING: Asegura el cierre de la conexión pase lo que pase
        Using conexion As New OleDbConnection(rutaConexion)
            Using comando As New OleDbCommand(sqlInsert, conexion)

                ' 3. PARÁMETROS EN EL ORDEN EXACTO DE LAS COLUMNAS (15 en total)
                comando.Parameters.AddWithValue("?", txtNombreEstudiante.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtApellidoEstudiante.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtCEDULA.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtCARRERA.Text.ToUpper().Trim())

                ' Asignaturas
                ' Une el nombre con la nota en un solo parámetro
                comando.Parameters.AddWithValue("?", txtAsignatura1.Text & " " & txtN1.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura2.Text & " " & txtN2.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura3.Text & " " & txtN3.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura4.Text & " " & txtN4.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura5.Text & " " & txtN5.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura6.Text & " " & txtN6.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura7.Text & " " & txtN7.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura8.Text & " " & txtN8.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura9.Text & " " & txtN9.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura10.Text & " " & txtN10.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura11.Text & " " & txtN11.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura12.Text & " " & txtN12.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura13.Text & " " & txtN13.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura14.Text & " " & txtN14.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura15.Text & " " & txtN15.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtAsignatura16.Text & " " & txtN16.Text.ToUpper().Trim())
                ' Resultados finales
                comando.Parameters.AddWithValue("?", txtPromedio.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtPuntuacion.Text.ToUpper().Trim())
                comando.Parameters.AddWithValue("?", txtNota.Text.ToUpper().Trim())

                ' 4. CONTROL DE ERRORES Y EJECUCIÓN
                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error al guardar en la base de datos: " & ex.Message, "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnINGRESAR.Click
        txtNombreEstudiante.Text = MDIParent3.nombre(posicion)
        txtApellidoEstudiante.Text = MDIParent3.apellido(posicion)
        txtCEDULA.Text = MDIParent3.cedula(posicion)
        txtPeriodo.Text = MDIParent3.periodo(posicion)
        txtAsignatura1.Text = MDIParent3.p1(posicion)
        txtAsignatura2.Text = MDIParent3.p2(posicion)
        txtAsignatura3.Text = MDIParent3.p3(posicion)
        txtAsignatura4.Text = MDIParent3.p4(posicion)
        txtAsignatura5.Text = MDIParent3.p5(posicion)
        txtAsignatura6.Text = MDIParent3.p6(posicion)
        txtAsignatura7.Text = MDIParent3.p7(posicion)
        txtAsignatura8.Text = MDIParent3.p8(posicion)
        txtAsignatura9.Text = MDIParent3.p9(posicion)
        txtAsignatura10.Text = MDIParent3.p10(posicion)
        txtAsignatura11.Text = MDIParent3.p11(posicion)
        txtAsignatura12.Text = MDIParent3.p12(posicion)
        txtAsignatura13.Text = MDIParent3.p13(posicion)
        txtAsignatura14.Text = MDIParent3.p14(posicion)
        txtAsignatura15.Text = MDIParent3.p15(posicion)
        txtAsignatura16.Text = MDIParent3.p16(posicion)
        txtN1.Text = MDIParent3.nota1(posicion)
        txtN2.Text = MDIParent3.nota2(posicion)
        txtN3.Text = MDIParent3.nota3(posicion)
        txtN4.Text = MDIParent3.nota4(posicion)
        txtN5.Text = MDIParent3.nota5(posicion)
        txtN6.Text = MDIParent3.nota6(posicion)
        txtN7.Text = MDIParent3.nota7(posicion)
        txtN8.Text = MDIParent3.nota8(posicion)
        txtN9.Text = MDIParent3.nota9(posicion)
        txtN10.Text = MDIParent3.nota10(posicion)
        txtN11.Text = MDIParent3.nota11(posicion)
        txtN12.Text = MDIParent3.nota12(posicion)
        txtN13.Text = MDIParent3.nota13(posicion)
        txtN14.Text = MDIParent3.nota14(posicion)
        txtN15.Text = MDIParent3.nota15(posicion)
        txtN16.Text = MDIParent3.nota16(posicion)
        txtCarrera.Text = MDIParent3.carrera(posicion)
        ' 1. Asignar los nombres de las asignaturas a los Labels

        Label4.Text = "COMUNICACIÓN ORAL Y ESCRITA 001"
        Label5.Text = "OFIMÁTICA 002"
        Label6.Text = "INTRODUCCIÓN A LOS AMBIENTES VIRTUALES 003"
        Label7.Text = "HISTORIA DE PANAMÁ 019"
        Label8.Text = "INGLÉS"
        Label9.Text = "LA COMUNICACIÓN EN ENTORNOS VIRTUALES"
        Label10.Text = "TUTORÍA EN ENTORNOS VIRTUALES"
        Label11.Text = "MATERIAL DIDÁCTICO EN ENTORNOS VIRTUALES I"
        Label12.Text = "MATERIAL DIDÁCTICO EN ENTORNOS VIRTUALES II"
        Label13.Text = "HERRAMIENTAS TECNOLÓGICAS PARA ENTORNOS VIRTUALES"
        Label14.Text = "EL APRENDIZAJE EN ENTORNOS VIRTUALES"
        Label15.Text = "ÉTICA Y MORAL"
        Label16.Text = "MANEJO DE LAS PLATAFORMAS PARA ENTORNOS VIRTUALES"
        Label17.Text = "PLANIFICACIÓN Y EVALUACIÓN DE PROYECTOS"
        Label18.Text = "GEOGRAFÍA DE PANAMÁ"
        Label19.Text = "TRABAJO DE GRADUACIÓN"

        ' 2. Copiar los puntajes numéricos a los campos de Asignatura
        txtAsignatura1.Text = txtAsignatura1.Text
        txtAsignatura2.Text = txtAsignatura2.Text
        txtAsignatura3.Text = txtAsignatura3.Text
        txtAsignatura4.Text = txtAsignatura4.Text
        txtAsignatura5.Text = txtAsignatura5.Text
        txtAsignatura6.Text = txtAsignatura6.Text
        txtAsignatura7.Text = txtAsignatura7.Text
        txtAsignatura8.Text = txtAsignatura8.Text
        txtAsignatura9.Text = txtAsignatura9.Text
        txtAsignatura10.Text = txtAsignatura10.Text
        txtAsignatura11.Text = txtAsignatura11.Text
        txtAsignatura12.Text = txtAsignatura12.Text
        txtAsignatura13.Text = txtAsignatura13.Text
        txtAsignatura14.Text = txtAsignatura14.Text
        txtAsignatura15.Text = txtAsignatura15.Text
        txtAsignatura16.Text = txtAsignatura16.Text
        ' 3. Convertir los puntajes a letras y mostrarlos en los txtNota

        txtN1.Text = (txtN1.Text)
        txtN2.Text = (txtN2.Text)
        txtN3.Text = (txtN3.Text)
        txtN4.Text = (txtN4.Text)
        txtN5.Text = (txtN5.Text)
        txtN6.Text = (txtN6.Text)
        txtN7.Text = (txtN7.Text)
        txtN8.Text = (txtN8.Text)
        txtN9.Text = (txtN9.Text)
        txtN10.Text = (txtN10.Text)
        txtN11.Text = (txtN11.Text)
        txtN12.Text = (txtN12.Text)
        txtN13.Text = (txtN13.Text)
        txtN14.Text = (txtN14.Text)
        txtN15.Text = (txtN15.Text)
        txtN16.Text = (txtN16.Text)
    End Sub

    Private Sub btnVERIFICAR_Click(sender As Object, e As EventArgs) Handles btnVERIFICAR.Click

    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnSeletIMAGEN.Click

    End Sub
End Class