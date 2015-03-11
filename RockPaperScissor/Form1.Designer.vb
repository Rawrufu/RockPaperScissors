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
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnScissor = New System.Windows.Forms.Button()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblLose = New System.Windows.Forms.Label()
        Me.lblDraw = New System.Windows.Forms.Label()
        Me.lblWins1 = New System.Windows.Forms.Label()
        Me.lblLose1 = New System.Windows.Forms.Label()
        Me.lblDraw1 = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.Enabled = False
        Me.picPlayer.Location = New System.Drawing.Point(602, 12)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(111, 230)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 1
        Me.picPlayer.TabStop = False
        '
        'btnRock
        '
        Me.btnRock.Location = New System.Drawing.Point(640, 296)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(98, 60)
        Me.btnRock.TabIndex = 2
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Location = New System.Drawing.Point(640, 362)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(98, 60)
        Me.btnPaper.TabIndex = 3
        Me.btnPaper.Text = "Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnScissor
        '
        Me.btnScissor.Location = New System.Drawing.Point(640, 428)
        Me.btnScissor.Name = "btnScissor"
        Me.btnScissor.Size = New System.Drawing.Size(98, 60)
        Me.btnScissor.TabIndex = 4
        Me.btnScissor.Text = "Scissor"
        Me.btnScissor.UseVisualStyleBackColor = True
        '
        'picComputer
        '
        Me.picComputer.Enabled = False
        Me.picComputer.Location = New System.Drawing.Point(58, 12)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(111, 230)
        Me.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComputer.TabIndex = 5
        Me.picComputer.TabStop = False
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.Location = New System.Drawing.Point(25, 308)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(70, 29)
        Me.lblWins.TabIndex = 10
        Me.lblWins.Text = "Wins"
        '
        'lblLose
        '
        Me.lblLose.AutoSize = True
        Me.lblLose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose.Location = New System.Drawing.Point(22, 374)
        Me.lblLose.Name = "lblLose"
        Me.lblLose.Size = New System.Drawing.Size(83, 29)
        Me.lblLose.TabIndex = 11
        Me.lblLose.Text = "Loses"
        '
        'lblDraw
        '
        Me.lblDraw.AutoSize = True
        Me.lblDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraw.Location = New System.Drawing.Point(22, 440)
        Me.lblDraw.Name = "lblDraw"
        Me.lblDraw.Size = New System.Drawing.Size(73, 29)
        Me.lblDraw.TabIndex = 12
        Me.lblDraw.Text = "Draw"
        '
        'lblWins1
        '
        Me.lblWins1.AutoSize = True
        Me.lblWins1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins1.Location = New System.Drawing.Point(111, 308)
        Me.lblWins1.Name = "lblWins1"
        Me.lblWins1.Size = New System.Drawing.Size(27, 29)
        Me.lblWins1.TabIndex = 13
        Me.lblWins1.Text = "0"
        '
        'lblLose1
        '
        Me.lblLose1.AutoSize = True
        Me.lblLose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose1.Location = New System.Drawing.Point(111, 374)
        Me.lblLose1.Name = "lblLose1"
        Me.lblLose1.Size = New System.Drawing.Size(27, 29)
        Me.lblLose1.TabIndex = 14
        Me.lblLose1.Text = "0"
        '
        'lblDraw1
        '
        Me.lblDraw1.AutoSize = True
        Me.lblDraw1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraw1.Location = New System.Drawing.Point(111, 440)
        Me.lblDraw1.Name = "lblDraw1"
        Me.lblDraw1.Size = New System.Drawing.Size(27, 29)
        Me.lblDraw1.TabIndex = 15
        Me.lblDraw1.Text = "0"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(637, 257)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(36, 13)
        Me.lblPlayer.TabIndex = 16
        Me.lblPlayer.Text = "Player"
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.Location = New System.Drawing.Point(86, 257)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(52, 13)
        Me.lblComputer.TabIndex = 17
        Me.lblComputer.Text = "Computer"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(346, 249)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(68, 24)
        Me.lblScore.TabIndex = 18
        Me.lblScore.Text = "Result"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(536, 428)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 60)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 509)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblDraw1)
        Me.Controls.Add(Me.lblLose1)
        Me.Controls.Add(Me.lblWins1)
        Me.Controls.Add(Me.lblDraw)
        Me.Controls.Add(Me.lblLose)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.btnScissor)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.picPlayer)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors!"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnScissor As System.Windows.Forms.Button
    Friend WithEvents picComputer As System.Windows.Forms.PictureBox
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents lblLose As System.Windows.Forms.Label
    Friend WithEvents lblDraw As System.Windows.Forms.Label
    Friend WithEvents lblWins1 As System.Windows.Forms.Label
    Friend WithEvents lblLose1 As System.Windows.Forms.Label
    Friend WithEvents lblDraw1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
