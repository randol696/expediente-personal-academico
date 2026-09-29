Public Class NOTAS_EN_CURSOS
    Private Sub btnNOTACOMUNICACIÓNORALYESCRITA001_Click(sender As Object, e As EventArgs) Handles btnNOTACOMUNICACIÓNORALYESCRITA001.Click
        Me.Hide()
        LISTADO_DE_NOTAS_DE_COMUNICACION_ORAL_Y_ESCRITA_001.Show()
    End Sub

    Private Sub btnNOTAOFIMÁTICA002_Click(sender As Object, e As EventArgs) Handles btnNOTAOFIMÁTICA002.Click
        Me.Hide()
        LISTADO_DE_NOTAS_DE_OFIMATICA_002.Show()
    End Sub

    Private Sub btnNOTAINTRODUCCIÓNALOSAMBIENTESVIRTUALES003_Click(sender As Object, e As EventArgs) Handles btnNOTAINTRODUCCIÓNALOSAMBIENTESVIRTUALES003.Click
        Me.Hide()
        LISTADO_DE_NOTAS_DE_INTRODUCCION_A_LOS_AMBIENTES_VIRTUALES_003.Show()
    End Sub

    Private Sub btnNOTAHISTORIADEPANAMÁ019_Click(sender As Object, e As EventArgs) Handles btnNOTAHISTORIADEPANAMÁ019.Click
        Me.Hide()
        LISTADO_DE_NOTAS_DE_HISTORIA_DE_PANAMA_019.Show()
    End Sub

    Private Sub btnSALIRNOTAS_Click(sender As Object, e As EventArgs) Handles btnSALIRNOTAS.Click
        Me.Close()
        Form44_ACADEMICO.Show()
    End Sub
End Class