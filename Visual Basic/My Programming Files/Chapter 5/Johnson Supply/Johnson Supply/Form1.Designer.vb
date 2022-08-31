<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.unitsTextbox = New System.Windows.Forms.TextBox()
        Me.wholesaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.retailerRadioButton = New System.Windows.Forms.RadioButton()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.orderLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'unitsTextbox
        '
        Me.unitsTextbox.Location = New System.Drawing.Point(24, 28)
        Me.unitsTextbox.Name = "unitsTextbox"
        Me.unitsTextbox.Size = New System.Drawing.Size(100, 20)
        Me.unitsTextbox.TabIndex = 0
        '
        'wholesaleRadioButton
        '
        Me.wholesaleRadioButton.AutoSize = True
        Me.wholesaleRadioButton.Location = New System.Drawing.Point(160, 28)
        Me.wholesaleRadioButton.Name = "wholesaleRadioButton"
        Me.wholesaleRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.wholesaleRadioButton.TabIndex = 1
        Me.wholesaleRadioButton.TabStop = True
        Me.wholesaleRadioButton.Text = "Wholesaler"
        Me.wholesaleRadioButton.UseVisualStyleBackColor = True
        '
        'retailerRadioButton
        '
        Me.retailerRadioButton.AutoSize = True
        Me.retailerRadioButton.Location = New System.Drawing.Point(160, 52)
        Me.retailerRadioButton.Name = "retailerRadioButton"
        Me.retailerRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.retailerRadioButton.TabIndex = 2
        Me.retailerRadioButton.TabStop = True
        Me.retailerRadioButton.Text = "Retailer"
        Me.retailerRadioButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(24, 158)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(103, 44)
        Me.calcButton.TabIndex = 3
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(138, 158)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 44)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(24, 208)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(214, 38)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Units:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Order Price:"
        '
        'orderLabel
        '
        Me.orderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.orderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderLabel.Location = New System.Drawing.Point(24, 97)
        Me.orderLabel.Name = "orderLabel"
        Me.orderLabel.Size = New System.Drawing.Size(214, 49)
        Me.orderLabel.TabIndex = 8
        Me.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 277)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.orderLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.retailerRadioButton)
        Me.Controls.Add(Me.wholesaleRadioButton)
        Me.Controls.Add(Me.unitsTextbox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Johnson Supply"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents unitsTextbox As TextBox
    Friend WithEvents wholesaleRadioButton As RadioButton
    Friend WithEvents retailerRadioButton As RadioButton
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents orderLabel As Label
    Friend WithEvents Label4 As Label
End Class
