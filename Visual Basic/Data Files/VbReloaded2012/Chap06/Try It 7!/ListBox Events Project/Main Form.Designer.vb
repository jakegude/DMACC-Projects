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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.animalListBox = New System.Windows.Forms.ListBox()
        Me.codeListBox = New System.Windows.Forms.ListBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.animalLabel = New System.Windows.Forms.Label()
        Me.deptLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Animals:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Codes:"
        '
        'animalListBox
        '
        Me.animalListBox.FormattingEnabled = True
        Me.animalListBox.ItemHeight = 20
        Me.animalListBox.Location = New System.Drawing.Point(25, 47)
        Me.animalListBox.Name = "animalListBox"
        Me.animalListBox.Size = New System.Drawing.Size(80, 84)
        Me.animalListBox.Sorted = True
        Me.animalListBox.TabIndex = 2
        '
        'codeListBox
        '
        Me.codeListBox.FormattingEnabled = True
        Me.codeListBox.ItemHeight = 20
        Me.codeListBox.Location = New System.Drawing.Point(147, 47)
        Me.codeListBox.Name = "codeListBox"
        Me.codeListBox.Size = New System.Drawing.Size(80, 124)
        Me.codeListBox.TabIndex = 4
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(249, 23)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 29)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Animal's name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Department name:"
        '
        'animalLabel
        '
        Me.animalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.animalLabel.Location = New System.Drawing.Point(29, 223)
        Me.animalLabel.Name = "animalLabel"
        Me.animalLabel.Size = New System.Drawing.Size(105, 36)
        Me.animalLabel.TabIndex = 7
        Me.animalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'deptLabel
        '
        Me.deptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.deptLabel.Location = New System.Drawing.Point(151, 223)
        Me.deptLabel.Name = "deptLabel"
        Me.deptLabel.Size = New System.Drawing.Size(129, 36)
        Me.deptLabel.TabIndex = 8
        Me.deptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 298)
        Me.Controls.Add(Me.deptLabel)
        Me.Controls.Add(Me.animalLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.codeListBox)
        Me.Controls.Add(Me.animalListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListBox Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents animalListBox As System.Windows.Forms.ListBox
    Friend WithEvents codeListBox As System.Windows.Forms.ListBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents animalLabel As System.Windows.Forms.Label
    Friend WithEvents deptLabel As System.Windows.Forms.Label

End Class
