Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click

        Dim button As DialogResult
        msgLabel.Text = String.Empty

        button = MessageBox.Show("Delete this record?", "Payroll",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2)

        If button = Windows.Forms.DialogResult.Yes Then
            msgLabel.Text = "Record deleted"
        End If
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click

        If MessageBox.Show("Play another game?", "Math Monster",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            msgLabel.Text = "New game"
        Else
            msgLabel.Text = "Game closed"
        End If
    End Sub
End Class
