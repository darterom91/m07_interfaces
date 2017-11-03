Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cuentavocal As Integer
        Dim cadena As String = Me.campocadena.Text
        'crea una nueva variable que se llama letra que cuenta los chars de ese string
        For Each letra As String In cadena
            'comprueba si hay un char 'a'
            If letra = "a" Then
                'autoincrementa cada vez que hay una a
                cuentavocal = cuentavocal + 1
            End If
        Next
        'muestra el resultado
        Me.campovocal.Text = cuentavocal
    End Sub

    Private Sub campocadena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles campocadena.TextChanged

    End Sub
End Class
