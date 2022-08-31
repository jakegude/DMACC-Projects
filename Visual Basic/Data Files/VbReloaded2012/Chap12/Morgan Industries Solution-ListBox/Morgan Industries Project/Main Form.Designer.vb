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
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.codeLabel = New System.Windows.Forms.Label()
        Me.TblEmployBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesDataSet = New Morgan_Industries_Project.EmployeesDataSet()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.TblEmployTableAdapter = New Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter()
        Me.TableAdapterManager = New Morgan_Industries_Project.EmployeesDataSetTableAdapters.TableAdapterManager()
        CType(Me.TblEmployBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(187, 114)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(129, 31)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "&Next Record"
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(38, 114)
        Me.previousButton.Margin = New System.Windows.Forms.Padding(2)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(145, 31)
        Me.previousButton.TabIndex = 0
        Me.previousButton.Text = "&Previous Record"
        '
        'codeLabel
        '
        Me.codeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codeLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployBindingSource, "Code", True))
        Me.codeLabel.Location = New System.Drawing.Point(359, 57)
        Me.codeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.codeLabel.Name = "codeLabel"
        Me.codeLabel.Size = New System.Drawing.Size(43, 24)
        Me.codeLabel.TabIndex = 10
        Me.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblEmployBindingSource
        '
        Me.TblEmployBindingSource.DataMember = "tblEmploy"
        Me.TblEmployBindingSource.DataSource = Me.EmployeesDataSet
        '
        'EmployeesDataSet
        '
        Me.EmployeesDataSet.DataSetName = "EmployeesDataSet"
        Me.EmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'statusLabel
        '
        Me.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statusLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployBindingSource, "Status", True))
        Me.statusLabel.Location = New System.Drawing.Point(285, 57)
        Me.statusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(48, 24)
        Me.statusLabel.TabIndex = 8
        Me.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lastNameLabel
        '
        Me.lastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployBindingSource, "Last_Name", True))
        Me.lastNameLabel.Location = New System.Drawing.Point(120, 57)
        Me.lastNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(149, 24)
        Me.lastNameLabel.TabIndex = 6
        Me.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numberLabel
        '
        Me.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numberLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployBindingSource, "Emp_Number", True))
        Me.numberLabel.Location = New System.Drawing.Point(38, 57)
        Me.numberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(62, 24)
        Me.numberLabel.TabIndex = 4
        Me.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(336, 114)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(66, 31)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'TblEmployTableAdapter
        '
        Me.TblEmployTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblEmployTableAdapter = Me.TblEmployTableAdapter
        Me.TableAdapterManager.UpdateOrder = Morgan_Industries_Project.EmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 177)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.codeLabel)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.lastNameLabel)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morgan Industries"
        CType(Me.TblEmployBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents codeLabel As System.Windows.Forms.Label
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents lastNameLabel As System.Windows.Forms.Label
    Friend WithEvents numberLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents EmployeesDataSet As Morgan_Industries_Project.EmployeesDataSet
    Friend WithEvents TblEmployBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployTableAdapter As Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter
    Friend WithEvents TableAdapterManager As Morgan_Industries_Project.EmployeesDataSetTableAdapters.TableAdapterManager

End Class
