Public Class Form1
    Dim a, i As Integer
    Dim j As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button2.Enabled = False

        If Button1.Text = "parar" Then
            Button1.Text = "inicio"
            Timer1.Enabled = False
            Button2.Enabled = True
        Else
            Button1.Text = "parar"
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim img() As Object = {My.Resources.img1, My.Resources.img2, My.Resources.img3, My.Resources.img4, My.Resources.img5, My.Resources.img6,
                               My.Resources.img7, My.Resources.img8, My.Resources.img9, My.Resources.img10, My.Resources.img11, My.Resources.img12,
                               My.Resources.img13, My.Resources.img14, My.Resources.img15, My.Resources.img16, My.Resources.img17}
        a = a + 1

        If a Mod 10 = 0 Then
            i = i + 1
            PictureBox1.Image = img(i)
        End If

        If a > 160 Then
            a = 0
            i = 0
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim img() As Object = {My.Resources.img1, My.Resources.img2, My.Resources.img3, My.Resources.img4, My.Resources.img5, My.Resources.img6,
                              My.Resources.img7, My.Resources.img8, My.Resources.img9, My.Resources.img10, My.Resources.img11, My.Resources.img12,
                              My.Resources.img13, My.Resources.img14, My.Resources.img15, My.Resources.img16, My.Resources.img17}
        j = j + 1
        PictureBox1.Image = img(j)

        If j = 16 Then j = 0

    End Sub
End Class
