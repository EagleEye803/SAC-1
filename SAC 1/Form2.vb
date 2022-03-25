Public Class Form2
    'DEFINE PUBLIC VARIABLES:
    Dim nameList(0) As String
    Dim englishMarks(0)
    Dim mathsMarks(0)
    Dim peMarks(0)
    'Change file location to "E:\repos\marks.csv" to read the program's file.
    Dim path As String = "E:\repos\marks.csv"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProcess.Text = "Loading File..."
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)
            'DEFINE THE NECESSARY VARIABLES:
            Dim cellTicker As Integer = 0
            Dim rowTicker As Integer = 0
            Dim listBoxEntry As String
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
                            Case 1
                                ReDim Preserve nameList(UBound(nameList) + 1)
                                nameList(UBound(nameList)) = cell
                                listBoxEntry += cell
                            Case 2
                                ReDim Preserve englishMarks(UBound(englishMarks) + 1)
                                englishMarks(UBound(englishMarks)) = cell
                                listBoxEntry += ": " & cell
                            Case 3
                                ReDim Preserve mathsMarks(UBound(mathsMarks) + 1)
                                mathsMarks(UBound(englishMarks)) = cell
                                listBoxEntry += ", " & cell
                            Case 4
                                ReDim Preserve peMarks(UBound(peMarks) + 1)
                                peMarks(UBound(englishMarks)) = cell
                                listBoxEntry += ", " & cell
                                lstDisplay.Items.Add(listBoxEntry)
                                listBoxEntry = ""
                        End Select
                    Next
                    cellTicker = 0
                End If
                rowTicker += 1
            End While
        End Using
        lblProcess.Text = "CSV File Loaded Into Array"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim nameToSearch = InputBox("Let's Find Your Entry." & vbNewLine & "Enter Student Name: ")
        Dim locator As Integer = 0
        Dim found As Boolean = False
        For Each student In nameList
            lblProcess.Text = "Searching..."
            locator += 1
            If student = nameToSearch Then
                lblProcess.Text = "Student " & nameToSearch & " Found!"
                Dim location As Integer = locator - 1
                lblProcess.Text = nameToSearch & "'s marks are:" & vbNewLine & "English: " & englishMarks(location) & vbNewLine & "Math: " & mathsMarks(location) & vbNewLine & "PE: " & peMarks(location)
                found = True
                Exit For
            End If
        Next
        If found = False Then
            lblProcess.Text = "Student not found :(" & vbNewLine & "Try again!"
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class