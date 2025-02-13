Namespace UserControls.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ArchiveFolder
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            MainBackgroundWorker = New ComponentModel.BackgroundWorker()
            ClearButton = New Button()
            ProcessButton = New Button()
            FolderNameButton = New Button()
            FolderNameTextBox = New TextBox()
            ArchiveNameTextBox = New TextBox()
            ArchiveNameButton = New Button()
            FolderNameLabel = New Label()
            ArchiveNameLabel = New Label()
            MainListResults = New PoesShared.UserControls.ListResults()
            BackupAddonsButton = New Button()
            BackupWTFButton = New Button()
            SuspendLayout()
            ' 
            ' MainBackgroundWorker
            ' 
            ' 
            ' ClearButton
            ' 
            ClearButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            ClearButton.BackColor = Color.MediumSlateBlue
            ClearButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            ClearButton.FlatStyle = FlatStyle.Flat
            ClearButton.Font = New Font("Tahoma", 8.25F)
            ClearButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ClearButton.Location = New Point(674, 863)
            ClearButton.Margin = New Padding(0, 0, 5, 5)
            ClearButton.Name = "ClearButton"
            ClearButton.Size = New Size(80, 23)
            ClearButton.TabIndex = 8
            ClearButton.Text = "Clear"
            ClearButton.UseVisualStyleBackColor = True
            ' 
            ' ProcessButton
            ' 
            ProcessButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            ProcessButton.BackColor = Color.MediumSlateBlue
            ProcessButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            ProcessButton.FlatStyle = FlatStyle.Flat
            ProcessButton.Font = New Font("Tahoma", 8.25F)
            ProcessButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ProcessButton.Location = New Point(5, 863)
            ProcessButton.Margin = New Padding(5, 0, 5, 5)
            ProcessButton.Name = "ProcessButton"
            ProcessButton.Size = New Size(80, 23)
            ProcessButton.TabIndex = 5
            ProcessButton.Text = "Process"
            ProcessButton.UseVisualStyleBackColor = True
            ' 
            ' FolderNameButton
            ' 
            FolderNameButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            FolderNameButton.BackColor = Color.MediumSlateBlue
            FolderNameButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            FolderNameButton.FlatStyle = FlatStyle.Flat
            FolderNameButton.Font = New Font("Tahoma", 8.25F)
            FolderNameButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            FolderNameButton.Location = New Point(724, 5)
            FolderNameButton.Margin = New Padding(0, 5, 5, 5)
            FolderNameButton.Name = "FolderNameButton"
            FolderNameButton.Size = New Size(30, 21)
            FolderNameButton.TabIndex = 1
            FolderNameButton.Text = "..."
            FolderNameButton.UseVisualStyleBackColor = True
            ' 
            ' FolderNameTextBox
            ' 
            FolderNameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            FolderNameTextBox.BackColor = SystemColors.Window
            FolderNameTextBox.Font = New Font("Tahoma", 8.25F)
            FolderNameTextBox.ForeColor = Color.DimGray
            FolderNameTextBox.Location = New Point(110, 5)
            FolderNameTextBox.Margin = New Padding(0, 5, 5, 5)
            FolderNameTextBox.Name = "FolderNameTextBox"
            FolderNameTextBox.Size = New Size(609, 21)
            FolderNameTextBox.TabIndex = 0
            ' 
            ' ArchiveNameTextBox
            ' 
            ArchiveNameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            ArchiveNameTextBox.BackColor = SystemColors.Window
            ArchiveNameTextBox.Font = New Font("Tahoma", 8.25F)
            ArchiveNameTextBox.ForeColor = Color.DimGray
            ArchiveNameTextBox.Location = New Point(110, 31)
            ArchiveNameTextBox.Margin = New Padding(0, 0, 5, 5)
            ArchiveNameTextBox.Name = "ArchiveNameTextBox"
            ArchiveNameTextBox.Size = New Size(609, 21)
            ArchiveNameTextBox.TabIndex = 2
            ' 
            ' ArchiveNameButton
            ' 
            ArchiveNameButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ArchiveNameButton.BackColor = Color.MediumSlateBlue
            ArchiveNameButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            ArchiveNameButton.FlatStyle = FlatStyle.Flat
            ArchiveNameButton.Font = New Font("Tahoma", 8.25F)
            ArchiveNameButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ArchiveNameButton.Location = New Point(724, 31)
            ArchiveNameButton.Margin = New Padding(0, 0, 5, 5)
            ArchiveNameButton.Name = "ArchiveNameButton"
            ArchiveNameButton.Size = New Size(30, 21)
            ArchiveNameButton.TabIndex = 3
            ArchiveNameButton.Text = "..."
            ArchiveNameButton.UseVisualStyleBackColor = True
            ' 
            ' FolderNameLabel
            ' 
            FolderNameLabel.Font = New Font("Tahoma", 8.25F)
            FolderNameLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            FolderNameLabel.Location = New Point(5, 5)
            FolderNameLabel.Margin = New Padding(5)
            FolderNameLabel.Name = "FolderNameLabel"
            FolderNameLabel.Size = New Size(100, 21)
            FolderNameLabel.TabIndex = 64
            FolderNameLabel.Text = "Folder Name"
            FolderNameLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' ArchiveNameLabel
            ' 
            ArchiveNameLabel.Font = New Font("Tahoma", 8.25F)
            ArchiveNameLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ArchiveNameLabel.Location = New Point(5, 31)
            ArchiveNameLabel.Margin = New Padding(0, 0, 5, 5)
            ArchiveNameLabel.Name = "ArchiveNameLabel"
            ArchiveNameLabel.Size = New Size(100, 21)
            ArchiveNameLabel.TabIndex = 65
            ArchiveNameLabel.Text = "Archive Name"
            ArchiveNameLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' MainListResults
            ' 
            MainListResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            MainListResults.BackColor = SystemColors.Window
            MainListResults.BorderColor = Color.MediumSlateBlue
            MainListResults.BorderSize = New Padding(2)
            MainListResults.Font = New Font("Tahoma", 8.25F)
            MainListResults.Indent = 0
            MainListResults.Location = New Point(5, 57)
            MainListResults.Margin = New Padding(5, 0, 5, 5)
            MainListResults.Name = "MainListResults"
            MainListResults.Padding = New Padding(2)
            MainListResults.Size = New Size(749, 801)
            MainListResults.TabIndex = 4
            ' 
            ' BackupAddonsButton
            ' 
            BackupAddonsButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            BackupAddonsButton.BackColor = Color.MediumSlateBlue
            BackupAddonsButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            BackupAddonsButton.FlatStyle = FlatStyle.Flat
            BackupAddonsButton.Font = New Font("Tahoma", 8.25F)
            BackupAddonsButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            BackupAddonsButton.Location = New Point(90, 863)
            BackupAddonsButton.Margin = New Padding(0, 0, 5, 5)
            BackupAddonsButton.Name = "BackupAddonsButton"
            BackupAddonsButton.Size = New Size(125, 23)
            BackupAddonsButton.TabIndex = 6
            BackupAddonsButton.Text = "Backup Addons"
            BackupAddonsButton.UseVisualStyleBackColor = True
            ' 
            ' BackupWTFButton
            ' 
            BackupWTFButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            BackupWTFButton.BackColor = Color.MediumSlateBlue
            BackupWTFButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            BackupWTFButton.FlatStyle = FlatStyle.Flat
            BackupWTFButton.Font = New Font("Tahoma", 8.25F)
            BackupWTFButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            BackupWTFButton.Location = New Point(220, 863)
            BackupWTFButton.Margin = New Padding(0, 0, 5, 5)
            BackupWTFButton.Name = "BackupWTFButton"
            BackupWTFButton.Size = New Size(115, 23)
            BackupWTFButton.TabIndex = 7
            BackupWTFButton.Text = "Backup WTF"
            BackupWTFButton.UseVisualStyleBackColor = True
            ' 
            ' ArchiveFolder
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(BackupWTFButton)
            Controls.Add(BackupAddonsButton)
            Controls.Add(MainListResults)
            Controls.Add(ArchiveNameLabel)
            Controls.Add(FolderNameLabel)
            Controls.Add(ArchiveNameTextBox)
            Controls.Add(ArchiveNameButton)
            Controls.Add(FolderNameTextBox)
            Controls.Add(FolderNameButton)
            Controls.Add(ProcessButton)
            Controls.Add(ClearButton)
            DoubleBuffered = True
            Font = New Font("Tahoma", 8.25F)
            Margin = New Padding(0)
            Name = "ArchiveFolder"
            Size = New Size(759, 891)
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Private WithEvents MainBackgroundWorker As System.ComponentModel.BackgroundWorker
        Private WithEvents ClearButton As Button
        Private WithEvents ProcessButton As Button
        Private WithEvents FolderNameButton As Button
        Private WithEvents ArchiveNameButton As Button
        Private WithEvents FolderNameLabel As Label
        Private WithEvents ArchiveNameLabel As Label
        Private WithEvents MainListResults As PoesShared.UserControls.ListResults
        Private WithEvents BackupAddonsButton As Button
        Private WithEvents BackupWTFButton As Button
        Private WithEvents FolderNameTextBox As TextBox
        Private WithEvents ArchiveNameTextBox As TextBox
    End Class

End Namespace