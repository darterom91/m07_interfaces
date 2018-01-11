Public Class Form1
    Dim graf As Graphics
    Dim llapis As Pen

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        graf = Panel1.CreateGraphics
        Dim fuente As New System.Drawing.Font("Arial", 15)
        Dim n1 As String = TextBox1.Text
        Dim n2 As String = TextBox2.Text
        Dim num1 As Integer = CInt(n1)
        Dim num2 As Integer = CInt(n2)
        Dim frase As String = "Hola que tal estas: "
        Dim concate As String
        concate = frase + Str(num1) + " , " + Str(num2)
        Dim formato As New System.Drawing.StringFormat
        llapis = New System.Drawing.Pen(Brushes.Aqua, 10)
        graf.DrawRectangle(llapis, New Rectangle(0, 0, 100, 100))
        graf.DrawRectangle(Pens.Red, New Rectangle(10, 10, 50, 50))
        graf.FillRectangle(Brushes.Red, New Rectangle(110, 10, 50, 50))
        graf.DrawString(concate, fuente, Brushes.Blue, num1, num2, formato)

    End Sub

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        graf = Panel1.CreateGraphics
        Dim punts() As Point = {New Point(30, 30), New Point(90, 50), New Point(70, 80)}
        Dim punts2() As Point = {New Point(80, 80), New Point(140, 100), New Point(120, 130)}
        Panel2.CreateGraphics.DrawClosedCurve(Pens.Blue, punts)
        Panel2.CreateGraphics.DrawClosedCurve(Pens.Blue, punts2)
        Panel2.CreateGraphics.FillClosedCurve(Brushes.Brown, punts2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.CreateGraphics.Clear(Color.White)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel2.CreateGraphics.Clear(Color.White)
    End Sub
End Class
