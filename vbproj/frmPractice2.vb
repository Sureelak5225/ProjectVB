Public Class frmPractice2
    Private Sub radUS_CheckedChanged(sender As Object, e As EventArgs) Handles radUS.CheckedChanged
        lblResult.Text = Val(txtBath.Text) / 39
    End Sub

    Private Sub radFrench_CheckedChanged(sender As Object, e As EventArgs) Handles radFrench.CheckedChanged
        lblResult.Text = Val(txtBath.Text) / 37
    End Sub
    Private Sub radKorea_CheckedChanged(sender As Object, e As EventArgs) Handles radKorea.CheckedChanged
        lblResult.Text = Val(txtBath.Text) / 30
    End Sub

    Private Sub radLock_CheckedChanged(sender As Object, e As EventArgs) Handles radLock.CheckedChanged
        txtBath.Enabled = False
        radUS.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub radUnLock_CheckedChanged(sender As Object, e As EventArgs) Handles radUnLock.CheckedChanged
        txtBath.Enabled = True
        radUS.Enabled = True
        radFrench.Enabled = True
        radKorea.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class