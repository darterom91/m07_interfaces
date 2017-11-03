Module primer
    Function primo(ByVal num As Integer) As String
        Dim i As Integer = 1
        Dim cont As Integer
        Dim res As String
        'bucle'
        For i = i To num
            If num Mod i = 0 Then
                cont = cont + 1
            ElseIf num Mod i = 0 Then
                cont = cont + 1
            End If
        Next
        'comprovar cont'
        If cont > 2 Then
            res = "primer"
            Return res
        Else
            res = "no primer"
            Return res
        End If

        Return 0
    End Function
End Module

Module primer2

    Sub prim(ByVal num As Integer, ByRef res As String)
        Dim i As Integer = 1
        Dim cont As Integer
        'bucles'
        For i = i To num
            If num Mod i = 0 Then
                cont = cont + 1
            ElseIf num Mod i = 0 Then
                cont = cont + 1
            End If
        Next
        'comprovar contador'
        If cont > 2 Then
            res = "primer"
        Else
            res = "no primer"
        End If

    End Sub

End Module

Module comprovar_num


    Function comprovar(ByVal num As Integer, ByRef res As String) As String
        If num > 1000 Then
            comprovar = "numero no correcto"
        End If
    End Function


End Module
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim res As String
        Dim num As Integer
        num = Val(Me.TextBox1.Text)
        If num > 1000 Then
            TextBox2.Text = comprovar_num.comprovar(num, res)
        Else
            res = primer.primo(num)
            Me.TextBox2.Text = res
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim res As String
        Dim num As Integer
        num = Val(Me.TextBox1.Text)

        If num > 1000 Then
            TextBox2.Text = comprovar_num.comprovar(num, res)
        Else
            primer2.prim(num, res)
            Me.TextBox2.Text = res
        End If

    End Sub
End Class
