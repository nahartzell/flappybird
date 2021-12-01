Public Class frmFlappyBird
    Dim intT As Integer = 0 'bird goinig faster #see tmrBird
    Dim intP As Integer = 0 'points
    Dim space As Boolean

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Pause
        If e.KeyCode = Keys.P Then
            tmrPipeL1.Stop()
            tmrPipeL1.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            tmrControle.Stop()
            tmrBirdDown.Stop()
            lblPPause.Visible = False
            lblPause.Visible = True
            lblSA.Visible = True
        End If

        'Start after pause
        If lblPause.Visible = True And
        e.KeyCode = Keys.S Then
            tmrPipeL1.Start()
            tmrPipeL1.Start()
            tmrPipe1Move.Start()
            tmrPipe2Move.Start()
            tmrControle.Start()
            tmrBirdDown.Start()
            lblPPause.Visible = True
            lblPause.Visible = False
            lblSA.Visible = False

        End If

        'Bird UP
        If picBird.Top > picTop.Top And
            picBird.Bottom < picGround.Top And
            lblPause.Visible = False And
            e.KeyCode = Keys.Space Then
            My.Computer.Audio.Play(My.Resources.JumpSound, AudioPlayMode.Background)
            Dim B1, B2, B3, B4 As New Point
            tmrBirdDown.Stop()
            Dim intY1 As Integer
            intY1 = picBird.Location.Y
            B1.X = picBird.Location.X
            B1.Y = intY1 - 50
            intY1 = B1.Y - 50
            picBird.Location = B1
            intT = 0
            tmrBirdDown.Start()
        End If

        'Start game with Spacebar
        If lblSpace.Visible = True And
             e.KeyCode = Keys.Space Then
            picPipeDown2.Visible = False
            picPipeUp2.Visible = False
            intP = 0
            intT = 0
            lblPunten.Text = CStr(intP)
            picGameOver.Visible = False
            Dim B1 As New Point
            B1.X = picBird.Location.X
            B1.Y = 190
            picBird.Location = B1

            Dim rndU1 As New Random
            Dim intU1, intD1 As Integer
            intU1 = rndU1.Next(-310, 1)
            intD1 = intU1 + 440
            Dim pipeU1 As New Point(460, intU1)
            Dim pipeD1 As New Point(460, intD1)
            picPipeUp1.Location = pipeU1
            picPipeDown1.Location = pipeD1

            Dim rndU2 As New Random
            Dim intU2, intD2 As Integer
            intU2 = rndU2.Next(-320, 1)
            intD2 = intU2 + 440
            Dim pipeU2 As New Point(460, intU2)
            Dim pipeD2 As New Point(460, intD2)

            picPipeUp2.Location = pipeU2
            picPipeDown2.Location = pipeD2

            tmrPipeL1.Start()
            tmrBirdDown.Start()
            tmrControle.Start()
            'Lbl's visible = False except PAUSE
            lblSpace.Visible = False
            lblPPause.Visible = True
        End If
    End Sub

    Private Sub tmrBirdDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBirdDown.Tick
        'This is intT for birdspeeddown increment
        intT = intT + 1

        Dim Bird1 As New Point
        'Position of picBird (y)
        Dim intY1 As Integer
        'Bird down
        intY1 = picBird.Location.Y
        Bird1.X = picBird.Location.X
        Bird1.Y = intY1 + 1

        intY1 = Bird1.Y + 1
        picBird.Location = Bird1

        'Here the birdspeedfalldown increase
        If intT > 50 Then
            intY1 = picBird.Location.Y
            Bird1.X = picBird.Location.X
            Bird1.Y = intY1 + 3

            intY1 = Bird1.Y + 3
            picBird.Location = Bird1

        End If

        'If bird touch ground process if tmrControle is not in process
        If picBird.Bottom >= picGround.Top And
            tmrControle.Enabled = True Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
            ' If bird touch ground proccess if tmrControle is in proccess
        ElseIf picBird.Bottom >= picGround.Top And
            tmrControle.Enabled = False Then
            tmrControle.Stop()
            tmrBirdDown.Stop()
        End If


        If picGameOver.Visible = True Then
            Me.BackColor = Color.Red
            My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
        Else : Me.BackColor = Color.LightSkyBlue
        End If
    End Sub

    Private Sub tmrControle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrControle.Tick



        If picBird.Top <= picPipeUp1.Bottom And
                    picPipeUp1.Right >= picBird.Right And
                    picPipeUp1.Left <= picBird.Left Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Bottom >= picPipeDown1.Top And
                     picPipeUp1.Right >= picBird.Right And
                      picPipeUp1.Left <= picBird.Left Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Top <= picPipeUp2.Bottom And
             picPipeUp2.Right >= picBird.Right And
                  picPipeUp2.Left <= picBird.Left Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Bottom >= picPipeDown2.Top And
             picPipeUp2.Right >= picBird.Right And
                   picPipeUp2.Left <= picBird.Left Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True


            'Left/right touch
        ElseIf picBird.Right = picPipeUp1.Left And
            picBird.Top <= picPipeUp1.Bottom Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Right = picPipeDown1.Left And
        picBird.Bottom >= picPipeDown1.Top Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True

        ElseIf picBird.Right = picPipeDown2.Left And
  picBird.Bottom >= picPipeDown2.Top Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Right = picPipeUp2.Left And
            picBird.Top <= picPipeUp2.Bottom Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True

        ElseIf picBird.Left = picPipeUp1.Right And
        picBird.Top <= picPipeUp1.Bottom Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True

        ElseIf picBird.Left = picPipeUp2.Right And
    picBird.Top <= picPipeUp2.Bottom Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Left = picPipeDown1.Right And
    picBird.Bottom >= picPipeDown1.Top Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Left = picPipeDown2.Right And
    picBird.Bottom >= picPipeDown2.Top Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True

        ElseIf picBird.Right = picPipeUp1.Right And
