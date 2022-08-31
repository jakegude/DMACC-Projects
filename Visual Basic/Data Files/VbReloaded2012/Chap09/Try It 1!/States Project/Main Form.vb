' Project name:         States Project
' Project purpose:      Displays the selected list box item
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with array values and then selects the first item

        Dim states() As String = {"Alaska", "Florida", "Iowa", "Ohio"}

        ' Example 1 in Figure 9-7
        Dim highestSub As Integer = states.GetUpperBound(0)
        For subscript As Integer = 0 To highestSub
            statesListBox.Items.Add(states(subscript))
        Next subscript

        ' Example 2 in Figure 9-7
        'Dim highestSub As Integer = states.Length - 1
        'Dim subscript As Integer
        'Do While subscript <= highestSub
        '    statesListBox.Items.Add(states(subscript))
        '    subscript += 1
        'Loop

        statesListBox.SelectedIndex = 0

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub statesListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles statesListBox.SelectedValueChanged
        selectedItemLabel.Text = statesListBox.SelectedItem.ToString
    End Sub
End Class
