Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim palabras(2.4) As String
        Dim i, j As Integer

        For i = 0 To 2
            For j = 1 To 4
                palabras(j) = InputBox("Introduce todas las palabras", "Introduce una palabra")
            Next
        Next
        For i = 0 To 2
            For j = 1 To 4
                Me.TextBox1.Text = Me.TextBox2(j)
            Next
        Next
    End Sub
End Class
