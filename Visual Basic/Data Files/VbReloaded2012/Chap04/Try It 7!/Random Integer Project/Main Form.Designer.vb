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
        Me.randomLabel = New System.Windows.Forms.Label()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Random integer (1 - 10):"
        '
        'randomLabel
        '
        Me.randomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.randomLabel.Location = New System.Drawing.Point(248, 36)
        Me.randomLabel.Name = "randomLabel"
        Me.randomLabel.Size = New System.Drawing.Size(39, 26)
        Me.randomLabel.TabIndex = 3
        Me.randomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(30, 86)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(203, 40)
        Me.generateButton.TabIndex = 0
        Me.generateButton.Text = "&Generate Random Integer"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(239, 86)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 40)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 170)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.randomLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Integer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents randomLabel As System.Windows.Forms.Label
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
