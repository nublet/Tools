Namespace UserForms

    Public Class VolumeControl

        Private Shared ReadOnly _SelectedBackColor = Color.FromArgb(24, 28, 63)
        Private Shared ReadOnly _SelectedForeColor = Color.WhiteSmoke

        Private Shared ReadOnly _NormalBackColor = Color.FromArgb(128, 255, 128)
        Private Shared ReadOnly _NormalForeColor = Color.Black

        Private _HasClosed As Boolean = False

        Private ReadOnly _Device As CoreAudio.MMDevice = Nothing
        Private ReadOnly _UpdateVolumeControls As New MethodInvoker(AddressOf UpdateVolumeControls)

#Region " Form Events "

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Try
                Enabled = False
                SuspendLayout()

                TopMost = True

                Dim WindowLong = NativeRoutines.PInvoke.GetWindowLong(Handle, -20)
                WindowLong = WindowLong Or NativeRoutines.WS_EX_LAYERED Or NativeRoutines.WS_EX_TRANSPARENT

                Dim ExitCode = NativeRoutines.PInvoke.SetWindowLong(Handle, -20, WindowLong)
                NativeRoutines.PInvoke.SetLayeredWindowAttributes(Handle, Color.White.ToArgb(), 128, NativeRoutines.LWA_COLORKEY Or NativeRoutines.LWA_ALPHA)

                Dim DeviceEnumerator = New CoreAudio.MMDeviceEnumerator(Guid.NewGuid())
                _Device = DeviceEnumerator.GetDefaultAudioEndpoint(CoreAudio.DataFlow.Render, CoreAudio.Role.Multimedia)

                AddHandler _Device.AudioEndpointVolume.OnVolumeNotification, AddressOf Device_VolumeNotification
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            If _HasClosed Then
                Return
            End If

            _HasClosed = True

            RemoveHandler _Device.AudioEndpointVolume.OnVolumeNotification, AddressOf Device_VolumeNotification

            RemoveHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf SystemEvents_SessionEnding

            _Device.Dispose()

            ShutDown("")
        End Sub

        Private Sub Me_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Try
                AddHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf SystemEvents_SessionEnding

                Enabled = True
                ResumeLayout(False)

                StartUp("")

                UpdateVolumeControls()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#End Region

        Private Sub UpdateVolumeControls()
            Try
                Dim Volume = CInt(_Device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)

                CurrentVolumeLabel.Text = $"{Volume}%"

                Set10Button.BackColor = _NormalBackColor
                Set10Button.ForeColor = _NormalForeColor
                Set20Button.BackColor = _NormalBackColor
                Set20Button.ForeColor = _NormalForeColor
                Set30Button.BackColor = _NormalBackColor
                Set30Button.ForeColor = _NormalForeColor
                Set40Button.BackColor = _NormalBackColor
                Set40Button.ForeColor = _NormalForeColor
                SetMuteButton.BackColor = _NormalBackColor
                SetMuteButton.ForeColor = _NormalForeColor

                If _Device.AudioEndpointVolume.Mute Then
                    SetMuteButton.BackColor = _SelectedBackColor
                    SetMuteButton.ForeColor = _SelectedForeColor
                ElseIf Volume = 10 Then
                    Set10Button.BackColor = _SelectedBackColor
                    Set10Button.ForeColor = _SelectedForeColor
                ElseIf Volume = 20 Then
                    Set20Button.BackColor = _SelectedBackColor
                    Set20Button.ForeColor = _SelectedForeColor
                ElseIf Volume = 30 Then
                    Set30Button.BackColor = _SelectedBackColor
                    Set30Button.ForeColor = _SelectedForeColor
                ElseIf Volume = 40 Then
                    Set40Button.BackColor = _SelectedBackColor
                    Set40Button.ForeColor = _SelectedForeColor
                End If
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#Region " Control Events "

        Private Sub Device_VolumeNotification(data As CoreAudio.AudioVolumeNotificationData)
            Invoke(_UpdateVolumeControls)
        End Sub

        Private Sub Me_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, CurrentVolumeLabel.MouseDown
            NativeRoutines.PInvoke.ReleaseCapture()
            NativeRoutines.PInvoke.SendMessage(Handle, NativeRoutines.WM_SYSCOMMAND, &HF012, IntPtr.Zero)
        End Sub

        Private Sub Set10Button_Click(sender As Object, e As EventArgs) Handles Set10Button.Click
            Try
                _Device.AudioEndpointVolume.Mute = False
                _Device.AudioEndpointVolume.MasterVolumeLevelScalar = (10 / 100.0F)
            Catch ex As Exception
            End Try

            UpdateVolumeControls()
        End Sub

        Private Sub Set20Button_Click(sender As Object, e As EventArgs) Handles Set20Button.Click
            Try
                _Device.AudioEndpointVolume.Mute = False
                _Device.AudioEndpointVolume.MasterVolumeLevelScalar = (20 / 100.0F)
            Catch ex As Exception
            End Try

            UpdateVolumeControls()
        End Sub

        Private Sub Set30Button_Click(sender As Object, e As EventArgs) Handles Set30Button.Click
            Try
                _Device.AudioEndpointVolume.Mute = False
                _Device.AudioEndpointVolume.MasterVolumeLevelScalar = (30 / 100.0F)
            Catch ex As Exception
            End Try

            UpdateVolumeControls()
        End Sub

        Private Sub Set40Button_Click(sender As Object, e As EventArgs) Handles Set40Button.Click
            Try
                _Device.AudioEndpointVolume.Mute = False
                _Device.AudioEndpointVolume.MasterVolumeLevelScalar = (40 / 100.0F)
            Catch ex As Exception
            End Try

            UpdateVolumeControls()
        End Sub

        Private Sub SetMuteButton_Click(sender As Object, e As EventArgs) Handles SetMuteButton.Click
            Try
                _Device.AudioEndpointVolume.MasterVolumeLevelScalar = (0 / 100.0F)
                _Device.AudioEndpointVolume.Mute = True
            Catch ex As Exception
            End Try

            UpdateVolumeControls()
        End Sub

        Private Sub SystemEvents_SessionEnding(sender As Object, e As Microsoft.Win32.SessionEndingEventArgs)
            Close()
        End Sub

#End Region

    End Class

End Namespace