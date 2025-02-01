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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StopButton = New System.Windows.Forms.Button()
        Me.NewTabButton = New System.Windows.Forms.Button()
        Me.CloseTabButton = New System.Windows.Forms.Button()
        Me.GoHomeButton = New System.Windows.Forms.Button()
        Me.GoSearchButton = New System.Windows.Forms.Button()
        Me.ShowPropertiesDialogButton = New System.Windows.Forms.Button()
        Me.ShowSaveAsDialogButton = New System.Windows.Forms.Button()
        Me.NavigateButton = New System.Windows.Forms.Button()
        Me.URLComboBox = New System.Windows.Forms.ComboBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabControlContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabControlNewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControlToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControlCloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.URLLabel = New System.Windows.Forms.Label()
        Me.TabPageContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabPageNewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPageToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPageCloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.TabControlContextMenuStrip.SuspendLayout()
        Me.TabPageContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GoBackButton
        '
        Me.GoBackButton.Enabled = False
        Me.GoBackButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackButton.Location = New System.Drawing.Point(0, 0)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(75, 23)
        Me.GoBackButton.TabIndex = 5
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
        Me.GoForwardButton.TabIndex = 6
        Me.GoForwardButton.Text = ">>"
        Me.ToolTip.SetToolTip(Me.GoForwardButton, "Go Forward")
        Me.GoForwardButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Enabled = False
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(909, 29)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 4
        Me.RefreshButton.Text = "Refresh"
        Me.ToolTip.SetToolTip(Me.RefreshButton, "Refresh")
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripProgressBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip.TabIndex = 0
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(867, 17)
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
        Me.StopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.StopButton.Enabled = False
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(828, 29)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 3
        Me.StopButton.Text = "Stop"
        Me.ToolTip.SetToolTip(Me.StopButton, "Stop")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'NewTabButton
        '
        Me.NewTabButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTabButton.Location = New System.Drawing.Point(0, 29)
        Me.NewTabButton.Name = "NewTabButton"
        Me.NewTabButton.Size = New System.Drawing.Size(75, 23)
        Me.NewTabButton.TabIndex = 9
        Me.NewTabButton.Text = "New Tab"
        Me.ToolTip.SetToolTip(Me.NewTabButton, "New Tab")
        Me.NewTabButton.UseVisualStyleBackColor = True
        '
        'CloseTabButton
        '
        Me.CloseTabButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseTabButton.Location = New System.Drawing.Point(81, 29)
        Me.CloseTabButton.Name = "CloseTabButton"
        Me.CloseTabButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseTabButton.TabIndex = 10
        Me.CloseTabButton.Text = "Close Tab"
        Me.ToolTip.SetToolTip(Me.CloseTabButton, "Close Tab")
        Me.CloseTabButton.UseVisualStyleBackColor = True
        '
        'GoHomeButton
        '
        Me.GoHomeButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoHomeButton.Location = New System.Drawing.Point(162, 0)
        Me.GoHomeButton.Name = "GoHomeButton"
        Me.GoHomeButton.Size = New System.Drawing.Size(75, 23)
        Me.GoHomeButton.TabIndex = 7
        Me.GoHomeButton.Text = "Home"
        Me.ToolTip.SetToolTip(Me.GoHomeButton, "Go Home")
        Me.GoHomeButton.UseVisualStyleBackColor = True
        '
        'GoSearchButton
        '
        Me.GoSearchButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoSearchButton.Location = New System.Drawing.Point(243, 0)
        Me.GoSearchButton.Name = "GoSearchButton"
        Me.GoSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.GoSearchButton.TabIndex = 8
        Me.GoSearchButton.Text = "Search"
        Me.ToolTip.SetToolTip(Me.GoSearchButton, "Go Search")
        Me.GoSearchButton.UseVisualStyleBackColor = True
        '
        'ShowPropertiesDialogButton
        '
        Me.ShowPropertiesDialogButton.Enabled = False
        Me.ShowPropertiesDialogButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPropertiesDialogButton.Location = New System.Drawing.Point(162, 29)
        Me.ShowPropertiesDialogButton.Name = "ShowPropertiesDialogButton"
        Me.ShowPropertiesDialogButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowPropertiesDialogButton.TabIndex = 11
        Me.ShowPropertiesDialogButton.Text = "Properties"
        Me.ToolTip.SetToolTip(Me.ShowPropertiesDialogButton, "Show Properties Dialog")
        Me.ShowPropertiesDialogButton.UseVisualStyleBackColor = True
        '
        'ShowSaveAsDialogButton
        '
        Me.ShowSaveAsDialogButton.Enabled = False
        Me.ShowSaveAsDialogButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowSaveAsDialogButton.Location = New System.Drawing.Point(243, 29)
        Me.ShowSaveAsDialogButton.Name = "ShowSaveAsDialogButton"
        Me.ShowSaveAsDialogButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowSaveAsDialogButton.TabIndex = 12
        Me.ShowSaveAsDialogButton.Text = "Save As..."
        Me.ToolTip.SetToolTip(Me.ShowSaveAsDialogButton, "Show Save As Dialog...")
        Me.ShowSaveAsDialogButton.UseVisualStyleBackColor = True
        '
        'NavigateButton
        '
        Me.NavigateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavigateButton.Enabled = False
        Me.NavigateButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigateButton.Location = New System.Drawing.Point(828, 0)
        Me.NavigateButton.Name = "NavigateButton"
        Me.NavigateButton.Size = New System.Drawing.Size(156, 23)
        Me.NavigateButton.TabIndex = 1
        Me.NavigateButton.Text = "Navigate"
        Me.ToolTip.SetToolTip(Me.NavigateButton, "Navigate")
        Me.NavigateButton.UseVisualStyleBackColor = True
        '
        'URLComboBox
        '
        Me.URLComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URLComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.URLComboBox.FormattingEnabled = True
        Me.URLComboBox.Location = New System.Drawing.Point(364, 2)
        Me.URLComboBox.Name = "URLComboBox"
        Me.URLComboBox.Size = New System.Drawing.Size(458, 21)
        Me.URLComboBox.TabIndex = 0
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.ContextMenuStrip = Me.TabControlContextMenuStrip
        Me.TabControl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.ImageList = Me.ImageList
        Me.TabControl.Location = New System.Drawing.Point(0, 58)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.ShowToolTips = True
        Me.TabControl.Size = New System.Drawing.Size(984, 582)
        Me.TabControl.TabIndex = 2
        '
        'TabControlContextMenuStrip
        '
        Me.TabControlContextMenuStrip.BackColor = System.Drawing.Color.White
        Me.TabControlContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabControlNewTabToolStripMenuItem, Me.TabControlToolStripSeparator, Me.TabControlCloseTabToolStripMenuItem})
        Me.TabControlContextMenuStrip.Name = "ContextMenuStrip"
        Me.TabControlContextMenuStrip.ShowImageMargin = False
        Me.TabControlContextMenuStrip.Size = New System.Drawing.Size(102, 54)
        '
        'TabControlNewTabToolStripMenuItem
        '
        Me.TabControlNewTabToolStripMenuItem.Name = "TabControlNewTabToolStripMenuItem"
        Me.TabControlNewTabToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.TabControlNewTabToolStripMenuItem.Text = "New Tab"
        '
        'TabControlToolStripSeparator
        '
        Me.TabControlToolStripSeparator.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabControlToolStripSeparator.Name = "TabControlToolStripSeparator"
        Me.TabControlToolStripSeparator.Size = New System.Drawing.Size(98, 6)
        '
        'TabControlCloseTabToolStripMenuItem
        '
        Me.TabControlCloseTabToolStripMenuItem.Name = "TabControlCloseTabToolStripMenuItem"
        Me.TabControlCloseTabToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.TabControlCloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'URLLabel
        '
        Me.URLLabel.AutoSize = True
        Me.URLLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLLabel.ForeColor = System.Drawing.Color.White
        Me.URLLabel.Location = New System.Drawing.Point(324, 5)
        Me.URLLabel.Name = "URLLabel"
        Me.URLLabel.Size = New System.Drawing.Size(30, 13)
        Me.URLLabel.TabIndex = 0
        Me.URLLabel.Text = "URL:"
        '
        'TabPageContextMenuStrip
        '
        Me.TabPageContextMenuStrip.BackColor = System.Drawing.Color.White
        Me.TabPageContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabPageNewTabToolStripMenuItem, Me.TabPageToolStripSeparator, Me.TabPageCloseTabToolStripMenuItem})
        Me.TabPageContextMenuStrip.Name = "ContextMenuStrip"
        Me.TabPageContextMenuStrip.ShowImageMargin = False
        Me.TabPageContextMenuStrip.Size = New System.Drawing.Size(102, 54)
        '
        'TabPageNewTabToolStripMenuItem
        '
        Me.TabPageNewTabToolStripMenuItem.Name = "TabPageNewTabToolStripMenuItem"
        Me.TabPageNewTabToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.TabPageNewTabToolStripMenuItem.Text = "New Tab"
        '
        'TabPageToolStripSeparator
        '
        Me.TabPageToolStripSeparator.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPageToolStripSeparator.Name = "TabPageToolStripSeparator"
        Me.TabPageToolStripSeparator.Size = New System.Drawing.Size(98, 6)
        '
        'TabPageCloseTabToolStripMenuItem
        '
        Me.TabPageCloseTabToolStripMenuItem.Name = "TabPageCloseTabToolStripMenuItem"
        Me.TabPageCloseTabToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.TabPageCloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.NavigateButton)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.URLLabel)
        Me.Controls.Add(Me.URLComboBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.GoForwardButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.CloseTabButton)
        Me.Controls.Add(Me.NewTabButton)
        Me.Controls.Add(Me.ShowPropertiesDialogButton)
        Me.Controls.Add(Me.ShowSaveAsDialogButton)
        Me.Controls.Add(Me.GoBackButton)
        Me.Controls.Add(Me.GoHomeButton)
        Me.Controls.Add(Me.GoSearchButton)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabbed Web Browser"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControlContextMenuStrip.ResumeLayout(False)
        Me.TabPageContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GoBackButton As System.Windows.Forms.Button
    Friend WithEvents GoForwardButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents NewTabButton As System.Windows.Forms.Button
    Friend WithEvents CloseTabButton As System.Windows.Forms.Button
    Friend WithEvents GoHomeButton As System.Windows.Forms.Button
    Friend WithEvents GoSearchButton As System.Windows.Forms.Button
    Friend WithEvents ShowPropertiesDialogButton As System.Windows.Forms.Button
    Friend WithEvents ShowSaveAsDialogButton As System.Windows.Forms.Button
    Friend WithEvents NavigateButton As System.Windows.Forms.Button
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControlContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TabControlNewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControlToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControlCloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents URLLabel As System.Windows.Forms.Label
    Friend WithEvents TabPageContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TabPageNewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPageToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabPageCloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents URLComboBox As System.Windows.Forms.ComboBox

End Class
