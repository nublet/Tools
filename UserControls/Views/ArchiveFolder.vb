Namespace Tools.UserControls.Views

    Public Class ArchiveFolder

        Private Const ONE_KB As Double = 1024
        Private Const ONE_MB As Double = ONE_KB * 1024
        Private Const ONE_GB As Double = ONE_MB * 1024
        Private Const ONE_TB As Double = ONE_GB * 1024
        Private Const ONE_PB As Double = ONE_TB * 1024
        Private Const ONE_EB As Double = ONE_PB * 1024
        Private Const ONE_ZB As Double = ONE_EB * 1024
        Private Const ONE_YB As Double = ONE_ZB * 1024

        Private _ArchiveName As String = ""
        Private _FolderName As String = ""

        Private ReadOnly _Timer As Timers.Timer = Nothing

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _Timer = New Timers.Timer(1 * 60 * 60 * 1000)
            AddHandler _Timer.Elapsed, AddressOf Timer_Elapsed
            _Timer.Start()

            SevenZip.SevenZipBase.SetLibraryPath("D:\Projects\_Binaries\7za.dll")
        End Sub

        Private Function GetNumberToThreeSig(value As Double) As String
            Try
                If value >= 100 Then
                    Return Format$(CInt(value))
                ElseIf value >= 10 Then
                    Return Format$(value, "0.0")
                Else
                    Return Format$(value, "0.00")
                End If
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return ""
        End Function

        Private Function GetFileLength(fileName As String) As String
            Try
                Dim FileSize As Double = New IO.FileInfo(fileName).Length

                If FileSize <= 999 Then
                    Return Format$(FileSize, "0") & " bytes"
                ElseIf FileSize <= ONE_KB * 999 Then
                    Return GetNumberToThreeSig(FileSize / ONE_KB) & " " & "KB"
                ElseIf FileSize <= ONE_MB * 999 Then
                    Return GetNumberToThreeSig(FileSize / ONE_MB) & " " & "MB"
                ElseIf FileSize <= ONE_GB * 999 Then
                    Return GetNumberToThreeSig(FileSize / ONE_GB) & " " & "GB"
                ElseIf FileSize <= ONE_TB * 999 Then
                    Return GetNumberToThreeSig(FileSize / ONE_TB) & " " & "TB"
                ElseIf FileSize <= ONE_PB * 999 Then
                    Return GetNumberToThreeSig(FileSize / ONE_PB) & " " & "PB"
                ElseIf FileSize <= ONE_EB * 999 Then
                    Return GetNumberToThreeSig(FileSize / ONE_EB) & " " & "EB"
                ElseIf FileSize <= ONE_ZB * 999 Then
                    Return GetNumberToThreeSig(FileSize / ONE_ZB) & " " & "ZB"
                Else
                    Return GetNumberToThreeSig(FileSize / ONE_YB) & " " & "YB"
                End If
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return ""
        End Function

        Public Sub StartTimer()
            _ArchiveName = CommonRoutines.Settings.Get(Of String)("ArchiveFolder.ArchiveName")
            _FolderName = CommonRoutines.Settings.Get(Of String)("ArchiveFolder.FolderName")

            ArchiveNameTextBox.Text = _ArchiveName
            FolderNameTextBox.Text = _FolderName
        End Sub

