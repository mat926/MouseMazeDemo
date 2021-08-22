Public Class Form19

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Form19_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.LostFocus

    End Sub

    Private Sub Label9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseEnter

    End Sub

    Private Sub Label5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseEnter
        Dim startingPoint = Label7.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseEnter
        Dim startingPoint = Label10.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.MouseEnter
        Dim startingPoint = Label12.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        ad6.Show()
        Me.Close()
    End Sub

    Private Sub Form19_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
   
    End Sub
End Class