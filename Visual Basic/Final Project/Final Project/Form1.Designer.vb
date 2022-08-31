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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.onionringsCheckbox = New System.Windows.Forms.CheckBox()
        Me.picklesCheckbox = New System.Windows.Forms.CheckBox()
        Me.friesCheckbox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gudeburgerCheckbox = New System.Windows.Forms.CheckBox()
        Me.doubleburgerCheckbox = New System.Windows.Forms.CheckBox()
        Me.baconburgerCheckbox = New System.Windows.Forms.CheckBox()
        Me.cheeseburgerCheckbox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.fudgeCheckbox = New System.Windows.Forms.CheckBox()
        Me.cheesecakeCheckbox = New System.Windows.Forms.CheckBox()
        Me.icecreamCheckbox = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.beerCheckbox = New System.Windows.Forms.CheckBox()
        Me.lemonadeCheckbox = New System.Windows.Forms.CheckBox()
        Me.waterCheckbox = New System.Windows.Forms.CheckBox()
        Me.popCheckbox = New System.Windows.Forms.CheckBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.tipTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(254, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programmed By: Jake Gudenkauf"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(428, 277)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(81, 38)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(339, 277)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(81, 38)
        Me.aboutButton.TabIndex = 2
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 76)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "GUDE BURGER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.onionringsCheckbox)
        Me.GroupBox1.Controls.Add(Me.picklesCheckbox)
        Me.GroupBox1.Controls.Add(Me.friesCheckbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 124)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sides / Appetizers ($7)"
        '
        'onionringsCheckbox
        '
        Me.onionringsCheckbox.AutoSize = True
        Me.onionringsCheckbox.Location = New System.Drawing.Point(7, 68)
        Me.onionringsCheckbox.Name = "onionringsCheckbox"
        Me.onionringsCheckbox.Size = New System.Drawing.Size(132, 17)
        Me.onionringsCheckbox.TabIndex = 2
        Me.onionringsCheckbox.Text = "Stacks of Onion Rings"
        Me.onionringsCheckbox.UseVisualStyleBackColor = True
        '
        'picklesCheckbox
        '
        Me.picklesCheckbox.AutoSize = True
        Me.picklesCheckbox.Location = New System.Drawing.Point(7, 44)
        Me.picklesCheckbox.Name = "picklesCheckbox"
        Me.picklesCheckbox.Size = New System.Drawing.Size(115, 17)
        Me.picklesCheckbox.TabIndex = 1
        Me.picklesCheckbox.Text = "Deep Fried Pickles"
        Me.picklesCheckbox.UseVisualStyleBackColor = True
        '
        'friesCheckbox
        '
        Me.friesCheckbox.AutoSize = True
        Me.friesCheckbox.Location = New System.Drawing.Point(7, 20)
        Me.friesCheckbox.Name = "friesCheckbox"
        Me.friesCheckbox.Size = New System.Drawing.Size(122, 17)
        Me.friesCheckbox.TabIndex = 0
        Me.friesCheckbox.Text = "Big Ol Stack of Fries"
        Me.friesCheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gudeburgerCheckbox)
        Me.GroupBox2.Controls.Add(Me.doubleburgerCheckbox)
        Me.GroupBox2.Controls.Add(Me.baconburgerCheckbox)
        Me.GroupBox2.Controls.Add(Me.cheeseburgerCheckbox)
        Me.GroupBox2.Location = New System.Drawing.Point(179, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 124)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Burgers ($10)"
        '
        'gudeburgerCheckbox
        '
        Me.gudeburgerCheckbox.AutoSize = True
        Me.gudeburgerCheckbox.Location = New System.Drawing.Point(7, 92)
        Me.gudeburgerCheckbox.Name = "gudeburgerCheckbox"
        Me.gudeburgerCheckbox.Size = New System.Drawing.Size(86, 17)
        Me.gudeburgerCheckbox.TabIndex = 3
        Me.gudeburgerCheckbox.Text = "Gude Burger"
        Me.gudeburgerCheckbox.UseVisualStyleBackColor = True
        '
        'doubleburgerCheckbox
        '
        Me.doubleburgerCheckbox.AutoSize = True
        Me.doubleburgerCheckbox.Location = New System.Drawing.Point(7, 68)
        Me.doubleburgerCheckbox.Name = "doubleburgerCheckbox"
        Me.doubleburgerCheckbox.Size = New System.Drawing.Size(94, 17)
        Me.doubleburgerCheckbox.TabIndex = 2
        Me.doubleburgerCheckbox.Text = "Double Burger"
        Me.doubleburgerCheckbox.UseVisualStyleBackColor = True
        '
        'baconburgerCheckbox
        '
        Me.baconburgerCheckbox.AutoSize = True
        Me.baconburgerCheckbox.Location = New System.Drawing.Point(7, 44)
        Me.baconburgerCheckbox.Name = "baconburgerCheckbox"
        Me.baconburgerCheckbox.Size = New System.Drawing.Size(100, 17)
        Me.baconburgerCheckbox.TabIndex = 1
        Me.baconburgerCheckbox.Text = "Poor Pig Burger"
        Me.baconburgerCheckbox.UseVisualStyleBackColor = True
        '
        'cheeseburgerCheckbox
        '
        Me.cheeseburgerCheckbox.AutoSize = True
        Me.cheeseburgerCheckbox.Location = New System.Drawing.Point(7, 20)
        Me.cheeseburgerCheckbox.Name = "cheeseburgerCheckbox"
        Me.cheeseburgerCheckbox.Size = New System.Drawing.Size(95, 17)
        Me.cheeseburgerCheckbox.TabIndex = 0
        Me.cheeseburgerCheckbox.Text = "Cheesy Burger"
        Me.cheeseburgerCheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.fudgeCheckbox)
        Me.GroupBox3.Controls.Add(Me.cheesecakeCheckbox)
        Me.GroupBox3.Controls.Add(Me.icecreamCheckbox)
        Me.GroupBox3.Location = New System.Drawing.Point(346, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 124)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Desserts ($6)"
        '
        'fudgeCheckbox
        '
        Me.fudgeCheckbox.AutoSize = True
        Me.fudgeCheckbox.Location = New System.Drawing.Point(7, 68)
        Me.fudgeCheckbox.Name = "fudgeCheckbox"
        Me.fudgeCheckbox.Size = New System.Drawing.Size(119, 17)
        Me.fudgeCheckbox.TabIndex = 2
        Me.fudgeCheckbox.Text = "Fudge of Chocolate"
        Me.fudgeCheckbox.UseVisualStyleBackColor = True
        '
        'cheesecakeCheckbox
        '
        Me.cheesecakeCheckbox.AutoSize = True
        Me.cheesecakeCheckbox.Location = New System.Drawing.Point(7, 44)
        Me.cheesecakeCheckbox.Name = "cheesecakeCheckbox"
        Me.cheesecakeCheckbox.Size = New System.Drawing.Size(102, 17)
        Me.cheesecakeCheckbox.TabIndex = 1
        Me.cheesecakeCheckbox.Text = "Cake of Cheese"
        Me.cheesecakeCheckbox.UseVisualStyleBackColor = True
        '
        'icecreamCheckbox
        '
        Me.icecreamCheckbox.AutoSize = True
        Me.icecreamCheckbox.Location = New System.Drawing.Point(7, 20)
        Me.icecreamCheckbox.Name = "icecreamCheckbox"
        Me.icecreamCheckbox.Size = New System.Drawing.Size(86, 17)
        Me.icecreamCheckbox.TabIndex = 0
        Me.icecreamCheckbox.Text = "Cream of Ice"
        Me.icecreamCheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.beerCheckbox)
        Me.GroupBox4.Controls.Add(Me.lemonadeCheckbox)
        Me.GroupBox4.Controls.Add(Me.waterCheckbox)
        Me.GroupBox4.Controls.Add(Me.popCheckbox)
        Me.GroupBox4.Location = New System.Drawing.Point(513, 89)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 124)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Drinks ($5)"
        '
        'beerCheckbox
        '
        Me.beerCheckbox.AutoSize = True
        Me.beerCheckbox.Location = New System.Drawing.Point(7, 92)
        Me.beerCheckbox.Name = "beerCheckbox"
        Me.beerCheckbox.Size = New System.Drawing.Size(48, 17)
        Me.beerCheckbox.TabIndex = 6
        Me.beerCheckbox.Text = "Beer"
        Me.beerCheckbox.UseVisualStyleBackColor = True
        '
        'lemonadeCheckbox
        '
        Me.lemonadeCheckbox.AutoSize = True
        Me.lemonadeCheckbox.Location = New System.Drawing.Point(7, 68)
        Me.lemonadeCheckbox.Name = "lemonadeCheckbox"
        Me.lemonadeCheckbox.Size = New System.Drawing.Size(76, 17)
        Me.lemonadeCheckbox.TabIndex = 5
        Me.lemonadeCheckbox.Text = "Lemonade"
        Me.lemonadeCheckbox.UseVisualStyleBackColor = True
        '
        'waterCheckbox
        '
        Me.waterCheckbox.AutoSize = True
        Me.waterCheckbox.Location = New System.Drawing.Point(7, 44)
        Me.waterCheckbox.Name = "waterCheckbox"
        Me.waterCheckbox.Size = New System.Drawing.Size(55, 17)
        Me.waterCheckbox.TabIndex = 4
        Me.waterCheckbox.Text = "Water"
        Me.waterCheckbox.UseVisualStyleBackColor = True
        '
        'popCheckbox
        '
        Me.popCheckbox.AutoSize = True
        Me.popCheckbox.Location = New System.Drawing.Point(6, 20)
        Me.popCheckbox.Name = "popCheckbox"
        Me.popCheckbox.Size = New System.Drawing.Size(45, 17)
        Me.popCheckbox.TabIndex = 3
        Me.popCheckbox.Text = "Pop"
        Me.popCheckbox.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(161, 277)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(81, 38)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total:"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(257, 222)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(165, 43)
        Me.totalLabel.TabIndex = 10
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(250, 277)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(81, 38)
        Me.clearButton.TabIndex = 11
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'tipTextbox
        '
        Me.tipTextbox.Location = New System.Drawing.Point(19, 245)
        Me.tipTextbox.Name = "tipTextbox"
        Me.tipTextbox.Size = New System.Drawing.Size(100, 20)
        Me.tipTextbox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Enter Tip Amount:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(676, 357)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tipTextbox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "GUDE BURGER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents onionringsCheckbox As CheckBox
    Friend WithEvents picklesCheckbox As CheckBox
    Friend WithEvents friesCheckbox As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gudeburgerCheckbox As CheckBox
    Friend WithEvents doubleburgerCheckbox As CheckBox
    Friend WithEvents baconburgerCheckbox As CheckBox
    Friend WithEvents cheeseburgerCheckbox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents fudgeCheckbox As CheckBox
    Friend WithEvents cheesecakeCheckbox As CheckBox
    Friend WithEvents icecreamCheckbox As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents beerCheckbox As CheckBox
    Friend WithEvents lemonadeCheckbox As CheckBox
    Friend WithEvents waterCheckbox As CheckBox
    Friend WithEvents popCheckbox As CheckBox
    Friend WithEvents calcButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents tipTextbox As TextBox
    Friend WithEvents Label4 As Label
End Class
