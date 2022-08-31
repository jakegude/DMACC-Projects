' Project name:         Actor Actress Project
' Project purpose:      Displays a message that contains the name of either an actor or an actress
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub DisplayMsg(ByVal type As String,
                           ByVal performer As String)
  
        msgLabel.Text = "Your favorite " & type &
            " is " & performer & "."
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click

        Dim category As String
        Dim name As String

        If actorRadioButton.Checked = True Then
            category = "actor"
            name =
                InputBox("Your favorite actor?", "Actor")
        Else
            category = "actress"
            name = InputBox("Your favorite actress?", "Actress")
        End If

        Call DisplayMsg(category, name)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub actorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles actorRadioButton.CheckedChanged
        msgLabel.Text = String.Empty
    End Sub

    Private Sub actressRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles actressRadioButton.CheckedChanged
        msgLabel.Text = String.Empty
    End Sub
End Class
