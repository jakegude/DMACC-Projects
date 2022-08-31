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
        Me.PennyTextbox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dollarLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PennyTextbox
        '
        Me.PennyTextbox.Location = New System.Drawing.Point(15, 25)
        Me.PennyTextbox.Name = "PennyTextbox"
        Me.PennyTextbox.Size = New System.Drawing.Size(100, 20)
        Me.PennyTextbox.TabIndex = 0
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(146, 42)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(98, 46)
        Me.calcButton.TabIndex = 1
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(146, 108)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(98, 46)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(146, 187)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(98, 46)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number Of Pennies"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dollars"
        '
        'dollarLabel
        '
        Me.dollarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dollarLabel.Location = New System.Drawing.Point(15, 72)
        Me.dollarLabel.Name = "dollarLabel"
        Me.dollarLabel.Size = New System.Drawing.Size(100, 21)
        Me.dollarLabel.TabIndex = 6
        Me.dollarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quarters"
        '
        'QLabel
        '
        Me.QLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QLabel.Location = New System.Drawing.Point(15, 121)
        Me.QLabel.Name = "QLabel"
        Me.QLabel.Size = New System.Drawing.Size(100, 21)
        Me.QLabel.TabIndex = 8
        Me.QLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Dimes"
        '
        'DLabel
        '
        Me.DLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DLabel.Location = New System.Drawing.Point(15, 171)
        Me.DLabel.Name = "DLabel"
        Me.DLabel.Size = New System.Drawing.Size(100, 21)
        Me.DLabel.TabIndex = 10
        Me.DLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Nickels"
        '
        'NLabel
        '
        Me.NLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NLabel.Location = New System.Drawing.Point(15, 217)
        Me.NLabel.Name = "NLabel"
        Me.NLabel.Size = New System.Drawing.Size(100, 21)
        Me.NLabel.TabIndex = 12
        Me.NLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Pennies"
        '
        'PLabel
        '
        Me.PLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLabel.Location = New System.Drawing.Point(15, 268)
        Me.PLabel.Name = "PLabel"
        Me.PLabel.Size = New System.Drawing.Size(100, 21)
        Me.PLabel.TabIndex = 14
        Me.PLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(128, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 307)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.QLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dollarLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.PennyTextbox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Penny Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PennyTextbox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dollarLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents QLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PLabel As Label
    Friend WithEvents Label12 As Label
End Class
