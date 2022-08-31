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
        Me.helloButton = New System.Windows.Forms.Button()
        Me.byeButton = New System.Windows.Forms.Button()
        Me.loveButton = New System.Windows.Forms.Button()
        Me.catButton = New System.Windows.Forms.Button()
        Me.dogButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'helloButton
        '
        Me.helloButton.Location = New System.Drawing.Point(12, 36)
        Me.helloButton.Name = "helloButton"
        Me.helloButton.Size = New System.Drawing.Size(75, 23)
        Me.helloButton.TabIndex = 0
        Me.helloButton.Text = "Hello"
        Me.helloButton.UseVisualStyleBackColor = True
        '
        'byeButton
        '
        Me.byeButton.Location = New System.Drawing.Point(12, 65)
        Me.byeButton.Name = "byeButton"
        Me.byeButton.Size = New System.Drawing.Size(75, 23)
        Me.byeButton.TabIndex = 1
        Me.byeButton.Text = "Good-bye"
        Me.byeButton.UseVisualStyleBackColor = True
        '
        'loveButton
        '
        Me.loveButton.Location = New System.Drawing.Point(12, 95)
        Me.loveButton.Name = "loveButton"
        Me.loveButton.Size = New System.Drawing.Size(75, 23)
        Me.loveButton.TabIndex = 2
        Me.loveButton.Text = "Love"
        Me.loveButton.UseVisualStyleBackColor = True
        '
        'catButton
        '
        Me.catButton.Location = New System.Drawing.Point(12, 125)
        Me.catButton.Name = "catButton"
        Me.catButton.Size = New System.Drawing.Size(75, 23)
        Me.catButton.TabIndex = 3
        Me.catButton.Text = "Cat"
        Me.catButton.UseVisualStyleBackColor = True
        '
        'dogButton
        '
        Me.dogButton.Location = New System.Drawing.Point(12, 155)
        Me.dogButton.Name = "dogButton"
        Me.dogButton.Size = New System.Drawing.Size(75, 23)
        Me.dogButton.TabIndex = 4
        Me.dogButton.Text = "Dog"
        Me.dogButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(12, 185)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Spanish:"
        '
        'outputLabel
        '
        Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputLabel.Location = New System.Drawing.Point(194, 155)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(100, 23)
        Me.outputLabel.TabIndex = 7
        Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(140, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 299)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.dogButton)
        Me.Controls.Add(Me.catButton)
        Me.Controls.Add(Me.loveButton)
        Me.Controls.Add(Me.byeButton)
        Me.Controls.Add(Me.helloButton)
        Me.Name = "Form1"
        Me.Text = "Elvira Learing Center"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents helloButton As Button
    Friend WithEvents byeButton As Button
    Friend WithEvents loveButton As Button
    Friend WithEvents catButton As Button
    Friend WithEvents dogButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents outputLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
