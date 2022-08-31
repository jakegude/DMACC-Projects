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
        Me.headPictureBox = New System.Windows.Forms.PictureBox()
        Me.torsoPictureBox = New System.Windows.Forms.PictureBox()
        Me.rightArmPictureBox = New System.Windows.Forms.PictureBox()
        Me.leftArmPictureBox = New System.Windows.Forms.PictureBox()
        Me.rightLegPictureBox = New System.Windows.Forms.PictureBox()
        Me.leftLegPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wordLabel = New System.Windows.Forms.Label()
        Me.incorrectLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.letterTextBox = New System.Windows.Forms.TextBox()
        Me.checkButton = New System.Windows.Forms.Button()
        CType(Me.headPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.torsoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightArmPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftArmPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightLegPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftLegPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headPictureBox
        '
        Me.headPictureBox.Image = Global.Frankenstein_Project.My.Resources.Resources.Head
        Me.headPictureBox.Location = New System.Drawing.Point(12, 55)
        Me.headPictureBox.Name = "headPictureBox"
        Me.headPictureBox.Size = New System.Drawing.Size(230, 290)
        Me.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.headPictureBox.TabIndex = 0
        Me.headPictureBox.TabStop = False
        '
        'torsoPictureBox
        '
        Me.torsoPictureBox.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorso
        Me.torsoPictureBox.Location = New System.Drawing.Point(12, 279)
        Me.torsoPictureBox.Name = "torsoPictureBox"
        Me.torsoPictureBox.Size = New System.Drawing.Size(230, 290)
        Me.torsoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.torsoPictureBox.TabIndex = 1
        Me.torsoPictureBox.TabStop = False
        '
        'rightArmPictureBox
        '
        Me.rightArmPictureBox.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorsoOneArm
        Me.rightArmPictureBox.Location = New System.Drawing.Point(248, 279)
        Me.rightArmPictureBox.Name = "rightArmPictureBox"
        Me.rightArmPictureBox.Size = New System.Drawing.Size(230, 290)
        Me.rightArmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rightArmPictureBox.TabIndex = 2
        Me.rightArmPictureBox.TabStop = False
        '
        'leftArmPictureBox
        '
        Me.leftArmPictureBox.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorsoTwoArms
        Me.leftArmPictureBox.Location = New System.Drawing.Point(433, 279)
        Me.leftArmPictureBox.Name = "leftArmPictureBox"
        Me.leftArmPictureBox.Size = New System.Drawing.Size(230, 290)
        Me.leftArmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.leftArmPictureBox.TabIndex = 3
        Me.leftArmPictureBox.TabStop = False
        '
        'rightLegPictureBox
        '
        Me.rightLegPictureBox.Image = Global.Frankenstein_Project.My.Resources.Resources.HeadTorsoArmsOneLeg
        Me.rightLegPictureBox.Location = New System.Drawing.Point(639, 279)
        Me.rightLegPictureBox.Name = "rightLegPictureBox"
        Me.rightLegPictureBox.Size = New System.Drawing.Size(230, 290)
        Me.rightLegPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rightLegPictureBox.TabIndex = 4
        Me.rightLegPictureBox.TabStop = False
        '
        'leftLegPictureBox
        '
        Me.leftLegPictureBox.Image = Global.Frankenstein_Project.My.Resources.Resources.FullBody
        Me.leftLegPictureBox.Location = New System.Drawing.Point(839, 279)
        Me.leftLegPictureBox.Name = "leftLegPictureBox"
        Me.leftLegPictureBox.Size = New System.Drawing.Size(230, 290)
        Me.leftLegPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.leftLegPictureBox.TabIndex = 5
        Me.leftLegPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Secret word:"
        '
        'wordLabel
        '
        Me.wordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wordLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wordLabel.Location = New System.Drawing.Point(254, 71)
        Me.wordLabel.Name = "wordLabel"
        Me.wordLabel.Size = New System.Drawing.Size(160, 34)
        Me.wordLabel.TabIndex = 7
        Me.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'incorrectLabel
        '
        Me.incorrectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.incorrectLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incorrectLabel.Location = New System.Drawing.Point(456, 71)
        Me.incorrectLabel.Name = "incorrectLabel"
        Me.incorrectLabel.Size = New System.Drawing.Size(207, 34)
        Me.incorrectLabel.TabIndex = 9
        Me.incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(453, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Incorrect letters:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Enter a letter:"
        '
        'letterTextBox
        '
        Me.letterTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.letterTextBox.Location = New System.Drawing.Point(341, 149)
        Me.letterTextBox.MaxLength = 1
        Me.letterTextBox.Name = "letterTextBox"
        Me.letterTextBox.Size = New System.Drawing.Size(32, 25)
        Me.letterTextBox.TabIndex = 11
        '
        'checkButton
        '
        Me.checkButton.Enabled = False
        Me.checkButton.Location = New System.Drawing.Point(385, 146)
        Me.checkButton.Name = "checkButton"
        Me.checkButton.Size = New System.Drawing.Size(89, 28)
        Me.checkButton.TabIndex = 12
        Me.checkButton.Text = "&Check"
        Me.checkButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.checkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 571)
        Me.Controls.Add(Me.checkButton)
        Me.Controls.Add(Me.letterTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.incorrectLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.wordLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.leftLegPictureBox)
        Me.Controls.Add(Me.rightLegPictureBox)
        Me.Controls.Add(Me.leftArmPictureBox)
        Me.Controls.Add(Me.rightArmPictureBox)
        Me.Controls.Add(Me.torsoPictureBox)
        Me.Controls.Add(Me.headPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frankenstein Game"
        CType(Me.headPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.torsoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightArmPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftArmPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightLegPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftLegPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents headPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents torsoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents rightArmPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents leftArmPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents rightLegPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents leftLegPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wordLabel As System.Windows.Forms.Label
    Friend WithEvents incorrectLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents letterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents checkButton As System.Windows.Forms.Button

End Class
