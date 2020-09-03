Public Class Form1
    Private Randomizer As New Random
    Private multiplier As Integer = 50

    Private addEnd1 As Integer
    Private addEnd2 As Integer
    Private diffEnd1 As Integer
    Private diffEnd2 As Integer
    Private multEnd1 As Integer
    Private multEnd2 As Integer
    Private divEnd1 As Integer
    Private divEnd2 As Integer

    Private timeLeft As Integer

    Public Sub startTheQuiz()

        sum.Value = 0
        diff.Value = 0
        prod.Value = 0
        division.Value = 0

        addEnd1 = Randomizer.Next(multiplier)
        addEnd2 = Randomizer.Next(multiplier)
        Do
            diffEnd1 = Randomizer.Next(multiplier)
            diffEnd2 = Randomizer.Next(multiplier)
        Loop Until diffEnd1 > diffEnd2

        multEnd1 = Randomizer.Next(multiplier / 8)
        multEnd2 = Randomizer.Next(multiplier / 8)

        Do
            divEnd1 = Randomizer.Next(multiplier) + 10
            divEnd2 = Randomizer.Next(multiplier) + 5
        Loop Until divEnd1 Mod divEnd2 = 0

        plusLeftLabel.Text = addEnd1.ToString
        plusRightLabel.Text = addEnd2.ToString

        minusLeft.Text = diffEnd1.ToString
        minusRight.Text = diffEnd2.ToString

        multLeft.Text = multEnd1.ToString
        multRight.Text = multEnd2.ToString

        divLeft.Text = divEnd1.ToString
        divRight.Text = divEnd2.ToString

        timeLeft = 30

        Timer1.Start()
    End Sub

    Private Function checkTheAnswer() As Boolean
        If addEnd1 + addEnd2 = sum.Value AndAlso diffEnd1 - diffEnd2 = diff.Value AndAlso
             multEnd1 * multEnd2 = prod.Value AndAlso divEnd1 / divEnd2 = division.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startTheQuiz()
        Button1.Enabled = False
        lblTimeLeft.Text = "30 seconds"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If checkTheAnswer() Then
            Timer1.Stop()
            MessageBox.Show("Congratulations, you typed good answer", "Congratulations!")
            Dim response = MsgBox("Do you want to try harder?", MsgBoxStyle.YesNo, "Another game")
            If response = MsgBoxResult.Yes Then
                multiplier += 50
                startTheQuiz()
            End If
        ElseIf timeLeft > 0 Then
            timeLeft -= 1
            lblTimeLeft.Text = timeLeft & " seconds"
        Else
            Timer1.Stop()
            lblTimeLeft.Text = "Time's up!"
            MessageBox.Show("You lost", "Sorry")
            Button1.Enabled = True
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim response = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Quit")

        If response = MsgBoxResult.Yes Then
            End
        Else
            Timer1.Stop()
            MsgBox("Click OK to start new game", , "New Game")
            Button1.Enabled = True
        End If
    End Sub
End Class