#Region " Events "

        Private Sub ArchiveNameButton_Click(sender As Object, e As EventArgs) Handles ArchiveNameButton.Click
            ArchiveNameTextBox.SaveFile("", "Archive Name")
        End Sub

        Private Sub BackupAddonsButtonButton_Click(sender As Object, e As EventArgs) Handles BackupAddonsButton.Click
            Enabled = False

            _ArchiveName = "Z:\BackUps\WoW\AddOns_{0}.7z".FormatWith(CommonRoutines.GetCurrentDate().GetSQLString("yyyy_MM_dd_HH_mm"))
            _FolderName = "D:\Games\Activision\World of Warcraft\_retail_\Interface\AddOns"

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

        Private Sub BackupWTFButton_Click(sender As Object, e As EventArgs) Handles BackupWTFButton.Click
            Enabled = False

            _ArchiveName = "Z:\BackUps\WoW\POESBOI_{0}.7z".FormatWith(CommonRoutines.GetCurrentDate().GetSQLString("yyyy_MM_dd_HH_mm"))
            _FolderName = "D:\Games\Activision\World of Warcraft\_retail_\WTF\Account\POESBOI"

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

        Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
            MainListResults.ClearResults()
        End Sub

        Private Sub FolderNameButton_Click(sender As Object, e As EventArgs) Handles FolderNameButton.Click
            FolderNameTextBox.BrowseForFolder("Folder Name")
        End Sub

        Private Sub MainBackgroundWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles MainBackgroundWorker.DoWork
            Try
                MainListResults.AddMessage("Starting...")
                MainListResults.AddMessage("   Archive: {0}".FormatWith(_ArchiveName))
                MainListResults.AddMessage("   Folder: {0}".FormatWith(_FolderName))

                If _ArchiveName.IsNotSet() Then
                    MainListResults.AddMessage("   ERROR: Invalid Archive Name")

                    Return
                End If

                If _ArchiveName.FileExists() Then
                    IO.File.Delete(_ArchiveName)

                    MainListResults.AddMessage("   Existing Archive DELETED")
                End If

                If _FolderName.IsNotSet() Then
                    MainListResults.AddMessage("   ERROR: Invalid Folder Name")

                    Return
                End If

                If Not IO.Directory.Exists(_FolderName) Then
                    MainListResults.AddMessage("   ERROR: Folder not found, or access denied")

                    Return
                End If

                'IO.Compression.ZipFile.CreateFromDirectory(_FolderName, _ArchiveName, IO.Compression.CompressionLevel.Optimal, True)

                Dim SZC As New SevenZip.SevenZipCompressor()
                SZC.ArchiveFormat = SevenZip.OutArchiveFormat.SevenZip
                SZC.CompressionLevel = SevenZip.CompressionLevel.Ultra
                SZC.CompressionMethod = SevenZip.CompressionMethod.Lzma2
                SZC.CompressionMode = SevenZip.CompressionMode.Create
                SZC.CompressDirectory(_FolderName, _ArchiveName, "", "*", True)
                MainListResults.AddMessage("   File Size: {0}".FormatWith(GetFileLength(_ArchiveName)))
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage("   ERROR: {0}".FormatWith(ex.Message))
            Finally
                MainListResults.AddMessage("Complete.")
            End Try
        End Sub

        Private Sub MainBackgroundWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles MainBackgroundWorker.RunWorkerCompleted
            Enabled = True
        End Sub

        Private Sub Me_Changed(sender As Object, e As EventArgs) Handles FolderNameTextBox.TextChanged, ArchiveNameTextBox.TxtChanged
            If ArchiveNameTextBox.Text.IsSet() Then
                If FolderNameTextBox.Text.IsSet() AndAlso IO.Directory.Exists(FolderNameTextBox.Text) Then
                    ProcessButton.Enabled = True
                Else
                    ProcessButton.Enabled = False
                End If
            Else
                ProcessButton.Enabled = False
            End If
        End Sub

        Private Sub ProcessButton_Click(sender As Object, e As EventArgs) Handles ProcessButton.Click
            Enabled = False

            _ArchiveName = ArchiveNameTextBox.Text
            _FolderName = FolderNameTextBox.Text

            CommonRoutines.Settings.Set("ArchiveFolder.ArchiveName", _ArchiveName)
            CommonRoutines.Settings.Set("ArchiveFolder.FolderName", _FolderName)

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

        Private Sub Timer_Elapsed(sender As Object, e As Timers.ElapsedEventArgs)
            _Timer.Stop()

            MainListResults.AddMessage("Checking Daily WTF Backup...")

            _ArchiveName = "Z:\BackUps\WoW\POESBOI_{0}.7z".FormatWith(CommonRoutines.GetCurrentDate().GetSQLString("yyyy_MM_dd"))
            _FolderName = "D:\Games\Activision\World of Warcraft\_retail_\WTF\Account\POESBOI"

            If Not _ArchiveName.FileExists() Then
                MainBackgroundWorker.RunWorkerAsync()
            End If

            _Timer.Start()
        End Sub

#End Region

    End Class

End Namespace