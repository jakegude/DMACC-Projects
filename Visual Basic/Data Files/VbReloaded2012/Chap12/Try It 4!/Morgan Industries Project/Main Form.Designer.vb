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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblEmployDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblEmployBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesDataSet = New Morgan_Industries_Project.EmployeesDataSet()
        Me.avgButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.TblEmployTableAdapter = New Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter()
        Me.highButton = New System.Windows.Forms.Button()
        Me.dept2Button = New System.Windows.Forms.Button()
        Me.EmpNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblEmployDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblEmployDataGridView
        '
        Me.TblEmployDataGridView.AllowUserToAddRows = False
        Me.TblEmployDataGridView.AllowUserToDeleteRows = False
        Me.TblEmployDataGridView.AutoGenerateColumns = False
        Me.TblEmployDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblEmployDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpNumberDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.HiredDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn})
        Me.TblEmployDataGridView.DataSource = Me.TblEmployBindingSource
        Me.TblEmployDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TblEmployDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblEmployDataGridView.Name = "TblEmployDataGridView"
        Me.TblEmployDataGridView.ReadOnly = True
        Me.TblEmployDataGridView.RowTemplate.Height = 24
        Me.TblEmployDataGridView.Size = New System.Drawing.Size(731, 373)
        Me.TblEmployDataGridView.TabIndex = 3
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
        'avgButton
        '
        Me.avgButton.Location = New System.Drawing.Point(215, 396)
        Me.avgButton.Name = "avgButton"
        Me.avgButton.Size = New System.Drawing.Size(90, 38)
        Me.avgButton.TabIndex = 0
        Me.avgButton.Text = "&Average Rate"
        Me.avgButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(654, 396)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(65, 38)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'TblEmployTableAdapter
        '
        Me.TblEmployTableAdapter.ClearBeforeFill = True
        '
        'highButton
        '
        Me.highButton.Location = New System.Drawing.Point(311, 396)
        Me.highButton.Name = "highButton"
        Me.highButton.Size = New System.Drawing.Size(144, 38)
        Me.highButton.TabIndex = 4
        Me.highButton.Text = "&Highest Part-Time Rate"
        Me.highButton.UseVisualStyleBackColor = True
        '
        'dept2Button
        '
        Me.dept2Button.Location = New System.Drawing.Point(461, 396)
        Me.dept2Button.Name = "dept2Button"
        Me.dept2Button.Size = New System.Drawing.Size(187, 38)
        Me.dept2Button.TabIndex = 5
        Me.dept2Button.Text = "&Number of Dept 2 Employees"
        Me.dept2Button.UseVisualStyleBackColor = True
        '
        'EmpNumberDataGridViewTextBoxColumn
        '
        Me.EmpNumberDataGridViewTextBoxColumn.DataPropertyName = "Emp_Number"
        Me.EmpNumberDataGridViewTextBoxColumn.HeaderText = "Emp_Number"
        Me.EmpNumberDataGridViewTextBoxColumn.Name = "EmpNumberDataGridViewTextBoxColumn"
        Me.EmpNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HiredDataGridViewTextBoxColumn
        '
        Me.HiredDataGridViewTextBoxColumn.DataPropertyName = "Hired"
        Me.HiredDataGridViewTextBoxColumn.HeaderText = "Hired"
        Me.HiredDataGridViewTextBoxColumn.Name = "HiredDataGridViewTextBoxColumn"
        Me.HiredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.RateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        Me.RateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RateDataGridViewTextBoxColumn.Width = 55
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 456)
        Me.Controls.Add(Me.dept2Button)
        Me.Controls.Add(Me.highButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.avgButton)
        Me.Controls.Add(Me.TblEmployDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morgan Industries"
        CType(Me.TblEmployDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TblEmployDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents avgButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents EmployeesDataSet As Morgan_Industries_Project.EmployeesDataSet
    Friend WithEvents TblEmployBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployTableAdapter As Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter
    Friend WithEvents highButton As System.Windows.Forms.Button
    Friend WithEvents dept2Button As System.Windows.Forms.Button
    Friend WithEvents EmpNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
