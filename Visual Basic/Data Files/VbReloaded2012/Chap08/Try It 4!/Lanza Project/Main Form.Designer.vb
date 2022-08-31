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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regularLabel = New System.Windows.Forms.Label()
        Me.grossLabel = New System.Windows.Forms.Label()
        Me.overtimeLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hoursComboBox = New System.Windows.Forms.ComboBox()
        Me.rateComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.regularLabel)
        Me.Panel1.Controls.Add(Me.grossLabel)
        Me.Panel1.Controls.Add(Me.overtimeLabel)
        Me.Panel1.Location = New System.Drawing.Point(30, 80)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 83)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Overtime pay:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Regular pay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gross pay:"
        '
        'regularLabel
        '
        Me.regularLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regularLabel.Location = New System.Drawing.Point(18, 36)
        Me.regularLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.regularLabel.Name = "regularLabel"
        Me.regularLabel.Size = New System.Drawing.Size(84, 26)
        Me.regularLabel.TabIndex = 1
        Me.regularLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grossLabel
        '
        Me.grossLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grossLabel.Location = New System.Drawing.Point(235, 36)
        Me.grossLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.grossLabel.Name = "grossLabel"
        Me.grossLabel.Size = New System.Drawing.Size(84, 26)
        Me.grossLabel.TabIndex = 5
        Me.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'overtimeLabel
        '
        Me.overtimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.overtimeLabel.Location = New System.Drawing.Point(123, 36)
        Me.overtimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.overtimeLabel.Name = "overtimeLabel"
        Me.overtimeLabel.Size = New System.Drawing.Size(84, 26)
        Me.overtimeLabel.TabIndex = 3
        Me.overtimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(294, 187)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(79, 28)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(210, 187)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(79, 28)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "C&lear"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(127, 187)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(79, 28)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&Hours:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lanza_Project.My.Resources.Resources.Lanza
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 62)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'hoursComboBox
        '
        Me.hoursComboBox.FormattingEnabled = True
        Me.hoursComboBox.Location = New System.Drawing.Point(178, 40)
        Me.hoursComboBox.Name = "hoursComboBox"
        Me.hoursComboBox.Size = New System.Drawing.Size(54, 25)
        Me.hoursComboBox.TabIndex = 4
        '
        'rateComboBox
        '
        Me.rateComboBox.FormattingEnabled = True
        Me.rateComboBox.Location = New System.Drawing.Point(278, 40)
        Me.rateComboBox.Name = "rateComboBox"
        Me.rateComboBox.Size = New System.Drawing.Size(54, 25)
        Me.rateComboBox.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 194)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 9
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 237)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.rateComboBox)
        Me.Controls.Add(Me.hoursComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lanza Trinkets - Weekly Pay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents regularLabel As System.Windows.Forms.Label
    Friend WithEvents grossLabel As System.Windows.Forms.Label
    Friend WithEvents overtimeLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents hoursComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
