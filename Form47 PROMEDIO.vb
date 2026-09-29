Public Class Form47
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c, d As Integer
        Dim estudiante As Integer
        Dim tecnico As String
        Dim promedio As Single
        Dim nota As String
        Dim Aprobado As String
        Dim Reprobado As String
        a = txtA1.Text
        b = txtA2.Text
        c = txtA3.Text
        d = txtA4.Text
        txtPromedio.Text = (a + b + c + d) / 4
        txtPuntuacion.Text = (a + b + c + d)

        nota = Val(txtA1.Text)
        nota = Val(txtA2.Text)
        nota = Val(txtA3.Text)
        nota = Val(txtA4.Text)
        promedio = (a + b + c + d) / 4
        txtNOTA.Text = promedio

        If (promedio >= 91 And 100) Then
            txtNOTA.Text = "A"
            MsgBox("APROBADO")
        Else
            If (promedio >= 81 And 90) Then
                txtNOTA.Text = "B"
                MsgBox("APROBADO")
            Else
                If (promedio >= 71 And 80) Then
                    txtNOTA.Text = "C"
                    MsgBox("APROBADO")
                Else
                    If (promedio >= 61 And 70) Then
                        txtNOTA.Text = "D"
                        MsgBox("REPROBADO")
                    Else
                        If (promedio >= 0 And 60) Then
                            txtNOTA.Text = "F"
                            MsgBox("REPROBADO")
                        Else
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEstudiante.Text = ""
        cbTecnico.SelectedIndex = -1
        txtA1.Text = ""
        txtA2.Text = ""
        txtA3.Text = ""
        txtA4.Text = ""
        txtPromedio.Text = ""
        txtPuntuacion.Text = ""
        txtNOTA.Text = ""
        txtA1.Focus()
        txtA2.Focus()
        txtA3.Focus()
        txtA4.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("Desea Salir de la aplicacion", "Atecion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class