Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, bmi As Double

        weight = Val(TextBox2.Text)
        height = Val(TextBox1.Text)

        bmi = weight / (height) ^ 2

        TextBox3.Text = bmi

        If bmi < 18 Then
            TextBox4.Text = "You are under weight"
        ElseIf 18 <= bmi <= 26 Then
            TextBox4.Text = "You are normal"
        Else
            TextBox4.Text = "You are over weight"
        End If
    End Sub
End Class
