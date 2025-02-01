<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LogOffBtn = New System.Windows.Forms.Button()
        Me.RestartBtn = New System.Windows.Forms.Button()
        Me.ShutDownBtn = New System.Windows.Forms.Button()
        Me.AbortBtn = New System.Windows.Forms.Button()
        Me.HibernateBtn = New System.Windows.Forms.Button()
        Me.StandByBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogOffBtn
        '
        Me.LogOffBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LogOffBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOffBtn.Location = New System.Drawing.Point(97, 38)
        Me.LogOffBtn.Name = "LogOffBtn"
        Me.LogOffBtn.Size = New System.Drawing.Size(100, 23)
        Me.LogOffBtn.TabIndex = 0
        Me.LogOffBtn.Text = "Log Off"
        Me.LogOffBtn.UseVisualStyleBackColor = True
        '
        'RestartBtn
        '
        Me.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RestartBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartBtn.Location = New System.Drawing.Point(97, 67)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(100, 23)
        Me.RestartBtn.TabIndex = 1
        Me.RestartBtn.Text = "Restart"
        Me.RestartBtn.UseVisualStyleBackColor = True
        '
        'ShutDownBtn
        '
        Me.ShutDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ShutDownBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShutDownBtn.Location = New System.Drawing.Point(97, 96)
        Me.ShutDownBtn.Name = "ShutDownBtn"
        Me.ShutDownBtn.Size = New System.Drawing.Size(100, 23)
        Me.ShutDownBtn.TabIndex = 2
        Me.ShutDownBtn.Text = "Shut Down"
        Me.ShutDownBtn.UseVisualStyleBackColor = True
        '
        'AbortBtn
        '
        Me.AbortBtn.Enabled = False
        Me.AbortBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AbortBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbortBtn.ForeColor = System.Drawing.Color.Black
        Me.AbortBtn.Location = New System.Drawing.Point(97, 183)
        Me.AbortBtn.Name = "AbortBtn"
        Me.AbortBtn.Size = New System.Drawing.Size(100, 23)
        Me.AbortBtn.TabIndex = 5
        Me.AbortBtn.Text = "Abort"
        Me.AbortBtn.UseVisualStyleBackColor = True
        '
        'HibernateBtn
        '
        Me.HibernateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HibernateBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HibernateBtn.Location = New System.Drawing.Point(97, 125)
        Me.HibernateBtn.Name = "HibernateBtn"
        Me.HibernateBtn.Size = New System.Drawing.Size(100, 23)
        Me.HibernateBtn.TabIndex = 3
        Me.HibernateBtn.Text = "Hibernate"
        Me.HibernateBtn.UseVisualStyleBackColor = True
        '
        'StandByBtn
        '
        Me.StandByBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StandByBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StandByBtn.Location = New System.Drawing.Point(97, 154)
        Me.StandByBtn.Name = "StandByBtn"
        Me.StandByBtn.Size = New System.Drawing.Size(100, 23)
        Me.StandByBtn.TabIndex = 4
        Me.StandByBtn.Text = "Stand By"
        Me.StandByBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ExitBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(97, 212)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(100, 23)
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AcceptButton = Me.AbortBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(294, 272)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.StandByBtn)
        Me.Controls.Add(Me.HibernateBtn)
        Me.Controls.Add(Me.ShutDownBtn)
        Me.Controls.Add(Me.RestartBtn)
        Me.Controls.Add(Me.LogOffBtn)
        Me.Controls.Add(Me.AbortBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown Utility"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogOffBtn As System.Windows.Forms.Button
    Friend WithEvents RestartBtn As System.Windows.Forms.Button
    Friend WithEvents ShutDownBtn As System.Windows.Forms.Button
    Friend WithEvents AbortBtn As System.Windows.Forms.Button
    Friend WithEvents HibernateBtn As System.Windows.Forms.Button
    Friend WithEvents StandByBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button

End Class
