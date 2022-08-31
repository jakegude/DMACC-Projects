'Jake Gudenkauf
'Jan 9th 2017
'average calculator

Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'closes program
        Me.Close()

    End Sub
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears all inputs and outputs
        avgScoreLabel.Text = String.Empty
        score1Textbox.Text = String.Empty
        score2Textbox.Text = String.Empty
        score3Textbox.Text = String.Empty
        'set focus
        score1Textbox.Focus()
    End Sub
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates the average of 3 scores
        'variables
        Dim score1 As Integer
        Dim score2 As Integer
        Dim score3 As Integer
        Dim AVGScore As Integer
        'assign user inputs
        Integer.TryParse(score1Textbox.Text, score1)
        Integer.TryParse(score2Textbox.Text, score2)
        Integer.TryParse(score3Textbox.Text, score3)
        'calculate
        AVGScore = (score1 + score2 + score3) \ 3
        'display
        avgScoreLabel.Text = AVGScore.ToString
    End Sub
End Class
