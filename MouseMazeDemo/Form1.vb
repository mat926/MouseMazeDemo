Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("The Demo version of MouseMaze comes with only 10 levels. Get the full version to play over 350 levels!", MsgBoxStyle.Information)
        level1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        fullversion.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("This feature is disabled in the Demo version. Get the full version to unlock", MsgBoxStyle.Critical)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MsgBox("This feature is disabled in the Demo version. Get the full version to unlock", MsgBoxStyle.Critical)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox1.Click
        Process.Start("http://www.points2shop.com?ref=uin1265050827")
    End Sub
End Class
