Public Class Form1
    Private Sub cajaTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cajaTexto.TextChanged
        Me.longTexto.Text = Me.cajaTexto.TextLength
    End Sub
End Class
