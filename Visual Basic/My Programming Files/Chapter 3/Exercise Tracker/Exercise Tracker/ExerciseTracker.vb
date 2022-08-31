'jake gudenkauf
'calculates the number of pounds lost
'11-17-2016

Option Infer Off
Option Explicit On
Option Strict On

Public Class ExerciseTracker
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'closes the program
        Me.Close()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculate and display results

        'constants
        Const stepper As Integer = 446
        Const elliptical As Integer = 670
        Const bike As Integer = 520
        'variables
        Dim stepperhours As Double
        Dim ellipticalhours As Double
        Dim bikehours As Double
        Dim poundslost As Double
        Dim steppercals As Double
        Dim ellipticalcals As Double
        Dim bikecals As Double
        Dim totalcals As Double

        'assign user inputs
        Double.TryParse(SSTextbox.Text, stepperhours)
        Double.TryParse(ETTextbox.Text, ellipticalhours)
        Double.TryParse(SBTextbox.Text, bikehours)

        'calculate
        steppercals = stepperhours * stepper
        ellipticalcals = ellipticalhours * elliptical
        bikecals = bikehours * bike
        totalcals = steppercals + ellipticalcals + bikecals
        poundslost = totalcals / 3500

        'display
        PLLabel.Text = poundslost.ToString("N1")

    End Sub
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears inputs
        SSTextbox.Text = String.Empty
        ETTextbox.Text = String.Empty
        SBTextbox.Text = String.Empty
        PLLabel.Text = String.Empty

        'focus
        SSTextbox.Focus()

    End Sub
End Class
