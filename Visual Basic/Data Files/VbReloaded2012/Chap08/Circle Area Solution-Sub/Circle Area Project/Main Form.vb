' Project name:         Circle Area Project
' Project purpose:      Displays the area of a circle
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub radiusTextBox_Enter(sender As Object, e As EventArgs) Handles radiusTextBox.Enter
        radiusTextBox.SelectAll()
    End Sub

    Private Sub radiusTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles radiusTextBox.KeyPress
        ' allow only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub radiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles radiusTextBox.TextChanged
        areaLabel.Text = String.Empty
    End Sub
End Class
