Namespace Tools.UserForms

    Public Class Main

        Private _ShouldExit As Boolean = False

#Region " Form Events "

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Try
                _Instance = Me

                Enabled = False
                Opacity = 0.75
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Using CommonRoutines.Performance.StartCounter("Tools.UserForms.Main", "Me_FormClosing")
                ShutDown("")

                If Not _ShouldExit Then
                    Hide()

                    e.Cancel = True

                    Return
                End If
                CommonRoutines.SingleInstanceApplication.Close()

                CommonRoutines.CloseAndSave(Me)
            End Using
        End Sub

        Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
            Using CommonRoutines.Performance.StartCounter("Utilities.Forms.Main", "Me_Load")
                Try
                    Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Ssl3 Or Net.SecurityProtocolType.SystemDefault Or Net.SecurityProtocolType.Tls Or Net.SecurityProtocolType.Tls11 Or Net.SecurityProtocolType.Tls12

                    Initialise()

                    Using CommonRoutines.Performance.StartCounter("Utilities.Forms.Main", "Me_Load", "Create Tabs")
                        _Tabs.Clear()
                        _Tabs.AddRange(CommonRoutines.Reflection.GetInstances(Of UserControls.Tabs.ITab))
                    End Using

                    Using CommonRoutines.Performance.StartCounter("Utilities.Forms.Main", "Me_Load", "Populate Tabs")
                        Dim IsFirst As Boolean = True
                        Dim LastY As Integer = 1

                        For Each Current As UserControls.Tabs.ITab In _Tabs.OrderBy(Function(o) o.OrderButton).ThenBy(Function(o) o.Text)
                            ControlsPanel.Controls.Add(Current.UserControl)

                            ButtonsPanel.Controls.Add(Current.Button)

                            If IsFirst Then
                                Current.Button.Location = New Point(1, 1)

                                IsFirst = False
                            Else
                                Current.Button.Location = New Point(1, LastY + Current.Button.Height - 1)

                                Do While Current.Button.Location.X.IsNotEqualTo(1)
                                    Current.Button.Location = New Point(1, LastY + Current.Button.Height - 1)
                                Loop

                                LastY = Current.Button.Location.Y
                            End If

                            AddHandler Current.Button.Click, AddressOf Button_Click
                        Next
                    End Using
                Catch ex As Exception
                    ex.ToLog()
                End Try
            End Using
        End Sub

        Private Sub Me_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Using CommonRoutines.Performance.StartCounter("Utilities.Forms.Main", "Me_Shown")
                StartUp("")

                SetTheme()

                For Each Current As UserControls.Tabs.ITab In _Tabs.OrderBy(Function(o) o.OrderButton).ThenBy(Function(o) o.Text)
                    SetButtons(Current.Button)

                    Exit For
                Next

                Opacity = 1
                Enabled = True
            End Using
        End Sub

#End Region

        Private Sub SetButtons(currentButton As Button)
            Try
                Opacity = 0.75

                For Each Current As UserControls.Tabs.ITab In _Tabs
                    Current.IsSelected = False
                Next

                Dim Tab As UserControls.Tabs.ITab = _Tabs.Where(Function(o) o.Button.Name.IsEqualTo(currentButton.Name)).FirstOrDefault()

                If Tab Is Nothing Then
                    Return
                End If

                Tab.IsSelected = True

                Tab.LoadArea()
            Catch ex As Exception
                ex.ToLog()
            Finally
                Opacity = 1

                Refresh()
            End Try
        End Sub

        Private Sub Button_Click(sender As Object, e As EventArgs)
            SetButtons(DirectCast(sender, Button))
        End Sub

#Region " Shared "

        Private Shared ReadOnly _Tabs As New List(Of UserControls.Tabs.ITab)

        Private Shared _Instance As Main = Nothing

        Public Shared Sub BringForward()
            Try
                If _Instance Is Nothing Then
                    Return
                End If

                If Not _Instance.Visible Then
                    _Instance.Show()
                End If

                _Instance.TopMost = True
                _Instance.BringToFront()
                _Instance.TopMost = False
            Catch ex As Exception
                ex.ToLog(True)
            End Try
        End Sub

        Public Shared Sub UpdateTheme()
            Try
                If _Instance Is Nothing Then
                    Return
                End If

                _Instance.SetTheme()

                Dim Tab As UserControls.Tabs.ITab = _Tabs.Where(Function(o) o.IsSelected).FirstOrDefault()
                If Tab Is Nothing Then
                    Return
                End If

                Tab.IsSelected = False
                Tab.IsSelected = True
            Catch ex As Exception
                ex.ToLog(True)
            End Try
        End Sub

