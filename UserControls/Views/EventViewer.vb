Namespace UserControls.Views

    Public Class EventViewer

        Private ReadOnly _Logs As New List(Of String) From {"Application", "System"}
        Private ReadOnly _Machines As New List(Of String) From {"Bjorn25", "Nix25", "Server24"}
        Private ReadOnly _Password As New Security.SecureString()
        Private ReadOnly _StartTimer As New MethodInvoker(AddressOf StartTimer)
        Private ReadOnly _Timer As Timers.Timer = Nothing
        Private ReadOnly _WipeUsernames As New List(Of String) From {"poesServices", "Administrator"}
        Private ReadOnly _Username As String = String.Empty

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Try
                Dim Password = Settings.DesktopSetting("UserControls.Views.EventViewer", "Password")
                For Each c As Char In Password
                    _Password.AppendChar(c)
                Next
                _Password.MakeReadOnly()

                _Username = Settings.DesktopSetting("UserControls.Views.EventViewer", "Username")

                _Timer = New Timers.Timer(3 * 60 * 60 * 1000)
                AddHandler _Timer.Elapsed, AddressOf Timer_Elapsed
                _Timer.Start()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Public Sub StartTimer()
            _Timer.Stop()

            Enabled = False
            MainBackgroundWorker.RunWorkerAsync()

            _Timer.Start()
        End Sub

#Region " Events "

        Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
            MainListResults.ClearResults()
        End Sub

        Private Sub MainBackgroundWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles MainBackgroundWorker.DoWork
            Try
                MainListResults.AddMessage("Getting Event Logs...")

                Dim OneWeek = CLng(TimeSpan.FromDays(7).TotalMilliseconds)
                Dim Query = $"*[System[(Level=1 or Level=2) and TimeCreated[timediff(@SystemTime) <= {OneWeek}]]]"

                For Each MachineName In _Machines
                    Dim Builder As New Text.StringBuilder()
                    Builder.AppendLine($"   {MachineName}:")

                    Try
                        Dim Items As New List(Of Models.EventInformation)

                        Using Session As New Eventing.Reader.EventLogSession(MachineName, String.Empty, _Username, _Password, Eventing.Reader.SessionAuthentication.Default)
                            For Each LogName In _Logs
                                Builder.AppendLine($"      {LogName}:")

                                Dim EventQuery As New Eventing.Reader.EventLogQuery(LogName, Eventing.Reader.PathType.LogName, Query) With {
                                    .Session = Session
                                }

                                Using reader As New Eventing.Reader.EventLogReader(EventQuery)
                                    Dim Existing = reader.ReadEvent()
                                    While Existing IsNot Nothing
                                        Items.Add(New Models.EventInformation(Existing))

                                        Existing = reader.ReadEvent()
                                    End While
                                End Using
                            Next
                        End Using

                        For Each Current In Items.OrderByDescending(Function(o) o.EventDate).ThenBy(Function(o) o.EventSource)
                            Builder.AppendLine($"         {Current.EventDate.GetSQLString("ddd dd MMM HH:mm")} ({Current.EventLevel}) {Current.EventSource} - {Current.Description}".ReplaceLineEndings("_"))
                        Next
                    Catch exInner As Exception
                        Builder.AppendLine($"   ERROR: {exInner.Message}")
                    End Try

                    MainListResults.AddMessage(Builder.ToString())
                Next
            Catch ex As Exception
                ex.ToLog()
            Finally
                MainListResults.AddMessage("Complete.")
            End Try
        End Sub

        Private Sub MainBackgroundWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles MainBackgroundWorker.RunWorkerCompleted
            Enabled = True
        End Sub

        Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
            Enabled = False

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

        Private Sub Timer_Elapsed(sender As Object, e As Timers.ElapsedEventArgs)
            Invoke(_StartTimer)
        End Sub

        Private Sub WipeButton_Click(sender As Object, e As EventArgs) Handles WipeButton.Click
            Try
                MainListResults.AddMessage("Wiping Event Logs...")

                Dim OneWeek = CLng(TimeSpan.FromDays(7).TotalMilliseconds)
                Dim Query = $"*[System[(Level=1 or Level=2) and TimeCreated[timediff(@SystemTime) <= {OneWeek}]]]"

                For Each MachineName In _Machines
                    Dim Builder As New Text.StringBuilder()
                    Builder.AppendLine($"   {MachineName}:")

                    For Each Username In _WipeUsernames
                        Try
                            Using Session As New Eventing.Reader.EventLogSession(MachineName, String.Empty, Username, _Password, Eventing.Reader.SessionAuthentication.Default)
                                For Each LogName In _Logs
                                    Builder.AppendLine($"      Clearing {LogName}...")
                                    Session.ClearLog(LogName)
                                    Builder.AppendLine($"      Cleared.")
                                Next
                            End Using

                            Exit For
                        Catch exInner As Exception
                            Builder.AppendLine($"   ERROR: {exInner.Message}")
                        End Try
                    Next

                    MainListResults.AddMessage(Builder.ToString())
                Next
            Catch ex As Exception
                ex.ToLog()
            Finally
                MainListResults.AddMessage("Complete.")
            End Try
        End Sub

#End Region

    End Class

End Namespace