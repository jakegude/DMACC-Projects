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
        Me.price1Textbox = New System.Windows.Forms.TextBox()
        Me.price2Textbox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.savingsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'price1Textbox
        '
        Me.price1Textbox.Location = New System.Drawing.Point(34, 31)
        Me.price1Textbox.Name = "price1Textbox"
        Me.price1Textbox.Size = New System.Drawing.Size(100, 20)
        Me.price1Textbox.TabIndex = 0
        Me.price1Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'price2Textbox
        '
        Me.price2Textbox.Location = New System.Drawing.Point(34, 78)
        Me.price2Textbox.Name = "price2Textbox"
        Me.price2Textbox.Size = New System.Drawing.Size(100, 20)
        Me.price2Textbox.TabIndex = 1
        Me.price2Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(152, 20)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(95, 40)
        Me.calcButton.TabIndex = 2
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(152, 78)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(95, 40)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(152, 141)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(95, 40)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(34, 130)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(100, 23)
        Me.totalLabel.TabIndex = 5
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'savingsLabel
        '
        Me.savingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.savingsLabel.Location = New System.Drawing.Point(34, 184)
        Me.savingsLabel.Name = "savingsLabel"
        Me.savingsLabel.Size = New System.Drawing.Size(100, 23)
        Me.savingsLabel.TabIndex = 6
        Me.savingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Item 1 Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Item 2 Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Due"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Savings"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 226)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.savingsLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.price2Textbox)
        Me.Controls.Add(Me.price1Textbox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Marcy's"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents price1Textbox As TextBox
    Friend WithEvents price2Textbox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents totalLabel As Label
    Friend WithEvents savingsLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
