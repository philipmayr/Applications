Public Class Main

    Private Sub GoBackButton_Click() Handles GoBackButton.Click
        WebBrowser.GoBack()
        WebBrowser.Select()
    End Sub

    Private Sub GoForwardButton_Click() Handles GoForwardButton.Click
        WebBrowser.GoForward()
        WebBrowser.Select()
    End Sub

    Private Sub StopButton_Click() Handles StopButton.Click
        WebBrowser.Stop()
        WebBrowser.Select()
    End Sub

    Private Sub RefreshButton_Click() Handles RefreshButton.Click
        If Not WebBrowser.Url.Equals("about:blank") Then WebBrowser.Refresh()
        WebBrowser.Select()
    End Sub

    Private Sub URLComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles URLComboBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Escape Then e.SuppressKeyPress = True
        If e.KeyCode = Keys.Enter AndAlso URLComboBox.Text.Trim() <> Nothing Then
            WebBrowser.Navigate(URLComboBox.Text.Trim())
            WebBrowser.Select()
            StopButton.Enabled = True
            RefreshButton.Enabled = True
        End If
    End Sub

    Private Sub WebBrowser_CanGoBackChanged() Handles WebBrowser.CanGoBackChanged
        GoBackButton.Enabled = WebBrowser.CanGoBack
    End Sub

    Private Sub WebBrowser_CanGoForwardChanged() Handles WebBrowser.CanGoForwardChanged
        GoForwardButton.Enabled = WebBrowser.CanGoForward
    End Sub

    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted
        If WebBrowser.ReadyState = WebBrowserReadyState.Complete Then
            URLComboBox.Text = e.Url.AbsoluteUri
            URLComboBox.Items.Insert(0, e.Url.AbsoluteUri)
        End If
    End Sub

    Private Sub WebBrowser_DocumentTitleChanged() Handles WebBrowser.DocumentTitleChanged
        Text = If(WebBrowser.DocumentTitle <> Nothing, WebBrowser.DocumentTitle, WebBrowser.Document.Domain) & " - Web Browser"
    End Sub

    Private Sub WebBrowser_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WebBrowser.NewWindow
        e.Cancel = True
        Dim NewWindow As New Main()
        NewWindow.StartPosition = FormStartPosition.WindowsDefaultLocation
        NewWindow.WebBrowser.Navigate(WebBrowser.Document.ActiveElement.GetAttribute("href"))
        NewWindow.WebBrowser.Select()
        NewWindow.Show()
    End Sub

    Private Sub WebBrowser_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser.ProgressChanged
        Try
            ToolStripProgressBar.Maximum = CInt(e.MaximumProgress)
            ToolStripProgressBar.Value = CInt(e.CurrentProgress)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub WebBrowser_StatusTextChanged() Handles WebBrowser.StatusTextChanged
        ToolStripStatusLabel.Text = WebBrowser.StatusText
    End Sub
End Class
