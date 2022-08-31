' Project name:         Math Project
' Project purpose:      Displays either the sum or the product of two numbers
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the sum or product of two numbers

        Dim operation As String
        Dim decimalPlaces As String
        Dim firstNum As Double
        Dim secondNum As Double
        Dim answer As Double
        Dim operationMsg As String

        ' store input in variables
        operation = operationTextBox.Text
        decimalPlaces = decimalPlacesTextBox.Text
        Double.TryParse(firstTextBox.Text, firstNum)
        Double.TryParse(secondTextBox.Text, secondNum)

        ' determine operation and perform calculation
        If operation = "A" Then
            answer = firstNum + secondNum
            operationMsg = "Sum: "
        Else
            answer = firstNum * secondNum
            operationMsg = "Product: "
        End If

        ' determine number of decimal places and display answer
        If decimalPlaces = "1" Then
            answerLabel.Text = operationMsg & answer.ToString("N1")
        Else
            answerLabel.Text = operationMsg & answer.ToString("N2")
        End If
    End Sub
End Class
