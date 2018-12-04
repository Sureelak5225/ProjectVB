Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblSalaryYear.Text = txtSalary.Text * 12
        lblTax.Text = lblSalaryYear.Text * 0.05
        lblAfterTax.Text = lblSalaryYear.Text - lblTax.Text
    End Sub
End Class
