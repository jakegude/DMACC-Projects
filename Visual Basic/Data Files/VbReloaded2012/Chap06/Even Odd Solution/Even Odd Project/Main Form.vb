' Project name:         Even Odd Project
' Project purpose:      Displays the even and odd integers between two numbers
' Created/revised by:   jake gudenkauf on 12-6-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub pretestButton_Click(sender As Object, e As EventArgs) Handles pretestButton.Click
        'displays the even integers from 2-10

        Dim evenNum As Integer = 2

        pretestListBox.Items.Clear()

        Do While evenNum < 11
            pretestListBox.Items.Add(evenNum.ToString)
            evenNum += 2
        Loop
    End Sub

    Private Sub posttestButton_Click(sender As Object, e As EventArgs) Handles posttestButton.Click
        'displays the odd integers from 21-39

        Dim oddNum As Integer = 21

        posttestListBox.Items.Clear()

        Do
            posttestListBox.Items.Add(oddNum.ToString)
            oddNum += 2
        Loop While oddNum < 40
    End Sub
End Class
