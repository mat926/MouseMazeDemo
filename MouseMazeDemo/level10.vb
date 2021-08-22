Public Class level10

    Private Sub level10_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label49.Location
        startingPoint.Offset(5, 5)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub level10_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label51_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label51.MouseEnter
        Dim startingPoint = Label66.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label52_Click(sender As System.Object, e As System.EventArgs) Handles Label52.Click

    End Sub

    Private Sub Label52_MouseEnter(sender As Object, e As System.EventArgs) Handles Label52.MouseEnter
        Dim startingPoint = Label67.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label58_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label58.MouseEnter
        Dim startingPoint = Label68.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label59_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label59.MouseEnter
        Dim startingPoint = Label69.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label53_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label53.MouseEnter
        Dim startingPoint = Label70.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label60_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label60.MouseEnter
        Dim startingPoint = Label71.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label54_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label54.MouseEnter
        Dim startingPoint = Label72.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label73_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label73.MouseEnter
      
    End Sub

    Private Sub Label74_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label74.MouseEnter
        Timer1.Start()
        Label74.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label57.Width -= 1
        If Label57.Width = 0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label62.Hide()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label61.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label63.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Hide()
        Label64.Hide()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        Label65.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub Label61_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label55_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label55.MouseEnter
        Dim startingPoint = Label73.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label74_Click(sender As System.Object, e As System.EventArgs) Handles Label74.Click

    End Sub

    Private Sub Label50_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label50.MouseEnter
        MsgBox("Congratulations you completed all the levels!!! For more fun , get the full version.", MsgBoxStyle.Information)

        Form1.Show()
        fullversion.Show()

        Me.Close()
    End Sub
End Class