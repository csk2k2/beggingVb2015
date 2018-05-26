Public Class Exercise4

    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        'Declare variable
        Dim strName As String

        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex)

        'Use Select Case statement to get the gender of the seleted person
        Select Case strName.ToLower
            Case "chengyi", "libo", "wxd"
                MessageBox.Show("The person is male!")
            Case "zhangxiaoxu", "zhaoyan", "miaomiao"
                MessageBox.Show("The person is female!")
            Case Else
                MessageBox.Show("I don't know this person's gender")
        End Select
    End Sub
End Class
