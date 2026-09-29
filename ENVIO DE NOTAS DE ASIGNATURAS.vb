Public Class ENVIO_DE_NOTAS_DE_ASIGNATURAS
    Private Sub btnENVIOCOMUNICACIÓNORALYESCRITA001_Click(sender As Object, e As EventArgs) Handles btnENVIOCOMUNICACIÓNORALYESCRITA001.Click
        Me.Hide()
        COMUNICACIÓN_ORAL_Y_ESCRITA_001.Show()
    End Sub

    Private Sub btnENVIOOFIMÁTICA002_Click(sender As Object, e As EventArgs) Handles btnENVIOOFIMÁTICA002.Click
        Me.Hide()
        OFIMÁTICA_002.Show()
    End Sub

    Private Sub btnENVIOINTRODUCCIÓNALOSAMBIENTESVIRTUALES003_Click(sender As Object, e As EventArgs) Handles btnENVIOINTRODUCCIÓNALOSAMBIENTESVIRTUALES003.Click
        Me.Hide()
        INTRODUCCIÓN_A_LOS_AMBIENTES_VIRTUALES_003.Show()
    End Sub

    Private Sub btnENVIOHISTORIADEPANAMÁ019_Click(sender As Object, e As EventArgs) Handles btnENVIOHISTORIADEPANAMÁ019.Click
        Me.Hide()
        HISTORIA_DE_PANAMÁ_019.Show()
    End Sub

    Private Sub btnSALIRENVIO_Click(sender As Object, e As EventArgs) Handles btnSALIRENVIO.Click
        Me.Close()
        Form44_ACADEMICO.Show()
    End Sub
End Class