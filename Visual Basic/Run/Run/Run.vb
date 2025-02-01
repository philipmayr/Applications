Public Class Run

    Private OK As Boolean

    Private Sub Run_Load() Handles Me.Load
        OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    End Sub

    Private Sub ComboBox_TextChanged() Handles ComboBox.TextChanged
        OKBtn.Enabled = ComboBox.Text.Trim() <> Nothing
    End Sub

    Private Sub OKBtn_Click() Handles OKBtn.Click
        Dim T = ComboBox.Text.Trim()
        ComboBox.Focus()
        Try
            If My.Computer.FileSystem.DirectoryExists(T.Replace("""", Nothing)) Then Process.Start("explorer.exe", T) Else If My.Computer.FileSystem.FileExists(T.Replace("""", Nothing)) Then Process.Start(T) Else Process.Start(If(T.Contains(" "), T.Substring(0, T.IndexOf(" ")), T), If(T.Contains(" "), T.Substring(T.IndexOf(" ")), Nothing))
            Application.Exit()
        Catch ex As Exception
            Hide()
            MessageBox.Show("Run cannot find '" & T & "'. Make sure you typed the name correctly, and then try again.", T, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Show()
        End Try
    End Sub

    Private Sub CancelBtn_Click() Handles CancelBtn.Click
        Application.Exit()
    End Sub

    Private Sub BrowseBtn_Click() Handles BrowseBtn.Click
        OK = False
        OpenFileDialog.FileName = Nothing
        OpenFileDialog.ShowDialog()
        If OK Then OKBtn.Focus()
    End Sub

    Private Sub OpenFileDialog_FileOk() Handles OpenFileDialog.FileOk
        ComboBox.Text = If(OpenFileDialog.FileName.Contains(" "), """" & OpenFileDialog.FileName & """", OpenFileDialog.FileName)
        OpenFileDialog.FilterIndex = 1
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.GetParentPath(OpenFileDialog.FileName)
        OK = True
    End Sub

    Private Sub Run_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(SystemPens.Control, 0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1)
    End Sub
End Class