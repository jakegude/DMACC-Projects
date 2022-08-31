' Project name:         Temperature Solution
' Project purpose:      Convert a temperature to either Celsius or Fahrenheit
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles tempTextBox.TextChanged,
                       toCelsiusRadioButton.CheckedChanged, toFahrenheitRadioButton.CheckedChanged
        resultLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub tempTextBox_Enter(sender As Object, e As EventArgs) Handles tempTextBox.Enter
        tempTextBox.SelectAll()
    End Sub
End Class
