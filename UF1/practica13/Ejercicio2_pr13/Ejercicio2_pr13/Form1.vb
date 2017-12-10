Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = Me.Button1.Left
        Me.TextBox2.Text = Me.Button1.Top

    End Sub
  
    Private Sub top_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Me.Button1.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Me.Button1.Size.Height
        Me.Label3.Text = limite1
        Me.Label4.Text = limite2

        If e.KeyCode = Keys.W Then
            If Me.Button1.Top >= 0 Then
                Me.Button1.Location = New Point(Me.Button1.Location.X, Me.Button1.Location.Y - 1)
                Me.Button1.Text = "TOP"
                Me.Button1.BackColor = Color.Red
                Me.Button1.ForeColor = Color.White
                Me.TextBox2.Text = Me.Button1.Top
            Else
                Me.Label4.Text = "Limit"
                Me.Button1.Location = New Point(Me.Button1.Location.X, Me.Button1.Location.Y + 1)
                Me.Button1.Text = "TOP"
                Me.Button1.BackColor = Color.Red
                Me.Button1.ForeColor = Color.White
                Me.TextBox2.Text = Me.Button1.Top
            End If
        End If

    End Sub

    Private Sub right_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Panel1.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Panel1.Size.Height

        If e.KeyCode = Keys.A Then
            If Me.Button1.Left >= 0 Then
                Me.Button1.Location = New Point(Me.Button1.Location.X - 1, Me.Button1.Location.Y)
                Me.Button1.Text = "RIGHT"
                Me.Button1.BackColor = Color.Blue
                Me.Button1.ForeColor = Color.White
                Me.TextBox1.Text = Me.Button1.Left
            Else
                Me.Label3.Text = "Limit"
                Me.Button1.Location = New Point(Me.Button1.Location.X + 1, Me.Button1.Location.Y)
                Me.Button1.Text = "RIGHT"
                Me.Button1.BackColor = Color.Blue
                Me.Button1.ForeColor = Color.White
                Me.TextBox1.Text = Me.Button1.Left
            End If
        End If

    End Sub
    Private Sub down_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Me.Button1.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Me.Button1.Size.Height

        If e.KeyCode = Keys.S Then
            If Me.Button1.Top < limite2 - 1 Then
                Me.Button1.Location = New Point(Me.Button1.Location.X, Me.Button1.Location.Y + 1)
                Me.Button1.Text = "DOWN"
                Me.Button1.BackColor = Color.Yellow
                Me.Button1.ForeColor = Color.Black
                Me.TextBox2.Text = Me.Button1.Top
            Else
                Me.Label4.Text = "Limit"
                Me.Button1.Location = New Point(Me.Button1.Location.X, Me.Button1.Location.Y - 1)
                Me.Button1.Text = "DOWN"
                Me.Button1.BackColor = Color.Yellow
                Me.Button1.ForeColor = Color.Black
                Me.TextBox2.Text = Me.Button1.Top
            End If
        End If

    End Sub
    Private Sub left_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Me.Button1.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Me.Button1.Size.Height


        If e.KeyCode = Keys.D Then
            If Me.Button1.Left < limite1 - 1 Then
                Me.Button1.Location = New Point(Me.Button1.Location.X + 1, Me.Button1.Location.Y)
                Me.Button1.Text = "LEFT"
                Me.Button1.BackColor = Color.DarkGreen
                Me.Button1.ForeColor = Color.White
                Me.TextBox1.Text = Me.Button1.Left
            Else
                Me.Label3.Text = "Limit"
                Me.Button1.Location = New Point(Me.Button1.Location.X - 1, Me.Button1.Location.Y)
                Me.Button1.Text = "LEFT"
                Me.Button1.BackColor = Color.DarkGreen
                Me.Button1.ForeColor = Color.White
                Me.TextBox1.Text = Me.Button1.Left
            End If
        End If

    End Sub

    Private Sub cerrar_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cerrar.MouseClick
        Close()
    End Sub
End Class
