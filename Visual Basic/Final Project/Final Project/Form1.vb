'Jake Gudenkauf
'Final Project
'Gude Burger
'12-12-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        'shows the about box
        AboutBox1.ShowDialog()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'closes the program
        Me.Close()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates the total bill

        'constants
        Const fries As Integer = 7
        Const pickles As Integer = 7
        Const orings As Integer = 7

        Const cheeseburger As Integer = 10
        Const baconburger As Integer = 10
        Const doubleburger As Integer = 10
        Const gudeburger As Integer = 10

        Const icecream As Integer = 6
        Const cheesecake As Integer = 6
        Const fudge As Integer = 6

        Const pop As Integer = 5
        Const water As Integer = 5
        Const lemonade As Integer = 5
        Const beer As Integer = 5

        'variables
        Dim total As Integer
        'Dim runningtotal As Integer
        Dim tip As Integer

        'assign user inputs
        Integer.TryParse(tipTextbox.Text, tip)

        'calc
        If friesCheckbox.Checked = True Then
            total = total + fries
        End If
        If picklesCheckbox.Checked = True Then
            total = total + pickles
        End If
        If onionringsCheckbox.Checked = True Then
            total = total + orings
        End If
        If cheeseburgerCheckbox.Checked = True Then
            total = total + cheeseburger
        End If
        If baconburgerCheckbox.Checked = True Then
            total = total + baconburger
        End If
        If doubleburgerCheckbox.Checked = True Then
            total = total + doubleburger
        End If
        If gudeburgerCheckbox.Checked = True Then
            total = total + gudeburger
        End If
        If icecreamCheckbox.Checked = True Then
            total = total + icecream
        End If
        If cheesecakeCheckbox.Checked = True Then
            total = total + cheesecake
        End If
        If fudgeCheckbox.Checked = True Then
            total = total + fudge
        End If
        If popCheckbox.Checked = True Then
            total = total + pop
        End If
        If waterCheckbox.Checked = True Then
            total = total + water
        End If
        If lemonadeCheckbox.Checked = True Then
            total = total + lemonade
        End If
        If beerCheckbox.Checked = True Then
            total = total + beer
        End If

        total = total + tip

        'display
        totalLabel.Text = total.ToString("C2")

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears all inputs
        totalLabel.Text = String.Empty

        tipTextbox.Text = String.Empty

        friesCheckbox.Checked = False
        picklesCheckbox.Checked = False
        onionringsCheckbox.Checked = False
        cheeseburgerCheckbox.Checked = False
        baconburgerCheckbox.Checked = False
        doubleburgerCheckbox.Checked = False
        gudeburgerCheckbox.Checked = False
        icecreamCheckbox.Checked = False
        cheesecakeCheckbox.Checked = False
        fudgeCheckbox.Checked = False
        popCheckbox.Checked = False
        waterCheckbox.Checked = False
        lemonadeCheckbox.Checked = False
        beerCheckbox.Checked = False

        calcButton.Focus()

    End Sub
End Class
