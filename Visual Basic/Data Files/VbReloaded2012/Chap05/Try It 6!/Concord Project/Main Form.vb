' Project name:         Concord Project
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
        ' calculates the total amount owed

        Const PricePerBox As Double = 19.99
        Dim boxes As Integer
        Dim subtotal As Double
        Dim shipping As Integer
        Dim total As Double

        Integer.TryParse(boxesTextBox.Text, boxes)
        subtotal = boxes * PricePerBox

        ' determine shipping
        If subtotal > 79 Then
            shipping = 0
        Else
            If clubCheckBox.Checked Then
                shipping = 10
            Else
                shipping = 20
            End If
        End If

        ' calculate and display total owed
        total = subtotal + shipping
        totalLabel.Text = total.ToString("C2")
    End Sub

    Private Sub boxesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boxesTextBox.KeyPress
        ' accept only numbers and the Backspace key


    End Sub
End Class
