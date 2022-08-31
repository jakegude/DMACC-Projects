' Project name:         Carroll Project
' Project purpose:      Displays the gross pay
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the gross pay

        Const RatePerHour As Double = 10.65
        Dim hours As Double
        Dim gross As Double

        ' store input in a variable
        Double.TryParse(hoursTextBox.Text, hours)

        ' enter the selection structure here
   
    End Sub
End Class
