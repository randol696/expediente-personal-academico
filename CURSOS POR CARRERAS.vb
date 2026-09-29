Public Class CURSOS_POR_PERIODOS
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Respuesta As Integer
        ' Muestra la caja de diálogo con botones Sí, No y un icono de pregunta
        Respuesta = MsgBox("¿Deseas continuar con el proceso?", vbYesNo + vbQuestion, "Confirmación")

        ' Evalúa la respuesta del usuario
        If Respuesta = vbYes Then
            ' Código que se ejecuta si el usuario presiona "Sí"
            MsgBox("Has seleccionado Sí.")
        Else
            ' Código que se ejecuta si el usuario presiona "No"
            MsgBox("Has seleccionado No.")
        End If
        Me.Hide()
        ASIGNATURAS_I_CUATRIMESTREEV.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Close()
        CURSOS_Y_CUATRIMESTRES.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("NO ES LA CARRERA QUE CORRESPONDE")
    End Sub
End Class