Public Class Form1
    Function introNum() As Integer
        Dim num(2, 3), i, j As Integer
        For i = 0 To 1
            For j = 0 To 2
                num(i, j) = InputBox("Introducir numeros", "Introduce 1 numero")
            Next
        Next

        For i = 0 To 1
            For j = 0 To 2
                Me.TextBox1.Text = Me.TextBox1.Text & num(i, j) & vbTab
                introNum = num(i, j)
            Next
        Next

    End Function

    Sub introNumSub()
        Dim num(2, 3), i, j As Integer
        For i = 0 To 1
            For j = 0 To 2
                num(i, j) = InputBox("Introducir numeros", "Introduce 1 numero")
            Next
        Next

        For i = 0 To 1
            For j = 0 To 2
                Me.TextBox2.Text = Me.TextBox2.Text & num(i, j) & vbTab
            Next
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        introNum()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        introNumSub()
    End Sub

End Class
