' Project name:         Auction Project
' Project purpose:      Displays the lowest and highest bids
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the lowest and highest bids

        Dim bid1 As Integer
        Dim bid2 As Integer

        ' assign input to variables
        Integer.TryParse(bid1TextBox.Text, bid1)
        Integer.TryParse(bid2TextBox.Text, bid2)

        ' swap bids, if necessary
        If bid1 > bid2 Then
            Dim temp As Integer
            temp = bid1
            bid1 = bid2
            bid2 = temp
        End If

        ' display bids
        bidsLabel.Text = "Lowest: " & bid1.ToString &
            ControlChars.NewLine & "Highest: " & bid2.ToString
    End Sub
End Class
