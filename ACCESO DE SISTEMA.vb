Public Class SISTEMA
    Private Sub btnADMINISTRADOR_Click(sender As Object, e As EventArgs) Handles btnADMINISTRADOR.Click
        Me.Hide()
        ACCESO_ADMINISTRADOR.Show()
    End Sub

    Private Sub btnACADEMICO_Click(sender As Object, e As EventArgs) Handles btnACADEMICO.Click
        Me.Hide()
        ACCESO_ACADEMICO.Show()
    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Close()
        SIGPAE.Show()
    End Sub
End Class