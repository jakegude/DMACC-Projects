' Project name:         Stock Project
' Project purpose:      Displays the average stock price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the average stock price

        Const Prompt As String = "Enter a stock price. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const Title As String = "Stock Price Entry"
        Dim inputPrice As String
        Dim price As Decimal
        Dim numPrices As Integer
        Dim totalPrices As Decimal
        Dim avgPrice As Decimal

        ' get first stock price
        inputPrice = InputBox(Prompt, Title)

        ' repeat as long as the user enters a price
        Do While inputPrice <> String.Empty
            ' convert the price to a number
            Decimal.TryParse(inputPrice, price)

            ' update the counter and accumulator
            numPrices += 1
            totalPrices += price

            ' display the price in the text box
            listOfPricesTextBox.Text =
                listOfPricesTextBox.Text &
                price.ToString("N2") & ControlChars.NewLine

            ' get the next price
            inputPrice = InputBox(Prompt, Title)
        Loop

        ' verify that the counter is greater than 0
        If numPrices > 0 Then
            avgPrice = totalPrices / numPrices
            avgLabel.Text = avgPrice.ToString("C2")
        Else
            avgLabel.Text = "N/A"
        End If
    End Sub

    Private Sub startOverButton_Click(sender As Object, e As EventArgs) Handles startOverButton.Click
        ' clear prices and average price

        listOfPricesTextBox.Text = String.Empty
        avgLabel.Text = String.Empty
    End Sub
End Class
