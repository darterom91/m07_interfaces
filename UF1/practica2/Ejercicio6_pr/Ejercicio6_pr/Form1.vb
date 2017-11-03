Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Variables
        Dim num, max, min, i As Integer
        'iniciando variables
        max = 0
        min = 0
        While (i < 10)
            'introducir los numeros
            num = InputBox("introduce el numero", "El numero es:")
            'comprobar si el numero es 0 o no
            If (num = 0) Then
                i = 10
            Else
                'Comprueban si num es mayor a Max y si num es menor min, para introducir los valores
                If num > max Then
                    max = num

                    If i = 0 Then
                        min = num
                    End If

                End If

                If num < min Then
                    min = num
                End If
            End If

            'introducen los valores dentro de los cuadros de texto
            Me.TextBox1.Text = min
            Me.TextBox2.Text = max
            i = i + 1

        End While

    End Sub
End Class
