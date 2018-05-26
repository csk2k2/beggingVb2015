Public Class WordCounter

    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged

        'Something changed so display the results
        UpdateDisplay()
    End Sub

    ''' <summary>
    ''' Count the characters in a block of text
    ''' </summary>
    ''' <param name="text">The string containing the text to count characters in</param>
    ''' <returns>number of characters</returns>
    Private Function CountCharacters(ByVal text As String) As Integer
        Return text.Length
    End Function

    Private Function CountWords(ByVal text As String) As Integer

        'Is the text empty?
        If text.Trim.Length = 0 Then Return 0

        'Split the words
        Dim strWords() As String = text.Split(" "c)

        'Return the number of words
        Return strWords.Length
    End Function

    Private Sub UpdateDisplay()
        'Do we want to cout words?
        If radCountWords.Checked Then
            'Update the results with words
            lblResults.Text = CountWords(txtWords.Text) & "words"
        Else
            'Update the results with characters
            lblResults.Text = CountCharacters(txtWords.Text) & "charaters"
        End If
    End Sub

    Private Sub radCountChars_CheckedChanged(sender As Object, e As EventArgs) Handles radCountChars.CheckedChanged
        UpdateDisplay()
    End Sub

    Private Sub radCountWords_CheckedChanged(sender As Object, e As EventArgs) Handles radCountWords.CheckedChanged
        UpdateDisplay()
    End Sub
End Class
