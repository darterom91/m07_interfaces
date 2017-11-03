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
        Me.TipoLetra = New System.Windows.Forms.RadioButton()
        Me.ColorTexto = New System.Windows.Forms.RadioButton()
        Me.ColorFondo = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UtilitzacioRadioButton = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UtilitzacioCheckBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckCambiarLetra = New System.Windows.Forms.CheckBox()
        Me.CheckColorText = New System.Windows.Forms.CheckBox()
        Me.CheckColorFondo = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TipoLetra
        '
        Me.TipoLetra.AutoSize = True
        Me.TipoLetra.Location = New System.Drawing.Point(3, 3)
        Me.TipoLetra.Name = "TipoLetra"
        Me.TipoLetra.Size = New System.Drawing.Size(123, 17)
        Me.TipoLetra.TabIndex = 0
        Me.TipoLetra.TabStop = True
        Me.TipoLetra.Text = "Cambiar tipo de lletra"
        Me.TipoLetra.UseVisualStyleBackColor = True
        '
        'ColorTexto
        '
        Me.ColorTexto.AutoSize = True
        Me.ColorTexto.Location = New System.Drawing.Point(3, 40)
        Me.ColorTexto.Name = "ColorTexto"
        Me.ColorTexto.Size = New System.Drawing.Size(126, 17)
        Me.ColorTexto.TabIndex = 1
        Me.ColorTexto.TabStop = True
        Me.ColorTexto.Text = "Cambiar color del text"
        Me.ColorTexto.UseVisualStyleBackColor = True
        '
        'ColorFondo
        '
        Me.ColorFondo.AutoSize = True
        Me.ColorFondo.Location = New System.Drawing.Point(3, 80)
        Me.ColorFondo.Name = "ColorFondo"
        Me.ColorFondo.Size = New System.Drawing.Size(112, 17)
        Me.ColorFondo.TabIndex = 2
        Me.ColorFondo.TabStop = True
        Me.ColorFondo.Text = "Cambiar color fons"
        Me.ColorFondo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Control radio button"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UtilitzacioRadioButton)
        Me.Panel2.Controls.Add(Me.TipoLetra)
        Me.Panel2.Controls.Add(Me.ColorTexto)
        Me.Panel2.Controls.Add(Me.ColorFondo)
        Me.Panel2.Location = New System.Drawing.Point(12, 203)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 100)
        Me.Panel2.TabIndex = 4
        '
        'UtilitzacioRadioButton
        '
        Me.UtilitzacioRadioButton.Location = New System.Drawing.Point(243, 39)
        Me.UtilitzacioRadioButton.Name = "UtilitzacioRadioButton"
        Me.UtilitzacioRadioButton.Size = New System.Drawing.Size(172, 20)
        Me.UtilitzacioRadioButton.TabIndex = 3
        Me.UtilitzacioRadioButton.Text = "Utilització de radio button"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckColorFondo)
        Me.Panel1.Controls.Add(Me.CheckColorText)
        Me.Panel1.Controls.Add(Me.CheckCambiarLetra)
        Me.Panel1.Controls.Add(Me.UtilitzacioCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 100)
        Me.Panel1.TabIndex = 6
        '
        'UtilitzacioCheckBox
        '
        Me.UtilitzacioCheckBox.Location = New System.Drawing.Point(243, 39)
        Me.UtilitzacioCheckBox.Name = "UtilitzacioCheckBox"
        Me.UtilitzacioCheckBox.Size = New System.Drawing.Size(172, 20)
        Me.UtilitzacioCheckBox.TabIndex = 3
        Me.UtilitzacioCheckBox.Text = "Utilització de checkbox"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Control de checkbox"
        '
        'CheckCambiarLetra
        '
        Me.CheckCambiarLetra.AutoSize = True
        Me.CheckCambiarLetra.Location = New System.Drawing.Point(3, 3)
        Me.CheckCambiarLetra.Name = "CheckCambiarLetra"
        Me.CheckCambiarLetra.Size = New System.Drawing.Size(124, 17)
        Me.CheckCambiarLetra.TabIndex = 4
        Me.CheckCambiarLetra.Text = "Cambiar tipo de lletra"
        Me.CheckCambiarLetra.UseVisualStyleBackColor = True
        '
        'CheckColorText
        '
        Me.CheckColorText.AutoSize = True
        Me.CheckColorText.Location = New System.Drawing.Point(3, 39)
        Me.CheckColorText.Name = "CheckColorText"
        Me.CheckColorText.Size = New System.Drawing.Size(110, 17)
        Me.CheckColorText.TabIndex = 5
        Me.CheckColorText.Text = "Cambiar color text"
        Me.CheckColorText.UseVisualStyleBackColor = True
        '
        'CheckColorFondo
        '
        Me.CheckColorFondo.AutoSize = True
        Me.CheckColorFondo.Location = New System.Drawing.Point(3, 80)
        Me.CheckColorFondo.Name = "CheckColorFondo"
        Me.CheckColorFondo.Size = New System.Drawing.Size(125, 17)
        Me.CheckColorFondo.TabIndex = 6
        Me.CheckColorFondo.Text = "Cambia color de fons"
        Me.CheckColorFondo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 343)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TipoLetra As System.Windows.Forms.RadioButton
    Friend WithEvents ColorTexto As System.Windows.Forms.RadioButton
    Friend WithEvents ColorFondo As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UtilitzacioRadioButton As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckColorFondo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckColorText As System.Windows.Forms.CheckBox
    Friend WithEvents CheckCambiarLetra As System.Windows.Forms.CheckBox
    Friend WithEvents UtilitzacioCheckBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
