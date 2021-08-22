Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label21.Hide()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label22.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        Label27.Hide()
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        Label26.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        Label24.Hide()
        PictureBox6.Hide()
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        Label20.Hide()
        PictureBox7.Hide()
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        ad3.Show()
        Me.Close()
    End Sub

    Private Sub Label10_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label23.Hide()
        PictureBox2.Hide()
    End Sub
End Class