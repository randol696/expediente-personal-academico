Public Class SIGPAE

    Private Sub btnINGRESAR_Click(sender As Object, e As EventArgs) Handles btnINGRESAR.Click
        If MessageBox.Show("DESEA ENTRAR AL SISTEMA DE LA APLICACIÓN", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            SISTEMA.Show()
        End If
    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        If MessageBox.Show("Desea Salir de la Aplicación", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class