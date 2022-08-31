Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub buttheadButton_Click(sender As Object, e As EventArgs) Handles buttheadButton.Click
        My.Computer.Audio.Play("butthead.wav")
    End Sub

    Private Sub greatscottButton_Click(sender As Object, e As EventArgs) Handles greatscottButton.Click
        My.Computer.Audio.Play("great_scott.wav")
    End Sub

    Private Sub heyButton_Click(sender As Object, e As EventArgs) Handles heyButton.Click
        My.Computer.Audio.Play("hey.wav")
    End Sub

    Private Sub treeButton_Click(sender As Object, e As EventArgs) Handles treeButton.Click
        My.Computer.Audio.Play("make_like_tree.wav")
    End Sub

    Private Sub chewyButton_Click(sender As Object, e As EventArgs) Handles chewyButton.Click
        My.Computer.Audio.Play("chewy.wav")
    End Sub

    Private Sub r2d2Button_Click(sender As Object, e As EventArgs) Handles r2d2Button.Click
        My.Computer.Audio.Play("r2-d2.wav")
    End Sub

    Private Sub kissButton_Click(sender As Object, e As EventArgs) Handles kissButton.Click
        My.Computer.Audio.Play("christmas_vacation_kiss.wav")
    End Sub

    Private Sub nogoodButton_Click(sender As Object, e As EventArgs) Handles nogoodButton.Click
        My.Computer.Audio.Play("christmas_vacation_no_good.wav")
    End Sub
End Class