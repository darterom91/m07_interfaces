Public Class Form1

    Function ConstraintsCA(ByVal s As String) As Boolean
        Return s.Contains("ca")
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim palabras(2, 4) As String
        Dim s As Boolean
        Dim i, j As Integer

        For i = 0 To 1
            For j = 0 To 3
                palabras(i, j) = InputBox("Introduce todas las palabras", "Introduce una palabra")
            Next
        Next

        Me.TextBox1.Text = Me.TextBox1.Text & vbCrLf
        For i = 0 To 1
            For j = 0 To 4
                Me.TextBox1.Text = Me.TextBox1.Text & palabras(i, j) & vbTab
            Next
        Next

    End Sub
End Class
