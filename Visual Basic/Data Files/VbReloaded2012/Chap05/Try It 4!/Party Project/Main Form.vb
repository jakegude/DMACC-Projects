' Project name:         Party Project
' Project purpose:      Displays the price for a balloon bouquet
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the price for a bouquet of balloons

        Dim price As Double

        ' determine occasion


        ' if necessary, add $10 for a large bouquet
 

        ' display price
        priceLabel.Text = price.ToString("C2")
    End Sub
End Class
