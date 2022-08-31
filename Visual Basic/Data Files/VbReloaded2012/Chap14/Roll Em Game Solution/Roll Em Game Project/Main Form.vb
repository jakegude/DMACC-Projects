' Project name:         Roll Em Game Project
' Project purpose:      Simulates the Roll 'Em game
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub rollButton_Click(sender As Object, e As EventArgs) Handles rollButton.Click
        ' simulates the Roll 'Em game

        Dim randGen As New Random
        Dim random1 As Integer
        Dim random2 As Integer
        Static player As Integer = 1

        ' clear images and display message
        firstDiePictureBox.Image = Nothing
        secondDiePictureBox.Image = Nothing
        msgLabel.Text = "Player " &
            player.ToString & " rolled:"

        ' disable Roll 'Em button
        rollButton.Enabled = False

        ' refresh form and then delay execution
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        ' generate two random integers from 1 through 6
        random1 = randGen.Next(1, 7)
        random2 = randGen.Next(1, 7)

        ' display appropriate image in firstDiePictureBox
        Select Case random1
            Case 1
                firstDiePictureBox.Image = dot1PictureBox.Image
            Case 2
                firstDiePictureBox.Image = dot2PictureBox.Image
            Case 3
                firstDiePictureBox.Image = dot3PictureBox.Image
            Case 4
                firstDiePictureBox.Image = dot4PictureBox.Image
            Case 5
                firstDiePictureBox.Image = dot5PictureBox.Image
            Case Else
                firstDiePictureBox.Image = dot6PictureBox.Image
        End Select

        ' display appropriate image in secondDiePictureBox
        Select Case random2
            Case 1
                secondDiePictureBox.Image = dot1PictureBox.Image
            Case 2
                secondDiePictureBox.Image = dot2PictureBox.Image
            Case 3
                secondDiePictureBox.Image = dot3PictureBox.Image
            Case 4
                secondDiePictureBox.Image = dot4PictureBox.Image
            Case 5
                secondDiePictureBox.Image = dot5PictureBox.Image
            Case Else
                secondDiePictureBox.Image = dot6PictureBox.Image
        End Select

        ' check if there is a winner
        If random1 = random2 Then
            msgLabel.Text = "Congratulations, player " &
                player.ToString & "!"
            Dim count As Integer = 1
            Do While count <= 10
                msgLabel.Visible = Not msgLabel.Visible
                Me.Refresh()
                System.Threading.Thread.Sleep(100)
                count += 1
            Loop
        End If

        ' reset the current player
        If player = 1 Then
            player = 2
        Else
            player = 1
        End If

        ' enable Roll 'Em button
        rollButton.Enabled = True

    End Sub
End Class
