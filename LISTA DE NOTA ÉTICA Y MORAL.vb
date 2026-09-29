Public Class LISTA_DE_NOTA_ÉTICA_Y_MORAL
    Public carnet As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Hide()
        NOTAS_EN_CURSO.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click
        ' 1. Agrega los datos a la tabla
        DataGridView1.Rows.Add(txtNo.Text, txtNOMBRE.Text, txtAPELLIDO.Text, txtCEDULAID.Text, txtTELEFONO.Text, txtCORREOELECTRONICO.Text, cbNOTA.Text, cbPUNTUACION.Text)

        ' 2. Limpia los campos de texto
        txtNo.Clear()
        txtNOMBRE.Clear()
        txtAPELLIDO.Clear()
        txtCEDULAID.Clear()
        txtTELEFONO.Clear()
        txtCORREOELECTRONICO.Clear()

        ' 3. Reinicia los cuadros de lista (ComboBox)
        cbNOTA.SelectedIndex = -1
        cbPUNTUACION.SelectedIndex = -1

        ' 4. Pone el cursor en el primer campo
        txtNUMERO.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        ' Borra el texto de las cajas de texto
        txtNo.Clear()
        txtNOMBRE.Clear()
        txtAPELLIDO.Clear()
        txtCEDULAID.Clear()
        txtTELEFONO.Clear()
        txtCORREOELECTRONICO.Clear()

        ' Deja los cuadros de lista vacíos (sin ninguna opción seleccionada)
        cbNOTA.SelectedIndex = -1
        cbPUNTUACION.SelectedIndex = -1

        ' Coloca el cursor en el primer campo para volver a escribir
        txtNUMERO.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Esto se ejecuta una sola vez al abrir el programa y cambia la letra a tamaño 12
        ' Es mejor cambiar el tipo de letra una sola vez al cargar el formulario
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Arial", 12)
    End Sub

    Private Sub btnELIMINAR_Click_1(sender As Object, e As EventArgs) Handles btnELIMINAR.Click
        ' 1. Verifica si el usuario tiene una fila seleccionada
        If DataGridView1.CurrentRow IsNot Nothing Then

            ' 2. Pregunta al usuario si realmente quiere borrar el registro
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("¿Estás seguro de que deseas quitar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' 3. Si responde que SÍ, se elimina la fila
            If respuesta = DialogResult.Yes Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If

        Else
            ' Si no hay nada seleccionado, muestra un aviso
            MessageBox.Show("Por favor, selecciona una fila de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class