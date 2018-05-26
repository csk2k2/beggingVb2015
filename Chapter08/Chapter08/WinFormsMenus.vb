Public Class WinFormsMenus
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        'Clear the text boxes
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        'Set focus to the first text box
        TextBox1.Focus()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        'Call the NewToolStripMenuItem_Click procedure
        NewToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the form and end
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        'Undo the last operation
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Undo()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        'Copy the text to the clipboard and clear the field
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        'Call CutToolStripMenuItem_Click procedure
        CutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        'Copy the text to the clipboard
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        'Call CopyToolStripMenuItem_Click procedure
        CopyToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Copy the text from the clipboard to the text box
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Paste()
        End If
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        'Call the PasteToolStripMenuItem_Click procedure
        PasteToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        'Select all the text in the text box
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).SelectAll()
        End If
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        'Toggle the visibility of the Main toobar
        'based on the menu item's Checked property
        If MainToolStripMenuItem.Checked Then
            tspMain.Visible = True
        Else
            tspMain.Visible = False
        End If
    End Sub

    Private Sub FormattingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormattingToolStripMenuItem.Click
        'Toggle the visibility of the Formatting toolbar
        'based on the menu item's Checked property
        If FormattingToolStripMenuItem.Checked Then
            tspFormatting.Visible = True
        Else
            tspFormatting.Visible = False
        End If
    End Sub

    Private Sub ContextUndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContextUndoToolStripMenuItem.Click
        'Call the UndoToolStripMenuItem_CLick procedure
        UndoToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ContextCutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContextCutToolStripMenuItem.Click
        'Call the CutToolStripMenuItem_Click procedure
        CutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ContextCopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContextCopyToolStripMenuItem.Click
        'Call the CopyToolStripMenuItem_Click procedure
        CopyToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ContextPasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContextPasteToolStripMenuItem.Click
        'Call PasteToolStripMenuItem_Click procedure
        PasteToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ContextSelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContextSelectAllToolStripMenuItem.Click
        'Call SelectAallToolStripMenuItem_Click
        SelectAllToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToggleMenus()
        'Declare a TextBox object and set if to the ActiveControl
        Dim objTextBox As TextBox = CType(Me.ActiveControl, TextBox)

        'Declare and set a Boolean variable
        Dim blnEnabled As Boolean = CType(objTextBox.SelectionLength, Boolean)

        'Toggle the Undo menu items
        UndoToolStripMenuItem.Enabled = objTextBox.CanUndo
        ContextUndoToolStripMenuItem.Enabled = objTextBox.CanUndo

        'Toggle the Cut toolbar button and menu items
        CutToolStripMenuItem.Enabled = blnEnabled
        CutToolStripButton.Enabled = blnEnabled
        ContextCutToolStripMenuItem.Enabled = blnEnabled

        'Toggle the Copy toolbar button and menu items
        CopyToolStripButton.Enabled = blnEnabled
        CopyToolStripMenuItem.Enabled = blnEnabled
        ContextCopyToolStripMenuItem.Enabled = blnEnabled

        'Reset the blnEnable variable
        blnEnabled = My.Computer.Clipboard.ContainsText

        'Toggle the Paste toolbar button and menu items
        PasteToolStripButton.Enabled = blnEnabled
        PasteToolStripMenuItem.Enabled = blnEnabled
        ContextPasteToolStripMenuItem.Enabled = blnEnabled

        'Reset the blnEnable variable
        If objTextBox.SelectionLength < objTextBox.TextLength Then
            blnEnabled = True
        Else
            blnEnabled = False
        End If

        'Toggle the SelectAll menu items
        SelectAllToolStripMenuItem.Enabled = blnEnabled
        ContextSelectAllToolStripMenuItem.Enabled = blnEnabled
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Toggle toolbar and menu items
        ToggleMenus()
    End Sub
End Class