picBird.Top <= picPipeUp1.Bottom Then

            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Right = picPipeDown1.Right And
picBird.Bottom >= picPipeDown1.Top Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Right = picPipeUp2.Right And
picBird.Top <= picPipeUp2.Bottom Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        ElseIf picBird.Right = picPipeDown2.Right And
picBird.Bottom >= picPipeDown2.Top Then
            tmrControle.Stop()
            tmrPipeL1.Stop()
            tmrPipeL2.Stop()
            tmrPipe1Move.Stop()
            tmrPipe2Move.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Game over" & vbNewLine & "Your score: " & intP, "Game over")
            picGameOver.Visible = False
            lblSpace.Visible = True
        End If

        If picBird.Left = picPipeUp1.Right Or
            picBird.Left = picPipeUp2.Right Then
            intP += 1
            My.Computer.Audio.Play(My.Resources.PointSound, AudioPlayMode.Background)
        End If

        lblPunten.Text = CStr(intP)
    End Sub

    Private Sub tmrPipeL1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPipeL1.Tick
        Dim pipeU1, pipeD1 As New Point
        Dim rndU1 As New Random
        Dim intU1, intD1 As Integer
        intU1 = rndU1.Next(-310, 1)
        intD1 = intU1 + 440
        pipeU1.X = 460
        pipeU1.Y = intU1
        pipeD1.X = 460
        pipeD1.Y = intD1

        picPipeUp1.Location = pipeU1
        picPipeDown1.Location = pipeD1
        tmrPipe1Move.Start()

    End Sub


    Private Sub tmrPipe1Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPipe1Move.Tick
        tmrPipeL1.Stop()
        Dim pipe1, pipe2 As New Point
        pipe1.X = picPipeUp1.Location.X
        pipe1.Y = picPipeUp1.Location.Y
        pipe1.X -= 2
        picPipeUp1.Location = pipe1
        pipe2.X = picPipeDown1.Location.X
        pipe2.Y = picPipeDown1.Location.Y
        pipe2.X -= 2
        picPipeDown1.Location = pipe2

        If pipe1.X = 230 Then
            picPipeDown2.Show()
            picPipeUp2.Show()
            tmrPipeL2.Start()
        End If
        If picPipeDown1.Location.X = 0 Then
            tmrPipeL1.Start()
        End If
    End Sub

    Private Sub tmrPipe2Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPipe2Move.Tick
        tmrPipeL2.Stop()
        Dim pipe2, pipe3 As New Point
        pipe2.X = picPipeUp2.Location.X
        pipe2.Y = picPipeUp2.Location.Y
        pipe2.X -= 2
        picPipeUp2.Location = pipe2
        pipe3.X = picPipeDown2.Location.X
        pipe3.Y = picPipeDown2.Location.Y
        pipe3.X -= 2
        picPipeDown2.Location = pipe3

        If picPipeDown2.Location.X = 0 Then
            tmrPipeL2.Start()
        End If
    End Sub

    Private Sub tmrPipeL2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPipeL2.Tick
        Dim pipeU2, pipeD2 As New Point
        Dim rndU2 As New Random
        Dim intU2, intD2 As Integer
        intU2 = rndU2.Next(-320, 1)
        intD2 = intU2 + 440
        pipeU2.X = 460
        pipeU2.Y = intU2
        pipeD2.X = 460
        pipeD2.Y = intD2

        picPipeUp2.Location = pipeU2
        picPipeDown2.Location = pipeD2
        tmrPipe2Move.Start()
    End Sub


    Private Sub MadeBy()
        'Made by Bram
        'Belgium
    End Sub

  
End Class


