Public Class Form1
    Dim ang As Double = 0
    Dim x, y As Integer
  

    Private Sub Parar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Parar.Click
        Timer1.Enabled = False
        Iniciar.Text = "Continuar"
    End Sub

    Private Sub Iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Iniciar.Click
        Timer1.Enabled = True
    End Sub

    Private Sub PararLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PararLimpiar.Click
        Dim Graf As Graphics
        Graf = PictureBox1.CreateGraphics
        Graf.Clear(Color.SeaGreen)
        Graf.DrawEllipse(Pens.Black, New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height))
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim graf As Graphics
        graf = PictureBox1.CreateGraphics
        Dim Radio As Integer = TextBox5.Text
        ang = ang + 0.1
        x = Int(Radio * Math.Cos(ang))
        y = Int(Radio * Math.Sin(ang))

        Dim center As Point = New Point(PictureBox1.Width / 2, PictureBox1.Height / 2)
        Dim final As Point = New Point(PictureBox1.Width / 2 + x, PictureBox1.Height / 2 + y)

        graf.DrawLine(Pens.Black, center, final)
        TextBox3.Text = final.X
        TextBox4.Text = final.Y
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawEllipse(Pens.Black, New Rectangle(0, 0, PictureBox1.Width - 2, PictureBox1.Height - 2))
        TextBox1.Text = PictureBox1.Width / 2
        TextBox2.Text = PictureBox1.Height / 2
    End Sub
End Class
