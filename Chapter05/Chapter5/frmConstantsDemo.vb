Public Class frmConstantsDemo

    'File name constant
    Private Const strFileName As String = "C:\Temp\Hello.txt"

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'Using a constant
        MessageBox.Show("1:" & strFileName)
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        'Using a constant
        MessageBox.Show("2:" & strFileName)
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'Using a constant
        MessageBox.Show("3:" & strFileName)

    End Sub
End Class