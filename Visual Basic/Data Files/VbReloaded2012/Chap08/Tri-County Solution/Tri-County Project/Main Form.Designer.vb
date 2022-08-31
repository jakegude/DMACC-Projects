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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.commercialRadioButton = New System.Windows.Forms.RadioButton()
        Me.residentialRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.previousTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usageLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.commercialRadioButton)
        Me.GroupBox1.Controls.Add(Me.residentialRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(148, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 89)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rate codes"
        '
        'commercialRadioButton
        '
        Me.commercialRadioButton.Location = New System.Drawing.Point(12, 53)
        Me.commercialRadioButton.Name = "commercialRadioButton"
        Me.commercialRadioButton.Size = New System.Drawing.Size(119, 21)
        Me.commercialRadioButton.TabIndex = 1
        Me.commercialRadioButton.Text = "&2 - Commercial"
        Me.commercialRadioButton.UseVisualStyleBackColor = True
        '
        'residentialRadioButton
        '
        Me.residentialRadioButton.Checked = True
        Me.residentialRadioButton.Location = New System.Drawing.Point(13, 24)
        Me.residentialRadioButton.Name = "residentialRadioButton"
        Me.residentialRadioButton.Size = New System.Drawing.Size(118, 23)
        Me.residentialRadioButton.TabIndex = 0
        Me.residentialRadioButton.TabStop = True
        Me.residentialRadioButton.Text = "&1 - Residential"
        Me.residentialRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Previous reading:"
        '
        'previousTextBox
        '
        Me.previousTextBox.Location = New System.Drawing.Point(148, 119)
        Me.previousTextBox.Name = "previousTextBox"
        Me.previousTextBox.Size = New System.Drawing.Size(70, 25)
        Me.previousTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current &reading:"
        '
        'currentTextBox
        '
        Me.currentTextBox.Location = New System.Drawing.Point(148, 158)
        Me.currentTextBox.Name = "currentTextBox"
        Me.currentTextBox.Size = New System.Drawing.Size(70, 25)
        Me.currentTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Monthly usage:"
        '
        'usageLabel
        '
        Me.usageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usageLabel.Location = New System.Drawing.Point(335, 115)
        Me.usageLabel.Name = "usageLabel"
        Me.usageLabel.Size = New System.Drawing.Size(79, 25)
        Me.usageLabel.TabIndex = 8
        Me.usageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(328, 160)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(86, 25)
        Me.totalLabel.TabIndex = 10
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total charge:"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(339, 12)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 27)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(339, 45)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tri_County_Project.My.Resources.Resources.TCE
        Me.PictureBox1.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 214)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.usageLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.currentTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.previousTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tri-County Electricity"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents commercialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents residentialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents previousTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents currentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents usageLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
