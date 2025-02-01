Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If e.IsNetworkAvailable Then MessageBox.Show("Connected", "Network", MessageBoxButtons.OK, MessageBoxIcon.Information) Else MessageBox.Show("Not Connected", "Network", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Sub

        Private Sub MyApplication_Startup() Handles Me.Startup
            If Not My.Computer.Network.IsAvailable Then MessageBox.Show("Not Connected", "Network", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False
            MessageBox.Show(e.Exception.Message, "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class


End Namespace

