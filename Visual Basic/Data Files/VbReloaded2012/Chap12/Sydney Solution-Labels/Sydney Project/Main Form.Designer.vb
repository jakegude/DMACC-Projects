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
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(165, 112)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(116, 41)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "&Next Record"
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(45, 112)
        Me.previousButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(116, 41)
        Me.previousButton.TabIndex = 0
        Me.previousButton.Text = "&Previous Record"
        '
        'priceLabel
        '
        Me.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceLabel.Location = New System.Drawing.Point(307, 34)
        Me.priceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(56, 31)
        Me.priceLabel.TabIndex = 8
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameLabel
        '
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameLabel.Location = New System.Drawing.Point(114, 34)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(173, 31)
        Me.nameLabel.TabIndex = 6
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numberLabel
        '
        Me.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numberLabel.Location = New System.Drawing.Point(19, 34)
        Me.numberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(72, 31)
        Me.numberLabel.TabIndex = 4
        Me.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(286, 112)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(77, 41)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 179)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sydney Industries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents numberLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
