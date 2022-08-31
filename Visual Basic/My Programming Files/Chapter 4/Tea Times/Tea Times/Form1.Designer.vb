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
        Me.poundsTextbox = New System.Windows.Forms.TextBox()
        Me.discountCheckbox = New System.Windows.Forms.CheckBox()
        Me.shippingCheckbox = New System.Windows.Forms.CheckBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.totaldueLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'poundsTextbox
        '
        Me.poundsTextbox.Location = New System.Drawing.Point(15, 31)
        Me.poundsTextbox.Name = "poundsTextbox"
        Me.poundsTextbox.Size = New System.Drawing.Size(100, 20)
        Me.poundsTextbox.TabIndex = 0
        Me.poundsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'discountCheckbox
        '
        Me.discountCheckbox.AutoSize = True
        Me.discountCheckbox.Location = New System.Drawing.Point(15, 64)
        Me.discountCheckbox.Name = "discountCheckbox"
        Me.discountCheckbox.Size = New System.Drawing.Size(63, 17)
        Me.discountCheckbox.TabIndex = 1
        Me.discountCheckbox.Text = "10% Off"
        Me.discountCheckbox.UseVisualStyleBackColor = True
        '
        'shippingCheckbox
        '
        Me.shippingCheckbox.AutoSize = True
        Me.shippingCheckbox.Location = New System.Drawing.Point(15, 88)
        Me.shippingCheckbox.Name = "shippingCheckbox"
        Me.shippingCheckbox.Size = New System.Drawing.Size(88, 17)
        Me.shippingCheckbox.TabIndex = 2
        Me.shippingCheckbox.Text = "Shipping Fee"
        Me.shippingCheckbox.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(142, 20)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 42)
        Me.calcButton.TabIndex = 3
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(142, 68)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 42)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(142, 116)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 42)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'totaldueLabel
        '
        Me.totaldueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totaldueLabel.Location = New System.Drawing.Point(15, 144)
        Me.totaldueLabel.Name = "totaldueLabel"
        Me.totaldueLabel.Size = New System.Drawing.Size(75, 20)
        Me.totaldueLabel.TabIndex = 6
        Me.totaldueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Due"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pounds Ordered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 213)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totaldueLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.shippingCheckbox)
        Me.Controls.Add(Me.discountCheckbox)
        Me.Controls.Add(Me.poundsTextbox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tea Time"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents poundsTextbox As TextBox
    Friend WithEvents discountCheckbox As CheckBox
    Friend WithEvents shippingCheckbox As CheckBox
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents totaldueLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
