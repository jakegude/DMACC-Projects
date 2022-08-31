''jake gudenkauf
'12-1-2016
'shopper stoppers

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'closes the program
        Me.Close()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates the reward points
        'variables
        Dim purchase As Double
        Dim points As Double

        'assign user input
        Double.TryParse(totalTextbox.Text, purchase)

        'cases
        Select Case True
            Case basicRadioButton.Checked
                If purchase < 100 Then
                    points = purchase * 0.05
                Else
                    points = purchase * 0.07
                End If
            Case standardRadioButton.Checked
                If purchase < 150 Then
                    points = purchase * 0.06
                ElseIf purchase < 300 Then
                    points = purchase * 0.08
                Else
                    points = purchase * 0.1
                End If
            Case premiumRadioButton.Checked
                If purchase < 200 Then
                    points = purchase * 0.07
                Else points = purchase * 0.15
                End If
        End Select

        'display
        rewardLabel.Text = points.ToString("N0")

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears the inputs and variables
        totalTextbox.Text = String.Empty
        rewardLabel.Text = String.Empty
        basicRadioButton.Checked = False
        standardRadioButton.Checked = False
        premiumRadioButton.Checked = False

        totalTextbox.Focus()

    End Sub
End Class
