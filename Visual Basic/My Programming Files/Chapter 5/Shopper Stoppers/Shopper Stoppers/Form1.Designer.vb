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
        Me.totalTextbox = New System.Windows.Forms.TextBox()
        Me.basicRadioButton = New System.Windows.Forms.RadioButton()
        Me.standardRadioButton = New System.Windows.Forms.RadioButton()
        Me.premiumRadioButton = New System.Windows.Forms.RadioButton()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rewardLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'totalTextbox
        '
        Me.totalTextbox.Location = New System.Drawing.Point(24, 41)
        Me.totalTextbox.Name = "totalTextbox"
        Me.totalTextbox.Size = New System.Drawing.Size(100, 20)
        Me.totalTextbox.TabIndex = 0
        '
        'basicRadioButton
        '
        Me.basicRadioButton.AutoSize = True
        Me.basicRadioButton.Location = New System.Drawing.Point(152, 44)
        Me.basicRadioButton.Name = "basicRadioButton"
        Me.basicRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.basicRadioButton.TabIndex = 1
        Me.basicRadioButton.TabStop = True
        Me.basicRadioButton.Text = "Basic"
        Me.basicRadioButton.UseVisualStyleBackColor = True
        '
        'standardRadioButton
        '
        Me.standardRadioButton.AutoSize = True
        Me.standardRadioButton.Location = New System.Drawing.Point(152, 67)
        Me.standardRadioButton.Name = "standardRadioButton"
        Me.standardRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.standardRadioButton.TabIndex = 2
        Me.standardRadioButton.TabStop = True
        Me.standardRadioButton.Text = "Standard"
        Me.standardRadioButton.UseVisualStyleBackColor = True
        '
        'premiumRadioButton
        '
        Me.premiumRadioButton.AutoSize = True
        Me.premiumRadioButton.Location = New System.Drawing.Point(152, 90)
        Me.premiumRadioButton.Name = "premiumRadioButton"
        Me.premiumRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.premiumRadioButton.TabIndex = 3
        Me.premiumRadioButton.TabStop = True
        Me.premiumRadioButton.Text = "Premium"
        Me.premiumRadioButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(24, 153)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(100, 40)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(130, 153)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 40)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(24, 199)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(206, 32)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Monthly Purchase:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Reward Points:"
        '
        'rewardLabel
        '
        Me.rewardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rewardLabel.Location = New System.Drawing.Point(24, 106)
        Me.rewardLabel.Name = "rewardLabel"
        Me.rewardLabel.Size = New System.Drawing.Size(100, 23)
        Me.rewardLabel.TabIndex = 9
        Me.rewardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 264)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rewardLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.premiumRadioButton)
        Me.Controls.Add(Me.standardRadioButton)
        Me.Controls.Add(Me.basicRadioButton)
        Me.Controls.Add(Me.totalTextbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents totalTextbox As TextBox
    Friend WithEvents basicRadioButton As RadioButton
    Friend WithEvents standardRadioButton As RadioButton
    Friend WithEvents premiumRadioButton As RadioButton
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rewardLabel As Label
    Friend WithEvents Label4 As Label
End Class
