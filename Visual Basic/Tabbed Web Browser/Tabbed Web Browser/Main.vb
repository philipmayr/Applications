Public Class Main

    Private Sub Main_Load() Handles Me.Load
        If Name <> "New Window" AndAlso My.Application.CommandLineArgs().Count <> Nothing Then
            For Each Arg In My.Application.CommandLineArgs()
                Dim NewTabPage = New TabPage("New Tab") With {.ToolTipText = "New Tab", .ContextMenuStrip = TabPageContextMenuStrip, .BackColor = Color.SlateGray, .Parent = TabControl},
                    NewWebBrowser = New WebBrowser() With {.Dock = DockStyle.Fill, .ScriptErrorsSuppressed = True}
                AddHandler NewWebBrowser.CanGoBackChanged, AddressOf WebBrowser_CanGoBackChanged
                AddHandler NewWebBrowser.CanGoForwardChanged, AddressOf WebBrowser_CanGoForwardChanged
                AddHandler NewWebBrowser.DocumentCompleted, AddressOf WebBrowser_DocumentCompleted
                AddHandler NewWebBrowser.DocumentTitleChanged, AddressOf WebBrowser_DocumentTitleChanged
                AddHandler NewWebBrowser.NewWindow, AddressOf WebBrowser_NewWindow
                AddHandler NewWebBrowser.ProgressChanged, AddressOf WebBrowser_ProgressChanged
                AddHandler NewWebBrowser.StatusTextChanged, AddressOf WebBrowser_StatusTextChanged
                NewTabPage.Controls.Add(NewWebBrowser)
                NewWebBrowser.Navigate(Arg)
                NewWebBrowser.Select()
                StopButton.Enabled = True
                RefreshButton.Enabled = True
            Next
        Else
            Dim NewTabPage = New TabPage("New Tab") With {.ToolTipText = "New Tab", .ContextMenuStrip = TabPageContextMenuStrip, .BackColor = Color.SlateGray, .Parent = TabControl}
        End If
        Text = "New Tab - Tabbed Web Browser"
    End Sub

    Private Sub URLComboBox_TextChanged() Handles URLComboBox.TextChanged
        NavigateButton.Enabled = URLComboBox.Text.Trim() <> Nothing
        If TabControl.SelectedTab.Text = "New Tab" Then TabControl.SelectedTab.Tag = URLComboBox.Text
    End Sub

    Private Sub URLComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles URLComboBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Escape Then e.SuppressKeyPress = True
        If e.KeyCode = Keys.Enter AndAlso URLComboBox.Text.Trim() <> Nothing Then NavigateButton.PerformClick()
    End Sub

    Private Sub NavigateButton_Click() Handles NavigateButton.Click
        Dim ST = TabControl.SelectedTab, URL = URLComboBox.Text.Trim()
        If ST.Text = "New Tab" Then
            Dim NewWebBrowser = New WebBrowser() With {.Dock = DockStyle.Fill, .ScriptErrorsSuppressed = True}
            AddHandler NewWebBrowser.CanGoBackChanged, AddressOf WebBrowser_CanGoBackChanged
            AddHandler NewWebBrowser.CanGoForwardChanged, AddressOf WebBrowser_CanGoForwardChanged
            AddHandler NewWebBrowser.DocumentCompleted, AddressOf WebBrowser_DocumentCompleted
            AddHandler NewWebBrowser.DocumentTitleChanged, AddressOf WebBrowser_DocumentTitleChanged
            AddHandler NewWebBrowser.NewWindow, AddressOf WebBrowser_NewWindow
            AddHandler NewWebBrowser.ProgressChanged, AddressOf WebBrowser_ProgressChanged
            AddHandler NewWebBrowser.StatusTextChanged, AddressOf WebBrowser_StatusTextChanged
            ST.Controls.Add(NewWebBrowser)
            NewWebBrowser.Navigate(URL)
            NewWebBrowser.Select()
        Else
            Dim WebBrowser = CType(ST.Controls.Item(0), WebBrowser)
            WebBrowser.Navigate(URL)
            WebBrowser.Select()
        End If
        StopButton.Enabled = True
        RefreshButton.Enabled = True
    End Sub

    Private Sub WebBrowser_CanGoBackChanged(sender As Object, e As EventArgs)
        If TabControl.SelectedTab.Text <> "New Tab" AndAlso sender Is TabControl.SelectedTab.Controls.Item(0) Then GoBackButton.Enabled = CType(sender, WebBrowser).CanGoBack
    End Sub

    Private Sub WebBrowser_CanGoForwardChanged(sender As Object, e As EventArgs)
        If TabControl.SelectedTab.Text <> "New Tab" AndAlso sender Is TabControl.SelectedTab.Controls.Item(0) Then GoForwardButton.Enabled = CType(sender, WebBrowser).CanGoForward
    End Sub

    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        Dim WebBrowser = CType(sender, WebBrowser), TabPage = CType(WebBrowser.Parent, TabPage), DocumentTitle = WebBrowser.DocumentTitle, ST = TabControl.SelectedTab, URI = e.Url.AbsoluteUri
        If ST.Text <> "New Tab" AndAlso sender Is ST.Controls.Item(0) Then
            ShowPropertiesDialogButton.Enabled = True
            ShowSaveAsDialogButton.Enabled = True
        End If
        If WebBrowser.DocumentType = "File" OrElse e.Url.IsFile Then TabPage.ImageKey = Nothing
        If DocumentTitle <> Nothing Then
            TabPage.Text = DocumentTitle
            TabPage.ToolTipText = DocumentTitle
            If ST.Text <> "New Tab" AndAlso sender Is ST.Controls.Item(0) Then
                URLComboBox.Text = URI
                Text = DocumentTitle & " - Tabbed Web Browser"
            End If
        Else
            Dim DocumentDomain = WebBrowser.Document.Domain
            TabPage.Text = DocumentDomain
            TabPage.ToolTipText = DocumentDomain
            TabPage.ImageKey = Nothing
            If ST.Text <> "New Tab" AndAlso sender Is ST.Controls.Item(0) Then Text = DocumentDomain & " - Tabbed Web Browser"
        End If
        URLComboBox.Items.Insert(0, URI)
    End Sub

    Private Sub WebBrowser_DocumentTitleChanged(sender As Object, e As EventArgs)
        Dim WebBrowser = CType(sender, WebBrowser), TabPage = CType(WebBrowser.Parent, TabPage), DocumentDomain = WebBrowser.Document.Domain, DocumentTitle = WebBrowser.DocumentTitle, ST = TabControl.SelectedTab
        Try
            ImageList.Images.Add(DocumentTitle, Image.FromStream(New MemoryStream(New WebClient().DownloadData("http://" & DocumentDomain & "/favicon.ico"))))
        Catch ex As Exception
        End Try
        If DocumentTitle <> Nothing Then
            TabPage.Text = DocumentTitle
            TabPage.ToolTipText = DocumentTitle
            TabPage.ImageKey = DocumentTitle
            If ST.Text <> "New Tab" AndAlso sender Is ST.Controls.Item(0) Then Text = DocumentTitle & " - Tabbed Web Browser"
        Else
            TabPage.Text = DocumentDomain
            TabPage.ToolTipText = DocumentDomain
            TabPage.ImageKey = Nothing
            If ST.Text <> "New Tab" AndAlso sender Is ST.Controls.Item(0) Then Text = DocumentDomain & " - Tabbed Web Browser"
        End If
    End Sub

    Private Sub WebBrowser_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs)
        e.Cancel = True
        Dim NewWindow = New Main() With {.Name = "New Window"}
        NewWindow.Show()
        NewWindow.URLComboBox.Text = (CType(sender, WebBrowser).Document.ActiveElement.GetAttribute("href"))
        NewWindow.NavigateButton.PerformClick()
    End Sub

    Private Sub WebBrowser_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs)
        If TabControl.SelectedTab.Text <> "New Tab" AndAlso sender Is TabControl.SelectedTab.Controls.Item(0) Then
            ToolStripProgressBar.Maximum = CInt(e.MaximumProgress)
            ToolStripProgressBar.Value = CInt(e.CurrentProgress)
        End If
    End Sub

    Private Sub WebBrowser_StatusTextChanged(sender As Object, e As EventArgs)
        If TabControl.SelectedTab.Text <> "New Tab" AndAlso sender Is TabControl.SelectedTab.Controls.Item(0) Then ToolStripStatusLabel.Text = CType(sender, WebBrowser).StatusText
    End Sub

    Private Sub StopButton_Click() Handles StopButton.Click
        Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
        WebBrowser.Stop()
        WebBrowser.Select()
    End Sub

    Private Sub RefreshButton_Click() Handles RefreshButton.Click
        Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
        If Not WebBrowser.Url.Equals("about:blank") Then WebBrowser.Refresh()
        WebBrowser.Select()
    End Sub

    Private Sub GoBackButton_Click() Handles GoBackButton.Click
        Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
        WebBrowser.GoBack()
        WebBrowser.Select()
    End Sub

    Private Sub GoForwardButton_Click() Handles GoForwardButton.Click
        Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
        WebBrowser.GoForward()
        WebBrowser.Select()
    End Sub

    Private Sub GoHomeButton_Click() Handles GoHomeButton.Click
        Dim ST = TabControl.SelectedTab
        If TabControl.SelectedTab.Text = "New Tab" Then
            Dim NewWebBrowser = New WebBrowser() With {.Dock = DockStyle.Fill, .ScriptErrorsSuppressed = True}
            AddHandler NewWebBrowser.CanGoBackChanged, AddressOf WebBrowser_CanGoBackChanged
            AddHandler NewWebBrowser.CanGoForwardChanged, AddressOf WebBrowser_CanGoForwardChanged
            AddHandler NewWebBrowser.DocumentCompleted, AddressOf WebBrowser_DocumentCompleted
            AddHandler NewWebBrowser.DocumentTitleChanged, AddressOf WebBrowser_DocumentTitleChanged
            AddHandler NewWebBrowser.NewWindow, AddressOf WebBrowser_NewWindow
            AddHandler NewWebBrowser.ProgressChanged, AddressOf WebBrowser_ProgressChanged
            AddHandler NewWebBrowser.StatusTextChanged, AddressOf WebBrowser_StatusTextChanged
            ST.Controls.Add(NewWebBrowser)
            NewWebBrowser.GoHome()
            NewWebBrowser.Select()
            StopButton.Enabled = True
            RefreshButton.Enabled = True
        Else
            Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
            WebBrowser.GoHome()
            WebBrowser.Select()
        End If
    End Sub

    Private Sub GoSearchButton_Click() Handles GoSearchButton.Click
        Dim ST = TabControl.SelectedTab
        If ST.Text = "New Tab" Then
            Dim NewWebBrowser = New WebBrowser() With {.Dock = DockStyle.Fill, .ScriptErrorsSuppressed = True}
            AddHandler NewWebBrowser.CanGoBackChanged, AddressOf WebBrowser_CanGoBackChanged
            AddHandler NewWebBrowser.CanGoForwardChanged, AddressOf WebBrowser_CanGoForwardChanged
            AddHandler NewWebBrowser.DocumentCompleted, AddressOf WebBrowser_DocumentCompleted
            AddHandler NewWebBrowser.DocumentTitleChanged, AddressOf WebBrowser_DocumentTitleChanged
            AddHandler NewWebBrowser.NewWindow, AddressOf WebBrowser_NewWindow
            AddHandler NewWebBrowser.ProgressChanged, AddressOf WebBrowser_ProgressChanged
            AddHandler NewWebBrowser.StatusTextChanged, AddressOf WebBrowser_StatusTextChanged
            ST.Controls.Add(NewWebBrowser)
            NewWebBrowser.GoSearch()
            NewWebBrowser.Select()
            StopButton.Enabled = True
            RefreshButton.Enabled = True
        Else
            Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
            WebBrowser.GoSearch()
            WebBrowser.Select()
        End If
    End Sub

    Private Sub ShowPropertiesDialogButton_Click() Handles ShowPropertiesDialogButton.Click
        Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
        WebBrowser.ShowPropertiesDialog()
        WebBrowser.Select()
    End Sub

    Private Sub ShowSaveAsDialogButton_Click() Handles ShowSaveAsDialogButton.Click
        Dim WebBrowser = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser)
        WebBrowser.ShowSaveAsDialog()
        WebBrowser.Select()
    End Sub

    Private Sub NewTab() Handles NewTabButton.Click, TabPageNewTabToolStripMenuItem.Click
        Dim NewTabPage As New TabPage("New Tab") With {.BackColor = Color.SlateGray, .ContextMenuStrip = TabPageContextMenuStrip}
        TabControl.TabPages.Add(NewTabPage)
        TabControl.SelectTab(NewTabPage)
    End Sub

    Private Sub CloseTab() Handles CloseTabButton.Click, TabPageCloseTabToolStripMenuItem.Click
        If TabControl.TabCount = 1 Then
            Close()
        Else
            Dim SI = TabControl.SelectedIndex
            TabControl.TabPages.RemoveAt(TabControl.SelectedIndex)
            TabControl.SelectTab(If(SI <> TabControl.TabCount, SI, SI - 1))
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged() Handles TabControl.SelectedIndexChanged
        Dim ST = TabControl.SelectedTab
        If ST.Text = "New Tab" Then
            Text = "New Tab - Tabbed Web Browser"
            ToolStripStatusLabel.Text = Nothing
            ToolStripProgressBar.Value = Nothing
            RefreshButton.Enabled = False
            StopButton.Enabled = False
            GoBackButton.Enabled = False
            GoForwardButton.Enabled = False
            ShowPropertiesDialogButton.Enabled = False
            ShowSaveAsDialogButton.Enabled = False
            URLComboBox.Text = CStr(ST.Tag)
            URLComboBox.Focus()
        Else
            Dim WebBrowser = CType(ST.Controls.Item(0), WebBrowser)
            WebBrowser.Select()
            ToolStripStatusLabel.Text = WebBrowser.StatusText
            ToolStripProgressBar.Value = Nothing
            StopButton.Enabled = True
            RefreshButton.Enabled = True
            GoBackButton.Enabled = WebBrowser.CanGoBack
            GoForwardButton.Enabled = WebBrowser.CanGoForward
            ShowPropertiesDialogButton.Enabled = True
            ShowSaveAsDialogButton.Enabled = True
            URLComboBox.Text = WebBrowser.Url.AbsoluteUri
            Text = ST.Text & " - Tabbed Web Browser"
        End If
    End Sub

    Private TI As Integer

    Private Sub TabControl_MouseUp(sender As Object, e As MouseEventArgs) Handles TabControl.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            For I = 0 To TabControl.TabCount - 1
                If TabControl.GetTabRect(I).Contains(e.Location) Then TI = I
            Next
        End If
    End Sub

    Private Sub TabControlNewTabToolStripMenuItem_Click() Handles TabControlNewTabToolStripMenuItem.Click
        Dim NewTabPage = New TabPage("New Tab") With {.ToolTipText = "New Tab", .ContextMenuStrip = TabPageContextMenuStrip, .BackColor = Color.SlateGray}
        TabControl.TabPages.Insert(TI + 1, NewTabPage)
        TabControl.SelectTab(TI + 1)
    End Sub

    Private Sub TabControlCloseTabToolStripMenuItem_Click() Handles TabControlCloseTabToolStripMenuItem.Click
        If TabControl.TabCount = 1 Then
            Close()
        Else
            Dim SI = TabControl.SelectedIndex
            TabControl.TabPages.RemoveAt(TI)
            TabControl.SelectTab(If(SI = TabControl.TabCount OrElse TabControl.SelectedIndex = SI - 1, SI - 1, SI))
        End If
    End Sub
End Class
