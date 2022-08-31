' Project name:         Savers Project
' Project purpose:      Display the balance in a savings account
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculate the account balance

        Dim balance As Double
        Dim rate As Double
        Dim interest As Double
        Dim years As Integer

        Double.TryParse(depositTextBox.Text, balance)
        Double.TryParse(rateTextBox.Text, rate)

        If balance > 0 AndAlso rate > 0 Then
            Do While balance < 100000
                interest = balance * rate
                balance = balance + interest
                years = years + 1
            Loop
        End If

        balanceLabel.Text = "You will have " &
            balance.ToString("C2") & " in " & years.ToString & " years."
    End Sub

    Private Sub depositTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles depositTextBox.KeyPress
        ' accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub rateTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rateTextBox.KeyPress
        ' accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub
End Class
