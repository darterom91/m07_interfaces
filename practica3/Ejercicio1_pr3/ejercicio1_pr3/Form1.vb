Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim num, num2, num3 As Integer

        num = Me.TextBox1.Text
        num2 = Me.TextBox2.Text
        num3 = Me.TextBox3.Text

        If num > num2 And num > num3 Then
            Me.TextBox4.Text = num
        ElseIf num2 > num And num2 > num3 Then
            Me.TextBox4.Text = num2
        ElseIf num3 > num And num3 > num2 Then
            Me.TextBox4.Text = num3
        End If

        If num > num2 And num < num3 Or num < num2 And num > num3 Then
            Me.TextBox5.Text = num
        ElseIf num2 > num And num2 < num3 Or num2 < num And num2 > num3 Then
            Me.TextBox5.Text = num2
        ElseIf num3 > num And num3 < num2 Or num3 < num And num3 > num2 Then
            Me.TextBox5.Text = num3
        End If

        If num < num2 And num < num3 Then
            Me.TextBox6.Text = num
        ElseIf num2 < num And num2 < num3 Then
            Me.TextBox6.Text = num2
        ElseIf num3 < num And num3 < num2 Then
            Me.TextBox6.Text = num3
        End If

    End Sub
End Class
