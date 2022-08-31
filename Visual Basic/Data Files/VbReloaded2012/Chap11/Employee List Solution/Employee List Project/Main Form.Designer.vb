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
        Me.employTextBox = New System.Windows.Forms.TextBox()
        Me.writeButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.readButton = New System.Windows.Forms.Button()
        Me.employListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'employTextBox
        '
        Me.employTextBox.Location = New System.Drawing.Point(64, 23)
        Me.employTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.employTextBox.Name = "employTextBox"
        Me.employTextBox.Size = New System.Drawing.Size(212, 23)
        Me.employTextBox.TabIndex = 1
        '
        'writeButton
        '
        Me.writeButton.Location = New System.Drawing.Point(290, 19)
        Me.writeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.writeButton.Name = "writeButton"
        Me.writeButton.Size = New System.Drawing.Size(68, 29)
        Me.writeButton.TabIndex = 2
        Me.writeButton.Text = "&Write"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(290, 168)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(68, 29)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        '
        'readButton
        '
        Me.readButton.Location = New System.Drawing.Point(146, 86)
        Me.readButton.Margin = New System.Windows.Forms.Padding(2)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(68, 29)
        Me.readButton.TabIndex = 5
        Me.readButton.Text = "&Read"
        '
        'employListBox
        '
        Me.employListBox.FormattingEnabled = True
        Me.employListBox.ItemHeight = 15
        Me.employListBox.Location = New System.Drawing.Point(21, 103)
        Me.employListBox.Name = "employListBox"
        Me.employListBox.Size = New System.Drawing.Size(120, 94)
        Me.employListBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Employees:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 217)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.employListBox)
        Me.Controls.Add(Me.readButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.writeButton)
        Me.Controls.Add(Me.employTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents employTextBox As System.Windows.Forms.TextBox
    Friend WithEvents writeButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents readButton As System.Windows.Forms.Button
    Friend WithEvents employListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
