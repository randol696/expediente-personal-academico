Public Class ENVIO_DE_NOTAS_DE_ASIGNATURAS_EV_1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NOTAS_DE_ENVIO_ENTORNOS_VIRTUALES.Show()
        Me.Close()
    End Sub

    Private Sub COMUNICACIÓNORALYESCRITA001_Click(sender As Object, e As EventArgs) Handles COMUNICACIÓNORALYESCRITA001.Click
        COMUNICACIÓN_ORAL_Y_ESCRITA_001.Show()
        Me.Hide()
    End Sub

    Private Sub OFIMÁTICA002_Click(sender As Object, e As EventArgs) Handles OFIMÁTICA002.Click
        OFIMÁTICA_002.Show()
        Me.Hide()
    End Sub

    Private Sub btnINTRODUCCIÓNALOSAMBIENTESVIRTUALES003_Click(sender As Object, e As EventArgs) Handles btnINTRODUCCIÓNALOSAMBIENTESVIRTUALES003.Click
        INTRODUCCIÓN_A_LOS_AMBIENTES_VIRTUALES_003.Show()
        Me.Hide()
    End Sub

    Private Sub btnHISTORIADEPANAMÁ019_Click(sender As Object, e As EventArgs) Handles btnHISTORIADEPANAMÁ019.Click
        HISTORIA_DE_PANAMÁ_019.Show()
        Me.Hide()
    End Sub
End Class