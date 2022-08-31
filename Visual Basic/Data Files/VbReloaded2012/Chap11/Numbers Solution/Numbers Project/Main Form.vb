' Project name:         Numbers Project
' Project purpose:      Displays numbers and also updates numbers by 1; the numbers
'                       are stored in a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
