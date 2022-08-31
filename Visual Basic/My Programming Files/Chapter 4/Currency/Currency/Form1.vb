'jake gudenkauf
'currency converter
'11-29-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()

    End Sub

    Private Sub convertButton_Click(sender As Object, e As EventArgs) Handles convertButton.Click
        'converts the inputted US dollars to a foreign currency
        'constants
        Const CanadianDollar As Double = 1.01
        Const Euro As Double = 0.76
        Const Rupee As Double = 53.86
        Const Yen As Double = 99.1
        Const Peso As Double = 12.07
        Const Rand As Double = 8.93
        Const Pound As Double = 0.64

        'variables
        Dim USDollar As Double
        Dim Rate As Double
        Dim Converted As Double

        'assign user inputs
        Double.TryParse(USTextbox.Text, USDollar)

        Select Case True
            Case CanadianRadioButton.Checked
                Rate = CanadianDollar
            Case EuroRadioButton.Checked
                Rate = Euro
            Case RupeeRadioButton.Checked
                Rate = Rupee
            Case YenRadioButton.Checked
                Rate = Yen
            Case PesoRadioButton.Checked
                Rate = Peso
            Case RandRadioButton.Checked
                Rate = Rand
            Case PoundRadioButton.Checked
                Rate = Pound
        End Select

        'calc
        Converted = USDollar * Rate
        convertedLabel.Text = Converted.ToString("N3")

    End Sub

    Private Sub USTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles USTextbox.KeyPress
        'allow only numbers and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub
End Class