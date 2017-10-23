Public Class Form1
    Function introString(ByVal palabras() As String) As String

        Dim i, j As Integer

        For i = 0 To palabras.Length - 1
            palabras(i) = InputBox("Introduce palabras", "Introduce 1 palabra")
        Next

        For i = 0 To palabras.Length - 1
            Me.TextBox1.Text = Me.TextBox1.Text & palabras(i) & vbTab
        Next

    End Function


    Sub introStringSub(ByVal palabras() As String)
        Dim i As Integer

        For i = 0 To palabras.Length - 1
            Me.TextBox2.Text = Me.TextBox2.Text & palabras(i) & vbTab
        Next

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim palabras(6) As String

        introString(palabras)
        introStringSub(palabras)
    End Sub
End Class
