' Name:         Discount Calculator Project
' Purpose:      Displays a discount amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub disc15Button_Click(sender As Object, e As EventArgs) Handles disc15Button.Click
        ' calculates and displays a 15% discount

        ' declare variables
        Dim sales As Double
        Dim discount15 As Double

        ' convert input to Double
        Double.TryParse(salesTextBox.Text, sales)

        ' calculate and display discount
        discount15 = sales * 0.15
        discountLabel.Text = Convert.ToString(discount15)
    End Sub

    Private Sub disc20Button_Click(sender As Object, e As EventArgs) Handles disc20Button.Click
        ' calculates and displays a 20% discount

        ' declare variables
        Dim sales As Double
        Dim discount20 As Double

        ' convert input to Double
        Double.TryParse(salesTextBox.Text, sales)

        ' calculate and display discount
        discount20 = sales * 0.2
        discountLabel.Text = Convert.ToString(discount20)
    End Sub
End Class
