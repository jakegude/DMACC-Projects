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
        Me.firstTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lastTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fullLabel = New System.Windows.Forms.Label()
        Me.concatenateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&First name:"
        '
        'firstTextBox
        '
        Me.firstTextBox.Location = New System.Drawing.Point(83, 10)
        Me.firstTextBox.Name = "firstTextBox"
        Me.firstTextBox.Size = New System.Drawing.Size(117, 25)
        Me.firstTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Last name:"
        '
        'lastTextBox
        '
        Me.lastTextBox.Location = New System.Drawing.Point(83, 49)
        Me.lastTextBox.Name = "lastTextBox"
        Me.lastTextBox.Size = New System.Drawing.Size(117, 25)
        Me.lastTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Full name:"
        '
        'fullLabel
        '
        Me.fullLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullLabel.Location = New System.Drawing.Point(83, 96)
        Me.fullLabel.Name = "fullLabel"
        Me.fullLabel.Size = New System.Drawing.Size(239, 26)
        Me.fullLabel.TabIndex = 7
        Me.fullLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'concatenateButton
        '
        Me.concatenateButton.Location = New System.Drawing.Point(225, 10)
        Me.concatenateButton.Name = "concatenateButton"
        Me.concatenateButton.Size = New System.Drawing.Size(97, 31)
        Me.concatenateButton.TabIndex = 4
        Me.concatenateButton.Text = "&Concatenate"
        Me.concatenateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(225, 45)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(97, 31)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 151)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.concatenateButton)
        Me.Controls.Add(Me.fullLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lastTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.firstTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Full Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents firstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fullLabel As System.Windows.Forms.Label
    Friend WithEvents concatenateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
