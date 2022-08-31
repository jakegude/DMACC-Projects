'Jake Gudenkauf
'Cook College
'calculates the gpa of students from their amount of credit hours and grades in classes
'12-8-2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub enterdataButton_Click(sender As Object, e As EventArgs) Handles enterdataButton.Click
        'calc

        'constants
        Const NumCreditHoursMessage As String = "Enter Number of Credit Hours:"
        Const LetterGradeMessage As String = "Enter Letter Grade:"
        Const HoursTitle As String = "Enter Number of Credit Hours:"
        Const GradeTitle As String = "Grades"

        'variables
        Dim inputNumCreditHours As String
        Dim inputLetterGrade As String
        Dim creditHours As Integer
        Dim numletterGrade As Integer
        Dim totalCreditHours As Integer
        Dim TotalGradesEntered As Integer
        Dim GPA As Integer

        'accumulate hours
        inputNumCreditHours = InputBox(NumCreditHoursMessage, HoursTitle)
        Do While inputNumCreditHours <> String.Empty
            Integer.TryParse(inputNumCreditHours, creditHours)
            totalCreditHours = totalCreditHours + creditHours
            inputNumCreditHours = InputBox(NumCreditHoursMessage, HoursTitle)
            inputLetterGrade = InputBox(LetterGradeMessage, GradeTitle)
            Integer.TryParse(inputLetterGrade, numletterGrade)
            TotalGradesEntered += 1
        Loop

        'accumulate grade
        Select Case inputLetterGrade.ToUpper
            Case "A"
                GPA = 4
            Case "B"
                GPA = 3
            Case "C"
                GPA = 2
            Case "D"
                GPA = 1
            Case "F"
                GPA = 0
        End Select

        'gpa
        GPA = totalCreditHours \ GPA


        'display
        hoursLabel.Text = totalCreditHours.ToString("N0")
        gpaLabel.Text = GPA.ToString("N2")
        numgradesLabel.Text = TotalGradesEntered.ToString("N0")

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits the program
        Me.Close()

    End Sub
End Class
