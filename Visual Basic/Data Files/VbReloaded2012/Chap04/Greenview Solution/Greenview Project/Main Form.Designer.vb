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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.duesLabel = New System.Windows.Forms.Label()
        Me.basicFeeTextBox = New System.Windows.Forms.TextBox()
        Me.tennisCheckBox = New System.Windows.Forms.CheckBox()
        Me.racquetballCheckBox = New System.Windows.Forms.CheckBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Greenview_Project.My.Resources.Resources.Greenview
        Me.PictureBox1.Location = New System.Drawing.Point(57, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 76)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Basic monthly fee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monthly dues:"
        '
        'duesLabel
        '
        Me.duesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.duesLabel.Location = New System.Drawing.Point(21, 225)
        Me.duesLabel.Name = "duesLabel"
        Me.duesLabel.Size = New System.Drawing.Size(130, 54)
        Me.duesLabel.TabIndex = 7
        Me.duesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'basicFeeTextBox
        '
        Me.basicFeeTextBox.Location = New System.Drawing.Point(21, 139)
        Me.basicFeeTextBox.Name = "basicFeeTextBox"
        Me.basicFeeTextBox.Size = New System.Drawing.Size(62, 27)
        Me.basicFeeTextBox.TabIndex = 1
        '
        'tennisCheckBox
        '
        Me.tennisCheckBox.AutoSize = True
        Me.tennisCheckBox.Location = New System.Drawing.Point(171, 116)
        Me.tennisCheckBox.Name = "tennisCheckBox"
        Me.tennisCheckBox.Size = New System.Drawing.Size(70, 24)
        Me.tennisCheckBox.TabIndex = 2
        Me.tennisCheckBox.Text = "&Tennis"
        Me.tennisCheckBox.UseVisualStyleBackColor = True
        '
        'racquetballCheckBox
        '
        Me.racquetballCheckBox.AutoSize = True
        Me.racquetballCheckBox.Location = New System.Drawing.Point(171, 146)
        Me.racquetballCheckBox.Name = "racquetballCheckBox"
        Me.racquetballCheckBox.Size = New System.Drawing.Size(107, 24)
        Me.racquetballCheckBox.TabIndex = 3
        Me.racquetballCheckBox.Text = "&Racquetball"
        Me.racquetballCheckBox.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(188, 201)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(133, 36)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate Dues"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(188, 243)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(133, 36)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 304)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.racquetballCheckBox)
        Me.Controls.Add(Me.tennisCheckBox)
        Me.Controls.Add(Me.basicFeeTextBox)
        Me.Controls.Add(Me.duesLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Greenview Health Club"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents duesLabel As System.Windows.Forms.Label
    Friend WithEvents basicFeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tennisCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents racquetballCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
