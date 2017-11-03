Public Class Form1

    'Es un procedimiento que le da el valor max y min al VScrollred, green y blue, se declara una variable de tipo color, 
    'la variable colores se le pasa el metodo color.FromArgb() con el value de cada vScroll y finalmente introduce los valores al color
    Sub colorbox()
        Dim colores As Color
        VScrollRed.Maximum = 255
        VScrollRed.Minimum = 0
        VScrollGreen.Maximum = 255
        VScrollGreen.Minimum = 0
        VScrollBlue.Maximum = 255
        VScrollBlue.Minimum = 0

        colores = Color.FromArgb(VScrollRed.Value, VScrollGreen.Value, VScrollBlue.Value)
        Panel1.BackColor = colores
    End Sub

    Private Sub VScrollRed_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollRed.Scroll
        Dim colores As Color

        VScrollRed.Maximum = 255
        VScrollRed.Minimum = 0
        VScrollGreen.Maximum = 255
        VScrollGreen.Minimum = 0
        VScrollBlue.Maximum = 255
        VScrollBlue.Minimum = 0

        colores = Color.FromArgb(VScrollRed.Value, VScrollGreen.Value, VScrollBlue.Value)
        Panel1.BackColor = colores
        TextBox1.Text = VScrollRed.Value
    End Sub

    Private Sub VScrollGreen_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollGreen.Scroll
        Dim colores As Color

        VScrollRed.Maximum = 255
        VScrollRed.Minimum = 0
        VScrollGreen.Maximum = 255
        VScrollGreen.Minimum = 0
        VScrollBlue.Maximum = 255
        VScrollBlue.Minimum = 0

        colores = Color.FromArgb(VScrollRed.Value, VScrollGreen.Value, VScrollBlue.Value)
        Panel1.BackColor = colores
        TextBox2.Text = VScrollGreen.Value
    End Sub

    'Se Llama a la procedure desde el if y se le introduce al textbox3 el valor.
    Private Sub VScrollBlue_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBlue.Scroll
        If e.Type = ScrollEventType.EndScroll Then colorbox()
        TextBox3.Text = VScrollBlue.Value
    End Sub

    'Le damos el valor max y min del trackBar de cada color en sus diferentes funciones, se declara la var colores y se le assigna el color,
    'para mostrarlo en el panel y se pasa el valor del trackbar al textBox correspondiente. (en la funcion color.FronArgb(trackBarRojo, trackBarVerde, trackBarAzul)  
    'tiene que estar los 3 colores)
    Private Sub TrackBarRed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarRed.Scroll
        Dim colores As Color

        TrackBarRed.Maximum = 255
        TrackBarRed.Minimum = 0

        colores = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
        Panel1.BackColor = colores

        TextBox1.Text = TrackBarRed.Value

    End Sub

    Private Sub TrackBarGreen_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarGreen.Scroll
        Dim colores As Color

        TrackBarGreen.Maximum = 255
        TrackBarGreen.Minimum = 0

        colores = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
        Panel1.BackColor = colores

        TextBox2.Text = TrackBarGreen.Value

    End Sub

    Private Sub TrackBarBlue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarBlue.Scroll
        Dim colores As Color

        TrackBarBlue.Maximum = 255
        TrackBarBlue.Minimum = 0

        colores = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
        Panel1.BackColor = colores

        TextBox3.Text = TrackBarBlue.Value

    End Sub
End Class
