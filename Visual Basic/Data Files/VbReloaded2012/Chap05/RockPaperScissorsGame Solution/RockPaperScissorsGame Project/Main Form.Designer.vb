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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.winnerLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rockPictureBox = New System.Windows.Forms.PictureBox()
        Me.scissorsPictureBox = New System.Windows.Forms.PictureBox()
        Me.paperPictureBox = New System.Windows.Forms.PictureBox()
        Me.computerPictureBox = New System.Windows.Forms.PictureBox()
        Me.playerPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.rockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissorsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(505, 448)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(63, 39)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 212)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Player:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Computer:"
        '
        'winnerLabel
        '
        Me.winnerLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.winnerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.winnerLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winnerLabel.Location = New System.Drawing.Point(106, 380)
        Me.winnerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.winnerLabel.Name = "winnerLabel"
        Me.winnerLabel.Size = New System.Drawing.Size(462, 34)
        Me.winnerLabel.TabIndex = 5
        Me.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Click the Rock, Paper, or Scissors image"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.rockPictureBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.scissorsPictureBox, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.paperPictureBox, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(106, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(462, 100)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'rockPictureBox
        '
        Me.rockPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rockPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rockPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Rock
        Me.rockPictureBox.Location = New System.Drawing.Point(6, 7)
        Me.rockPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rockPictureBox.Name = "rockPictureBox"
        Me.rockPictureBox.Size = New System.Drawing.Size(144, 86)
        Me.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rockPictureBox.TabIndex = 7
        Me.rockPictureBox.TabStop = False
        '
        'scissorsPictureBox
        '
        Me.scissorsPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scissorsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scissorsPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Scissors
        Me.scissorsPictureBox.Location = New System.Drawing.Point(312, 7)
        Me.scissorsPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.scissorsPictureBox.Name = "scissorsPictureBox"
        Me.scissorsPictureBox.Size = New System.Drawing.Size(144, 86)
        Me.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.scissorsPictureBox.TabIndex = 9
        Me.scissorsPictureBox.TabStop = False
        '
        'paperPictureBox
        '
        Me.paperPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paperPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paperPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Paper
        Me.paperPictureBox.Location = New System.Drawing.Point(159, 7)
        Me.paperPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.paperPictureBox.Name = "paperPictureBox"
        Me.paperPictureBox.Size = New System.Drawing.Size(144, 86)
        Me.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.paperPictureBox.TabIndex = 8
        Me.paperPictureBox.TabStop = False
        '
        'computerPictureBox
        '
        Me.computerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.computerPictureBox.Location = New System.Drawing.Point(370, 243)
        Me.computerPictureBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.computerPictureBox.Name = "computerPictureBox"
        Me.computerPictureBox.Size = New System.Drawing.Size(144, 119)
        Me.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.computerPictureBox.TabIndex = 6
        Me.computerPictureBox.TabStop = False
        '
        'playerPictureBox
        '
        Me.playerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.playerPictureBox.Location = New System.Drawing.Point(161, 243)
        Me.playerPictureBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.playerPictureBox.Name = "playerPictureBox"
        Me.playerPictureBox.Size = New System.Drawing.Size(144, 119)
        Me.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerPictureBox.TabIndex = 4
        Me.playerPictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 516)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.winnerLabel)
        Me.Controls.Add(Me.computerPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.playerPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rock, Paper, Scissors Game"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.rockPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissorsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents playerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents computerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents winnerLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rockPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents paperPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents scissorsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
