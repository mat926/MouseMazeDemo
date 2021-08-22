Public Class fullversion

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub fullversion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox3.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If MsgBox("Hello, thank you for your interested in buying MouseMaze. As of 8-14-2013 MouseMaze is still in developement and I have not finished working on it yet. However , you may still preorder the game. If you do, you will then be redirected to Paypal to where you can make your purchase. Please make sure that you enter in the CORRECT email address, because that is where the game will be sent once MouseMaze is available. Thank you for your time! " & vbNewLine _
                  & vbNewLine _
                & "Would you like to proceed with your preorder now?", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BR95QZE8CZNKN")
        Else
        End If
    End Sub
End Class