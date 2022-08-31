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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.redTextBox = New System.Windows.Forms.TextBox()
        Me.greenTextBox = New System.Windows.Forms.TextBox()
        Me.blueTextBox = New System.Windows.Forms.TextBox()
        Me.viewButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Red (0 to 255):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Green (0 to 255):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Blue (0 to 255):"
        '
        'redTextBox
        '
        Me.redTextBox.Location = New System.Drawing.Point(156, 41)
        Me.redTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.redTextBox.Name = "redTextBox"
        Me.redTextBox.Size = New System.Drawing.Size(60, 27)
        Me.redTextBox.TabIndex = 1
        '
        'greenTextBox
        '
        Me.greenTextBox.Location = New System.Drawing.Point(156, 89)
        Me.greenTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.greenTextBox.Name = "greenTextBox"
        Me.greenTextBox.Size = New System.Drawing.Size(60, 27)
        Me.greenTextBox.TabIndex = 3
        '
        'blueTextBox
        '
        Me.blueTextBox.Location = New System.Drawing.Point(156, 137)
        Me.blueTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.blueTextBox.Name = "blueTextBox"
        Me.blueTextBox.Size = New System.Drawing.Size(60, 27)
        Me.blueTextBox.TabIndex = 5
        '
        'viewButton
        '
        Me.viewButton.Location = New System.Drawing.Point(39, 193)
        Me.viewButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.viewButton.Name = "viewButton"
        Me.viewButton.Size = New System.Drawing.Size(101, 32)
        Me.viewButton.TabIndex = 6
        Me.viewButton.Text = "&View Color"
        Me.viewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(146, 193)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(70, 32)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 269)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.viewButton)
        Me.Controls.Add(Me.blueTextBox)
        Me.Controls.Add(Me.greenTextBox)
        Me.Controls.Add(Me.redTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Mixer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents redTextBox As System.Windows.Forms.TextBox
    Friend WithEvents greenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents blueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents viewButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
