Module Module13
    Public curso As String
    Public periodo As String
    Public nombre As String
    Public apellido As String
    Public cedula As String
    Public nota1 As String
    Public nota2 As String
    Public nota3 As String
    Public nota4 As String
    Public lista As String
    Sub Agregar(formulario As Form8)
        ' Use 'Control' instead of 'Object' for better type safety
        For Each ctl As Control In formulario.Controls
            ' Check if the control is a TextBox
            If TypeOf ctl Is TextBox Then
                ' Correctly cast to TextBox and clear it
                CType(ctl, TextBox).Text = ""
                ' Alternative: DirectCast(ctl, TextBox).Clear()
            End If
        Next
    End Sub

    ' Define arrays with 20 slots (0 to 19)
    Public notas1(19) As String
    Public notas2(19) As String
    Public notas3(19) As String
    Public notas4(19) As String
End Module
