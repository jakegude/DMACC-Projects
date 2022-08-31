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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.leftPictureBox = New System.Windows.Forms.PictureBox()
        Me.rightPictureBox = New System.Windows.Forms.PictureBox()
        Me.centerPictureBox = New System.Windows.Forms.PictureBox()
        Me.clickHereButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.leftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.centerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.leftPictureBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rightPictureBox, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.centerPictureBox, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(31, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(396, 156)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'leftPictureBox
        '
        Me.leftPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.leftPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.leftPictureBox.Name = "leftPictureBox"
        Me.leftPictureBox.Size = New System.Drawing.Size(126, 150)
        Me.leftPictureBox.TabIndex = 0
        Me.leftPictureBox.TabStop = False
        '
        'rightPictureBox
        '
        Me.rightPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rightPictureBox.Location = New System.Drawing.Point(267, 3)
        Me.rightPictureBox.Name = "rightPictureBox"
        Me.rightPictureBox.Size = New System.Drawing.Size(126, 150)
        Me.rightPictureBox.TabIndex = 2
        Me.rightPictureBox.TabStop = False
        '
        'centerPictureBox
        '
        Me.centerPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.centerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.centerPictureBox.Location = New System.Drawing.Point(135, 3)
        Me.centerPictureBox.Name = "centerPictureBox"
        Me.centerPictureBox.Size = New System.Drawing.Size(126, 150)
        Me.centerPictureBox.TabIndex = 1
        Me.centerPictureBox.TabStop = False
        '
        'clickHereButton
        '
        Me.clickHereButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.clickHereButton.FlatAppearance.BorderSize = 3
        Me.clickHereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clickHereButton.Image = Global.Slot_Machine_Project.My.Resources.Resources.ClickHere
        Me.clickHereButton.Location = New System.Drawing.Point(456, 35)
        Me.clickHereButton.Name = "clickHereButton"
        Me.clickHereButton.Size = New System.Drawing.Size(93, 95)
        Me.clickHereButton.TabIndex = 0
        Me.clickHereButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(456, 153)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(93, 35)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.clickHereButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 237)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clickHereButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.leftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.centerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents leftPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents rightPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents centerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents clickHereButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
