Public Class ASIGNATURA_4_SI
    Private Sub ASIGNATURA_4_SI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Close()
        ASIGNATURAS_I_CUATRIMESTRE_SI.Show()
    End Sub
End Class