Public Class Form1
    Dim selection As Boolean
    Dim mv_boton As Boolean

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Button1.Text = "Button1"
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Text = "Move"
        Button1.BackColor = Color.Yellow
        Button1.ForeColor = Color.Blue
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.Font = New Font("Microsoft Sans Serif", 20)
        Button1.Size = New Size(100, 100)

        Button1.Text = "Down"
        Button1.BackColor = Color.Magenta
        Button1.ForeColor = Color.Aqua

        If selection = False Then
            selection = True
            mv_boton = True
        Else
            selection = False
            mv_boton = False
        End If
    End Sub

    Private Sub panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If mv_boton = True Then
            Button1.Top = Fix(e.Y)
            TextBox1.Text = Button1.Top

            Button1.Left = Fix(e.X)
            TextBox2.Text = Button1.Left
        End If
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        Button1.Font = New Font("Microsoft Sans Serif", 10)
        Button1.Text = "Up"
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Button1.Size = New Size(75, 23)
    End Sub
End Class
