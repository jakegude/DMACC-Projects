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
        Me.QuantityTextbox = New System.Windows.Forms.TextBox()
        Me.BoxTextbox = New System.Windows.Forms.TextBox()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FullLabel = New System.Windows.Forms.Label()
        Me.RemainLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FullBoxLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'QuantityTextbox
        '
        Me.QuantityTextbox.Location = New System.Drawing.Point(16, 37)
        Me.QuantityTextbox.Name = "QuantityTextbox"
        Me.QuantityTextbox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextbox.TabIndex = 0
        Me.QuantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BoxTextbox
        '
        Me.BoxTextbox.Location = New System.Drawing.Point(170, 37)
        Me.BoxTextbox.Name = "BoxTextbox"
        Me.BoxTextbox.Size = New System.Drawing.Size(100, 20)
        Me.BoxTextbox.TabIndex = 1
        Me.BoxTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(337, 37)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 2
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(337, 66)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(337, 95)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Full Boxes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Remaining"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Box Quantity"
        '
        'FullLabel
        '
        Me.FullLabel.Location = New System.Drawing.Point(19, 95)
        Me.FullLabel.Name = "FullLabel"
        Me.FullLabel.Size = New System.Drawing.Size(39, 13)
        Me.FullLabel.TabIndex = 9
        '
        'RemainLabel
        '
        Me.RemainLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RemainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RemainLabel.Location = New System.Drawing.Point(173, 109)
        Me.RemainLabel.Name = "RemainLabel"
        Me.RemainLabel.Size = New System.Drawing.Size(103, 33)
        Me.RemainLabel.TabIndex = 10
        Me.RemainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "By Jake Gudenkauf"
        '
        'FullBoxLabel
        '
        Me.FullBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FullBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FullBoxLabel.Location = New System.Drawing.Point(19, 108)
        Me.FullBoxLabel.Name = "FullBoxLabel"
        Me.FullBoxLabel.Size = New System.Drawing.Size(100, 33)
        Me.FullBoxLabel.TabIndex = 12
        Me.FullBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 167)
        Me.Controls.Add(Me.FullBoxLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RemainLabel)
        Me.Controls.Add(Me.FullLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.BoxTextbox)
        Me.Controls.Add(Me.QuantityTextbox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Colfax  Industries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuantityTextbox As TextBox
    Friend WithEvents BoxTextbox As TextBox
    Friend WithEvents CalcButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FullLabel As Label
    Friend WithEvents RemainLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FullBoxLabel As Label
End Class
