Public Class MainForm
    Public Property PrintForm1 As Object

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub everythingPictureBox_Click(sender As Object, e As EventArgs) Handles everythingPictureBox.Click
        My.Computer.Audio.Play("Everything-Begins-by-danosongs.com.wav")
    End Sub

    Private Sub invisiblePictureBox_Click(sender As Object, e As EventArgs) Handles invisiblePictureBox.Click
        My.Computer.Audio.Play("Invisible-Love-by-danosongs.com.wav")
    End Sub

    Private Sub magicPictureBox_Click(sender As Object, e As EventArgs) Handles magicPictureBox.Click
        My.Computer.Audio.Play("Magic-Ghost-by-danosongs.com.wav")
    End Sub

    Private Sub threePictureBox_Click(sender As Object, e As EventArgs) Handles threePictureBox.Click
        My.Computer.Audio.Play("Three-Drops-by-danosongs.com.wav")
    End Sub

    Private Sub unclaimedPictureBox_Click(sender As Object, e As EventArgs) Handles unclaimedPictureBox.Click
        My.Computer.Audio.Play("Unclaimed-Territory-by-danosongs.com.wav")
    End Sub

    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        colorDialog.Color = Me.BackColor
        colorDialog.ShowDialog()
        Me.BackColor = colorDialog.Color
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
