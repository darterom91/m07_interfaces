Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.x1.Text = Me.A.Left
        Me.y1.Text = Me.A.Top
        Me.x2.Text = Me.B.Left
        Me.y2.Text = Me.B.Top
    End Sub

    Private Sub top_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles A.KeyDown, B.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Me.A.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Me.A.Size.Height
        Dim limite11 As Integer = Panel1.Size.Width - Me.B.Size.Width
        Dim limite22 As Integer = Panel1.Size.Height - Me.B.Size.Height

        If e.KeyCode = Keys.W Then
            If Me.A.Top >= 0 And Not Me.A.Bounds.IntersectsWith(Me.B.Bounds) Then
                Me.A.Location = New Point(Me.A.Location.X, Me.A.Location.Y - 1)
                Me.y1.Text = Me.A.Top
            Else
                Me.A.Location = New Point(Me.A.Location.X, Me.A.Location.Y + 1)
                Me.y1.Text = Me.A.Top
            End If
        End If

        If e.KeyCode = Keys.U Then
            If Me.B.Top >= 0 And Not Me.B.Bounds.IntersectsWith(Me.A.Bounds) Then
                Me.B.Location = New Point(Me.B.Location.X, Me.B.Location.Y - 1)
                Me.y2.Text = Me.B.Top
            Else
                Me.B.Location = New Point(Me.B.Location.X, Me.B.Location.Y + 1)
                Me.y2.Text = Me.B.Top
            End If
        End If

    End Sub

    Private Sub right_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles A.KeyDown, B.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Me.A.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Me.A.Size.Height
        Dim limite11 As Integer = Panel1.Size.Width - Me.B.Size.Width
        Dim limite22 As Integer = Panel1.Size.Height - Me.B.Size.Height

        If e.KeyCode = Keys.A Then
            If Me.A.Left >= 0 And Not Me.A.Bounds.IntersectsWith(Me.B.Bounds) Then
                Me.A.Location = New Point(Me.A.Location.X - 1, Me.A.Location.Y)
                Me.x1.Text = Me.A.Left
            Else
                Me.A.Location = New Point(Me.A.Location.X + 1, Me.A.Location.Y)
                Me.x1.Text = Me.A.Left
            End If
        End If

        If e.KeyCode = Keys.H Then
            If Me.B.Left >= 0 And Not Me.B.Bounds.IntersectsWith(Me.A.Bounds) Then
                Me.B.Location = New Point(Me.B.Location.X - 1, Me.B.Location.Y)
                Me.x2.Text = Me.B.Left
            Else
                Me.B.Location = New Point(Me.B.Location.X + 1, Me.B.Location.Y)
                Me.x2.Text = Me.B.Left
            End If
        End If

    End Sub
    Private Sub down_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles A.KeyDown, B.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Me.A.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Me.A.Size.Height
        Dim limite11 As Integer = Panel1.Size.Width - Me.B.Size.Width
        Dim limite22 As Integer = Panel1.Size.Height - Me.B.Size.Height

        If e.KeyCode = Keys.S Then
            If Me.A.Top < limite2 - 1 And Not Me.A.Bounds.IntersectsWith(Me.B.Bounds) Then
                Me.A.Location = New Point(Me.A.Location.X, Me.A.Location.Y + 1)
                Me.y1.Text = Me.A.Top
            Else
                Me.A.Location = New Point(Me.A.Location.X, Me.A.Location.Y - 1)
                Me.y1.Text = Me.A.Top
            End If
        End If


        If e.KeyCode = Keys.J Then
            If Me.B.Top < limite22 - 1 And Not Me.B.Bounds.IntersectsWith(Me.A.Bounds) Then
                Me.B.Location = New Point(Me.B.Location.X, Me.B.Location.Y + 1)
                Me.y2.Text = Me.B.Top
            Else
                Me.B.Location = New Point(Me.B.Location.X, Me.B.Location.Y - 1)
                Me.y2.Text = Me.B.Top
            End If
        End If

    End Sub
    Private Sub left_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles A.KeyDown, B.KeyDown
        Dim limite1 As Integer = Panel1.Size.Width - Me.A.Size.Width
        Dim limite2 As Integer = Panel1.Size.Height - Me.A.Size.Height
        Dim limite11 As Integer = Panel1.Size.Width - Me.B.Size.Width
        Dim limite22 As Integer = Panel1.Size.Height - Me.B.Size.Height

        If e.KeyCode = Keys.D Then
            If Me.A.Left < limite1 - 1 And Not Me.A.Bounds.IntersectsWith(Me.B.Bounds) Then
                Me.A.Location = New Point(Me.A.Location.X + 1, Me.A.Location.Y)
                Me.x1.Text = Me.A.Left
            Else
                Me.A.Location = New Point(Me.A.Location.X - 1, Me.A.Location.Y)
                Me.x1.Text = Me.A.Left
            End If
        End If

        If e.KeyCode = Keys.K Then
            If Me.B.Left < limite11 - 1 And Not Me.B.Bounds.IntersectsWith(Me.A.Bounds) Then
                Me.B.Location = New Point(Me.B.Location.X + 1, Me.B.Location.Y)
                Me.x2.Text = Me.B.Left
            Else
                Me.B.Location = New Point(Me.B.Location.X - 1, Me.B.Location.Y)
                Me.x2.Text = Me.B.Left
            End If
        End If

    End Sub


    Private Sub cerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cerrar.Click
        Close()
    End Sub
End Class

