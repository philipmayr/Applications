Public Class Main

    Private G As Graphics, R As New Random(), MouseIsActive As Boolean, MouseLocation As Point, I As Integer = R.Next(2)

    Private Sub Main_KeyDown() Handles Me.KeyDown
        G.Dispose()
        Application.Exit()
    End Sub

    Private Sub Main_Load() Handles Me.Load
        G = CreateGraphics()
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Timer.Enabled = True
        Cursor.Hide()
    End Sub

    Private Sub Main_MouseDown() Handles Me.MouseDown
        G.Dispose()
        Application.Exit()
    End Sub

    Private Sub Main_MouseMove() Handles Me.MouseMove
        If Not MouseIsActive Then
            MouseLocation = New Point(MousePosition.X, MousePosition.Y)
            MouseIsActive = True
        Else
            If Math.Abs(MousePosition.X - MouseLocation.X) >= 10 OrElse Math.Abs(MousePosition.Y - MouseLocation.Y) >= 10 Then
                G.Dispose()
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Timer_Tick() Handles Timer.Tick
        Dim x1, x2, y1, y2 As Integer, Rect As Rectangle, Color As Color

        x1 = R.Next(0, Width)
        x2 = R.Next(0, Width)

        y1 = R.Next(0, Height)
        y2 = R.Next(0, Height)

        Rect = New Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2))

        Color = Color.FromArgb(R.Next(256), R.Next(256), R.Next(256), R.Next(256))

        If I = 0 Then G.FillRectangle(New SolidBrush(Color), Rect) Else G.FillEllipse(New SolidBrush(Color), Rect)
    End Sub
End Class
