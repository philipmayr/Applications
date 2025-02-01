<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.GuessLbl = New System.Windows.Forms.Label()
        Me.Guess = New System.Windows.Forms.NumericUpDown()
        Me.GuessBtn = New System.Windows.Forms.Button()
        Me.Correct = New System.Windows.Forms.Label()
        Me.RestartBtn = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TooHigh = New System.Windows.Forms.Label()
        Me.TooLow = New System.Windows.Forms.Label()
        CType(Me.Guess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GuessLbl
        '
        Me.GuessLbl.AutoSize = True
        Me.GuessLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessLbl.ForeColor = System.Drawing.Color.Black
        Me.GuessLbl.Location = New System.Drawing.Point(91, 21)
        Me.GuessLbl.Name = "GuessLbl"
        Me.GuessLbl.Size = New System.Drawing.Size(109, 17)
        Me.GuessLbl.TabIndex = 0
        Me.GuessLbl.Text = "Enter your guess:"
        '
        'Guess
        '
        Me.Guess.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guess.ForeColor = System.Drawing.Color.Black
        Me.Guess.Location = New System.Drawing.Point(85, 41)
        Me.Guess.Name = "Guess"
        Me.Guess.Size = New System.Drawing.Size(120, 25)
        Me.Guess.TabIndex = 1
        '
        'GuessBtn
        '
        Me.GuessBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessBtn.ForeColor = System.Drawing.Color.Black
        Me.GuessBtn.Location = New System.Drawing.Point(85, 72)
        Me.GuessBtn.Name = "GuessBtn"
        Me.GuessBtn.Size = New System.Drawing.Size(120, 23)
        Me.GuessBtn.TabIndex = 2
        Me.GuessBtn.Tag = ""
        Me.GuessBtn.Text = "Guess!"
        Me.ToolTip.SetToolTip(Me.GuessBtn, "Guess!")
        Me.GuessBtn.UseVisualStyleBackColor = True
        '
        'Correct
        '
        Me.Correct.AutoSize = True
        Me.Correct.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correct.ForeColor = System.Drawing.Color.Green
        Me.Correct.Location = New System.Drawing.Point(112, 98)
        Me.Correct.Name = "Correct"
        Me.Correct.Size = New System.Drawing.Size(66, 21)
        Me.Correct.TabIndex = 3
        Me.Correct.Text = "Correct!"
        Me.Correct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Correct.Visible = False
        '
        'RestartBtn
        '
        Me.RestartBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartBtn.ForeColor = System.Drawing.Color.Black
        Me.RestartBtn.Location = New System.Drawing.Point(85, 122)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(120, 23)
        Me.RestartBtn.TabIndex = 4
        Me.RestartBtn.Tag = ""
        Me.RestartBtn.Text = "Play Again!"
        Me.ToolTip.SetToolTip(Me.RestartBtn, "Play Again!")
        Me.RestartBtn.UseVisualStyleBackColor = True
        Me.RestartBtn.Visible = False
        '
        'TooHigh
        '
        Me.TooHigh.AutoSize = True
        Me.TooHigh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TooHigh.ForeColor = System.Drawing.Color.Black
        Me.TooHigh.Location = New System.Drawing.Point(106, 98)
        Me.TooHigh.Name = "TooHigh"
        Me.TooHigh.Size = New System.Drawing.Size(78, 21)
        Me.TooHigh.TabIndex = 3
        Me.TooHigh.Text = "Too High!"
        Me.TooHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TooHigh.Visible = False
        '
        'TooLow
        '
        Me.TooLow.AutoSize = True
        Me.TooLow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TooLow.ForeColor = System.Drawing.Color.Black
        Me.TooLow.Location = New System.Drawing.Point(108, 98)
        Me.TooLow.Name = "TooLow"
        Me.TooLow.Size = New System.Drawing.Size(74, 21)
        Me.TooLow.TabIndex = 3
        Me.TooLow.Text = "Too Low!"
        Me.TooLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TooLow.Visible = False
        '
        'Game
        '
        Me.AcceptButton = Me.GuessBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 168)
        Me.Controls.Add(Me.RestartBtn)
        Me.Controls.Add(Me.Correct)
        Me.Controls.Add(Me.GuessBtn)
        Me.Controls.Add(Me.Guess)
        Me.Controls.Add(Me.GuessLbl)
        Me.Controls.Add(Me.TooLow)
        Me.Controls.Add(Me.TooHigh)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GuessLbl As System.Windows.Forms.Label
    Friend WithEvents Guess As System.Windows.Forms.NumericUpDown
    Friend WithEvents GuessBtn As System.Windows.Forms.Button
    Friend WithEvents Correct As System.Windows.Forms.Label
    Friend WithEvents RestartBtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TooHigh As System.Windows.Forms.Label
    Friend WithEvents TooLow As System.Windows.Forms.Label

End Class
