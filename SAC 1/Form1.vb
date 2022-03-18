Public Class Form1
    Dim peopleCounter As Integer
    Dim entry As String = ""
    Dim currentEntry As String

    'CLEAR SHEET FUNCTION
    Function clearCSV()
        My.Computer.FileSystem.WriteAllText("E:\repos\marks.csv", "", False)
    End Function

    'WRITE TO CSV FUNCTION
    Function WriteToCSV(name, mark1, mark2, mark3)
        'IF Entry is empty, add headers
        If entry = "" Then
            My.Computer.FileSystem.WriteAllText("E:\repos\marks.csv", ",English,Maths,PE", True)
        End If
        'Add mark details to file
        entry += vbNewLine & name & "," & mark1 & "," & mark2 & "," & mark3
        currentEntry = vbNewLine & name & "," & mark1 & "," & mark2 & "," & mark3
        My.Computer.FileSystem.WriteAllText("E:\repos\marks.csv", currentEntry, True)
    End Function

    'CLEARS SHEET ON OPEN
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPeople.Text = "The number of people in this class is: 0"
        clearCSV()
    End Sub

    'ADD GRADES
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text
        'CHECK FOR EMPTY FIELD:
        If name = "" Then
            MsgBox("Please enter a NAME in the text box above.", vbCritical)
        Else
            Dim markEnglish = InputBox("Please enter " + name + "'s English mark: ")
            'CHECK FOR NUMERIC VALUES IN EACH GRADE
            If IsNumeric(markEnglish) And 0 <= markEnglish <= 100 Then
                Dim markMaths As Double = InputBox("Please enter " + name + "'s Maths mark: ")
                If IsNumeric(markMaths) And 0 <= markMaths <= 100 Then
                    Dim markPE As Double = InputBox("Please enter " + name + "'s PE mark: ")
                    If IsNumeric(markPE) And 0 <= markPE <= 100 Then
                        'USES FUNCTION TO WRITE NAME and MARKS to CSV
                        WriteToCSV(name, markEnglish, markMaths, markPE)
                    Else
                        MsgBox("Please enter the PE MARK as a POSITIVE NUMBER 100 or less.", vbCritical)
                    End If
                Else
                    MsgBox("Please enter the MATHS MARK as a POSITIVE NUMBER 100 or less.", vbCritical)
                End If
            Else
                MsgBox("Please enter the ENGLISH MARK as a POSITIVE NUMBER 100 or less.", vbCritical)
            End If
        End If

    End Sub

    'READ CSV BUTTON - !!!SAC 2 CODE HERE!!!
    Private Sub btnPseudo_Click(sender As Object, e As EventArgs) Handles btnPseudo.Click
        'Change file location to "E:\repos\marks.csv" to read the program's file.
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("E:\repos\marks.csv")

            'DEFININE THE NECESSARY VARIABLES:
            Dim cellTicker As Integer = 0
            Dim rowTicker As Integer = 0
            Dim englishMarks(0) As Integer
            Dim mathsMarks(0) As Integer
            Dim peMarks(0) As Integer
            Dim englishTotal As Double
            Dim mathsTotal As Double
            Dim peTotal As Double
            peopleCounter = 0
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim row As String()

            'LOOP THROUGH EACH ROW
            While Not MyReader.EndOfData
                row = MyReader.ReadFields()
                'LOOP THROUGH EACH CELL
                If rowTicker > 0 Then
                    For Each cell In row
                        cellTicker += 1
                        Select Case cellTicker
                            Case 2
                                ReDim Preserve englishMarks(UBound(englishMarks) + 1)
                                englishMarks(UBound(englishMarks)) = cell
                                englishTotal += cell
                            Case 3
                                ReDim Preserve mathsMarks(UBound(mathsMarks) + 1)
                                mathsMarks(UBound(englishMarks)) = cell
                                mathsTotal += cell
                            Case 4
                                ReDim Preserve peMarks(UBound(peMarks) + 1)
                                peMarks(UBound(englishMarks)) = cell
                                peTotal += cell
                        End Select
                    Next
                    cellTicker = 0
                    peopleCounter += 1
                End If
                rowTicker += 1
            End While

            'DISPLAY AVERAGES
            MsgBox("The average English mark was: " & (englishTotal / (englishMarks.Length - 1)))
            MsgBox("The average Maths mark was: " & (mathsTotal / (mathsMarks.Length - 1)))
            MsgBox("The average PE mark was: " & (peTotal / (peMarks.Length - 1)))

            'DISPLAY NUMBER OF STUDENTS
            peopleCounter -= 1
            lblPeople.Text = "The number of people in this class is: " + peopleCounter.ToString()
        End Using
    End Sub

    'CLEAR CSV BUTTON
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearCSV()
        MsgBox("CSV cleared!")
        entry = ""
        lblPeople.Text = "The number of people in this class is: 0"
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class