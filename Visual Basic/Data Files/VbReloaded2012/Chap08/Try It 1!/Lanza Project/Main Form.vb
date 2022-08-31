' Project name:         Lanza Project
' Project purpose:      Display an employee's regular, overtime, and gross weekly pay
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub ClearLabels()
        regularLabel.Text = String.Empty
        overtimeLabel.Text = String.Empty
        grossLabel.Text = String.Empty
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the combo boxes with values

        For hours As Double = 0 To 50 Step 0.5
            hoursComboBox.Items.Add(hours.ToString("N1"))
        Next hours
        hoursComboBox.SelectedItem = "40.0"

        For rates As Double = 7.75 To 12.5 Step 0.25
            rateComboBox.Items.Add(rates.ToString("N2"))
        Next rates
        rateComboBox.SelectedItem = "10.00"
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates regular pay, overtime pay,
        ' and gross pay

        Dim hours As Double
        Dim rate As Double
        Dim regular As Double
        Dim overtime As Double
        Dim gross As Double

        Double.TryParse(hoursComboBox.Text, hours)
        Double.TryParse(rateComboBox.Text, rate)

        If hours <= 40 Then
            ' calculate regular pay only
            regular = hours * rate
        Else
            ' calculate regular and overtime pay
            regular = 40 * rate
            overtime = (hours - 40) * rate * 1.5
        End If

        ' calculate gross pay
        gross = regular + overtime

        ' display calculated results
        regularLabel.Text = regular.ToString("N2")
        overtimeLabel.Text = overtime.ToString("N2")
        grossLabel.Text = gross.ToString("N2")
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Call ClearLabels()
    End Sub

    Private Sub hoursComboBox_TextChanged(sender As Object, e As EventArgs) Handles hoursComboBox.TextChanged
        Call ClearLabels()
    End Sub

    Private Sub rateComboBox_TextChanged(sender As Object, e As EventArgs) Handles rateComboBox.TextChanged
        Call ClearLabels()
    End Sub
End Class
