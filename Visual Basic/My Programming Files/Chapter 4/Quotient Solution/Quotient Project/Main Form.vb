' Project name:         Quotient Project
' Project purpose:      Divides two numbers and displays the quotient
' Created/revised by:   jake gudenkauf on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'divide the first number by the second number and displays the quotient

        'variables
        Dim num1 As Double
        Dim num2 As Double
        Dim quotient As Double

        Double.TryParse(firstTextBox.Text, num1)
        Double.TryParse(secondTextBox.Text, num2)

        'calculate
        If num2 <> 0 Then
            quotient = num1 / num2
        Else
            quotient = 0
        End If

        'display 
        quotientLabel.Text = quotient.ToString("N2")
    End Sub
End Class
