Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates
Imports System.Data

Public Class Form1_INGRESO_ALUMNO
    Dim con As New OleDbConnection
    Dim sql As New OleDbCommand
    Dim consulta As String = ""
    Dim dr As OleDbDataAdapter
    Dim ord As DataSet
    Dim busca As Byte
    Dim numero As Integer
    Private conexion As Integer
    Dim foto As Integer
    Public pos As Integer
    Dim ruta As String 'alamacenar la imagen
    Dim edad As Integer
    Dim ingreso As Integer
    Dim comando As String

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGUARDAR.Click
        ' 1. VALIDACIÓN DE DATOS
        Dim datosValidos As Boolean = True

        If Trim(txtNumero.Text) = "" Then
            MsgBox("El campo Número no puede estar vacío.", vbExclamation, "Error de Validación")
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
            MsgBox("El campo primer Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido.Focus()
        ElseIf Trim(txtApellido2.Text) = "" Then
            MsgBox("El campo segundo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido2.Focus()
        ElseIf Trim(txtCedula.Text) = "" Then
            MsgBox("El campo Cédula no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCedula.Focus()
        ElseIf Trim(cbFECHADIA.Text) = "" Then
            MsgBox("El campo Día de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFECHADIA.Focus()
        ElseIf Trim(cbFECHAMES.Text) = "" Then
            MsgBox("El campo Mes de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFECHAMES.Focus()
        ElseIf Trim(cbFECHAAÑO.Text) = "" Then
            MsgBox("El campo año de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFECHAAÑO.Focus()
        ElseIf Trim(cbGENERO.Text) = "" Then
            MsgBox("El campo genero no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbGENERO.Focus()
        ElseIf Trim(cbTecnico.Text) = "" Then
            MsgBox("El campo CARRERA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbTecnico.Focus()
        ElseIf Trim(cbPAIS.Text) = "" Then
            MsgBox("El campo PAIS no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPAIS.Focus()
        ElseIf Trim(cbPROVINCIA.Text) = "" Then
            MsgBox("El campo PROVINCIA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPROVINCIA.Focus()
        ElseIf Trim(cbDISTRITO.Text) = "" Then
            MsgBox("El campo DISTRITO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbDISTRITO.Focus()
        ElseIf Trim(cbCORREGIMIENTO.Text) = "" Then
            MsgBox("El campo Corregimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbCORREGIMIENTO.Focus()
        ElseIf Trim(txtDireccion.Text) = "" Then
            MsgBox("El campo Dirección no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtDireccion.Focus()
        ElseIf Trim(txtColegio.Text) = "" Then
            MsgBox("El campo COLEGIO SECUNDARIO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtColegio.Focus()
        ElseIf Trim(cbBACHILLER.Text) = "" Then
            MsgBox("El campo BACHILLER no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbBachiller.Focus()
        ElseIf Trim(txtCorreoElectronico.Text) = "" Then
            MsgBox("El campo Correo no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCorreoElectronico.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        End If

        ' 2. PROCESAMIENTO DE LOS DATOS
        If datosValidos Then
            ' Declaración y asignación directa de variables locales
            Dim NUMERO As String = txtNumero.Text
            Dim NOMBRE As String = txtNombre.Text
            Dim NOMBRE2 As String = txtNombre2.Text
            Dim APELLIDO As String = txtApellido.Text
            Dim APELLIDO2 As String = txtApellido2.Text
            Dim CEDULA As String = txtCedula.Text
            Dim EDAD As String = cbEdad.Text
            Dim FECHANACIMIENTO As String = cbFECHADIA.Text & "/" & cbFECHAMES.Text & "/" & cbFECHAAÑO.Text
            Dim GENERO As String = cbGENERO.Text
            Dim CARRERA As String = cbTecnico.Text
            Dim PAIS As String = cbPAIS.Text
            Dim PROVINCIA As String = cbPROVINCIA.Text
            Dim COMARCA As String = cbCOMARCA.Text ' <-- CORREGIDO: Antes llamaba a cbPROVINCIA
            Dim DISTRITO As String = cbDISTRITO.Text
            Dim CORREGIMIENTO As String = cbCORREGIMIENTO.Text
            Dim DIRECCION As String = txtDireccion.Text
            Dim COLEGIO As String = txtColegio.Text
            Dim BACHILLER As String = cbBachiller.Text
            Dim CORREOELECTRONICO As String = txtCorreoElectronico.Text
            Dim TELEFONO As String = txtTelefono.Text

            ' Guardar en los arreglos del formulario MDI
            MDIParent1.numero(pos) = NUMERO
            MDIParent1.nombre(pos) = NOMBRE
            MDIParent1.nombre2(pos) = NOMBRE2
            MDIParent1.apellido(pos) = APELLIDO
            MDIParent1.apellido2(pos) = APELLIDO2
            MDIParent1.cedula(pos) = CEDULA
            MDIParent1.tecnico(pos) = CARRERA
            MDIParent1.edad(pos) = EDAD
            MDIParent1.fechadia(pos) = cbFECHADIA.Text
            MDIParent1.fechames(pos) = cbFECHAMES.Text
            MDIParent1.fechanaño(pos) = cbFECHAAÑO.Text
            MDIParent1.correoelectronico(pos) = CORREOELECTRONICO
            MDIParent1.telefono(pos) = TELEFONO
            MDIParent1.direccion(pos) = DIRECCION
            MDIParent1.colegio(pos) = COLEGIO
            MDIParent1.distrito(pos) = DISTRITO
            MDIParent1.corregimiento(pos) = CORREGIMIENTO
            MDIParent1.genero(pos) = GENERO
            MDIParent1.provincia(pos) = PROVINCIA
            MDIParent1.comarca(pos) = COMARCA
            MDIParent1.pais(pos) = PAIS
            MDIParent1.bachiller(pos) = BACHILLER

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



    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        txtNumero.Text = ""
        txtNombre.Text = ""
        txtNombre2.Text = ""
        txtApellido.Text = ""
        txtApellido2.Text = ""
        txtCedula.Text = ""
        cbTecnico.SelectedIndex = -1
        cbEDAD.SelectedIndex = -1
        cbFECHADIA.SelectedIndex = -1
        cbFECHAMES.SelectedIndex = -1
        cbFECHAAÑO.SelectedIndex = -1
        cbGENERO.SelectedIndex = -1
        txtCorreoElectronico.Text = ""
        txtColegio.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        cbPROVINCIA.SelectedIndex = -1
        cbCOMARCA.SelectedIndex = -1
        cbPAIS.SelectedIndex = -1
        cbDISTRITO.SelectedIndex = -1
        cbCorregimiento.SelectedIndex = -1
        cbBachiller.SelectedIndex = -1
        pbImagen.Image = Nothing
        MessageBox.Show("SUS DATOS ESTÁN BORRADOS", "TITULO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        With OpenFileDialog1
            .Title = "Selecciona una imagen"
            .FileName = Nothing
            .Filter = "JPG|*.jpg"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If (.ShowDialog = DialogResult.OK) Then
                pbImagen.Load(.FileName)
                ruta = .FileName
            End If
        End With
    End Sub

    Private Sub BtnGenerarCarnet_Click(sender As Object, e As EventArgs) Handles BtnGenerarCarnet.Click
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
        ' \d{2,3}= Exactamente 1 o 3 dígitos numéricos
        ' $      = Termina el texto
        Dim carnet As String = "^\d{1,3}$"

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

        ' Aquí puedes agregar la lógica si necesitas buscar "numero" dentro de "numerosValidos"

    End Sub


    Private Sub CbTecnico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTecnico.SelectedIndexChanged
        ' 1. Validar que no sea una selección vacía
        If cbTecnico.SelectedIndex <> -1 Then

            ' 2. Obtener el nombre (Texto)
            Dim nombreTecnico As String = cbTecnico.Text

            ' 3. Si usas una base de datos, lo ideal es capturar el ID (Value)
            ' Dim idTecnico As Integer = Convert.ToInt32(cbTecnico.SelectedValue)

            MessageBox.Show("Técnico asignado: " & nombreTecnico, "Gestión de Técnicos")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Hide()
        Form41_PERSONAL.Show()
    End Sub



    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles btnVALIDAR.Click
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

    Private Sub Form1_INGRESO_ALUMNO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb"
            con.Open()
            MsgBox("CONECTADA CORRECTAMENTE", MsgBoxStyle.Information, "AVISO")
        Catch ex As Exception
            MsgBox("ERROR CORREXION", MsgBoxStyle.Critical, "AVISO")
        End Try

    End Sub

    Private Sub CbEdad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEDAD.SelectedIndexChanged
        ' Validamos que haya una selección para evitar errores
        If cbEDAD.SelectedItem Is Nothing Then Exit Sub

        ' Convertimos de forma segura
        Dim edad As Integer = CInt(cbEDAD.SelectedItem.ToString())

        If edad >= 18 AndAlso edad <= 65 Then
            MessageBox.Show("La edad está permitida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf edad >= 0 AndAlso edad < 18 Then
            MessageBox.Show("No cumple con el rango de edad [18 a 65]", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Edad fuera de los rangos definidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub BtnValidarTelefono_Click(sender As Object, e As EventArgs) Handles btnVALIDARTELEFONO.Click
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


    Private Sub CbGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGENERO.SelectedIndexChanged
        ' Validamos que haya una selección activa
        If cbGENERO.SelectedItem IsNot Nothing Then
            Dim generoSeleccionado As String = cbGENERO.SelectedItem.ToString()

            ' Usamos interpolación ($) para que el código sea más legible
            MessageBox.Show($"Has seleccionado: {generoSeleccionado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPAIS.SelectedIndexChanged
        ' Validar que haya algo seleccionado para evitar errores
        If cbPAIS.SelectedItem IsNot Nothing Then
            Dim paisSeleccionado As String = cbPAIS.SelectedItem.ToString()
            MessageBox.Show("Has seleccionado: " & paisSeleccionado)
        End If
    End Sub

    Private Sub CbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPROVINCIA.SelectedIndexChanged
        ' 1. Validar que realmente haya algo seleccionado
        If cbPROVINCIA.SelectedItem IsNot Nothing Then

            ' 2. Obtener el texto seleccionado una sola vez
            Dim seleccion As String = cbPROVINCIA.SelectedItem.ToString()

            ' 3. Mostrar un único mensaje con el valor
            MessageBox.Show("Has seleccionado: " & seleccion, "Selección Registrada")

        End If
    End Sub

    Private Sub CbComarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCOMARCA.SelectedIndexChanged
        ' 1. Validar que realmente haya algo seleccionado
        If cbCOMARCA.SelectedItem IsNot Nothing Then

            ' 2. Obtener el texto seleccionado una sola vez
            Dim seleccion As String = cbCOMARCA.SelectedItem.ToString()

            ' 3. Mostrar un único mensaje con el valor
            MessageBox.Show("Has seleccionado: " & seleccion, "Selección Registrada")

        End If
    End Sub

    Private Sub CbDistrito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDISTRITO.SelectedIndexChanged
        ' Validar que el elemento no sea nulo antes de convertirlo a String
        If cbDISTRITO.SelectedItem IsNot Nothing Then
            Dim distritoSeleccionado As String = cbDISTRITO.SelectedItem.ToString()
            MessageBox.Show("Has seleccionado el distrito: " & distritoSeleccionado, "Confirmación")
        End If
    End Sub

    Private Sub CbCorregimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCORREGIMIENTO.SelectedIndexChanged
        ' Validar que el elemento seleccionado no sea nulo
        If cbCORREGIMIENTO.SelectedItem IsNot Nothing Then
            Dim corregimientoSeleccionado As String = cbCORREGIMIENTO.SelectedItem.ToString()
            MessageBox.Show("Has seleccionado el corregimiento: " & corregimientoSeleccionado, "Confirmación")
        End If
    End Sub

    Private Sub CbBachiller_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBACHILLER.SelectedIndexChanged
        ' Validar que el elemento no sea nulo antes de usar .ToString()
        If cbBACHILLER.SelectedItem IsNot Nothing Then
            Dim bachillerSeleccionado As String = cbBACHILLER.SelectedItem.ToString()
            MessageBox.Show("Has seleccionado el bachillerato: " & bachillerSeleccionado, "Formación Académica")
        End If
    End Sub

    Private Sub BtnValidarCorreo_Click(sender As Object, e As EventArgs) Handles BtnValidarCorreo.Click

        ' 1. Obtener valor y limpiar espacios
        Dim correo As String = txtCorreoElectronico.Text.Trim()

        ' 2. Definir el patrón de validación
        Dim patron As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"

        ' 3. Evaluar
        If Regex.IsMatch(correo, patron) Then
            MessageBox.Show("CORREO ELECTRÓNICO VÁLIDO.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Formato no válido." & vbCrLf &
                            "Ejemplos aceptados:" & vbCrLf &
                            "GMAIL: Estudiante@Gmail.com" & vbCrLf &
                            "HOTMAIL: cc@Hotmail.com" & vbCrLf &
                            "YAHOO: usuario@yahoo.com",
                            "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnPREGUARDAR.Click
        ' 1. Conexión y Consulta SQL limpia con exactamente 21 signos de interrogación (?)
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb")

        Dim sql As String = "INSERT INTO [INGRESO DE DATOS DE LOS ESTUDIANTES] " &
                "(NÚMERO, [PRIMER NOMBRE], [SEGUNDO NOMBRE], [APELLIDO PATERNO], [APELLIDO MATERNO], CÉDULA, CARRERA, EDAD, [FECHA DE NACIMIENTO], DIRECCIÓN, DISTRITO, CORREGIMIENTO, " &
                "[COLEGIO SECUNDARIO], [CORREO ELECTRÓNICO], TELÉFONO, GÉNERO, PROVINCIA, COMARCA, [PAÍS DE PROCEDENCIA], ESCUELA, BACHILLER) " &
                "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Dim comando As New OleDbCommand(sql, conexion)

        ' 2. Consolidación de la fecha
        Dim fechaNacimiento As String = $"{cbFechaDIA.Text}/{cbFechaMES.Text}/{cbFechaAÑO.Text}"

        ' 3. Parámetros agregados en el ORDEN EXACTO en que aparecen las columnas arriba
        comando.Parameters.AddWithValue("?", txtNumero.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtNombre.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtNombre2.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtApellido.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtApellido2.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtCedula.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbTecnico.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbEdad.Text.ToUpper())
        comando.Parameters.AddWithValue("?", fechaNacimiento.ToUpper())
        comando.Parameters.AddWithValue("?", txtDireccion.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbDistrito.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbCorregimiento.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtColegio.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtCorreoElectronico.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtTelefono.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbGENERO.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbProvincia.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbComarca.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbPAIS.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbBachiller.Text.ToUpper())

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

    Private Sub BtnPreGUARDAR_Click(sender As Object, e As EventArgs) Handles BtnPreGUARDAR.Click
        ' 1. VALIDACIÓN DE DATOS
        Dim datosValidos As Boolean = True

        If Trim(txtNumero.Text) = "" Then
            MsgBox("El campo Número no puede estar vacío.", vbExclamation, "Error de Validación")
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
            MsgBox("El campo primer Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido.Focus()
        ElseIf Trim(txtApellido2.Text) = "" Then
            MsgBox("El campo segundo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido2.Focus()
        ElseIf Trim(txtCedula.Text) = "" Then
            MsgBox("El campo Cédula no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCedula.Focus()
        ElseIf Trim(cbFECHADIA.Text) = "" Then
            MsgBox("El campo Día de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFECHADIA.Focus()
        ElseIf Trim(cbFECHAMES.Text) = "" Then
            MsgBox("El campo Mes de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFECHAMES.Focus()
        ElseIf Trim(cbFECHAAÑO.Text) = "" Then
            MsgBox("El campo año de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFECHAAÑO.Focus()
        ElseIf Trim(cbGENERO.Text) = "" Then
            MsgBox("El campo genero no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbGENERO.Focus()
        ElseIf Trim(cbTecnico.Text) = "" Then
            MsgBox("El campo CARRERA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbTecnico.Focus()
        ElseIf Trim(cbPAIS.Text) = "" Then
            MsgBox("El campo PAIS no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPAIS.Focus()
        ElseIf Trim(cbPROVINCIA.Text) = "" Then
            MsgBox("El campo PROVINCIA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPROVINCIA.Focus()
        ElseIf Trim(cbCOMARCA.Text) = "" Then
            MsgBox("El campo COMARCA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbCOMARCA.Focus()
        ElseIf Trim(cbDISTRITO.Text) = "" Then
            MsgBox("El campo DISTRITO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbDISTRITO.Focus()
        ElseIf Trim(cbCORREGIMIENTO.Text) = "" Then
            MsgBox("El campo Corregimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbCORREGIMIENTO.Focus()
        ElseIf Trim(txtDireccion.Text) = "" Then
            MsgBox("El campo Dirección no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtDireccion.Focus()
        ElseIf Trim(txtColegio.Text) = "" Then
            MsgBox("El campo COLEGIO SECUNDARIO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtColegio.Focus()
        ElseIf Trim(cbBACHILLER.Text) = "" Then
            MsgBox("El campo BACHILLER no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbBachiller.Focus()
        ElseIf Trim(txtCorreoElectronico.Text) = "" Then
            MsgBox("El campo Correo no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCorreoElectronico.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        End If

        ' 2. PROCESAMIENTO DE LOS DATOS
        If datosValidos Then
            ' Declaración y asignación directa de variables locales
            Dim NUMERO As String = txtNumero.Text
            Dim NOMBRE As String = txtNombre.Text
            Dim NOMBRE2 As String = txtNombre2.Text
            Dim APELLIDO As String = txtApellido.Text
            Dim APELLIDO2 As String = txtApellido2.Text
            Dim CEDULA As String = txtCedula.Text
            Dim EDAD As String = cbEDAD.Text
            Dim FECHANACIMIENTO As String = cbFECHADIA.Text & "/" & cbFECHAMES.Text & "/" & cbFECHAAÑO.Text
            Dim GENERO As String = cbGENERO.Text
            Dim CARRERA As String = cbTecnico.Text
            Dim PAIS As String = cbPAIS.Text
            Dim PROVINCIA As String = cbPROVINCIA.Text
            Dim COMARCA As String = cbCOMARCA.Text ' <-- CORREGIDO: Antes llamaba a cbPROVINCIA
            Dim DISTRITO As String = cbDISTRITO.Text
            Dim CORREGIMIENTO As String = cbCORREGIMIENTO.Text
            Dim DIRECCION As String = txtDireccion.Text
            Dim COLEGIO As String = txtColegio.Text
            Dim BACHILLER As String = cbBachiller.Text
            Dim CORREOELECTRONICO As String = txtCorreoElectronico.Text
            Dim TELEFONO As String = txtTelefono.Text

            ' Guardar en los arreglos del formulario MDI
            MDIParent1.numero(pos) = NUMERO
            MDIParent1.nombre(pos) = NOMBRE
            MDIParent1.nombre2(pos) = NOMBRE2
            MDIParent1.apellido(pos) = APELLIDO
            MDIParent1.apellido2(pos) = APELLIDO2
            MDIParent1.cedula(pos) = CEDULA
            MDIParent1.tecnico(pos) = CARRERA
            MDIParent1.edad(pos) = EDAD
            MDIParent1.fechadia(pos) = cbFECHADIA.Text
            MDIParent1.fechames(pos) = cbFECHAMES.Text
            MDIParent1.fechanaño(pos) = cbFECHAAÑO.Text
            MDIParent1.correoelectronico(pos) = CORREOELECTRONICO
            MDIParent1.telefono(pos) = TELEFONO
            MDIParent1.direccion(pos) = DIRECCION
            MDIParent1.colegio(pos) = COLEGIO
            MDIParent1.distrito(pos) = DISTRITO
            MDIParent1.corregimiento(pos) = CORREGIMIENTO
            MDIParent1.genero(pos) = GENERO
            MDIParent1.provincia(pos) = PROVINCIA
            MDIParent1.comarca(pos) = COMARCA
            MDIParent1.pais(pos) = PAIS
            MDIParent1.bachiller(pos) = BACHILLER

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

    Private Sub BtnOTROSDATOS_Click(sender As Object, e As EventArgs) Handles btnOTROS.Click
        ' 1. VALIDACIÓN DE DATOS
        Dim datosValidos As Boolean = True

        If Trim(txtNumero.Text) = "" Then
            MsgBox("El campo Número no puede estar vacío.", vbExclamation, "Error de Validación")
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
            MsgBox("El campo primer Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido.Focus()
        ElseIf Trim(txtApellido2.Text) = "" Then
            MsgBox("El campo segundo Apellido no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtApellido2.Focus()
        ElseIf Trim(txtCedula.Text) = "" Then
            MsgBox("El campo Cédula no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCedula.Focus()
        ElseIf Trim(cbFechaDIA.Text) = "" Then
            MsgBox("El campo Día de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFechaDIA.Focus()
        ElseIf Trim(cbFechaMES.Text) = "" Then
            MsgBox("El campo Mes de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFechaMES.Focus()
        ElseIf Trim(cbFechaAÑO.Text) = "" Then
            MsgBox("El campo año de Nacimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbFechaAÑO.Focus()
        ElseIf Trim(cbGENERO.Text) = "" Then
            MsgBox("El campo genero no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbGENERO.Focus()
        ElseIf Trim(cbTecnico.Text) = "" Then
            MsgBox("El campo CARRERA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbTecnico.Focus()
        ElseIf Trim(cbPAIS.Text) = "" Then
            MsgBox("El campo PAIS no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbPAIS.Focus()
        ElseIf Trim(cbComarca.Text) = "" Then
            MsgBox("El campo COMARCA no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbComarca.Focus()
        ElseIf Trim(cbDistrito.Text) = "" Then
            MsgBox("El campo DISTRITO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbDistrito.Focus()
        ElseIf Trim(cbCorregimiento.Text) = "" Then
            MsgBox("El campo Corregimiento no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbCorregimiento.Focus()
        ElseIf Trim(txtDireccion.Text) = "" Then
            MsgBox("El campo Dirección no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtDireccion.Focus()
        ElseIf Trim(txtColegio.Text) = "" Then
            MsgBox("El campo COLEGIO SECUNDARIO no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtColegio.Focus()
        ElseIf Trim(cbBachiller.Text) = "" Then
            MsgBox("El campo BACHILLER no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            cbBachiller.Focus()
        ElseIf Trim(txtCorreoElectronico.Text) = "" Then
            MsgBox("El campo Correo no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtCorreoElectronico.Focus()
        ElseIf Trim(txtTelefono.Text) = "" Then
            MsgBox("El campo Teléfono no puede estar vacío.", vbExclamation, "Error de Validación")
            datosValidos = False
            txtTelefono.Focus()
        End If

        ' 2. PROCESAMIENTO DE LOS DATOS
        If datosValidos Then
            ' Declaración y asignación directa de variables locales
            Dim NUMERO As String = txtNumero.Text
            Dim NOMBRE As String = txtNombre.Text
            Dim NOMBRE2 As String = txtNombre2.Text
            Dim APELLIDO As String = txtApellido.Text
            Dim APELLIDO2 As String = txtApellido2.Text
            Dim CEDULA As String = txtCedula.Text
            Dim EDAD As String = cbEdad.Text
            Dim FECHANACIMIENTO As String = cbFechaDIA.Text & "/" & cbFechaMES.Text & "/" & cbFechaAÑO.Text
            Dim GENERO As String = cbGENERO.Text
            Dim CARRERA As String = cbTecnico.Text
            Dim PAIS As String = cbPAIS.Text
            Dim PROVINCIA As String = cbProvincia.Text
            Dim COMARCA As String = cbComarca.Text ' <-- CORREGIDO: Antes llamaba a cbPROVINCIA
            Dim DISTRITO As String = cbDistrito.Text
            Dim CORREGIMIENTO As String = cbCorregimiento.Text
            Dim DIRECCION As String = txtDireccion.Text
            Dim COLEGIO As String = txtColegio.Text
            Dim BACHILLER As String = cbBachiller.Text
            Dim CORREOELECTRONICO As String = txtCorreoElectronico.Text
            Dim TELEFONO As String = txtTelefono.Text

            ' Guardar en los arreglos del formulario MDI
            MDIParent1.numero(pos) = NUMERO
            MDIParent1.nombre(pos) = NOMBRE
            MDIParent1.nombre2(pos) = NOMBRE2
            MDIParent1.apellido(pos) = APELLIDO
            MDIParent1.apellido2(pos) = APELLIDO2
            MDIParent1.cedula(pos) = CEDULA
            MDIParent1.tecnico(pos) = CARRERA
            MDIParent1.edad(pos) = EDAD
            MDIParent1.fechadia(pos) = cbFechaDIA.Text
            MDIParent1.fechames(pos) = cbFechaMES.Text
            MDIParent1.fechanaño(pos) = cbFechaAÑO.Text
            MDIParent1.correoelectronico(pos) = CORREOELECTRONICO
            MDIParent1.telefono(pos) = TELEFONO
            MDIParent1.direccion(pos) = DIRECCION
            MDIParent1.colegio(pos) = COLEGIO
            MDIParent1.distrito(pos) = DISTRITO
            MDIParent1.corregimiento(pos) = CORREGIMIENTO
            MDIParent1.genero(pos) = GENERO
            MDIParent1.provincia(pos) = PROVINCIA
            MDIParent1.comarca(pos) = COMARCA
            MDIParent1.pais(pos) = PAIS
            MDIParent1.bachiller(pos) = BACHILLER

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

    Private Sub btnOTROS_Click(sender As Object, e As EventArgs) Handles btnOTROS.Click
        ' 1. Conexión y Consulta SQL limpia con exactamente 21 signos de interrogación (?)
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb")

        Dim sql As String = "INSERT INTO [INGRESO DE DATOS DE LOS ESTUDIANTES] " &
                "(NÚMERO, [PRIMER NOMBRE], [SEGUNDO NOMBRE], [APELLIDO PATERNO], [APELLIDO MATERNO], CÉDULA, CARRERA, EDAD, [FECHA DE NACIMIENTO], DIRECCIÓN, DISTRITO, CORREGIMIENTO, " &
                "[COLEGIO SECUNDARIO], [CORREO ELECTRÓNICO], TELÉFONO, GÉNERO, PROVINCIA, COMARCA, [PAÍS DE PROCEDENCIA], ESCUELA, BACHILLER) " &
                "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Dim comando As New OleDbCommand(sql, conexion)

        ' 2. Consolidación de la fecha
        Dim fechaNacimiento As String = $"{cbFechaDIA.Text}/{cbFechaMES.Text}/{cbFechaAÑO.Text}"

        ' 3. Parámetros agregados en el ORDEN EXACTO en que aparecen las columnas arriba
        comando.Parameters.AddWithValue("?", txtNumero.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtNombre.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtNombre2.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtApellido.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtApellido2.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtCedula.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbTecnico.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbEdad.Text.ToUpper())
        comando.Parameters.AddWithValue("?", fechaNacimiento.ToUpper())
        comando.Parameters.AddWithValue("?", txtDireccion.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbDistrito.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbCorregimiento.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtColegio.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtCorreoElectronico.Text.ToUpper())
        comando.Parameters.AddWithValue("?", txtTelefono.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbGENERO.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbProvincia.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbComarca.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbPAIS.Text.ToUpper())
        comando.Parameters.AddWithValue("?", cbBachiller.Text.ToUpper())

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

    Private Sub btnValidarCorreo_Click_1(sender As Object, e As EventArgs) Handles btnValidarCorreo.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class