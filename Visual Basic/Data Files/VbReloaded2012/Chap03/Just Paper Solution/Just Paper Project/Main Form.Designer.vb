<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.totalCasesLabel = New System.Windows.Forms.Label()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.standardTextBox = New System.Windows.Forms.TextBox()
        Me.legalTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Order Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cit&y:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "S&tate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "&ZIP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(337, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "&Standard (8.5 X 11):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 107)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "&Legal (8.5 X 14):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(337, 159)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Cases ordered:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(337, 214)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total price:"
        '
        'totalCasesLabel
        '
        Me.totalCasesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalCasesLabel.Location = New System.Drawing.Point(341, 179)
        Me.totalCasesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalCasesLabel.Name = "totalCasesLabel"
        Me.totalCasesLabel.Size = New System.Drawing.Size(113, 23)
        Me.totalCasesLabel.TabIndex = 19
        Me.totalCasesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPriceLabel.Location = New System.Drawing.Point(340, 233)
        Me.totalPriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(114, 23)
        Me.totalPriceLabel.TabIndex = 21
        Me.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(24, 72)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(262, 23)
        Me.nameTextBox.TabIndex = 1
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(22, 126)
        Me.addressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(264, 23)
        Me.addressTextBox.TabIndex = 3
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(24, 177)
        Me.cityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(262, 23)
        Me.cityTextBox.TabIndex = 5
        '
        'stateTextBox
        '
        Me.stateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stateTextBox.Location = New System.Drawing.Point(24, 240)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.stateTextBox.MaxLength = 2
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(44, 23)
        Me.stateTextBox.TabIndex = 7
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(72, 240)
        Me.zipTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(64, 23)
        Me.zipTextBox.TabIndex = 9
        '
        'standardTextBox
        '
        Me.standardTextBox.Location = New System.Drawing.Point(341, 72)
        Me.standardTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.standardTextBox.Name = "standardTextBox"
        Me.standardTextBox.Size = New System.Drawing.Size(46, 23)
        Me.standardTextBox.TabIndex = 11
        '
        'legalTextBox
        '
        Me.legalTextBox.Location = New System.Drawing.Point(342, 124)
        Me.legalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.legalTextBox.Name = "legalTextBox"
        Me.legalTextBox.Size = New System.Drawing.Size(46, 23)
        Me.legalTextBox.TabIndex = 13
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(477, 54)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(140, 28)
        Me.calcButton.TabIndex = 14
        Me.calcButton.Text = "&Calculate Order"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(478, 118)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(140, 28)
        Me.clearButton.TabIndex = 16
        Me.clearButton.Text = "Clea&r Order"
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(478, 150)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(140, 28)
        Me.exitButton.TabIndex = 17
        Me.exitButton.Text = "E&xit"
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(478, 86)
        Me.printButton.Margin = New System.Windows.Forms.Padding(2)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(140, 28)
        Me.printButton.TabIndex = 15
        Me.printButton.Text = "&Print Order"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 299)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.legalTextBox)
        Me.Controls.Add(Me.standardTextBox)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.stateTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.totalPriceLabel)
        Me.Controls.Add(Me.totalCasesLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Just Paper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents totalCasesLabel As System.Windows.Forms.Label
    Friend WithEvents totalPriceLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents zipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents standardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents legalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
