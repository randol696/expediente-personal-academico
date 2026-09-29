Module Module4
    Public curso As String
    Public nombre As String
    Public apellido As String
    Public periodo As String
    Public cedula As String
    Public nota1 As String
    Public nota2 As String
    Public nota3 As String
    Public nota4 As String
    Public nota5 As String
    Public nota6 As String
    Public nota7 As String
    Public nota8 As String
    Public nota9 As String
    Public nota10 As String
    Public nota11 As String
    Public nota12 As String
    Public nota13 As String
    Public nota14 As String
    Public nota15 As String
    Public nota16 As String
    Public p1 As String
    Public p2 As String
    Public p3 As String
    Public p4 As String
    Public p5 As String
    Public p6 As String
    Public p7 As String
    Public p8 As String
    Public p9 As String
    Public p10 As String
    Public p11 As String
    Public p12 As String
    Public p13 As String
    Public p14 As String
    Public p15 As String
    Public p16 As String
    Public lista As String
    Public prof1(50) As String
    Public prof2(50) As String
    Public prof3(50) As String
    Public prof4(50) As String
    Public prof5(50) As String
    Public prof6(50) As String
    Public prof7(50) As String
    Public prof8(50) As String
    Public porf9(50) As String
    Public prof10(50) As String
    Public prof11(50) As String
    Public prof12(50) As String
    Public prof13(50) As String
    Public prof14(50) As String
    Public prof15(50) As String
    Public prof16(50) As String
    Public ASIG1(50) As String
    Public ASIG2(50) As String
    Public ASIG3(50) As String
    Public ASIG4(50) As String
    Public ASIG5(50) As String
    Public ASIG6(50) As String
    Public ASIG7(50) As String
    Public ASIG8(50) As String
    Public ASIG9(50) As String
    Public ASIG10(50) As String
    Public ASIG11(50) As String
    Public ASIG12(50) As String
    Public ASIG13(50) As String
    Public ASIG14(50) As String
    Public ASIG15(50) As String
    Public ASIG16(50) As String
    Public puntuacion As String
    Public carrera As String
    Public profesor As String
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
End Module

