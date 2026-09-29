Public Class LISTA_DEL_PROFESOR_COMUNICACION_ORAL_Y_ESCRITA_001
    Private Sub btnNOTACOMUNICACIONORALYESCRITA001_Click(sender As Object, e As EventArgs) Handles btnSALIRLISTACOMUNICACIONORALYESCRITA001.Click
        Me.Close()
        ASIGNATURAS_I_CUATRIMESTREEV.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LISTADO_DE_NOTAS_DE_COMUNICACION_ORAL_Y_ESCRITA_001.Show()
    End Sub
End Class