'jake gudenkauf
'12-1-2016
'sunflower resort

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'closes the program
        Me.Close()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears form
        roomTextbox.Text = String.Empty
        nightsTextbox.Text = String.Empty
        adultTextbox.Text = String.Empty
        childrenTextbox.Text = String.Empty
        roomLabel.Text = String.Empty
        taxLabel.Text = String.Empty
        feeLabel.Text = String.Empty
        totalLabel.Text = String.Empty
        messageLabel.Text = String.Empty

        'focus
        roomTextbox.Focus()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates the total amount due

        'variables
        Dim numrooms As Integer
        Dim numnights As Integer
        Dim numadults As Integer
        Dim numchildren As Integer
        Dim roomcharge As Double
        Dim taxtotal As Double
        Dim resortfeetotal As Double
        Dim totaldue As Double
        Dim message As String = "You have exceeded the maximum guests per room"
        Dim totalguest As Integer

        'constants
        Const roomfee As Double = 284
        Const tax As Double = 0.1525
        Const resortfee As Double = 15
        Const maxguests As Integer = 6


        'assign user inputs
        Integer.TryParse(roomTextbox.Text, numrooms)
        Integer.TryParse(nightsTextbox.Text, numnights)
        Integer.TryParse(adultTextbox.Text, numadults)
        Integer.TryParse(childrenTextbox.Text, numchildren)

        'calculate
        roomcharge = (numrooms * numnights) * roomfee
        taxtotal = roomcharge * tax
        resortfeetotal = (numrooms * numnights) * resortfee
        totaldue = roomcharge + tax + resortfeetotal
        totalguest = numadults + numchildren

        If totalguest > maxguests Then
            messageLabel.Text = message
        End If

        'display
        roomLabel.Text = roomcharge.ToString("N2")
        taxLabel.Text = taxtotal.ToString("N2")
        feeLabel.Text = resortfeetotal.ToString("N2")
        totalLabel.Text = totaldue.ToString("C2")

    End Sub
End Class
