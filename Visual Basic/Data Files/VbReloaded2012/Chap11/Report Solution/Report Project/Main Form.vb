' Project name:         Report Project
' Project purpose:      Writes a report to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Structure StateInfo
        Public name As String
        Public sales As Integer
    End Structure

    Private stateSales(2) As StateInfo

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill array with values

        stateSales(0).name = "Arizona"
        stateSales(0).sales = 25500
        stateSales(1).name = "New Mexico"
        stateSales(1).sales = 10300
        stateSales(2).name = "Texas"
        stateSales(2).sales = 9900
    End Sub

End Class
