Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Celsius, fahrenheit As Double
        fahrenheit = (1.8 * Me.TextBox1.Text) + 32
        Celsius = (Me.TextBox2.Text - 32) * 0.556

        Me.TextBox3.Text = fahrenheit
        Me.TextBox4.Text = Celsius

    End Sub
End Class
