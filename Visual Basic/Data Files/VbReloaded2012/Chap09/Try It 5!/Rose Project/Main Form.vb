' Project name:         Rose Project
' Project purpose:      Displays the total due for tickets
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private prices() As Double = {103, 95, 75.5, 32.5}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills list box

        sectionListBox.Items.Add("A")
        sectionListBox.Items.Add("B")
        sectionListBox.Items.Add("C")
        sectionListBox.Items.Add("D")
        sectionListBox.SelectedIndex = 0
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the total due for tickets

        Dim numTickets As Integer
        Dim subscript As Integer
        Dim ticketPrice As Double
        Dim totalDue As Double

        Integer.TryParse(ticketsTextBox.Text, numTickets)
        subscript = sectionListBox.SelectedIndex
        ticketPrice = prices(subscript)
        totalDue = ticketPrice * numTickets

        totalPriceLabel.Text = totalDue.ToString("C2")
    End Sub

    Private Sub ticketsTextBox_Enter(sender As Object, e As EventArgs) Handles ticketsTextBox.Enter
        ticketsTextBox.SelectAll()
    End Sub

    Private Sub ticketsTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ticketsTextBox.KeyPress
        ' accepts only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ticketsTextBox_TextChanged(sender As Object, e As EventArgs) Handles ticketsTextBox.TextChanged, sectionListBox.SelectedIndexChanged
        totalPriceLabel.Text = String.Empty
    End Sub
End Class
