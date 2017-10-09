Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Valores
        Dim num As Integer = 5
        Dim num2 As Integer = 8

        'operaciones
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double
        Dim divisionInt As Integer
        Dim residu As Integer
        Dim exponent As Integer

        suma = num + num2
        resta = num - num2
        multiplicacion = num * num2
        division = num / num2
        divisionInt = num / num2
        residu = num Mod num2
        exponent = num ^ num2


        'TextBox
        Me.TextBox1.Text = suma
        Me.TextBox2.Text = resta
        Me.TextBox3.Text = multiplicacion
        Me.TextBox4.Text = division
        Me.TextBox5.Text = divisionInt
        Me.TextBox6.Text = residu
        Me.TextBox7.Text = exponent



    End Sub

End Class
