Public Class frmLab7
    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.TextLength Then
            btnAdd.Enabled = True

        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Text = ""
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim R As Integer = lstAdd.SelectedIndex
        cboOutput.Items.Add(lstAdd.SelectedItem)
        cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        lstAdd.Items.RemoveAt(R)

        If lstAdd.Items.Count <> 0 Then
            If lstAdd.Items.Count <= R Then
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.SelectedIndex = R
            End If

        End If
    End Sub



    Private Sub btnMoveAll_Click_1(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        Dim i As Integer
        For i = 0 To lstAdd.Items.Count - 1
            cboOutput.Items.Add(lstAdd.Items(i))
        Next
        lstAdd.Items.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim D As Integer = cboOutput.SelectedIndex
        lstAdd.Items.Add(cboOutput.SelectedItem)
        cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        cboOutput.Items.RemoveAt(D)

        If cboOutput.Items.Count <> 0 Then
            If cboOutput.Items.Count >= D Then
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                cboOutput.SelectedIndex = D
            End If
        End If

    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        Dim i As Integer
        For i = 0 To cboOutput.Items.Count - 1
            lstAdd.Items.Add(cboOutput.Items(i))
        Next
        cboOutput.Items.Clear()
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class