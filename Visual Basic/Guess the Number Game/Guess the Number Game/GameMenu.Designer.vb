<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameMenu))
        Me.EasyBtn = New System.Windows.Forms.Button()
        Me.NormalBtn = New System.Windows.Forms.Button()
        Me.HardBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'EasyBtn
        '
        Me.EasyBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EasyBtn.ForeColor = System.Drawing.Color.Black
        Me.EasyBtn.Location = New System.Drawing.Point(108, 44)
        Me.EasyBtn.Name = "EasyBtn"
        Me.EasyBtn.Size = New System.Drawing.Size(75, 23)
        Me.EasyBtn.TabIndex = 0
        Me.EasyBtn.Text = "Easy"
        Me.ToolTip.SetToolTip(Me.EasyBtn, "Easy (1-10)")
        Me.EasyBtn.UseVisualStyleBackColor = True
        '
        'NormalBtn
        '
        Me.NormalBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NormalBtn.ForeColor = System.Drawing.Color.Black
        Me.NormalBtn.Location = New System.Drawing.Point(108, 73)
        Me.NormalBtn.Name = "NormalBtn"
        Me.NormalBtn.Size = New System.Drawing.Size(75, 23)
        Me.NormalBtn.TabIndex = 1
        Me.NormalBtn.Text = "Normal"
        Me.ToolTip.SetToolTip(Me.NormalBtn, "Normal (1-100)")
        Me.NormalBtn.UseVisualStyleBackColor = True
        '
        'HardBtn
        '
        Me.HardBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardBtn.ForeColor = System.Drawing.Color.Black
        Me.HardBtn.Location = New System.Drawing.Point(108, 102)
        Me.HardBtn.Name = "HardBtn"
        Me.HardBtn.Size = New System.Drawing.Size(75, 23)
        Me.HardBtn.TabIndex = 2
        Me.HardBtn.Text = "Hard"
        Me.ToolTip.SetToolTip(Me.HardBtn, "Hard (1-1000)")
        Me.HardBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.Black
        Me.ExitBtn.Location = New System.Drawing.Point(203, 133)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 3
        Me.ExitBtn.Text = "Exit"
        Me.ToolTip.SetToolTip(Me.ExitBtn, "Exit")
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'GameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(290, 168)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.HardBtn)
        Me.Controls.Add(Me.NormalBtn)
        Me.Controls.Add(Me.EasyBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GameMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess The Number"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EasyBtn As System.Windows.Forms.Button
    Friend WithEvents NormalBtn As System.Windows.Forms.Button
    Friend WithEvents HardBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
