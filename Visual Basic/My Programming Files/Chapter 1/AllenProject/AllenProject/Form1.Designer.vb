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
        Me.primaryButton = New System.Windows.Forms.Button()
        Me.middleButton = New System.Windows.Forms.Button()
        Me.jrButton = New System.Windows.Forms.Button()
        Me.highButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.principalLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'primaryButton
        '
        Me.primaryButton.Location = New System.Drawing.Point(12, 52)
        Me.primaryButton.Name = "primaryButton"
        Me.primaryButton.Size = New System.Drawing.Size(135, 23)
        Me.primaryButton.TabIndex = 0
        Me.primaryButton.Text = "Primary Center"
        Me.primaryButton.UseVisualStyleBackColor = True
        '
        'middleButton
        '
        Me.middleButton.Location = New System.Drawing.Point(12, 81)
        Me.middleButton.Name = "middleButton"
        Me.middleButton.Size = New System.Drawing.Size(135, 23)
        Me.middleButton.TabIndex = 1
        Me.middleButton.Text = "Lewis Middle School"
        Me.middleButton.UseVisualStyleBackColor = True
        '
        'jrButton
        '
        Me.jrButton.Location = New System.Drawing.Point(12, 110)
        Me.jrButton.Name = "jrButton"
        Me.jrButton.Size = New System.Drawing.Size(135, 23)
        Me.jrButton.TabIndex = 2
        Me.jrButton.Text = "Kaufman Junior High"
        Me.jrButton.UseVisualStyleBackColor = True
        '
        'highButton
        '
        Me.highButton.Location = New System.Drawing.Point(12, 140)
        Me.highButton.Name = "highButton"
        Me.highButton.Size = New System.Drawing.Size(135, 23)
        Me.highButton.TabIndex = 3
        Me.highButton.Text = "Allen High School"
        Me.highButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(12, 170)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(135, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Principal:"
        '
        'principalLabel
        '
        Me.principalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.principalLabel.Location = New System.Drawing.Point(182, 70)
        Me.principalLabel.Name = "principalLabel"
        Me.principalLabel.Size = New System.Drawing.Size(131, 34)
        Me.principalLabel.TabIndex = 6
        Me.principalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Phone:"
        '
        'phoneLabel
        '
        Me.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneLabel.Location = New System.Drawing.Point(182, 128)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(131, 35)
        Me.phoneLabel.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(327, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 261)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.principalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.highButton)
        Me.Controls.Add(Me.jrButton)
        Me.Controls.Add(Me.middleButton)
        Me.Controls.Add(Me.primaryButton)
        Me.Name = "Form1"
        Me.Text = "Allen School District"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents primaryButton As Button
    Friend WithEvents middleButton As Button
    Friend WithEvents jrButton As Button
    Friend WithEvents highButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents principalLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
