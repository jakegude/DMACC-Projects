' Project name:         Starward Coffee Project
' Project purpose:      Display the total number of pounds used during a 12-month period and the 
'                       average number of pounds used each month
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private poundsUsed() As Double = {400.5, 450, 475.5,
                                      336.5, 457, 325,
                                      220.5, 276, 300,
                                      320.5, 400.5, 415}

    Private Sub forNextButton_Click(sender As Object, e As EventArgs) Handles forNextButton.Click
        ' displays the total and average pounds used

        Dim highSub As Integer = poundsUsed.GetUpperBound(0)
        Dim total As Double
        Dim average As Double

        ' accumulate pounds used 
        For subscript As Integer = 0 To highSub
            total += poundsUsed(subscript)
        Next subscript
        ' calculate average
        average = total / poundsUsed.Length

        totalLabel.Text = total.ToString("N1")
        averageLabel.Text = average.ToString("N2")
    End Sub

    Private Sub doLoopButton_Click(sender As Object, e As EventArgs) Handles doLoopButton.Click
        ' displays the total and average pounds used

        Dim highSub As Integer = poundsUsed.GetUpperBound(0)
        Dim total As Double
        Dim average As Double
        Dim subscript As Integer

        ' accumulate pounds used
        Do While subscript <= highSub
            total += poundsUsed(subscript)
            subscript += 1
        Loop
        ' calculate average
        average = total / poundsUsed.Length

        totalLabel.Text = total.ToString("N1")
        averageLabel.Text = average.ToString("N2")
    End Sub

    Private Sub forEachNextButton_Click(sender As Object, e As EventArgs) Handles forEachNextButton.Click
        ' displays the total and average pounds used

        Dim total As Double
        Dim average As Double

        ' accumulate pounds used
        For Each pound As Double In poundsUsed
            total += pound
        Next pound
        ' calculate average
        average = total / poundsUsed.Length

        totalLabel.Text = total.ToString("N1")
        averageLabel.Text = average.ToString("N2")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
