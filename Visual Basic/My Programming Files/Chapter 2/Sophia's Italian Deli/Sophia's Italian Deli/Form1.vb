Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        AboutBox1.ShowDialog()
    End Sub
End Class