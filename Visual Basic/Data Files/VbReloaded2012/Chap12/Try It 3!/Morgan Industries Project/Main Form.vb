' Project name:         Morgan Industries Project
' Project purpose:      Displays specific records from a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub

    Private Sub allButton_Click(sender As Object, e As EventArgs) Handles allButton.Click
        ' selects all records from the dataset

        Dim records = From employee In EmployeesDataSet.tblEmploy
                      Select employee

        ' assign to BindingSource control
        TblEmployBindingSource.DataSource = records.AsDataView
    End Sub


    Private Sub allAscendCodeButton_Click(sender As Object, e As EventArgs) Handles allAscendCodeButton.Click
        ' selects all records from the dataset and arranges them
        ' in ascending order by the Code field

        Dim records = From employee In EmployeesDataSet.tblEmploy
                      Order By employee.Code
                      Select employee

        ' assign to BindingSource control
        TblEmployBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub parttimeButton_Click(sender As Object, e As EventArgs) Handles parttimeButton.Click
        ' selects only part-time records from the dataset 

        Dim records = From employee In EmployeesDataSet.tblEmploy
                      Where employee.Status.ToUpper = "P"
                      Select employee

        ' assign to BindingSource control
        TblEmployBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub jLastNameDescCode_Click(sender As Object, e As EventArgs) Handles jLastNameDescCode.Click
        ' selects only records whose last name begins with J and
        ' arranges them in descending order by the Code field

        Dim records = From employee In EmployeesDataSet.tblEmploy
                      Where employee.Last_Name.ToUpper Like "J*"
                      Order By employee.Code Descending
                      Select employee

        ' assign to BindingSource control
        TblEmployBindingSource.DataSource = records.AsDataView
    End Sub
End Class
