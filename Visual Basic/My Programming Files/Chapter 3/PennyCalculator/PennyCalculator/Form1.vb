'program by jake gudenkauf
'calculates the amount of money you have with the given amount of pennies
'11-16-2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()
    End Sub
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears all inputs and labels
        PennyTextbox.Text = String.Empty
        dollarLabel.Text = String.Empty
        QLabel.Text = String.Empty
        DLabel.Text = String.Empty
        NLabel.Text = String.Empty
        PLabel.Text = String.Empty

        'sets focus
        PennyTextbox.Focus()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates and displays results

        'declares variables
        Dim dollars As Integer
        Dim quarters As Integer
        Dim dimes As Integer
        Dim nickels As Integer
        Dim pennies As Integer

        'assign user input to variable
        Integer.TryParse(PennyTextbox.Text, pennies)

        'calculate dollars
        dollars = pennies \ 100
        pennies = pennies - dollars * 100

        'calculate quarters
        quarters = pennies \ 25
        pennies = pennies - quarters * 25

        'calculate dimes
        dimes = pennies \ 10
        pennies = pennies - dimes * 10

        'calculate nickels
        nickels = pennies \ 5

        'calculate pennies
        pennies = pennies - nickels * 5

        'display results
        dollarLabel.Text = Convert.ToString(dollars)
        QLabel.Text = Convert.ToString(quarters)
        DLabel.Text = Convert.ToString(dimes)
        NLabel.Text = Convert.ToString(nickels)
        PLabel.Text = Convert.ToString(pennies)

        clearButton.Focus()

    End Sub
End Class
