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
        Me.BillBox = New System.Windows.Forms.TextBox()
        Me.calcbutton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tip10Label = New System.Windows.Forms.Label()
        Me.tip15Label = New System.Windows.Forms.Label()
        Me.tip20Label = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BillBox
        '
        Me.BillBox.Location = New System.Drawing.Point(30, 27)
        Me.BillBox.Name = "BillBox"
        Me.BillBox.Size = New System.Drawing.Size(100, 20)
        Me.BillBox.TabIndex = 0
        '
        'calcbutton
        '
        Me.calcbutton.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcbutton.Location = New System.Drawing.Point(153, 58)
        Me.calcbutton.Name = "calcbutton"
        Me.calcbutton.Size = New System.Drawing.Size(98, 39)
        Me.calcbutton.TabIndex = 1
        Me.calcbutton.Text = "Calculate"
        Me.calcbutton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(153, 103)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(98, 39)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(153, 148)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(98, 39)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bill"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "10% Tip"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "15% Tip"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "20% Tip"
        '
        'tip10Label
        '
        Me.tip10Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tip10Label.Location = New System.Drawing.Point(30, 72)
        Me.tip10Label.Name = "tip10Label"
        Me.tip10Label.Size = New System.Drawing.Size(100, 23)
        Me.tip10Label.TabIndex = 8
        Me.tip10Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tip15Label
        '
        Me.tip15Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tip15Label.Location = New System.Drawing.Point(30, 125)
        Me.tip15Label.Name = "tip15Label"
        Me.tip15Label.Size = New System.Drawing.Size(100, 23)
        Me.tip15Label.TabIndex = 9
        Me.tip15Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tip20Label
        '
        Me.tip20Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tip20Label.Location = New System.Drawing.Point(30, 177)
        Me.tip20Label.Name = "tip20Label"
        Me.tip20Label.Size = New System.Drawing.Size(100, 23)
        Me.tip20Label.TabIndex = 10
        Me.tip20Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(149, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "By Jake Gudenkauf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 217)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tip20Label)
        Me.Controls.Add(Me.tip15Label)
        Me.Controls.Add(Me.tip10Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcbutton)
        Me.Controls.Add(Me.BillBox)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BillBox As TextBox
    Friend WithEvents calcbutton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tip10Label As Label
    Friend WithEvents tip15Label As Label
    Friend WithEvents tip20Label As Label
    Friend WithEvents Label8 As Label
End Class
