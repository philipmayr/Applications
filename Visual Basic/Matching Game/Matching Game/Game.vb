Public Class Game

    Private random As New Random

    Private icons As New List(Of String) From {"!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z"}

    Private firstClicked, secondClicked As Label

    Private sound As New Media.SoundPlayer("C:\Windows\Media\tada.wav")

    Private Sub AssignIconsToSquares()

        For Each control In TableLayoutPanel.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.count)
                iconLabel.Text = icons(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next
    End Sub

    Public Sub New()

        InitializeComponent()

        AssignIconsToSquares()
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click, Label10.Click, Label11.Click, Label12.Click, Label12.Click, Label13.Click, Label14.Click, Label15.Click, Label16.Click

        If Timer.Enabled Then Exit Sub

        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then

            If clickedLabel.ForeColor = Color.Black Then Exit Sub

            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Exit Sub
            End If

            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black

            CheckForWinner()

            If firstClicked.Text = secondClicked.Text Then
                firstClicked = Nothing
                secondClicked = Nothing
                Exit Sub
            End If

            Timer.Start()

        End If
    End Sub

    Private Sub Timer_Tick() Handles Timer.Tick

        Timer.Stop()

        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        firstClicked = Nothing
        secondClicked = Nothing
    End Sub

    Private Sub CheckForWinner()

        For Each Control In TableLayoutPanel.Controls
            Dim iconLabel = TryCast(Control, Label)
            If iconLabel IsNot Nothing AndAlso iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
        Next

        sound.Play()

        If MessageBox.Show("You matched all of the icons!" & Environment.NewLine & Environment.NewLine & "Would you like to play again?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then Application.Restart() Else Application.Exit()
    End Sub
End Class
