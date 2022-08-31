' Project name:         Laury Project
' Project purpose:      Displays a shipping charge
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub orderedTextBox_Enter(sender As Object, e As EventArgs) Handles orderedTextBox.Enter
        orderedTextBox.SelectAll()
    End Sub

    Private Sub orderedTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles orderedTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub orderedTextBox_TextChanged(sender As Object, e As EventArgs) Handles orderedTextBox.TextChanged
        shippingLabel.Text = String.Empty
    End Sub

End Class
