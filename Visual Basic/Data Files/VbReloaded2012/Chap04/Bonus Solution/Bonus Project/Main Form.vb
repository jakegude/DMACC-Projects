' Project name:         Bonus Project
' Project purpose:      Displays the amount of a bonus 
' Created/revised by:   jake gudenkauf On <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculate the bonus
        'declare
        Dim sales As Double
        Dim rate As Double
        Dim bonus As Double

        'assign
        Double.TryParse(salesTextBox.Text, sales)

        'determine bonus rate
        If sales > 3500 Then
            rate = 0.05
        Else
            rate = 0.04
        End If

        'calculate and display bonus amount
        bonus = sales * rate
        bonusLabel.Text = bonus.ToString("C2")

    End Sub
End Class
