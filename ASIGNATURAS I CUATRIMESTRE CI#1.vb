Public Class ASIGNATURAS_I_CUATRIMESTRECI_1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        CURSOS_POR_PERIODOS.Show()
    End Sub

    Private Sub btnASIGNATURA1_Click(sender As Object, e As EventArgs) Handles btnASIGNATURA1.Click
        Me.Hide()
        LISTA_DE_PROFESOR_ASIGNATURA_1_CI__1.Show()
    End Sub

    Private Sub btnASIGNATURA2_Click(sender As Object, e As EventArgs) Handles btnASIGNATURA2.Click
        Me.Hide()
        LISTA_DE_PROFESOR_ASIGNATURA_2_CI__1.Show()
    End Sub

    Private Sub btnASIGNATURA3_Click(sender As Object, e As EventArgs) Handles btnASIGNATURA3.Click
        Me.Hide()
        LISTA_DE_PROFESOR_ASIGNATURA_3_CI__1.Show()
    End Sub

    Private Sub btnASIGNATURA4_Click(sender As Object, e As EventArgs) Handles btnASIGNATURA4.Click
        Me.Hide()
        LISTA_DE_PROFESOR_ASIGNATURA_4_CI__1.Show()
    End Sub

End Class