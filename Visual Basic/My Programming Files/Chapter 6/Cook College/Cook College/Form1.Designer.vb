<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.enterdataButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hoursLabel = New System.Windows.Forms.Label()
        Me.gpaLabel = New System.Windows.Forms.Label()
        Me.numgradesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'enterdataButton
        '
        Me.enterdataButton.Location = New System.Drawing.Point(15, 151)
        Me.enterdataButton.Name = "enterdataButton"
        Me.enterdataButton.Size = New System.Drawing.Size(101, 45)
        Me.enterdataButton.TabIndex = 0
        Me.enterdataButton.Text = "Enter Data"
        Me.enterdataButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(157, 151)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(101, 45)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Credit Hours:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "GPA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of Grades Entered:"
        '
        'hoursLabel
        '
        Me.hoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoursLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.hoursLabel.Location = New System.Drawing.Point(157, 18)
        Me.hoursLabel.Name = "hoursLabel"
        Me.hoursLabel.Size = New System.Drawing.Size(100, 23)
        Me.hoursLabel.TabIndex = 5
        '
        'gpaLabel
        '
        Me.gpaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gpaLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.gpaLabel.Location = New System.Drawing.Point(157, 63)
        Me.gpaLabel.Name = "gpaLabel"
        Me.gpaLabel.Size = New System.Drawing.Size(100, 23)
        Me.gpaLabel.TabIndex = 6
        '
        'numgradesLabel
        '
        Me.numgradesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numgradesLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.numgradesLabel.Location = New System.Drawing.Point(157, 108)
        Me.numgradesLabel.Name = "numgradesLabel"
        Me.numgradesLabel.Size = New System.Drawing.Size(100, 23)
        Me.numgradesLabel.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 221)
        Me.Controls.Add(Me.numgradesLabel)
        Me.Controls.Add(Me.gpaLabel)
        Me.Controls.Add(Me.hoursLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.enterdataButton)
        Me.Name = "Form1"
        Me.Text = "Cook College"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enterdataButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hoursLabel As Label
    Friend WithEvents gpaLabel As Label
    Friend WithEvents numgradesLabel As Label
End Class
