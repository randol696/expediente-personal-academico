Public Class CURSO_POR_PERIODOS_II
    Private Sub btn4SALIRLISTADOCUMENTOS_Click(sender As Object, e As EventArgs) Handles btn4SALIRLISTADOCUMENTOS.Click
        CURSOS_Y_CUATRIMESTRES.Show()
        Me.Hide()
    End Sub

    Private Sub btnENTORNOSVIRTUALES_Click(sender As Object, e As EventArgs) Handles btnENTORNOSVIRTUALES.Click
        ASIGNATURAS_II_CUATRIMESTRE_EV.Show()
        Me.Hide()
    End Sub
End Class