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
            Me.MainBackgroundWorker = New System.ComponentModel.BackgroundWorker()
            Me.ClearButton = New CommonRoutines.UserControls.Button()
            Me.ProcessButton = New CommonRoutines.UserControls.Button()
            Me.FolderNameButton = New CommonRoutines.UserControls.Button()
            Me.FolderNameTextBox = New CommonRoutines.UserControls.TextBox()
            Me.ArchiveNameTextBox = New CommonRoutines.UserControls.TextBox()
            Me.ArchiveNameButton = New CommonRoutines.UserControls.Button()
            Me.FolderNameLabel = New System.Windows.Forms.Label()
            Me.ArchiveNameLabel = New System.Windows.Forms.Label()
            Me.MainListResults = New CommonRoutines.UserControls.ListResults()
            Me.BackupAddonsButton = New CommonRoutines.UserControls.Button()
            Me.BackupWTFButton = New CommonRoutines.UserControls.Button()
            Me.SuspendLayout()
            '
            'MainBackgroundWorker
            '
            '
            'ClearButton
            '
            Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ClearButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.ClearButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.ClearButton.BorderRadius = 0
            Me.ClearButton.BorderSize = 1
            Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.ClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.ClearButton.Location = New System.Drawing.Point(674, 856)
            Me.ClearButton.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.ClearButton.Name = "ClearButton"
            Me.ClearButton.Size = New System.Drawing.Size(80, 30)
            Me.ClearButton.TabIndex = 46
            Me.ClearButton.Text = "Clear"
            Me.ClearButton.UseVisualStyleBackColor = True
            '
            'ProcessButton
            '
            Me.ProcessButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.ProcessButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.ProcessButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.ProcessButton.BorderRadius = 0
            Me.ProcessButton.BorderSize = 1
            Me.ProcessButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ProcessButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.ProcessButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.ProcessButton.Location = New System.Drawing.Point(8, 856)
            Me.ProcessButton.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.ProcessButton.Name = "ProcessButton"
            Me.ProcessButton.Size = New System.Drawing.Size(80, 30)
            Me.ProcessButton.TabIndex = 47
            Me.ProcessButton.Text = "Process"
            Me.ProcessButton.UseVisualStyleBackColor = True
            '
            'FolderNameButton
            '
            Me.FolderNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FolderNameButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.FolderNameButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.FolderNameButton.BorderRadius = 0
            Me.FolderNameButton.BorderSize = 1
            Me.FolderNameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.FolderNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.FolderNameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.FolderNameButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.FolderNameButton.Location = New System.Drawing.Point(723, 5)
            Me.FolderNameButton.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.FolderNameButton.Name = "FolderNameButton"
            Me.FolderNameButton.Size = New System.Drawing.Size(31, 31)
            Me.FolderNameButton.TabIndex = 48
            Me.FolderNameButton.Text = "..."
            Me.FolderNameButton.UseVisualStyleBackColor = True
            '
            'FolderNameTextBox
            '
            Me.FolderNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FolderNameTextBox.BackColor = System.Drawing.SystemColors.Window
            Me.FolderNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.FolderNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink
            Me.FolderNameTextBox.BorderRadius = 0
            Me.FolderNameTextBox.BorderSize = 2
            Me.FolderNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FolderNameTextBox.ForeColor = System.Drawing.Color.DimGray
            Me.FolderNameTextBox.Location = New System.Drawing.Point(110, 5)
            Me.FolderNameTextBox.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.FolderNameTextBox.Multiline = False
            Me.FolderNameTextBox.Name = "FolderNameTextBox"
            Me.FolderNameTextBox.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.FolderNameTextBox.PasswordChar = False
            Me.FolderNameTextBox.PlaceHolderColor = System.Drawing.Color.DarkGray
            Me.FolderNameTextBox.PlaceHolderText = ""
            Me.FolderNameTextBox.Size = New System.Drawing.Size(608, 31)
            Me.FolderNameTextBox.TabIndex = 49
            Me.FolderNameTextBox.UnderlinedStyle = False
            '
            'ArchiveNameTextBox
            '
            Me.ArchiveNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ArchiveNameTextBox.BackColor = System.Drawing.SystemColors.Window
            Me.ArchiveNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.ArchiveNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink
            Me.ArchiveNameTextBox.BorderRadius = 0
            Me.ArchiveNameTextBox.BorderSize = 2
            Me.ArchiveNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ArchiveNameTextBox.ForeColor = System.Drawing.Color.DimGray
            Me.ArchiveNameTextBox.Location = New System.Drawing.Point(110, 41)
            Me.ArchiveNameTextBox.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.ArchiveNameTextBox.Multiline = False
            Me.ArchiveNameTextBox.Name = "ArchiveNameTextBox"
            Me.ArchiveNameTextBox.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.ArchiveNameTextBox.PasswordChar = False
            Me.ArchiveNameTextBox.PlaceHolderColor = System.Drawing.Color.DarkGray
            Me.ArchiveNameTextBox.PlaceHolderText = ""
            Me.ArchiveNameTextBox.Size = New System.Drawing.Size(608, 31)
            Me.ArchiveNameTextBox.TabIndex = 51
            Me.ArchiveNameTextBox.UnderlinedStyle = False
            '
            'ArchiveNameButton
            '
            Me.ArchiveNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ArchiveNameButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.ArchiveNameButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.ArchiveNameButton.BorderRadius = 0
            Me.ArchiveNameButton.BorderSize = 1
            Me.ArchiveNameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ArchiveNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ArchiveNameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.ArchiveNameButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.ArchiveNameButton.Location = New System.Drawing.Point(723, 41)
            Me.ArchiveNameButton.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.ArchiveNameButton.Name = "ArchiveNameButton"
            Me.ArchiveNameButton.Size = New System.Drawing.Size(31, 31)
            Me.ArchiveNameButton.TabIndex = 50
            Me.ArchiveNameButton.Text = "..."
            Me.ArchiveNameButton.UseVisualStyleBackColor = True
            '
            'FolderNameLabel
            '
            Me.FolderNameLabel.Cursor = System.Windows.Forms.Cursors.Default
            Me.FolderNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.FolderNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.FolderNameLabel.Location = New System.Drawing.Point(5, 5)
            Me.FolderNameLabel.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.FolderNameLabel.Name = "FolderNameLabel"
            Me.FolderNameLabel.Size = New System.Drawing.Size(100, 31)
            Me.FolderNameLabel.TabIndex = 64
            Me.FolderNameLabel.Text = "Folder Name"
            Me.FolderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ArchiveNameLabel
            '
            Me.ArchiveNameLabel.Cursor = System.Windows.Forms.Cursors.Default
            Me.ArchiveNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.ArchiveNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.ArchiveNameLabel.Location = New System.Drawing.Point(5, 41)
            Me.ArchiveNameLabel.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.ArchiveNameLabel.Name = "ArchiveNameLabel"
            Me.ArchiveNameLabel.Size = New System.Drawing.Size(100, 31)
            Me.ArchiveNameLabel.TabIndex = 65
            Me.ArchiveNameLabel.Text = "Archive Name"
            Me.ArchiveNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MainListResults
            '
            Me.MainListResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MainListResults.BackColor = System.Drawing.SystemColors.Window
            Me.MainListResults.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.MainListResults.BorderFocusColor = System.Drawing.Color.HotPink
            Me.MainListResults.BorderRadius = 0
            Me.MainListResults.BorderSize = 2
            Me.MainListResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MainListResults.ForeColor = System.Drawing.Color.DimGray
            Me.MainListResults.Indent = 0
            Me.MainListResults.Location = New System.Drawing.Point(8, 77)
            Me.MainListResults.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.MainListResults.Name = "MainListResults"
            Me.MainListResults.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.MainListResults.Size = New System.Drawing.Size(746, 774)
            Me.MainListResults.TabIndex = 66
            Me.MainListResults.UnderlinedStyle = False
            '
            'BackupAddonsButton
            '
            Me.BackupAddonsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.BackupAddonsButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.BackupAddonsButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.BackupAddonsButton.BorderRadius = 0
            Me.BackupAddonsButton.BorderSize = 1
            Me.BackupAddonsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.BackupAddonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BackupAddonsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.BackupAddonsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.BackupAddonsButton.Location = New System.Drawing.Point(93, 856)
            Me.BackupAddonsButton.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.BackupAddonsButton.Name = "BackupAddonsButton"
            Me.BackupAddonsButton.Size = New System.Drawing.Size(125, 30)
            Me.BackupAddonsButton.TabIndex = 67
            Me.BackupAddonsButton.Text = "Backup Addons"
            Me.BackupAddonsButton.UseVisualStyleBackColor = True
            '
            'BackupWTFButton
            '
            Me.BackupWTFButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.BackupWTFButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.BackupWTFButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.BackupWTFButton.BorderRadius = 0
            Me.BackupWTFButton.BorderSize = 1
            Me.BackupWTFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.BackupWTFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BackupWTFButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.BackupWTFButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.BackupWTFButton.Location = New System.Drawing.Point(223, 856)
            Me.BackupWTFButton.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.BackupWTFButton.Name = "BackupWTFButton"
            Me.BackupWTFButton.Size = New System.Drawing.Size(115, 30)
            Me.BackupWTFButton.TabIndex = 68
            Me.BackupWTFButton.Text = "Backup WTF"
            Me.BackupWTFButton.UseVisualStyleBackColor = True
            '
            'ArchiveFolder
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.Controls.Add(Me.BackupWTFButton)
            Me.Controls.Add(Me.BackupAddonsButton)
            Me.Controls.Add(Me.MainListResults)
            Me.Controls.Add(Me.ArchiveNameLabel)
            Me.Controls.Add(Me.FolderNameLabel)
            Me.Controls.Add(Me.ArchiveNameTextBox)
            Me.Controls.Add(Me.ArchiveNameButton)
            Me.Controls.Add(Me.FolderNameTextBox)
            Me.Controls.Add(Me.FolderNameButton)
            Me.Controls.Add(Me.ProcessButton)
            Me.Controls.Add(Me.ClearButton)
            Me.DoubleBuffered = True
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "ArchiveFolder"
            Me.Size = New System.Drawing.Size(759, 891)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents MainBackgroundWorker As System.ComponentModel.BackgroundWorker
        Private WithEvents ClearButton As CommonRoutines.UserControls.Button
        Private WithEvents ProcessButton As CommonRoutines.UserControls.Button
        Private WithEvents FolderNameButton As CommonRoutines.UserControls.Button
        Friend WithEvents FolderNameTextBox As CommonRoutines.UserControls.TextBox
        Friend WithEvents ArchiveNameTextBox As CommonRoutines.UserControls.TextBox
        Private WithEvents ArchiveNameButton As CommonRoutines.UserControls.Button
        Private WithEvents FolderNameLabel As Label
        Private WithEvents ArchiveNameLabel As Label
        Private WithEvents MainListResults As CommonRoutines.UserControls.ListResults
        Private WithEvents BackupAddonsButton As CommonRoutines.UserControls.Button
        Private WithEvents BackupWTFButton As CommonRoutines.UserControls.Button
    End Class

End Namespace