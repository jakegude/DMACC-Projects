'jake gudenkauf
'generates 6 lotto numbers
'11-22-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub numbersButton_Click(sender As Object, e As EventArgs) Handles numbersButton.Click
        'generates numbers
        'variables
        Dim randomgenerator As New Random
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim num4 As Integer
        Dim num5 As Integer
        Dim num6 As Integer

        num1 = randomgenerator.Next(1, 55)
        num2 = randomgenerator.Next(1, 55)
        num3 = randomgenerator.Next(1, 55)
        num4 = randomgenerator.Next(1, 55)
        num5 = randomgenerator.Next(1, 55)
        num6 = randomgenerator.Next(1, 55)

        'display random numbers
        numbersLabel.Text = Convert.ToString(num1) & " " & Convert.ToString(num2) & " " & Convert.ToString(num3) & " " & Convert.ToString(num4) & " " & Convert.ToString(num5) & " " & Convert.ToString(num6) & " "
    End Sub
End Class
