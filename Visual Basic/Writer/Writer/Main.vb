Public Class Main

    Private FullFileName As String = "Document", FileName As String = "Document", FileType As RichTextBoxStreamType = RichTextBoxStreamType.RichText, OpenedDocument, SavedDocument, DocumentTextChanged As Boolean

    Private Sub NewDocument() Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        If DocumentTextChanged Then
            Select Case MessageBox.Show("Do you want to save changes to " & FullFileName & "?", "Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    If OpenedDocument OrElse SavedDocument Then
                        RichTextBox.SaveFile(FullFileName, FileType)
                    Else
                        SaveFileDialog.FileName = "Document"
                        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                        If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            If SaveFileDialog.FileName <> Nothing Then
                                FullFileName = SaveFileDialog.FileName
                                FileName = IO.Path.GetFileNameWithoutExtension(FullFileName)
                            End If
                            If SaveFileDialog.FilterIndex = 1 Then
                                FileType = RichTextBoxStreamType.RichText
                                RichTextBox.SaveFile(FullFileName, FileType)
                            Else
                                FileType = RichTextBoxStreamType.PlainText
                                RichTextBox.SaveFile(FullFileName, FileType)
                            End If
                        Else
                            Exit Sub
                        End If
                    End If
                Case Windows.Forms.DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        RichTextBox.Clear()
        Text = "Document - Writer"
        FullFileName = "Document"
        OpenedDocument = False
        SavedDocument = False
        DocumentTextChanged = False
    End Sub

    Private Sub OpenDocument() Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        OpenFileDialog.FileName = Nothing
        OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog_FileOk() Handles OpenFileDialog.FileOk
        If DocumentTextChanged Then
            Select Case MessageBox.Show("Do you want to save changes to " & FullFileName & "?", "Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    SaveDocument()
                Case Windows.Forms.DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        If OpenFileDialog.FileName <> Nothing Then
            FullFileName = OpenFileDialog.FileName
            FileName = IO.Path.GetFileNameWithoutExtension(FullFileName)
        End If
        If IO.Path.GetExtension(FullFileName) = ".rtf" Then
            FileType = RichTextBoxStreamType.RichText
            RichTextBox.LoadFile(FullFileName, FileType)
        Else
            FileType = RichTextBoxStreamType.PlainText
            RichTextBox.Font = New Font("Segoe UI", 9.75)
            RichTextBox.ForeColor = Color.Black
            RichTextBox.LoadFile(FullFileName, FileType)
        End If
        Text = FileName & " - Writer"
        OpenedDocument = True
        DocumentTextChanged = False
    End Sub

    Private Sub SaveDocument() Handles SaveToolStripMenuItem.Click, SaveToolStripButton.Click
        If OpenedDocument OrElse SavedDocument Then RichTextBox.SaveFile(FullFileName, FileType) : DocumentTextChanged = False Else SaveAs()
    End Sub

    Private Sub SaveAs() Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog.FileName = "Document"
        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub SaveFileDialog_FileOk() Handles SaveFileDialog.FileOk
        If SaveFileDialog.FileName <> Nothing Then
            FullFileName = SaveFileDialog.FileName
            FileName = IO.Path.GetFileNameWithoutExtension(FullFileName)
        End If
        If SaveFileDialog.FilterIndex = 1 Then
            FileType = RichTextBoxStreamType.RichText
            RichTextBox.SaveFile(FullFileName, FileType)
        Else
            FileType = RichTextBoxStreamType.PlainText
            RichTextBox.SaveFile(FullFileName, FileType)
        End If
        Text = FileName & " - Writer"
        SavedDocument = True
        DocumentTextChanged = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click() Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If DocumentTextChanged Then
            Select Case MessageBox.Show("Do you want to save changes to " & FullFileName & "?", "Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    SaveDocument()
                Case Windows.Forms.DialogResult.No
                    Application.ExitThread()
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub RichTextBoxUndo() Handles UndoToolStripMenuItem.Click, ToolStripMenuItem1.Click
        RichTextBox.Undo()
    End Sub

    Private Sub RichTextBoxRedo() Handles RedoToolStripMenuItem.Click, ToolStripMenuItem2.Click
        RichTextBox.Redo()
    End Sub

    Private Sub RichTextBoxCut() Handles CutToolStripMenuItem.Click, CutToolStripButton.Click, ToolStripMenuItem3.Click
        RichTextBox.Cut()
    End Sub

    Private Sub RichTextBoxCopy() Handles CopyToolStripMenuItem.Click, CopyToolStripButton.Click, ToolStripMenuItem4.Click
        RichTextBox.Copy()
    End Sub

    Private Sub RichTextBoxPaste() Handles PasteToolStripMenuItem.Click, PasteToolStripButton.Click, ToolStripMenuItem5.Click
        RichTextBox.Paste()
    End Sub

    Private Sub RichTextBoxClear() Handles ClearToolStripMenuItem.Click, ToolStripMenuItem6.Click
        RichTextBox.SelectedText = String.Empty
    End Sub

    Private Sub RichTextBoxSelectAll() Handles SelectAllToolStripMenuItem.Click, ToolStripMenuItem7.Click
        RichTextBox.SelectAll()
    End Sub

    Private Sub RichTextBoxWordWrap() Handles WordWrapToolStripMenuItem.CheckedChanged
        RichTextBox.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub RichTextBoxFont() Handles FontToolStripMenuItem.Click
        FontDialog.Font = RichTextBox.SelectionFont
        FontDialog.Color = RichTextBox.SelectionColor
        If FontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox.SelectionFont = FontDialog.Font
            RichTextBox.SelectionColor = FontDialog.Color
        End If
    End Sub

    Private Sub RichTextBoxBulletStyle() Handles BulletStyleToolStripMenuItem.CheckedChanged
        RichTextBox.BulletIndent = 50
        RichTextBox.SelectionBullet = BulletStyleToolStripMenuItem.Checked
    End Sub

    Private Sub RichTextBoxLeftAlignment() Handles LeftToolStripMenuItem.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Left
        LeftToolStripMenuItem.Checked = True
        RightToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
    End Sub

    Private Sub RichTextBoxRightAlignment() Handles RightToolStripMenuItem.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Right
        RightToolStripMenuItem.Checked = True
        LeftToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
    End Sub

    Private Sub RichTextBoxCenterAlignment() Handles CenterToolStripMenuItem.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Center
        CenterToolStripMenuItem.Checked = True
        LeftToolStripMenuItem.Checked = False
        RightToolStripMenuItem.Checked = False
    End Sub

    Private Sub RichTextBox_SelectionChanged() Handles RichTextBox.SelectionChanged
        If RichTextBox.SelectionLength > 0 Then
            CutToolStripButton.Enabled = True
            CopyToolStripButton.Enabled = True
            ClearToolStripMenuItem.Enabled = True
        Else
            CutToolStripButton.Enabled = False
            CopyToolStripButton.Enabled = False
            ClearToolStripMenuItem.Enabled = False
        End If
        BulletStyleToolStripMenuItem.Checked = RichTextBox.SelectionBullet
        Select Case RichTextBox.SelectionAlignment
            Case HorizontalAlignment.Left
                LeftToolStripMenuItem.Checked = True
                RightToolStripMenuItem.Checked = False
                CenterToolStripMenuItem.Checked = False
            Case HorizontalAlignment.Right
                RightToolStripMenuItem.Checked = True
                LeftToolStripMenuItem.Checked = False
                CenterToolStripMenuItem.Checked = False
            Case HorizontalAlignment.Center
                CenterToolStripMenuItem.Checked = True
                LeftToolStripMenuItem.Checked = False
                RightToolStripMenuItem.Checked = False
        End Select
    End Sub

    Private Sub RichTextBox_TextChanged() Handles RichTextBox.TextChanged
        DocumentTextChanged = True
        If RichTextBox.TextLength > 0 Then
            SelectAllToolStripMenuItem.Enabled = True
            ToolStripMenuItem7.Enabled = True
        Else
            SelectAllToolStripMenuItem.Enabled = False
            ToolStripMenuItem7.Enabled = False
        End If
    End Sub

    Private Sub RichTextBoxContextMenuStrip_Opening() Handles RichTextBoxContextMenuStrip.Opening
        If RichTextBox.SelectionLength > 0 Then
            ToolStripMenuItem3.Enabled = True
            ToolStripMenuItem4.Enabled = True
            ToolStripMenuItem6.Enabled = True
        Else
            ToolStripMenuItem3.Enabled = False
            ToolStripMenuItem4.Enabled = False
            ToolStripMenuItem6.Enabled = False
        End If
        ToolStripMenuItem1.Enabled = RichTextBox.CanUndo
        ToolStripMenuItem2.Enabled = RichTextBox.CanRedo
        ToolStripMenuItem5.Enabled = Clipboard.ContainsText() OrElse Clipboard.ContainsImage()
        ToolStripMenuItem7.Enabled = RichTextBox.TextLength > 0
    End Sub

    Private Sub Timer_Tick() Handles Timer.Tick
        UndoToolStripMenuItem.Enabled = RichTextBox.CanUndo
        RedoToolStripMenuItem.Enabled = RichTextBox.CanRedo
        If Clipboard.ContainsText() OrElse Clipboard.ContainsImage() Then
            PasteToolStripButton.Enabled = True
            PasteToolStripMenuItem.Enabled = True
        Else
            PasteToolStripButton.Enabled = False
            PasteToolStripMenuItem.Enabled = False
        End If
    End Sub
End Class