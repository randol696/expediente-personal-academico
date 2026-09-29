Public Class LISTA_DE_PROFESOR_DE_INTRODUCCION_A_LOS_AMBIENTES_VIRTUALES_003
    Private Sub btnNOTAINTRODUCCIONALOSAMBIENTESVIRTUALES003_Click(sender As Object, e As EventArgs) Handles btnLISTAINTRODUCCIONALOSAMBIENTESVIRTUALES003.Click
        Me.Close()
        ASIGNATURAS_I_CUATRIMESTREEV.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        LISTADO_DE_NOTAS_DE_INTRODUCCION_A_LOS_AMBIENTES_VIRTUALES_003.Show()
    End Sub
End Class