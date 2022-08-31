Public Class Form1
    'jake gudenkauf
    'tip calculator
    'displays 10, 15, and 20$ tips on bill

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub clearButton_Click_1(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears the tip labels and the bill text box
        BillBox.Text = String.Empty
        tip10Label.Text = String.Empty
        tip15Label.Text = String.Empty
        tip20Label.Text = String.Empty

        'sets focus to bill box
        BillBox.Focus()

    End Sub

    Private Sub calcbutton_Click(sender As Object, e As EventArgs) Handles calcbutton.Click
        'calcuates and displays the tips
        Const Percent10 As Double = 0.1
        Const Percent15 As Double = 0.15
        Const Percent20 As Double = 0.2
        Dim Bill As Double
        Dim Tip10 As Double
        Dim Tip15 As Double
        Dim Tip20 As Double

        'assign user input to variable
        Double.TryParse(BillBox.Text, Bill)

        'calculate tips
        Tip10 = Bill * Percent10
        Tip15 = Bill * Percent15
        Tip20 = Bill * Percent20

        'display results
        tip10Label.Text = Tip10.ToString("C2")
        tip15Label.Text = Tip15.ToString("C2")
        tip20Label.Text = Tip20.ToString("C2")

    End Sub
End Class
