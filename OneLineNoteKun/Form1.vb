Public Class Form1
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' サイズ変更不可の直線ウィンドウに変更する
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        'フォームが最大化されないようにする
        Me.MaximizeBox = False
        'フォームが最小化されないようにする
        Me.MinimizeBox = False

        My.Settings("tb1") = TextBox1.Text
        My.Settings("tb2") = TextBox2.Text
        My.Settings("tb3") = TextBox3.Text
        My.Settings("tb4") = TextBox4.Text
        My.Settings("tb5") = TextBox5.Text
        My.Settings("tb6") = TextBox6.Text
        My.Settings("tb7") = TextBox7.Text
        My.Settings("tb8") = TextBox8.Text
        My.Settings("tb9") = TextBox9.Text
        My.Settings("tb10") = TextBox10.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = My.Settings.tb1
        TextBox2.Text = My.Settings.tb2
        TextBox3.Text = My.Settings.tb3
        TextBox4.Text = My.Settings.tb4
        TextBox5.Text = My.Settings.tb5
        TextBox6.Text = My.Settings.tb6
        TextBox7.Text = My.Settings.tb7
        TextBox8.Text = My.Settings.tb8
        TextBox9.Text = My.Settings.tb9
        TextBox10.Text = My.Settings.tb10
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox3.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clipboard.SetText(TextBox4.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clipboard.SetText(TextBox5.Text)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Clipboard.SetText(TextBox6.Text)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Clipboard.SetText(TextBox7.Text)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Clipboard.SetText(TextBox8.Text)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Clipboard.SetText(TextBox9.Text)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Clipboard.SetText(TextBox10.Text)

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        'フォームが最小化、最大化された時は、元の状態に戻す
        If Me.WindowState = FormWindowState.Minimized OrElse
            Me.WindowState = FormWindowState.Maximized Then

            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
