Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' add items to the animalListBox
        animalListBox.Items.Add("Dog")
        animalListBox.Items.Add("Cat")
        animalListBox.Items.Add("Horse")

        ' add items to the codeListBox
        Dim code As Integer = 100
        Do While code <= 105
            codeListBox.Items.Add(code.ToString)
            code += 1
        Loop

        ' select the default list box item
        animalListBox.SelectedIndex = 0
        codeListBox.SelectedItem = "100"
    End Sub

    Private Sub animalListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles animalListBox.SelectedValueChanged
        ' displays the animal's name

        Dim animal As String
        animal = Convert.ToString(animalListBox.SelectedItem)

        Select Case animal
            Case "Dog"
                animalLabel.Text = "Rover"
            Case "Cat"
                animalLabel.Text = "Fluffy"
            Case Else
                animalLabel.Text = "Poco"
        End Select
    End Sub

    Private Sub codeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles codeListBox.SelectedIndexChanged
        ' displays the department name

        Select Case codeListBox.SelectedIndex
            Case 0
                deptLabel.Text = "Personnel"
            Case 1
                deptLabel.Text = "Payroll"
            Case 2
                deptLabel.Text = "Budget"
            Case 3
                deptLabel.Text = "Inventory"
            Case 4
                deptLabel.Text = "Security"
            Case Else
                deptLabel.Text = "Accounting"
        End Select
    End Sub
End Class
