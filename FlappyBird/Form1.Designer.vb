<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.tmrBirdDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRnd = New System.Windows.Forms.Timer(Me.components)
        Me.tmrObstakel = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRnd2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrObstakel2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrControle = New System.Windows.Forms.Timer(Me.components)
        Me.lblPunten = New System.Windows.Forms.Label()
        Me.lblSpace = New System.Windows.Forms.Label()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.lblPPause = New System.Windows.Forms.Label()
        Me.lblSA = New System.Windows.Forms.Label()
        Me.picGameOver = New System.Windows.Forms.PictureBox()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picObstakelDoorgangH2 = New System.Windows.Forms.PictureBox()
        Me.picObstakelDoorgangHL2 = New System.Windows.Forms.PictureBox()
        Me.picObstakelDoorgangHH2 = New System.Windows.Forms.PictureBox()
        Me.picObstakelDoorgangH = New System.Windows.Forms.PictureBox()
        Me.picObstakelDoorgangHL = New System.Windows.Forms.PictureBox()
        Me.picObstakelDoorgangHH = New System.Windows.Forms.PictureBox()
        Me.picObstakelHeel2 = New System.Windows.Forms.PictureBox()
        Me.picObstakelHeel = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picTop = New System.Windows.Forms.PictureBox()
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelDoorgangH2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelDoorgangHL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelDoorgangHH2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelDoorgangH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelDoorgangHL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelDoorgangHH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelHeel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstakelHeel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlay
        '
        Me.lblPlay.AutoSize = True
        Me.lblPlay.BackColor = System.Drawing.Color.DarkGray
        Me.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlay.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay.Location = New System.Drawing.Point(189, 187)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(98, 46)
        Me.lblPlay.TabIndex = 0
        Me.lblPlay.Text = "Play"
        '
        'tmrBirdDown
        '
        Me.tmrBirdDown.Interval = 2
        '
        'tmrRnd
        '
        Me.tmrRnd.Interval = 1
        '
        'tmrObstakel
        '
        Me.tmrObstakel.Interval = 1
        '
        'tmrRnd2
        '
        Me.tmrRnd2.Interval = 1
        '
        'tmrObstakel2
        '
        Me.tmrObstakel2.Interval = 1
        '
        'tmrControle
        '
        Me.tmrControle.Interval = 10
        '
        'lblPunten
        '
        Me.lblPunten.AutoSize = True
        Me.lblPunten.BackColor = System.Drawing.Color.Transparent
        Me.lblPunten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPunten.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPunten.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunten.ForeColor = System.Drawing.Color.Snow
        Me.lblPunten.Location = New System.Drawing.Point(208, 46)
        Me.lblPunten.Name = "lblPunten"
        Me.lblPunten.Size = New System.Drawing.Size(43, 47)
        Me.lblPunten.TabIndex = 4
        Me.lblPunten.Text = "0"
        '
        'lblSpace
        '
        Me.lblSpace.AutoSize = True
        Me.lblSpace.BackColor = System.Drawing.Color.Transparent
        Me.lblSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpace.Location = New System.Drawing.Point(128, 93)
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(206, 40)
        Me.lblSpace.TabIndex = 8
        Me.lblSpace.Text = "Press Spacebar to begin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or press PLAY button"
        Me.lblSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.Location = New System.Drawing.Point(174, 236)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(102, 33)
        Me.lblPause.TabIndex = 9
        Me.lblPause.Text = "Pause"
        Me.lblPause.Visible = False
        '
        'lblPPause
        '
        Me.lblPPause.AutoSize = True
        Me.lblPPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPause.Location = New System.Drawing.Point(1, 65)
        Me.lblPPause.Name = "lblPPause"
        Me.lblPPause.Size = New System.Drawing.Size(135, 20)
        Me.lblPPause.TabIndex = 10
        Me.lblPPause.Text = "Press P for Pause"
        Me.lblPPause.Visible = False
        '
        'lblSA
        '
        Me.lblSA.AutoSize = True
        Me.lblSA.BackColor = System.Drawing.Color.Transparent
        Me.lblSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSA.Location = New System.Drawing.Point(1, 93)
        Me.lblSA.Name = "lblSA"
        Me.lblSA.Size = New System.Drawing.Size(166, 20)
        Me.lblSA.TabIndex = 10
        Me.lblSA.Text = "Press S to Start Again"
        Me.lblSA.Visible = False
        '
        'picGameOver
        '
        Me.picGameOver.BackColor = System.Drawing.Color.Transparent
        Me.picGameOver.BackgroundImage = Global.FlappyBird.My.Resources.Resources.GameOver
        Me.picGameOver.Location = New System.Drawing.Point(108, 136)
        Me.picGameOver.Name = "picGameOver"
        Me.picGameOver.Size = New System.Drawing.Size(226, 37)
        Me.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGameOver.TabIndex = 11
        Me.picGameOver.TabStop = False
        Me.picGameOver.Visible = False
        '
        'picBird
        '
        Me.picBird.BackColor = System.Drawing.Color.Transparent
        Me.picBird.Image = Global.FlappyBird.My.Resources.Resources.FB
        Me.picBird.Location = New System.Drawing.Point(132, 189)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(51, 44)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 1
        Me.picBird.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picGround.Location = New System.Drawing.Point(-4, 517)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(530, 25)
        Me.picGround.TabIndex = 5
        Me.picGround.TabStop = False
        '
        'picObstakelDoorgangH2
        '
        Me.picObstakelDoorgangH2.BackColor = System.Drawing.Color.Transparent
        Me.picObstakelDoorgangH2.Location = New System.Drawing.Point(532, 116)
        Me.picObstakelDoorgangH2.Name = "picObstakelDoorgangH2"
        Me.picObstakelDoorgangH2.Size = New System.Drawing.Size(46, 110)
        Me.picObstakelDoorgangH2.TabIndex = 3
        Me.picObstakelDoorgangH2.TabStop = False
        '
        'picObstakelDoorgangHL2
        '
        Me.picObstakelDoorgangHL2.BackColor = System.Drawing.Color.Transparent
        Me.picObstakelDoorgangHL2.Location = New System.Drawing.Point(532, 196)
        Me.picObstakelDoorgangHL2.Name = "picObstakelDoorgangHL2"
        Me.picObstakelDoorgangHL2.Size = New System.Drawing.Size(46, 10)
        Me.picObstakelDoorgangHL2.TabIndex = 3
        Me.picObstakelDoorgangHL2.TabStop = False
        '
        'picObstakelDoorgangHH2
        '
        Me.picObstakelDoorgangHH2.BackColor = System.Drawing.Color.Transparent
        Me.picObstakelDoorgangHH2.Location = New System.Drawing.Point(532, 115)
        Me.picObstakelDoorgangHH2.Name = "picObstakelDoorgangHH2"
        Me.picObstakelDoorgangHH2.Size = New System.Drawing.Size(46, 10)
        Me.picObstakelDoorgangHH2.TabIndex = 3
        Me.picObstakelDoorgangHH2.TabStop = False
        '
        'picObstakelDoorgangH
        '
        Me.picObstakelDoorgangH.BackColor = System.Drawing.Color.Transparent
        Me.picObstakelDoorgangH.Location = New System.Drawing.Point(616, 115)
        Me.picObstakelDoorgangH.Name = "picObstakelDoorgangH"
        Me.picObstakelDoorgangH.Size = New System.Drawing.Size(46, 110)
        Me.picObstakelDoorgangH.TabIndex = 3
        Me.picObstakelDoorgangH.TabStop = False
        '
        'picObstakelDoorgangHL
        '
        Me.picObstakelDoorgangHL.BackColor = System.Drawing.Color.Transparent
        Me.picObstakelDoorgangHL.Location = New System.Drawing.Point(616, 196)
        Me.picObstakelDoorgangHL.Name = "picObstakelDoorgangHL"
        Me.picObstakelDoorgangHL.Size = New System.Drawing.Size(46, 10)
        Me.picObstakelDoorgangHL.TabIndex = 3
        Me.picObstakelDoorgangHL.TabStop = False
        '
        'picObstakelDoorgangHH
        '
        Me.picObstakelDoorgangHH.BackColor = System.Drawing.Color.Transparent
        Me.picObstakelDoorgangHH.Location = New System.Drawing.Point(616, 115)
        Me.picObstakelDoorgangHH.Name = "picObstakelDoorgangHH"
        Me.picObstakelDoorgangHH.Size = New System.Drawing.Size(46, 10)
        Me.picObstakelDoorgangHH.TabIndex = 3
        Me.picObstakelDoorgangHH.TabStop = False
        '
        'picObstakelHeel2
        '
        Me.picObstakelHeel2.BackColor = System.Drawing.Color.Green
        Me.picObstakelHeel2.Location = New System.Drawing.Point(532, 0)
        Me.picObstakelHeel2.Name = "picObstakelHeel2"
        Me.picObstakelHeel2.Size = New System.Drawing.Size(46, 542)
        Me.picObstakelHeel2.TabIndex = 2
        Me.picObstakelHeel2.TabStop = False
        '
        'picObstakelHeel
        '
        Me.picObstakelHeel.BackColor = System.Drawing.Color.Green
        Me.picObstakelHeel.Location = New System.Drawing.Point(616, 0)
        Me.picObstakelHeel.Name = "picObstakelHeel"
        Me.picObstakelHeel.Size = New System.Drawing.Size(46, 542)
        Me.picObstakelHeel.TabIndex = 2
        Me.picObstakelHeel.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.FlappyBird.My.Resources.Resources.Cloud
        Me.PictureBox3.Location = New System.Drawing.Point(393, -22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(158, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.FlappyBird.My.Resources.Resources.Cloud
        Me.PictureBox4.Location = New System.Drawing.Point(283, -15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(73, 49)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.FlappyBird.My.Resources.Resources.Cloud
        Me.PictureBox2.Location = New System.Drawing.Point(84, -15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.FlappyBird.My.Resources.Resources.Cloud
        Me.PictureBox5.Location = New System.Drawing.Point(-55, -15)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(133, 56)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'picTop
        '
        Me.picTop.BackColor = System.Drawing.Color.Transparent
        Me.picTop.Location = New System.Drawing.Point(186, 1)
        Me.picTop.Name = "picTop"
        Me.picTop.Size = New System.Drawing.Size(100, 10)
        Me.picTop.TabIndex = 7
        Me.picTop.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(417, 541)
        Me.Controls.Add(Me.picGameOver)
        Me.Controls.Add(Me.lblSA)
        Me.Controls.Add(Me.lblPPause)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.lblSpace)
        Me.Controls.Add(Me.lblPlay)
        Me.Controls.Add(Me.lblPunten)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picObstakelDoorgangH2)
        Me.Controls.Add(Me.picObstakelDoorgangHL2)
        Me.Controls.Add(Me.picObstakelDoorgangHH2)
        Me.Controls.Add(Me.picObstakelDoorgangH)
        Me.Controls.Add(Me.picObstakelDoorgangHL)
        Me.Controls.Add(Me.picObstakelDoorgangHH)
        Me.Controls.Add(Me.picObstakelHeel2)
        Me.Controls.Add(Me.picObstakelHeel)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.picTop)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlappyBird"
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelDoorgangH2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelDoorgangHL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelDoorgangHH2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelDoorgangH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelDoorgangHL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelDoorgangHH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelHeel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstakelHeel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents tmrBirdDown As System.Windows.Forms.Timer
    Friend WithEvents tmrRnd As System.Windows.Forms.Timer
    Friend WithEvents tmrObstakel As System.Windows.Forms.Timer
    Friend WithEvents tmrRnd2 As System.Windows.Forms.Timer
    Friend WithEvents tmrObstakel2 As System.Windows.Forms.Timer
    Friend WithEvents picObstakelHeel As System.Windows.Forms.PictureBox
    Friend WithEvents picObstakelDoorgangHH As System.Windows.Forms.PictureBox
    Friend WithEvents picObstakelDoorgangHL As System.Windows.Forms.PictureBox
    Friend WithEvents picObstakelDoorgangH As System.Windows.Forms.PictureBox
    Friend WithEvents picObstakelHeel2 As System.Windows.Forms.PictureBox
    Friend WithEvents picObstakelDoorgangHH2 As System.Windows.Forms.PictureBox
    Friend WithEvents picObstakelDoorgangH2 As System.Windows.Forms.PictureBox
    Friend WithEvents picObstakelDoorgangHL2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrControle As System.Windows.Forms.Timer
    Friend WithEvents lblPunten As System.Windows.Forms.Label
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picBird As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents picTop As System.Windows.Forms.PictureBox
    Friend WithEvents lblSpace As System.Windows.Forms.Label
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents lblPPause As System.Windows.Forms.Label
    Friend WithEvents lblSA As System.Windows.Forms.Label
    Friend WithEvents picGameOver As System.Windows.Forms.PictureBox

End Class
