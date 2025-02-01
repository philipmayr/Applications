Public Class Main

    Private InkOverlay As Microsoft.Ink.InkOverlay

    Public Sub New()
        InitializeComponent()

        InkOverlay = New Microsoft.Ink.InkOverlay(InkCanvas)
        InkOverlay.Enabled = True
    End Sub

    Private Sub ClearBtn_Click() Handles ClearButton.Click
        InkOverlay.Ink.DeleteStrokes()
        InkCanvas.Invalidate()
    End Sub

    Private Sub CloseBtn_Click() Handles CloseButton.Click
        Close()
    End Sub
End Class
