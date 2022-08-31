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
        Me.noDiscRadioButton = New System.Windows.Forms.RadioButton()
        Me.disc5RadioButton = New System.Windows.Forms.RadioButton()
        Me.disc10RadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'noDiscRadioButton
        '
        Me.noDiscRadioButton.AutoSize = True
        Me.noDiscRadioButton.Checked = True
        Me.noDiscRadioButton.Location = New System.Drawing.Point(170, 16)
        Me.noDiscRadioButton.Name = "noDiscRadioButton"
        Me.noDiscRadioButton.Size = New System.Drawing.Size(97, 21)
        Me.noDiscRadioButton.TabIndex = 2
        Me.noDiscRadioButton.TabStop = True
        Me.noDiscRadioButton.Text = "&No discount"
        Me.noDiscRadioButton.UseVisualStyleBackColor = True
        '
        'disc5RadioButton
        '
        Me.disc5RadioButton.AutoSize = True
        Me.disc5RadioButton.Location = New System.Drawing.Point(170, 41)
        Me.disc5RadioButton.Name = "disc5RadioButton"
        Me.disc5RadioButton.Size = New System.Drawing.Size(97, 21)
        Me.disc5RadioButton.TabIndex = 3
        Me.disc5RadioButton.Text = "&5% discount"
        Me.disc5RadioButton.UseVisualStyleBackColor = True
        '
        'disc10RadioButton
        '
        Me.disc10RadioButton.AutoSize = True
        Me.disc10RadioButton.Location = New System.Drawing.Point(170, 69)
        Me.disc10RadioButton.Name = "disc10RadioButton"
        Me.disc10RadioButton.Size = New System.Drawing.Size(104, 21)
        Me.disc10RadioButton.TabIndex = 4
        Me.disc10RadioButton.Text = "&10% discount"
        Me.disc10RadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Sales amount:"
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(21, 41)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(100, 25)
        Me.salesTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total due:"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(21, 119)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(100, 33)
        Me.totalLabel.TabIndex = 8
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(170, 108)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(96, 29)
        Me.calcButton.TabIndex = 5
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(170, 144)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 29)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 202)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.salesTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.disc10RadioButton)
        Me.Controls.Add(Me.disc5RadioButton)
        Me.Controls.Add(Me.noDiscRadioButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rocky's"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents noDiscRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents disc5RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents disc10RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
