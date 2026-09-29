Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Net.Mime.MediaTypeNames
Imports System.Security.AccessControl
Imports System.Security.Cryptography.X509Certificates


Public Class Form8
    Dim con As New OleDbConnection
    Dim sql As New OleDbCommand
    Dim consulta As String = ""
    Dim dr As OleDbDataAdapter
    Dim ord As DataSet
    Dim busca As Byte
    Dim numero As Integer
    Dim conexion As String
    Public Datos As Integer
    ' Define arrays with 20 slots (0 to 19)
    Public nombres(19) As String
    Public apellidos(19) As String
    Public cedulas(19) As String
    Public notas1(19) As String
    Public notas2(19) As String
    Public notas3(19) As String
    Public notas4(19) As String
    Public notas5(19) As String
    Public notas6(19) As String
    Public notas7(19) As String
    Public notas8(19) As String
    Public notas9(19) As String
    Public notas10(19) As String
    Public notas11(19) As String
    Public notas12(19) As String
    Public notas13(19) As String
    Public notas14(19) As String
    Public notas15(19) As String
    Public notas16(19) As String
    Public pos As Integer
    Dim posicion As Integer
    Private datosValidos As Boolean

    ' Añadimos un parámetro 'fila' para controlar dónde se escribe
    Private Sub LlenarDatos(nombre As String, apellido As String, cedula As String, boxes As TextBox(), fila As Integer)

        ' Validación: Solo procesar si está en el rango de filas 1 a 20
        If fila < 1 Or fila > 20 Then
            Debug.WriteLine("Fila fuera de rango permitido (1-20).")
            Exit Sub
        End If

        ' Evitar duplicados: Si el ID (cédula) ya existe en la UI, podrías abortar
        ' (Asumiendo que boxes(2) es el identificador único)
        If boxes(2).Text = cedula Then
            Debug.WriteLine("Registro idéntico detectado. Omitiendo llenado.")
            Exit Sub
        End If

        ' Llenado de datos
        boxes(0).Text = nombre
        boxes(1).Text = apellido
        boxes(2).Text = cedula
        boxes(3).Text = Module4.nota1
        boxes(4).Text = Module4.nota2
        boxes(5).Text = Module4.nota3
        boxes(6).Text = Module4.nota4
        boxes(3).Text = Module4.nota5
        boxes(4).Text = Module4.nota6
        boxes(5).Text = Module4.nota7
        boxes(6).Text = Module4.nota8
        boxes(3).Text = Module4.nota9
        boxes(4).Text = Module4.nota10
        boxes(5).Text = Module4.nota11
        boxes(6).Text = Module4.nota12
        boxes(3).Text = Module4.nota13
        boxes(4).Text = Module4.nota14
        boxes(5).Text = Module4.nota15
        boxes(6).Text = Module4.nota16
        boxes(7).Text = Module4.p1
        boxes(8).Text = Module4.p2
        boxes(9).Text = Module4.p3
        boxes(10).Text = Module4.p4
        boxes(7).Text = Module4.p5
        boxes(8).Text = Module4.p6
        boxes(9).Text = Module4.p7
        boxes(10).Text = Module4.p8
        boxes(7).Text = Module4.p9
        boxes(8).Text = Module4.p10
        boxes(9).Text = Module4.p11
        boxes(10).Text = Module4.p12
        boxes(7).Text = Module4.p13
        boxes(8).Text = Module4.p14
        boxes(9).Text = Module4.p15
        boxes(10).Text = Module4.p16
        boxes(11).Text = Module4.carrera
        Debug.WriteLine($"Fila {fila} procesada exitosamente para: {nombre}")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnENVIAR.Click
        ' Lista para controlar qué cédulas ya se mostraron y evitar repetir estudiantes
        Dim cedulasProcesadas As New List(Of String)()

        ' Variable contadora para los grupos de TextBox visuales (1 al 20)
        Dim filaVisual As Integer = 1

        ' Bucle para pasar por cada uno de los 20 bloques de estudiantes (origen de datos)
        For paso As Integer = 1 To 20
            Dim nombre As String = ""
            Dim apellido As String = ""
            Dim cedula As String = ""
            Dim n1 As String = "", n2 As String = "", n3 As String = "", n4 As String = ""
            Dim p1 As String = "", p2 As String = "", p3 As String = "", p4 As String = ""
            Dim n5 As String = "", n6 As String = "", n7 As String = "", n8 As String = ""
            Dim p5 As String = "", p6 As String = "", p7 As String = "", p8 As String = ""
            Dim n9 As String = "", n10 As String = "", n11 As String = "", n12 As String = ""
            Dim p9 As String = "", p10 As String = "", p11 As String = "", p12 As String = ""
            Dim n13 As String = "", n14 As String = "", n15 As String = "", n16 As String = ""
            Dim p13 As String = "", p14 As String = "", p15 As String = "", p16 As String = ""
            Dim carrera As String = ""

            ' 1. Obtener los datos del módulo correspondiente según el caso actual

            nombre = Module4.nombre : apellido = Module4.apellido : cedula = Module4.cedula
            n1 = Module4.nota1 : n2 = Module4.nota2
            n3 = Module4.nota3 : n4 = Module4.nota4
            n5 = Module4.nota5 : n6 = Module4.nota6
            n7 = Module4.nota7 : n8 = Module4.nota8
            n9 = Module4.nota9 : n10 = Module4.nota10
            n11 = Module4.nota11 : n12 = Module4.nota12
            n13 = Module4.nota13 : n14 = Module4.nota14
            n15 = Module4.nota15 : n16 = Module4.nota16
            p1 = Module4.p1 : p2 = Module4.p2 : p3 = Module4.p3 : p4 = Module4.p4
            p5 = Module4.p5 : p6 = Module4.p6 : p7 = Module4.p7 : p8 = Module4.p8
            p9 = Module4.p9 : p10 = Module4.p10 : p11 = Module4.p11 : p12 = Module4.p12
            p13 = Module4.p13 : p14 = Module4.p14 : p15 = Module4.p15 : p16 = Module4.p16
            carrera = Module4.carrera



            ' 2. VALIDACIÓN: Si el módulo
            '
            ' vacío o la cédula ya se procesó, saltar este caso
            If String.IsNullOrWhiteSpace(cedula) OrElse cedulasProcesadas.Contains(cedula.Trim()) Then
                Continue For
            End If

            ' Registrar la cédula para que no se repita en los siguientes bloques
            cedulasProcesadas.Add(cedula.Trim())

            ' 3. Asignar los datos usando la variable filaVisual (llena los TextBox consecutivamente)

            txtNOMBRE.Text = nombre : txtAPELLIDO.Text = apellido : txtCEDULA.Text = cedula
            txtN1.Text = n1 : txtN2.Text = n2 : txtN3.Text = n3 : txtN4.Text = n4
            txtPUNTOS1.Text = p1 : txtPUNTOS2.Text = p2 : txtPUNTOS3.Text = p3 : txtPUNTOS4.Text = p4
            txtN5.Text = n5 : txtN6.Text = n6 : txtN7.Text = n7 : txtN8.Text = n8
            txtPUNTOS5.Text = p5 : txtPUNTOS6.Text = p6 : txtPUNTOS7.Text = p7 : txtPUNTOS8.Text = p8
            txtN9.Text = n9 : txtN10.Text = n10 : txtN11.Text = n11 : txtN12.Text = n12
            txtPUNTOS9.Text = p9 : txtPUNTOS10.Text = p10 : txtPUNTOS11.Text = p11 : txtPUNTOS12.Text = p12
            txtN13.Text = n13 : txtN14.Text = n14 : txtN15.Text = n15 : txtN16.Text = n16
            txtPUNTOS13.Text = p13 : txtPUNTOS14.Text = p14 : txtPUNTOS15.Text = p15 : txtPUNTOS16.Text = p16
            txtCARRERA.Text = carrera



            ' Incrementamos la fila visual solo si encontramos y pintamos un alumno válido
            filaVisual += 1
        Next
    End Sub


    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"
            con.Open()
            MsgBox("CONECTADA CORRECTAMENTE", MsgBoxStyle.Information, "AVISO")
        Catch ex As Exception
            MsgBox("ERROR CORREXION", MsgBoxStyle.Critical, "AVISO")
        End Try
    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Hide()
        Form45_NOTAS_DE_TECNICO_SUPERIOR.Show()
    End Sub

    Private Sub btnENVIAR_Click(sender As Object, e As EventArgs) Handles btnENVIAR.Click
        ' 1. Filtro de Validación: Si los datos no son válidos, frena la ejecución de inmediato
        If datosValidos Then
            MessageBox.Show("LOS DATOS SON INCORRECTOS, INTÉNTELO NUEVAMENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 2. Control de Desbordamiento: Verifica que 'pos' no supere el tamaño del arreglo en MDIParent3
        If MDIParent3.nombre Is Nothing OrElse pos >= MDIParent3.nombre.Length Then
            MessageBox.Show("El almacenamiento está lleno. No se pueden agregar más registros.", "Error de Límite", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 3. Almacenamiento Cíclico en Arreglos (MDIParent3)
        MDIParent3.nombre(pos) = txtNOMBRE.Text
        MDIParent3.apellido(pos) = txtAPELLIDO.Text
        MDIParent3.cedula(pos) = txtCEDULA.Text
        MDIParent3.nota1(pos) = txtN1.Text
        MDIParent3.nota2(pos) = txtN2.Text
        MDIParent3.nota3(pos) = txtN3.Text
        MDIParent3.nota4(pos) = txtN4.Text
        MDIParent3.p1(pos) = txtPUNTOS1.Text
        MDIParent3.p2(pos) = txtPUNTOS2.Text
        MDIParent3.p3(pos) = txtPUNTOS3.Text
        MDIParent3.p4(pos) = txtPUNTOS4.Text
        MDIParent3.carrera(pos) = txtCARRERA.Text

        ' Incrementar posición para el siguiente registro
        pos += 1

        ' 4. Almacenamiento Global en Módulo (Module4) - Último registro activo
        Module4.nombre = txtNOMBRE.Text
        Module4.apellido = txtAPELLIDO.Text
        Module4.cedula = txtCEDULA.Text
        Module4.carrera = txtCARRERA.Text
        Module4.nota1 = txtN1.Text
        Module4.nota2 = txtN2.Text
        Module4.nota3 = txtN3.Text
        Module4.nota4 = txtN4.Text
        Module4.nota5 = txtN5.Text
        Module4.nota6 = txtN6.Text
        Module4.nota7 = txtN7.Text
        Module4.nota8 = txtN8.Text
        Module4.nota9 = txtN9.Text
        Module4.nota10 = txtN10.Text
        Module4.nota11 = txtN11.Text
        Module4.nota12 = txtN12.Text
        Module4.nota13 = txtN13.Text
        Module4.nota14 = txtN14.Text
        Module4.nota15 = txtN15.Text
        Module4.nota16 = txtN16.Text
        Module4.p1 = txtPUNTOS1.Text
        Module4.p2 = txtPUNTOS2.Text
        Module4.p3 = txtPUNTOS3.Text
        Module4.p4 = txtPUNTOS4.Text
        Module4.p5 = txtPUNTOS5.Text
        Module4.p6 = txtPUNTOS6.Text
        Module4.p7 = txtPUNTOS7.Text
        Module4.p8 = txtPUNTOS8.Text
        Module4.p9 = txtPUNTOS9.Text
        Module4.p10 = txtPUNTOS10.Text
        Module4.p11 = txtPUNTOS11.Text
        Module4.p12 = txtPUNTOS12.Text
        Module4.p13 = txtPUNTOS13.Text
        Module4.p14 = txtPUNTOS14.Text
        Module4.p15 = txtPUNTOS15.Text
        Module4.p16 = txtPUNTOS16.Text

        ' 5. Mensaje de éxito al usuario
        MessageBox.Show("DATOS SON CORRECTOS. REGISTRO INGRESADO EXITOSAMENTE", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' 6. Flujo de Ventanas: Cargar y mostrar el formulario correspondiente
        Dim f40 As New Form40()
    End Sub

    Private Sub btnIVCUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnIVCUATRIMESTRE.Click

    End Sub

    Private Sub btnIIICUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnIIICUATRIMESTRE.Click

    End Sub

    Private Sub btnIICUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnIICUATRIMESTRE.Click

    End Sub

    Private Sub btnICUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnICUATRIMESTRE.Click

    End Sub
End Class