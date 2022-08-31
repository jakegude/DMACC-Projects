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
        Me.components = New System.ComponentModel.Container()
        Me.blinkButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.blinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'blinkButton
        '
        Me.blinkButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blinkButton.Location = New System.Drawing.Point(244, 135)
        Me.blinkButton.Name = "blinkButton"
        Me.blinkButton.Size = New System.Drawing.Size(75, 27)
        Me.blinkButton.TabIndex = 0
        Me.blinkButton.Text = "&Blink"
        Me.blinkButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(244, 168)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'welcomeLabel
        '
        Me.welcomeLabel.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLabel.ForeColor = System.Drawing.Color.DarkViolet
        Me.welcomeLabel.Location = New System.Drawing.Point(10, 34)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(329, 86)
        Me.welcomeLabel.TabIndex = 2
        Me.welcomeLabel.Text = "Welcome!"
        '
        'blinkTimer
        '
        Me.blinkTimer.Interval = 500
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 216)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.blinkButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents blinkButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents welcomeLabel As System.Windows.Forms.Label
    Friend WithEvents blinkTimer As System.Windows.Forms.Timer

End Class
