Public Class Main

    Private Sub TextBox_TextChanged() Handles TextBox.TextChanged
        DownloadButton.Enabled = TextBox.Text.Trim() <> Nothing
    End Sub

    Private WithEvents WebClient As New Net.WebClient()

    Private Sub DownloadFileButton_Click() Handles DownloadButton.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim Text = TextBox.Text.Trim
                WebClient.DownloadFileAsync(New Uri(Text), FolderBrowserDialog.SelectedPath & "\" & If(Text.Contains("/"), Text.Substring(Text.LastIndexOf("/")), Text))
                CancelDownloadButton.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox.Text = "http:\\"
                TextBox.SelectAll()
                TextBox.Focus()
            End Try
        End If
    End Sub

    Private Sub CancelButton_Click() Handles CancelDownloadButton.Click
        WebClient.CancelAsync()
    End Sub

    Private BytesRecieved, TotalBytesToReceive As Double, BytesRecievedUnit, TotalBytesToReceiveUnit As String, StringBuilder As New System.Text.StringBuilder()

    Private Sub WebClient_DownloadProgressChanged(sender As Object, e As Net.DownloadProgressChangedEventArgs)
        If e.BytesReceived < 1024 Then
            BytesRecieved = Math.Round(e.BytesReceived)
            BytesRecievedUnit = "Bytes"
        ElseIf e.BytesReceived >= 1024 AndAlso e.BytesReceived < 1048576 Then
            BytesRecieved = (Math.Round(e.BytesReceived / 1024))
            BytesRecievedUnit = "KB"
        ElseIf e.BytesReceived >= 1048576 AndAlso e.BytesReceived < 1073741824 Then
            BytesRecieved = Math.Round(e.BytesReceived / 1048576)
            BytesRecievedUnit = "MB"
        ElseIf e.BytesReceived >= 1073741824 AndAlso e.BytesReceived < 1099511627776 Then
            BytesRecieved = Math.Round(e.BytesReceived / 1073741824)
            BytesRecievedUnit = "GB"
        ElseIf e.BytesReceived >= 1099511627776 Then
            BytesRecieved = Math.Round(e.BytesReceived / 1099511627776)
            BytesRecievedUnit = "TB"
        End If
        If e.TotalBytesToReceive < 1024 Then
            TotalBytesToReceive = Math.Round(e.TotalBytesToReceive)
            TotalBytesToReceiveUnit = "Bytes"
        ElseIf e.TotalBytesToReceive >= 1024 AndAlso e.TotalBytesToReceive < 1048576 Then
            TotalBytesToReceive = Math.Round(e.TotalBytesToReceive / 1024)
            TotalBytesToReceiveUnit = "KB"
        ElseIf e.TotalBytesToReceive >= 1048576 AndAlso e.TotalBytesToReceive < 1073741824 Then
            TotalBytesToReceive = Math.Round(e.TotalBytesToReceive / 1048576)
            TotalBytesToReceiveUnit = "MB"
        ElseIf e.TotalBytesToReceive >= 1073741824 AndAlso e.TotalBytesToReceive < 1099511627776 Then
            TotalBytesToReceive = Math.Round(e.TotalBytesToReceive / 1073741824)
            TotalBytesToReceiveUnit = "GB"
        ElseIf e.TotalBytesToReceive >= 1099511627776 Then
            TotalBytesToReceive = Math.Round(e.TotalBytesToReceive / 1099511627776)
            TotalBytesToReceiveUnit = "TB"
        End If
        SizeLabel.Text = StringBuilder.Append(BytesRecieved).Append(" ").Append(BytesRecievedUnit).Append(" of ").Append(TotalBytesToReceive).Append(" ").Append(TotalBytesToReceiveUnit).ToString
        ProgressPercentageLabel.Text = e.ProgressPercentage & "%"
        ProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub WebClient_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        CancelDownloadButton.Enabled = False
    End Sub
End Class
