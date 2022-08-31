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
        Me.operationTextBox = New System.Windows.Forms.TextBox()
        Me.decimalPlacesTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.secondTextBox = New System.Windows.Forms.TextBox()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Operation (A for Addition or M for Multiplication):"
        '
        'operationTextBox
        '
        Me.operationTextBox.Location = New System.Drawing.Point(104, 50)
        Me.operationTextBox.Name = "operationTextBox"
        Me.operationTextBox.Size = New System.Drawing.Size(38, 27)
        Me.operationTextBox.TabIndex = 1
        '
        'decimalPlacesTextBox
        '
        Me.decimalPlacesTextBox.Location = New System.Drawing.Point(104, 119)
        Me.decimalPlacesTextBox.Name = "decimalPlacesTextBox"
        Me.decimalPlacesTextBox.Size = New System.Drawing.Size(38, 27)
        Me.decimalPlacesTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Number of decimal places in output (1 or 2):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&First number:"
        '
        'firstTextBox
        '
        Me.firstTextBox.Location = New System.Drawing.Point(104, 188)
        Me.firstTextBox.Name = "firstTextBox"
        Me.firstTextBox.Size = New System.Drawing.Size(77, 27)
        Me.firstTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Second number:"
        '
        'secondTextBox
        '
        Me.secondTextBox.Location = New System.Drawing.Point(229, 188)
        Me.secondTextBox.Name = "secondTextBox"
        Me.secondTextBox.Size = New System.Drawing.Size(77, 27)
        Me.secondTextBox.TabIndex = 7
        '
        'answerLabel
        '
        Me.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerLabel.Location = New System.Drawing.Point(104, 239)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(338, 51)
        Me.answerLabel.TabIndex = 10
        Me.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Math_Project.My.Resources.Resources.Numbers
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(474, 27)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(94, 32)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(474, 65)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(94, 32)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 325)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.secondTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.firstTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.decimalPlacesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.operationTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents operationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents decimalPlacesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents firstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents secondTextBox As System.Windows.Forms.TextBox
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
