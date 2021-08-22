Public Class Form34

    Private Sub Form34_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TabControl1.TabPages.Remove(TabPage3)
        MoveToStart()
    End Sub

    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs)
        PictureBox1.Hide()
        Label18.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs)
        PictureBox2.Hide()
        Label7.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            TabControl1.TabPages.Add(TabPage3)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Hide()
        Label29.Hide()
    End Sub

    Private Sub Label31_Click(sender As System.Object, e As System.EventArgs) Handles Label31.Click

    End Sub

    Private Sub Label31_MouseEnter(sender As Object, e As System.EventArgs) Handles Label31.MouseEnter

        Dim startingPoint = Label30.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer2.Start()
        Button2.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button2.Text -= 1
        If Button2.Text = 0 Then
            Timer2.Stop()
            timer3.start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label33.Height = Label33.Height - 1
        If Label33.Height = 0 Then
            Timer3.Stop()
        End If
    End Sub

    Private Sub Label35_MouseEnter(sender As Object, e As System.EventArgs) Handles Label35.MouseEnter
        Label35.Hide()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As System.EventArgs) Handles Label5.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As System.EventArgs) Handles Label6.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As System.EventArgs) Handles Label7.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As System.EventArgs) Handles Label8.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label16.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As System.EventArgs) Handles Label10.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As System.EventArgs) Handles Label12.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As System.EventArgs) Handles Label13.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As System.EventArgs) Handles Label14.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As System.EventArgs) Handles Label15.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label16_MouseEnter(sender As Object, e As System.EventArgs) Handles Label16.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label17_MouseEnter(sender As Object, e As System.EventArgs) Handles Label17.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label18_MouseEnter(sender As Object, e As System.EventArgs) Handles Label18.MouseEnter, Label8.MouseEnter, Label17.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label19_MouseEnter(sender As Object, e As System.EventArgs) Handles Label19.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As System.EventArgs) Handles Label20.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As System.EventArgs) Handles Label21.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label22_MouseEnter(sender As Object, e As System.EventArgs) Handles Label22.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label23_MouseEnter(sender As Object, e As System.EventArgs) Handles Label23.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label24_MouseEnter(sender As Object, e As System.EventArgs) Handles Label24.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label25_MouseEnter(sender As Object, e As System.EventArgs) Handles Label25.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        If Label35.Visible = False Then
            MsgBox("Level Cleared", MsgBoxStyle.Information)
            ad9.Show()

            Me.Close()
        End If
    End Sub

    Private Sub Label26_MouseEnter(sender As Object, e As System.EventArgs) Handles Label26.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label27_MouseEnter(sender As Object, e As System.EventArgs) Handles Label27.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label27_MouseHover(sender As Object, e As System.EventArgs) Handles Label27.MouseHover

    End Sub

    Private Sub Label28_MouseEnter(sender As Object, e As System.EventArgs) Handles Label28.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label29_MouseEnter(sender As Object, e As System.EventArgs) Handles Label29.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label30_MouseEnter(sender As Object, e As System.EventArgs) Handles Label30.MouseEnter

    End Sub

    Private Sub Label32_MouseEnter(sender As Object, e As System.EventArgs) Handles Label32.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label33_MouseEnter(sender As Object, e As System.EventArgs) Handles Label33.MouseEnter, MyBase.MouseEnter, Label9.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label34.MouseEnter, Label32.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label15.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label34_MouseEnter(sender As Object, e As System.EventArgs) Handles Label34.MouseEnter
        If Label35.Visible = True Then
            MoveToStart()

        End If
    End Sub

    Private Sub Label30_Click(sender As System.Object, e As System.EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form34_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form34_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
   
    End Sub

    Private Sub PictureBox1_MouseEnter_1(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label18.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter1(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label7.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub
End Class