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
        Me.goldRadioButton = New System.Windows.Forms.RadioButton()
        Me.silverRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.basicRadioButton = New System.Windows.Forms.RadioButton()
        Me.bronzeRadioButton = New System.Windows.Forms.RadioButton()
        Me.hbiCheckBox = New System.Windows.Forms.CheckBox()
        Me.showtimerCheckBox = New System.Windows.Forms.CheckBox()
        Me.cinematicCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.localCheckBox = New System.Windows.Forms.CheckBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'goldRadioButton
        '
        Me.goldRadioButton.AutoSize = True
        Me.goldRadioButton.Location = New System.Drawing.Point(18, 129)
        Me.goldRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.goldRadioButton.Name = "goldRadioButton"
        Me.goldRadioButton.Size = New System.Drawing.Size(59, 24)
        Me.goldRadioButton.TabIndex = 3
        Me.goldRadioButton.TabStop = True
        Me.goldRadioButton.Text = "&Gold"
        Me.goldRadioButton.UseVisualStyleBackColor = True
        '
        'silverRadioButton
        '
        Me.silverRadioButton.AutoSize = True
        Me.silverRadioButton.Location = New System.Drawing.Point(18, 96)
        Me.silverRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.silverRadioButton.Name = "silverRadioButton"
        Me.silverRadioButton.Size = New System.Drawing.Size(63, 24)
        Me.silverRadioButton.TabIndex = 2
        Me.silverRadioButton.TabStop = True
        Me.silverRadioButton.Text = "&Silver"
        Me.silverRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.basicRadioButton)
        Me.GroupBox1.Controls.Add(Me.bronzeRadioButton)
        Me.GroupBox1.Controls.Add(Me.goldRadioButton)
        Me.GroupBox1.Controls.Add(Me.silverRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(137, 169)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cable packages"
        '
        'basicRadioButton
        '
        Me.basicRadioButton.AutoSize = True
        Me.basicRadioButton.Checked = True
        Me.basicRadioButton.Location = New System.Drawing.Point(18, 29)
        Me.basicRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.basicRadioButton.Name = "basicRadioButton"
        Me.basicRadioButton.Size = New System.Drawing.Size(61, 24)
        Me.basicRadioButton.TabIndex = 0
        Me.basicRadioButton.TabStop = True
        Me.basicRadioButton.Text = "&Basic"
        Me.basicRadioButton.UseVisualStyleBackColor = True
        '
        'bronzeRadioButton
        '
        Me.bronzeRadioButton.AutoSize = True
        Me.bronzeRadioButton.Location = New System.Drawing.Point(18, 63)
        Me.bronzeRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bronzeRadioButton.Name = "bronzeRadioButton"
        Me.bronzeRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.bronzeRadioButton.TabIndex = 1
        Me.bronzeRadioButton.TabStop = True
        Me.bronzeRadioButton.Text = "Bron&ze"
        Me.bronzeRadioButton.UseVisualStyleBackColor = True
        '
        'hbiCheckBox
        '
        Me.hbiCheckBox.AutoSize = True
        Me.hbiCheckBox.Location = New System.Drawing.Point(13, 29)
        Me.hbiCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.hbiCheckBox.Name = "hbiCheckBox"
        Me.hbiCheckBox.Size = New System.Drawing.Size(158, 24)
        Me.hbiCheckBox.TabIndex = 0
        Me.hbiCheckBox.Text = "&HBI movie channels"
        Me.hbiCheckBox.UseVisualStyleBackColor = True
        '
        'showtimerCheckBox
        '
        Me.showtimerCheckBox.AutoSize = True
        Me.showtimerCheckBox.Location = New System.Drawing.Point(13, 63)
        Me.showtimerCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.showtimerCheckBox.Name = "showtimerCheckBox"
        Me.showtimerCheckBox.Size = New System.Drawing.Size(205, 24)
        Me.showtimerCheckBox.TabIndex = 1
        Me.showtimerCheckBox.Text = "Show&timer movie channels"
        Me.showtimerCheckBox.UseVisualStyleBackColor = True
        '
        'cinematicCheckBox
        '
        Me.cinematicCheckBox.AutoSize = True
        Me.cinematicCheckBox.Location = New System.Drawing.Point(13, 96)
        Me.cinematicCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cinematicCheckBox.Name = "cinematicCheckBox"
        Me.cinematicCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.cinematicCheckBox.TabIndex = 2
        Me.cinematicCheckBox.Text = "Cine&matic movie channels"
        Me.cinematicCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.localCheckBox)
        Me.GroupBox2.Controls.Add(Me.hbiCheckBox)
        Me.GroupBox2.Controls.Add(Me.cinematicCheckBox)
        Me.GroupBox2.Controls.Add(Me.showtimerCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(256, 54)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(229, 169)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional features"
        '
        'localCheckBox
        '
        Me.localCheckBox.AutoSize = True
        Me.localCheckBox.Location = New System.Drawing.Point(13, 129)
        Me.localCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.localCheckBox.Name = "localCheckBox"
        Me.localCheckBox.Size = New System.Drawing.Size(118, 24)
        Me.localCheckBox.TabIndex = 3
        Me.localCheckBox.Text = "&Local stations"
        Me.localCheckBox.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(156, 269)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(149, 37)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate Cable Bill"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(311, 269)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 37)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Charleston_Cable_Project.My.Resources.Resources.CCC
        Me.PictureBox1.Location = New System.Drawing.Point(13, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 305)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 349)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charleston Cable Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents goldRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents silverRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents basicRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents bronzeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hbiCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents showtimerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents cinematicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents localCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
