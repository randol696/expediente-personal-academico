Public Class ASIGNATURAS_I_CUATRIMESTREEV
    Private Sub COMUNICACIÓNORALYESCRITA001_Click(sender As Object, e As EventArgs) Handles COMUNICACIÓNORALYESCRITA001.Click
        Me.Hide()
        LISTA_DEL_PROFESOR_COMUNICACION_ORAL_Y_ESCRITA_001.Show()
    End Sub

    Private Sub OFIMÁTICA002_Click(sender As Object, e As EventArgs) Handles OFIMÁTICA002.Click
        Me.Hide()
        LISTA_DE_PROFESOR_OFIMATICA_002.Show()
    End Sub

    Private Sub btnINTRODUCCIÓNALOSAMBIENTESVIRTUALES003_Click(sender As Object, e As EventArgs) Handles btnINTRODUCCIÓNALOSAMBIENTESVIRTUALES003.Click
        Me.Hide()
        LISTA_DE_PROFESOR_DE_INTRODUCCION_A_LOS_AMBIENTES_VIRTUALES_003.Show()
    End Sub

    Private Sub btnHISTORIADEPANAMÁ019_Click(sender As Object, e As EventArgs) Handles btnHISTORIADEPANAMÁ019.Click
        Me.Hide()
        LISTA_DE_PROFESOR_DE_HISTORIA_DE_PANAMA_019.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        CURSOS_POR_PERIODOS.Show()
    End Sub

End Class