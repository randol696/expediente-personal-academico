Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates

Public Class FORMULARIO_PROFESOR
    Dim conexion As String
    Dim con As New OleDbConnection
    Dim sql As New OleDbCommand
    Dim consulta As String = ""
    Dim dr As OleDbDataAdapter
    Dim ord As DataSet
    Dim busca As Byte
    Dim foto As Integer
    Dim pos As Integer
    Dim edad As String
    Dim area As String
    Dim ruta As String 'alamacenar la imagen
    Dim datosValidos As String
    Private Sub btnGUARDAR_Click(sender As Object, e As EventArgs) Handles btnGUARDAR.Click
        ' 1. Conexión limpia a la base de datos Access
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FS\Documents\PROYECTO BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb")

        ' 2. Consulta SQL corregida (Se eliminaron comas dobles y se alinearon exactamente 14 campos)
        Dim sql As String = "INSERT INTO [INGRESO DE DATOS DE LOS PROFESORES] " &
                        "(CARNET, [PRIMER NOMBRE], [SEGUNDO NOMBRE], [APELLIDO PATERNO], [APELLIDO MATERNO], CÉDULA, EDAD, GÉNERO, [CORREO ELECTRÓNICO], TELÉFONO, CURSO, PROVINCIA, COMARCA, [PAÍS DE PROCEDENCIA]) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Dim comando As New OleDbCommand(sql, conexion)

        ' 3. Parámetros agregados en el ORDEN EXACTO de la consulta SQL anterior (14 en total)
        comando.Parameters.AddWithValue("?", txtNumero.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtNombre.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtNombre2.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtApellido.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtApellido2.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtCedula.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbEdad.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbGENERO.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtCorreoElectronico.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtTelefono.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbCURSO.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbProvincia.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbComarca.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbPAIS.Text.ToUpper().Trim())

        ' 4. Control de conexión y ejecución segura
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Opcional: Aquí puedes llamar a una función para limpiar los controles después de guardar

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Cierra la conexión de forma correcta siempre
            conexion.Close()
        End Try
        ' 1. VALIDACIÓN DE DATOS (Verificamos antes de almacenar)
        Dim datosValidos As Boolean = True
        If Trim(txtNumero.Text) = "" Then
            MsgBox("El campo Carnet no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNumero.Focus()
        ElseIf Trim(txtNombre.Text) = "" Then
            MsgBox("El campo primer Nombre no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNombre.Focus()
        ElseIf Trim(txtNombre2.Text) = "" Then
            MsgBox("El campo segundo Nombre no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNombre2.Focus()
        ElseIf Trim(txtApellido.Text) = "" Then
            MsgBox("El campo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido.Focus()
        ElseIf Trim(txtApellido2.Text) = "" Then
            MsgBox("El campo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido2.Focus()
        ElseIf Trim(txtCedula.Text) = "" Then
            MsgBox("El campo Cédula no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCedula.Focus()
        ElseIf Trim(txtCorreoElectronico.Text) = "" Then
            MsgBox("El campo Correo no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCorreoElectronico.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        ElseIf Trim(cbEdad.Text) = "" Then
            MsgBox("Debe seleccionar o ingresar una edad.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbEdad.Focus()
        ElseIf Not IsNumeric(cbEdad.Text) OrElse CInt(cbEdad.Text) < 18 OrElse CInt(cbEdad.Text) > 100 Then
            MsgBox("La edad debe ser un número entre 18 y 100.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbEdad.Focus()
        ElseIf Trim(cbGENERO.Text) = "" Then
            MsgBox("El campo GENERO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbGENERO.Focus()
        ElseIf Trim(cbCURSO.Text) = "" Then
            MsgBox("El campo CURSO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbCURSO.Focus()
        ElseIf Trim(cbPAIS.Text) = "" Then
            MsgBox("El campo PAIS no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPAIS.Focus()
        ElseIf Trim(cbProvincia.Text) = "" Then
            MsgBox("El campo PROVINCIA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbProvincia.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        End If

        ' 2. PROCESAMIENTO DE LOS DATOS (Solo si pasa la validación)
        If datosValidos Then
            ' Declaración de variables locales
            Dim CARNET, PRIMERNOMBRE, SEGUNDONOMBRE, APELLIDOPATERNO, APELLIDOMATERNO, CEDULA, EDAD, CURSO, GENERO, PROVINCIA, CORREO, PAIS, TELEFONO As String

            ' Asignación a variables (Corregido: se cambió .Created por .Text)
            CARNET = txtNumero.Text
            PRIMERNOMBRE = txtNombre.Text
            SEGUNDONOMBRE = txtNombre2.Text
            APELLIDOPATERNO = txtApellido.Text
            APELLIDOMATERNO = txtApellido2.Text
            CEDULA = txtCedula.Text
            EDAD = cbEdad.Text
            CURSO = cbCURSO.Text
            GENERO = cbGENERO.Text
            PROVINCIA = cbProvincia.Text
            CORREO = txtCorreoElectronico.Text
            PAIS = cbPAIS.Text
            TELEFONO = txtTelefono.Text

            ' Guardar en la matriz de MDIParent2
            MDIParent2.carnet(pos) = CARNET
            MDIParent2.nombreprofesor(pos) = PRIMERNOMBRE
            MDIParent2.nombreprofesor2(pos) = SEGUNDONOMBRE
            MDIParent2.apellidoprofesor(pos) = APELLIDOPATERNO
            MDIParent2.apellidoprofesor2(pos) = APELLIDOMATERNO
            MDIParent2.cedulaprofesor(pos) = CEDULA
            MDIParent2.edadprofesor(pos) = EDAD
            MDIParent2.curso(pos) = CURSO
            MDIParent2.generoprofesor(pos) = GENERO
            MDIParent2.provinciaprofesor(pos) = PROVINCIA
            MDIParent2.paisprofesor(pos) = PAIS
            MDIParent2.telefonoprofesor(pos) = TELEFONO
            MDIParent2.correoelectronicoprofesor(pos) = CORREO
            MDIParent2.imagen(pos) = ruta

            ' Nota: Asegúrate de tener declarada la variable "ruta" en tu formulario
            ' MDIParent1.imagen(pos) = ruta 

            ' Incrementar posición para el siguiente registro
            pos += 1

            ' Mensaje de éxito
            MessageBox.Show("DATOS SON CORRECTOS. REGISTRO INGRESADO EXITOSAMENTE", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Mensaje de error si la validación falló
            MessageBox.Show("LOS DATOS SON INCORRECTOS, INTÉNTELO NUEVAMENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        txtNumero.Text = ""
        txtNombre.Text = ""
        txtNombre2.Text = ""
        txtApellido.Text = ""
        txtApellido2.Text = ""
        txtCedula.Text = ""
        cbEdad.SelectedIndex = -1
        cbGENERO.SelectedIndex = -1
        cbCURSO.SelectedIndex = -1
        cbPAIS.SelectedIndex = -1
        cbProvincia.SelectedIndex = -1
        cbComarca.SelectedIndex = -1
        txtTelefono.Text = ""
        txtCorreoElectronico.Text = ""
        pbIMAGEN.Image = Nothing
        MessageBox.Show("SUS DATOS ESTÁN BORRADOS", "TITULO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnGENERAR_Click(sender As Object, e As EventArgs) Handles btnGenerarCarnet.Click
        Dim entrada As String = txtNumero.Text.Trim()

        ' 1. VALIDACIÓN PRIMARIA DE ENTRADA (Debe ir al inicio)
        If String.IsNullOrEmpty(entrada) Then
            MessageBox.Show("Por favor, ingrese un número.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Limpiar espacios y guiones para estandarizar la validación
        Dim numero As String = entrada.Replace(" ", "").Replace("-", "")

        ' EXPRESIÓN REGULAR EXPLICADA:
        ' ^      = Inicia el texto
        ' \d{2,3}= Exactamente 1 o 5 dígitos numéricos
        ' $      = Termina el texto
        Dim carnet As String = "^\d{1,5}$"

        ' Lógica corregida: IsMatch = Éxito
        If Regex.IsMatch(numero, carnet) Then
            MessageBox.Show("El número de carnet es válido.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Número inválido." & vbCrLf & "Debe contener 2 o 3 dígitos numéricos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 2. VALIDACIÓN DE LISTA DE NÚMEROS (Opcional, si requieres buscar en una base de datos o lista)
        Dim numerosValidos As New List(Of String) From {}

        ' Aquí puedes agregar la lógica si necesitas buscar "numero" dent
    End Sub

    Private Sub btnVALIDARCEDULA_Click(sender As Object, e As EventArgs) Handles btnVALIDAR.Click
        ' Obtenemos el valor y eliminamos espacios accidentales
        Dim documento As String = txtCedula.Text.Trim()

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

    Public Function ValidarCedulaPanama(ByVal cedula As String) As Boolean
        ' Elimina los guiones y espacios para facilitar la comparación
        Dim numeroLimpio As String = cedula.Replace("-", "").Replace(" ", "")

        ' Patrones de cédula válidos (ajustar según sea necesario)
        ' Puedes usar expresiones regulares para un patrón más robusto
        ' Ejemplo básico de validación de formato:
        If String.IsNullOrWhiteSpace(cedula) Then
            Return False
        End If

        ' Aquí iría la lógica de validación más compleja.
        ' Por ahora, solo un ejemplo de validación simple:
        ' Si la cédula no tiene guiones y la cantidad de dígitos no es correcta.
        If cedula.IndexOf("-") = -1 Then ' Verifica si faltan guiones
            Return False
        End If

        ' Podrías agregar validaciones específicas por prefijo (ej. "PE-", "E-") y la longitud de los números.
        ' Por ejemplo, una cédula válida debe tener una longitud entre 9 y 11 caracteres.
        If cedula.Length < 9 Or cedula.Length > 11 Then
            Return False
        End If

        Return True
    End Function

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Hide()
        Form41_PERSONAL.Show()
    End Sub


    Private Sub btnEXAMINAR_Click_1(sender As Object, e As EventArgs) Handles btnEXAMINAR.Click
        With OpenFileDialog1
            .Title = "Selecciona una imagen"
            .FileName = Nothing
            .Filter = "JPG|*.jpg"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If (.ShowDialog = DialogResult.OK) Then
                pbIMAGEN.Load(.FileName)
                ruta = .FileName
            End If
        End With
    End Sub

    Private Sub cbEDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEdad.SelectedIndexChanged
        ' Validamos que haya una selección para evitar errores
        If cbEdad.SelectedItem Is Nothing Then Exit Sub

        ' Convertimos de forma segura
        Dim edad As Integer = CInt(cbEdad.SelectedItem.ToString())

        If edad >= 18 AndAlso edad <= 65 Then
            MessageBox.Show("La edad está permitida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf edad >= 0 AndAlso edad < 18 Then
            MessageBox.Show("No cumple con el rango de edad [18 a 65]", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Edad fuera de los rangos definidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnVALIDARTELEFONO_Click(sender As Object, e As EventArgs) Handles btnValidarTelefono.Click
        ' Limpiar espacios y guiones para estandarizar la validación
        Dim telefono As String = txtTelefono.Text.Trim().Replace(" ", "").Replace("-", "")

        ' EXPRESIÓN REGULAR EXPLICADA (2026):
        ' 1. Panamá: ^(\+507|507)?(6\d{7}|[23789]\d{6})$ -> Móviles (8 dígitos) o Fijos (7 dígitos)
        ' 2. Internacional: ^\+\d{7,15}$ -> Obliga el '+' seguido de 7 a 15 dígitos
        Dim patron As String = "^(\+507|507)?(6\d{7}|[23789]\d{6})$|^\+\d{7,15}$"

        ' Lógica corregida: IsMatch = Éxito
        If Regex.IsMatch(telefono, patron) Then
            MessageBox.Show("El número de teléfono es válido.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Número inválido." & vbCrLf &
                        "Panamá: 6XXX-XXXX o 2XX-XXXX" & vbCrLf &
                        "Extranjero: + (Código País) (Número)",
                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbGENERO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGENERO.SelectedIndexChanged
        ' Validar que la selección no esté vacía
        If cbGENERO.SelectedItem IsNot Nothing Then
            Dim generoSeleccionado As String = cbGENERO.SelectedItem.ToString()
            MessageBox.Show("Género seleccionado: " & generoSeleccionado, "Datos Personales")
        End If
    End Sub

    Private Sub cbPAISPROFESOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPAIS.SelectedIndexChanged
        ' Validar que la selección no sea nula antes de convertir a String
        If cbPAIS.SelectedItem IsNot Nothing Then
            Dim paisSeleccionado As String = cbPAIS.SelectedItem.ToString()
            MessageBox.Show("País del profesor seleccionado: " & paisSeleccionado, "Información Docente")
        End If
    End Sub

    Private Sub cbPROVINCIAPROFESOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedIndexChanged
        ' 1. Validar que realmente haya algo seleccionado para evitar errores
        If cbProvincia.SelectedItem IsNot Nothing Then

            ' 2. Obtener el texto seleccionado una sola vez
            Dim seleccion As String = cbProvincia.SelectedItem.ToString()

            ' 3. Mostrar un único mensaje con el valor seleccionado
            MessageBox.Show("Ubicación del profesor: " & seleccion, "Registro de Ubicación")

        End If
    End Sub

    Private Sub cbPROVINCIACOMARCAPROFESOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbComarca.SelectedIndexChanged
        ' 1. Validar que realmente haya algo seleccionado para evitar errores
        If cbComarca.SelectedItem IsNot Nothing Then

            ' 2. Obtener el texto seleccionado una sola vez
            Dim seleccion As String = cbComarca.SelectedItem.ToString()

            ' 3. Mostrar un único mensaje con el valor seleccionado
            MessageBox.Show("Ubicación del profesor: " & seleccion, "Registro de Ubicación")

        End If
    End Sub

    Private Sub btnVALIDARCORREOPROFESOR_Click(sender As Object, e As EventArgs) Handles btnValidarCorreo.Click
        ' Obtenemos el valor y eliminamos espacios accidentales
        Dim correo As String = txtCorreoElectronico.Text.Trim()

        ' Patrón de validación para correos estándar
        Dim patron As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Validar si el correo coincide con el patrón
        If System.Text.RegularExpressions.Regex.IsMatch(correo, patron) Then
            MessageBox.Show("CORREO ELECTRÓNICO VÁLIDO.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Formato no válido." & vbCrLf &
                            "Ejemplos aceptados:" & vbCrLf &
                            "GMAIL: usuario@gmail.com" & vbCrLf &
                            "HOTMAIL: usuario@hotmail.com" & vbCrLf &
                            "YAHOO: usuario@yahoo.com",
                            "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FORMULARIO_PROFESOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FS\Documents\PROYECTO BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"
            con.Open()
            MsgBox("CONECTADA CORRECTAMENTE", MsgBoxStyle.Information, "AVISO")
        Catch ex As Exception
            MsgBox("ERROR CORREXION", MsgBoxStyle.Critical, "AVISO")
        End Try

    End Sub

    Private Sub cbCursoProfesor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCURSO.SelectedIndexChanged
        ' 1. Validar que realmente haya algo seleccionado
        If cbCURSO.SelectedItem IsNot Nothing Then

            ' 2. Obtener el texto seleccionado una sola vez
            Dim seleccion As String = cbCURSO.SelectedItem.ToString()

            ' 3. Mostrar un único mensaje con el valor
            MessageBox.Show("Has seleccionado: " & seleccion, "Selección Registrada")

        End If
    End Sub

    Private Sub btnPREGUARDAR_Click(sender As Object, e As EventArgs) Handles btnPREGUARDAR.Click
        ' 1. VALIDACIÓN DE DATOS (Verificamos antes de almacenar)
        Dim datosValidos As Boolean = True
        If Trim(txtNumero.Text) = "" Then
            MsgBox("El campo Carnet no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNumero.Focus()
        ElseIf Trim(txtNombre.Text) = "" Then
            MsgBox("El campo primer Nombre no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNombre.Focus()
        ElseIf Trim(txtNombre2.Text) = "" Then
            MsgBox("El campo segundo Nombre no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNombre2.Focus()
        ElseIf Trim(txtApellido.Text) = "" Then
            MsgBox("El campo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido.Focus()
        ElseIf Trim(txtApellido2.Text) = "" Then
            MsgBox("El campo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido2.Focus()
        ElseIf Trim(txtCedula.Text) = "" Then
            MsgBox("El campo Cédula no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCedula.Focus()
        ElseIf Trim(txtCorreoElectronico.Text) = "" Then
            MsgBox("El campo Correo no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCorreoElectronico.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        ElseIf Trim(cbEdad.Text) = "" Then
            MsgBox("Debe seleccionar o ingresar una edad.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbEdad.Focus()
        ElseIf Not IsNumeric(cbEdad.Text) OrElse CInt(cbEdad.Text) < 18 OrElse CInt(cbEdad.Text) > 100 Then
            MsgBox("La edad debe ser un número entre 18 y 100.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbEdad.Focus()
        ElseIf Trim(cbGENERO.Text) = "" Then
            MsgBox("El campo GENERO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbGENERO.Focus()
        ElseIf Trim(cbCURSO.Text) = "" Then
            MsgBox("El campo CURSO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbCURSO.Focus()
        ElseIf Trim(cbPAIS.Text) = "" Then
            MsgBox("El campo PAIS no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPAIS.Focus()
        ElseIf Trim(cbProvincia.Text) = "" Then
            MsgBox("El campo PROVINCIA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbProvincia.Focus()
        ElseIf Trim(cbComarca.Text) = "" Then
            MsgBox("El campo COMARCA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbComarca.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        End If

        ' 2. PROCESAMIENTO DE LOS DATOS (Solo si pasa la validación)
        If datosValidos Then
            ' Declaración de variables locales
            Dim CARNET, PRIMERNOMBRE, SEGUNDONOMBRE, APELLIDOPATERNO, APELLIDOMATERNO, CEDULA, EDAD, CURSO, GENERO, PROVINCIA, COMARCA, CORREO, PAIS, TELEFONO As String

            ' Asignación a variables (Corregido: se cambió .Created por .Text)
            CARNET = txtNumero.Text
            PRIMERNOMBRE = txtNombre.Text
            SEGUNDONOMBRE = txtNombre2.Text
            APELLIDOPATERNO = txtApellido.Text
            APELLIDOMATERNO = txtApellido2.Text
            CEDULA = txtCedula.Text
            EDAD = cbEdad.Text
            CURSO = cbCURSO.Text
            GENERO = cbGENERO.Text
            PROVINCIA = cbProvincia.Text
            COMARCA = cbComarca.Text
            CORREO = txtCorreoElectronico.Text
            PAIS = cbPAIS.Text
            TELEFONO = txtTelefono.Text

            ' Guardar en la matriz de MDIParent2
            MDIParent2.carnet(pos) = CARNET
            MDIParent2.nombreprofesor(pos) = PRIMERNOMBRE
            MDIParent2.nombreprofesor2(pos) = SEGUNDONOMBRE
            MDIParent2.apellidoprofesor(pos) = APELLIDOPATERNO
            MDIParent2.apellidoprofesor2(pos) = APELLIDOMATERNO
            MDIParent2.cedulaprofesor(pos) = CEDULA
            MDIParent2.edadprofesor(pos) = EDAD
            MDIParent2.curso(pos) = CURSO
            MDIParent2.generoprofesor(pos) = GENERO
            MDIParent2.provinciaprofesor(pos) = PROVINCIA
            MDIParent2.comarcaprofesor(pos) = COMARCA
            MDIParent2.paisprofesor(pos) = PAIS
            MDIParent2.telefonoprofesor(pos) = TELEFONO
            MDIParent2.correoelectronicoprofesor(pos) = CORREO
            MDIParent2.imagen(pos) = ruta

            ' Nota: Asegúrate de tener declarada la variable "ruta" en tu formulario
            ' MDIParent1.imagen(pos) = ruta 

            ' Incrementar posición para el siguiente registro
            pos += 1

            ' Mensaje de éxito
            MessageBox.Show("DATOS SON CORRECTOS. REGISTRO INGRESADO EXITOSAMENTE", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Mensaje de error si la validación falló
            MessageBox.Show("LOS DATOS SON INCORRECTOS, INTÉNTELO NUEVAMENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnOTROSDATOSPROFESOR_Click(sender As Object, e As EventArgs) Handles btnOTROS.Click
        ' 1. Conexión limpia a la base de datos Access
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FS\Documents\PROYECTO BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb")

        ' 2. Consulta SQL corregida (Se eliminaron comas dobles y se alinearon exactamente 14 campos)
        Dim sql As String = "INSERT INTO [INGRESO DE DATOS DE LOS PROFESORES] " &
                        "(CARNET, [PRIMER NOMBRE], [SEGUNDO NOMBRE], [APELLIDO PATERNO], [APELLIDO MATERNO], CÉDULA, EDAD, GÉNERO, [CORREO ELECTRÓNICO], TELÉFONO, CURSO, PROVINCIA, COMARCA, [PAÍS DE PROCEDENCIA]) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Dim comando As New OleDbCommand(sql, conexion)

        ' 3. Parámetros agregados en el ORDEN EXACTO de la consulta SQL anterior (14 en total)
        comando.Parameters.AddWithValue("?", txtNumero.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtNombre.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtNombre2.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtApellido.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtApellido2.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtCedula.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbEdad.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbGENERO.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtCorreoElectronico.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", txtTelefono.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbCURSO.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbProvincia.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbComarca.Text.ToUpper().Trim())
        comando.Parameters.AddWithValue("?", cbPAIS.Text.ToUpper().Trim())

        ' 4. Control de conexión y ejecución segura
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Opcional: Aquí puedes llamar a una función para limpiar los controles después de guardar

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Cierra la conexión de forma correcta siempre
            conexion.Close()
        End Try
        ' 1. VALIDACIÓN DE DATOS (Verificamos antes de almacenar)
        Dim datosValidos As Boolean = True
        If Trim(txtNumero.Text) = "" Then
            MsgBox("El campo Carnet no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNumero.Focus()
        ElseIf Trim(txtNombre.Text) = "" Then
            MsgBox("El campo primer Nombre no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNombre.Focus()
        ElseIf Trim(txtNombre2.Text) = "" Then
            MsgBox("El campo segundo Nombre no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtNombre2.Focus()
        ElseIf Trim(txtApellido.Text) = "" Then
            MsgBox("El campo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido.Focus()
        ElseIf Trim(txtApellido2.Text) = "" Then
            MsgBox("El campo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido2.Focus()
        ElseIf Trim(txtCedula.Text) = "" Then
            MsgBox("El campo Cédula no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCedula.Focus()
        ElseIf Trim(txtCorreoElectronico.Text) = "" Then
            MsgBox("El campo Correo no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCorreoElectronico.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        ElseIf Trim(cbEdad.Text) = "" Then
            MsgBox("Debe seleccionar o ingresar una edad.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbEdad.Focus()
        ElseIf Not IsNumeric(cbEdad.Text) OrElse CInt(cbEdad.Text) < 18 OrElse CInt(cbEdad.Text) > 100 Then
            MsgBox("La edad debe ser un número entre 18 y 100.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbEdad.Focus()
        ElseIf Trim(cbGENERO.Text) = "" Then
            MsgBox("El campo GENERO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbGENERO.Focus()
        ElseIf Trim(cbCURSO.Text) = "" Then
            MsgBox("El campo CURSO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbCURSO.Focus()
        ElseIf Trim(cbPAIS.Text) = "" Then
            MsgBox("El campo PAIS no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPAIS.Focus()
        ElseIf Trim(cbComarca.Text) = "" Then
            MsgBox("El campo COMARCA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbComarca.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        End If

        ' 2. PROCESAMIENTO DE LOS DATOS (Solo si pasa la validación)
        If datosValidos Then
            ' Declaración de variables locales
            Dim CARNET, PRIMERNOMBRE, SEGUNDONOMBRE, APELLIDOPATERNO, APELLIDOMATERNO, CEDULA, EDAD, CURSO, GENERO, COMARCA, CORREO, PAIS, TELEFONO As String

            ' Asignación a variables (Corregido: se cambió .Created por .Text)
            CARNET = txtNumero.Text
            PRIMERNOMBRE = txtNombre.Text
            SEGUNDONOMBRE = txtNombre2.Text
            APELLIDOPATERNO = txtApellido.Text
            APELLIDOMATERNO = txtApellido2.Text
            CEDULA = txtCedula.Text
            EDAD = cbEdad.Text
            CURSO = cbCURSO.Text
            GENERO = cbGENERO.Text
            COMARCA = cbComarca.Text
            CORREO = txtCorreoElectronico.Text
            PAIS = cbPAIS.Text
            TELEFONO = txtTelefono.Text

            ' Guardar en la matriz de MDIParent2
            MDIParent2.carnet(pos) = CARNET
            MDIParent2.nombreprofesor(pos) = PRIMERNOMBRE
            MDIParent2.nombreprofesor2(pos) = SEGUNDONOMBRE
            MDIParent2.apellidoprofesor(pos) = APELLIDOPATERNO
            MDIParent2.apellidoprofesor2(pos) = APELLIDOMATERNO
            MDIParent2.cedulaprofesor(pos) = CEDULA
            MDIParent2.edadprofesor(pos) = EDAD
            MDIParent2.curso(pos) = CURSO
            MDIParent2.generoprofesor(pos) = GENERO
            MDIParent2.comarcaprofesor(pos) = COMARCA
            MDIParent2.paisprofesor(pos) = PAIS
            MDIParent2.telefonoprofesor(pos) = TELEFONO
            MDIParent2.correoelectronicoprofesor(pos) = CORREO
            MDIParent2.imagen(pos) = ruta

            ' Nota: Asegúrate de tener declarada la variable "ruta" en tu formulario
            ' MDIParent1.imagen(pos) = ruta 

            ' Incrementar posición para el siguiente registro
            pos += 1

            ' Mensaje de éxito
            MessageBox.Show("DATOS SON CORRECTOS. REGISTRO INGRESADO EXITOSAMENTE", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Mensaje de error si la validación falló
            MessageBox.Show("LOS DATOS SON INCORRECTOS, INTÉNTELO NUEVAMENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
