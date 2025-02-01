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
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.URILabel = New System.Windows.Forms.Label()
        Me.CancelDownloadButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressPercentageLabel = New System.Windows.Forms.Label()
        Me.SizeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DownloadButton
        '
        Me.DownloadButton.AutoSize = True
        Me.DownloadButton.Enabled = False
        Me.DownloadButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadButton.Location = New System.Drawing.Point(184, 40)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(71, 23)
        Me.DownloadButton.TabIndex = 1
        Me.DownloadButton.Text = "Download"
        Me.ToolTip.SetToolTip(Me.DownloadButton, "Download")
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 74)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(300, 23)
        Me.ProgressBar.TabIndex = 0
        '
        'TextBox
        '
        Me.TextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.Location = New System.Drawing.Point(46, 12)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(266, 22)
        Me.TextBox.TabIndex = 0
        Me.TextBox.Text = "http://"
        '
        'URILabel
        '
        Me.URILabel.AutoSize = True
        Me.URILabel.BackColor = System.Drawing.Color.Transparent
        Me.URILabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URILabel.ForeColor = System.Drawing.Color.White
        Me.URILabel.Location = New System.Drawing.Point(12, 15)
        Me.URILabel.Name = "URILabel"
        Me.URILabel.Size = New System.Drawing.Size(28, 13)
        Me.URILabel.TabIndex = 0
        Me.URILabel.Text = "URI:"
        '
        'CancelDownloadButton
        '
        Me.CancelDownloadButton.AutoSize = True
        Me.CancelDownloadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelDownloadButton.Enabled = False
        Me.CancelDownloadButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelDownloadButton.Location = New System.Drawing.Point(261, 40)
        Me.CancelDownloadButton.Name = "CancelDownloadButton"
        Me.CancelDownloadButton.Size = New System.Drawing.Size(51, 23)
        Me.CancelDownloadButton.TabIndex = 2
        Me.CancelDownloadButton.Text = "Cancel"
        Me.ToolTip.SetToolTip(Me.CancelDownloadButton, "Cancel")
        Me.CancelDownloadButton.UseVisualStyleBackColor = True
        '
        'ProgressPercentageLabel
        '
        Me.ProgressPercentageLabel.AutoSize = True
        Me.ProgressPercentageLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPercentageLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPercentageLabel.ForeColor = System.Drawing.Color.White
        Me.ProgressPercentageLabel.Location = New System.Drawing.Point(12, 58)
        Me.ProgressPercentageLabel.Name = "ProgressPercentageLabel"
        Me.ProgressPercentageLabel.Size = New System.Drawing.Size(22, 13)
        Me.ProgressPercentageLabel.TabIndex = 0
        Me.ProgressPercentageLabel.Text = "0%"
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.BackColor = System.Drawing.Color.Transparent
        Me.SizeLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeLabel.ForeColor = System.Drawing.Color.White
        Me.SizeLabel.Location = New System.Drawing.Point(12, 45)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(96, 13)
        Me.SizeLabel.TabIndex = 0
        Me.SizeLabel.Text = "0 Bytes of 0 Bytes"
        '
        'Main
        '
        Me.AcceptButton = Me.DownloadButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(324, 107)
        Me.Controls.Add(Me.SizeLabel)
        Me.Controls.Add(Me.ProgressPercentageLabel)
        Me.Controls.Add(Me.CancelDownloadButton)
        Me.Controls.Add(Me.URILabel)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.ProgressBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DownloadButton As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents URILabel As System.Windows.Forms.Label
    Friend WithEvents CancelDownloadButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ProgressPercentageLabel As System.Windows.Forms.Label
    Friend WithEvents SizeLabel As System.Windows.Forms.Label

End Class
