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
        Me.USTextbox = New System.Windows.Forms.TextBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.CanadianRadioButton = New System.Windows.Forms.RadioButton()
        Me.EuroRadioButton = New System.Windows.Forms.RadioButton()
        Me.RupeeRadioButton = New System.Windows.Forms.RadioButton()
        Me.YenRadioButton = New System.Windows.Forms.RadioButton()
        Me.PesoRadioButton = New System.Windows.Forms.RadioButton()
        Me.RandRadioButton = New System.Windows.Forms.RadioButton()
        Me.PoundRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.convertedLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'USTextbox
        '
        Me.USTextbox.Location = New System.Drawing.Point(12, 25)
        Me.USTextbox.Name = "USTextbox"
        Me.USTextbox.Size = New System.Drawing.Size(100, 20)
        Me.USTextbox.TabIndex = 0
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(12, 223)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(93, 40)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'convertButton
        '
        Me.convertButton.Location = New System.Drawing.Point(12, 177)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(93, 40)
        Me.convertButton.TabIndex = 2
        Me.convertButton.Text = "Convert"
        Me.convertButton.UseVisualStyleBackColor = True
        '
        'CanadianRadioButton
        '
        Me.CanadianRadioButton.AutoSize = True
        Me.CanadianRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.CanadianRadioButton.Name = "CanadianRadioButton"
        Me.CanadianRadioButton.Size = New System.Drawing.Size(100, 17)
        Me.CanadianRadioButton.TabIndex = 3
        Me.CanadianRadioButton.TabStop = True
        Me.CanadianRadioButton.Text = "Canadian Dollar"
        Me.CanadianRadioButton.UseVisualStyleBackColor = True
        '
        'EuroRadioButton
        '
        Me.EuroRadioButton.AutoSize = True
        Me.EuroRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.EuroRadioButton.Name = "EuroRadioButton"
        Me.EuroRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.EuroRadioButton.TabIndex = 4
        Me.EuroRadioButton.TabStop = True
        Me.EuroRadioButton.Text = "Euro"
        Me.EuroRadioButton.UseVisualStyleBackColor = True
        '
        'RupeeRadioButton
        '
        Me.RupeeRadioButton.AutoSize = True
        Me.RupeeRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.RupeeRadioButton.Name = "RupeeRadioButton"
        Me.RupeeRadioButton.Size = New System.Drawing.Size(89, 17)
        Me.RupeeRadioButton.TabIndex = 5
        Me.RupeeRadioButton.TabStop = True
        Me.RupeeRadioButton.Text = "Indian Rupee"
        Me.RupeeRadioButton.UseVisualStyleBackColor = True
        '
        'YenRadioButton
        '
        Me.YenRadioButton.AutoSize = True
        Me.YenRadioButton.Location = New System.Drawing.Point(6, 88)
        Me.YenRadioButton.Name = "YenRadioButton"
        Me.YenRadioButton.Size = New System.Drawing.Size(93, 17)
        Me.YenRadioButton.TabIndex = 6
        Me.YenRadioButton.TabStop = True
        Me.YenRadioButton.Text = "Japanese Yen"
        Me.YenRadioButton.UseVisualStyleBackColor = True
        '
        'PesoRadioButton
        '
        Me.PesoRadioButton.AutoSize = True
        Me.PesoRadioButton.Location = New System.Drawing.Point(6, 111)
        Me.PesoRadioButton.Name = "PesoRadioButton"
        Me.PesoRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.PesoRadioButton.TabIndex = 7
        Me.PesoRadioButton.TabStop = True
        Me.PesoRadioButton.Text = "Mexican Peso"
        Me.PesoRadioButton.UseVisualStyleBackColor = True
        '
        'RandRadioButton
        '
        Me.RandRadioButton.AutoSize = True
        Me.RandRadioButton.Location = New System.Drawing.Point(6, 134)
        Me.RandRadioButton.Name = "RandRadioButton"
        Me.RandRadioButton.Size = New System.Drawing.Size(118, 17)
        Me.RandRadioButton.TabIndex = 8
        Me.RandRadioButton.TabStop = True
        Me.RandRadioButton.Text = "South African Rand"
        Me.RandRadioButton.UseVisualStyleBackColor = True
        '
        'PoundRadioButton
        '
        Me.PoundRadioButton.AutoSize = True
        Me.PoundRadioButton.Location = New System.Drawing.Point(6, 157)
        Me.PoundRadioButton.Name = "PoundRadioButton"
        Me.PoundRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.PoundRadioButton.TabIndex = 9
        Me.PoundRadioButton.TabStop = True
        Me.PoundRadioButton.Text = "British Pound"
        Me.PoundRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CanadianRadioButton)
        Me.GroupBox1.Controls.Add(Me.PoundRadioButton)
        Me.GroupBox1.Controls.Add(Me.EuroRadioButton)
        Me.GroupBox1.Controls.Add(Me.RandRadioButton)
        Me.GroupBox1.Controls.Add(Me.RupeeRadioButton)
        Me.GroupBox1.Controls.Add(Me.PesoRadioButton)
        Me.GroupBox1.Controls.Add(Me.YenRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(199, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 183)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Foreign Currency"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "US Dollars"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Converted Currency"
        '
        'convertedLabel
        '
        Me.convertedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.convertedLabel.Location = New System.Drawing.Point(12, 103)
        Me.convertedLabel.Name = "convertedLabel"
        Me.convertedLabel.Size = New System.Drawing.Size(100, 23)
        Me.convertedLabel.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 303)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.convertedLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.USTextbox)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents USTextbox As TextBox
    Friend WithEvents exitButton As Button
    Friend WithEvents convertButton As Button
    Friend WithEvents CanadianRadioButton As RadioButton
    Friend WithEvents EuroRadioButton As RadioButton
    Friend WithEvents RupeeRadioButton As RadioButton
    Friend WithEvents YenRadioButton As RadioButton
    Friend WithEvents PesoRadioButton As RadioButton
    Friend WithEvents RandRadioButton As RadioButton
    Friend WithEvents PoundRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents convertedLabel As Label
    Friend WithEvents Label4 As Label
End Class
