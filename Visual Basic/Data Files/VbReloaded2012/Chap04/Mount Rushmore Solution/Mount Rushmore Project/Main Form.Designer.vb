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
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.andAlsoButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.orElseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'msgLabel
        '
        Me.msgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msgLabel.Location = New System.Drawing.Point(17, 73)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(310, 27)
        Me.msgLabel.TabIndex = 5
        Me.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(71, 31)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(252, 27)
        Me.nameTextBox.TabIndex = 1
        '
        'andAlsoButton
        '
        Me.andAlsoButton.Location = New System.Drawing.Point(354, 24)
        Me.andAlsoButton.Name = "andAlsoButton"
        Me.andAlsoButton.Size = New System.Drawing.Size(149, 35)
        Me.andAlsoButton.TabIndex = 2
        Me.andAlsoButton.Text = "Display (&AndAlso)"
        Me.andAlsoButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(354, 107)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(149, 35)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'orElseButton
        '
        Me.orElseButton.Location = New System.Drawing.Point(354, 65)
        Me.orElseButton.Name = "orElseButton"
        Me.orElseButton.Size = New System.Drawing.Size(149, 35)
        Me.orElseButton.TabIndex = 3
        Me.orElseButton.Text = "Display (&OrElse)"
        Me.orElseButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 176)
        Me.Controls.Add(Me.orElseButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.andAlsoButton)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mount Rushmore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents msgLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents andAlsoButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents orElseButton As System.Windows.Forms.Button

End Class
