Public Class Form25

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        ad7.Show()
        Me.Close()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form25_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 100 Then
            Label6.Hide()
        End If
    End Sub

    Private Sub Label8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label8.MouseEnter
        Dim startingPoint = Label9.Location
        startingPoint.Offset(25, 25)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Button1.Enabled = False
            Label12.Show()
        End If
    End Sub

    Private Sub Label9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter
        If Button1.Text = 0 Then
            Dim startingPoint = Label13.Location
            startingPoint.Offset(25, 25)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label15.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub Form25_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
End Class