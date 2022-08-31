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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.score1Textbox = New System.Windows.Forms.TextBox()
        Me.score2Textbox = New System.Windows.Forms.TextBox()
        Me.score3Textbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.avgScoreLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Score 3"
        '
        'score1Textbox
        '
        Me.score1Textbox.Location = New System.Drawing.Point(116, 33)
        Me.score1Textbox.Name = "score1Textbox"
        Me.score1Textbox.Size = New System.Drawing.Size(100, 20)
        Me.score1Textbox.TabIndex = 3
        '
        'score2Textbox
        '
        Me.score2Textbox.Location = New System.Drawing.Point(116, 85)
        Me.score2Textbox.Name = "score2Textbox"
        Me.score2Textbox.Size = New System.Drawing.Size(100, 20)
        Me.score2Textbox.TabIndex = 4
        '
        'score3Textbox
        '
        Me.score3Textbox.Location = New System.Drawing.Point(116, 134)
        Me.score3Textbox.Name = "score3Textbox"
        Me.score3Textbox.Size = New System.Drawing.Size(100, 20)
        Me.score3Textbox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Average"
        '
        'avgScoreLabel
        '
        Me.avgScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.avgScoreLabel.Location = New System.Drawing.Point(116, 171)
        Me.avgScoreLabel.Name = "avgScoreLabel"
        Me.avgScoreLabel.Size = New System.Drawing.Size(100, 23)
        Me.avgScoreLabel.TabIndex = 7
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(13, 226)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(94, 226)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 9
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(177, 226)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.avgScoreLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.score3Textbox)
        Me.Controls.Add(Me.score2Textbox)
        Me.Controls.Add(Me.score1Textbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Average Calculator "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents score1Textbox As TextBox
    Friend WithEvents score2Textbox As TextBox
    Friend WithEvents score3Textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents avgScoreLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
