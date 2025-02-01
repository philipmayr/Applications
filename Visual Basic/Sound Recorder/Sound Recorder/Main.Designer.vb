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
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.StartRecToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RecButton = New System.Windows.Forms.Button()
        Me.StopRecToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ResumeRecToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.FileName = "Untitled"
        Me.SaveFileDialog.Filter = "Windows Media Audio File|*.wma"
        '
        'RecButton
        '
        Me.RecButton.BackColor = System.Drawing.Color.Transparent
        Me.RecButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecButton.Location = New System.Drawing.Point(12, 12)
        Me.RecButton.Name = "RecButton"
        Me.RecButton.Size = New System.Drawing.Size(270, 25)
        Me.RecButton.TabIndex = 0
        Me.RecButton.Text = "Start Recording"
        Me.ResumeRecToolTip.SetToolTip(Me.RecButton, "Resume Recording (Alt+S)")
        Me.StartRecToolTip.SetToolTip(Me.RecButton, "Start Recording (Alt+S)")
        Me.StopRecToolTip.SetToolTip(Me.RecButton, "Stop Recording (Alt+S)")
        Me.RecButton.UseVisualStyleBackColor = False
        '
        'StopRecToolTip
        '
        Me.StopRecToolTip.Active = False
        '
        'ResumeRecToolTip
        '
        Me.ResumeRecToolTip.Active = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(294, 49)
        Me.Controls.Add(Me.RecButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sound Recorder"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartRecToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RecButton As System.Windows.Forms.Button
    Friend WithEvents ResumeRecToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StopRecToolTip As System.Windows.Forms.ToolTip

End Class
