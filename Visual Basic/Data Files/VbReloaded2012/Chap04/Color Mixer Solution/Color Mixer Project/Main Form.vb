' Project name:         Color Mixer Project
' Project purpose:      Show the color associated with
'                       the values entered by the user
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
        ' change the oval's color

        ' declare variables
        Dim inputRed As Integer
        Dim inputGreen As Integer
        Dim inputBlue As Integer

        ' assign input to variables
        Integer.TryParse(redTextBox.Text, inputRed)
        Integer.TryParse(greenTextBox.Text, inputGreen)
        Integer.TryParse(blueTextBox.Text, inputBlue)

        ' change color
        colorOvalShape.BackColor =
            Color.FromArgb(inputRed, inputGreen, inputBlue)
    End Sub
End Class
