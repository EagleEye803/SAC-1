Public Class Rewards

    Dim nameList(0) As String
    Dim englishMarks(0)
    Dim mathsmarks(0)
    Dim peMarks(0)
    Dim Subject As String
    Dim path As String = "E:\repos\marks.csv"

    'READ CSV FUNCTION
    Function ReadCSV()
        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)

                'Define the Necessary Variables:
                Dim cellTicker As Integer = 0
                Dim rowTicker As Integer = 0
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim row As String()

                'Loop Through Each Row:
                While Not MyReader.EndOfData
                    row = MyReader.ReadFields()
                    'Loop Through Each Cell:
                    For Each cell In row
                        cellTicker += 1
                        Select Case cellTicker
                            Case 1
                                If rowTicker = nameList.Length Then
                                        ReDim Preserve nameList(UBound(nameList) + 1)
                                    End If
                                    nameList(rowTicker) = cell
                            Case 2
                                If rowTicker = englishMarks.Length Then
                                    ReDim Preserve englishMarks(UBound(englishMarks) + 1)
                                    englishMarks(UBound(englishMarks)) = cell
                                Else
                                    englishMarks(rowTicker) = cell
                                    End If
                                Case 3
                                If rowTicker = mathsmarks.Length Then
                                    ReDim Preserve mathsmarks(UBound(mathsmarks) + 1)
                                    mathsmarks(UBound(mathsmarks)) = cell
                                Else
                                    mathsmarks(rowTicker) = cell
                                End If
                            Case 4
                                    If rowTicker = peMarks.Length Then
                                        ReDim Preserve peMarks(peMarks.Length)
                                        peMarks(UBound(englishMarks)) = cell
                                    Else
                                        peMarks(rowTicker) = cell
                                    End If
                            End Select
                        Next
                    cellTicker = 0
                    rowTicker += 1
                End While
                If rowTicker = 0 Then
                    MsgBox("There's no-one here yet!" & vbNewLine & "Add entries to the CSV to get started.")
                    Me.Hide()
                    Form1.Show()
                End If
            End Using
        Catch ex As Exception
            Dim errorMessage = MsgBox("An error occurred while reading the CSV: " & ex.Message & vbNewLine & "Please try again.", vbCritical)
        End Try
    End Function

    Function findHighest(subjectArray)
        Dim highestMark As Integer = 0
        Dim index = 0
        Dim rowCounter As Integer = 0
        Dim Tie = False

        For Each mark In subjectArray
            If rowCounter > 0 Then
                If highestMark = 0 Then
                    highestMark = Convert.ToInt32(mark)
                    index = rowCounter
                ElseIf mark > highestMark Then
                    highestMark = Convert.ToInt32(mark)
                    index = rowCounter
                ElseIf mark = highestMark Then
                    Tie = True
                    index = rowCounter
                End If
            End If
            rowCounter += 1
        Next
        If Tie = True Then
            MsgBox("Uh oh! There's a tie Let's fetch those smart students for you...")
            Dim tiedStudents As String
            index = 0
            For Each mark In subjectArray
                If index > 0 Then
                    If mark = highestMark Then
                        If String.IsNullOrEmpty(tiedStudents) Then
                            tiedStudents = nameList(index)
                        Else
                            tiedStudents += $", {nameList(index)}"
                        End If
                    End If
                End If
                index += 1
            Next
            MsgBox($"The students that tied are: {vbNewLine}{tiedStudents}, with a shared score of {highestMark}!")
        Else
            MsgBox($"The highest-scoring student in class {Subject} is {nameList(index)}, with a score of {highestMark}!")
        End If
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadCSV()
    End Sub

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        Subject = "English"
        findHighest(englishMarks)
    End Sub

    Private Sub btnMath_Click(sender As Object, e As EventArgs) Handles btnMath.Click
        Subject = "Maths"
        findHighest(mathsmarks)
    End Sub

    Private Sub btnPE_Click(sender As Object, e As EventArgs) Handles btnPE.Click
        Subject = "PE"
        findHighest(peMarks)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class