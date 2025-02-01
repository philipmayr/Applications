Public Class Game

    Private randomizer As New Random

    Private addend1, addend2, minuend, subtrahend, multiplicand, multiplier, dividend, divisor, timeleft As Integer

    Private correct As New Media.SoundPlayer("C:\Windows\Media\tada.wav"), incorrect As New Media.SoundPlayer("C:\Windows\Media\chord.wav")

    Public Sub StartTheQuiz()
        timeLabel.ForeColor = Color.Black
        sum.ForeColor = Color.Black
        difference.ForeColor = Color.Black
        product.ForeColor = Color.Black
        quotient.ForeColor = Color.Black

        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)
        plusLeftLabel.Text = addend1.ToString()
        plusRightLabel.Text = addend2.ToString()
        sum.Value = 0

        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString()
        minusRightLabel.Text = subtrahend.ToString()
        difference.Value = 0

        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        timesLeftLabel.Text = multiplicand.ToString()
        timesRightLabel.Text = multiplier.ToString()
        product.Value = 0

        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient
        dividedLeftLabel.Text = dividend.ToString()
        dividedRightLabel.Text = divisor.ToString()
        quotient.Value = 0

        timeleft = 30
        timeLabel.Text = "30 seconds"
        Timer.Start()
    End Sub

    Private Sub startButton_Click() Handles startButton.Click
        timeLabel.Enabled = True
        sum.Enabled = True
        difference.Enabled = True
        product.Enabled = True
        quotient.Enabled = True
        StartTheQuiz()
        startButton.Enabled = False
    End Sub

    Private Sub Timer_Tick() Handles Timer.Tick
        If timeLeft < 7 Then timeLabel.ForeColor = Color.Red
        If CheckTheAnswer() Then
            Timer.Stop()
            correct.Play()
            MessageBox.Show("You got all of the answers right!", "Congratulations!")
            timeLabel.Enabled = False
            sum.Enabled = False
            difference.Enabled = False
            product.Enabled = False
            quotient.Enabled = False
            startButton.Enabled = True
            startButton.Focus()
        ElseIf timeLeft > 0 Then
            timeLeft -= 1
            timeLabel.Text = timeLeft & " seconds"
        Else
            Timer.Stop()
            incorrect.Play()
            timeLabel.Text = "Time's Up!"
            MessageBox.Show("You didn't finish in time.", "Sorry")
            sum.Value = addend1 + addend2
            difference.Value = minuend - subtrahend
            product.Value = multiplicand * multiplier
            quotient.Value = CDec(dividend / divisor)
            timeLabel.Enabled = False
            sum.Enabled = False
            difference.Enabled = False
            product.Enabled = False
            quotient.Enabled = False
            startButton.Enabled = True
            startButton.Enabled = True
            startButton.Focus()
        End If
    End Sub

    Public Function CheckTheAnswer() As Boolean
        If addend1 + addend2 = sum.Value AndAlso
            minuend - subtrahend = difference.Value AndAlso
            multiplicand * multiplier = product.Value AndAlso
            dividend / divisor = quotient.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub answer_Enter(sender As Object, e As EventArgs) Handles sum.Enter, difference.Enter, product.Enter, quotient.Enter
        Dim answerBox = TryCast(sender, NumericUpDown)
        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If
    End Sub

    Private Sub sum_TextChanged() Handles sum.TextChanged
        sum.ForeColor = If(addend1 + addend2 = sum.Value, Color.Green, Color.Black)
    End Sub

    Private Sub difference_TextChanged() Handles difference.TextChanged
        difference.ForeColor = If(minuend - subtrahend = difference.Value, Color.Green, Color.Black)
    End Sub

    Private Sub product_TextChanged() Handles product.TextChanged
        product.ForeColor = If(multiplicand * multiplier = product.Value, Color.Green, Color.Black)
    End Sub

    Private Sub quotient_TextChanged() Handles quotient.TextChanged
        quotient.ForeColor = If(dividend / divisor = quotient.Value, Color.Green, Color.Black)
    End Sub
End Class
