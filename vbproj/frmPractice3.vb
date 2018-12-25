Public Class frmPractice3
    Private Sub แบบฝกToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles แบบฝกToolStripMenuItem.Click
        Dim frmMyP1 As frmPractice1 = New frmPractice1
        frmMyP1.Show()
    End Sub

    Private Sub แบบฝกท2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles แบบฝกท2ToolStripMenuItem.Click
        Dim frmMyP2 As frmPractice2 = New frmPractice2
        frmMyP2.Show()
    End Sub

    Private Sub ใบงานท1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท1ToolStripMenuItem.Click
        Dim frmMyL1 As Form1 = New Form1
        frmMyL1.Show()
    End Sub

    Private Sub ใบงานท2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท2ToolStripMenuItem.Click
        Dim frmMyL2 As frmLab2 = New frmLab2
        frmMyL2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class