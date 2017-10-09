Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'variables
        Dim hora As Integer = Me.TextBox1.Text
        Dim minuts As Integer = Me.TextBox2.Text
        Dim segons As Integer = Me.TextBox3.Text

        'operaciones
        If segons >= 59 Then
            segons = 0
            minuts = minuts + 1
        End If

        If minuts > 59 Then
            minuts = 0
            hora = hora + 1
        End If

        If hora > 23 Then
            hora = 0
        End If

        'mostrar
        Me.TextBox4.Text = hora
        Me.TextBox5.Text = minuts
        Me.TextBox6.Text = segons

        Me.TextBox1.Text = Me.TextBox1.Text
        Me.TextBox2.Text = Me.TextBox2.Text
        Me.TextBox3.Text = Me.TextBox3.Text


    End Sub
End Class
