<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cobSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(170, 66)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(305, 98)
        Me.txtInput.TabIndex = 0
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDown.Location = New System.Drawing.Point(474, 116)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(46, 48)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'cobSize
        '
        Me.cobSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cobSize.FormattingEnabled = True
        Me.cobSize.IntegralHeight = False
        Me.cobSize.Items.AddRange(New Object() {"12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.cobSize.Location = New System.Drawing.Point(430, 170)
        Me.cobSize.Name = "cobSize"
        Me.cobSize.Size = New System.Drawing.Size(90, 26)
        Me.cobSize.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFSky
        '
        Me.lblFSky.AutoSize = True
        Me.lblFSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblFSky.Location = New System.Drawing.Point(191, 64)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(37, 39)
        Me.lblFSky.TabIndex = 0
        Me.lblFSky.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFWhite
        '
        Me.lblFWhite.AutoSize = True
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Location = New System.Drawing.Point(148, 64)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(37, 39)
        Me.lblFWhite.TabIndex = 0
        Me.lblFWhite.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFBrown
        '
        Me.lblFBrown.AutoSize = True
        Me.lblFBrown.BackColor = System.Drawing.Color.Brown
        Me.lblFBrown.Location = New System.Drawing.Point(105, 64)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(37, 39)
        Me.lblFBrown.TabIndex = 0
        Me.lblFBrown.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFYellow
        '
        Me.lblFYellow.AutoSize = True
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(61, 64)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(37, 39)
        Me.lblFYellow.TabIndex = 0
        Me.lblFYellow.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFOrange
        '
        Me.lblFOrange.AutoSize = True
        Me.lblFOrange.BackColor = System.Drawing.Color.Orange
        Me.lblFOrange.Location = New System.Drawing.Point(18, 64)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(37, 39)
        Me.lblFOrange.TabIndex = 0
        Me.lblFOrange.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFBlack
        '
        Me.lblFBlack.AutoSize = True
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(191, 21)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(37, 39)
        Me.lblFBlack.TabIndex = 0
        Me.lblFBlack.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFViolet
        '
        Me.lblFViolet.AutoSize = True
        Me.lblFViolet.BackColor = System.Drawing.Color.Violet
        Me.lblFViolet.Location = New System.Drawing.Point(148, 21)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(37, 39)
        Me.lblFViolet.TabIndex = 0
        Me.lblFViolet.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFGreen
        '
        Me.lblFGreen.AutoSize = True
        Me.lblFGreen.BackColor = System.Drawing.Color.Green
        Me.lblFGreen.Location = New System.Drawing.Point(105, 21)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(37, 39)
        Me.lblFGreen.TabIndex = 0
        Me.lblFGreen.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFBlue
        '
        Me.lblFBlue.AutoSize = True
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(61, 21)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(37, 39)
        Me.lblFBlue.TabIndex = 0
        Me.lblFBlue.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFRed
        '
        Me.lblFRed.AutoSize = True
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(18, 21)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(37, 39)
        Me.lblFRed.TabIndex = 0
        Me.lblFRed.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBWhite)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 120)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblBSky
        '
        Me.lblBSky.AutoSize = True
        Me.lblBSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblBSky.Location = New System.Drawing.Point(199, 64)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(37, 39)
        Me.lblBSky.TabIndex = 0
        Me.lblBSky.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBGreen
        '
        Me.lblBGreen.AutoSize = True
        Me.lblBGreen.BackColor = System.Drawing.Color.Green
        Me.lblBGreen.Location = New System.Drawing.Point(113, 21)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(37, 39)
        Me.lblBGreen.TabIndex = 0
        Me.lblBGreen.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBWhite
        '
        Me.lblBWhite.AutoSize = True
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.Location = New System.Drawing.Point(156, 64)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(37, 39)
        Me.lblBWhite.TabIndex = 0
        Me.lblBWhite.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBRed
        '
        Me.lblBRed.AutoSize = True
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(26, 21)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(37, 39)
        Me.lblBRed.TabIndex = 0
        Me.lblBRed.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBBrown
        '
        Me.lblBBrown.AutoSize = True
        Me.lblBBrown.BackColor = System.Drawing.Color.Brown
        Me.lblBBrown.Location = New System.Drawing.Point(113, 64)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(37, 39)
        Me.lblBBrown.TabIndex = 0
        Me.lblBBrown.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBBlue
        '
        Me.lblBBlue.AutoSize = True
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(69, 21)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(37, 39)
        Me.lblBBlue.TabIndex = 0
        Me.lblBBlue.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBYellow
        '
        Me.lblBYellow.AutoSize = True
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(69, 64)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(37, 39)
        Me.lblBYellow.TabIndex = 0
        Me.lblBYellow.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBViolet
        '
        Me.lblBViolet.AutoSize = True
        Me.lblBViolet.BackColor = System.Drawing.Color.Violet
        Me.lblBViolet.Location = New System.Drawing.Point(156, 21)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(37, 39)
        Me.lblBViolet.TabIndex = 0
        Me.lblBViolet.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBOrange
        '
        Me.lblBOrange.AutoSize = True
        Me.lblBOrange.BackColor = System.Drawing.Color.Orange
        Me.lblBOrange.Location = New System.Drawing.Point(26, 64)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(37, 39)
        Me.lblBOrange.TabIndex = 0
        Me.lblBOrange.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBBlack
        '
        Me.lblBBlack.AutoSize = True
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(199, 21)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(37, 39)
        Me.lblBBlack.TabIndex = 0
        Me.lblBBlack.Text = "          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ขนาดฟอนต์"
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUp.Location = New System.Drawing.Point(474, 65)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(46, 52)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 391)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cobSize)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmLab3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnDown As Button
    Friend WithEvents cobSize As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFRed As Label
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBWhite As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents btnUp As Button
End Class
