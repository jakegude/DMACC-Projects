'jake gudenkauf
'11-30-2016
'calculates bonus based on domestic and international sales

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates the bonus
        'variables
        Dim domesticsales As Double
        Dim internationalsales As Double
        Dim rate As Double
        Dim totalsales As Double

        'assign user inputs
        Double.TryParse(domesticTextbox.Text, domesticsales)
        Double.TryParse(internationalTextbox.Text, internationalsales)

        'calculate
        totalsales = domesticsales + internationalsales

        If totalsales < 100000 Then
            rate = 0.02 * totalsales
        ElseIf totalsales < 400000 Then
            rate = 2000 + 0.05 * (totalsales - 100000)
        ElseIf totalsales > 400000 Then
            rate = 17000 + 0.1 * (totalsales - 400000)
        End If

        'display
        commissionLabel.Text = rate.ToString("C2")

    End Sub
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears inputs and outputs
        domesticTextbox.Text = String.Empty
        internationalTextbox.Text = String.Empty
        commissionLabel.Text = String.Empty

        'focus
        domesticTextbox.Focus()

    End Sub
    Private Sub domesticTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles domesticTextbox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub internationalTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles internationalTextbox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
