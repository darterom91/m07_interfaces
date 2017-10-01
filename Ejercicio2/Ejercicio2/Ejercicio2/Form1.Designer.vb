<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.insertar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ordenado = New System.Windows.Forms.CheckBox()
        Me.soloLectura = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(28, 72)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 121)
        Me.ListBox1.TabIndex = 0
        '
        'insertar
        '
        Me.insertar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.insertar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.insertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive
        Me.insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insertar.ForeColor = System.Drawing.Color.White
        Me.insertar.Location = New System.Drawing.Point(214, 264)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(75, 23)
        Me.insertar.TabIndex = 1
        Me.insertar.Text = "Insertar"
        Me.insertar.UseVisualStyleBackColor = False
        '
        'limpiar
        '
        Me.limpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive
        Me.limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.limpiar.ForeColor = System.Drawing.Color.White
        Me.limpiar.Location = New System.Drawing.Point(336, 264)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 2
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive
        Me.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.ForeColor = System.Drawing.Color.White
        Me.eliminar.Location = New System.Drawing.Point(185, 212)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.eliminar.Size = New System.Drawing.Size(57, 21)
        Me.eliminar.TabIndex = 3
        Me.eliminar.Text = "-> "
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(34, 267)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 4
        '
        'ordenado
        '
        Me.ordenado.AutoSize = True
        Me.ordenado.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ordenado.ForeColor = System.Drawing.Color.White
        Me.ordenado.Location = New System.Drawing.Point(338, 96)
        Me.ordenado.Name = "ordenado"
        Me.ordenado.Size = New System.Drawing.Size(73, 17)
        Me.ordenado.TabIndex = 5
        Me.ordenado.Text = "Ordenado"
        Me.ordenado.UseVisualStyleBackColor = False
        '
        'soloLectura
        '
        Me.soloLectura.AutoSize = True
        Me.soloLectura.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.soloLectura.ForeColor = System.Drawing.Color.White
        Me.soloLectura.Location = New System.Drawing.Point(338, 160)
        Me.soloLectura.Name = "soloLectura"
        Me.soloLectura.Size = New System.Drawing.Size(82, 17)
        Me.soloLectura.TabIndex = 6
        Me.soloLectura.Text = "Solo lectura"
        Me.soloLectura.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Que quieres hacer?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(467, 330)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.soloLectura)
        Me.Controls.Add(Me.ordenado)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents insertar As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ordenado As System.Windows.Forms.CheckBox
    Friend WithEvents soloLectura As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
