Public Class ad9

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Button1.Text = "Continue"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        level10.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        fullversion.Show()
    End Sub
End Class