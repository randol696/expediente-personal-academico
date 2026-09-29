Imports System.Drawing.Text
Imports System.Reflection

Module Module1
    Sub limpiar(formulario As Form1_INGRESO_ALUMNO)
        Dim controles As Object
        For Each controles In formulario.Controls
            If TypeOf controles Is TextBox Then
                CType(controles, TextBox).Text = ""
            ElseIf TypeOf controles Is ComboBox Then
                CType(controles, ComboBox).Text = ""
                CType(controles, ComboBox).SelectedIndex = -1
            ElseIf TypeOf controles Is NumericUpDown Then
                CType(controles, NumericUpDown).Value = CType(controles, NumericUpDown).Minimum
            ElseIf TypeOf controles Is PictureBox Then
                CType(controles, PictureBox).Image = Nothing
            ElseIf TypeOf controles Is Form1_INGRESO_ALUMNO Then
                CType(controles, GroupBox).Select()
                CType(controles, RadioButton).Checked = False
            End If
        Next
    End Sub

End Module
