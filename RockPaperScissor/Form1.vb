Public Class Form1
    Dim iComputer As Integer = 0
    Private iWins As Integer = 0
    Private iDraw As Integer = 0
    Private iLose As Integer = 0

    Private Sub btnRock_Click(sender As System.Object, e As System.EventArgs) Handles btnRock.Click
        lblPlayer.Text = "Rock"
        picPlayer.Image = WindowsApplication1.My.Resources.Resources.rock
        iComputer = CInt(Math.Floor((3 - 1 + 1) * Rnd())) + 1
        lblComputer.Text = iComputer
        If iComputer = 1 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.paper
            lblComputer.Text = "Paper"
            lblScore.Text = "You lose!"
            iLose = iLose + 1
        End If
        If iComputer = 2 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.rock
            lblComputer.Text = "Rock"
            lblScore.Text = "Draw!"
            iDraw = iDraw + 1
        End If
        If iComputer = 3 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.scissor
            lblComputer.Text = "Scissor"
            lblScore.Text = "You win!"
            iWins = iWins + 1
        End If
        lblWins1.Text = iWins
        lblDraw1.Text = iDraw
        lblLose1.Text = iLose
    End Sub

    Private Sub btnPaper_Click(sender As System.Object, e As System.EventArgs) Handles btnPaper.Click
        lblPlayer.Text = "Paper"
        picPlayer.Image = WindowsApplication1.My.Resources.Resources.paper
        iComputer = CInt(Math.Floor((3 - 1 + 1) * Rnd())) + 1
        lblComputer.Text = iComputer

        If iComputer = 1 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.paper
            lblComputer.Text = "Paper"
            lblScore.Text = "Draw!"
            iDraw = iDraw + 1
        End If
        If iComputer = 2 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.rock
            lblComputer.Text = "Rock"
            lblScore.Text = "You win!"
            iWins = iWins + 1
        End If
        If iComputer = 3 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.scissor
            lblComputer.Text = "Scissor"
            lblScore.Text = "You lose!"
            iLose = iLose + 1
        End If
        lblWins1.Text = iWins
        lblDraw1.Text = iDraw
        lblLose1.Text = iLose
    End Sub

    Private Sub btnScissor_Click(sender As System.Object, e As System.EventArgs) Handles btnScissor.Click
        lblPlayer.Text = "Scissor"
        picPlayer.Image = WindowsApplication1.My.Resources.Resources.scissor
        iComputer = CInt(Math.Floor((3 - 1 + 1) * Rnd())) + 1
        lblComputer.Text = iComputer
        lblWins1.Text = iWins
        lblDraw1.Text = iDraw
        lblLose1.Text = iLose
        If iComputer = 1 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.paper
            lblComputer.Text = "Paper"
            lblScore.Text = "You win!"
            iWins = iWins + 1
        End If
        If iComputer = 2 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.rock
            lblComputer.Text = "Rock"
            lblScore.Text = "You lose!"
            iLose = iLose + 1
        End If
        If iComputer = 3 Then
            picComputer.Image = WindowsApplication1.My.Resources.Resources.scissor
            lblComputer.Text = "Scissor"
            lblScore.Text = "Draw!"
            iDraw = iDraw + 1
        End If
        lblWins1.Text = iWins
        lblDraw1.Text = iDraw
        lblLose1.Text = iLose
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        iLose = 0
        iDraw = 0
        iWins = 0
        lblWins1.Text = iWins
        lblDraw1.Text = iDraw
        lblLose1.Text = iLose
        lblPlayer.Text = ""
        lblComputer.Text = ""
        picComputer.Image = Nothing
        picPlayer.Image = Nothing
        lblScore.Text = ""
    End Sub
End Class

