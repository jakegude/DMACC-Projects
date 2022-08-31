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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.rollButton = New System.Windows.Forms.Button()
        Me.secondDiePictureBox = New System.Windows.Forms.PictureBox()
        Me.firstDiePictureBox = New System.Windows.Forms.PictureBox()
        Me.dot6PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot5PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot4PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot3PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot2PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot1PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.secondDiePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firstDiePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot6PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot5PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(331, 69)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(102, 35)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLabel.Location = New System.Drawing.Point(42, 27)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(193, 21)
        Me.msgLabel.TabIndex = 2
        Me.msgLabel.Text = "Click the Roll 'Em button"
        '
        'rollButton
        '
        Me.rollButton.Location = New System.Drawing.Point(331, 27)
        Me.rollButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rollButton.Name = "rollButton"
        Me.rollButton.Size = New System.Drawing.Size(102, 35)
        Me.rollButton.TabIndex = 0
        Me.rollButton.Text = "&Roll 'Em"
        Me.rollButton.UseVisualStyleBackColor = True
        '
        'secondDiePictureBox
        '
        Me.secondDiePictureBox.Location = New System.Drawing.Point(154, 69)
        Me.secondDiePictureBox.Name = "secondDiePictureBox"
        Me.secondDiePictureBox.Size = New System.Drawing.Size(101, 108)
        Me.secondDiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.secondDiePictureBox.TabIndex = 32
        Me.secondDiePictureBox.TabStop = False
        '
        'firstDiePictureBox
        '
        Me.firstDiePictureBox.Location = New System.Drawing.Point(47, 69)
        Me.firstDiePictureBox.Name = "firstDiePictureBox"
        Me.firstDiePictureBox.Size = New System.Drawing.Size(101, 108)
        Me.firstDiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.firstDiePictureBox.TabIndex = 31
        Me.firstDiePictureBox.TabStop = False
        '
        'dot6PictureBox
        '
        Me.dot6PictureBox.Image = Global.Roll_Em_Game_Project.My.Resources.Resources.Dot6
        Me.dot6PictureBox.Location = New System.Drawing.Point(375, 231)
        Me.dot6PictureBox.Name = "dot6PictureBox"
        Me.dot6PictureBox.Size = New System.Drawing.Size(64, 77)
        Me.dot6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot6PictureBox.TabIndex = 30
        Me.dot6PictureBox.TabStop = False
        '
        'dot5PictureBox
        '
        Me.dot5PictureBox.Image = Global.Roll_Em_Game_Project.My.Resources.Resources.Dot5
        Me.dot5PictureBox.Location = New System.Drawing.Point(305, 231)
        Me.dot5PictureBox.Name = "dot5PictureBox"
        Me.dot5PictureBox.Size = New System.Drawing.Size(64, 77)
        Me.dot5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot5PictureBox.TabIndex = 29
        Me.dot5PictureBox.TabStop = False
        '
        'dot4PictureBox
        '
        Me.dot4PictureBox.Image = Global.Roll_Em_Game_Project.My.Resources.Resources.Dot4
        Me.dot4PictureBox.Location = New System.Drawing.Point(235, 231)
        Me.dot4PictureBox.Name = "dot4PictureBox"
        Me.dot4PictureBox.Size = New System.Drawing.Size(64, 77)
        Me.dot4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot4PictureBox.TabIndex = 28
        Me.dot4PictureBox.TabStop = False
        '
        'dot3PictureBox
        '
        Me.dot3PictureBox.Image = Global.Roll_Em_Game_Project.My.Resources.Resources.Dot3
        Me.dot3PictureBox.Location = New System.Drawing.Point(165, 231)
        Me.dot3PictureBox.Name = "dot3PictureBox"
        Me.dot3PictureBox.Size = New System.Drawing.Size(64, 77)
        Me.dot3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot3PictureBox.TabIndex = 27
        Me.dot3PictureBox.TabStop = False
        '
        'dot2PictureBox
        '
        Me.dot2PictureBox.Image = Global.Roll_Em_Game_Project.My.Resources.Resources.Dot2
        Me.dot2PictureBox.Location = New System.Drawing.Point(95, 231)
        Me.dot2PictureBox.Name = "dot2PictureBox"
        Me.dot2PictureBox.Size = New System.Drawing.Size(64, 77)
        Me.dot2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot2PictureBox.TabIndex = 26
        Me.dot2PictureBox.TabStop = False
        '
        'dot1PictureBox
        '
        Me.dot1PictureBox.Image = Global.Roll_Em_Game_Project.My.Resources.Resources.Dot1
        Me.dot1PictureBox.Location = New System.Drawing.Point(25, 231)
        Me.dot1PictureBox.Name = "dot1PictureBox"
        Me.dot1PictureBox.Size = New System.Drawing.Size(64, 77)
        Me.dot1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot1PictureBox.TabIndex = 25
        Me.dot1PictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 356)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.secondDiePictureBox)
        Me.Controls.Add(Me.firstDiePictureBox)
        Me.Controls.Add(Me.dot6PictureBox)
        Me.Controls.Add(Me.dot5PictureBox)
        Me.Controls.Add(Me.dot4PictureBox)
        Me.Controls.Add(Me.dot3PictureBox)
        Me.Controls.Add(Me.dot2PictureBox)
        Me.Controls.Add(Me.dot1PictureBox)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.rollButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roll 'Em Game"
        CType(Me.secondDiePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firstDiePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot6PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot5PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents secondDiePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents firstDiePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dot6PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dot5PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dot4PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dot3PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dot2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dot1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents msgLabel As System.Windows.Forms.Label
    Friend WithEvents rollButton As System.Windows.Forms.Button

End Class
