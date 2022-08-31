' Project name:         Frankenstein Project
' Project purpose:      Allows the user to guess a 
'                       word letter-by-letter
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private word As String
    Private incorrect As Integer

    Private Sub DisplayPicture()
        ' display appropriate picture

        Select Case incorrect
            Case 1
                headPictureBox.Visible = True
            Case 2
                torsoPictureBox.Visible = True
            Case 3
                rightArmPictureBox.Visible = True
            Case 4
                leftArmPictureBox.Visible = True
            Case 5
                rightLegPictureBox.Visible = True
            Case 6
                leftLegPictureBox.Visible = True
        End Select
    End Sub

    Private Sub DetermineGameOver(ByVal dashReplaced As Boolean)
        ' determine whether the game is over and
        ' take the appropriate action

        If dashReplaced = True Then
            ' if the word does not contain any dashes, 
            ' the game is over because player 2 
            ' guessed the word
            If wordLabel.Text.Contains("-") = False Then
                MessageBox.Show("Great guessing!", "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                checkButton.Enabled = False
                incorrect = 0
            End If
        Else
            ' if the user made 6 incorrect guesses,
            ' the game is over
            If incorrect = 6 Then
                MessageBox.Show("Sorry, the word is " &
                                word & ".", "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                checkButton.Enabled = False
                incorrect = 0
            End If
        End If
    End Sub

    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles checkButton.Click
        ' check if the letter appears in the word

        Dim letter As String
        Dim dashReplaced As Boolean

        letter = letterTextBox.Text

        ' look at each letter in the word


        If dashReplaced = True Then
            Call DetermineGameOver(dashReplaced)
        Else  ' no dash was replaced
            incorrectLabel.Text =
                incorrectLabel.Text & " " & letter
            incorrect += 1
            Call DisplayPicture()
            Call DetermineGameOver(dashReplaced)
        End If

        ' clear text box and set focus
        letterTextBox.Text = String.Empty
        letterTextBox.Focus()
    End Sub
End Class
