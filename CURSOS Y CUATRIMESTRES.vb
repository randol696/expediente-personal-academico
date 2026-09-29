Public Class CURSOS_Y_CUATRIMESTRES
    Private Sub btnICUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnICUATRIMESTRE.Click
        Me.Hide()
        CURSO_POR_PERIODOS.Show()
    End Sub

    Private Sub btnIICUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnIICUATRIMESTRE.Click
        Me.Hide()
        CURSO_POR_PERIODOS_II.Show()
    End Sub

    Private Sub btnIIICUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnIIICUATRIMESTRE.Click
        Me.Hide()
        CURSO_POR_PERIODOS_III.Show()
    End Sub

    Private Sub btnIVCUATRIMESTRE_Click(sender As Object, e As EventArgs) Handles btnIVCUATRIMESTRE.Click
        Me.Hide()
        CURSO_POR_PERIODOS_IV.Show()
    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Me.Hide()
        Form44_ACADEMICO.Show()
    End Sub

  
End Class