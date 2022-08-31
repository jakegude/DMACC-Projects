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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblEmployDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmpNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblEmployBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesDataSet = New Morgan_Industries_Project.EmployeesDataSet()
        Me.allButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.TblEmployTableAdapter = New Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter()
        Me.allAscendCodeButton = New System.Windows.Forms.Button()
        Me.parttimeButton = New System.Windows.Forms.Button()
        Me.jLastNameDescCode = New System.Windows.Forms.Button()
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
        Me.TblEmployDataGridView.Size = New System.Drawing.Size(747, 373)
        Me.TblEmployDataGridView.TabIndex = 5
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.RateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
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
        'allButton
        '
        Me.allButton.Location = New System.Drawing.Point(19, 396)
        Me.allButton.Name = "allButton"
        Me.allButton.Size = New System.Drawing.Size(90, 38)
        Me.allButton.TabIndex = 0
        Me.allButton.Text = "All &Records"
        Me.allButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(664, 396)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(65, 38)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'TblEmployTableAdapter
        '
        Me.TblEmployTableAdapter.ClearBeforeFill = True
        '
        'allAscendCodeButton
        '
        Me.allAscendCodeButton.Location = New System.Drawing.Point(115, 396)
        Me.allAscendCodeButton.Name = "allAscendCodeButton"
        Me.allAscendCodeButton.Size = New System.Drawing.Size(144, 38)
        Me.allAscendCodeButton.TabIndex = 1
        Me.allAscendCodeButton.Text = "All &Ascending by Code"
        Me.allAscendCodeButton.UseVisualStyleBackColor = True
        '
        'parttimeButton
        '
        Me.parttimeButton.Location = New System.Drawing.Point(265, 396)
        Me.parttimeButton.Name = "parttimeButton"
        Me.parttimeButton.Size = New System.Drawing.Size(123, 38)
        Me.parttimeButton.TabIndex = 2
        Me.parttimeButton.Text = "&Part-Time Records"
        Me.parttimeButton.UseVisualStyleBackColor = True
        '
        'jLastNameDescCode
        '
        Me.jLastNameDescCode.Location = New System.Drawing.Point(394, 396)
        Me.jLastNameDescCode.Name = "jLastNameDescCode"
        Me.jLastNameDescCode.Size = New System.Drawing.Size(264, 38)
        Me.jLastNameDescCode.TabIndex = 3
        Me.jLastNameDescCode.Text = "&Last Name Begins with J, Descending by Code"
        Me.jLastNameDescCode.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 456)
        Me.Controls.Add(Me.jLastNameDescCode)
        Me.Controls.Add(Me.parttimeButton)
        Me.Controls.Add(Me.allAscendCodeButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.allButton)
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
    Friend WithEvents allButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents EmployeesDataSet As Morgan_Industries_Project.EmployeesDataSet
    Friend WithEvents TblEmployBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployTableAdapter As Morgan_Industries_Project.EmployeesDataSetTableAdapters.tblEmployTableAdapter
    Friend WithEvents allAscendCodeButton As System.Windows.Forms.Button
    Friend WithEvents parttimeButton As System.Windows.Forms.Button
    Friend WithEvents jLastNameDescCode As System.Windows.Forms.Button
    Friend WithEvents EmpNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
