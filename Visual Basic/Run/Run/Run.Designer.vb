<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Run
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Run))
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.OpenLbl = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox
        '
        Me.ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.ComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox.ForeColor = System.Drawing.Color.Black
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(63, 69)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(321, 23)
        Me.ComboBox.TabIndex = 0
        '
        'OpenLbl
        '
        Me.OpenLbl.AutoSize = True
        Me.OpenLbl.BackColor = System.Drawing.Color.Transparent
        Me.OpenLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenLbl.ForeColor = System.Drawing.Color.Black
        Me.OpenLbl.Location = New System.Drawing.Point(9, 72)
        Me.OpenLbl.Name = "OpenLbl"
        Me.OpenLbl.Size = New System.Drawing.Size(39, 15)
        Me.OpenLbl.TabIndex = 0
        Me.OpenLbl.Text = "&Open:"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Programs|*.exe|All Files|*.*"
        Me.OpenFileDialog.Title = "Browse"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox.TabIndex = 4
        Me.PictureBox.TabStop = False
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(60, 21)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(317, 45)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Type the name of a program, folder, document, or Internet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "resource, and Run will" & _
    " open it for you." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.SystemColors.Control
        Me.Panel.Controls.Add(Me.OKBtn)
        Me.Panel.Controls.Add(Me.BrowseBtn)
        Me.Panel.Controls.Add(Me.CancelBtn)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel.Location = New System.Drawing.Point(0, 113)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(397, 61)
        Me.Panel.TabIndex = 1
        '
        'OKBtn
        '
        Me.OKBtn.Enabled = False
        Me.OKBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKBtn.ForeColor = System.Drawing.Color.Black
        Me.OKBtn.Location = New System.Drawing.Point(109, 18)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(88, 25)
        Me.OKBtn.TabIndex = 0
        Me.OKBtn.Text = "OK"
        Me.OKBtn.UseVisualStyleBackColor = True
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBtn.ForeColor = System.Drawing.Color.Black
        Me.BrowseBtn.Location = New System.Drawing.Point(298, 18)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(88, 25)
        Me.BrowseBtn.TabIndex = 2
        Me.BrowseBtn.Text = "&Browse..."
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Location = New System.Drawing.Point(203, 18)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(88, 25)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Run
        '
        Me.AcceptButton = Me.OKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(397, 174)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.OpenLbl)
        Me.Controls.Add(Me.ComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Run"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OpenLbl As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents OKBtn As System.Windows.Forms.Button
    Friend WithEvents BrowseBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
End Class
