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
        Me.bdayRadioButton = New System.Windows.Forms.RadioButton()
        Me.gradRadioButton = New System.Windows.Forms.RadioButton()
        Me.annivRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.largeRadioButton = New System.Windows.Forms.RadioButton()
        Me.smallRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.annivRadioButton)
        Me.GroupBox1.Controls.Add(Me.gradRadioButton)
        Me.GroupBox1.Controls.Add(Me.bdayRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 156)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Occasion"
        '
        'bdayRadioButton
        '
        Me.bdayRadioButton.AutoSize = True
        Me.bdayRadioButton.Checked = True
        Me.bdayRadioButton.Location = New System.Drawing.Point(12, 27)
        Me.bdayRadioButton.Name = "bdayRadioButton"
        Me.bdayRadioButton.Size = New System.Drawing.Size(82, 24)
        Me.bdayRadioButton.TabIndex = 0
        Me.bdayRadioButton.TabStop = True
        Me.bdayRadioButton.Text = "&Birthday"
        Me.bdayRadioButton.UseVisualStyleBackColor = True
        '
        'gradRadioButton
        '
        Me.gradRadioButton.AutoSize = True
        Me.gradRadioButton.Location = New System.Drawing.Point(12, 68)
        Me.gradRadioButton.Name = "gradRadioButton"
        Me.gradRadioButton.Size = New System.Drawing.Size(101, 24)
        Me.gradRadioButton.TabIndex = 1
        Me.gradRadioButton.Text = "&Graduation"
        Me.gradRadioButton.UseVisualStyleBackColor = True
        '
        'annivRadioButton
        '
        Me.annivRadioButton.AutoSize = True
        Me.annivRadioButton.Location = New System.Drawing.Point(12, 111)
        Me.annivRadioButton.Name = "annivRadioButton"
        Me.annivRadioButton.Size = New System.Drawing.Size(103, 24)
        Me.annivRadioButton.TabIndex = 2
        Me.annivRadioButton.Text = "&Anniversary"
        Me.annivRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.largeRadioButton)
        Me.GroupBox2.Controls.Add(Me.smallRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(340, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(109, 109)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Size"
        '
        'largeRadioButton
        '
        Me.largeRadioButton.AutoSize = True
        Me.largeRadioButton.Location = New System.Drawing.Point(12, 68)
        Me.largeRadioButton.Name = "largeRadioButton"
        Me.largeRadioButton.Size = New System.Drawing.Size(64, 24)
        Me.largeRadioButton.TabIndex = 1
        Me.largeRadioButton.Text = "&Large"
        Me.largeRadioButton.UseVisualStyleBackColor = True
        '
        'smallRadioButton
        '
        Me.smallRadioButton.AutoSize = True
        Me.smallRadioButton.Checked = True
        Me.smallRadioButton.Location = New System.Drawing.Point(12, 27)
        Me.smallRadioButton.Name = "smallRadioButton"
        Me.smallRadioButton.Size = New System.Drawing.Size(64, 24)
        Me.smallRadioButton.TabIndex = 0
        Me.smallRadioButton.TabStop = True
        Me.smallRadioButton.Text = "&Small"
        Me.smallRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price:"
        '
        'priceLabel
        '
        Me.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceLabel.Location = New System.Drawing.Point(65, 200)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(109, 29)
        Me.priceLabel.TabIndex = 5
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(190, 195)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(111, 38)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display Price"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(307, 195)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(111, 38)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Party_Project.My.Resources.Resources.Balloons
        Me.PictureBox1.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 259)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Party Bouquets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents annivRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents gradRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents bdayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents largeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents smallRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
