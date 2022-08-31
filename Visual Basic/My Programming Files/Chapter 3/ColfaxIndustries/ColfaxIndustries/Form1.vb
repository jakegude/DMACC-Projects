'Colfax Project
'Calculate number of full boxes that can be packed using items in inventory and calculates remaining items
'Program by Jake Gudenkauf

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes the program
        Me.Close()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clears all inputs
        QuantityTextbox.Text = String.Empty
        BoxTextbox.Text = String.Empty
        FullBoxLabel.Text = String.Empty
        RemainLabel.Text = String.Empty
        'sets focus to quantity textbox
        QuantityTextbox.Focus()
    End Sub
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        'calculates the number of boxes and remaining items
        'declares variables
        Dim InventoryQuantity As Integer
        Dim BoxQuantity As Integer
        Dim FullBoxes As Integer
        Dim RemainItems As Integer
        'assign user inputs to variables
        Integer.TryParse(QuantityTextbox.Text, InventoryQuantity)
        Integer.TryParse(BoxTextbox.Text, BoxQuantity)
        'calculate and display results
        FullBoxes = InventoryQuantity \ BoxQuantity
        RemainItems = InventoryQuantity Mod BoxQuantity
        FullBoxLabel.Text = Convert.ToString(FullBoxes)
        RemainLabel.Text = Convert.ToString(RemainItems)
    End Sub
End Class
