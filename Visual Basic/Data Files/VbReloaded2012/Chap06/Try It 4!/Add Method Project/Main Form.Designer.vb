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
        Me.animalListBox.TabIndex = 2
        '
        'codeListBox
        '
        Me.codeListBox.FormattingEnabled = True
        Me.codeListBox.ItemHeight = 20
        Me.codeListBox.Location = New System.Drawing.Point(147, 47)
        Me.codeListBox.Name = "codeListBox"
        Me.codeListBox.Size = New System.Drawing.Size(80, 84)
        Me.codeListBox.TabIndex = 4
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(244, 102)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 29)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 163)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.codeListBox)
        Me.Controls.Add(Me.animalListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Method Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents animalListBox As System.Windows.Forms.ListBox
    Friend WithEvents codeListBox As System.Windows.Forms.ListBox
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
