' Project name:         Morgan Industries Project
' Project purpose:      Displays the records stored in a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub TblEmployBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblEmployBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.TblEmployBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)
            MessageBox.Show("Changes saved", "Morgan Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Morgan Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub
End Class
