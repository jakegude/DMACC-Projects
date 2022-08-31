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

    Private Sub avgButton_Click(sender As Object, e As EventArgs) Handles avgButton.Click
        ' displays the average pay rate

        Dim avgRate As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Select employee.Rate Into Average()

        MessageBox.Show("Average pay rate: " & avgRate.ToString("C2"),
                        "Morgan Industries", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub highButton_Click(sender As Object, e As EventArgs) Handles highButton.Click
        ' displays the highest pay rate for part-time employees

        Dim maxRate As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Where employee.Status.ToUpper = "P"
            Select employee.Rate Into Max()

        MessageBox.Show("Highest pay rate for a part-time employee: " & maxRate.ToString("C2"),
                        "Morgan Industries", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dept2Button_Click(sender As Object, e As EventArgs) Handles dept2Button.Click
        ' displays the number of employees in Department 2 

        Dim counter As Integer =
           Aggregate employee In EmployeesDataSet.tblEmploy
           Where employee.Code = 2
           Into Count()

        MessageBox.Show("Number of employees in Department 2: " & counter.ToString,
                        "Morgan Industries", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
