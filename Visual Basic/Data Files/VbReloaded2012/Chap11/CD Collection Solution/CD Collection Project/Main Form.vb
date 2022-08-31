' Project name:         CD Collection Project
' Project purpose:      Allows the user to add and delete list box entries
'                       Reads CD information from a sequential access file
'                       Writes CD information to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
