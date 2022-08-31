Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' concatenates strings

        Dim city As String = "Bowling Green"
        Dim state As String = "KY"
        Dim people As Integer = 58300
        Const CoName As String = "Sun Products"

        ' enter the concatenated string after the = sign
        msgLabel.Text =

    End Sub
End Class
