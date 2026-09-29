Public Class Form44_ACADEMICO

    Private Sub btnNOTASTECSUP_Click(sender As Object, e As EventArgs) Handles btnNOTASTECSUP.Click
        Me.Hide()
        Form45_NOTAS_DE_TECNICO_SUPERIOR.Show()
    End Sub

    Private Sub btnPROMEDIOEST_Click(sender As Object, e As EventArgs) Handles btnPROMEDIOEST.Click
        Me.Hide()
        Form40.Show()
    End Sub


    Private Sub BbtnSALIRSECCIONACADEMICA_Click(sender As Object, e As EventArgs) Handles btn5SALIRSECCIONACADEMICA.Click
        Me.Hide()
        SISTEMA.Show()
    End Sub

    Private Sub btnCURSOSCUATRIMESTRES_Click(sender As Object, e As EventArgs) Handles btnCURSOSCUATRIMESTRES.Click
        Me.Hide()
        CURSOS_Y_CUATRIMESTRES.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NOTAS_POR_CARRERAS.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NOTAS_DE_ENVIO_POR_ASIGNATURAS_DE_CARRERA.Show()
        Me.Hide()
    End Sub
End Class