#Region " NotifyIcon "

        Private Sub MainNotifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles MainNotifyIcon.MouseClick
            If e.Button = MouseButtons.Left Then
                BringForward()
            End If
        End Sub

#End Region

#Region " ToolStripMenu "

        Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
            _ShouldExit = True
            Close()
        End Sub

#Region " Keys "

        Private Const _Key As String = "HKEY_LOCAL_MACHINE\Software\Aprotec"
        Private Const _KeyAPRENPASSWD As String = "APRENPASSWD"
        Private Const _KeyAPRENUSER As String = "APRENUSER"
        Private Const _KeyEN20SERVER As String = "EN20SERVER"
        Private Const _KeyEnginePort As String = "EnginePort"
        Private Const _KeyEngineServer As String = "EngineServer"
        Private Const _KeySQLPASSWORD As String = "SQLPASSWORD"
        Private Const _KeySQLUSERNAME As String = "SQLUSERNAME"

        Private Sub Keys_DevelopmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Keys_DevelopmentToolStripMenuItem.Click
            Try
                CommonRoutines.Registry.Set(_Key, _KeyAPRENPASSWD, "Aprotec")
                CommonRoutines.Registry.Set(_Key, _KeyAPRENUSER, "bjorn.falt")
                CommonRoutines.Registry.Set(_Key, _KeyEN20SERVER, "192.168.9.43\SQLDEV")
                CommonRoutines.Registry.Set(_Key, _KeyEnginePort, "45002")
                CommonRoutines.Registry.Set(_Key, _KeyEngineServer, "192.168.9.43")
                CommonRoutines.Registry.Set(_Key, _KeySQLPASSWORD, "KIx1hQmVANjH9MP7XICebA==")
                CommonRoutines.Registry.Set(_Key, _KeySQLUSERNAME, "VUtntl2IGR9PPUSkl3YZFg==")
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub Keys_ProductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Keys_ProductionToolStripMenuItem.Click
            Try
                CommonRoutines.Registry.Set(_Key, _KeyAPRENPASSWD, "nZHUxkGC4br6CKLv")
                CommonRoutines.Registry.Set(_Key, _KeyAPRENUSER, "Bjorn")
                CommonRoutines.Registry.Set(_Key, _KeyEN20SERVER, "192.168.10.205\DMSSALES")
                CommonRoutines.Registry.Set(_Key, _KeyEnginePort, "45001")
                CommonRoutines.Registry.Set(_Key, _KeyEngineServer, "192.168.10.205")
                CommonRoutines.Registry.Set(_Key, _KeySQLPASSWORD, "bJoDrxTHxl2fBamOr6AStQ==")
                CommonRoutines.Registry.Set(_Key, _KeySQLUSERNAME, "pid+8QT77QRTzN1qUh5iLA==")
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub Keys_Test2012ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Keys_Test2012ToolStripMenuItem.Click
            Try
                CommonRoutines.Registry.Set(_Key, _KeyAPRENPASSWD, "")
                CommonRoutines.Registry.Set(_Key, _KeyAPRENUSER, "")
                CommonRoutines.Registry.Set(_Key, _KeyEN20SERVER, "192.168.10.147\SQLEXPRESS")
                CommonRoutines.Registry.Set(_Key, _KeyEnginePort, "45001")
                CommonRoutines.Registry.Set(_Key, _KeyEngineServer, "192.168.10.147")
                CommonRoutines.Registry.Set(_Key, _KeySQLPASSWORD, "")
                CommonRoutines.Registry.Set(_Key, _KeySQLUSERNAME, "")
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub Keys_Test2016ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Keys_Test2016ToolStripMenuItem.Click
            Try
                CommonRoutines.Registry.Set(_Key, _KeyAPRENPASSWD, "aprotec")
                CommonRoutines.Registry.Set(_Key, _KeyAPRENUSER, "Bjorn")
                CommonRoutines.Registry.Set(_Key, _KeyEN20SERVER, "192.168.10.148\SQLEXPRESS")
                CommonRoutines.Registry.Set(_Key, _KeyEnginePort, "45001")
                CommonRoutines.Registry.Set(_Key, _KeyEngineServer, "192.168.10.148")
                CommonRoutines.Registry.Set(_Key, _KeySQLPASSWORD, "")
                CommonRoutines.Registry.Set(_Key, _KeySQLUSERNAME, "")
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#End Region

#End Region

#End Region

    End Class

End Namespace