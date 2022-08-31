' Project name:         New Salary Project
' Project purpose:      Display the new salary for 5 years
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the new salary for the next 5 years

        Dim salary As Double
        Dim raise As Double

        Double.TryParse(beginSalaryTextBox.Text, salary)
        newSalaryListBox.Items.Clear()


    End Sub

    Private Sub beginSalaryTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles beginSalaryTextBox.KeyPress
        ' accept only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
