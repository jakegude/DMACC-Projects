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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.viewerPictureBox = New System.Windows.Forms.PictureBox()
        Me.viewButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.viewerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewerPictureBox
        '
        Me.viewerPictureBox.Location = New System.Drawing.Point(43, 19)
        Me.viewerPictureBox.Name = "viewerPictureBox"
        Me.viewerPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.viewerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.viewerPictureBox.TabIndex = 0
        Me.viewerPictureBox.TabStop = False
        '
        'viewButton
        '
        Me.viewButton.Location = New System.Drawing.Point(43, 241)
        Me.viewButton.Name = "viewButton"
        Me.viewButton.Size = New System.Drawing.Size(75, 27)
        Me.viewButton.TabIndex = 0
        Me.viewButton.Text = "&View"
        Me.viewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(168, 241)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Blue.png")
        Me.ImageList1.Images.SetKeyName(1, "Green.png")
        Me.ImageList1.Images.SetKeyName(2, "Purple.png")
        Me.ImageList1.Images.SetKeyName(3, "Red.png")
        Me.ImageList1.Images.SetKeyName(4, "Yellow.png")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 288)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.viewButton)
        Me.Controls.Add(Me.viewerPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Viewer"
        CType(Me.viewerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents viewButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
