' Project name:         Morgan Industries Project
' Project purpose:      Displays the records stored in a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        ' moves the record pointer to the next record

        TblEmployBindingSource.MoveNext()
    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        ' moves the record pointer to the previous record

        TblEmployBindingSource.MovePrevious()
    End Sub
End Class

