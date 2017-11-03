Public Class Form1


    Private Sub CheckCambiarLetra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCambiarLetra.CheckedChanged
        If Me.CheckCambiarLetra.Checked Then
            Me.Label1.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Italic)
        Else
            Me.Label1.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        End If
    End Sub
    Private Sub CheckColorText_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckColorText.CheckedChanged
        If Me.CheckColorText.Checked Then
            Me.Label1.ForeColor = Color.DarkRed
        Else
            Me.Label1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CheckColorFondo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckColorFondo.CheckedChanged
        If Me.CheckColorFondo.Checked Then
            Me.Label1.BackColor = Color.Aqua
        Else
            Me.Label1.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub TipoLetra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoLetra.CheckedChanged
        Me.Label2.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Italic)
        Me.Label2.ForeColor = Color.Black
        Me.Label2.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub ColorTexto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorTexto.CheckedChanged
        Me.Label2.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        Me.Label2.ForeColor = Color.DarkRed
        Me.Label2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ColorFondo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorFondo.CheckedChanged
        Me.Label2.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        Me.Label2.ForeColor = Color.Black
        Me.Label2.BackColor = Color.Aqua

    End Sub
End Class
