Public Class Form41_PERSONAL
    Private Sub btnINGREO_Click(sender As Object, e As EventArgs) Handles btnINGRESO.Click
        Me.Hide()
        Form1_INGRESO_ALUMNO.Show()
    End Sub

    Private Sub btnCONSULTA_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDOCUMENTOS_Click(sender As Object, e As EventArgs) Handles btnDOCUMENTOS.Click
        Me.Hide()
        Form42_DOCUMENTOS_DE_EXPDEDIENTES_PERSONALES.Show()
    End Sub

    Private Sub btnLISTATECNICOSUP_Click(sender As Object, e As EventArgs) Handles btnLISTATECNICOSUP.Click
        Me.Hide()
        Form43_LISTA_DE_TECNICO_SUPERIOR.Show()
    End Sub

    Private Sub btnSALIRPERSONAL_Click(sender As Object, e As EventArgs) Handles btn2SALIRPERSONAL.Click
        Me.Hide()
        SISTEMA.Show()
    End Sub

    Private Sub btnINGRESOPROFESOR_Click(sender As Object, e As EventArgs) Handles btnINGRESOPROFESOR.Click
        Me.Hide()
        FORMULARIO_PROFESOR.Show()
    End Sub

    Private Sub btnCONSULTAPROFESOR_Click(sender As Object, e As EventArgs) Handles btnCONSULTAPROFESOR.Click
        Me.Hide()
        FORMULARIO_CONSULTA_PROFESORES.Show()
    End Sub

    Private Sub btnCONSULTA_Click_1(sender As Object, e As EventArgs) Handles btnCONSULTA.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class