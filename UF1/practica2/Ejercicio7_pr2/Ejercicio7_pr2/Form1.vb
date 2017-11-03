Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim suma, valor, i As Integer
        i = 0
        Dim Respuesta As String = ""

        Do
            valor = InputBox("Introduce un numero", "numeros capturados:")
            Me.TextBox1.Text = Me.TextBox1.Text & valor & vbCrLf
            suma = suma + valor
            If i = 10 Then
                Respuesta = InputBox("Respuesta", "Introduce la  respuesta")

            End If
            i = i + 1
        Loop While (Respuesta <> "no")
        Me.TextBox2.Text = suma
    End Sub
End Class
