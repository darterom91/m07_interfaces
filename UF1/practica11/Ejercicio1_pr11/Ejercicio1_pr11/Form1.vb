Public Class Form1
    Dim i As Integer
    Dim tiempo As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label3.Text += 1

        If Label3.Text = "60" Then
            Label2.Text += 1
            Label3.Text = "00"
        End If

        If Label2.Text = "60" Then
            Label1.Text += 1
            Label2.Text = "00"
        End If

        If Label1.Text = "24" Then
            Label1.Text = "00"
        End If



    End Sub

    Private Sub Pausar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pausar.Click
        Timer1.Stop()
        Continuar.Enabled = True

    End Sub

    Private Sub Continuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Continuar.Click
        Timer1.Start()
        Continuar.Enabled = False
    End Sub

    Private Sub Iniciar0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Iniciar0.Click
        Timer1.Stop()
        Label3.Text = "00"
        Label2.Text = "00"
        Label1.Text = "00"
        Continuar.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 10
        Continuar.Enabled = False
    End Sub
End Class
