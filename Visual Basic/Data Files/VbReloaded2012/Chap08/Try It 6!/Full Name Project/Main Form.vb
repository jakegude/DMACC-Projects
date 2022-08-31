' Project name:         Full Name Project
' Project purpose:      Displays the full name
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub concatenateButton_Click(sender As Object, e As EventArgs) Handles concatenateButton.Click
        ' concatenates the first and last names
        ' and then displays the result

        Dim first As String
        Dim last As String
        Dim full As String

        first = firstTextBox.Text
        last = lastTextBox.Text
        full = first & " " & last

        fullLabel.Text = full
        firstTextBox.Focus()
    End Sub

    Private Sub firstTextBox_Enter(sender As Object, e As EventArgs) Handles firstTextBox.Enter
        firstTextBox.SelectAll()
    End Sub

    Private Sub lastTextBox_Enter(sender As Object, e As EventArgs) Handles lastTextBox.Enter
        lastTextBox.SelectAll()
    End Sub

    'Private Sub SelectText(sender As Object, e As EventArgs
    '                       ) Handles firstTextBox.Enter, lastTextBox.Enter
    '    ' selects the existing text

    '    Dim thisTextBox As TextBox
    '    thisTextBox = TryCast(sender, TextBox)
    '    thisTextBox.SelectAll()
    'End Sub
End Class
