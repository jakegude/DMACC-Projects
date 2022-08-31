<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.depositTextBox = New System.Windows.Forms.TextBox()
        Me.rateTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.balanceLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Deposit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Annual interest rate (.00):"
        '
        'depositTextBox
        '
        Me.depositTextBox.Location = New System.Drawing.Point(47, 53)
        Me.depositTextBox.Name = "depositTextBox"
        Me.depositTextBox.Size = New System.Drawing.Size(100, 27)
        Me.depositTextBox.TabIndex = 1
        '
        'rateTextBox
        '
        Me.rateTextBox.Location = New System.Drawing.Point(169, 53)
        Me.rateTextBox.Name = "rateTextBox"
        Me.rateTextBox.Size = New System.Drawing.Size(50, 27)
        Me.rateTextBox.TabIndex = 3
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(359, 29)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(144, 29)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate Balance"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(359, 64)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(144, 29)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'balanceLabel
        '
        Me.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.balanceLabel.Location = New System.Drawing.Point(47, 134)
        Me.balanceLabel.Name = "balanceLabel"
        Me.balanceLabel.Size = New System.Drawing.Size(456, 65)
        Me.balanceLabel.TabIndex = 6
        Me.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 234)
        Me.Controls.Add(Me.balanceLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.rateTextBox)
        Me.Controls.Add(Me.depositTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Savers Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents depositTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents balanceLabel As System.Windows.Forms.Label

End Class
