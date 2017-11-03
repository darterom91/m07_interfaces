Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, valor, suma As Integer
        For i = 1 To 10
            'es una ventana con una caja de texto la cual le asignas valores a una variable
            valor = InputBox("digite numero", "captura numero")
            'se muestra lo introducido, el valor y un salto de linea 
            Me.TextBox1.Text = Me.TextBox1.Text & valor & vbCrLf
            'hace la operacion de todos los numeros capturados
            suma = suma + valor
        Next
        'muestra el resultado final
        Me.TextBox1.Text = Me.TextBox1.Text & valor & vbCrLf & "LA sumatoria es: " & suma
    End Sub
End Class
