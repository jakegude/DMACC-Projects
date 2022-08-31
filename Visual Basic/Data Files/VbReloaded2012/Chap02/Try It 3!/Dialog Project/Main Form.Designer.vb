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
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(31, 30)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(310, 20)
        Me.messageLabel.TabIndex = 3
        Me.messageLabel.Text = "Examples of the Font and Color dialog boxes."
        '
        'fontButton
        '
        Me.fontButton.Location = New System.Drawing.Point(104, 98)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(75, 33)
        Me.fontButton.TabIndex = 0
        Me.fontButton.Text = "&Font"
        Me.fontButton.UseVisualStyleBackColor = True
        '
        'colorButton
        '
        Me.colorButton.Location = New System.Drawing.Point(185, 98)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(75, 33)
        Me.colorButton.TabIndex = 1
        Me.colorButton.Text = "&Color"
        Me.colorButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(266, 98)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 33)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 162)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.colorButton)
        Me.Controls.Add(Me.fontButton)
        Me.Controls.Add(Me.messageLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents colorButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
