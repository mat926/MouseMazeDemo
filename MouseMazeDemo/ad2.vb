Public Class ad2

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Button1.Text = "Continue"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("http://www.points2shop.com?ref=uin1265050827")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        fullversion.Show()
    End Sub
End Class