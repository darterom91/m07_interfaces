Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opcion As Integer = Me.TextBox1.Text
        Dim Semana As String = ""

        Select(opcion)
            Case 1
                Me.TextBox2.Text = "Lunes"
            Case 2
                Me.TextBox2.Text = "Martes"
            Case 3
                Me.TextBox2.Text = "Miercoles"
            Case 4
                Me.TextBox2.Text = "Jueves"
            Case 5
                Me.TextBox2.Text = "Viernes"
            Case 6
                Me.TextBox2.Text = "Sabado"
            Case 7
                Me.TextBox2.Text = "Domingo"
            Case Else
                Me.TextBox2.Text = "Error ese día de la semana no existe"

        End Select

    End Sub
End Class
