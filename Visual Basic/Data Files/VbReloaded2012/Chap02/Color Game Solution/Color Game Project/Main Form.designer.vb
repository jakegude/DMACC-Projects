<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.startOverButton = New System.Windows.Forms.Button()
        Me.redButton = New System.Windows.Forms.Button()
        Me.orangeButton = New System.Windows.Forms.Button()
        Me.grayButton = New System.Windows.Forms.Button()
        Me.purpleButton = New System.Windows.Forms.Button()
        Me.pinkButton = New System.Windows.Forms.Button()
        Me.brownButton = New System.Windows.Forms.Button()
        Me.yellowButton = New System.Windows.Forms.Button()
        Me.greenButton = New System.Windows.Forms.Button()
        Me.blueButton = New System.Windows.Forms.Button()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 378)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Click a color button:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(311, 316)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(83, 44)
        Me.exitButton.TabIndex = 12
        Me.exitButton.Text = "E&xit"
        '
        'startOverButton
        '
        Me.startOverButton.Location = New System.Drawing.Point(47, 316)
        Me.startOverButton.Margin = New System.Windows.Forms.Padding(2)
        Me.startOverButton.Name = "startOverButton"
        Me.startOverButton.Size = New System.Drawing.Size(83, 44)
        Me.startOverButton.TabIndex = 9
        Me.startOverButton.Text = "&Start Over"
        '
        'redButton
        '
        Me.redButton.BackColor = System.Drawing.Color.White
        Me.redButton.Location = New System.Drawing.Point(47, 29)
        Me.redButton.Margin = New System.Windows.Forms.Padding(2)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(91, 42)
        Me.redButton.TabIndex = 0
        Me.redButton.Text = "&Red"
        Me.redButton.UseVisualStyleBackColor = False
        '
        'orangeButton
        '
        Me.orangeButton.BackColor = System.Drawing.Color.White
        Me.orangeButton.Location = New System.Drawing.Point(241, 124)
        Me.orangeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.orangeButton.Name = "orangeButton"
        Me.orangeButton.Size = New System.Drawing.Size(91, 42)
        Me.orangeButton.TabIndex = 8
        Me.orangeButton.Text = "&Orange"
        Me.orangeButton.UseVisualStyleBackColor = False
        '
        'grayButton
        '
        Me.grayButton.BackColor = System.Drawing.Color.White
        Me.grayButton.Location = New System.Drawing.Point(144, 124)
        Me.grayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.grayButton.Name = "grayButton"
        Me.grayButton.Size = New System.Drawing.Size(91, 42)
        Me.grayButton.TabIndex = 7
        Me.grayButton.Text = "Gr&ay"
        Me.grayButton.UseVisualStyleBackColor = False
        '
        'purpleButton
        '
        Me.purpleButton.BackColor = System.Drawing.Color.White
        Me.purpleButton.Location = New System.Drawing.Point(49, 124)
        Me.purpleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.purpleButton.Name = "purpleButton"
        Me.purpleButton.Size = New System.Drawing.Size(91, 42)
        Me.purpleButton.TabIndex = 6
        Me.purpleButton.Text = "Purp&le"
        Me.purpleButton.UseVisualStyleBackColor = False
        '
        'pinkButton
        '
        Me.pinkButton.BackColor = System.Drawing.Color.White
        Me.pinkButton.Location = New System.Drawing.Point(241, 78)
        Me.pinkButton.Margin = New System.Windows.Forms.Padding(2)
        Me.pinkButton.Name = "pinkButton"
        Me.pinkButton.Size = New System.Drawing.Size(91, 42)
        Me.pinkButton.TabIndex = 5
        Me.pinkButton.Text = "Pin&k"
        Me.pinkButton.UseVisualStyleBackColor = False
        '
        'brownButton
        '
        Me.brownButton.BackColor = System.Drawing.Color.White
        Me.brownButton.Location = New System.Drawing.Point(144, 78)
        Me.brownButton.Margin = New System.Windows.Forms.Padding(2)
        Me.brownButton.Name = "brownButton"
        Me.brownButton.Size = New System.Drawing.Size(91, 42)
        Me.brownButton.TabIndex = 4
        Me.brownButton.Text = "Brow&n"
        Me.brownButton.UseVisualStyleBackColor = False
        '
        'yellowButton
        '
        Me.yellowButton.BackColor = System.Drawing.Color.White
        Me.yellowButton.Location = New System.Drawing.Point(49, 78)
        Me.yellowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.yellowButton.Name = "yellowButton"
        Me.yellowButton.Size = New System.Drawing.Size(91, 42)
        Me.yellowButton.TabIndex = 3
        Me.yellowButton.Text = "&Yellow"
        Me.yellowButton.UseVisualStyleBackColor = False
        '
        'greenButton
        '
        Me.greenButton.BackColor = System.Drawing.Color.White
        Me.greenButton.Location = New System.Drawing.Point(241, 31)
        Me.greenButton.Margin = New System.Windows.Forms.Padding(2)
        Me.greenButton.Name = "greenButton"
        Me.greenButton.Size = New System.Drawing.Size(91, 42)
        Me.greenButton.TabIndex = 2
        Me.greenButton.Text = "&Green"
        Me.greenButton.UseVisualStyleBackColor = False
        '
        'blueButton
        '
        Me.blueButton.BackColor = System.Drawing.Color.White
        Me.blueButton.Location = New System.Drawing.Point(144, 29)
        Me.blueButton.Margin = New System.Windows.Forms.Padding(2)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(91, 42)
        Me.blueButton.TabIndex = 1
        Me.blueButton.Text = "&Blue"
        Me.blueButton.UseVisualStyleBackColor = False
        '
        'fontButton
        '
        Me.fontButton.Location = New System.Drawing.Point(223, 316)
        Me.fontButton.Margin = New System.Windows.Forms.Padding(2)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(83, 44)
        Me.fontButton.TabIndex = 11
        Me.fontButton.Text = "&Font"
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(135, 316)
        Me.printButton.Margin = New System.Windows.Forms.Padding(2)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(83, 44)
        Me.printButton.TabIndex = 10
        Me.printButton.Text = "&Print"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 464)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.fontButton)
        Me.Controls.Add(Me.orangeButton)
        Me.Controls.Add(Me.grayButton)
        Me.Controls.Add(Me.pinkButton)
        Me.Controls.Add(Me.brownButton)
        Me.Controls.Add(Me.purpleButton)
        Me.Controls.Add(Me.yellowButton)
        Me.Controls.Add(Me.greenButton)
        Me.Controls.Add(Me.blueButton)
        Me.Controls.Add(Me.startOverButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.redButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents startOverButton As System.Windows.Forms.Button
    Friend WithEvents redButton As System.Windows.Forms.Button
    Friend WithEvents orangeButton As System.Windows.Forms.Button
    Friend WithEvents grayButton As System.Windows.Forms.Button
    Friend WithEvents purpleButton As System.Windows.Forms.Button
    Friend WithEvents pinkButton As System.Windows.Forms.Button
    Friend WithEvents brownButton As System.Windows.Forms.Button
    Friend WithEvents yellowButton As System.Windows.Forms.Button
    Friend WithEvents greenButton As System.Windows.Forms.Button
    Friend WithEvents blueButton As System.Windows.Forms.Button
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button

End Class
