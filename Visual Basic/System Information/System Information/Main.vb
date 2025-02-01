Public Class Main

    Private Sub Is64BitOperatingSystemBtn_Click() Handles Is64BitOperatingSystemBtn.Click
        MessageBox.Show(Environment.Is64BitOperatingSystem.ToString, "Is 64 Bit Operating System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MachineNameBtn_Click() Handles MachineNameBtn.Click
        MessageBox.Show(Environment.MachineName, "Machine Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OSVersionBtn_Click() Handles OSVersionBtn.Click
        MessageBox.Show(Environment.OSVersion.ToString, "OS Version", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ProcessorCountBtn_Click() Handles ProcessorCountBtn.Click
        MessageBox.Show(Environment.ProcessorCount.ToString, "Processor Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SystemDirectoryBtn_Click() Handles SystemDirectoryBtn.Click
        MessageBox.Show(Environment.SystemDirectory, "System Directory", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SystemPageSizeBtn_Click() Handles SystemPageSizeBtn.Click
        MessageBox.Show(Environment.SystemPageSize.ToString, "System Page Size", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TickCountBtn_Click() Handles TickCountBtn.Click
        MessageBox.Show(Environment.TickCount.ToString, "Tick Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UserDomainNameBtn_Click() Handles UserDomainNameBtn.Click
        MessageBox.Show(Environment.UserDomainName, "User Domain Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UserNameBtn_Click() Handles UserNameBtn.Click
        MessageBox.Show(Environment.UserName, "User Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GMTTimeBtn_Click() Handles GMTTimeBtn.Click
        MessageBox.Show(My.Computer.Clock.GmtTime.ToString, "GMT Time", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LocalTimeBtn_Click() Handles LocalTimeBtn.Click
        MessageBox.Show(My.Computer.Clock.LocalTime.ToString, "Local Time", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DrivesBtn_Click() Handles DrivesBtn.Click
        MessageBox.Show(My.Computer.FileSystem.Drives.Count.ToString, "Drive Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AvailablePhysicalMemoryBtn_Click() Handles AvailablePhysicalMemoryBtn.Click
        MessageBox.Show(My.Computer.Info.AvailablePhysicalMemory.ToString, "Available Physical Memory", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AvailableVirtualMemoryBtn_Click() Handles AvailableVirtualMemoryBtn.Click
        MessageBox.Show(My.Computer.Info.AvailableVirtualMemory.ToString, "Available Virtual Memory", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub InstalledUICultureBtn_Click() Handles InstalledUICultureNativeNameBtn.Click
        MessageBox.Show(My.Computer.Info.InstalledUICulture.NativeName, "Native Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OSFullNameBtn_Click() Handles OSFullNameBtn.Click
        MessageBox.Show(My.Computer.Info.OSFullName, "OS Full Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OSPlatformBtn_Click() Handles OSPlatformBtn.Click
        MessageBox.Show(My.Computer.Info.OSPlatform, "OS Platform", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OSVersionInfoBtn_Click() Handles OSVersionInfoBtn.Click
        MessageBox.Show(My.Computer.Info.OSVersion, "OS Version", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TotalPhysicalMemoryBtn_Click() Handles TotalPhysicalMemoryBtn.Click
        MessageBox.Show(My.Computer.Info.TotalPhysicalMemory.ToString, "TotalPhysicalMemory", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TotalVirtualMemoryBtn_Click() Handles TotalVirtualMemoryBtn.Click
        MessageBox.Show(My.Computer.Info.TotalVirtualMemory.ToString, "Total Virtual Memory", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AltKeyDownBtn_Click() Handles AltKeyDownBtn.Click
        MessageBox.Show(My.Computer.Keyboard.AltKeyDown.ToString, "Alt Key Down", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CapsLockBtn_Click() Handles CapsLockBtn.Click
        MessageBox.Show(My.Computer.Keyboard.CapsLock.ToString, "Caps Lock", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CtrlKeyDownBtn_Click() Handles CtrlKeyDownBtn.Click
        MessageBox.Show(My.Computer.Keyboard.CtrlKeyDown.ToString, "Ctrl Key Down", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub NumLockBtn_Click() Handles NumLockBtn.Click
        MessageBox.Show(My.Computer.Keyboard.NumLock.ToString, "Num Lock", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ScrollLockBtn_Click() Handles ScrollLockBtn.Click
        MessageBox.Show(My.Computer.Keyboard.ScrollLock.ToString, "Scroll Lock", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShiftKeyDownBtn_Click() Handles ShiftKeyDownBtn.Click
        MessageBox.Show(My.Computer.Keyboard.ShiftKeyDown.ToString, "Shift Key Down", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonsSwappedBtn_Click() Handles ButtonsSwappedBtn.Click
        MessageBox.Show(My.Computer.Mouse.ButtonsSwapped.ToString, "Buttons Swapped", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WheelExistsBtn_Click() Handles WheelExistsBtn.Click
        MessageBox.Show(My.Computer.Mouse.WheelExists.ToString, "Wheel Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WheelScrollLinesBtn_Click() Handles WheelScrollLinesBtn.Click
        MessageBox.Show(My.Computer.Mouse.WheelScrollLines.ToString, "Wheel Scroll Lines", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub IsAvailableBtn_Click() Handles IsAvailableBtn.Click
        MessageBox.Show(My.Computer.Network.IsAvailable.ToString, "Is Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BitsPerPixelBtn_Click() Handles BitsPerPixelBtn.Click
        MessageBox.Show(My.Computer.Screen.BitsPerPixel.ToString, "Bits Per Pixel", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BoundsBtn_Click() Handles BoundsBtn.Click
        MessageBox.Show(My.Computer.Screen.Bounds.ToString, "Bounds", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DeviceNameBtn_Click() Handles DeviceNameBtn.Click
        MessageBox.Show(My.Computer.Screen.DeviceName, "Device Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PrimaryBtn_Click() Handles PrimaryBtn.Click
        MessageBox.Show(My.Computer.Screen.Primary.ToString, "Primary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WorkingAreaBtn_Click() Handles WorkingAreaBtn.Click
        MessageBox.Show(My.Computer.Screen.WorkingArea.ToString, "Working Area", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CountBtn_Click() Handles CountBtn.Click
        MessageBox.Show(My.Computer.Ports.SerialPortNames.Count.ToString, "Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
