Public Class Form6

    Private Sub Label5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label7.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label7.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        ad2.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
End Class