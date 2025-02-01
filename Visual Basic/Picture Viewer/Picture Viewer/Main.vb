Public Class Main

    Private Sub showButton_Click() Handles showButton.Click
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then PictureBox.Load(OpenFileDialog.FileName)
    End Sub

    Private Sub clearButton_Click() Handles clearButton.Click
        PictureBox.Image = Nothing
    End Sub

    Private Sub backgroundButton_Click() Handles backgroundButton.Click
        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then PictureBox.BackColor = ColorDialog.Color
    End Sub

    Private Sub closeButton_Click() Handles closeButton.Click
        Close()
    End Sub

    Private Sub CheckBox_CheckedChanged() Handles CheckBox.CheckedChanged
        PictureBox.SizeMode = If(CheckBox.Checked, PictureBoxSizeMode.StretchImage, PictureBoxSizeMode.Normal)
    End Sub
End Class
