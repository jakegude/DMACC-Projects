Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        ' adds employee names to the list box

        Dim empName As String

        empName = InputBox("Who is working today?", "Name")
        Do Until empName = String.Empty
            workerListBox.Items.Add(empName)
            empName = InputBox("Who is working today?", "Name")
        Loop
    End Sub
End Class
