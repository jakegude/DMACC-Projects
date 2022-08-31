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
        Me.bonusLabel = New System.Windows.Forms.Label()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Annual sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Bonus:"
        '
        'bonusLabel
        '
        Me.bonusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bonusLabel.Location = New System.Drawing.Point(264, 50)
        Me.bonusLabel.Name = "bonusLabel"
        Me.bonusLabel.Size = New System.Drawing.Size(106, 27)
        Me.bonusLabel.TabIndex = 9
        Me.bonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(136, 53)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(75, 27)
        Me.salesTextBox.TabIndex = 3
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(30, 104)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(80, 34)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(116, 104)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(80, 34)
        Me.printButton.TabIndex = 5
        Me.printButton.Text = "&Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(290, 104)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(80, 34)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(204, 104)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(80, 34)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(55, 53)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(63, 27)
        Me.idTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&ID:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 162)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.salesTextBox)
        Me.Controls.Add(Me.bonusLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shiloh Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bonusLabel As System.Windows.Forms.Label
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
