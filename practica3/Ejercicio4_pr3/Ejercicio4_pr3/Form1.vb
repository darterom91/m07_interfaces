Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim valor, res As Integer

        For i = 1 To 30
            If valor Mod 2 = 1 Then
                Me.TextBox1.Text = Me.TextBox1.Text & valor & vbCrLf
                res = res + valor
            End If
            valor = valor + 1
        Next
        Me.TextBox2.Text = res
    End Sub

End Class
