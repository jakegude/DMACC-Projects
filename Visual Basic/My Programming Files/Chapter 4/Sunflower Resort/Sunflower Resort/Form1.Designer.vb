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
        Me.roomTextbox = New System.Windows.Forms.TextBox()
        Me.nightsTextbox = New System.Windows.Forms.TextBox()
        Me.adultTextbox = New System.Windows.Forms.TextBox()
        Me.childrenTextbox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.feeLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.roomLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'roomTextbox
        '
        Me.roomTextbox.Location = New System.Drawing.Point(6, 42)
        Me.roomTextbox.Name = "roomTextbox"
        Me.roomTextbox.Size = New System.Drawing.Size(40, 20)
        Me.roomTextbox.TabIndex = 0
        '
        'nightsTextbox
        '
        Me.nightsTextbox.Location = New System.Drawing.Point(112, 42)
        Me.nightsTextbox.Name = "nightsTextbox"
        Me.nightsTextbox.Size = New System.Drawing.Size(40, 20)
        Me.nightsTextbox.TabIndex = 1
        '
        'adultTextbox
        '
        Me.adultTextbox.Location = New System.Drawing.Point(6, 97)
        Me.adultTextbox.Name = "adultTextbox"
        Me.adultTextbox.Size = New System.Drawing.Size(40, 20)
        Me.adultTextbox.TabIndex = 2
        '
        'childrenTextbox
        '
        Me.childrenTextbox.Location = New System.Drawing.Point(112, 97)
        Me.childrenTextbox.Name = "childrenTextbox"
        Me.childrenTextbox.Size = New System.Drawing.Size(40, 20)
        Me.childrenTextbox.TabIndex = 3
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(217, 14)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(86, 37)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(217, 69)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(86, 37)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(217, 119)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 37)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.roomTextbox)
        Me.GroupBox1.Controls.Add(Me.adultTextbox)
        Me.GroupBox1.Controls.Add(Me.nightsTextbox)
        Me.GroupBox1.Controls.Add(Me.childrenTextbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 144)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number of.."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(109, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Children:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(109, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Nights:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Adults(18+):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Rooms:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.totalLabel)
        Me.GroupBox2.Controls.Add(Me.feeLabel)
        Me.GroupBox2.Controls.Add(Me.taxLabel)
        Me.GroupBox2.Controls.Add(Me.roomLabel)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(87, 92)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(90, 23)
        Me.totalLabel.TabIndex = 7
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'feeLabel
        '
        Me.feeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.feeLabel.Location = New System.Drawing.Point(87, 64)
        Me.feeLabel.Name = "feeLabel"
        Me.feeLabel.Size = New System.Drawing.Size(90, 23)
        Me.feeLabel.TabIndex = 6
        Me.feeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'taxLabel
        '
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxLabel.Location = New System.Drawing.Point(87, 37)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(90, 23)
        Me.taxLabel.TabIndex = 5
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'roomLabel
        '
        Me.roomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.roomLabel.Location = New System.Drawing.Point(87, 11)
        Me.roomLabel.Name = "roomLabel"
        Me.roomLabel.Size = New System.Drawing.Size(90, 23)
        Me.roomLabel.TabIndex = 4
        Me.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Due:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resort Fee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "By Jake Gudenkauf"
        '
        'messageLabel
        '
        Me.messageLabel.Location = New System.Drawing.Point(15, 159)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(186, 32)
        Me.messageLabel.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 333)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Name = "Form1"
        Me.Text = "Sunflower Resort"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents roomTextbox As TextBox
    Friend WithEvents nightsTextbox As TextBox
    Friend WithEvents adultTextbox As TextBox
    Friend WithEvents childrenTextbox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents feeLabel As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents roomLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents messageLabel As Label
End Class
