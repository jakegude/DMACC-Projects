Public Class MainForm
    'Jake Gudenkauf
    'program for vans and more depot

    Option Explicit On
    Option Infer Off
    Option Strict On

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()
    End Sub
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates and displays the number of filled vans and the number of people remaining
        'declare named constant and variables
        Const MaxInVan As Integer = 10
        Dim attendees As Integer
        Dim vans As Integer
        Dim remaining As Integer

        'store user input in a variable
        Integer.TryParse(attendeesTextBox.Text, attendees)

        'calculate number of filled vans
        vans = attendees \ MaxInVan

        'calculate number remaining
        remaining = attendees Mod MaxInVan

        'display output
        vansLabel.Text = vans.ToString
        remainingLabel.Text = remaining.ToString
        attendeesTextBox.Focus()

    End Sub
End Class
