Public Class GameMenu

    Private Sub EasyBtn_Click() Handles EasyBtn.Click
        Game.I = Game.R.Next(1, 10)
        Game.Guess.Maximum = 10
        Game.Text = "Easy (1-10)"
        Game.Show()
        Hide()
    End Sub

    Private Sub NormalBtn_Click() Handles NormalBtn.Click
        Game.I = Game.R.Next(1, 100)
        Game.Guess.Maximum = 100
        Game.Text = "Normal (1-100)"
        Game.Show()
        Hide()
    End Sub

    Private Sub HardBtn_Click() Handles HardBtn.Click
        Game.I = Game.R.Next(1, 1000)
        Game.Guess.Maximum = 1000
        Game.Text = "Hard (1-1000)"
        Game.Show()
        Hide()
    End Sub

    Private Sub ExitBtn_Click() Handles ExitBtn.Click
        Application.Exit()
    End Sub
End Class