' Project name:         Phone Project
' Project purpose:      Removes any hyphens and parentheses from a phone number
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numberTextBox_Enter(sender As Object, e As EventArgs) Handles numberTextBox.Enter
        numberTextBox.SelectAll()
    End Sub

    Private Sub numberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numberTextBox.KeyPress
        ' allows numbers, hyphen, parentheses, and Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "-" AndAlso
            e.KeyChar <> "(" AndAlso e.KeyChar <> ")" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub numberTextBox_TextChanged(sender As Object, e As EventArgs) Handles numberTextBox.TextChanged
        numberLabel.Text = String.Empty
    End Sub

End Class
