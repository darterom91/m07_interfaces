Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()

        Dim num, num2 As Integer
        num = CInt(Int((80 - 1) * Rnd()) + 1)
        num2 = CInt(Int((80 - 1) * Rnd()) + 1)

        Me.TextBox1.Text = num
        Me.TextBox2.Text = num2


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num, i, j As Integer
        num = Me.TextBox1.Text

        For num = num To 100 Step 2
            Me.lista1.Text = Me.lista1.Text & num & "   [" & i + 1 & vbCrLf
            i = i + 1
        Next

        Me.Label1.Text = i

        num = Me.TextBox1.Text
        For num = num To 100 Step 3
            Me.lista2.Text = Me.lista2.Text & num & "   [" & j + 1 & vbCrLf
            j = j + 1
        Next
        Me.Label2.Text = j
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim num2, i, j As Integer
        num2 = Me.TextBox2.Text

        For num2 = num2 To 100 Step 2
            Me.lista3.Text = Me.lista3.Text & num2 & "   [" & i + 1 & vbCrLf
            i = i + 1
        Next
        Me.Label3.Text = i

        num2 = Me.TextBox2.Text
        For num2 = num2 To 100 Step 3
            Me.lista4.Text = Me.lista4.Text & num2 & "   [" & j + 1 & vbCrLf
            j = j + 1
        Next
        Me.Label4.Text = j

    End Sub

End Class
