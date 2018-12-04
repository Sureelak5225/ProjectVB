Public Class frmLab2
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim SalesCom As Double
        Dim SalesPrinter As Double
        Dim TotalSales As Double
        Dim CommisCom As Double
        Dim CommisPrinter As Double
        Dim TotalCommis As Double

        SalesCom = Val(txtSalesCom.Text)
        SalesPrinter = Val(txtSalesPrinter.Text)

        TotalSales = SalesCom + SalesPrinter
        CommisCom = SalesCom * 0.05
        CommisPrinter = SalesPrinter * 0.1

        lblTotalSales.Text = TotalSales
        lblCommisPrinter.Text = CommisPrinter
        lblCommisCom.Text = CommisCom
        lblTotalCommis.Text = CommisCom + CommisPrinter


    End Sub
End Class