' Project name:         Test Scores Project
' Project purpose:      Saves names and scores to a sequential access file and also 
'                       displays the names of students earning a specific score
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub scoreTextBox_Enter(sender As Object, e As EventArgs) Handles scoreTextBox.Enter
        scoreTextBox.SelectAll()
    End Sub

End Class
