'jake gudenkauf
'calculates revenue
'11-17-2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears the inputs and outputs
        OBox.Text = String.Empty
        MBox.Text = String.Empty
        BBox.Text = String.Empty
        ORLabel.Text = String.Empty
        MRLabel.Text = String.Empty
        BRLabel.Text = String.Empty
        OPLabel.Text = String.Empty
        MPLabel.Text = String.Empty
        BPLabel.Text = String.Empty
        TRLabel.Text = String.Empty

        'sets focus
        OBox.Focus()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates the revenue

        'declare variables and constants
        Const orchestra As Integer = 25
        Const main As Integer = 30
        Const balcony As Integer = 15
        Dim orchestraTickets As Integer
        Dim mainTickets As Integer
        Dim balconyTickets As Integer
        Dim orchestraRevenue As Integer
        Dim mainRevenue As Integer
        Dim balconyRevenue As Integer
        Dim orchestraPercent As Decimal
        Dim mainPercent As Decimal
        Dim balconyPercent As Decimal
        Dim totalRevenue As Integer

        'assign user inputs to variables
        Integer.TryParse(OBox.Text, orchestraTickets)
        Integer.TryParse(MBox.Text, mainTickets)
        Integer.TryParse(BBox.Text, balconyTickets)

        'calc revenue
        orchestraRevenue = orchestraTickets * orchestra
        mainRevenue = mainTickets * main
        balconyRevenue = balconyTickets * balcony
        totalRevenue = orchestraRevenue + mainRevenue + balconyRevenue

        'calc percentages
        orchestraPercent = Convert.ToDecimal(orchestraRevenue / totalRevenue)
        mainPercent = Convert.ToDecimal(mainRevenue / totalRevenue)
        balconyPercent = Convert.ToDecimal(balconyRevenue / totalRevenue)

        'display
        ORLabel.Text = orchestraRevenue.ToString("N0")
        MRLabel.Text = mainRevenue.ToString("N0")
        BRLabel.Text = balconyRevenue.ToString("N0")
        TRLabel.Text = totalRevenue.ToString("C0")
        OPLabel.Text = orchestraPercent.ToString("P1")
        MPLabel.Text = mainPercent.ToString("P1")
        BPLabel.Text = balconyPercent.ToString("P1")

        'set focus
        clearButton.Focus()

    End Sub
End Class
