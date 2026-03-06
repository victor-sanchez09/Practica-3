Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim mat1, mat2, mat3, mat4, mat5, mat6, mat7, mat8, mat9, mat10, mat11, mat12, mat13 As Double
        Dim promedio As Double

        mat1 = Val(materia1.Text)
        mat2 = Val(materia2.Text)
        mat3 = Val(materia3.Text)
        mat4 = Val(materia4.Text)
        mat5 = Val(materia5.Text)
        mat6 = Val(materia6.Text)
        mat7 = Val(materia7.Text)
        mat8 = Val(materia8.Text)
        mat9 = Val(materia9.Text)
        mat10 = Val(materia10.Text)
        mat11 = Val(materia11.Text)
        mat12 = Val(materia12.Text)
        mat13 = Val(materia13.Text)

        promedio = (mat1 + mat2 + mat3 + mat4 + mat5 + mat6 + mat7 + mat8 + mat9 + mat10 + mat11 + mat12 + mat13) / 13

        Dim redondeo As Double = Math.Round(promedio, 1)

        resultado.Text = redondeo.ToString()

        If redondeo = 10 Then
            mensaje.BackColor = Color.Lime
            mensaje.Text = "¡Excelente!"
        ElseIf redondeo >= 6 Then
            mensaje.BackColor = Color.Green
            mensaje.Text = "¡Aprobado!"
        Else
            mensaje.BackColor = Color.Red
            mensaje.Text = "Reprobado :("
        End If
    End Sub
End Class
