Public Class Main

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (lpstrCommand As String, lpstrReturnString As String, uReturnLength As Integer, hwndCallback As Integer) As Integer

    Private Sub RecButton_Click() Handles RecButton.Click
        Select Case RecButton.Text
            Case "Start Recording"
                RecButton.Text = "Stop Recording"
                StartRecToolTip.Active = False
                StopRecToolTip.Active = True

                mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)

                mciSendString("record recsound", "", 0, 0)

            Case "Stop Recording"
                RecButton.Text = "Resume Recording"
                StopRecToolTip.Active = False
                ResumeRecToolTip.Active = True

                mciSendString("pause recsound" & "", "", 0, 0)

                SaveFileDialog.FileName = "Untitled"
                SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

                If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    mciSendString("save recsound " & SaveFileDialog.FileName, "", 0, 0)

                    mciSendString("close recsound", "", 0, 0)

                    RecButton.Text = "Start Recording"
                    ResumeRecToolTip.Active = False
                    StopRecToolTip.Active = False
                    StartRecToolTip.Active = True
                End If
            Case "Resume Recording"
                RecButton.Text = "Stop Recording"
                ResumeRecToolTip.Active = False
                StopRecToolTip.Active = True

                mciSendString("resume recsound" & "", "", 0, 0)
        End Select
    End Sub

    Private Sub RecButton_KeyDown(sender As Object, e As KeyEventArgs) Handles RecButton.KeyDown
        If e.KeyCode = Keys.Alt + Keys.S Then RecButton.PerformClick()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If RecButton.Text = "Stop Recording" OrElse RecButton.Text = "Resume Recording" Then

            Select Case MessageBox.Show("Do you want to save the changes you made to the audio file?", "Sound Recorder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                Case Windows.Forms.DialogResult.Yes

                    SaveFileDialog.FileName = "Untitled"
                    SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

                    If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                        mciSendString("save recsound " & SaveFileDialog.FileName, "", 0, 0)

                        mciSendString("close recsound", "", 0, 0)

                        Application.ExitThread()
                    Else
                        e.Cancel = True
                    End If
                Case Windows.Forms.DialogResult.No
                    Application.ExitThread()
            End Select
        End If
    End Sub

    Private Sub Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(ClientRectangle, Color.Gray, Color.Black, Drawing2D.LinearGradientMode.Vertical), ClientRectangle)
    End Sub
End Class
