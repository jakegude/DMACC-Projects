'jake gudenkauf
'12-1-2016
'johnson supply
'calculates the order price

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears inputs and outputs
        unitsTextbox.Text = String.Empty
        orderLabel.Text = String.Empty
        wholesaleRadioButton.Checked = False
        retailerRadioButton.Checked = False

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits program
        Me.Close()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates the order price
        'variables
        Dim units As Integer
        Dim priceperunit As Integer
        Dim totalprice As Integer

        'assign user inputs
        Integer.TryParse(unitsTextbox.Text, units)

        'calc
        Select Case True
            Case wholesaleRadioButton.Checked
                If units <= 10 Then
                    priceperunit = 20
                Else
                    priceperunit = 15
                End If
            Case retailerRadioButton.Checked
                If units <= 5 Then
                    priceperunit = 30
                ElseIf units <= 15 Then
                    priceperunit = 28
                Else
                    priceperunit = 25
                End If
        End Select

        totalprice = units * priceperunit

        'display
        orderLabel.Text = totalprice.ToString("C0")

    End Sub
End Class
