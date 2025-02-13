Namespace UserForms

    Public Class Main

        Private _ShouldExit As Boolean = False
        Private _VolumeControl As VolumeControl = Nothing

#Region " Form Events "

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Opacity = 0
        End Sub

        Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ShutDown()

            If Not _ShouldExit Then
                Hide()

                e.Cancel = True

                Return
            End If

            _VolumeControl.Close()

            PoesShared.Models.SingleInstanceApplication.Close()

            Dim ScreenName = Screen.FromControl(Me).DeviceName
            If ScreenName.Contains(Chr(0)) Then
                ScreenName = ScreenName.Substring(0, ScreenName.IndexOf(Chr(0)))
            End If

            Settings.LastScreenName = ScreenName
        End Sub

        Private Sub Me_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Try
                Text = $"{Settings.ProductName} v{Settings.ProductVersion}"

                Dim Solutions As New List(Of Models.SolutionInformation)

                For Each Current As String In IO.Directory.GetFiles("D:\Projects\", "*.sln", IO.SearchOption.AllDirectories)
                    Solutions.Add(New Models.SolutionInformation(Current))
                Next

                For Each GroupName In Solutions.Select(Function(o) o.Group).Distinct().OrderBy(Function(o) o)
                    If GroupName.IsNotSet() Then
                        Continue For
                    End If

                    Dim GroupItem As New ToolStripMenuItem() With {
                        .Name = $"Solutions_{GroupName}ToolStripMenuItem".Replace(" "c, String.Empty),
                        .Size = New Size(180, 22),
                        .Text = GroupName
                    }

                    For Each Current In Solutions.Where(Function(o) o.Group.IsEqualTo(GroupName)).OrderBy(Function(o) o.Name)
                        Dim SolutionItem As New ToolStripMenuItem() With {
                            .Name = $"Solutions_{GroupName}_{Current.Name}ToolStripMenuItem".Replace(" "c, String.Empty),
                            .Size = New Size(180, 22),
                            .Tag = Current,
                            .Text = Current.Name
                        }

                        AddHandler SolutionItem.Click, AddressOf SolutionItem_Click

                        GroupItem.DropDownItems.Add(SolutionItem)
                    Next

                    SolutionsToolStripMenuItem.DropDownItems.Add(GroupItem)
                Next

                _Tabs.Clear()
                _Tabs.AddRange(TypeHelper.GetInstances(Of PoesShared.Models.ITab))

                For Each Current In _Tabs.OrderBy(Function(o) o.OrderButton).ThenBy(Function(o) o.Text)
                    ControlsPanel.Controls.Add(Current.UserControl)
                    Current.UserControl.DockAndBringToFront()

                    ButtonsPanel.Controls.Add(Current.Button)
                    Current.Button.Dock = DockStyle.Top
                    Current.Button.BringToFront()

                    AddHandler Current.Button.Click, AddressOf Button_Click
                Next

                _VolumeControl = New VolumeControl()
                _VolumeControl.Show()
            Catch ex As Exception
                ex.ToLog()
            Finally
                Try
                    Enabled = True

                    StartUp()

                    SetTheme()

                    For Each Current In _Tabs.OrderBy(Function(o) o.OrderButton).ThenBy(Function(o) o.Text)
                        SetButtons(Current.Button)

                        Exit For
                    Next
                Catch ex As Exception
                    ex.ToLog()
                End Try
            End Try
        End Sub

#End Region

        Private Sub Button_Click(sender As Object, e As EventArgs)
            SetButtons(DirectCast(sender, Button))
        End Sub

        Private Sub SetButtons(currentButton As Button)
            Try
                Opacity = 0.75

                For Each Current In _Tabs
                    Current.IsSelected = False
                Next

                Dim Tab = _Tabs.Where(Function(o) o.Button.Name.IsEqualTo(currentButton.Name)).FirstOrDefault()

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

        Public Sub NewInstanceMessage(sender As Object, message As Object)
            Try
                If Not Visible Then
                    Show()
                End If

                TopMost = True
                BringToFront()
                TopMost = False
            Catch ex As Exception
                ex.ToLog(True)
            End Try
        End Sub

#Region " Shared "

        Private Shared ReadOnly _Tabs As New List(Of PoesShared.Models.ITab)

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

        Private Shared Sub LogError(errorInformation As PoesShared.Models.ErrorInformation, silent As Boolean)
            errorInformation.WriteToFile(Errors.Filename)

            If Not silent Then
                UserMessage.Show(True, errorInformation.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Public Shared Sub Main(args As String())
            Try
                If PoesShared.Models.SingleInstanceApplication.NotifyExistingInstance(String.Empty, WindowCaption) Then
                    Application.Exit()
                    Return
                End If
            Catch
            End Try

            Try
                AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
                AddHandler Application.ThreadException, AddressOf Application_ThreadException

                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Application.SetDefaultFont(New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point))
                Application.SetHighDpiMode(HighDpiMode.PerMonitorV2)
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

                Settings.FormIcon = My.Resources.App
                Settings.ProductName = "Tools"
                Settings.ProductVersion = My.Application.Info.Version.GetVersionString()

                Dim MainForm As New Main()

                Errors.Handlers.Clear()
                Errors.Handlers.Add(New AddErrorLogEventHandler(AddressOf LogError))

                DBCache.LoadCache(Settings.ProductName)
                UITheme.Load("Bjorn", MainForm)

                SevenZip.SevenZipBase.SetLibraryPath("D:\Projects\_Binaries\7za.dll")

                PoesShared.Models.SingleInstanceApplication.Initialize(WindowCaption, New PoesShared.Models.SingleInstanceApplication.NewInstanceMessageHandler(AddressOf MainForm.NewInstanceMessage))

                Application.Run(MainForm)
            Catch ex As Exception
                ex.ToLog()

                Application.Exit()
            End Try
        End Sub

#Region " NotifyIcon "

        Private Sub MainNotifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles MainNotifyIcon.MouseClick
            If e.Button = MouseButtons.Left Then
                BringToFront()
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