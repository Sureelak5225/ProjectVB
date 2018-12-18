<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYearSalary = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblAllIncome = New System.Windows.Forms.Label()
        Me.lblAllowance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radShortDate = New System.Windows.Forms.RadioButton()
        Me.radGenDate = New System.Windows.Forms.RadioButton()
        Me.radLongDate = New System.Windows.Forms.RadioButton()
        Me.btnCalTax = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษี (อย่างหยาบ)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "วันที่"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "เงินเดือน"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ยอดขายทั้งปี"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "เงินเดือนทั้งปี"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "รับเงินโบนัส"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "รวมรายได้"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "หักค่าลดหย่อน"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(88, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ภาษีที่ต้องชำระ"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.DarkGray
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDate.Location = New System.Drawing.Point(294, 83)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(189, 23)
        Me.lblDate.TabIndex = 2
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblYearSalary
        '
        Me.lblYearSalary.BackColor = System.Drawing.Color.DarkGray
        Me.lblYearSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblYearSalary.Location = New System.Drawing.Point(294, 204)
        Me.lblYearSalary.Name = "lblYearSalary"
        Me.lblYearSalary.Size = New System.Drawing.Size(189, 23)
        Me.lblYearSalary.TabIndex = 2
        Me.lblYearSalary.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.Color.DarkGray
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBonus.Location = New System.Drawing.Point(294, 244)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(189, 23)
        Me.lblBonus.TabIndex = 2
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAllIncome
        '
        Me.lblAllIncome.BackColor = System.Drawing.Color.DarkGray
        Me.lblAllIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAllIncome.Location = New System.Drawing.Point(294, 288)
        Me.lblAllIncome.Name = "lblAllIncome"
        Me.lblAllIncome.Size = New System.Drawing.Size(189, 23)
        Me.lblAllIncome.TabIndex = 2
        Me.lblAllIncome.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAllowance
        '
        Me.lblAllowance.BackColor = System.Drawing.Color.DarkGray
        Me.lblAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAllowance.Location = New System.Drawing.Point(294, 331)
        Me.lblAllowance.Name = "lblAllowance"
        Me.lblAllowance.Size = New System.Drawing.Size(189, 23)
        Me.lblAllowance.TabIndex = 2
        Me.lblAllowance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.DarkGray
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax.Location = New System.Drawing.Point(294, 372)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(189, 23)
        Me.lblTax.TabIndex = 2
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(293, 129)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(188, 26)
        Me.txtSalary.TabIndex = 0
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSale
        '
        Me.txtSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSale.Location = New System.Drawing.Point(293, 165)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(188, 26)
        Me.txtSale.TabIndex = 1
        Me.txtSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radLongDate)
        Me.GroupBox1.Controls.Add(Me.radGenDate)
        Me.GroupBox1.Controls.Add(Me.radShortDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(534, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 135)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'radShortDate
        '
        Me.radShortDate.AutoSize = True
        Me.radShortDate.Location = New System.Drawing.Point(17, 39)
        Me.radShortDate.Name = "radShortDate"
        Me.radShortDate.Size = New System.Drawing.Size(162, 24)
        Me.radShortDate.TabIndex = 0
        Me.radShortDate.TabStop = True
        Me.radShortDate.Text = "วันที่แบบ Short Date"
        Me.radShortDate.UseVisualStyleBackColor = True
        '
        'radGenDate
        '
        Me.radGenDate.AutoSize = True
        Me.radGenDate.Location = New System.Drawing.Point(17, 69)
        Me.radGenDate.Name = "radGenDate"
        Me.radGenDate.Size = New System.Drawing.Size(180, 24)
        Me.radGenDate.TabIndex = 0
        Me.radGenDate.TabStop = True
        Me.radGenDate.Text = "วันที่แบบ General Date"
        Me.radGenDate.UseVisualStyleBackColor = True
        '
        'radLongDate
        '
        Me.radLongDate.AutoSize = True
        Me.radLongDate.Location = New System.Drawing.Point(17, 99)
        Me.radLongDate.Name = "radLongDate"
        Me.radLongDate.Size = New System.Drawing.Size(159, 24)
        Me.radLongDate.TabIndex = 0
        Me.radLongDate.TabStop = True
        Me.radLongDate.Text = "วันที่แบบ Long Date"
        Me.radLongDate.UseVisualStyleBackColor = True
        '
        'btnCalTax
        '
        Me.btnCalTax.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalTax.Location = New System.Drawing.Point(576, 276)
        Me.btnCalTax.Name = "btnCalTax"
        Me.btnCalTax.Size = New System.Drawing.Size(173, 78)
        Me.btnCalTax.TabIndex = 5
        Me.btnCalTax.Text = "คำนวณ"
        Me.btnCalTax.UseVisualStyleBackColor = False
        '
        'frmJob4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalTax)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAllowance)
        Me.Controls.Add(Me.lblAllIncome)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblYearSalary)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJob4"
        Me.Text = "frmJob4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblYearSalary As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblAllIncome As Label
    Friend WithEvents lblAllowance As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radLongDate As RadioButton
    Friend WithEvents radGenDate As RadioButton
    Friend WithEvents radShortDate As RadioButton
    Friend WithEvents btnCalTax As Button
End Class
