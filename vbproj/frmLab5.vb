Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Decimal

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub







    Private Sub radMember_Click(sender As Object, e As EventArgs) Handles radMember.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

        gpbPaid.Enabled = True

    End Sub

    Private Sub radOther_Click(sender As Object, e As EventArgs) Handles radOther.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

        gpbPaid.Enabled = False
        radPaid.Checked = True
    End Sub

    Private Sub radPaid_Click(sender As Object, e As EventArgs) Handles radPaid.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_Click(sender As Object, e As EventArgs) Handles radCredit.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Product As String = txtProduct.Text
        Dim Price As Integer = Val(txtPrice.Text)
        Dim Unit As Integer = Val(txtUnit.Text)
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        decDiscount = 0

        If Product = "" Or Price <= 0 Or Unit <= 0 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked = True And radPaid.Checked Then
                If decTotal < 1000 Then
                    decDiscount = 0
                ElseIf decTotal < 5000 Then
                    decDiscount = 0.05 * decTotal
                ElseIf decTotal < 10000 Then
                    decDiscount = 0.1 * decTotal
                ElseIf decTotal >= 10000 Then
                    decDiscount = 0.15 * decTotal

                End If

                decNet = decTotal - decDiscount
                decCredit = 0

            ElseIf radMember.Checked = True And radCredit.Checked Then
                decCredit = 0
                decNet = decTotal
                decCredit = decTotal

            Else
                decDiscount = 0
                decNet = decTotal
                decCredit = 0

            End If
            lblDiscount.Text = decDiscount
            lblPaid.Text = decNet
            lblCredit.Text = decCredit

        End If



    End Sub
End Class