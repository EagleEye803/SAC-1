Imports System.IO

Public Class Form1
    Dim path As String = "E:\repos\marks.csv"
    Dim peopleCounter As Integer = 0
    Dim currentEntry As String
    Dim nameList(0) As String
    Dim englishMarks(0)
    Dim mathsMarks(0)
    Dim peMarks(0)

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
                Dim listBoxEntry As String
                lstDisplay.Items.Clear()

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
                                listBoxEntry += cell
                            Case 2
                                If rowTicker = englishMarks.Length Then
                                    ReDim Preserve englishMarks(UBound(englishMarks) + 1)
                                    englishMarks(UBound(englishMarks)) = cell
                                Else
                                    englishMarks(rowTicker) = cell
                                End If
                                listBoxEntry += ": " & cell
                            Case 3
                                If rowTicker = mathsMarks.Length Then
                                    ReDim Preserve mathsMarks(UBound(mathsMarks) + 1)
                                    mathsMarks(UBound(mathsMarks)) = cell
                                Else
                                    mathsMarks(rowTicker) = cell
                                End If
                                listBoxEntry += ", " & cell
                            Case 4
                                If rowTicker = peMarks.Length Then
                                    ReDim Preserve peMarks(peMarks.Length)
                                    peMarks(UBound(englishMarks)) = cell
                                Else
                                    peMarks(rowTicker) = cell
                                End If
                                listBoxEntry += ", " & cell
                                lstDisplay.Items.Add(listBoxEntry)
                                listBoxEntry = ""
                        End Select
                    Next
                    cellTicker = 0
                    rowTicker += 1
                End While
                If rowTicker = 0 Then
                    lblPeople.Text = "There's no-one here yet!" & vbNewLine & "Add entries to the CSV to get started."
                Else
                    lblPeople.Text = "There are " & (rowTicker - 1) & " people in this class."
                End If
            End Using
        Catch ex As Exception
            Dim errorMessage = MsgBox("An error occurred while reading the CSV: " & ex.Message & vbNewLine & "Please try again.", vbCritical)
        End Try
    End Function

    'CLEAR SHEET FUNCTION
    Function clearCSV()
        Try
            My.Computer.FileSystem.WriteAllText(path, "NAME,ENGLISH,MATHS,PE", False)
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, vbCritical, "ERROR")
        End Try
        lstDisplay.Items.Clear()
        lblPeople.Text = "There's no-one here yet! Add entries to the CSV to get started."
        Array.Clear(nameList, 1, nameList.Length - 1)
        Array.Clear(englishMarks, 1, englishMarks.Length - 1)
        Array.Clear(mathsMarks, 1, mathsMarks.Length - 1)
        Array.Clear(peMarks, 1, peMarks.Length - 1)
        ReadCSV()
    End Function

    'WRITE TO CSV FUNCTION
    Function WriteToCSV(name, mark1, mark2, mark3)
        ReadCSV()
        'Add mark details to file
        currentEntry = vbNewLine & name & "," & mark1 & "," & mark2 & "," & mark3
        My.Computer.FileSystem.WriteAllText(path, currentEntry, True)
        ReadCSV()
    End Function

    'READ CSV ON FORM LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadCSV()
    End Sub

    'ADD GRADES BUTTON
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text
        'Check for Empty Field:
        If name = "" Then
            MsgBox("Please enter a NAME in the text box above.", vbCritical)
        Else
            Try
                Dim markEnglish = InputBox("Please enter " + name + "'s English mark: ")
                'Check for Numeric Values in Each Grade
                If IsNumeric(markEnglish) And markEnglish >= 0 And markEnglish <= 100 Then
                    Dim markMaths As Double = InputBox("Please enter " + name + "'s Maths mark: ")
                    If IsNumeric(markMaths) And markMaths >= 0 And markMaths <= 100 Then
                        Dim markPE As Double = InputBox("Please enter " + name + "'s PE mark: ")
                        If IsNumeric(markPE) And markPE >= 0 And markPE <= 100 Then
                            'Use WriteToCSV Function to Write Grades to CSV
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
            Catch ex As Exception
                MsgBox("AN ERROR OCCURRED: " & ex.Message & vbNewLine & "Please try again!")
            End Try
        End If
    End Sub

    'READ CSV BUTTON
    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim englishTotal As Double
        Dim mathsTotal As Double
        Dim peTotal As Double
        ReadCSV()

        'Calculate Totals
        For Each value In englishMarks
            If IsNumeric(value) Then
                englishTotal += value
            End If
        Next
        For Each value In mathsMarks
            If IsNumeric(value) Then
                mathsTotal += value
            End If
        Next
        For Each value In peMarks
            If IsNumeric(value) Then
                peTotal += value
            End If
        Next

        'Display Averages
        If String.IsNullOrEmpty(nameList(0)) Then
            MsgBox("You silly goose! Enter data into your CSV before you try to read it!", vbCritical, "ERROR")
        Else
            MsgBox("The average English mark was: " & (englishTotal / (englishMarks.Length - 1)))
            MsgBox("The average Maths mark was: " & (mathsTotal / (mathsMarks.Length - 1)))
            MsgBox("The average PE mark was: " & (peTotal / (peMarks.Length - 1)))
        End If
    End Sub

    'CLEAR CSV BUTTON
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim sure As MsgBoxResult = MsgBox($"Are you sure you want to clear the CSV?{vbNewLine}This will permanently erase all data!", vbYesNo)
        If sure = MsgBoxResult.Yes Then
            clearCSV()
            MsgBox("CSV cleared! Time for some fresh data!")
        Else
            MsgBox("Understandable. Have a nice day.")
        End If
    End Sub

    'INTERVIEW MODE BUTTON
    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    'SORT CSV BUTTON
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        ReadCSV()
        Dim tempSortArray(1)
        Dim rowTicker As Integer = 0
        For Each student In nameList
            If rowTicker > 0 Then
                ReDim Preserve tempSortArray(tempSortArray.Length)
            End If
            rowTicker += 1
            tempSortArray(rowTicker) = student
        Next
        rowTicker = 0
        For Each mark In englishMarks
            rowTicker += 1
            tempSortArray(rowTicker) += "," & mark
        Next
        rowTicker = 0
        For Each mark In mathsMarks
            rowTicker += 1
            tempSortArray(rowTicker) += "," & mark
        Next
        rowTicker = 0
        For Each mark In peMarks
            rowTicker += 1
            tempSortArray(rowTicker) += "," & mark
        Next
        Array.Sort(tempSortArray, 2, tempSortArray.Length - 2)
        My.Computer.FileSystem.WriteAllText(path, Join(tempSortArray, vbNewLine), False)
        ReadCSV()

    End Sub

    Private Sub btnRewards_Click(sender As Object, e As EventArgs) Handles btnRewards.Click
        Me.Hide()
        Rewards.Show()
    End Sub
End Class