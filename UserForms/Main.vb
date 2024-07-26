Namespace UserForms

    Public Class Main

        Private _ShouldExit As Boolean = False
        Private _VolumeControl As VolumeControl = Nothing

#Region " Form Events "

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Try
                Aprotec.MainFormInstance = Me

                Enabled = False
                Opacity = 0
                SuspendLayout()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ShutDown("")

            If Not _ShouldExit Then
                Hide()

                e.Cancel = True

                Return
            End If

            _VolumeControl.Close()

            Aprotec.SingleInstanceApplication.Close()

            Dim ScreenName = Screen.FromControl(Me).DeviceName
            If ScreenName.Contains(Chr(0)) Then
                ScreenName = ScreenName.Substring(0, ScreenName.IndexOf(Chr(0)))
            End If
            Aprotec.LocalSettings.DefaultScreenName = ScreenName
            Aprotec.LocalSettings.SaveCache()
        End Sub

        Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.SystemDefault Or Net.SecurityProtocolType.Tls Or Net.SecurityProtocolType.Tls11 Or Net.SecurityProtocolType.Tls12

                _Tabs.Clear()
                _Tabs.AddRange(Aprotec.TypeHelper.GetInstances(Of Aprotec.UserControls.ITab))

                Dim IsFirst As Boolean = True
                Dim LastY As Integer = 1

                For Each Current As Aprotec.UserControls.ITab In _Tabs.OrderBy(Function(o) o.OrderButton).ThenBy(Function(o) o.Text)
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
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub Me_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Try
                Dim Solutions As New List(Of Models.SolutionInformation)

                For Each Current As String In IO.Directory.GetFiles("D:\Projects\", "*.sln", IO.SearchOption.AllDirectories)
                    Solutions.Add(New Models.SolutionInformation(Current))
                Next

                For Each GroupName As String In Solutions.Select(Function(o) o.Group).Distinct().OrderBy(Function(o) o)
                    If GroupName.IsNotSet() Then
                        Continue For
                    End If

                    Dim GroupItem As New ToolStripMenuItem() With {
                                .Name = "Solutions_{0}ToolStripMenuItem".FormatWith(GroupName).Replace(" ", ""),
                                .Size = New Size(180, 22),
                                .Text = GroupName
                            }

                    For Each Current As Models.SolutionInformation In Solutions.Where(Function(o) o.Group.IsEqualTo(GroupName)).OrderBy(Function(o) o.Name)
                        Dim SolutionItem As New ToolStripMenuItem() With {
                                        .Name = "Solutions_{0}_{1}ToolStripMenuItem".FormatWith(GroupName, Current.Name).Replace(" ", ""),
                                        .Size = New Size(180, 22),
                                        .Tag = Current,
                                        .Text = Current.Name
                                    }

                        AddHandler SolutionItem.Click, AddressOf SolutionItem_Click

                        GroupItem.DropDownItems.Add(SolutionItem)
                    Next

                    SolutionsToolStripMenuItem.DropDownItems.Add(GroupItem)
                Next

                _VolumeControl = New VolumeControl()
                _VolumeControl.Show()
            Catch ex As Exception
                ex.ToLog()
            Finally
                Try
                    If IsDisposed OrElse Disposing Then
                    Else
                        Enabled = True

                        ResumeLayout(False)

                        StartUp("")

                        SetTheme()

                        For Each Current As Aprotec.UserControls.ITab In _Tabs.OrderBy(Function(o) o.OrderButton).ThenBy(Function(o) o.Text)
                            SetButtons(Current.Button)

                            Exit For
                        Next
                    End If
                Catch ex As Exception
                    ex.ToLog()
                End Try
            End Try
        End Sub

#End Region

        Private Sub SetButtons(currentButton As Button)
            Try
                Opacity = 0.75

                For Each Current As Aprotec.UserControls.ITab In _Tabs
                    Current.IsSelected = False
                Next

                Dim Tab As Aprotec.UserControls.ITab = _Tabs.Where(Function(o) o.Button.Name.IsEqualTo(currentButton.Name)).FirstOrDefault()

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

        Private Shared ReadOnly _Tabs As New List(Of Aprotec.UserControls.ITab)

        Private Shared Sub Application_ThreadException(sender As Object, e As Threading.ThreadExceptionEventArgs)
            Try
                Dim MethodName As String = String.Empty

                Try
                    Dim Frame As New StackFrame(1, False)
                    MethodName = Frame.GetMethod().Name
                Catch
                End Try

                e.Exception.ToLog(True, $"Application_ThreadException - MethodName: {MethodName}")
            Catch
            End Try
        End Sub

        Private Shared Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
            Try
                Dim MethodName As String = String.Empty

                Try
                    Dim Frame As New StackFrame(1, False)
                    MethodName = Frame.GetMethod().Name
                Catch exInner As Exception
                End Try

                DirectCast(e.ExceptionObject, Exception).ToLog(True, $"CurrentDomain_UnhandledException - MethodName: {MethodName}, IsTerminating: {e.IsTerminating}")
            Catch
            End Try
        End Sub

        Private Shared Sub LogError(silent As Boolean, errorInformation As Aprotec.Models.Error)
            errorInformation.WriteToFile(Aprotec.Errors.Filename)

            If Not silent Then
                If Aprotec.MainFormInstance IsNot Nothing AndAlso Aprotec.MainFormInstance.IsHandleCreated Then
                    Try
                        Aprotec.MainFormInstance.Invoke(Sub()
                                                            Aprotec.UserMessage.Show(True, errorInformation.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                        End Sub)
                    Catch
                    End Try
                End If
            End If
        End Sub

        Private Shared Sub SIA_NewInstanceMessage(sender As Object, message As Object)
            BringForward()
        End Sub

        Public Shared Sub BringForward()
            Try
                If Aprotec.MainFormInstance Is Nothing Then
                    Return
                End If

                If Not Aprotec.MainFormInstance.Visible Then
                    Aprotec.MainFormInstance.Show()
                End If

                Aprotec.MainFormInstance.TopMost = True
                Aprotec.MainFormInstance.BringToFront()
                Aprotec.MainFormInstance.TopMost = False
            Catch ex As Exception
                ex.ToLog(True)
            End Try
        End Sub

        Public Shared Sub Main(args As String())
            Try
                If Aprotec.SingleInstanceApplication.NotifyExistingInstance(String.Empty, WindowCaption) Then
                    Application.Exit()
                    Return
                End If
            Catch ex As Exception
            End Try

            Try
                AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
                AddHandler Application.ThreadException, AddressOf Application_ThreadException

                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Application.SetDefaultFont(New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point))
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

                Aprotec.FormIcon = My.Resources.App
                Aprotec.Settings.DebugLogging = False
                Aprotec.Settings.DebugLoggingDatabase = False
                Aprotec.Settings.ProductName = "Tools"
                Aprotec.Settings.ProductVersion = My.Application.Info.Version.GetVersionString()

                Aprotec.Errors.Filename = "\\192.168.50.246\Projects\Errors.txt"
                Aprotec.LocalSettings.CacheLocation = $"\\192.168.50.246\Projects\{Aprotec.Settings.ProductName}_LocalSettings.JSON"
                Aprotec.Performance.Filename = String.Empty

                Aprotec.Errors.Handlers.Clear()
                Aprotec.Errors.Handlers.Add(New Aprotec.AddErrorLogEventHandler(AddressOf LogError))

                Aprotec.Performance.Handlers.Clear()

                Aprotec.LocalSettings.LoadCache()

                Aprotec.SingleInstanceApplication.Initialize(WindowCaption, New Aprotec.SingleInstanceApplication.NewInstanceMessageHandler(AddressOf SIA_NewInstanceMessage))
                SevenZip.SevenZipBase.SetLibraryPath("D:\Projects\_Binaries\7za.dll")

                Application.Run(New Main())
            Catch ex As Exception
                ex.ToLog()

                Application.Exit()
            End Try
        End Sub

        Public Shared Sub UpdateTheme()
            Try
                If Aprotec.MainFormInstance Is Nothing Then
                    Return
                End If

                Aprotec.MainFormInstance.SetTheme()

                Dim Tab As Aprotec.UserControls.ITab = _Tabs.Where(Function(o) o.IsSelected).FirstOrDefault()
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

        Private Sub SolutionItem_Click(sender As Object, e As EventArgs)
            Try
                Dim SolutionItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
                Dim SolutionInformation As Models.SolutionInformation = DirectCast(SolutionItem.Tag, Models.SolutionInformation)

                Dim Process As New Process()

                Process.StartInfo.Arguments = SolutionInformation.Filename
                Process.StartInfo.FileName = "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe"
                Process.StartInfo.UseShellExecute = True

                If SolutionInformation.RequiresAdmin Then
                    Process.StartInfo.Verb = "RunAs"
                End If

                Process.Start()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#End Region

#End Region

    End Class

End Namespace