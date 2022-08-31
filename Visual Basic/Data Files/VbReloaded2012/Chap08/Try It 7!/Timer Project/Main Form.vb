' Project name:         Timer Example Project
' Project purpose:      Blink a message 10 times
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub blinkButton_Click(sender As Object, e As EventArgs) Handles blinkButton.Click
        ' turns the timer on
        blinkTimer.Enabled = True
    End Sub

    Private Sub blinkTimer_Tick(sender As Object, e As EventArgs) Handles blinkTimer.Tick
        ' blinks the welcomeLabel 10 times

        Static numBlinks As Integer = 1

        If numBlinks < 21 Then
            welcomeLabel.Visible = Not welcomeLabel.Visible
            numBlinks += 1
        Else
            ' turns the timer off
            blinkTimer.Enabled = False
        End If
    End Sub
End Class
