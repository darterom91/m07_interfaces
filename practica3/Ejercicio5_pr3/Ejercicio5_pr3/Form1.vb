Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim num As Integer

        For num = i To 100
            Me.TextBox1.Text = Me.TextBox1.Text & num & vbCrLf
        Next

        i = 0
        While (i < 100)
            i = i + 1
            num = i
            Me.TextBox2.Text = Me.TextBox2.Text & num & vbCrLf
        End While

        i = 0
        Do
            i = i + 1
            num = i
            Me.TextBox3.Text = Me.TextBox3.Text & num & vbCrLf
        Loop While (i <> 100)

    End Sub
End Class
