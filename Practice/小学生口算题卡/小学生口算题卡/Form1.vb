Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(4) As String
        Dim b As Integer

        ' 文本框中随机产生0-100的数字
        TextBox1.Text = Int(100 * Rnd())
        a(1) = "+"
        a(2) = "-"
        a(3) = "*"
        a(4) = "/"
        b = Int(4 * Rnd() + 1)
        ' 随机产生加减乘除
        Label1.Text = a(b)
        ' 如果是除号
        If Label1.Text = a(4) Then
            ' 产生1-100之间的随机数
            TextBox2.Text = Int((100 * Rnd()) + 1)
        Else
            TextBox2.Text = Int(100 * Rnd())
        End If
        TextBox3.Text = ""

    End Sub
    Dim z As Integer ' 总分
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As Single
        Dim x As Integer ' 正确的个数

        Dim y As Integer ' 错误的个数
        If IsNumeric(TextBox3.Text) = False Then
            'MsgBox "请输入数字！", vbOKOnly + vbExclamation, "提示 请输入数字!"
            MsgBox("请输入数字！", vbOKOnly + vbExclamation, "提示 请输入数字!")
            TextBox3.Text = ""
        Else
            Select Case Label1.Text
                Case "+"
                    c = Val(TextBox1.Text) + Val(TextBox2.Text)
                Case "-"
                    c = Val(TextBox1.Text) - Val(TextBox2.Text)
                Case "*"
                    c = Val(TextBox1.Text) * Val(TextBox2.Text)
                Case "/"
                    c = Val(TextBox1.Text) / Val(TextBox2.Text)
            End Select

            If TextBox3.Text = c Then
                MsgBox("恭喜你，回答正确!", vbOKOnly + vbInformation, "提示")
                x = x + 1
                TextBox4.Text = x
                z = z + 10
                TextBox6.Text = z
            ElseIf TextBox3.Text <> c Then
                MsgBox("回答错误！正确结果为" & c, vbOKOnly + vbCritical, "提示")
                y = y + 1
                TextBox5.Text = y
                z = z - 10
                TextBox6.Text = z


            End If

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
