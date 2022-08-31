' Project name:         Products Project
' Project purpose:      Search a list box for a product ID
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with IDs

        idListBox.Items.Add("FX123")
        idListBox.Items.Add("AB654")
        idListBox.Items.Add("JH733")
        idListBox.Items.Add("FX457")
        idListBox.Items.Add("NK111")
        idListBox.Items.Add("KYT897")
        idListBox.Items.Add("KVB419")
        idListBox.Items.Add("PQR333")
        idListBox.Items.Add("UVP492")
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        ' searches a list box for a specific ID

        Dim isFound As Boolean
        Dim index As Integer
        Dim numItems As Integer
        Dim id As String

        ' assign ID and number of list box 
        ' items to variables
        id = idTextBox.Text.ToUpper
        numItems = idListBox.Items.Count

        ' search the list box, stopping either after the 
        ' last item or when the item is found
        Do While index < numItems AndAlso isFound = False
            If id = idListBox.Items(index).ToString.ToUpper Then
                isFound = True
            Else
                index += 1
            End If
        Loop

        If isFound = True Then
            idListBox.SelectedIndex = index
        Else
            idListBox.SelectedIndex = -1
            MessageBox.Show("Not found", "Product Finder",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
