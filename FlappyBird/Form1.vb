Public Class Form1
    Dim intT As Integer = 0 'bird goinig faster #see tmrBird
    Dim intP As Integer = 0 'points
    Dim space As Boolean

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Pause
        If lblPlay.Visible = False And
            e.KeyCode = Keys.P Then
            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            tmrBirdDown.Stop()
            lblPPause.Visible = False
            lblPause.Visible = True
            lblSA.Visible = True
        End If

        'Start after pause
        If lblPause.Visible = True And
        e.KeyCode = Keys.S Then
            tmrObstakel.Start()
            tmrObstakel2.Start()
            tmrControle.Start()
            tmrBirdDown.Start()
            lblPPause.Visible = True
            lblPause.Visible = False
            lblSA.Visible = False

        End If

        'Bird UP
        If picBird.Top > picTop.Top And
            picBird.Bottom < picGround.Top And
            lblPlay.Visible = False And
            lblPause.Visible = False And
            e.KeyCode = Keys.Space Then
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
        If lblPlay.Visible = True And
            e.KeyCode = Keys.Space Then
            intP = 0
            intT = 0
            lblPunten.Text = CStr(intP)
            picGameOver.Visible = False
            Dim B1 As New Point
            B1.X = picBird.Location.X
            B1.Y = 190
            picBird.Location = B1
            tmrRnd.Start()
            tmrBirdDown.Start()
            tmrControle.Start()
            'Dim obstakles2 as new point to start
            Dim rndB2 As New Random
            Dim pntB2 As New Point
            Dim pntB22 As New Point
            Dim intB2 As Integer
            intB2 = rndB2.Next(20, 300)
            pntB2.X = 460
            pntB2.Y = intB2
            pntB22.X = 460
            pntB22.Y = intB2 + 110

            Dim obstakelH2 As New Point(460, 0)
            Dim obstakelD2 As New Point(460, intB2)
            Dim obstakelDH2 As New Point(460, intB2)
            Dim obstakelDL2 As New Point(460, intB2 + 110)
            picObstakelDoorgangH2.Location = obstakelDH2
            picObstakelHeel2.Location = obstakelH2
            picObstakelDoorgangHH2.Location = obstakelDH2
            picObstakelDoorgangHL2.Location = obstakelDL2

            picObstakelDoorgangH2.Visible = False
            picObstakelDoorgangHH2.Visible = False
            picObstakelDoorgangHL2.Visible = False
            picObstakelHeel2.Visible = False

            'Dim obstakles as new point to start
            Dim rndB As New Random
            Dim pntB As New Point
            Dim pntB21 As New Point
            Dim intB As Integer
            intB = rndB.Next(20, 300)
            pntB.X = 460
            pntB.Y = intB
            pntB21.X = 460
            pntB21.Y = intB + 110

            Dim obstakelH As New Point(460, 0)
            Dim obstakelD As New Point(460, intB)
            Dim obstakelDH As New Point(460, intB)
            Dim obstakelDL As New Point(460, intB + 110)
            picObstakelDoorgangH.Location = obstakelDH
            picObstakelHeel.Location = obstakelH
            picObstakelDoorgangHH.Location = obstakelDH
            picObstakelDoorgangHL.Location = obstakelDL

            'Lbl's visible = False except PAUSE
            lblPlay.Visible = False
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
            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            tmrBirdDown.Stop()
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblPlay.Visible = True
            lblSpace.Visible = True
            ' If bird touch ground proccess if tmrControle is in proccess
        ElseIf picBird.Bottom >= picGround.Top And
            tmrControle.Enabled = False Then
            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            tmrBirdDown.Stop()
        End If
    End Sub

    Private Sub tmrRnd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRnd.Tick
        'Point of obstakle
        Dim rndB As New Random
        Dim pntB As New Point
        Dim pntB2 As New Point
        Dim intB As Integer
        intB = rndB.Next(10, 415)
        pntB.X = 460
        pntB.Y = intB
        pntB2.X = 460
        pntB2.Y = intB + 110

        If intB = picObstakelDoorgangHH.Location.Y Then
        Else
            picObstakelDoorgangH.Location = New Point(460, intB)
            picObstakelDoorgangHH.Location = New Point(460, intB)
            picObstakelDoorgangHL.Location = New Point(460, intB + 110)
            picObstakelHeel.Location = New Point(460, 0)
            tmrObstakel.Start()
            tmrRnd.Stop()
        End If


    End Sub

    Private Sub tmrObstakel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrObstakel.Tick

        'Obstakle position
        Dim intB, intX As Integer
        intB = picObstakelDoorgangH.Location.Y
        intX = picObstakelDoorgangH.Location.X
        If picObstakelDoorgangH.Location.X = 0 Then
            tmrRnd.Start()
            tmrObstakel.Stop()

        Else
            'Obstakle movement
            intX -= 2
        End If

        Dim obstakelH As New Point(intX, 0)
        Dim obstakelD As New Point(intX, intB)
        Dim obstakelDH As New Point(intX, intB)
        Dim obstakelDL As New Point(intX, intB + 110)

        picObstakelDoorgangH.Location = obstakelDH
        picObstakelHeel.Location = obstakelH
        picObstakelDoorgangHH.Location = obstakelDH
        picObstakelDoorgangHL.Location = obstakelDL

        'Obstakle 2 start
        If picObstakelDoorgangH.Location.X = 230 Then
            picObstakelDoorgangH2.Visible = True
            picObstakelDoorgangHH2.Visible = True
            picObstakelDoorgangHL2.Visible = True
            picObstakelHeel2.Visible = True
            tmrRnd2.Start()
        End If

    End Sub

    Private Sub tmrRnd2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRnd2.Tick
        'Obstakle2 position
        Dim rndB As New Random
        Dim pntB As New Point
        Dim pntB2 As New Point
        Dim intB As Integer
        intB = rndB.Next(10, 415)
        pntB.X = 460
        pntB.Y = intB
        pntB2.X = 460
        pntB2.Y = intB + 110

        If intB = picObstakelDoorgangHH2.Location.Y Then
        Else
            picObstakelDoorgangH2.Location = New Point(460, intB)
            picObstakelDoorgangHH2.Location = New Point(460, intB)
            picObstakelDoorgangHL2.Location = New Point(460, intB + 110)
            picObstakelHeel2.Location = New Point(460, 0)
            tmrObstakel2.Start()
            tmrRnd2.Stop()
        End If
    End Sub

    Private Sub tmrObstakel2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrObstakel2.Tick
        'IDEM as tmrObstakel1
        Dim intB, intX As Integer
        intB = picObstakelDoorgangH2.Location.Y
        intX = picObstakelDoorgangH2.Location.X
        If picObstakelDoorgangH2.Location.X = 0 Then
            tmrRnd2.Start()
            tmrObstakel2.Stop()
        Else
            intX -= 2
        End If

        Dim obstakelH As New Point(intX, 0)
        Dim obstakelD As New Point(intX, intB)
        Dim obstakelDH As New Point(intX, intB)
        Dim obstakelDL As New Point(intX, intB + 110)

        picObstakelDoorgangH2.Location = obstakelDH
        picObstakelHeel2.Location = obstakelH
        picObstakelDoorgangHH2.Location = obstakelDH
        picObstakelDoorgangHL2.Location = obstakelDL


    End Sub

    Private Sub tmrControle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrControle.Tick
        'controls position bird and obstakle1

        If picBird.Top < picObstakelDoorgangHH.Top And
            picBird.Left <= picObstakelDoorgangH.Left And
            picBird.Right >= picObstakelDoorgangH.Right And
            picBird.Right >= picObstakelDoorgangH.Left And
            picBird.Left <= picObstakelDoorgangH.Right Or
            picBird.Bottom > picObstakelDoorgangHL.Bottom And
            picBird.Left <= picObstakelDoorgangH.Left And
            picBird.Right >= picObstakelDoorgangH.Right And
            picBird.Right >= picObstakelDoorgangH.Left And
            picBird.Left <= picObstakelDoorgangH.Right Then
            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picGameOver.Visible = False
            lblPlay.Visible = True
            lblSpace.Visible = True
        ElseIf picBird.Top <= picObstakelDoorgangHH.Top And
           picBird.Right = picObstakelDoorgangH.Left Or
           picBird.Right = picObstakelDoorgangH.Left And
           picBird.Bottom >= picObstakelDoorgangHL.Bottom Then

            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picGameOver.Visible = False
            lblPlay.Visible = True
            lblSpace.Visible = True

        ElseIf picBird.Top <= picObstakelDoorgangHH.Top And
            picBird.Left = picObstakelDoorgangH.Right Or
            picBird.Left = picObstakelDoorgangH.Right And
            picBird.Bottom >= picObstakelDoorgangHL.Bottom Then

            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picGameOver.Visible = False
            lblPlay.Visible = True
            lblSpace.Visible = True
        End If

        If picBird.Left = picObstakelDoorgangH.Right Then
            intP += 1
            lblPunten.Text = CStr(intP)
        End If

        'IDEM for second obstakle
        If picBird.Top < picObstakelDoorgangHH2.Top And
           picBird.Left <= picObstakelDoorgangH2.Left And
           picBird.Right >= picObstakelDoorgangH2.Right And
           picBird.Right >= picObstakelDoorgangH2.Left And
           picBird.Left <= picObstakelDoorgangH2.Right Or
           picBird.Bottom > picObstakelDoorgangHL2.Bottom And
           picBird.Left <= picObstakelDoorgangH2.Left And
           picBird.Right >= picObstakelDoorgangH2.Right And
           picBird.Right >= picObstakelDoorgangH2.Left And
           picBird.Left <= picObstakelDoorgangH2.Right Then
            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picGameOver.Visible = False
            lblPlay.Visible = True
            lblSpace.Visible = True
        ElseIf picBird.Top <= picObstakelDoorgangHH2.Top And
           picBird.Right = picObstakelDoorgangH2.Left Or
           picBird.Right = picObstakelDoorgangH2.Left And
           picBird.Bottom >= picObstakelDoorgangHL2.Bottom Then

            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picGameOver.Visible = False
            lblPlay.Visible = True
            lblSpace.Visible = True

        ElseIf picBird.Top <= picObstakelDoorgangHH2.Top And
            picBird.Left = picObstakelDoorgangH2.Right Or
            picBird.Left = picObstakelDoorgangH2.Right And
            picBird.Bottom >= picObstakelDoorgangHL2.Bottom Then

            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrControle.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picGameOver.Visible = False
            lblPlay.Visible = True
            lblSpace.Visible = True
        End If

        If picBird.Left = picObstakelDoorgangH2.Right Then
            intP += 1
            lblPunten.Text = CStr(intP)
        End If

        'Hold bird in form
     
        If picBird.Bottom >= picGround.Top And
              tmrBirdDown.Enabled = True Then
            tmrRnd.Stop()
            tmrRnd2.Stop()
            tmrObstakel.Stop()
            tmrObstakel2.Stop()
            tmrBirdDown.Stop()
            tmrControle.Stop()
            picGameOver.Visible = True
            MessageBox.Show("Score: " & intP, "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picGameOver.Visible = False
            lblPlay.Visible = True
            lblSpace.Visible = True


            If picBird.Top < picTop.Top Then

                Dim pntB As New Point
                pntB.X = picBird.Location.X
                pntB.Y = 10
                picBird.Location = pntB
            End If
        End If

    End Sub

    Private Sub lblPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlay.Click
        intP = 0
        intT = 0
        lblPunten.Text = CStr(intP)
        picGameOver.Visible = False
        Dim B1 As New Point
        B1.X = picBird.Location.X
        B1.Y = 190
        picBird.Location = B1
        tmrRnd.Start()
        tmrBirdDown.Start()
        tmrControle.Start()
        '
        Dim rndB2 As New Random
        Dim pntB2 As New Point
        Dim pntB22 As New Point
        Dim intB2 As Integer
        intB2 = rndB2.Next(20, 300)
        pntB2.X = 460
        pntB2.Y = intB2
        pntB22.X = 460
        pntB22.Y = intB2 + 110

        Dim obstakelH2 As New Point(460, 0)
        Dim obstakelD2 As New Point(460, intB2)
        Dim obstakelDH2 As New Point(460, intB2)
        Dim obstakelDL2 As New Point(460, intB2 + 110)
        picObstakelDoorgangH2.Location = obstakelDH2
        picObstakelHeel2.Location = obstakelH2
        picObstakelDoorgangHH2.Location = obstakelDH2
        picObstakelDoorgangHL2.Location = obstakelDL2

        picObstakelDoorgangH2.Visible = False
        picObstakelDoorgangHH2.Visible = False
        picObstakelDoorgangHL2.Visible = False
        picObstakelHeel2.Visible = False
        '
        Dim rndB As New Random
        Dim pntB As New Point
        Dim pntB21 As New Point
        Dim intB As Integer
        intB = rndB.Next(20, 300)
        pntB.X = 460
        pntB.Y = intB
        pntB21.X = 460
        pntB21.Y = intB + 110

        Dim obstakelH As New Point(460, 0)
        Dim obstakelD As New Point(460, intB)
        Dim obstakelDH As New Point(460, intB)
        Dim obstakelDL As New Point(460, intB + 110)
        picObstakelDoorgangH.Location = obstakelDH
        picObstakelHeel.Location = obstakelH
        picObstakelDoorgangHH.Location = obstakelDH
        picObstakelDoorgangHL.Location = obstakelDL

        '
        lblPPause.Visible = True
        lblPlay.Visible = False
        lblSpace.Visible = False
    End Sub
    Private Sub MadeBy()
        'Made by Bram
        'Belgium
    End Sub
End Class


