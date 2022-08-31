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
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.forNextButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.doLoopButton = New System.Windows.Forms.Button()
        Me.forEachNextButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total pounds used:"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(120, 45)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(74, 23)
        Me.totalLabel.TabIndex = 5
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Average pounds used:"
        '
        'averageLabel
        '
        Me.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.averageLabel.Location = New System.Drawing.Point(120, 97)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(74, 23)
        Me.averageLabel.TabIndex = 7
        Me.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'forNextButton
        '
        Me.forNextButton.Location = New System.Drawing.Point(286, 23)
        Me.forNextButton.Name = "forNextButton"
        Me.forNextButton.Size = New System.Drawing.Size(110, 27)
        Me.forNextButton.TabIndex = 0
        Me.forNextButton.Text = "&For...Next"
        Me.forNextButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(286, 128)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 27)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'doLoopButton
        '
        Me.doLoopButton.Location = New System.Drawing.Point(286, 56)
        Me.doLoopButton.Name = "doLoopButton"
        Me.doLoopButton.Size = New System.Drawing.Size(110, 27)
        Me.doLoopButton.TabIndex = 1
        Me.doLoopButton.Text = "&Do...Loop"
        Me.doLoopButton.UseVisualStyleBackColor = True
        '
        'forEachNextButton
        '
        Me.forEachNextButton.Location = New System.Drawing.Point(286, 89)
        Me.forEachNextButton.Name = "forEachNextButton"
        Me.forEachNextButton.Size = New System.Drawing.Size(110, 27)
        Me.forEachNextButton.TabIndex = 2
        Me.forEachNextButton.Text = "For &Each...Next"
        Me.forEachNextButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Starward_Coffee_Project.My.Resources.Resources.Coffee
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 175)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.forEachNextButton)
        Me.Controls.Add(Me.doLoopButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.forNextButton)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Starward Coffee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents averageLabel As System.Windows.Forms.Label
    Friend WithEvents forNextButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents doLoopButton As System.Windows.Forms.Button
    Friend WithEvents forEachNextButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
