' Project name:         Circle Project
' Project purpose:      Displays the area of a circle
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculate area of a circle

        ' declare constant and variables
        Const Pi As Double = 3.141593
        Dim radius As Double
        Dim area As Double

        ' assign user input to a variable
        Double.TryParse(radiusTextBox.Text, radius)

        ' calculate and display area
        area = Pi * radius * radius
        areaLabel.Text = area.ToString("N2")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' prepare screen for next calculation

        radiusTextBox.Text = String.Empty
        areaLabel.Text = String.Empty
        radiusTextBox.Focus()
    End Sub
End Class
