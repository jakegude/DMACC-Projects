' Project name:         Image Viewer Project
' Project purpose:      Example of using an image list control
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
        ' view images, one at a time

        Dim numImages As Integer = ImageList1.Images.Count

        For index As Integer = 0 To numImages - 1
            viewerPictureBox.Image =
                ImageList1.Images.Item(index)
            Me.Refresh()
            System.Threading.Thread.Sleep(1000)
        Next index
    End Sub
End Class
