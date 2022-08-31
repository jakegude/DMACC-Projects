' Project name: Jake Gudenkauf         Blane Project
' Project purpose:      Display the total amount owed
' Created/revised by:   11/30/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates total amount owed
        'variables
        Dim numRegistered As Integer
        Dim total As Integer

        'assign user inputs
        Integer.TryParse(numberTextBox.Text, numRegistered)

        'determine total owed
        Select Case numRegistered
            Case 1 To 3
                total = numRegistered * 150
            Case 4 To 10
                total = 3 * 150 + (numRegistered - 3) * 100
            Case Is > 10
                total = 3 * 150 + 7 * 100 + (numRegistered - 10) * 60
            Case Else
                total = 0
                MessageBox.Show("Please Enter the number registered:", "Blane LTD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        'display
        totalLabel.Text = total.ToString("C0")
    End Sub

    Private Sub numberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numberTextBox.KeyPress
        'allows only numbers and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
