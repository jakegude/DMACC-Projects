' Project name:         Optional Project
' Project purpose:      Displays a bonus amount
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub CalcBonus(ByVal totalSales As Double, ByRef bonusAmount As Double, ByVal bonusRate As Double)
        ' calculates the bonus amount

        bonusAmount = totalSales * bonusRate
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates a bonus amount

        Dim code As String
        Dim inputRate As String
        Dim sales As Double
        Dim bonus As Double
        Dim rate As Double

        code = codeTextBox.Text.ToUpper
        Double.TryParse(salesTextBox.Text, sales)

        ' if the salesperson's code is "A", get the bonus rate;
        ' otherwise, use the default bonus rate
        If code = "A" Then
            inputRate = InputBox("Rate:", "Rate Entry")
            Double.TryParse(inputRate, rate)
            ' calculate and display the bonus
            Call CalcBonus(sales, bonus, rate)
            bonusLabel.Text = bonus.ToString("C2")
        Else
            ' calculate and display the bonus
            Call CalcBonus(sales, bonus)
            bonusLabel.Text = bonus.ToString("C2")
        End If

        codeTextBox.Focus()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub codeTextBox_Enter(sender As Object, e As EventArgs) Handles codeTextBox.Enter
        codeTextBox.SelectAll()
    End Sub

    Private Sub salesTextBox_Enter(sender As Object, e As EventArgs) Handles salesTextBox.Enter
        salesTextBox.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles codeTextBox.TextChanged, salesTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub
End Class
