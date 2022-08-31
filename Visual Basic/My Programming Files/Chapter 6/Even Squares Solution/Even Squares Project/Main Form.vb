' Project name:         Even Squares Project
' Project purpose:      Displays the squares of the even
'                       integers from 2 through 12
' Created/revised by:   jake gudenkauf 12-6-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        'displays the square of the even integers from 2-12.

        Dim num As Integer = 2
        Dim numSquared As Integer

        squaresLabel.Text = String.Empty

        Do While num <= 12
            numSquared = num * num
            squaresLabel.Text = squaresLabel.Text &
                numSquared.ToString & ControlChars.NewLine
            num += 2
        Loop
    End Sub
End Class
