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
        Me.listOfPricesTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.avgLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.startOverButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stock prices:"
        '
        'listOfPricesTextBox
        '
        Me.listOfPricesTextBox.Location = New System.Drawing.Point(38, 54)
        Me.listOfPricesTextBox.Multiline = True
        Me.listOfPricesTextBox.Name = "listOfPricesTextBox"
        Me.listOfPricesTextBox.ReadOnly = True
        Me.listOfPricesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.listOfPricesTextBox.Size = New System.Drawing.Size(115, 165)
        Me.listOfPricesTextBox.TabIndex = 4
        Me.listOfPricesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Average price:"
        '
        'avgLabel
        '
        Me.avgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.avgLabel.Location = New System.Drawing.Point(188, 54)
        Me.avgLabel.Name = "avgLabel"
        Me.avgLabel.Size = New System.Drawing.Size(157, 30)
        Me.avgLabel.TabIndex = 6
        Me.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(188, 105)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(157, 34)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate Average"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'startOverButton
        '
        Me.startOverButton.Location = New System.Drawing.Point(188, 145)
        Me.startOverButton.Name = "startOverButton"
        Me.startOverButton.Size = New System.Drawing.Size(157, 34)
        Me.startOverButton.TabIndex = 1
        Me.startOverButton.Text = "&Start Over"
        Me.startOverButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(188, 185)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(157, 34)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 259)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.startOverButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.avgLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listOfPricesTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Stock Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listOfPricesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents avgLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents startOverButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
