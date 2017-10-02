Public Class Form1
    'compara la longitud del texto y la introduce a la lista y despues borra el contenido del textbox
    Private Sub insertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertar.Click
        If Me.TextBox1.TextLength > 0 Then
            Me.ListBox1.Items.Add(Me.TextBox1.Text)
            Me.ComboBox1.Items.Add(Me.TextBox1.Text)
            Me.TextBox1.Clear()
        End If
    End Sub
    'si el checkbox tiene esta checked la lista ordena la lista de caracteres 
    Private Sub ordenar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ordenar.CheckedChanged
        If Me.ordenar.Checked Then
            Me.ListBox1.Sorted = True
            Me.ComboBox1.Sorted = True
        Else
            Me.ListBox1.Sorted = False
            Me.ComboBox1.Sorted = False
        End If
    End Sub
    'cuando seleccionas un nombre al clicar al boton eliminar borra ese string
    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        Me.ListBox1.Items.Remove(Me.ListBox1.SelectedItem)
        Me.ListBox1.Items.Remove(Me.ListBox1.SelectedItem)
        Me.ComboBox1.Items.Remove(Me.ComboBox1.SelectedItem)
        Me.ComboBox1.Items.Remove(Me.ComboBox1.SelectedItem)
    End Sub
    'borra el contenido de la lista
    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        Me.ListBox1.Items.Clear()
        Me.ListBox1.Items.Clear()
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Clear()
    End Sub

    'bloquea el textbox y los 2 botones, para que no puedas interactuar con ellos
    Private Sub noLectura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noLectura.CheckedChanged
        If Me.noLectura.Checked Then
            Me.TextBox1.Enabled = False
            Me.insertar.Enabled = False
            Me.eliminar.Enabled = False
        Else
            Me.TextBox1.Enabled = True
            Me.insertar.Enabled = True
            Me.eliminar.Enabled = True
        End If
    End Sub
End Class
