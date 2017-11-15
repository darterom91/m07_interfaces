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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pausar = New System.Windows.Forms.Button()
        Me.Continuar = New System.Windows.Forms.Button()
        Me.Iniciar0 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(95, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00"
        '
        'Pausar
        '
        Me.Pausar.Location = New System.Drawing.Point(106, 282)
        Me.Pausar.Name = "Pausar"
        Me.Pausar.Size = New System.Drawing.Size(75, 35)
        Me.Pausar.TabIndex = 1
        Me.Pausar.Text = "Pausar"
        Me.Pausar.UseVisualStyleBackColor = True
        '
        'Continuar
        '
        Me.Continuar.Location = New System.Drawing.Point(233, 282)
        Me.Continuar.Name = "Continuar"
        Me.Continuar.Size = New System.Drawing.Size(87, 35)
        Me.Continuar.TabIndex = 2
        Me.Continuar.Text = "Continuar"
        Me.Continuar.UseVisualStyleBackColor = True
        '
        'Iniciar0
        '
        Me.Iniciar0.Location = New System.Drawing.Point(380, 282)
        Me.Iniciar0.Name = "Iniciar0"
        Me.Iniciar0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Iniciar0.Size = New System.Drawing.Size(74, 35)
        Me.Iniciar0.TabIndex = 3
        Me.Iniciar0.Text = "Iniciar0"
        Me.Iniciar0.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(369, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 61)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(235, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 61)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 61)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 61)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = ":"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(605, 383)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Iniciar0)
        Me.Controls.Add(Me.Continuar)
        Me.Controls.Add(Me.Pausar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pausar As System.Windows.Forms.Button
    Friend WithEvents Continuar As System.Windows.Forms.Button
    Friend WithEvents Iniciar0 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
