' Project name:         Count Project
' Project purpose:      Displays the number of times the numbers 1 through 9
'                       appear in a two-dimensional array
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private numbers(,) As Integer = {{1, 8}, {4, 5}, {7, 9}, {3, 1}, {9, 3}, {5, 9},
                                     {8, 8}, {9, 9}, {7, 3}, {2, 1}, {5, 4}}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
