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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.GoForwardButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StopButton = New System.Windows.Forms.Button()
        Me.URLComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GoBackButton
        '
        Me.GoBackButton.Enabled = False
        Me.GoBackButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackButton.Location = New System.Drawing.Point(0, 0)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(75, 23)
        Me.GoBackButton.TabIndex = 4
        Me.GoBackButton.Text = "<<"
        Me.ToolTip.SetToolTip(Me.GoBackButton, "Go Back")
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'GoForwardButton
        '
        Me.GoForwardButton.Enabled = False
        Me.GoForwardButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoForwardButton.Location = New System.Drawing.Point(81, 0)
        Me.GoForwardButton.Name = "GoForwardButton"
        Me.GoForwardButton.Size = New System.Drawing.Size(75, 23)
        Me.GoForwardButton.TabIndex = 5
        Me.GoForwardButton.Text = ">>"
        Me.ToolTip.SetToolTip(Me.GoForwardButton, "Go Forward")
        Me.GoForwardButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Enabled = False
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(809, 0)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 3
        Me.RefreshButton.Text = "Refresh"
        Me.ToolTip.SetToolTip(Me.RefreshButton, "Refresh")
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'WebBrowser
        '
        Me.WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser.Location = New System.Drawing.Point(0, 29)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = True
        Me.WebBrowser.Size = New System.Drawing.Size(884, 511)
        Me.WebBrowser.TabIndex = 1
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripProgressBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip.TabIndex = 0
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(767, 17)
        Me.ToolStripStatusLabel.Spring = True
        Me.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripProgressBar
        '
        Me.ToolStripProgressBar.Name = "ToolStripProgressBar"
        Me.ToolStripProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'StopButton
        '
        Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopButton.Enabled = False
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(728, 0)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 2
        Me.StopButton.Text = "Stop"
        Me.ToolTip.SetToolTip(Me.StopButton, "Stop")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'URLComboBox
        '
        Me.URLComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URLComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.URLComboBox.FormattingEnabled = True
        Me.URLComboBox.Location = New System.Drawing.Point(162, 2)
        Me.URLComboBox.Name = "URLComboBox"
        Me.URLComboBox.Size = New System.Drawing.Size(560, 21)
        Me.URLComboBox.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.URLComboBox)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.GoForwardButton)
        Me.Controls.Add(Me.GoBackButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 200)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Browser"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GoBackButton As System.Windows.Forms.Button
    Friend WithEvents GoForwardButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents URLComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StopButton As System.Windows.Forms.Button

End Class
