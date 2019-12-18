Public Class Form1
    Dim a, b, c As Integer


    ' 开始按钮
    Private Sub Command1_Click() Handles Command1.Click
        Timer1.Enabled = True
        ' 倒计时是红灯的时间
        Label4.Text = TextBox1.Text
        Label4.ForeColor = System.Drawing.Color.Red
        '红灯可见
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False

        ' 获取
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

    End Sub
    ' 结束按钮
    Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label4.Text = ""

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Val(TextBox1.Text) - 1
        Label4.ForeColor = System.Drawing.Color.Red
        Label4.Text = Val(TextBox1.Text)
        If TextBox1.Text = 0 Then
            TextBox2.Text = b
            Label4.ForeColor = System.Drawing.Color.Yellow
            Label4.Text = b
            Timer2.Enabled = True
            Timer1.Enabled = False
            PictureBox2.Visible = True
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextBox2.Text = Val(TextBox2.Text) - 1
        Label4.ForeColor = System.Drawing.Color.Yellow
        Label4.Text = Val(TextBox2.Text)
        If TextBox2.Text = 0 Then
            TextBox2.Text = c
            Label4.ForeColor = System.Drawing.Color.Green
            Label4.Text = c
            Timer3.Enabled = True
            Timer2.Enabled = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            TextBox1.Text = a
            TextBox2.Text = b
            TextBox3.Text = c
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        TextBox3.Text = Val(TextBox3.Text) - 1
        Label4.Text = Val(TextBox3.Text)
        Label4.ForeColor = System.Drawing.Color.Green
        If TextBox3.Text = 0 Then
            TextBox3.Text = a
            Label4.ForeColor = System.Drawing.Color.Red
            Label4.Text = a
            Timer1.Enabled = True
            Timer3.Enabled = False
            PictureBox1.Visible = True
            PictureBox3.Visible = False
        End If
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
