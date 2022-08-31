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
        Me.highestLabel = New System.Windows.Forms.Label()
        Me.highestButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.salespeopleLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Highest commission:"
        '
        'highestLabel
        '
        Me.highestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.highestLabel.Location = New System.Drawing.Point(329, 9)
        Me.highestLabel.Name = "highestLabel"
        Me.highestLabel.Size = New System.Drawing.Size(65, 25)
        Me.highestLabel.TabIndex = 3
        Me.highestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'highestButton
        '
        Me.highestButton.Location = New System.Drawing.Point(198, 87)
        Me.highestButton.Name = "highestButton"
        Me.highestButton.Size = New System.Drawing.Size(102, 27)
        Me.highestButton.TabIndex = 0
        Me.highestButton.Text = "&Get Highest"
        Me.highestButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(306, 87)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(88, 27)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of salespeople:"
        '
        'salespeopleLabel
        '
        Me.salespeopleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salespeopleLabel.Location = New System.Drawing.Point(349, 43)
        Me.salespeopleLabel.Name = "salespeopleLabel"
        Me.salespeopleLabel.Size = New System.Drawing.Size(45, 27)
        Me.salespeopleLabel.TabIndex = 5
        Me.salespeopleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Car_Mart_Project.My.Resources.Resources.Car
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 135)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.salespeopleLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.highestButton)
        Me.Controls.Add(Me.highestLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car-Mart"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents highestLabel As System.Windows.Forms.Label
    Friend WithEvents highestButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents salespeopleLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
