' Project name:         Framington Project
' Project purpose:      Display the number of tables needed to seat guests at a party
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' calculates the number of tables that seat 10, the number of tables that seat 5, and the number of guests remaining
        ' example: 67 guests need 6 tables of 10 and 1 table of 5, with 2 guests remaining

        Dim guests As Integer
        Dim table10 As Integer
        Dim table5 As Integer
        Dim remain As Integer

        ' assign input to a variable
        Integer.TryParse(guestsTextBox.Text, guests)

        ' perform calculations
        table10 = guests / 10
        remain = guests - table10 * 10
        table5 = remain / 5
        remain = remain - table5 * 5

        ' display calculated results
        table10Label.Text = table10
        table5Label.Text = table5
        remainLabel.Text = remain
    End Sub
End Class
