Namespace UserControls.Views

    Public Class ArchiveFolder

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
        End Sub

        Public Sub StartTimer()
            _ArchiveName = Settings.DesktopSetting("UserControls.Views.ArchiveFolder", "ArchiveName")
            _FolderName = Settings.DesktopSetting("UserControls.Views.ArchiveFolder", "FolderName")

            ArchiveNameTextBox.Text = _ArchiveName
            FolderNameTextBox.Text = _FolderName
        End Sub

#Region " Events "

        Private Sub ArchiveNameButton_Click(sender As Object, e As EventArgs) Handles ArchiveNameButton.Click
            ArchiveNameTextBox.SaveFile("", "Archive Name")
        End Sub

        Private Sub BackupAddonsButtonButton_Click(sender As Object, e As EventArgs) Handles BackupAddonsButton.Click
            Enabled = False

            _ArchiveName = $"Z:\BackUps\AddOns_{GetCurrentDate("yyyy_MM_dd_HH_mm")}.7z"
            _FolderName = "D:\Games\Activision\World of Warcraft\_retail_\Interface\AddOns"

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

        Private Sub BackupWTFButton_Click(sender As Object, e As EventArgs) Handles BackupWTFButton.Click
            Enabled = False

            _ArchiveName = $"Z:\BackUps\POESBOI_{GetCurrentDate("yyyy_MM_dd_HH_mm")}.7z"
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
                MainListResults.AddMessage($"   Archive: {_ArchiveName}")
                MainListResults.AddMessage($"   Folder: {_FolderName}")

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

                Dim SZC As New SevenZip.SevenZipCompressor With {
                    .ArchiveFormat = SevenZip.OutArchiveFormat.SevenZip,
                    .CompressionLevel = SevenZip.CompressionLevel.Ultra,
                    .CompressionMethod = SevenZip.CompressionMethod.Lzma2,
                    .CompressionMode = SevenZip.CompressionMode.Create
                }
                SZC.CompressDirectory(_FolderName, _ArchiveName, "", "*", True)

                Dim FileSize = New IO.FileInfo(_ArchiveName).Length

                MainListResults.AddMessage($"   File Size: {FileSize.GetReadableSize()}")
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage($"   ERROR: {ex.Message}")
            Finally
                MainListResults.AddMessage("Complete.")
            End Try
        End Sub

        Private Sub MainBackgroundWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles MainBackgroundWorker.RunWorkerCompleted
            Enabled = True
        End Sub

        Private Sub Me_Changed(sender As Object, e As EventArgs) Handles FolderNameTextBox.TextChanged, ArchiveNameTextBox.TextChanged
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

            Settings.DesktopSetting("UserControls.Views.ArchiveFolder", "ArchiveName") = _ArchiveName
            Settings.DesktopSetting("UserControls.Views.ArchiveFolder", "FolderName") = _FolderName

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

        Private Sub Timer_Elapsed(sender As Object, e As Timers.ElapsedEventArgs)
            _Timer.Stop()

            MainListResults.AddMessage("Checking Daily WTF Backup...")

            _ArchiveName = $"Z:\BackUps\POESBOI_{GetCurrentDate("yyyy_MM_dd")}.7z"
            _FolderName = "D:\Games\Activision\World of Warcraft\_retail_\WTF\Account\POESBOI"

            If Not _ArchiveName.FileExists() Then
                MainBackgroundWorker.RunWorkerAsync()
            End If

            _Timer.Start()
        End Sub

#End Region

    End Class

End Namespace