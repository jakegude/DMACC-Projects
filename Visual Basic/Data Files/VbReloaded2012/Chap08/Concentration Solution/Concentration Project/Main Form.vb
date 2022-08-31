' Project name:         Concentration Project
' Project purpose:      Simulates the Concentration game, 
'                       where a player tries to find 
'                       matching pairs of words
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with 8 pairs of matching  
        ' words, then calls a procedure to shuffle 
        ' the words

        wordListBox.Items.Add("Refrigerator")
        wordListBox.Items.Add("Range")
        wordListBox.Items.Add("Television")
        wordListBox.Items.Add("Computer")
        wordListBox.Items.Add("Washer/Dryer")
        wordListBox.Items.Add("Dishwasher")
        wordListBox.Items.Add("Car")
        wordListBox.Items.Add("Trip")
        wordListBox.Items.Add("Refrigerator")
        wordListBox.Items.Add("Range")
        wordListBox.Items.Add("Television")
        wordListBox.Items.Add("Computer")
        wordListBox.Items.Add("Washer/Dryer")
        wordListBox.Items.Add("Dishwasher")
        wordListBox.Items.Add("Car")
        wordListBox.Items.Add("Trip")


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        ' removes any words from the label controls, then
        ' enables the label controls, then resets the 
        ' selection counter, and then calls a procedure
        ' to shuffle the words

        Label1.Text = String.Empty
        Label2.Text = String.Empty
        Label3.Text = String.Empty
        Label4.Text = String.Empty
        Label5.Text = String.Empty
        Label6.Text = String.Empty
        Label7.Text = String.Empty
        Label8.Text = String.Empty
        Label9.Text = String.Empty
        Label10.Text = String.Empty
        Label11.Text = String.Empty
        Label12.Text = String.Empty
        Label13.Text = String.Empty
        Label14.Text = String.Empty
        Label15.Text = String.Empty
        Label16.Text = String.Empty

        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        Label4.Enabled = True
        Label5.Enabled = True
        Label6.Enabled = True
        Label7.Enabled = True
        Label8.Enabled = True
        Label9.Enabled = True
        Label10.Enabled = True
        Label11.Enabled = True
        Label12.Enabled = True
        Label13.Enabled = True
        Label14.Enabled = True
        Label15.Enabled = True
        Label16.Enabled = True


    End Sub

    Private Sub TestForMatch(sender As Object, e As EventArgs) Handles Label1.Click,
        Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click,
        Label8.Click, Label9.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click,
        Label14.Click, Label15.Click, Label16.Click
        ' displays the appropriate words and determines 
        ' whether the user selected a matching pair 


    End Sub

    Private Sub matchTimer_Tick(sender As Object, e As EventArgs) Handles matchTimer.Tick
        ' when the two words match, the game board is 
        ' enabled and the timer is turned off


    End Sub

    Private Sub noMatchTimer_Tick(sender As Object, e As EventArgs) Handles noMatchTimer.Tick
        ' when the words do not match, the words are
        ' removed from the labels, the game board is
        ' enabled, and the timer is turned off


    End Sub
End Class
