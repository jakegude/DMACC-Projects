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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OBox = New System.Windows.Forms.TextBox()
        Me.MBox = New System.Windows.Forms.TextBox()
        Me.BBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ORLabel = New System.Windows.Forms.Label()
        Me.MRLabel = New System.Windows.Forms.Label()
        Me.BRLabel = New System.Windows.Forms.Label()
        Me.OPLabel = New System.Windows.Forms.Label()
        Me.MPLabel = New System.Windows.Forms.Label()
        Me.BPLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TRLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OBox
        '
        Me.OBox.Location = New System.Drawing.Point(175, 63)
        Me.OBox.Name = "OBox"
        Me.OBox.Size = New System.Drawing.Size(58, 20)
        Me.OBox.TabIndex = 0
        '
        'MBox
        '
        Me.MBox.Location = New System.Drawing.Point(175, 105)
        Me.MBox.Name = "MBox"
        Me.MBox.Size = New System.Drawing.Size(58, 20)
        Me.MBox.TabIndex = 1
        '
        'BBox
        '
        Me.BBox.Location = New System.Drawing.Point(175, 148)
        Me.BBox.Name = "BBox"
        Me.BBox.Size = New System.Drawing.Size(58, 20)
        Me.BBox.TabIndex = 2
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(300, 200)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 3
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(382, 199)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "&Orchestra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Main Floor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "&Balcony"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tickets"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "% of Revenue"
        '
        'ORLabel
        '
        Me.ORLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ORLabel.Location = New System.Drawing.Point(300, 63)
        Me.ORLabel.Name = "ORLabel"
        Me.ORLabel.Size = New System.Drawing.Size(48, 20)
        Me.ORLabel.TabIndex = 11
        '
        'MRLabel
        '
        Me.MRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MRLabel.Location = New System.Drawing.Point(300, 105)
        Me.MRLabel.Name = "MRLabel"
        Me.MRLabel.Size = New System.Drawing.Size(48, 20)
        Me.MRLabel.TabIndex = 12
        '
        'BRLabel
        '
        Me.BRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BRLabel.Location = New System.Drawing.Point(300, 148)
        Me.BRLabel.Name = "BRLabel"
        Me.BRLabel.Size = New System.Drawing.Size(48, 20)
        Me.BRLabel.TabIndex = 13
        '
        'OPLabel
        '
        Me.OPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OPLabel.Location = New System.Drawing.Point(382, 63)
        Me.OPLabel.Name = "OPLabel"
        Me.OPLabel.Size = New System.Drawing.Size(48, 20)
        Me.OPLabel.TabIndex = 14
        '
        'MPLabel
        '
        Me.MPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MPLabel.Location = New System.Drawing.Point(382, 105)
        Me.MPLabel.Name = "MPLabel"
        Me.MPLabel.Size = New System.Drawing.Size(48, 20)
        Me.MPLabel.TabIndex = 15
        '
        'BPLabel
        '
        Me.BPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BPLabel.Location = New System.Drawing.Point(382, 148)
        Me.BPLabel.Name = "BPLabel"
        Me.BPLabel.Size = New System.Drawing.Size(48, 20)
        Me.BPLabel.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(102, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Total Revenue: "
        '
        'TRLabel
        '
        Me.TRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRLabel.Location = New System.Drawing.Point(192, 204)
        Me.TRLabel.Name = "TRLabel"
        Me.TRLabel.Size = New System.Drawing.Size(62, 23)
        Me.TRLabel.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(385, 257)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "By Jake Gudenkauf"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(300, 230)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(156, 23)
        Me.exitButton.TabIndex = 21
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 276)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TRLabel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BPLabel)
        Me.Controls.Add(Me.MPLabel)
        Me.Controls.Add(Me.OPLabel)
        Me.Controls.Add(Me.BRLabel)
        Me.Controls.Add(Me.MRLabel)
        Me.Controls.Add(Me.ORLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.BBox)
        Me.Controls.Add(Me.MBox)
        Me.Controls.Add(Me.OBox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Myran Mustic Hall"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OBox As TextBox
    Friend WithEvents MBox As TextBox
    Friend WithEvents BBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ORLabel As Label
    Friend WithEvents MRLabel As Label
    Friend WithEvents BRLabel As Label
    Friend WithEvents OPLabel As Label
    Friend WithEvents MPLabel As Label
    Friend WithEvents BPLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TRLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitButton As Button
End Class
