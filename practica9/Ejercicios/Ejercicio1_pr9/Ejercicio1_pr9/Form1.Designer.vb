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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VScrollRed = New System.Windows.Forms.VScrollBar()
        Me.VScrollGreen = New System.Windows.Forms.VScrollBar()
        Me.VScrollBlue = New System.Windows.Forms.VScrollBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TrackBarBlue = New System.Windows.Forms.TrackBar()
        Me.TrackBarGreen = New System.Windows.Forms.TrackBar()
        Me.TrackBarRed = New System.Windows.Forms.TrackBar()
        Me.vermell = New System.Windows.Forms.Label()
        Me.verd = New System.Windows.Forms.Label()
        Me.blau = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.VScrollRed)
        Me.GroupBox1.Controls.Add(Me.VScrollGreen)
        Me.GroupBox1.Controls.Add(Me.VScrollBlue)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'VScrollRed
        '
        Me.VScrollRed.Location = New System.Drawing.Point(49, 16)
        Me.VScrollRed.Name = "VScrollRed"
        Me.VScrollRed.Size = New System.Drawing.Size(24, 137)
        Me.VScrollRed.TabIndex = 1
        '
        'VScrollGreen
        '
        Me.VScrollGreen.Location = New System.Drawing.Point(90, 16)
        Me.VScrollGreen.Name = "VScrollGreen"
        Me.VScrollGreen.Size = New System.Drawing.Size(24, 137)
        Me.VScrollGreen.TabIndex = 0
        '
        'VScrollBlue
        '
        Me.VScrollBlue.Location = New System.Drawing.Point(133, 16)
        Me.VScrollBlue.Name = "VScrollBlue"
        Me.VScrollBlue.Size = New System.Drawing.Size(23, 137)
        Me.VScrollBlue.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Controls.Add(Me.TrackBarBlue)
        Me.GroupBox2.Controls.Add(Me.TrackBarGreen)
        Me.GroupBox2.Controls.Add(Me.TrackBarRed)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TrackBarBlue
        '
        Me.TrackBarBlue.Location = New System.Drawing.Point(35, 109)
        Me.TrackBarBlue.Name = "TrackBarBlue"
        Me.TrackBarBlue.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarBlue.TabIndex = 5
        '
        'TrackBarGreen
        '
        Me.TrackBarGreen.Location = New System.Drawing.Point(35, 64)
        Me.TrackBarGreen.Name = "TrackBarGreen"
        Me.TrackBarGreen.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarGreen.TabIndex = 4
        '
        'TrackBarRed
        '
        Me.TrackBarRed.Location = New System.Drawing.Point(35, 19)
        Me.TrackBarRed.Name = "TrackBarRed"
        Me.TrackBarRed.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarRed.TabIndex = 3
        '
        'vermell
        '
        Me.vermell.AutoSize = True
        Me.vermell.Location = New System.Drawing.Point(274, 199)
        Me.vermell.Name = "vermell"
        Me.vermell.Size = New System.Drawing.Size(40, 13)
        Me.vermell.TabIndex = 0
        Me.vermell.Text = "vermell"
        '
        'verd
        '
        Me.verd.AutoSize = True
        Me.verd.Location = New System.Drawing.Point(274, 242)
        Me.verd.Name = "verd"
        Me.verd.Size = New System.Drawing.Size(28, 13)
        Me.verd.TabIndex = 1
        Me.verd.Text = "verd"
        '
        'blau
        '
        Me.blau.AutoSize = True
        Me.blau.Location = New System.Drawing.Point(274, 291)
        Me.blau.Name = "blau"
        Me.blau.Size = New System.Drawing.Size(27, 13)
        Me.blau.TabIndex = 2
        Me.blau.Text = "blau"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(335, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(335, 239)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(335, 291)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(301, 42)
        Me.Panel1.Multiline = True
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 70)
        Me.Panel1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 382)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.vermell)
        Me.Controls.Add(Me.verd)
        Me.Controls.Add(Me.blau)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VScrollRed As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollGreen As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBlue As System.Windows.Forms.VScrollBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBarBlue As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarGreen As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarRed As System.Windows.Forms.TrackBar
    Friend WithEvents vermell As System.Windows.Forms.Label
    Friend WithEvents verd As System.Windows.Forms.Label
    Friend WithEvents blau As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.TextBox

End Class
