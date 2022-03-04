Public Class Form1
    Dim peopleCounter As Integer
    Dim entry As String = ""
    Dim currentEntry As String

    Function clearCSV()
        My.Computer.FileSystem.WriteAllText("E:\repos\marks.csv", "", False)
    End Function

    Function WriteToCSV(name, mark1, mark2, mark3)
        If entry = "" Then
            My.Computer.FileSystem.WriteAllText("E:\repos\marks.csv", ",English,Maths,PE", True)
        End If
        entry += vbNewLine + name + "," + mark1 + "," + mark2 + "," + mark3
        currentEntry = vbNewLine + name + "," + mark1 + "," + mark2 + "," + mark3
        My.Computer.FileSystem.WriteAllText("E:\repos\marks.csv", currentEntry, True)
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name = txtName.Text
        If name = "" Then
            MsgBox("Please enter a NAME in the text box above.", vbCritical)
        Else
            Dim markEnglish = InputBox("Please enter " + name + "'s English mark: ")
            If IsNumeric(markEnglish) Then
                Dim markMaths = InputBox("Please enter " + name + "'s Maths mark: ")
                If IsNumeric(markMaths) Then
                    Dim markPE = InputBox("Please enter " + name + "'s PE mark: ")
                    If IsNumeric(markPE) Then
                        WriteToCSV(name, markEnglish, markMaths, markPE)
                    Else
                        MsgBox("Please enter the PE MARK as a NUMBER.", vbCritical)
                    End If
                Else
                    MsgBox("Please enter the MATHS MARK as a NUMBER.", vbCritical)
                End If
            Else
                MsgBox("Please enter the ENGLISH MARK as a NUMBER.", vbCritical)
            End If
        End If

    End Sub

    Private Sub btnPseudo_Click(sender As Object, e As EventArgs) Handles btnPseudo.Click
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("E:\repos\marks.csv")
            Dim ticker As Integer = 0
            Dim englishMarks As String = "ENGLISH MARKS: "
            Dim mathsMarks As String = "MATH MARKS: "
            Dim peMarks As String = "STUDENTS: "
            Dim nameList As String = ""
            peopleCounter = 0

            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim row As String()
            While Not MyReader.EndOfData
                row = MyReader.ReadFields()
                peopleCounter += 1
                For Each cell In row
                    ticker += 1
                    Select Case ticker
                        Case 1
                            nameList += cell + ", "
                        Case 2
                            englishMarks += cell + ", "
                        Case 3
                            mathsMarks += cell + ", "
                        Case 4
                            peMarks += cell + ", "
                    End Select
                Next
            End While

            peopleCounter -= 1
            lblPeople.Text = "The number of people in this class is: " + peopleCounter.ToString()
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearCSV()
        MsgBox("CSV cleared!")
        entry = ""
        lblPeople.Text = "The number of people in this class is: 0"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPeople.Text = "The number of people in this class is: 0"
    End Sub
End Class
