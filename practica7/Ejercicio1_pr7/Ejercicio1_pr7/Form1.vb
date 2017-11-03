Public Class Form1
    Dim palabra() As String = {"negro", "verde", "azul", "rojo", "amarillo"}
    Dim tamaño() As String = {11, 12, 13, 14}

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Select Case (ListBox1.SelectedIndex)
            Case 0
                Me.TextBox2.ForeColor = Color.Black
            Case 1
                Me.TextBox2.ForeColor = Color.Green
            Case 2
                Me.TextBox2.ForeColor = Color.Blue
            Case 3
                Me.TextBox2.ForeColor = Color.Red
            Case 4
                Me.TextBox2.ForeColor = Color.Yellow

        End Select


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer

        For i = 0 To palabra.Length - 1
            ListBox1.Items.Add(palabra(i))
        Next

        For i = 0 To tamaño.Length - 1
            ComboBox1.Items.Add(tamaño(i))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cosa As Single

        Select Case (ComboBox1.SelectedIndex)
            Case 0
                Me.TextBox2.Font = New Font("Microsoft Sans Serif", tamaño(0))
            Case 1
                Me.TextBox2.Font = New Font("Microsoft Sans Serif", tamaño(1))
            Case 2
                Me.TextBox2.Font = New Font("Microsoft Sans Serif", tamaño(2))
            Case 3
                Me.TextBox2.Font = New Font("Microsoft Sans Serif", tamaño(3))
            Case 4
                Me.TextBox2.Font = New Font("Microsoft Sans Serif", tamaño(4))

        End Select
    End Sub
End Class
