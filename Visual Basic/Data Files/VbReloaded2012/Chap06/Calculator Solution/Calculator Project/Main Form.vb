' Project name:         Calculator Project
' Project purpose:      Display the sum of the numbers entered
' Created/revised by:   jake gudenkauf 12-6-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    'class level accumulator
    Private sum As Integer
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numTextBox.KeyPress
        ' allow the text box to accept only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        'accumulates the numbers entered by the user
        Dim num As Integer

        'display number
        numsTextBox.Text = numsTextBox.Text &
            numTextBox.Text & ControlChars.NewLine

        'convert inputs to number
        Integer.TryParse(numTextBox.Text, num)

        'add the number to the sum
        sum += num

        'display the sum
        sumLabel.Text = sum.ToString
    End Sub
    Private Sub startOverButton_Click(sender As Object, e As EventArgs) Handles startOverButton.Click
        'clears screen and starts over at 0
        numTextBox.Text = String.Empty
        numsTextBox.Text = String.Empty
        sumLabel.Text = String.Empty
        sum = 0


    End Sub
End Class
