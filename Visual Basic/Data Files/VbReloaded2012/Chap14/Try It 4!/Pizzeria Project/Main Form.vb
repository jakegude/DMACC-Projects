' Project name:         Pizzeria Project
' Project purpose:      Display the number of square pizza slices 
'                       that can be cut from a square pizza
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' displays the number of square pizza slices
        ' that can be cut from a square pizza

        Dim entirePizza As New Rectangle
        Dim pizzaSlice As New Rectangle
        Dim entireArea As Double
        Dim sliceArea As Double
        Dim slices As Double

        Double.TryParse(entirePizzaTextBox.Text, entirePizza.Length)
        Double.TryParse(entirePizzaTextBox.Text, entirePizza.Width)
        Double.TryParse(pizzaSliceTextBox.Text, pizzaSlice.Length)
        Double.TryParse(pizzaSliceTextBox.Text, pizzaSlice.Width)

        ' calculate areas
        entireArea = entirePizza.GetArea
        sliceArea = pizzaSlice.GetArea
        ' calculate number of slices
        If sliceArea > 0 Then
            slices = entireArea / sliceArea
        Else
            slices = 0
        End If
        ' display number of slices
        slicesLabel.Text = slices.ToString("N1")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub entirePizzaTextBox_Enter(sender As Object, e As EventArgs) Handles entirePizzaTextBox.Enter
        entirePizzaTextBox.SelectAll()
    End Sub

    Private Sub pizzaSliceTextBox_Enter(sender As Object, e As EventArgs) Handles pizzaSliceTextBox.Enter
        pizzaSliceTextBox.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles entirePizzaTextBox.KeyPress, pizzaSliceTextBox.KeyPress
        ' allows only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles entirePizzaTextBox.TextChanged, pizzaSliceTextBox.TextChanged
        slicesLabel.Text = String.Empty
    End Sub
End Class
