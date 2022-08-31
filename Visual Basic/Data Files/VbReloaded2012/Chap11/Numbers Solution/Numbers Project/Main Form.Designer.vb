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
        Me.displayButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.numbersListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numbers:"
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(105, 29)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(74, 31)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(105, 67)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(74, 31)
        Me.updateButton.TabIndex = 1
        Me.updateButton.Text = "&Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(105, 104)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(74, 31)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'numbersListBox
        '
        Me.numbersListBox.FormattingEnabled = True
        Me.numbersListBox.ItemHeight = 17
        Me.numbersListBox.Location = New System.Drawing.Point(16, 29)
        Me.numbersListBox.Name = "numbersListBox"
        Me.numbersListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.numbersListBox.Size = New System.Drawing.Size(68, 106)
        Me.numbersListBox.TabIndex = 4
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 175)
        Me.Controls.Add(Me.numbersListBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents numbersListBox As System.Windows.Forms.ListBox

End Class
