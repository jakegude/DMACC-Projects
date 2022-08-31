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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.dRadioButton = New System.Windows.Forms.RadioButton()
        Me.cRadioButton = New System.Windows.Forms.RadioButton()
        Me.bRadioButton = New System.Windows.Forms.RadioButton()
        Me.aRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dTextBox = New System.Windows.Forms.TextBox()
        Me.cTextBox = New System.Windows.Forms.TextBox()
        Me.bTextBox = New System.Windows.Forms.TextBox()
        Me.aTextBox = New System.Windows.Forms.TextBox()
        Me.questionTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(398, 347)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(107, 37)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(287, 347)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(107, 37)
        Me.submitButton.TabIndex = 0
        Me.submitButton.Text = "&Submit Answer"
        '
        'dRadioButton
        '
        Me.dRadioButton.AutoSize = True
        Me.dRadioButton.Location = New System.Drawing.Point(25, 286)
        Me.dRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.dRadioButton.Name = "dRadioButton"
        Me.dRadioButton.Size = New System.Drawing.Size(35, 21)
        Me.dRadioButton.TabIndex = 10
        Me.dRadioButton.Text = "&D"
        '
        'cRadioButton
        '
        Me.cRadioButton.AutoSize = True
        Me.cRadioButton.Location = New System.Drawing.Point(25, 233)
        Me.cRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cRadioButton.Name = "cRadioButton"
        Me.cRadioButton.Size = New System.Drawing.Size(34, 21)
        Me.cRadioButton.TabIndex = 8
        Me.cRadioButton.Text = "&C"
        '
        'bRadioButton
        '
        Me.bRadioButton.AutoSize = True
        Me.bRadioButton.Location = New System.Drawing.Point(25, 179)
        Me.bRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.bRadioButton.Name = "bRadioButton"
        Me.bRadioButton.Size = New System.Drawing.Size(33, 21)
        Me.bRadioButton.TabIndex = 6
        Me.bRadioButton.Text = "&B"
        '
        'aRadioButton
        '
        Me.aRadioButton.AutoSize = True
        Me.aRadioButton.Checked = True
        Me.aRadioButton.Location = New System.Drawing.Point(25, 127)
        Me.aRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.aRadioButton.Name = "aRadioButton"
        Me.aRadioButton.Size = New System.Drawing.Size(34, 21)
        Me.aRadioButton.TabIndex = 4
        Me.aRadioButton.TabStop = True
        Me.aRadioButton.Text = "&A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Question:"
        '
        'dTextBox
        '
        Me.dTextBox.Location = New System.Drawing.Point(69, 286)
        Me.dTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.dTextBox.Multiline = True
        Me.dTextBox.Name = "dTextBox"
        Me.dTextBox.ReadOnly = True
        Me.dTextBox.Size = New System.Drawing.Size(436, 47)
        Me.dTextBox.TabIndex = 11
        Me.dTextBox.TabStop = False
        '
        'cTextBox
        '
        Me.cTextBox.Location = New System.Drawing.Point(69, 233)
        Me.cTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.cTextBox.Multiline = True
        Me.cTextBox.Name = "cTextBox"
        Me.cTextBox.ReadOnly = True
        Me.cTextBox.Size = New System.Drawing.Size(436, 47)
        Me.cTextBox.TabIndex = 9
        Me.cTextBox.TabStop = False
        '
        'bTextBox
        '
        Me.bTextBox.Location = New System.Drawing.Point(69, 179)
        Me.bTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.bTextBox.Multiline = True
        Me.bTextBox.Name = "bTextBox"
        Me.bTextBox.ReadOnly = True
        Me.bTextBox.Size = New System.Drawing.Size(436, 47)
        Me.bTextBox.TabIndex = 7
        Me.bTextBox.TabStop = False
        '
        'aTextBox
        '
        Me.aTextBox.Location = New System.Drawing.Point(69, 126)
        Me.aTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.aTextBox.Multiline = True
        Me.aTextBox.Name = "aTextBox"
        Me.aTextBox.ReadOnly = True
        Me.aTextBox.Size = New System.Drawing.Size(436, 47)
        Me.aTextBox.TabIndex = 5
        Me.aTextBox.TabStop = False
        '
        'questionTextBox
        '
        Me.questionTextBox.Location = New System.Drawing.Point(24, 44)
        Me.questionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.questionTextBox.Multiline = True
        Me.questionTextBox.Name = "questionTextBox"
        Me.questionTextBox.ReadOnly = True
        Me.questionTextBox.Size = New System.Drawing.Size(481, 60)
        Me.questionTextBox.TabIndex = 3
        Me.questionTextBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 402)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.dRadioButton)
        Me.Controls.Add(Me.cRadioButton)
        Me.Controls.Add(Me.bRadioButton)
        Me.Controls.Add(Me.aRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dTextBox)
        Me.Controls.Add(Me.cTextBox)
        Me.Controls.Add(Me.bTextBox)
        Me.Controls.Add(Me.aTextBox)
        Me.Controls.Add(Me.questionTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trivia Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents dRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents cRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents bRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents aRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bTextBox As System.Windows.Forms.TextBox
    Friend WithEvents aTextBox As System.Windows.Forms.TextBox
    Friend WithEvents questionTextBox As System.Windows.Forms.TextBox

End Class
