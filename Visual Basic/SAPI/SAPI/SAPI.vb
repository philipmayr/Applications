Public Class Form

    Private WithEvents Voice As New SpeechLib.SpVoice()

    Private Sub TextBox_TextChanged() Handles TextBox.TextChanged
        SpeakBtn.Enabled = TextBox.Text.Trim() <> Nothing
    End Sub

    Private Sub SpeakBtn_Click() Handles SpeakBtn.Click
        Voice.Speak(TextBox.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub

    Private Sub Voice_StartStream() Handles Voice.StartStream
        Label.Text = "Speaking..."
        SpeakBtn.Enabled = False
        TextBox.Enabled = False
    End Sub

    Private Sub Voice_EndStream() Handles Voice.EndStream
        Label.Text = Nothing
        TextBox.Enabled = True
        SpeakBtn.Enabled = True
        TextBox.SelectAll()
        TextBox.Focus()
    End Sub

    Private Sub Form_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If ClientRectangle <> Nothing Then e.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(ClientRectangle, Color.Black, Color.LightBlue, Drawing2D.LinearGradientMode.Horizontal), ClientRectangle)
    End Sub
End Class
