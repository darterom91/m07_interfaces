Public Class Form1

    Function introNum(ByVal num() As Integer) As Integer
        Dim i As Integer
        For i = 0 To num.Length - 1
            num(i) = InputBox("Introducir numeros", "Introduce 1 numero")
        Next
        For i = 0 To num.Length - 1
            Me.TextBox2.Text = Me.TextBox2.Text & num(i) & vbTab
            introNum = num(i)
        Next
    End Function

    Sub introNumSub(ByVal num() As Integer)
        Dim i As Integer
        For i = 0 To num.Length - 1
            Me.TextBox3.Text = Me.TextBox3.Text & num(i) & vbTab
        Next
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num(6), i As Integer
        num(6) = introNum(num)
        introNumSub(num)
    End Sub

End Class
