Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opcion As Integer = Me.TextBox1.Text
        Select (opcion)
            Case 1
                Me.TextBox2.Text = "Enero"
            Case 2
                Me.TextBox2.Text = "Febrero"
            Case 3
                Me.TextBox2.Text = "Marzo"
            Case 4
                Me.TextBox2.Text = "Abril"
            Case 5
                Me.TextBox2.Text = "Mayo"
            Case 6
                Me.TextBox2.Text = "Junio"
            Case 7
                Me.TextBox2.Text = "Julio"
            Case 8
                Me.TextBox2.Text = "Agosto"
            Case 9
                Me.TextBox2.Text = "Septiembre"
            Case 10
                Me.TextBox2.Text = "Octubre"
            Case 11
                Me.TextBox2.Text = "Noviembre"
            Case 12
                Me.TextBox2.Text = "Diciembre"
            Case Else
                Me.TextBox2.Text = "No existe ese mes"
        End Select

    End Sub
End Class
