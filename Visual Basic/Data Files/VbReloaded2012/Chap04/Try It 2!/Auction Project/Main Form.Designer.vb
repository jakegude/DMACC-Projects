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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bid1TextBox = New System.Windows.Forms.TextBox()
        Me.bid2TextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.bidsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Displays the lowest and highest bids."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bid &1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bid &2:"
        '
        'bid1TextBox
        '
        Me.bid1TextBox.Location = New System.Drawing.Point(87, 99)
        Me.bid1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bid1TextBox.Name = "bid1TextBox"
        Me.bid1TextBox.Size = New System.Drawing.Size(64, 27)
        Me.bid1TextBox.TabIndex = 1
        '
        'bid2TextBox
        '
        Me.bid2TextBox.Location = New System.Drawing.Point(87, 142)
        Me.bid2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bid2TextBox.Name = "bid2TextBox"
        Me.bid2TextBox.Size = New System.Drawing.Size(64, 27)
        Me.bid2TextBox.TabIndex = 3
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(209, 99)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(86, 36)
        Me.displayButton.TabIndex = 4
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(209, 145)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 36)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'bidsLabel
        '
        Me.bidsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bidsLabel.Location = New System.Drawing.Point(35, 201)
        Me.bidsLabel.Name = "bidsLabel"
        Me.bidsLabel.Size = New System.Drawing.Size(260, 84)
        Me.bidsLabel.TabIndex = 7
        Me.bidsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AcceptButton = Me.displayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 333)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.bidsLabel)
        Me.Controls.Add(Me.bid2TextBox)
        Me.Controls.Add(Me.bid1TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auction House"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bid1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents bid2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents bidsLabel As System.Windows.Forms.Label

End Class
