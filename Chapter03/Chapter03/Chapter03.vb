Public Class FmMain
    Private Sub btnFloatMath_Click(sender As Object, e As EventArgs) Handles btnFloatMath.Click
        'Declare variable
        Dim dblNumber As Single

        'Set Number, multiply number, and display results
        dblNumber = 0.477
        dblNumber *= 209
        MessageBox.Show("Float Multiplication test:0.477*209 = " & dblNumber.ToString, "Float Test")

        'Set number, divide number, and display results
        dblNumber = 1212121212
        dblNumber /= 7
        MessageBox.Show("Float division test: =" & dblNumber.ToString, "Float Test")

        'Display the results with formatting
        MessageBox.Show("Division test with formatting:" & String.Format("{0:n3}", dblNumber), "test")
    End Sub

    Private Sub btnStrings_Click(sender As Object, e As EventArgs) Handles btnStrings.Click
        'Declare Variablle
        Dim strResults As String

        'Set the string value
        strResults = "Hello World"

        'Display results
        MessageBox.Show(strResults, "Strings")
    End Sub

    Private Sub btnConcatenation_Click(sender As Object, e As EventArgs) Handles btnConcatenation.Click
        'Declare Variables
        Dim strResults As String
        Dim str1, str2 As String

        'Set the string values
        str1 = "Hi,"
        str2 = "World!"

        'Concatenate the strings
        strResults = str1 & str2

        'Display the results
        MessageBox.Show(strResults, "Strings2")
    End Sub

    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        'Declare variables
        Dim strResults As String

        'get the text from textbox
        strResults = txtString.Text

        'Display results
        MessageBox.Show("The length of text is" & strResults.Length.ToString, "test")
    End Sub

    Private Sub btnSubStrings_Click(sender As Object, e As EventArgs) Handles btnSubStrings.Click
        'Declare variables
        Dim strResults As String

        'Get the text from the TextBox
        strResults = txtString.Text

        'Display the first three characters
        MessageBox.Show(strResults.Substring(0, 3), "Strings")

        'Display the middle three characters
        MessageBox.Show(strResults.Substring(3, 3), "Strings")

        'Display the last three characters
        MessageBox.Show(strResults.Substring(strResults.Length - 3), "Strings")
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        'Declare variables
        Dim strData, strResults As String

        'Get the text from the TextBox
        strData = txtString.Text

        'Replace the string occurrence
        strResults = strData.Replace("Hello", "Goodbye")

        'Display the new string
        MessageBox.Show(strResults, "result")
    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'Declare variable
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        'Display the results
        MessageBox.Show(dteResults.ToString, "Date Demo")

        'Display dates
        MessageBox.Show(dteResults.ToLongDateString, "Date Demo")
        MessageBox.Show(dteResults.ToShortDateString, "date demo")

        'Display times
        MessageBox.Show(dteResults.ToLongTimeString, "Date Demo")
        MessageBox.Show(dteResults.ToShortTimeString, "Date Demo")

    End Sub

    Private Sub btnDateProperties_Click(sender As Object, e As EventArgs) Handles btnDateProperties.Click
        'Declare variables
        Dim cap = "Date Demo"
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        'Display the various date properties
        MessageBox.Show("Month: " & dteResults.Month, cap)
        MessageBox.Show("Day: " & dteResults.Day, cap)
        MessageBox.Show("Year: " & dteResults.Year, cap)
        MessageBox.Show("Hour: " & dteResults.Hour, cap)
        MessageBox.Show("Minute: " & dteResults.Minute, cap)
        MessageBox.Show("Second: " & dteResults.Second, cap)
        MessageBox.Show("Day of week: " & dteResults.DayOfWeek, cap)
        MessageBox.Show("Day of year: " & dteResults.DayOfYear, cap)
    End Sub

    Private Sub btnDateNames_Click(sender As Object, e As EventArgs) Handles btnDateNames.Click
        'Declare variables
        Dim cap = "Date Demo"
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        'Display the date names
        MessageBox.Show("Weekday name: " & dteResults.ToString("dddd"), cap)
        MessageBox.Show("Month name: " & dteResults.ToString("MMMM"), cap)
        MessageBox.Show("Weekday name: " & WeekdayName(dteResults.DayOfWeek), cap)
        MessageBox.Show("Month name: " & MonthName(dteResults.Month), cap)
    End Sub

    Private Sub btnDateLiterals_Click(sender As Object, e As EventArgs) Handles btnDateLiterals.Click
        'Declare variables
        Dim cap = "Date Demo"
        Dim dteResults As Date

        'Set a date and time
        dteResults = #2017/11/11 21:50:00#

        'Display the date and time
        MessageBox.Show(dteResults.ToLongDateString & " " & dteResults.ToLongTimeString, cap)

        'Set a date and time
        dteResults = #3/27/2016 21:50:00#

        'Display the date and time
        MessageBox.Show(dteResults.ToLongDateString & " " & dteResults.ToLongTimeString, cap)
    End Sub

    Private Sub btnDateManipulation_Click(sender As Object, e As EventArgs) Handles btnDateManipulation.Click
        'Declare variables
        Dim cap = "Date Demo"
        Dim dteStartDate As Date
        Dim dteChangedDate As Date

        'Start in the year 2400
        dteStartDate = #2/28/2400#

        'Add a day and display the results
        dteChangedDate = dteStartDate.AddDays(1)
        MessageBox.Show(dteChangedDate.ToLongDateString, cap)

        'Add some months and display the results
        dteChangedDate = dteStartDate.AddMonths(6)
        MessageBox.Show(dteChangedDate.ToLongDateString, cap)

        'Subtract a year and display the result
        dteChangedDate = dteStartDate.AddYears(-1)
        MessageBox.Show(dteChangedDate.ToLongDateString, cap)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Define a variable for intNumber
        Dim intNumber As Integer
        Dim cap = "Variables"

        'Set the initial value
        intNumber = 27

        'Add 1 to the value of intNumber
        intNumber += 1

        'Display the new value of intNumber
        MessageBox.Show("intNumber + 1 = " & intNumber.ToString, cap)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim dblArea As Double

        'Calculate the area of a circle with a radius of 100
        dblArea = CalculateAreaFromRadius(100)

        'Display result
        MessageBox.Show(dblArea.ToString, "Area of 100")
    End Sub

    Private Sub SayHello()
        'Display a message box
        MessageBox.Show("Hello World", "Three Buttons")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Call your menthod
        SayHello()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Call your menthod
        SayHello()
    End Sub

    'CalculateAreaFromRadius-find the area of a circle
    Private Function CalculateAreaFromRadius(ByVal radius As Double) As Double
        'Declare variables
        Dim dblRadiusSquared As Double
        Dim dblResult As Double

        'Square the radius
        dblRadiusSquared = radius * radius

        'Multiply it by pi
        dblResult = dblRadiusSquared * Math.PI

        'Return the result
        Return dblResult
    End Function

    Private Sub DisplaySebastiansName()
        'Declare variable and set value
        Dim strName As String
        strName = "Sebastian Blackwood"

        'Display result
        MessageBox.Show(strName, "Scope Demo")
    End Sub

    Private Sub DisplayBalthazarsName()
        'Declare variable and set value
        Dim strName As String
        strName = "Balthazar Keech"

        'Display result
        MessageBox.Show(strName, "Scope Demo")
    End Sub

    Private Sub btnScope_Click(sender As Object, e As EventArgs) Handles btnScope.Click
        'Call a method
        DisplayBalthazarsName()
    End Sub

    Private Sub btnMathTest_Click(sender As Object, e As EventArgs) Handles btnMathTest.Click
        'Declare variables
        Dim dblNumber = 0.6635, intNumber = 1500
        Dim mtResult As Double

        'Calculate
        mtResult = dblNumber * intNumber

        'Display result
        MessageBox.Show(mtResult.ToString, "Math Test")
    End Sub

    Private Sub btnStringTest_Click(sender As Object, e As EventArgs) Handles btnStringTest.Click
        'Declare variables
        Dim str1, str2, strResult As String

        'Set values
        str1 = "I'm "
        str2 = "dying."
        strResult = str1 & str2

        'Display result
        MessageBox.Show(strResult, "String Concatenation")
    End Sub

    Private Sub btnSubStr_Click(sender As Object, e As EventArgs) Handles btnSubStr.Click
        'Declare variable
        Dim txtStr = txtString37.Text
        Dim intLen, intLen2, intRemainder As Integer

        intLen = txtStr.Length
        intRemainder = intLen Mod 2
        intLen2 = intLen \ 2

        'Display
        MessageBox.Show("Length: " & intLen.ToString)
        MessageBox.Show("The first half: " & txtStr.Substring(0, intLen2 + intRemainder))
        MessageBox.Show("The second half: " & txtStr.Substring(intLen2 + intRemainder, intLen2))
    End Sub
End Class

