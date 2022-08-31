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
        Me.citiesListBox = New System.Windows.Forms.ListBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'citiesListBox
        '
        Me.citiesListBox.FormattingEnabled = True
        Me.citiesListBox.ItemHeight = 20
        Me.citiesListBox.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas"})
        Me.citiesListBox.Location = New System.Drawing.Point(37, 25)
        Me.citiesListBox.Name = "citiesListBox"
        Me.citiesListBox.Size = New System.Drawing.Size(120, 124)
        Me.citiesListBox.TabIndex = 0
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(182, 25)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 32)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 166)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.citiesListBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cities"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents citiesListBox As System.Windows.Forms.ListBox
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
