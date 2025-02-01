Public Class Game

    Public R As New Random, I As Integer

    Private correctSound As New Media.SoundPlayer("C:\Windows\Media\tada.wav"), incorrectSound As New Media.SoundPlayer("C:\Windows\Media\chord.wav")

    Private Sub GuessBtn_Click() Handles GuessBtn.Click
        If I = Guess.Value Then
            correctSound.Play()
            Correct.BringToFront()
            TooHigh.Visible = False
            TooLow.Visible = False
            Correct.Visible = True
            RestartBtn.Visible = True
            Guess.ReadOnly = True
            GuessBtn.Visible = False
            RestartBtn.Focus()
        ElseIf I < Guess.Value Then
            incorrectSound.Play()
            TooHigh.BringToFront()
            TooHigh.Visible = True
            Guess.Focus()
        ElseIf I > Guess.Value Then
            incorrectSound.Play()
            TooLow.BringToFront()
            TooLow.Visible = True
            Guess.Focus()
        End If
    End Sub

    Private Sub RestartBtn_Click() Handles RestartBtn.Click
        Application.Restart()
    End Sub

    Private Sub Game_FormClosed() Handles Me.FormClosed
        GameMenu.Show()
    End Sub

    Private Sub Guess_GotFocus() Handles Guess.GotFocus
        Guess.Select(0, Guess.Value.ToString().Length)
    End Sub
End Class
