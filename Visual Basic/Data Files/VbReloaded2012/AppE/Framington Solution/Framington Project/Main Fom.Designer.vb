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
        Me.guestsTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.table10Label = New System.Windows.Forms.Label()
        Me.table5Label = New System.Windows.Forms.Label()
        Me.remainLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of &guests:"
        '
        'guestsTextBox
        '
        Me.guestsTextBox.Location = New System.Drawing.Point(147, 24)
        Me.guestsTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.guestsTextBox.Name = "guestsTextBox"
        Me.guestsTextBox.Size = New System.Drawing.Size(57, 27)
        Me.guestsTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tables for 10:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tables for 5:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Guests remaining:"
        '
        'table10Label
        '
        Me.table10Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.table10Label.Location = New System.Drawing.Point(18, 121)
        Me.table10Label.Name = "table10Label"
        Me.table10Label.Size = New System.Drawing.Size(58, 36)
        Me.table10Label.TabIndex = 7
        Me.table10Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'table5Label
        '
        Me.table5Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.table5Label.Location = New System.Drawing.Point(146, 121)
        Me.table5Label.Name = "table5Label"
        Me.table5Label.Size = New System.Drawing.Size(58, 36)
        Me.table5Label.TabIndex = 8
        Me.table5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'remainLabel
        '
        Me.remainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.remainLabel.Location = New System.Drawing.Point(264, 121)
        Me.remainLabel.Name = "remainLabel"
        Me.remainLabel.Size = New System.Drawing.Size(58, 36)
        Me.remainLabel.TabIndex = 9
        Me.remainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(237, 18)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(86, 38)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(329, 18)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 38)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 194)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.remainLabel)
        Me.Controls.Add(Me.table5Label)
        Me.Controls.Add(Me.table10Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.guestsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Framington Parties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents guestsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents table10Label As System.Windows.Forms.Label
    Friend WithEvents table5Label As System.Windows.Forms.Label
    Friend WithEvents remainLabel As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
