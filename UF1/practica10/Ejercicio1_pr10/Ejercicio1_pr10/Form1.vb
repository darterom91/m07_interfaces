Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Integer = Me.TextBox1.Text
        Dim i, j, res As Integer

        Me.DataGridView1.ColumnCount = 3
        Me.DataGridView1.Columns(0).Name = "Multiplicad"
        Me.DataGridView1.Columns(1).Name = "Multiplicador"
        Me.DataGridView1.Columns(2).Name = "Resultat"

        For i = 0 To 10
            res = i * num
            Me.DataGridView1.Rows.Add(num, i, res)
        Next
    End Sub

End Class
