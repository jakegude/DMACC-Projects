' Project name:         Yardley Project
' Project purpose:      Displays the price of a ticket
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the ticket price

        Dim code As Integer
        Integer.TryParse(codeTextBox.Text, code)

        ' display appropriate price
        
    End Sub
End Class
