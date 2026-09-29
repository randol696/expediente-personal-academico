Public Class LISTA_DE_PROFESOR_MATERIAL_DIDÁCTICO_EN_ENTORNOS_VIRTUALES_I
    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Hide()
        ASIGNATURAS_II_CUATRIMESTRE_EV.Show()
    End Sub

    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click
        ' 1. Agrega los datos a la tabla
        DataGridView1.Rows.Add(txtNo.Text, txtNOMBRE.Text, txtAPELLIDO.Text, txtCEDULAID.Text, txtTELEFONO.Text, txtCORREOELECTRONICO.Text)

        ' 2. Limpia los campos de texto y reinicia el formulario
        LimpiarFormulario()
    End Sub

    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        ' Limpia todos los campos llamando a la función centralizada
        LimpiarFormulario()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cambia el tamaño de la letra a 12 al cargar el formulario
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Arial", 12)
    End Sub

    Private Sub btnELIMINAR_Click(sender As Object, e As EventArgs) Handles btnELIMINAR.Click
        ' 1. Verifica si el usuario tiene una fila seleccionada
        If DataGridView1.CurrentRow IsNot Nothing AndAlso Not DataGridView1.CurrentRow.IsNewRow Then

            ' 2. Pregunta al usuario si realmente quiere borrar el registro
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas quitar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' 3. Si responde que SÍ, se elimina la fila
            If respuesta = DialogResult.Yes Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If
        Else
            ' Si no hay nada seleccionado, muestra un aviso
            MessageBox.Show("Por favor, selecciona una fila válida de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' SUB PROPIO: Para no repetir el mismo código de limpieza en AGREGAR y LIMPIAR
    Private Sub LimpiarFormulario()
        ' Cajas de texto
        txtNo.Clear()
        txtNOMBRE.Clear()
        txtAPELLIDO.Clear()
        txtCEDULAID.Clear()
        txtTELEFONO.Clear()
        txtCORREOELECTRONICO.Clear()

        ' Si tienes ComboBoxes (Cuadros de lista), reemplaza "cboEjemplo" con sus nombres reales:
        ' cboTuComboBox1.SelectedIndex = -1
        ' cboTuComboBox2.SelectedIndex = -1

        ' Coloca el cursor en el primer campo
        txtNo.Focus()
    End Sub

End Class