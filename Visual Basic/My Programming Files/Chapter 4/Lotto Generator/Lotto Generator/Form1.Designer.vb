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
        Me.numbersLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numbersButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'numbersLabel
        '
        Me.numbersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numbersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numbersLabel.Location = New System.Drawing.Point(12, 31)
        Me.numbersLabel.Name = "numbersLabel"
        Me.numbersLabel.Size = New System.Drawing.Size(323, 49)
        Me.numbersLabel.TabIndex = 0
        Me.numbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lottery Numbers"
        '
        'numbersButton
        '
        Me.numbersButton.Location = New System.Drawing.Point(12, 98)
        Me.numbersButton.Name = "numbersButton"
        Me.numbersButton.Size = New System.Drawing.Size(150, 39)
        Me.numbersButton.TabIndex = 2
        Me.numbersButton.Text = "Generate Numbers"
        Me.numbersButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(185, 98)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(150, 39)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 163)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.numbersButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numbersLabel)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Lottery Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numbersLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numbersButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label3 As Label
End Class
