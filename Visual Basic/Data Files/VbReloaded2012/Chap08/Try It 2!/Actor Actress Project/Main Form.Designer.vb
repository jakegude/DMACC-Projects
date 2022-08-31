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
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.actorRadioButton = New System.Windows.Forms.RadioButton()
        Me.actressRadioButton = New System.Windows.Forms.RadioButton()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'msgLabel
        '
        Me.msgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msgLabel.Location = New System.Drawing.Point(12, 94)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(355, 69)
        Me.msgLabel.TabIndex = 4
        Me.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'actorRadioButton
        '
        Me.actorRadioButton.AutoSize = True
        Me.actorRadioButton.Checked = True
        Me.actorRadioButton.Location = New System.Drawing.Point(35, 30)
        Me.actorRadioButton.Name = "actorRadioButton"
        Me.actorRadioButton.Size = New System.Drawing.Size(63, 24)
        Me.actorRadioButton.TabIndex = 2
        Me.actorRadioButton.TabStop = True
        Me.actorRadioButton.Text = "&Actor"
        Me.actorRadioButton.UseVisualStyleBackColor = True
        '
        'actressRadioButton
        '
        Me.actressRadioButton.AutoSize = True
        Me.actressRadioButton.Location = New System.Drawing.Point(35, 60)
        Me.actressRadioButton.Name = "actressRadioButton"
        Me.actressRadioButton.Size = New System.Drawing.Size(74, 24)
        Me.actressRadioButton.TabIndex = 3
        Me.actressRadioButton.Text = "Actre&ss"
        Me.actressRadioButton.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(148, 30)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(132, 37)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display Favorite"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(286, 30)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(77, 37)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 199)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.actressRadioButton)
        Me.Controls.Add(Me.actorRadioButton)
        Me.Controls.Add(Me.msgLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actor/Actress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msgLabel As System.Windows.Forms.Label
    Friend WithEvents actorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents actressRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
