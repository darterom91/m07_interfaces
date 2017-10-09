Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim cuentavocal As Integer
        Dim cadena As String = Me.TextBox1.Text

        For Each letra As String In cadena
            If letra = "a" Then
                cuentavocal = cuentavocal + 1
            End If
        Next
        Me.TextBox2.Text = cuentavocal
    End Sub
End Class
