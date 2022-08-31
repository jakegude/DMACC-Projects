'Jake Gudenkauf
'tea time project
'11-22-16

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits program
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears inputs and output
        poundsTextbox.Text = String.Empty
        discountCheckbox.Checked = False
        shippingCheckbox.Checked = False
        totaldueLabel.Text = String.Empty

        'focus
        poundsTextbox.Focus()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates and displays the total due

        'constants
        Const PricePerPound As Double = 11.25
        Const DiscountRate As Double = 0.1
        Const ShippingFee As Integer = 5

        'variables
        Dim ordered As Double
        Dim totalDue As Double

        'assign user input
        Double.TryParse(poundsTextbox.Text, ordered)

        'calculate total due
        totalDue = ordered * PricePerPound

        If discountCheckbox.Checked Then
            totalDue = totalDue - (totalDue * DiscountRate)
        End If

        If shippingCheckbox.Checked Then
            totalDue += ShippingFee
        End If

        'display
        totaldueLabel.Text = totalDue.ToString("C2")
    End Sub
End Class
