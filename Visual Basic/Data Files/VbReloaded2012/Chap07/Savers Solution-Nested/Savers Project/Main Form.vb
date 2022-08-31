' Project name:         Savers Project
' Project purpose:      Display a savings account balance for each of 5 years using rates
'                       from 3% through 7% in increments of 1%
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculate account balances for each of
        ' five years, using rates from 3% through 7%
        ' in increments of 1%

        Dim deposit As Double
        Dim balance As Double
        Dim interest As Double

        Double.TryParse(depositTextBox.Text, deposit)

        balanceTextBox.Text = "Rate" & ControlChars.Tab &
            "Year" & ControlChars.Tab & "Balance" &
            ControlChars.NewLine

        ' calculate and display account balances 
        For rate As Double = 0.03 To 0.07 Step 0.01
            balanceTextBox.Text = balanceTextBox.Text &
               rate.ToString("P0") & ControlChars.NewLine
            balance = deposit
            For year As Integer = 1 To 5
                interest = balance * rate
                balance += interest
                balanceTextBox.Text = balanceTextBox.Text &
                    ControlChars.Tab & year.ToString &
                    ControlChars.Tab & balance.ToString("C2") &
                    ControlChars.NewLine
            Next year
        Next rate
    End Sub

    Private Sub depositTextBox_Enter(sender As Object, e As EventArgs) Handles depositTextBox.Enter
        depositTextBox.SelectAll()
    End Sub

    Private Sub depositTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles depositTextBox.KeyPress
        ' accepts only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub depositTextBox_TextChanged(sender As Object, e As EventArgs) Handles depositTextBox.TextChanged
        balanceTextBox.Text = String.Empty
    End Sub
End Class
