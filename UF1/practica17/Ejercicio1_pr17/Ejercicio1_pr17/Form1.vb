Public Class Form1
    Dim cont, mover, maxOvejas As Integer
    Dim listaOvejas As New ArrayList()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listaOvejas.Add(My.Resources.sheep)
        listaOvejas.Add(My.Resources.sheep2)

        cont = 0

        maxOvejas = listaOvejas.Count
        mover = -10
        Me.PictureBox1.Image = listaOvejas(cont)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If (Timer1.Enabled = True) Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim oveja() As Object = {My.Resources.sheep, My.Resources.sheep2}
        Dim i As Integer

        If (Me.PictureBox1.Left <= 0) Then
            mover = 10
            For i = 0 To (maxOvejas - 1)
                listaOvejas(i).RotateFlip(RotateFlipType.Rotate180FlipY)
            Next

        ElseIf (Me.PictureBox1.Left >= (Me.Panel1.Width - Me.PictureBox1.Width)) Then
            mover = -10
            For i = 0 To (maxOvejas - 1)
                listaOvejas(i).RotateFlip(RotateFlipType.Rotate180FlipY)
            Next
        End If

        Me.PictureBox1.Left += mover
        Me.PictureBox1.Image = listaOvejas(cont)

        cont = cont + 1

        If cont >= maxOvejas Then
            cont = 0
        End If
    End Sub
End Class
