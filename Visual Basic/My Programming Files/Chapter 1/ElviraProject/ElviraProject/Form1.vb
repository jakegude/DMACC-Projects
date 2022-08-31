Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub helloButton_Click(sender As Object, e As EventArgs) Handles helloButton.Click
        outputLabel.Text = "Hola"
    End Sub
    Private Sub byeButton_Click(sender As Object, e As EventArgs) Handles byeButton.Click
        outputLabel.Text = "Adios"
    End Sub
    Private Sub loveButton_Click(sender As Object, e As EventArgs) Handles loveButton.Click
        outputLabel.Text = "Amor"
    End Sub
    Private Sub catButton_Click(sender As Object, e As EventArgs) Handles catButton.Click
        outputLabel.Text = "Gato"
    End Sub
    Private Sub dogButton_Click(sender As Object, e As EventArgs) Handles dogButton.Click
        outputLabel.Text = "Perro"
    End Sub
End Class
