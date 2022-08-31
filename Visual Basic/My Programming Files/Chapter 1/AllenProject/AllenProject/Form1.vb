Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub primaryButton_Click(sender As Object, e As EventArgs) Handles primaryButton.Click
        principalLabel.Text = "Homer Simpson"
        phoneLabel.Text = "515-555-4444"
    End Sub
    Private Sub middleButton_Click(sender As Object, e As EventArgs) Handles middleButton.Click
        principalLabel.Text = "Bob Simpson"
        phoneLabel.Text = "515-555-6667"
    End Sub
    Private Sub jrButton_Click(sender As Object, e As EventArgs) Handles jrButton.Click
        principalLabel.Text = "Jake Simpson"
        phoneLabel.Text = "515-555-7778"
    End Sub
    Private Sub highButton_Click(sender As Object, e As EventArgs) Handles highButton.Click
        principalLabel.Text = "Peter Simpson"
        phoneLabel.Text = "515-555-8889"
    End Sub
End Class
