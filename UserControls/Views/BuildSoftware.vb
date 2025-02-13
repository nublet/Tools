Namespace UserControls.Views

    Public Class BuildSoftware

        Private Const _DotNetLocation = "C:\Program Files\dotnet\dotnet.exe"
        Private Const _MSBuildLocation = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\MSBuild.exe"

        Private _Version As String

        Private ReadOnly _Solutions As New List(Of Models.BuildInformation)

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Private Function UpdateProjectVersions(ByRef information As Models.BuildInformation) As Boolean
            Try
                MainListResults.AddMessage($"   Updating {information.SolutionFilename}...")

                Dim Directory = IO.Path.GetDirectoryName(information.SolutionFilename)

                For Each Current In IO.Directory.GetFiles(Directory, "*.csproj", IO.SearchOption.AllDirectories)
                    Dim Content = IO.File.ReadAllText(Current)

                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<AssemblyVersion>\d+\.\d+\.\d+\.\d+</AssemblyVersion>", $"<AssemblyVersion>{_Version}</AssemblyVersion>")
                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<FileVersion>\d+\.\d+\.\d+\.\d+</FileVersion>", $"<FileVersion>{_Version}</FileVersion>")
                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<ProductVersion>\d+\.\d+\.\d+\.\d+</ProductVersion>", $"<ProductVersion>{_Version}</ProductVersion>")
                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<Version>\d+\.\d+\.\d+\.\d+</Version>", $"<Version>{_Version}</Version>")

                    IO.File.WriteAllText(Current, Content)
                Next

                For Each Current In IO.Directory.GetFiles(Directory, "*.vbproj", IO.SearchOption.AllDirectories)
                    Dim Content = IO.File.ReadAllText(Current)

                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<AssemblyVersion>\d+\.\d+\.\d+\.\d+</AssemblyVersion>", $"<AssemblyVersion>{_Version}</AssemblyVersion>")
                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<FileVersion>\d+\.\d+\.\d+\.\d+</FileVersion>", $"<FileVersion>{_Version}</FileVersion>")
                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<ProductVersion>\d+\.\d+\.\d+\.\d+</ProductVersion>", $"<ProductVersion>{_Version}</ProductVersion>")
                    Content = System.Text.RegularExpressions.Regex.Replace(Content, "<Version>\d+\.\d+\.\d+\.\d+</Version>", $"<Version>{_Version}</Version>")

                    IO.File.WriteAllText(Current, Content)
                Next

                Return True
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage($"   ERROR: {ex.Message}")
            Finally
                MainListResults.AddMessage("   Complete.")
            End Try

            Return False
        End Function

        Private Function BuildSolution(target As String, ByRef information As Models.BuildInformation) As Boolean
            Try
                MainListResults.AddMessage($"   {target}ing {information.SolutionFilename}...")

                Dim StartInfo As New ProcessStartInfo(_MSBuildLocation) With {
                    .CreateNoWindow = True,
                    .RedirectStandardError = True,
                    .RedirectStandardOutput = True,
                    .UseShellExecute = False
                }

                If target.StartsWith("WebPublish") Then
                    StartInfo.Arguments = $"""{information.SolutionFilename}"" /t:{target} /p:Platform=""x64"" /p:Configuration=Release;Platform=""Any CPU"""
                Else
                    Dim OutputFolder = information.OutputFilename.Substring(0, information.OutputFilename.LastIndexOf("\"c))
                    StartInfo.Arguments = $"""{information.SolutionFilename}"" /t:{target} /p:Platform=""x64"" /p:Configuration=Release;Platform=""Any CPU"" /p:OutputPath=""{OutputFolder}"""
                End If

                Dim NewProcess As New Process With {
                    .StartInfo = StartInfo
                }

                AddHandler NewProcess.ErrorDataReceived, AddressOf Process_ErrorDataReceived
                AddHandler NewProcess.OutputDataReceived, AddressOf Process_OutputDataReceived

                NewProcess.Start()
                NewProcess.BeginErrorReadLine()
                NewProcess.BeginOutputReadLine()
                NewProcess.WaitForExit()

                Select Case NewProcess.ExitCode
                    Case 0
                        Return True
                    Case Else
                        MainListResults.AddMessage($"   ExitCode: {NewProcess.ExitCode}")
                End Select
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage($"   ERROR: {ex.Message}")
            Finally
                MainListResults.AddMessage("   Complete.")
            End Try

            Return False
        End Function

        Private Function BuildSolutionCore(target As String, ByRef information As Models.BuildInformation) As Boolean
            Try
                MainListResults.AddMessage($"   {target}ing {information.SolutionFilename}...")

                Dim OutputFolder = information.OutputFilename.Substring(0, information.OutputFilename.LastIndexOf("\"c))

                Dim StartInfo As New ProcessStartInfo(_DotNetLocation) With {
                    .Arguments = $"dotnet {target} ""{information.SolutionFilename}"" --configuration Release --runtime win-x64",
                    .CreateNoWindow = True,
                    .RedirectStandardError = True,
                    .RedirectStandardOutput = True,
                    .UseShellExecute = False
                }

                Dim NewProcess As New Process With {
                    .StartInfo = StartInfo
                }

                AddHandler NewProcess.ErrorDataReceived, AddressOf Process_ErrorDataReceived
                AddHandler NewProcess.OutputDataReceived, AddressOf Process_OutputDataReceived

                NewProcess.Start()
                NewProcess.BeginErrorReadLine()
                NewProcess.BeginOutputReadLine()
                NewProcess.WaitForExit()

                Select Case NewProcess.ExitCode
                    Case 0
                        Return True
                    Case Else
                        MainListResults.AddMessage($"   ExitCode: {NewProcess.ExitCode}")
                End Select
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage($"   ERROR: {ex.Message}")
            Finally
                MainListResults.AddMessage("   Complete.")
            End Try

            Return False
        End Function

        Private Sub Process_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs)
            If e.Data.IsSet() Then
                MainListResults.AddMessage($"      {e.Data}")
            Else
                MainListResults.AddMessage("      ")
            End If
        End Sub

        Private Sub Process_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
            MainListResults.AddMessage($"      {e.Data}")
        End Sub

        Public Sub StartTimer()
            SoftwareVersionTextBox.Text = Settings.DesktopSetting("UserControls.Views.BuildSoftware", "SoftwareVersion")
        End Sub

#Region " Events "

        Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
            MainListResults.ClearResults()
        End Sub

        Private Sub MainBackgroundWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles MainBackgroundWorker.DoWork
            Try
                MainListResults.AddMessage("Starting...")
                MainListResults.AddMessage($"   {_DotNetLocation}")
                MainListResults.AddMessage($"   {_MSBuildLocation}")

                Dim Count As Integer = 1

                For Each Current In _Solutions
                    Invoke(Sub()
                               StatusLabel.Text = $"{Count}/{_Solutions.Count} - {Current.SolutionFilename}"
                           End Sub)

                    If Not UpdateProjectVersions(Current) Then
                        Return
                    End If

                    If Current.UseDotNet Then
                        If Not BuildSolutionCore("clean", Current) Then
                            Return
                        End If

                        'If Not BuildSolutionCore("restore", Current) Then
                        '    Return
                        'End If

                        If Not BuildSolutionCore("build", Current) Then
                            Return
                        End If
                    Else
                        If Not BuildSolution("Clean", Current) Then
                            Return
                        End If

                        'If Not BuildSolution("Restore", Current) Then
                        '    Return
                        'End If

                        If Not BuildSolution("Build", Current) Then
                            Return
                        End If
                    End If

                    If Not Current.OutputFilename.FileExists() Then
                        MainListResults.AddMessage("   ERROR: Output File NOT FOUND.")
                        Return
                    End If

                    Count += 1
                Next
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage($"   ERROR: {ex.Message}")
            Finally
                Invoke(Sub()
                           StatusLabel.Text = String.Empty
                       End Sub)

                MainListResults.AddMessage("Complete.")
            End Try
        End Sub

        Private Sub MainBackgroundWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles MainBackgroundWorker.RunWorkerCompleted
            Enabled = True
        End Sub

        Private Sub ProcessButton_Click(sender As Object, e As EventArgs) Handles ProcessButton.Click
            Enabled = False

            _Version = SoftwareVersionTextBox.Text
            Settings.DesktopSetting("UserControls.Views.BuildSoftware", "SoftwareVersion") = SoftwareVersionTextBox.Text

            _Solutions.Clear()
            _Solutions.Add(New Models.BuildInformation("D:\Projects\GitHub\PoesShared\PoesShared.DAL\bin\Release\net9.0-windows\PoesShared.DAL.dll", False, "D:\Projects\GitHub\PoesShared\PoesShared.DAL\PoesShared.DAL.vbproj", False))
            _Solutions.Add(New Models.BuildInformation("D:\Projects\GitHub\PoesShared\PoesShared.Forms\bin\Release\net9.0-windows\PoesShared.Forms.dll", False, "D:\Projects\GitHub\PoesShared\PoesShared.Forms\PoesShared.Forms.vbproj", False))
            _Solutions.Add(New Models.BuildInformation("D:\Projects\GitHub\PoesShared\PoesShared.Razor\bin\Release\net9.0-windows\PoesShared.Razor.dll", False, "D:\Projects\GitHub\PoesShared\PoesShared.Razor\PoesShared.Razor.vbproj", False))

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

#End Region

    End Class

End Namespace