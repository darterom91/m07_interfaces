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
        Me.B = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.x1 = New System.Windows.Forms.TextBox()
        Me.y1 = New System.Windows.Forms.TextBox()
        Me.x2 = New System.Windows.Forms.TextBox()
        Me.y2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.B)
        Me.Panel1.Controls.Add(Me.A)
        Me.Panel1.Location = New System.Drawing.Point(179, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 235)
        Me.Panel1.TabIndex = 0
        '
        'B
        '
        Me.B.BackColor = System.Drawing.Color.Red
        Me.B.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.B.FlatAppearance.BorderSize = 0
        Me.B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B.ForeColor = System.Drawing.Color.White
        Me.B.Location = New System.Drawing.Point(321, 74)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(75, 23)
        Me.B.TabIndex = 1
        Me.B.Text = "B"
        Me.B.UseVisualStyleBackColor = False
        '
        'A
        '
        Me.A.BackColor = System.Drawing.Color.DodgerBlue
        Me.A.FlatAppearance.BorderSize = 0
        Me.A.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.A.ForeColor = System.Drawing.Color.White
        Me.A.Location = New System.Drawing.Point(66, 74)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(75, 23)
        Me.A.TabIndex = 0
        Me.A.Text = "A"
        Me.A.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.BackColor = System.Drawing.Color.Black
        Me.cerrar.ForeColor = System.Drawing.Color.Cornsilk
        Me.cerrar.Location = New System.Drawing.Point(304, 365)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(199, 23)
        Me.cerrar.TabIndex = 2
        Me.cerrar.Text = "Cerrar"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Orange
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(25, 111)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(23, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "X1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Y1:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Red
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(664, 111)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 13)
        Me.label5.TabIndex = 5
        Me.label5.Text = "X2: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(664, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Y2:"
        '
        'x1
        '
        Me.x1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.x1.Enabled = False
        Me.x1.ForeColor = System.Drawing.Color.White
        Me.x1.Location = New System.Drawing.Point(70, 111)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(54, 20)
        Me.x1.TabIndex = 7
        Me.x1.Text = "0"
        '
        'y1
        '
        Me.y1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.y1.Enabled = False
        Me.y1.ForeColor = System.Drawing.Color.White
        Me.y1.Location = New System.Drawing.Point(70, 183)
        Me.y1.Name = "y1"
        Me.y1.Size = New System.Drawing.Size(54, 20)
        Me.y1.TabIndex = 8
        Me.y1.Text = "0"
        '
        'x2
        '
        Me.x2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.x2.Enabled = False
        Me.x2.ForeColor = System.Drawing.Color.White
        Me.x2.Location = New System.Drawing.Point(709, 111)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(54, 20)
        Me.x2.TabIndex = 9
        Me.x2.Text = "0"
        '
        'y2
        '
        Me.y2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.y2.Enabled = False
        Me.y2.ForeColor = System.Drawing.Color.White
        Me.y2.Location = New System.Drawing.Point(709, 183)
        Me.y2.Name = "y2"
        Me.y2.Size = New System.Drawing.Size(54, 20)
        Me.y2.TabIndex = 10
        Me.y2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(664, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "X2: "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(321, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "B"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(801, 475)
        Me.Controls.Add(Me.x2)
        Me.Controls.Add(Me.y2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.x1)
        Me.Controls.Add(Me.y1)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents B As System.Windows.Forms.Button
    Friend WithEvents A As System.Windows.Forms.Button
    Friend WithEvents cerrar As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents x1 As System.Windows.Forms.TextBox
    Friend WithEvents y1 As System.Windows.Forms.TextBox
    Friend WithEvents x2 As System.Windows.Forms.TextBox
    Friend WithEvents y2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
