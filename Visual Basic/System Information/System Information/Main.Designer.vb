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
        Me.EnvironmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserNameBtn = New System.Windows.Forms.Button()
        Me.UserDomainNameBtn = New System.Windows.Forms.Button()
        Me.TickCountBtn = New System.Windows.Forms.Button()
        Me.SystemPageSizeBtn = New System.Windows.Forms.Button()
        Me.SystemDirectoryBtn = New System.Windows.Forms.Button()
        Me.ProcessorCountBtn = New System.Windows.Forms.Button()
        Me.OSVersionBtn = New System.Windows.Forms.Button()
        Me.MachineNameBtn = New System.Windows.Forms.Button()
        Me.Is64BitOperatingSystemBtn = New System.Windows.Forms.Button()
        Me.ClockGroupBox = New System.Windows.Forms.GroupBox()
        Me.LocalTimeBtn = New System.Windows.Forms.Button()
        Me.GMTTimeBtn = New System.Windows.Forms.Button()
        Me.FileSystemGroupBox = New System.Windows.Forms.GroupBox()
        Me.DrivesBtn = New System.Windows.Forms.Button()
        Me.InfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalVirtualMemoryBtn = New System.Windows.Forms.Button()
        Me.TotalPhysicalMemoryBtn = New System.Windows.Forms.Button()
        Me.OSVersionInfoBtn = New System.Windows.Forms.Button()
        Me.OSPlatformBtn = New System.Windows.Forms.Button()
        Me.OSFullNameBtn = New System.Windows.Forms.Button()
        Me.InstalledUICultureNativeNameBtn = New System.Windows.Forms.Button()
        Me.AvailableVirtualMemoryBtn = New System.Windows.Forms.Button()
        Me.AvailablePhysicalMemoryBtn = New System.Windows.Forms.Button()
        Me.KeyboardGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShiftKeyDownBtn = New System.Windows.Forms.Button()
        Me.ScrollLockBtn = New System.Windows.Forms.Button()
        Me.NumLockBtn = New System.Windows.Forms.Button()
        Me.CtrlKeyDownBtn = New System.Windows.Forms.Button()
        Me.CapsLockBtn = New System.Windows.Forms.Button()
        Me.AltKeyDownBtn = New System.Windows.Forms.Button()
        Me.MouseGroupBox = New System.Windows.Forms.GroupBox()
        Me.WheelScrollLinesBtn = New System.Windows.Forms.Button()
        Me.WheelExistsBtn = New System.Windows.Forms.Button()
        Me.ButtonsSwappedBtn = New System.Windows.Forms.Button()
        Me.NetworkGroupBox = New System.Windows.Forms.GroupBox()
        Me.IsAvailableBtn = New System.Windows.Forms.Button()
        Me.ScreenGroupBox = New System.Windows.Forms.GroupBox()
        Me.WorkingAreaBtn = New System.Windows.Forms.Button()
        Me.PrimaryBtn = New System.Windows.Forms.Button()
        Me.DeviceNameBtn = New System.Windows.Forms.Button()
        Me.BoundsBtn = New System.Windows.Forms.Button()
        Me.BitsPerPixelBtn = New System.Windows.Forms.Button()
        Me.PortsClipboard = New System.Windows.Forms.GroupBox()
        Me.CountBtn = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.EnvironmentGroupBox.SuspendLayout()
        Me.ClockGroupBox.SuspendLayout()
        Me.FileSystemGroupBox.SuspendLayout()
        Me.InfoGroupBox.SuspendLayout()
        Me.KeyboardGroupBox.SuspendLayout()
        Me.MouseGroupBox.SuspendLayout()
        Me.NetworkGroupBox.SuspendLayout()
        Me.ScreenGroupBox.SuspendLayout()
        Me.PortsClipboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnvironmentGroupBox
        '
        Me.EnvironmentGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.EnvironmentGroupBox.Controls.Add(Me.UserNameBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.UserDomainNameBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.TickCountBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.SystemPageSizeBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.SystemDirectoryBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.ProcessorCountBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.OSVersionBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.MachineNameBtn)
        Me.EnvironmentGroupBox.Controls.Add(Me.Is64BitOperatingSystemBtn)
        Me.EnvironmentGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnvironmentGroupBox.ForeColor = System.Drawing.Color.White
        Me.EnvironmentGroupBox.Location = New System.Drawing.Point(25, 24)
        Me.EnvironmentGroupBox.Name = "EnvironmentGroupBox"
        Me.EnvironmentGroupBox.Size = New System.Drawing.Size(325, 267)
        Me.EnvironmentGroupBox.TabIndex = 0
        Me.EnvironmentGroupBox.TabStop = False
        Me.EnvironmentGroupBox.Text = "Environment"
        '
        'UserNameBtn
        '
        Me.UserNameBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameBtn.ForeColor = System.Drawing.Color.Black
        Me.UserNameBtn.Location = New System.Drawing.Point(218, 186)
        Me.UserNameBtn.Name = "UserNameBtn"
        Me.UserNameBtn.Size = New System.Drawing.Size(100, 75)
        Me.UserNameBtn.TabIndex = 8
        Me.UserNameBtn.Text = "User Name"
        Me.ToolTip.SetToolTip(Me.UserNameBtn, "Gets the user name of the person who is currently logged on to the Windows operat" & _
        "ing system.")
        Me.UserNameBtn.UseVisualStyleBackColor = True
        '
        'UserDomainNameBtn
        '
        Me.UserDomainNameBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDomainNameBtn.ForeColor = System.Drawing.Color.Black
        Me.UserDomainNameBtn.Location = New System.Drawing.Point(112, 186)
        Me.UserDomainNameBtn.Name = "UserDomainNameBtn"
        Me.UserDomainNameBtn.Size = New System.Drawing.Size(100, 75)
        Me.UserDomainNameBtn.TabIndex = 7
        Me.UserDomainNameBtn.Text = "User Domain Name"
        Me.ToolTip.SetToolTip(Me.UserDomainNameBtn, "Gets the network domain name associated with the current user.")
        Me.UserDomainNameBtn.UseVisualStyleBackColor = True
        '
        'TickCountBtn
        '
        Me.TickCountBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TickCountBtn.ForeColor = System.Drawing.Color.Black
        Me.TickCountBtn.Location = New System.Drawing.Point(6, 186)
        Me.TickCountBtn.Name = "TickCountBtn"
        Me.TickCountBtn.Size = New System.Drawing.Size(100, 75)
        Me.TickCountBtn.TabIndex = 6
        Me.TickCountBtn.Text = "Tick Count"
        Me.ToolTip.SetToolTip(Me.TickCountBtn, "Gets the number of milliseconds elapsed since the system started.")
        Me.TickCountBtn.UseVisualStyleBackColor = True
        '
        'SystemPageSizeBtn
        '
        Me.SystemPageSizeBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemPageSizeBtn.ForeColor = System.Drawing.Color.Black
        Me.SystemPageSizeBtn.Location = New System.Drawing.Point(218, 105)
        Me.SystemPageSizeBtn.Name = "SystemPageSizeBtn"
        Me.SystemPageSizeBtn.Size = New System.Drawing.Size(100, 75)
        Me.SystemPageSizeBtn.TabIndex = 5
        Me.SystemPageSizeBtn.Text = "System Page Size"
        Me.ToolTip.SetToolTip(Me.SystemPageSizeBtn, "Gets the amount of memory for an operating system's page file.")
        Me.SystemPageSizeBtn.UseVisualStyleBackColor = True
        '
        'SystemDirectoryBtn
        '
        Me.SystemDirectoryBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemDirectoryBtn.ForeColor = System.Drawing.Color.Black
        Me.SystemDirectoryBtn.Location = New System.Drawing.Point(112, 105)
        Me.SystemDirectoryBtn.Name = "SystemDirectoryBtn"
        Me.SystemDirectoryBtn.Size = New System.Drawing.Size(100, 75)
        Me.SystemDirectoryBtn.TabIndex = 4
        Me.SystemDirectoryBtn.Text = "System Directory"
        Me.ToolTip.SetToolTip(Me.SystemDirectoryBtn, "Gets the fully qualified path of the system directory.")
        Me.SystemDirectoryBtn.UseVisualStyleBackColor = True
        '
        'ProcessorCountBtn
        '
        Me.ProcessorCountBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessorCountBtn.ForeColor = System.Drawing.Color.Black
        Me.ProcessorCountBtn.Location = New System.Drawing.Point(6, 105)
        Me.ProcessorCountBtn.Name = "ProcessorCountBtn"
        Me.ProcessorCountBtn.Size = New System.Drawing.Size(100, 75)
        Me.ProcessorCountBtn.TabIndex = 3
        Me.ProcessorCountBtn.Text = "Processor Count"
        Me.ToolTip.SetToolTip(Me.ProcessorCountBtn, "Gets the number of processors on the current machine.")
        Me.ProcessorCountBtn.UseVisualStyleBackColor = True
        '
        'OSVersionBtn
        '
        Me.OSVersionBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSVersionBtn.ForeColor = System.Drawing.Color.Black
        Me.OSVersionBtn.Location = New System.Drawing.Point(218, 24)
        Me.OSVersionBtn.Name = "OSVersionBtn"
        Me.OSVersionBtn.Size = New System.Drawing.Size(100, 75)
        Me.OSVersionBtn.TabIndex = 2
        Me.OSVersionBtn.Text = "OS Version"
        Me.ToolTip.SetToolTip(Me.OSVersionBtn, "Gets the current platform identifier and version number.")
        Me.OSVersionBtn.UseVisualStyleBackColor = True
        '
        'MachineNameBtn
        '
        Me.MachineNameBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNameBtn.ForeColor = System.Drawing.Color.Black
        Me.MachineNameBtn.Location = New System.Drawing.Point(112, 24)
        Me.MachineNameBtn.Name = "MachineNameBtn"
        Me.MachineNameBtn.Size = New System.Drawing.Size(100, 75)
        Me.MachineNameBtn.TabIndex = 1
        Me.MachineNameBtn.Text = "Machine Name"
        Me.ToolTip.SetToolTip(Me.MachineNameBtn, "Gets the NetBIOS name of this local computer.")
        Me.MachineNameBtn.UseVisualStyleBackColor = True
        '
        'Is64BitOperatingSystemBtn
        '
        Me.Is64BitOperatingSystemBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Is64BitOperatingSystemBtn.ForeColor = System.Drawing.Color.Black
        Me.Is64BitOperatingSystemBtn.Location = New System.Drawing.Point(6, 24)
        Me.Is64BitOperatingSystemBtn.Name = "Is64BitOperatingSystemBtn"
        Me.Is64BitOperatingSystemBtn.Size = New System.Drawing.Size(100, 75)
        Me.Is64BitOperatingSystemBtn.TabIndex = 0
        Me.Is64BitOperatingSystemBtn.Text = "Is 64 Bit Operating System"
        Me.ToolTip.SetToolTip(Me.Is64BitOperatingSystemBtn, "Determines whether the current operating system is a 64-bit operating system.")
        Me.Is64BitOperatingSystemBtn.UseVisualStyleBackColor = True
        '
        'ClockGroupBox
        '
        Me.ClockGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ClockGroupBox.Controls.Add(Me.LocalTimeBtn)
        Me.ClockGroupBox.Controls.Add(Me.GMTTimeBtn)
        Me.ClockGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockGroupBox.ForeColor = System.Drawing.Color.White
        Me.ClockGroupBox.Location = New System.Drawing.Point(356, 24)
        Me.ClockGroupBox.Name = "ClockGroupBox"
        Me.ClockGroupBox.Size = New System.Drawing.Size(218, 80)
        Me.ClockGroupBox.TabIndex = 2
        Me.ClockGroupBox.TabStop = False
        Me.ClockGroupBox.Text = "Clock"
        '
        'LocalTimeBtn
        '
        Me.LocalTimeBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalTimeBtn.ForeColor = System.Drawing.Color.Black
        Me.LocalTimeBtn.Location = New System.Drawing.Point(112, 24)
        Me.LocalTimeBtn.Name = "LocalTimeBtn"
        Me.LocalTimeBtn.Size = New System.Drawing.Size(100, 50)
        Me.LocalTimeBtn.TabIndex = 1
        Me.LocalTimeBtn.Text = "Local Time"
        Me.ToolTip.SetToolTip(Me.LocalTimeBtn, "Gets the current local date and time on this computer.")
        Me.LocalTimeBtn.UseVisualStyleBackColor = True
        '
        'GMTTimeBtn
        '
        Me.GMTTimeBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GMTTimeBtn.ForeColor = System.Drawing.Color.Black
        Me.GMTTimeBtn.Location = New System.Drawing.Point(6, 24)
        Me.GMTTimeBtn.Name = "GMTTimeBtn"
        Me.GMTTimeBtn.Size = New System.Drawing.Size(100, 50)
        Me.GMTTimeBtn.TabIndex = 0
        Me.GMTTimeBtn.Text = "GMT Time"
        Me.ToolTip.SetToolTip(Me.GMTTimeBtn, "Gets the current local date and time on the computer, expressed as a UTC (GMT) ti" & _
        "me.")
        Me.GMTTimeBtn.UseVisualStyleBackColor = True
        '
        'FileSystemGroupBox
        '
        Me.FileSystemGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.FileSystemGroupBox.Controls.Add(Me.DrivesBtn)
        Me.FileSystemGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemGroupBox.ForeColor = System.Drawing.Color.White
        Me.FileSystemGroupBox.Location = New System.Drawing.Point(580, 24)
        Me.FileSystemGroupBox.Name = "FileSystemGroupBox"
        Me.FileSystemGroupBox.Size = New System.Drawing.Size(87, 80)
        Me.FileSystemGroupBox.TabIndex = 3
        Me.FileSystemGroupBox.TabStop = False
        Me.FileSystemGroupBox.Text = "File System"
        '
        'DrivesBtn
        '
        Me.DrivesBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrivesBtn.ForeColor = System.Drawing.Color.Black
        Me.DrivesBtn.Location = New System.Drawing.Point(6, 24)
        Me.DrivesBtn.Name = "DrivesBtn"
        Me.DrivesBtn.Size = New System.Drawing.Size(75, 50)
        Me.DrivesBtn.TabIndex = 0
        Me.DrivesBtn.Text = "Drive Count"
        Me.ToolTip.SetToolTip(Me.DrivesBtn, "Gets the number of drives.")
        Me.DrivesBtn.UseVisualStyleBackColor = True
        '
        'InfoGroupBox
        '
        Me.InfoGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.InfoGroupBox.Controls.Add(Me.TotalVirtualMemoryBtn)
        Me.InfoGroupBox.Controls.Add(Me.TotalPhysicalMemoryBtn)
        Me.InfoGroupBox.Controls.Add(Me.OSVersionInfoBtn)
        Me.InfoGroupBox.Controls.Add(Me.OSPlatformBtn)
        Me.InfoGroupBox.Controls.Add(Me.OSFullNameBtn)
        Me.InfoGroupBox.Controls.Add(Me.InstalledUICultureNativeNameBtn)
        Me.InfoGroupBox.Controls.Add(Me.AvailableVirtualMemoryBtn)
        Me.InfoGroupBox.Controls.Add(Me.AvailablePhysicalMemoryBtn)
        Me.InfoGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGroupBox.ForeColor = System.Drawing.Color.White
        Me.InfoGroupBox.Location = New System.Drawing.Point(356, 110)
        Me.InfoGroupBox.Name = "InfoGroupBox"
        Me.InfoGroupBox.Size = New System.Drawing.Size(218, 328)
        Me.InfoGroupBox.TabIndex = 4
        Me.InfoGroupBox.TabStop = False
        Me.InfoGroupBox.Text = "Info"
        '
        'TotalVirtualMemoryBtn
        '
        Me.TotalVirtualMemoryBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVirtualMemoryBtn.ForeColor = System.Drawing.Color.Black
        Me.TotalVirtualMemoryBtn.Location = New System.Drawing.Point(112, 252)
        Me.TotalVirtualMemoryBtn.Name = "TotalVirtualMemoryBtn"
        Me.TotalVirtualMemoryBtn.Size = New System.Drawing.Size(100, 70)
        Me.TotalVirtualMemoryBtn.TabIndex = 7
        Me.TotalVirtualMemoryBtn.Text = "Total Virtual Memory"
        Me.ToolTip.SetToolTip(Me.TotalVirtualMemoryBtn, "Gets the total amount of virtual address space available for the computer.")
        Me.TotalVirtualMemoryBtn.UseVisualStyleBackColor = True
        '
        'TotalPhysicalMemoryBtn
        '
        Me.TotalPhysicalMemoryBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPhysicalMemoryBtn.ForeColor = System.Drawing.Color.Black
        Me.TotalPhysicalMemoryBtn.Location = New System.Drawing.Point(6, 252)
        Me.TotalPhysicalMemoryBtn.Name = "TotalPhysicalMemoryBtn"
        Me.TotalPhysicalMemoryBtn.Size = New System.Drawing.Size(100, 70)
        Me.TotalPhysicalMemoryBtn.TabIndex = 6
        Me.TotalPhysicalMemoryBtn.Text = "Total Physical Memory"
        Me.ToolTip.SetToolTip(Me.TotalPhysicalMemoryBtn, "Gets the total amount of physical memory for the computer.")
        Me.TotalPhysicalMemoryBtn.UseVisualStyleBackColor = True
        '
        'OSVersionInfoBtn
        '
        Me.OSVersionInfoBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSVersionInfoBtn.ForeColor = System.Drawing.Color.Black
        Me.OSVersionInfoBtn.Location = New System.Drawing.Point(112, 176)
        Me.OSVersionInfoBtn.Name = "OSVersionInfoBtn"
        Me.OSVersionInfoBtn.Size = New System.Drawing.Size(100, 70)
        Me.OSVersionInfoBtn.TabIndex = 5
        Me.OSVersionInfoBtn.Text = "OS Version"
        Me.ToolTip.SetToolTip(Me.OSVersionInfoBtn, "Gets the version of the computer's operating system.")
        Me.OSVersionInfoBtn.UseVisualStyleBackColor = True
        '
        'OSPlatformBtn
        '
        Me.OSPlatformBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSPlatformBtn.ForeColor = System.Drawing.Color.Black
        Me.OSPlatformBtn.Location = New System.Drawing.Point(6, 176)
        Me.OSPlatformBtn.Name = "OSPlatformBtn"
        Me.OSPlatformBtn.Size = New System.Drawing.Size(100, 70)
        Me.OSPlatformBtn.TabIndex = 4
        Me.OSPlatformBtn.Text = "OS Platform"
        Me.ToolTip.SetToolTip(Me.OSPlatformBtn, "Gets the platform identifier for the operating system of the computer.")
        Me.OSPlatformBtn.UseVisualStyleBackColor = True
        '
        'OSFullNameBtn
        '
        Me.OSFullNameBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSFullNameBtn.ForeColor = System.Drawing.Color.Black
        Me.OSFullNameBtn.Location = New System.Drawing.Point(112, 100)
        Me.OSFullNameBtn.Name = "OSFullNameBtn"
        Me.OSFullNameBtn.Size = New System.Drawing.Size(100, 70)
        Me.OSFullNameBtn.TabIndex = 3
        Me.OSFullNameBtn.Text = "OS Full Name"
        Me.ToolTip.SetToolTip(Me.OSFullNameBtn, "Gets the full operating system name.")
        Me.OSFullNameBtn.UseVisualStyleBackColor = True
        '
        'InstalledUICultureNativeNameBtn
        '
        Me.InstalledUICultureNativeNameBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstalledUICultureNativeNameBtn.ForeColor = System.Drawing.Color.Black
        Me.InstalledUICultureNativeNameBtn.Location = New System.Drawing.Point(6, 100)
        Me.InstalledUICultureNativeNameBtn.Name = "InstalledUICultureNativeNameBtn"
        Me.InstalledUICultureNativeNameBtn.Size = New System.Drawing.Size(100, 70)
        Me.InstalledUICultureNativeNameBtn.TabIndex = 2
        Me.InstalledUICultureNativeNameBtn.Text = "Installed UI Culture Native Name"
        Me.ToolTip.SetToolTip(Me.InstalledUICultureNativeNameBtn, "Gets the culture name, consisting of the language, the country/region, and the op" & _
        "tional script, that the culture is set to display.")
        Me.InstalledUICultureNativeNameBtn.UseVisualStyleBackColor = True
        '
        'AvailableVirtualMemoryBtn
        '
        Me.AvailableVirtualMemoryBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableVirtualMemoryBtn.ForeColor = System.Drawing.Color.Black
        Me.AvailableVirtualMemoryBtn.Location = New System.Drawing.Point(112, 24)
        Me.AvailableVirtualMemoryBtn.Name = "AvailableVirtualMemoryBtn"
        Me.AvailableVirtualMemoryBtn.Size = New System.Drawing.Size(100, 70)
        Me.AvailableVirtualMemoryBtn.TabIndex = 1
        Me.AvailableVirtualMemoryBtn.Text = "Available Virtual Memory"
        Me.ToolTip.SetToolTip(Me.AvailableVirtualMemoryBtn, "Gets the total amount of the computer's free virtual address space.")
        Me.AvailableVirtualMemoryBtn.UseVisualStyleBackColor = True
        '
        'AvailablePhysicalMemoryBtn
        '
        Me.AvailablePhysicalMemoryBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailablePhysicalMemoryBtn.ForeColor = System.Drawing.Color.Black
        Me.AvailablePhysicalMemoryBtn.Location = New System.Drawing.Point(6, 24)
        Me.AvailablePhysicalMemoryBtn.Name = "AvailablePhysicalMemoryBtn"
        Me.AvailablePhysicalMemoryBtn.Size = New System.Drawing.Size(100, 70)
        Me.AvailablePhysicalMemoryBtn.TabIndex = 0
        Me.AvailablePhysicalMemoryBtn.Text = "Available Physical Memory"
        Me.ToolTip.SetToolTip(Me.AvailablePhysicalMemoryBtn, "Gets the total amount of free physical memory for the computer.")
        Me.AvailablePhysicalMemoryBtn.UseVisualStyleBackColor = True
        '
        'KeyboardGroupBox
        '
        Me.KeyboardGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.KeyboardGroupBox.Controls.Add(Me.ShiftKeyDownBtn)
        Me.KeyboardGroupBox.Controls.Add(Me.ScrollLockBtn)
        Me.KeyboardGroupBox.Controls.Add(Me.NumLockBtn)
        Me.KeyboardGroupBox.Controls.Add(Me.CtrlKeyDownBtn)
        Me.KeyboardGroupBox.Controls.Add(Me.CapsLockBtn)
        Me.KeyboardGroupBox.Controls.Add(Me.AltKeyDownBtn)
        Me.KeyboardGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyboardGroupBox.ForeColor = System.Drawing.Color.White
        Me.KeyboardGroupBox.Location = New System.Drawing.Point(25, 297)
        Me.KeyboardGroupBox.Name = "KeyboardGroupBox"
        Me.KeyboardGroupBox.Size = New System.Drawing.Size(250, 136)
        Me.KeyboardGroupBox.TabIndex = 5
        Me.KeyboardGroupBox.TabStop = False
        Me.KeyboardGroupBox.Text = "Keyboard"
        '
        'ShiftKeyDownBtn
        '
        Me.ShiftKeyDownBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftKeyDownBtn.ForeColor = System.Drawing.Color.Black
        Me.ShiftKeyDownBtn.Location = New System.Drawing.Point(168, 24)
        Me.ShiftKeyDownBtn.Name = "ShiftKeyDownBtn"
        Me.ShiftKeyDownBtn.Size = New System.Drawing.Size(75, 50)
        Me.ShiftKeyDownBtn.TabIndex = 2
        Me.ShiftKeyDownBtn.Text = "Shift Key Down"
        Me.ToolTip.SetToolTip(Me.ShiftKeyDownBtn, "Gets a Boolean indicating if a SHIFT key is down.")
        Me.ShiftKeyDownBtn.UseVisualStyleBackColor = True
        '
        'ScrollLockBtn
        '
        Me.ScrollLockBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScrollLockBtn.ForeColor = System.Drawing.Color.Black
        Me.ScrollLockBtn.Location = New System.Drawing.Point(169, 80)
        Me.ScrollLockBtn.Name = "ScrollLockBtn"
        Me.ScrollLockBtn.Size = New System.Drawing.Size(75, 50)
        Me.ScrollLockBtn.TabIndex = 5
        Me.ScrollLockBtn.Text = "Scroll Lock"
        Me.ToolTip.SetToolTip(Me.ScrollLockBtn, "Gets a Boolean indicating whether the SCROLL LOCK key is on.")
        Me.ScrollLockBtn.UseVisualStyleBackColor = True
        '
        'NumLockBtn
        '
        Me.NumLockBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumLockBtn.ForeColor = System.Drawing.Color.Black
        Me.NumLockBtn.Location = New System.Drawing.Point(87, 80)
        Me.NumLockBtn.Name = "NumLockBtn"
        Me.NumLockBtn.Size = New System.Drawing.Size(75, 50)
        Me.NumLockBtn.TabIndex = 4
        Me.NumLockBtn.Text = "Num Lock"
        Me.ToolTip.SetToolTip(Me.NumLockBtn, "Gets a Boolean indicating if the NUM LOCK key is on.")
        Me.NumLockBtn.UseVisualStyleBackColor = True
        '
        'CtrlKeyDownBtn
        '
        Me.CtrlKeyDownBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlKeyDownBtn.ForeColor = System.Drawing.Color.Black
        Me.CtrlKeyDownBtn.Location = New System.Drawing.Point(87, 24)
        Me.CtrlKeyDownBtn.Name = "CtrlKeyDownBtn"
        Me.CtrlKeyDownBtn.Size = New System.Drawing.Size(75, 50)
        Me.CtrlKeyDownBtn.TabIndex = 1
        Me.CtrlKeyDownBtn.Text = "Ctrl Key Down"
        Me.ToolTip.SetToolTip(Me.CtrlKeyDownBtn, "Gets a Boolean indicating if a CTRL key is down.")
        Me.CtrlKeyDownBtn.UseVisualStyleBackColor = True
        '
        'CapsLockBtn
        '
        Me.CapsLockBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapsLockBtn.ForeColor = System.Drawing.Color.Black
        Me.CapsLockBtn.Location = New System.Drawing.Point(6, 80)
        Me.CapsLockBtn.Name = "CapsLockBtn"
        Me.CapsLockBtn.Size = New System.Drawing.Size(75, 50)
        Me.CapsLockBtn.TabIndex = 3
        Me.CapsLockBtn.Text = "Caps Lock"
        Me.ToolTip.SetToolTip(Me.CapsLockBtn, "Gets a Boolean indicating if CAPS LOCK is turned on.")
        Me.CapsLockBtn.UseVisualStyleBackColor = True
        '
        'AltKeyDownBtn
        '
        Me.AltKeyDownBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltKeyDownBtn.ForeColor = System.Drawing.Color.Black
        Me.AltKeyDownBtn.Location = New System.Drawing.Point(6, 24)
        Me.AltKeyDownBtn.Name = "AltKeyDownBtn"
        Me.AltKeyDownBtn.Size = New System.Drawing.Size(75, 50)
        Me.AltKeyDownBtn.TabIndex = 0
        Me.AltKeyDownBtn.Text = "Alt Key Down"
        Me.ToolTip.SetToolTip(Me.AltKeyDownBtn, "Gets a Boolean indicating if the ALT key is down.")
        Me.AltKeyDownBtn.UseVisualStyleBackColor = True
        '
        'MouseGroupBox
        '
        Me.MouseGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.MouseGroupBox.Controls.Add(Me.WheelScrollLinesBtn)
        Me.MouseGroupBox.Controls.Add(Me.WheelExistsBtn)
        Me.MouseGroupBox.Controls.Add(Me.ButtonsSwappedBtn)
        Me.MouseGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MouseGroupBox.ForeColor = System.Drawing.Color.White
        Me.MouseGroupBox.Location = New System.Drawing.Point(673, 24)
        Me.MouseGroupBox.Name = "MouseGroupBox"
        Me.MouseGroupBox.Size = New System.Drawing.Size(87, 217)
        Me.MouseGroupBox.TabIndex = 6
        Me.MouseGroupBox.TabStop = False
        Me.MouseGroupBox.Text = "Mouse"
        '
        'WheelScrollLinesBtn
        '
        Me.WheelScrollLinesBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WheelScrollLinesBtn.ForeColor = System.Drawing.Color.Black
        Me.WheelScrollLinesBtn.Location = New System.Drawing.Point(6, 136)
        Me.WheelScrollLinesBtn.Name = "WheelScrollLinesBtn"
        Me.WheelScrollLinesBtn.Size = New System.Drawing.Size(75, 75)
        Me.WheelScrollLinesBtn.TabIndex = 2
        Me.WheelScrollLinesBtn.Text = "Wheel Scroll Lines"
        Me.ToolTip.SetToolTip(Me.WheelScrollLinesBtn, "Gets a number that indicates how much to scroll when the mouse wheel is rotated o" & _
        "ne notch.")
        Me.WheelScrollLinesBtn.UseVisualStyleBackColor = True
        '
        'WheelExistsBtn
        '
        Me.WheelExistsBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WheelExistsBtn.ForeColor = System.Drawing.Color.Black
        Me.WheelExistsBtn.Location = New System.Drawing.Point(6, 80)
        Me.WheelExistsBtn.Name = "WheelExistsBtn"
        Me.WheelExistsBtn.Size = New System.Drawing.Size(75, 50)
        Me.WheelExistsBtn.TabIndex = 1
        Me.WheelExistsBtn.Text = "Wheel Exists"
        Me.ToolTip.SetToolTip(Me.WheelExistsBtn, "Gets a Boolean that indicates if the mouse has a scroll wheel.")
        Me.WheelExistsBtn.UseVisualStyleBackColor = True
        '
        'ButtonsSwappedBtn
        '
        Me.ButtonsSwappedBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonsSwappedBtn.ForeColor = System.Drawing.Color.Black
        Me.ButtonsSwappedBtn.Location = New System.Drawing.Point(6, 24)
        Me.ButtonsSwappedBtn.Name = "ButtonsSwappedBtn"
        Me.ButtonsSwappedBtn.Size = New System.Drawing.Size(75, 50)
        Me.ButtonsSwappedBtn.TabIndex = 0
        Me.ButtonsSwappedBtn.Text = "Buttons Swapped"
        Me.ToolTip.SetToolTip(Me.ButtonsSwappedBtn, "Gets a Boolean that indicates if the functionality of the left and right mouse bu" & _
        "ttons has been swapped.")
        Me.ButtonsSwappedBtn.UseVisualStyleBackColor = True
        '
        'NetworkGroupBox
        '
        Me.NetworkGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.NetworkGroupBox.Controls.Add(Me.IsAvailableBtn)
        Me.NetworkGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkGroupBox.ForeColor = System.Drawing.Color.White
        Me.NetworkGroupBox.Location = New System.Drawing.Point(673, 247)
        Me.NetworkGroupBox.Name = "NetworkGroupBox"
        Me.NetworkGroupBox.Size = New System.Drawing.Size(87, 80)
        Me.NetworkGroupBox.TabIndex = 7
        Me.NetworkGroupBox.TabStop = False
        Me.NetworkGroupBox.Text = "Network"
        '
        'IsAvailableBtn
        '
        Me.IsAvailableBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsAvailableBtn.ForeColor = System.Drawing.Color.Black
        Me.IsAvailableBtn.Location = New System.Drawing.Point(6, 24)
        Me.IsAvailableBtn.Name = "IsAvailableBtn"
        Me.IsAvailableBtn.Size = New System.Drawing.Size(75, 50)
        Me.IsAvailableBtn.TabIndex = 0
        Me.IsAvailableBtn.Text = "Is Available"
        Me.ToolTip.SetToolTip(Me.IsAvailableBtn, "Indicates whether a computer is connected to a network.")
        Me.IsAvailableBtn.UseVisualStyleBackColor = True
        '
        'ScreenGroupBox
        '
        Me.ScreenGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ScreenGroupBox.Controls.Add(Me.WorkingAreaBtn)
        Me.ScreenGroupBox.Controls.Add(Me.PrimaryBtn)
        Me.ScreenGroupBox.Controls.Add(Me.DeviceNameBtn)
        Me.ScreenGroupBox.Controls.Add(Me.BoundsBtn)
        Me.ScreenGroupBox.Controls.Add(Me.BitsPerPixelBtn)
        Me.ScreenGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenGroupBox.ForeColor = System.Drawing.Color.White
        Me.ScreenGroupBox.Location = New System.Drawing.Point(580, 110)
        Me.ScreenGroupBox.Name = "ScreenGroupBox"
        Me.ScreenGroupBox.Size = New System.Drawing.Size(87, 304)
        Me.ScreenGroupBox.TabIndex = 8
        Me.ScreenGroupBox.TabStop = False
        Me.ScreenGroupBox.Text = "Screen"
        '
        'WorkingAreaBtn
        '
        Me.WorkingAreaBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingAreaBtn.ForeColor = System.Drawing.Color.Black
        Me.WorkingAreaBtn.Location = New System.Drawing.Point(6, 248)
        Me.WorkingAreaBtn.Name = "WorkingAreaBtn"
        Me.WorkingAreaBtn.Size = New System.Drawing.Size(75, 50)
        Me.WorkingAreaBtn.TabIndex = 4
        Me.WorkingAreaBtn.Text = "Working Area"
        Me.ToolTip.SetToolTip(Me.WorkingAreaBtn, "Gets the working area of the display. The working area is the desktop area of the" & _
        " display, excluding taskbars, docked windows, and docked tool bars.")
        Me.WorkingAreaBtn.UseVisualStyleBackColor = True
        '
        'PrimaryBtn
        '
        Me.PrimaryBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrimaryBtn.ForeColor = System.Drawing.Color.Black
        Me.PrimaryBtn.Location = New System.Drawing.Point(6, 192)
        Me.PrimaryBtn.Name = "PrimaryBtn"
        Me.PrimaryBtn.Size = New System.Drawing.Size(75, 50)
        Me.PrimaryBtn.TabIndex = 3
        Me.PrimaryBtn.Text = "Primary"
        Me.ToolTip.SetToolTip(Me.PrimaryBtn, "Gets a value indicating whether a particular display is the primary device.")
        Me.PrimaryBtn.UseVisualStyleBackColor = True
        '
        'DeviceNameBtn
        '
        Me.DeviceNameBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeviceNameBtn.ForeColor = System.Drawing.Color.Black
        Me.DeviceNameBtn.Location = New System.Drawing.Point(6, 136)
        Me.DeviceNameBtn.Name = "DeviceNameBtn"
        Me.DeviceNameBtn.Size = New System.Drawing.Size(75, 50)
        Me.DeviceNameBtn.TabIndex = 2
        Me.DeviceNameBtn.Text = "Device Name"
        Me.ToolTip.SetToolTip(Me.DeviceNameBtn, "Gets the device name associated with a display.")
        Me.DeviceNameBtn.UseVisualStyleBackColor = True
        '
        'BoundsBtn
        '
        Me.BoundsBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoundsBtn.ForeColor = System.Drawing.Color.Black
        Me.BoundsBtn.Location = New System.Drawing.Point(6, 80)
        Me.BoundsBtn.Name = "BoundsBtn"
        Me.BoundsBtn.Size = New System.Drawing.Size(75, 50)
        Me.BoundsBtn.TabIndex = 1
        Me.BoundsBtn.Text = "Bounds"
        Me.ToolTip.SetToolTip(Me.BoundsBtn, "Gets the bounds of the display.")
        Me.BoundsBtn.UseVisualStyleBackColor = True
        '
        'BitsPerPixelBtn
        '
        Me.BitsPerPixelBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BitsPerPixelBtn.ForeColor = System.Drawing.Color.Black
        Me.BitsPerPixelBtn.Location = New System.Drawing.Point(6, 24)
        Me.BitsPerPixelBtn.Name = "BitsPerPixelBtn"
        Me.BitsPerPixelBtn.Size = New System.Drawing.Size(75, 50)
        Me.BitsPerPixelBtn.TabIndex = 0
        Me.BitsPerPixelBtn.Text = "Bits Per Pixel"
        Me.ToolTip.SetToolTip(Me.BitsPerPixelBtn, "Gets the number of bits of memory, associated with one pixel of data.")
        Me.BitsPerPixelBtn.UseVisualStyleBackColor = True
        '
        'PortsClipboard
        '
        Me.PortsClipboard.BackColor = System.Drawing.Color.Transparent
        Me.PortsClipboard.Controls.Add(Me.CountBtn)
        Me.PortsClipboard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortsClipboard.ForeColor = System.Drawing.Color.White
        Me.PortsClipboard.Location = New System.Drawing.Point(678, 339)
        Me.PortsClipboard.Name = "PortsClipboard"
        Me.PortsClipboard.Size = New System.Drawing.Size(87, 80)
        Me.PortsClipboard.TabIndex = 9
        Me.PortsClipboard.TabStop = False
        Me.PortsClipboard.Text = "Ports"
        '
        'CountBtn
        '
        Me.CountBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountBtn.ForeColor = System.Drawing.Color.Black
        Me.CountBtn.Location = New System.Drawing.Point(6, 24)
        Me.CountBtn.Name = "CountBtn"
        Me.CountBtn.Size = New System.Drawing.Size(75, 50)
        Me.CountBtn.TabIndex = 0
        Me.CountBtn.Text = "Count"
        Me.ToolTip.SetToolTip(Me.CountBtn, "Gets the number of serial ports on the computer.")
        Me.CountBtn.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Computer Info"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.PortsClipboard)
        Me.Controls.Add(Me.ScreenGroupBox)
        Me.Controls.Add(Me.NetworkGroupBox)
        Me.Controls.Add(Me.MouseGroupBox)
        Me.Controls.Add(Me.KeyboardGroupBox)
        Me.Controls.Add(Me.InfoGroupBox)
        Me.Controls.Add(Me.FileSystemGroupBox)
        Me.Controls.Add(Me.ClockGroupBox)
        Me.Controls.Add(Me.EnvironmentGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Information"
        Me.EnvironmentGroupBox.ResumeLayout(False)
        Me.ClockGroupBox.ResumeLayout(False)
        Me.FileSystemGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.ResumeLayout(False)
        Me.KeyboardGroupBox.ResumeLayout(False)
        Me.MouseGroupBox.ResumeLayout(False)
        Me.NetworkGroupBox.ResumeLayout(False)
        Me.ScreenGroupBox.ResumeLayout(False)
        Me.PortsClipboard.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EnvironmentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents UserNameBtn As System.Windows.Forms.Button
    Friend WithEvents UserDomainNameBtn As System.Windows.Forms.Button
    Friend WithEvents TickCountBtn As System.Windows.Forms.Button
    Friend WithEvents SystemPageSizeBtn As System.Windows.Forms.Button
    Friend WithEvents SystemDirectoryBtn As System.Windows.Forms.Button
    Friend WithEvents ProcessorCountBtn As System.Windows.Forms.Button
    Friend WithEvents OSVersionBtn As System.Windows.Forms.Button
    Friend WithEvents MachineNameBtn As System.Windows.Forms.Button
    Friend WithEvents Is64BitOperatingSystemBtn As System.Windows.Forms.Button
    Friend WithEvents ClockGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GMTTimeBtn As System.Windows.Forms.Button
    Friend WithEvents LocalTimeBtn As System.Windows.Forms.Button
    Friend WithEvents FileSystemGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DrivesBtn As System.Windows.Forms.Button
    Friend WithEvents InfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TotalVirtualMemoryBtn As System.Windows.Forms.Button
    Friend WithEvents TotalPhysicalMemoryBtn As System.Windows.Forms.Button
    Friend WithEvents OSVersionInfoBtn As System.Windows.Forms.Button
    Friend WithEvents OSPlatformBtn As System.Windows.Forms.Button
    Friend WithEvents OSFullNameBtn As System.Windows.Forms.Button
    Friend WithEvents InstalledUICultureNativeNameBtn As System.Windows.Forms.Button
    Friend WithEvents AvailableVirtualMemoryBtn As System.Windows.Forms.Button
    Friend WithEvents AvailablePhysicalMemoryBtn As System.Windows.Forms.Button
    Friend WithEvents KeyboardGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AltKeyDownBtn As System.Windows.Forms.Button
    Friend WithEvents ShiftKeyDownBtn As System.Windows.Forms.Button
    Friend WithEvents ScrollLockBtn As System.Windows.Forms.Button
    Friend WithEvents NumLockBtn As System.Windows.Forms.Button
    Friend WithEvents CtrlKeyDownBtn As System.Windows.Forms.Button
    Friend WithEvents CapsLockBtn As System.Windows.Forms.Button
    Friend WithEvents MouseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonsSwappedBtn As System.Windows.Forms.Button
    Friend WithEvents WheelScrollLinesBtn As System.Windows.Forms.Button
    Friend WithEvents WheelExistsBtn As System.Windows.Forms.Button
    Friend WithEvents NetworkGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents IsAvailableBtn As System.Windows.Forms.Button
    Friend WithEvents ScreenGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BoundsBtn As System.Windows.Forms.Button
    Friend WithEvents BitsPerPixelBtn As System.Windows.Forms.Button
    Friend WithEvents WorkingAreaBtn As System.Windows.Forms.Button
    Friend WithEvents PrimaryBtn As System.Windows.Forms.Button
    Friend WithEvents DeviceNameBtn As System.Windows.Forms.Button
    Friend WithEvents PortsClipboard As System.Windows.Forms.GroupBox
    Friend WithEvents CountBtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
