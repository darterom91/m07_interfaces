Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, valor, suma As Integer
        For i = 1 To 10
            valor = InputBox("digite numero", "captura numero")
            Me.TextBox1.Text = Me.TextBox1.Text & valor & vbCrLf
            suma = suma + valor
        Next
        Me.TextBox1.Text = Me.TextBox1.Text & valor & vbCrLf & "LA sumatoria es: " & suma
    End Sub
End Class
