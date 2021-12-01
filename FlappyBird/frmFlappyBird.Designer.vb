<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlappyBird
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlappyBird))
        Me.tmrBirdDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrControle = New System.Windows.Forms.Timer(Me.components)
        Me.lblPunten = New System.Windows.Forms.Label()
        Me.lblSpace = New System.Windows.Forms.Label()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.lblPPause = New System.Windows.Forms.Label()
        Me.lblSA = New System.Windows.Forms.Label()
        Me.tmrPipeL1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPipe1Move = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPipeL2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPipe2Move = New System.Windows.Forms.Timer(Me.components)
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.picGameOver = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picPipeUp2 = New System.Windows.Forms.PictureBox()
        Me.picPipeDown2 = New System.Windows.Forms.PictureBox()
        Me.picPipeDown1 = New System.Windows.Forms.PictureBox()
        Me.picPipeUp1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picTop = New System.Windows.Forms.PictureBox()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPipeUp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPipeDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPipeDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPipeUp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrBirdDown
        '
        Me.tmrBirdDown.Interval = 2
        '
        'tmrControle
        '
        Me.tmrControle.Interval = 1
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
        Me.lblSpace.Location = New System.Drawing.Point(95, 233)
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(136, 20)
        Me.lblSpace.TabIndex = 8
        Me.lblSpace.Text = "Press Spacebar"
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
        'tmrPipeL1
        '
        Me.tmrPipeL1.Interval = 1
        '
        'tmrPipe1Move
        '
        Me.tmrPipe1Move.Interval = 1
        '
        'tmrPipeL2
        '
        Me.tmrPipeL2.Interval = 1
        '
        'tmrPipe2Move
        '
        Me.tmrPipe2Move.Interval = 1
        '
        'picBird
        '
        Me.picBird.BackColor = System.Drawing.Color.Transparent
        Me.picBird.Image = Global.FlappyBird.My.Resources.Resources.FB
        Me.picBird.Location = New System.Drawing.Point(132, 188)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(52, 42)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 1
        Me.picBird.TabStop = False
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
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picGround.Location = New System.Drawing.Point(-5, 450)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(530, 63)
        Me.picGround.TabIndex = 5
        Me.picGround.TabStop = False
        '
        'picPipeUp2
        '
        Me.picPipeUp2.BackColor = System.Drawing.Color.Transparent
        Me.picPipeUp2.Image = Global.FlappyBird.My.Resources.Resources.PipeD
        Me.picPipeUp2.Location = New System.Drawing.Point(679, 1)
        Me.picPipeUp2.Name = "picPipeUp2"
        Me.picPipeUp2.Size = New System.Drawing.Size(52, 330)
        Me.picPipeUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPipeUp2.TabIndex = 12
        Me.picPipeUp2.TabStop = False
        Me.picPipeUp2.Visible = False
        '
        'picPipeDown2
        '
        Me.picPipeDown2.BackColor = System.Drawing.Color.Transparent
        Me.picPipeDown2.Image = Global.FlappyBird.My.Resources.Resources.Pipe
        Me.picPipeDown2.Location = New System.Drawing.Point(679, 212)
        Me.picPipeDown2.Name = "picPipeDown2"
        Me.picPipeDown2.Size = New System.Drawing.Size(52, 344)
        Me.picPipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPipeDown2.TabIndex = 12
        Me.picPipeDown2.TabStop = False
        Me.picPipeDown2.Visible = False
        '
        'picPipeDown1
        '
        Me.picPipeDown1.BackColor = System.Drawing.Color.Transparent
        Me.picPipeDown1.Image = Global.FlappyBird.My.Resources.Resources.Pipe
        Me.picPipeDown1.Location = New System.Drawing.Point(557, 212)
        Me.picPipeDown1.Name = "picPipeDown1"
        Me.picPipeDown1.Size = New System.Drawing.Size(52, 330)
        Me.picPipeDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPipeDown1.TabIndex = 12
        Me.picPipeDown1.TabStop = False
        '
        'picPipeUp1
        '
        Me.picPipeUp1.BackColor = System.Drawing.Color.Transparent
        Me.picPipeUp1.Image = Global.FlappyBird.My.Resources.Resources.PipeD
        Me.picPipeUp1.Location = New System.Drawing.Point(557, 1)
        Me.picPipeUp1.Name = "picPipeUp1"
        Me.picPipeUp1.Size = New System.Drawing.Size(52, 330)
        Me.picPipeUp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPipeUp1.TabIndex = 12
        Me.picPipeUp1.TabStop = False
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
        'frmFlappyBird
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(376, 507)
        Me.Controls.Add(Me.lblSpace)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.picGameOver)
        Me.Controls.Add(Me.lblPunten)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picPipeUp2)
        Me.Controls.Add(Me.picPipeDown2)
        Me.Controls.Add(Me.picPipeDown1)
        Me.Controls.Add(Me.picPipeUp1)
        Me.Controls.Add(Me.lblSA)
        Me.Controls.Add(Me.lblPPause)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.picTop)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFlappyBird"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlappyBird"
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPipeUp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPipeDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPipeDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPipeUp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrBirdDown As System.Windows.Forms.Timer
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
    Friend WithEvents picPipeUp1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPipeDown1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPipeDown2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPipeUp2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPipeL1 As System.Windows.Forms.Timer
    Friend WithEvents tmrPipe1Move As System.Windows.Forms.Timer
    Friend WithEvents tmrPipeL2 As System.Windows.Forms.Timer
    Friend WithEvents tmrPipe2Move As System.Windows.Forms.Timer

End Class
