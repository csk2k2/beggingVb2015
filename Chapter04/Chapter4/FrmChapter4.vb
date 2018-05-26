Public Class FrmChapter4
    Private Sub btnIf_Click(sender As Object, e As EventArgs) Handles btnIf.Click
        'Declare and set a variable
        Dim intNumber As Integer = 27

        'Here's where you make a decision and tell the user what happened
        If intNumber = 27 Then
            MessageBox.Show("intNumber is indeed 27!")
        End If
    End Sub

    Private Sub btnIf2_Click(sender As Object, e As EventArgs) Handles btnIf2.Click
        'Declare and set a variable
        Dim intNumber As Integer = 27

        'Here's where you make a decision and tell the user what happened
        If intNumber = 10 Then
            MessageBox.Show("intNumber is indeed 10!")
        Else
            MessageBox.Show("intNumber is not 10!")
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Declare a variable and get the name from the textbox
        Dim strName = txtName.Text

        'Is the name Wendy?
        If strName <> "Wendy" Then
            MessageBox.Show("The name is not Wendy.")
        End If
    End Sub

    Private Sub btnCheckNumbers_Click(sender As Object, e As EventArgs) Handles btnCheckNumbers.Click
        'Declare variable
        Dim intNumber As Integer

        'Exception
        Try
            'Get the Number from the textbox
            intNumber = CType(txtValue.Text, Integer)
        Catch ex As Exception
            Exit Sub
        End Try

        'Is intNumber less than 27 or equal to 27?
        If intNumber <= 27 Then
            MessageBox.Show("Is 'intNumber' less than 27 or equal to 27? Yes!")
        Else
            MessageBox.Show("Is 'intNumber' less than 27 or equal to 27? No!")
        End If
    End Sub

    Private Sub btnOrCheck_Click(sender As Object, e As EventArgs) Handles btnOrCheck.Click
        'Declare variables
        Dim strName1, strName2 As String

        'Get the name
        strName1 = txtName.Text
        strName2 = txtValue.Text

        'Is one of the names Wendy?
        If strName1 = "Wendy" Or strName2 = "Wendy" Then
            MessageBox.Show("One of the names is Wendy.")
        Else
            MessageBox.Show("Neither of the names is Wendy.")
        End If
    End Sub

    Private Sub btnAndCheck_Click(sender As Object, e As EventArgs) Handles btnAndCheck.Click
        'Declare variables
        Dim strName1, strName2 As String

        'Get the name
        strName1 = txtName.Text
        strName2 = txtValue.Text

        'Are both the names Wendy?
        If strName1 = "Wendy" And strName2 = "Wendy" Then
            MessageBox.Show("Both names are Wendy.")
        ElseIf strName1 = "Wendy" Or strName2 = "Wendy" Then
            MessageBox.Show("One of the names is Wendy.")
        Else
            MessageBox.Show("Neither of the names is Wendy.")
        End If
    End Sub

    Private Sub btnStringCompare_Click(sender As Object, e As EventArgs) Handles btnStringCompare.Click
        'Declare variables
        Dim strName1, strName2 As String

        'Get the name
        strName1 = txtName.Text
        strName2 = txtValue.Text

        'Compare the names
        If String.Compare(strName1, strName2, True) = 0 Then
            MessageBox.Show("Hello," & strName1)
        Else
            MessageBox.Show("Sorry,you are not " & strName1)
        End If
    End Sub

    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        'Declare variables
        Dim strName As String
        Dim strFavoriteColor As String = vbNullString

        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex).ToString

        'Use a Select Case statement to get the favorite color of the selected person
        Select Case strName.ToLower
            Case "bryan"
                strFavoriteColor = "Madras Yellow"
            Case "ashley"
                strFavoriteColor = "Sea Blue"
            Case "jennifer"
                strFavoriteColor = "Morning Mist"
            Case "eddie"
                strFavoriteColor = "Passionate Purple"
            Case "katelyn"
                strFavoriteColor = "Blood Red"
        End Select
        'Display the favorite color of the selected person
        If strFavoriteColor IsNot vbNullString Then
            MessageBox.Show(text:=strName & "'s favorite color is " & strFavoriteColor)
        End If

        'Use a Select Case statement to display a person's gender
        Select Case strName.ToLower
            Case "bryan", "eddie", "ashley"
                MessageBox.Show("This person's gender is male.")
            Case "jennifer", "katelyn"
                MessageBox.Show("This person's gender is female.")
            Case Else
                MessageBox.Show("I don't know this person's gender.")
        End Select
    End Sub

    Private Sub btnForNextLoop_Click(sender As Object, e As EventArgs) Handles btnForNextLoop.Click
        'Declare variable
        Dim intCount As Integer

        'Clear the list
        ClearList()

        'Perform a loop
        For intCount = 1 To 5
            'Add the item to the list
            lstData.Items.Add("I'm item " & intCount.ToString & " in the list!")
        Next
    End Sub

    Private Sub ClearList()
        'Clear the list
        lstData.Items.Clear()
    End Sub

    Private Sub btnForNextLoopWithStep_Click(sender As Object, e As EventArgs) Handles btnForNextLoopWithStep.Click
        'Clear the list
        ClearList()
        'Perform a loop
        For intCount As Integer = 4 To 62 Step 7
            'Add the item to the list
            lstData.Items.Add("I'm item " & intCount.ToString & " in the list!")
        Next

    End Sub

    Private Sub btnBackwardsForNextLoop_Click(sender As Object, e As EventArgs) Handles btnBackwardsForNextLoop.Click
        'Clear the list
        ClearList()

        'Perform a loop
        For intCount As Integer = 10 To 1 Step -1
            'Add the item to the list
            lstData.Items.Add("I'm item " & intCount.ToString & " in the list!")
        Next
    End Sub

    Private Sub btnForEachLoop_Click(sender As Object, e As EventArgs) Handles btnForEachLoop.Click
        'Clear the list
        ClearList()

        'List each folder at the root of your C drive
        For Each strFolder As String In My.Computer.FileSystem.GetDirectories("C:\")
            'Add the item to the list
            lstData.Items.Add(strFolder)
        Next
    End Sub

    Private Sub btnDoUntilLoop_Click(sender As Object, e As EventArgs) Handles btnDoUntilLoop.Click
        'Declare variables
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0

        'Clear the list
        ClearList()

        'Process the loop until intRandomNumber = 10
        Do Until intRandomNumber = 10
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)
            'Add the number to the list
            lstData.Items.Add(intRandomNumber.ToString)
        Loop
    End Sub

    Private Sub btnDoWhileLoop_Click(sender As Object, e As EventArgs) Handles btnDoWhileLoop.Click
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0

        'Clear the list 
        ClearList()

        'Process the loop while  intRandomNumber < 15
        Do While intRandomNumber < 15
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)
            'Add the number to the list
            lstData.Items.Add(intRandomNumber)
        Loop
    End Sub

    Private Sub btnNestedLoops_Click(sender As Object, e As EventArgs) Handles btnNestedLoops.Click
        'Clear the List
        ClearList()

        'Process an outer loop
        For intOuterLoop As Integer = 1 To 2
            'Process a nested(inner) loop
            For intInnerLoop As Integer = 1 To 3
                lstData.Items.Add(intOuterLoop.ToString & "." & intInnerLoop.ToString)
            Next
        Next
    End Sub

    Private Sub btnQuittingAForLoop_Click(sender As Object, e As EventArgs) Handles btnQuittingAForLoop.Click
        'Clear the list
        ClearList()

        'List each folder at the root of your C drive
        For Each strFolder As String In My.Computer.FileSystem.GetDirectories("C:\")
            'Add the item to the list
            lstData.Items.Add(strFolder)

            'Do you have the folder C:\Program Files?
            If String.Compare(strFolder, "c:\program files", True) = 0 Then
                'Tell the user
                MessageBox.Show("Found it, exiting the loop now.")

                'Quit the loop early
                Exit For
            End If
        Next
    End Sub

    Private Sub btnQuittingADoLoop_Click(sender As Object, e As EventArgs) Handles btnQuittingADoLoop.Click
        'Declare variable
        Dim intCount As Integer = 0

        'Clear the list
        ClearList()

        'Process the loop
        Do While intCount < 10
            'Add the item to list
            lstData.Items.Add(intCount.ToString)

            'Increment the count by 1
            intCount += 1

            'Should you quit the Loop
            If intCount = 3 Then
                Exit Do
            End If
        Loop
    End Sub
End Class
