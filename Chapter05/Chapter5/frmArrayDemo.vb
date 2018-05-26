Public Class frmArrayDemo
    'Declare a form level array
    Private strFriends() As String
    Private Sub ClearList()
        'Clear the list
        lstFriends.Items.Clear()
    End Sub

    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles btnArrayElement.Click
        ClearList()

        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"

        'Add the first array item to the list
        lstFriends.Items.Add(strFriends(2))
    End Sub

    Private Sub ArrayDemo_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Populate the array
        strFriends = {"Wendy", "Harriet", "Jay", "Michelle", "Richard"}
        'strFriends(1) = "Harriet"
        'strFriends(2) = "Jay"
        'strFriends(3) = "Michelle"
        'strFriends(4) = "Richard"
    End Sub

    Private Sub btnEnumerateArray_Click(sender As Object, e As EventArgs) Handles btnEnumerateArray.Click
        'Clear the list 
        ClearList()

        'Enumerate the array
        For Each strName As String In strFriends
            'Add the array item to the list
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnArraysAsParameters_Click(sender As Object, e As EventArgs) Handles btnArraysAsParameters.Click
        'Clear the list
        ClearList()

        'List your friends
        AddItemsToList(strFriends)
    End Sub

    Private Sub AddItemsToList(ByVal arrayList As String())
        'Enumerate the array
        For Each strName As String In arrayList
            'Add the array item to the list
            lstFriends.Items.Add("[" & strName & "]")
        Next
    End Sub

    Private Sub btnMoreArrayParameters_Click(sender As Object, e As EventArgs) Handles btnMoreArrayParameters.Click
        'Clear the list
        ClearList()

        'Declare an Array
        Dim strMoreFriends(1) As String

        'Populate the array
        strMoreFriends(0) = "Elaine"
        strMoreFriends(1) = "Debra"

        'List your friends
        AddItemsToList(strFriends)
        AddItemsToList(strMoreFriends)
    End Sub

    Private Sub btnSortArrays_Click(sender As Object, e As EventArgs) Handles btnSortArrays.Click
        'Clear the list
        ClearList()

        'Declare  Arrays
        Dim strMoreFriends As String() = {"Elaine", "Debra"}
        Dim length1 = strFriends.Count()
        Dim length2 = strMoreFriends.Length
        'MessageBox.Show(length1.ToString, "Count")
        'MessageBox.Show(length2.ToString, "Length")

        Dim strResults(length1 + length2 - 1) As String
        For i = 0 To length1 - 1
            strResults(i) = strFriends(i)
        Next

        For i = length1 To length1 + length2 - 1
            strResults(i) = strMoreFriends(i - length1)
        Next

        'Sort the arrays
        Array.Sort(strResults)

        'List your friends
        AddItemsToList(strResults)

    End Sub

    Private Sub btnConcat_Click(sender As Object, e As EventArgs) Handles btnConcat.Click
        'Clear the list
        ClearList()

        'Declare  Arrays
        Dim strMoreFriends As String() = {"Elaine", "Debra"}
        'GetUpperBound(d),d is the dimension num of Array
        'Dim length1 = strFriends.GetUpperBound(0)
        Dim u = UBound(strFriends)
        Dim l = strMoreFriends.Length

        'combine the arrays use the ReDim statement. Preserve 保留现有数据
        Dim strResult = strFriends
        ReDim Preserve strResult(u + l)
        For i = u + 1 To u + l
            strResult(i) = strMoreFriends(i - u - 1)
        Next

        'Sort the arrays
        Array.Sort(strResult)

        'List your friends
        AddItemsToList(strResult)

    End Sub

    Private Sub btnConcat2_Click(sender As Object, e As EventArgs) Handles btnConcat2.Click
        'Clear the list
        ClearList()

        'Declare  Arrays
        Dim strMoreFriends As String() = {"Elaine", "Debra"}
        'GetUpperBound(d),d is the dimension num of Array
        'Dim length1 = strFriends.GetUpperBound(0)
        Dim l1 = strFriends.Length
        Dim l2 = strMoreFriends.Length

        'combine the arrays use the ReDim statement. Preserve 保留现有数据
        Dim strResult = strFriends
        ReDim Preserve strResult(l1 + l2 - 1)
        For i = l1 To l1 + l2 - 1
            strResult(i) = strMoreFriends(i - l1)
        Next

        'Sort the arrays
        Array.Sort(strResult)

        'List your friends
        AddItemsToList(strResult)

    End Sub

    Private Sub btnReversingAnArray_Click(sender As Object, e As EventArgs) Handles btnReversingAnArray.Click
        'Clear the list
        ClearList()

        'Reverse the Order-elements will be in descending order
        Array.Reverse(strFriends)

        'List your friends
        AddItemsToList(strFriends)
    End Sub

    Private Sub btnInitializingArraysWithValues_Click(sender As Object, e As EventArgs) Handles btnInitializingArraysWithValues.Click
        'Clear the list
        ClearList()

        'Declare and Initializing With values
        Dim strMyFriends() As String = {"c", "e", "a", "b", "d"}

        'Make the strMyFriends array larger
        ReDim Preserve strMyFriends(6)
        strMyFriends(5) = "six"
        strMyFriends(6) = "seven"

        'Sort the array
        Array.Sort(strMyFriends)
        'List strMyFriends
        AddItemsToList(strMyFriends)

    End Sub
End Class
