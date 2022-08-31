' Project name:         Color Game Project
' Project purpose:      Teach the English and Spanish color words
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub blueButton_Click(sender As Object, e As EventArgs) Handles blueButton.Click
        blueButton.BackColor = Color.LightBlue
        blueButton.Text = "Azul"
        My.Computer.Audio.Play("blue.wav")

    End Sub

    Private Sub brownButton_Click(sender As Object, e As EventArgs) Handles brownButton.Click
        brownButton.BackColor = Color.Brown
        brownButton.Text = "Marron"
        My.Computer.Audio.Play("brown.wav")

    End Sub

    Private Sub grayButton_Click(sender As Object, e As EventArgs) Handles grayButton.Click
        grayButton.BackColor = Color.Gray
        grayButton.Text = "Gris"
        My.Computer.Audio.Play("gray.wav")

    End Sub

    Private Sub greenButton_Click(sender As Object, e As EventArgs) Handles greenButton.Click
        greenButton.BackColor = Color.Green
        greenButton.Text = "Verde"
        My.Computer.Audio.Play("green.wav")

    End Sub

    Private Sub orangeButton_Click(sender As Object, e As EventArgs) Handles orangeButton.Click
        orangeButton.BackColor = Color.Orange
        orangeButton.Text = "Anaranjado"
        My.Computer.Audio.Play("orange.wav")

    End Sub

    Private Sub pinkButton_Click(sender As Object, e As EventArgs) Handles pinkButton.Click
        pinkButton.BackColor = Color.Pink
        pinkButton.Text = "Rosa"
        My.Computer.Audio.Play("pink.wav")

    End Sub

    Private Sub purpleButton_Click(sender As Object, e As EventArgs) Handles purpleButton.Click
        purpleButton.BackColor = Color.MediumPurple
        purpleButton.Text = "Morado"
        My.Computer.Audio.Play("purple.wav")

    End Sub

    Private Sub redButton_Click(sender As Object, e As EventArgs) Handles redButton.Click
        redButton.BackColor = Color.Red
        redButton.Text = "Rojo"
        My.Computer.Audio.Play("red.wav")

    End Sub

    Private Sub yellowButton_Click(sender As Object, e As EventArgs) Handles yellowButton.Click
        yellowButton.BackColor = Color.Yellow
        yellowButton.Text = "Amarillo"
        My.Computer.Audio.Play("yellow.wav")

    End Sub

    Private Sub startOverButton_Click(sender As Object, e As EventArgs) Handles startOverButton.Click
        blueButton.BackColor = Color.White
        brownButton.BackColor = Color.White
        grayButton.BackColor = Color.White
        greenButton.BackColor = Color.White
        orangeButton.BackColor = Color.White
        pinkButton.BackColor = Color.White
        purpleButton.BackColor = Color.White
        redButton.BackColor = Color.White
        yellowButton.BackColor = Color.White

    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        PrintForm1.PrintAction =
            Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub fontButton_Click(sender As Object, e As EventArgs) Handles fontButton.Click
        fontDialog.Font = Me.Font
        fontDialog.ShowDialog()
        Me.Font = fontDialog.Font

    End Sub
End Class
