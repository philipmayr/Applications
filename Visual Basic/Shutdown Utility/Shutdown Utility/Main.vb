Public Class Main

    Private Sub LogOffBtn_Click() Handles LogOffBtn.Click
        Shell("shutdown -l")
        Application.Exit()
    End Sub

    Private Sub RestartBtn_Click() Handles RestartBtn.Click
        Shell("shutdown -r")
        AbortBtn.Enabled = True
        AbortBtn.Focus()
        LogOffBtn.Enabled = False
        RestartBtn.Enabled = False
        ShutDownBtn.Enabled = False
        HibernateBtn.Enabled = False
        StandByBtn.Enabled = False
    End Sub

    Private Sub ShutDownBtn_Click() Handles ShutDownBtn.Click
        Shell("shutdown -s")
        AbortBtn.Enabled = True
        AbortBtn.Focus()
        LogOffBtn.Enabled = False
        RestartBtn.Enabled = False
        ShutDownBtn.Enabled = False
        HibernateBtn.Enabled = False
        StandByBtn.Enabled = False
    End Sub

    Private Sub HibernateBtn_Click() Handles HibernateBtn.Click
        Application.SetSuspendState(PowerState.Hibernate, False, False)
        Application.Exit()
    End Sub

    Private Sub StandByBtn_Click() Handles StandByBtn.Click
        Application.SetSuspendState(PowerState.Suspend, False, False)
        Application.Exit()
    End Sub

    Private Sub AbortBtn_Click() Handles AbortBtn.Click
        Shell("shutdown -a")
        AbortBtn.Enabled = False
        LogOffBtn.Enabled = True
        RestartBtn.Enabled = True
        ShutDownBtn.Enabled = True
        HibernateBtn.Enabled = True
        StandByBtn.Enabled = True
    End Sub

    Private Sub ExitBtn_Click() Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(ClientRectangle, Color.Gray, Color.DarkRed, Drawing2D.LinearGradientMode.Vertical), ClientRectangle)
    End Sub
End Class
