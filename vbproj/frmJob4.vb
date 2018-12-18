Public Class frmJob4
    Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim decR_Bonus As Decimal = 0.2
        Dim decR_Allow As Decimal = 0.01
        Dim decR_Tax As Decimal = 0.07
        Dim NowDate As Date = Date.Now


        dblYearSalary = txtSalary.Text * 12
        dblBonus = txtSale.Text * decR_Bonus
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_Allow
        dblTax = (dblAllIncome - dblAllowance) * decR_Tax

        lblYearSalary.Text = dblYearSalary.ToString("#,###")
        lblBonus.Text = dblBonus.ToString("#,###")
        lblAllIncome.Text = dblAllIncome.ToString("#,###")
        lblAllowance.Text = dblAllowance.ToString("#,###")
        lblTax.Text = dblTax.ToString("#,###.##")



    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now

    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Format(Now, "Short date")
    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = Format(Now, "General date")
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Format(Now, "Long date")
    End Sub
End Class