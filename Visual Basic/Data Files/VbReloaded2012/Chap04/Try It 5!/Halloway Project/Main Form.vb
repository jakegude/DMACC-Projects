' Project name:         Halloway Project
' Project purpose:      Displays the total owed
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the total owed

        Const DiscRate As Decimal = 0.1D
        Dim quantity As Integer
        Dim price As Decimal
        Dim subtotal As Decimal
        Dim discount As Decimal
        Dim totalDue As Decimal

        ' store input in variables
        Integer.TryParse(quantityTextBox.Text, quantity)
        Decimal.TryParse(priceTextBox.Text, price)

        ' calculate subtotal, discount, and total due
        subtotal = quantity * price
        ' enter the selection structure here
 
        totalDue = subtotal - discount

        totalDueLabel.Text = totalDue.ToString("C2")
    End Sub
End Class
