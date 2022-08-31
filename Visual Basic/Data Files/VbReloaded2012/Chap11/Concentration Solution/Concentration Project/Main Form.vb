' Project name:         Concentration Project
' Project purpose:      Simulates the Concentration game, 
'                       where a player tries to find 
'                       matching pairs of words
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private selectionCounter As Integer
    Private firstLabel As Label
    Private secondLabel As Label

    Private Sub ShuffleWords()
        ' shuffles the words in the wordListBox

        Dim randGen As New Random
        Dim index1 As Integer
        Dim index2 As Integer
        Dim temp As String

        For counter As Integer = 1 To 40
            ' generate two random numbers
            index1 = randGen.Next(0, 16)
            index2 = randGen.Next(0, 16)
            ' swap two words
            temp = wordListBox.Items(index1).ToString
            wordListBox.Items(index1) =
                wordListBox.Items(index2)
            wordListBox.Items(index2) = temp
        Next counter
    End Sub

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

        Call ShuffleWords()

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

        selectionCounter = 0
        Call ShuffleWords()

    End Sub

    Private Sub TestForMatch(sender As Object, e As EventArgs) Handles Label1.Click,
        Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click,
        Label8.Click, Label9.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click,
        Label14.Click, Label15.Click, Label16.Click
        ' displays the appropriate words and determines 
        ' whether the user selected a matching pair 

        Dim index1 As Integer
        Dim index2 As Integer

        ' update the selection counter
        selectionCounter += 1

        ' determine whether this is the first or second selection
        If selectionCounter = 1 Then
            firstLabel = TryCast(sender, Label)
            index1 = firstLabel.TabIndex
            firstLabel.Text = wordListBox.Items(index1).ToString
        Else    ' second label selected
            boardTableLayoutPanel.Enabled = False
            secondLabel = TryCast(sender, Label)
            index2 = secondLabel.TabIndex
            secondLabel.Text = wordListBox.Items(index2).ToString
            ' compare words in both labels
            If firstLabel.Text = secondLabel.Text Then
                firstLabel.Enabled = False
                secondLabel.Enabled = False
                matchTimer.Enabled = True
            Else
                noMatchTimer.Enabled = True
            End If

            ' reset the selection counter
            selectionCounter = 0

        End If
    End Sub

    Private Sub matchTimer_Tick(sender As Object, e As EventArgs) Handles matchTimer.Tick
        ' when the two words match, the game board is 
        ' enabled and the timer is turned off

        boardTableLayoutPanel.Enabled = True
        matchTimer.Enabled = False

    End Sub

    Private Sub noMatchTimer_Tick(sender As Object, e As EventArgs) Handles noMatchTimer.Tick
        ' when the words do not match, the words are
        ' removed from the labels, the game board is
        ' enabled, and the timer is turned off

        firstLabel.Text = String.Empty
        secondLabel.Text = String.Empty
        boardTableLayoutPanel.Enabled = True
        noMatchTimer.Enabled = False

    End Sub
End Class
