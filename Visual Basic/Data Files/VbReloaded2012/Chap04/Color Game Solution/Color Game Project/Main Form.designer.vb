<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.startOverButton = New System.Windows.Forms.Button()
        Me.redButton = New System.Windows.Forms.Button()
        Me.orangeButton = New System.Windows.Forms.Button()
        Me.grayButton = New System.Windows.Forms.Button()
        Me.purpleButton = New System.Windows.Forms.Button()
        Me.pinkButton = New System.Windows.Forms.Button()
        Me.brownButton = New System.Windows.Forms.Button()
        Me.yellowButton = New System.Windows.Forms.Button()
        Me.greenButton = New System.Windows.Forms.Button()
        Me.blueButton = New System.Windows.Forms.Button()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.fontDialog = New System.Windows.Forms.FontDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Click a color button:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(311, 316)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(83, 44)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'startOverButton
        '
        Me.startOverButton.Location = New System.Drawing.Point(48, 316)
        Me.startOverButton.Margin = New System.Windows.Forms.Padding(2)
        Me.startOverButton.Name = "startOverButton"
        Me.startOverButton.Size = New System.Drawing.Size(83, 44)
        Me.startOverButton.TabIndex = 0
        Me.startOverButton.Text = "&Start Over"
        '
        'redButton
        '
        Me.redButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.redButton.BackColor = System.Drawing.Color.White
        Me.redButton.Location = New System.Drawing.Point(5, 5)
        Me.redButton.Margin = New System.Windows.Forms.Padding(2)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(107, 58)
        Me.redButton.TabIndex = 0
        Me.redButton.Text = "&Red"
        Me.redButton.UseVisualStyleBackColor = False
        '
        'orangeButton
        '
        Me.orangeButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.orangeButton.BackColor = System.Drawing.Color.White
        Me.orangeButton.Location = New System.Drawing.Point(233, 135)
        Me.orangeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.orangeButton.Name = "orangeButton"
        Me.orangeButton.Size = New System.Drawing.Size(109, 60)
        Me.orangeButton.TabIndex = 8
        Me.orangeButton.Text = "&Orange"
        Me.orangeButton.UseVisualStyleBackColor = False
        '
        'grayButton
        '
        Me.grayButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grayButton.BackColor = System.Drawing.Color.White
        Me.grayButton.Location = New System.Drawing.Point(119, 135)
        Me.grayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.grayButton.Name = "grayButton"
        Me.grayButton.Size = New System.Drawing.Size(107, 60)
        Me.grayButton.TabIndex = 7
        Me.grayButton.Text = "Gr&ay"
        Me.grayButton.UseVisualStyleBackColor = False
        '
        'purpleButton
        '
        Me.purpleButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.purpleButton.BackColor = System.Drawing.Color.White
        Me.purpleButton.Location = New System.Drawing.Point(5, 135)
        Me.purpleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.purpleButton.Name = "purpleButton"
        Me.purpleButton.Size = New System.Drawing.Size(107, 60)
        Me.purpleButton.TabIndex = 6
        Me.purpleButton.Text = "Purp&le"
        Me.purpleButton.UseVisualStyleBackColor = False
        '
        'pinkButton
        '
        Me.pinkButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pinkButton.BackColor = System.Drawing.Color.White
        Me.pinkButton.Location = New System.Drawing.Point(233, 70)
        Me.pinkButton.Margin = New System.Windows.Forms.Padding(2)
        Me.pinkButton.Name = "pinkButton"
        Me.pinkButton.Size = New System.Drawing.Size(109, 58)
        Me.pinkButton.TabIndex = 5
        Me.pinkButton.Text = "Pin&k"
        Me.pinkButton.UseVisualStyleBackColor = False
        '
        'brownButton
        '
        Me.brownButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brownButton.BackColor = System.Drawing.Color.White
        Me.brownButton.Location = New System.Drawing.Point(119, 70)
        Me.brownButton.Margin = New System.Windows.Forms.Padding(2)
        Me.brownButton.Name = "brownButton"
        Me.brownButton.Size = New System.Drawing.Size(107, 58)
        Me.brownButton.TabIndex = 4
        Me.brownButton.Text = "Brow&n"
        Me.brownButton.UseVisualStyleBackColor = False
        '
        'yellowButton
        '
        Me.yellowButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.yellowButton.BackColor = System.Drawing.Color.White
        Me.yellowButton.Location = New System.Drawing.Point(5, 70)
        Me.yellowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.yellowButton.Name = "yellowButton"
        Me.yellowButton.Size = New System.Drawing.Size(107, 58)
        Me.yellowButton.TabIndex = 3
        Me.yellowButton.Text = "&Yellow"
        Me.yellowButton.UseVisualStyleBackColor = False
        '
        'greenButton
        '
        Me.greenButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.greenButton.BackColor = System.Drawing.Color.White
        Me.greenButton.Location = New System.Drawing.Point(233, 5)
        Me.greenButton.Margin = New System.Windows.Forms.Padding(2)
        Me.greenButton.Name = "greenButton"
        Me.greenButton.Size = New System.Drawing.Size(109, 58)
        Me.greenButton.TabIndex = 2
        Me.greenButton.Text = "&Green"
        Me.greenButton.UseVisualStyleBackColor = False
        '
        'blueButton
        '
        Me.blueButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.blueButton.BackColor = System.Drawing.Color.White
        Me.blueButton.Location = New System.Drawing.Point(119, 5)
        Me.blueButton.Margin = New System.Windows.Forms.Padding(2)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(107, 58)
        Me.blueButton.TabIndex = 1
        Me.blueButton.Text = "&Blue"
        Me.blueButton.UseVisualStyleBackColor = False
        '
        'fontButton
        '
        Me.fontButton.Location = New System.Drawing.Point(223, 316)
        Me.fontButton.Margin = New System.Windows.Forms.Padding(2)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(83, 44)
        Me.fontButton.TabIndex = 2
        Me.fontButton.Text = "&Font"
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(135, 316)
        Me.printButton.Margin = New System.Windows.Forms.Padding(2)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(83, 44)
        Me.printButton.TabIndex = 1
        Me.printButton.Text = "&Print"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.redButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.blueButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.greenButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.orangeButton, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.yellowButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grayButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.brownButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.purpleButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.pinkButton, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(41, 95)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(347, 200)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 464)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.fontButton)
        Me.Controls.Add(Me.startOverButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Game"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents startOverButton As System.Windows.Forms.Button
    Friend WithEvents redButton As System.Windows.Forms.Button
    Friend WithEvents orangeButton As System.Windows.Forms.Button
    Friend WithEvents grayButton As System.Windows.Forms.Button
    Friend WithEvents purpleButton As System.Windows.Forms.Button
    Friend WithEvents pinkButton As System.Windows.Forms.Button
    Friend WithEvents brownButton As System.Windows.Forms.Button
    Friend WithEvents yellowButton As System.Windows.Forms.Button
    Friend WithEvents greenButton As System.Windows.Forms.Button
    Friend WithEvents blueButton As System.Windows.Forms.Button
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents fontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
