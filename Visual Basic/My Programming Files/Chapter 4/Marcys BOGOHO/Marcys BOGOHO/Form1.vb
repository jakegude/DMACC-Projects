'jake gudenkauf
'calculates savings for bogoho
'11-22-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears inputs and outputs
        price1Textbox.Text = String.Empty
        price2Textbox.Text = String.Empty
        totalLabel.Text = String.Empty
        savingsLabel.Text = String.Empty

        'focus
        price1Textbox.Focus()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates and displays results
        'variables
        Dim price1 As Decimal
        Dim price2 As Decimal
        Dim total As Decimal
        Dim savings As Decimal

        'assign user inputs
        Decimal.TryParse(price1Textbox.Text, price1)
        Decimal.TryParse(price2Textbox.Text, price2)

        'calculate total and savings
        If price1 < price2 Then
            total = price1 / 2 + price2
        Else
            total = price2 / 2 + price1
        End If

        savings = price1 + price2 - total

        'display results
        totalLabel.Text = total.ToString("C2")
        savingsLabel.Text = savings.ToString("C2")

    End Sub
End Class
