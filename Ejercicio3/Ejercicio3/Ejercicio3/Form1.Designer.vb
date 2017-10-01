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
        Me.insertar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ordenar = New System.Windows.Forms.CheckBox()
        Me.noLectura = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'insertar
        '
        Me.insertar.BackColor = System.Drawing.Color.Black
        Me.insertar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.insertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insertar.ForeColor = System.Drawing.Color.White
        Me.insertar.Location = New System.Drawing.Point(211, 340)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(75, 23)
        Me.insertar.TabIndex = 0
        Me.insertar.Text = "insertar"
        Me.insertar.UseVisualStyleBackColor = False
        '
        'limpiar
        '
        Me.limpiar.BackColor = System.Drawing.Color.Black
        Me.limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.limpiar.ForeColor = System.Drawing.Color.White
        Me.limpiar.Location = New System.Drawing.Point(349, 340)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 1
        Me.limpiar.Text = "limpiar"
        Me.limpiar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.Color.Black
        Me.eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.ForeColor = System.Drawing.Color.White
        Me.eliminar.Location = New System.Drawing.Point(171, 296)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(51, 24)
        Me.eliminar.TabIndex = 2
        Me.eliminar.Text = "->"
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Que quieres hacer ?"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(34, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'ordenar
        '
        Me.ordenar.AutoSize = True
        Me.ordenar.BackColor = System.Drawing.Color.Black
        Me.ordenar.ForeColor = System.Drawing.Color.White
        Me.ordenar.Location = New System.Drawing.Point(306, 139)
        Me.ordenar.Name = "ordenar"
        Me.ordenar.Size = New System.Drawing.Size(62, 17)
        Me.ordenar.TabIndex = 5
        Me.ordenar.Text = "ordenar"
        Me.ordenar.UseVisualStyleBackColor = False
        '
        'noLectura
        '
        Me.noLectura.AutoSize = True
        Me.noLectura.BackColor = System.Drawing.Color.Black
        Me.noLectura.ForeColor = System.Drawing.Color.White
        Me.noLectura.Location = New System.Drawing.Point(306, 223)
        Me.noLectura.Name = "noLectura"
        Me.noLectura.Size = New System.Drawing.Size(73, 17)
        Me.noLectura.TabIndex = 6
        Me.noLectura.Text = "no lectura"
        Me.noLectura.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(34, 340)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(34, 128)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 147)
        Me.ListBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(438, 380)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.noLectura)
        Me.Controls.Add(Me.ordenar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.insertar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insertar As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ordenar As System.Windows.Forms.CheckBox
    Friend WithEvents noLectura As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
