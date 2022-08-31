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

        Dim beginSalary As Double
        Dim salary As Double
        Dim raise As Double
        'Dim rate As Double = 0.02

        Double.TryParse(beginSalaryTextBox.Text, beginSalary)
        newSalaryListBox.Items.Clear()

        For rate As Double = 0.02 To 0.04 Step 0.01
            salary = beginSalary
            newSalaryListBox.Items.Add(rate.ToString("P0") &
                                       ControlChars.NewLine)
            For year As Integer = 1 To 5
                raise = salary * rate
                salary += raise
                newSalaryListBox.Items.Add(year.ToString &
                                           ControlChars.NewLine &
                                           "   " & salary.ToString("N2"))
            Next year
            newSalaryListBox.Items.Add(ControlChars.NewLine)
        Next rate

        'Do While rate <= 0.04
        '    salary = beginSalary
        '    newSalaryListBox.Items.Add(rate.ToString("P0") &
        '                               ControlChars.NewLine)
        '    For year As Integer = 1 To 5
        '        raise = salary * rate
        '        salary += raise
        '        newSalaryListBox.Items.Add(year.ToString &
        '                                   ControlChars.NewLine &
        '                                   "   " & salary.ToString("N2"))
        '    Next year
        '    newSalaryListBox.Items.Add(ControlChars.NewLine)
        '    rate += 0.01
        'Loop
    End Sub

    Private Sub beginSalaryTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles beginSalaryTextBox.KeyPress
        ' accept only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
