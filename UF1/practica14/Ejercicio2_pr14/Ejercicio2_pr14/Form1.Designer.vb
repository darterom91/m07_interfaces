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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.black = New System.Windows.Forms.Button()
        Me.green = New System.Windows.Forms.Button()
        Me.yellow = New System.Windows.Forms.Button()
        Me.blue = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.red = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(53, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 265)
        Me.Panel1.TabIndex = 0
        '
        'black
        '
        Me.black.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.black.FlatAppearance.BorderSize = 2
        Me.black.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.black.Location = New System.Drawing.Point(158, 334)
        Me.black.Name = "black"
        Me.black.Size = New System.Drawing.Size(40, 28)
        Me.black.TabIndex = 0
        Me.black.UseVisualStyleBackColor = True
        '
        'green
        '
        Me.green.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.green.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.green.Location = New System.Drawing.Point(103, 307)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(40, 28)
        Me.green.TabIndex = 1
        Me.green.UseVisualStyleBackColor = False
        '
        'yellow
        '
        Me.yellow.BackColor = System.Drawing.Color.Yellow
        Me.yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yellow.Location = New System.Drawing.Point(103, 355)
        Me.yellow.Name = "yellow"
        Me.yellow.Size = New System.Drawing.Size(40, 28)
        Me.yellow.TabIndex = 2
        Me.yellow.UseVisualStyleBackColor = False
        '
        'blue
        '
        Me.blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blue.Location = New System.Drawing.Point(44, 355)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(41, 28)
        Me.blue.TabIndex = 3
        Me.blue.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(228, 334)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 28)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'red
        '
        Me.red.BackColor = System.Drawing.Color.Red
        Me.red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.red.Location = New System.Drawing.Point(44, 307)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(41, 28)
        Me.red.TabIndex = 5
        Me.red.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(365, 334)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 28)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(493, 395)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.blue)
        Me.Controls.Add(Me.black)
        Me.Controls.Add(Me.yellow)
        Me.Controls.Add(Me.green)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents black As System.Windows.Forms.Button
    Friend WithEvents green As System.Windows.Forms.Button
    Friend WithEvents yellow As System.Windows.Forms.Button
    Friend WithEvents blue As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents red As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button

End Class
