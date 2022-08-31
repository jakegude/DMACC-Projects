' Project name:         Debug Project
' Project purpose:      Displays the total amount due
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub salesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salesTextBox.KeyPress
        ' accept only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the total amount due

        Dim sales As Double
        Dim discount As Double
        Dim totalDue As Double

        ' assign input to a variable
        Double.TryParse(salesTextBox.Text, sales)

        ' calculate discount
        Select Case True
            Case disc5RadioButton.Checked
                discount = 0.05 * sales
            Case Else
                discount = 0.1 * sales
        End Select

        ' calculate and display total due
        totalDue = sales - discount
        totalLabel.Text = totalDue.ToString("C2")

        salesTextBox.Focus()
    End Sub
End Class
