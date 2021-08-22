Public Class Form16

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = TrackBar1.Maximum Then
            Label3.Show()
            Label5.Show()
            Label4.Show()
            Label6.Show()
            Label7.Show()
            TrackBar2.Show()
        End If
    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        TrackBar2.Hide()
        TrackBar3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label2.Hide()
        Label3.Hide()
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        If TrackBar2.Value = TrackBar2.Maximum Then
            Label7.Hide()
            Label8.Show()
            Label9.Show()
            Label10.Show()
            TrackBar3.Show()

        End If
    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar3.Scroll
        If TrackBar3.Value = TrackBar3.Minimum Then
            Label10.Hide()
            Label2.Show()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(30, 30)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Form16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.Enter

    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared.", MsgBoxStyle.Information)
        Me.Close()

        ad5.Show()
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form16_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        
    End Sub
End Class