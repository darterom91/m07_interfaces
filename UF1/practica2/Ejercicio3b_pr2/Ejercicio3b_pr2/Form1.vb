Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim numero As Integer = Me.TextBox1.Text
        Dim Respuesta As String

        Respuesta = If(numero > 0, "Positivo", "Negativo")
        Me.TextBox2.Text = Respuesta
    End Sub
End Class
