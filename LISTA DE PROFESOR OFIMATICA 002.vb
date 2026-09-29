Public Class LISTA_DE_PROFESOR_OFIMATICA_002
    Private Sub btnNOTAOFIMATICA002_Click(sender As Object, e As EventArgs) Handles btnSALIRLISTAOFIMATICA002.Click
        Me.Close()
        ASIGNATURAS_I_CUATRIMESTREEV.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LISTADO_DE_NOTAS_DE_OFIMATICA_002.Show()
    End Sub
End Class