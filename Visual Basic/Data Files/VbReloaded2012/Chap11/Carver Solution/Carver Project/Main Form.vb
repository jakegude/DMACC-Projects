' Project name:         Carver Project
' Project purpose:      Displays a grade based on the number of 
'                       points the user enters
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub pointsTextBox_Enter(sender As Object, e As EventArgs) Handles pointsTextBox.Enter
        pointsTextBox.SelectAll()
    End Sub

    Private Sub pointsTextBox_TextChanged(sender As Object, e As EventArgs) Handles pointsTextBox.TextChanged
        gradeLabel.Text = String.Empty
    End Sub

End Class
