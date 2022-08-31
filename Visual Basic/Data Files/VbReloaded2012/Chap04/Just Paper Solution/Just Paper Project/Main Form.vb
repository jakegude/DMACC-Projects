' Project name:         Just Paper Project
' Project purpose:      Display the total number of cases
'                       ordered and the total price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' prepares the screen for the next order

        nameTextBox.Text = String.Empty
        addressTextBox.Text = String.Empty
        cityTextBox.Text = String.Empty
        stateTextBox.Text = String.Empty
        zipTextBox.Text = String.Empty
        standardTextBox.Text = String.Empty
        legalTextBox.Text = String.Empty
        totalCasesLabel.Text = String.Empty
        totalPriceLabel.Text = String.Empty
        nameTextBox.Focus()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the total cases and total price

        ' declare constant and variables
        Const PricePerCase As Double = 27.99
        Dim standard As Integer
        Dim legal As Integer
        Dim totalCases As Integer
        Dim totalPrice As Double

        ' assign input to variables
        Integer.TryParse(standardTextBox.Text, standard)
        Integer.TryParse(legalTextBox.Text, legal)

        ' perform calculations
        totalCases = standard + legal
        totalPrice = totalCases * PricePerCase

        ' display calculated results
        totalCasesLabel.Text = Convert.ToString(totalCases)
        totalPriceLabel.Text = totalPrice.ToString("C2")

        printButton.Focus()

    End Sub
End Class
