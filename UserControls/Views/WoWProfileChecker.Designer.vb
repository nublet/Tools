Namespace UserControls.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class WoWProfileChecker
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
            StatusLabel = New Label()
            MainListResults = New PoesShared.UserControls.ListResults()
            MainBackgroundWorker = New ComponentModel.BackgroundWorker()
            ClearButton = New Button()
            BjornButton = New Button()
            NixButton = New Button()
            BothButton = New Button()
            SavedVariablesCheckBox = New CheckBox()
            IncludeTemplatesCheckBox = New CheckBox()
            FontsButton = New Button()
            FailedButton = New Button()
            SuspendLayout()
            ' 
            ' StatusLabel
            ' 
            StatusLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            StatusLabel.Font = New Font("Tahoma", 8.25F)
            StatusLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            StatusLabel.ImageAlign = ContentAlignment.MiddleLeft
            StatusLabel.Location = New Point(5, 5)
            StatusLabel.Margin = New Padding(5)
            StatusLabel.Name = "StatusLabel"
            StatusLabel.Size = New Size(1016, 23)
            StatusLabel.TabIndex = 44
            StatusLabel.Text = "Status"
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' MainListResults
            ' 
            MainListResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            MainListResults.BackColor = SystemColors.Window
            MainListResults.BorderColor = Color.MediumSlateBlue
            MainListResults.BorderSize = New Padding(2)
            MainListResults.Font = New Font("Tahoma", 8.25F)
            MainListResults.Indent = 0
            MainListResults.Location = New Point(5, 33)
            MainListResults.Margin = New Padding(5, 0, 5, 5)
            MainListResults.Name = "MainListResults"
            MainListResults.Padding = New Padding(2)
            MainListResults.Size = New Size(1016, 396)
            MainListResults.TabIndex = 0
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
            ClearButton.Location = New Point(941, 434)
            ClearButton.Margin = New Padding(0, 0, 5, 5)
            ClearButton.Name = "ClearButton"
            ClearButton.Size = New Size(80, 23)
            ClearButton.TabIndex = 8
            ClearButton.Text = "Clear"
            ClearButton.UseVisualStyleBackColor = True
            ' 
            ' BjornButton
            ' 
            BjornButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            BjornButton.BackColor = Color.MediumSlateBlue
            BjornButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            BjornButton.FlatStyle = FlatStyle.Flat
            BjornButton.Font = New Font("Tahoma", 8.25F)
            BjornButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            BjornButton.Location = New Point(5, 434)
            BjornButton.Margin = New Padding(5, 0, 5, 5)
            BjornButton.Name = "BjornButton"
            BjornButton.Size = New Size(80, 23)
            BjornButton.TabIndex = 1
            BjornButton.Text = "Bjorn"
            BjornButton.UseVisualStyleBackColor = True
            ' 
            ' NixButton
            ' 
            NixButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            NixButton.BackColor = Color.MediumSlateBlue
            NixButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            NixButton.FlatStyle = FlatStyle.Flat
            NixButton.Font = New Font("Tahoma", 8.25F)
            NixButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            NixButton.Location = New Point(90, 434)
            NixButton.Margin = New Padding(0, 0, 5, 5)
            NixButton.Name = "NixButton"
            NixButton.Size = New Size(80, 23)
            NixButton.TabIndex = 2
            NixButton.Text = "Nix"
            NixButton.UseVisualStyleBackColor = True
            ' 
            ' BothButton
            ' 
            BothButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            BothButton.BackColor = Color.MediumSlateBlue
            BothButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            BothButton.FlatStyle = FlatStyle.Flat
            BothButton.Font = New Font("Tahoma", 8.25F)
            BothButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            BothButton.Location = New Point(175, 434)
            BothButton.Margin = New Padding(0, 0, 5, 5)
            BothButton.Name = "BothButton"
            BothButton.Size = New Size(80, 23)
            BothButton.TabIndex = 3
            BothButton.Text = "Both"
            BothButton.UseVisualStyleBackColor = True
            ' 
            ' SavedVariablesCheckBox
            ' 
            SavedVariablesCheckBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            SavedVariablesCheckBox.Font = New Font("Tahoma", 8.25F)
            SavedVariablesCheckBox.Location = New Point(395, 434)
            SavedVariablesCheckBox.Margin = New Padding(0, 0, 5, 5)
            SavedVariablesCheckBox.MinimumSize = New Size(0, 21)
            SavedVariablesCheckBox.Name = "SavedVariablesCheckBox"
            SavedVariablesCheckBox.Padding = New Padding(10, 0, 0, 0)
            SavedVariablesCheckBox.Size = New Size(160, 23)
            SavedVariablesCheckBox.TabIndex = 5
            SavedVariablesCheckBox.Text = "Include Saved Variables"
            SavedVariablesCheckBox.UseVisualStyleBackColor = True
            ' 
            ' IncludeTemplatesCheckBox
            ' 
            IncludeTemplatesCheckBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            IncludeTemplatesCheckBox.Font = New Font("Tahoma", 8.25F)
            IncludeTemplatesCheckBox.Location = New Point(260, 434)
            IncludeTemplatesCheckBox.Margin = New Padding(0, 0, 5, 5)
            IncludeTemplatesCheckBox.MinimumSize = New Size(0, 21)
            IncludeTemplatesCheckBox.Name = "IncludeTemplatesCheckBox"
            IncludeTemplatesCheckBox.Padding = New Padding(10, 0, 0, 0)
            IncludeTemplatesCheckBox.Size = New Size(130, 23)
            IncludeTemplatesCheckBox.TabIndex = 4
            IncludeTemplatesCheckBox.Text = "Include Templates"
            IncludeTemplatesCheckBox.UseVisualStyleBackColor = True
            ' 
            ' FontsButton
            ' 
            FontsButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            FontsButton.BackColor = Color.MediumSlateBlue
            FontsButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            FontsButton.FlatStyle = FlatStyle.Flat
            FontsButton.Font = New Font("Tahoma", 8.25F)
            FontsButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            FontsButton.Location = New Point(560, 434)
            FontsButton.Margin = New Padding(0, 0, 5, 5)
            FontsButton.Name = "FontsButton"
            FontsButton.Size = New Size(80, 23)
            FontsButton.TabIndex = 6
            FontsButton.Text = "Fonts"
            FontsButton.UseVisualStyleBackColor = True
            ' 
            ' FailedButton
            ' 
            FailedButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            FailedButton.BackColor = Color.MediumSlateBlue
            FailedButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            FailedButton.FlatStyle = FlatStyle.Flat
            FailedButton.Font = New Font("Tahoma", 8.25F)
            FailedButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            FailedButton.Location = New Point(645, 434)
            FailedButton.Margin = New Padding(0, 0, 5, 5)
            FailedButton.Name = "FailedButton"
            FailedButton.Size = New Size(80, 23)
            FailedButton.TabIndex = 7
            FailedButton.Text = "Failed"
            FailedButton.UseVisualStyleBackColor = True
            ' 
            ' WoWProfileChecker
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(FailedButton)
            Controls.Add(FontsButton)
            Controls.Add(IncludeTemplatesCheckBox)
            Controls.Add(SavedVariablesCheckBox)
            Controls.Add(BothButton)
            Controls.Add(NixButton)
            Controls.Add(BjornButton)
            Controls.Add(ClearButton)
            Controls.Add(MainListResults)
            Controls.Add(StatusLabel)
            DoubleBuffered = True
            Font = New Font("Tahoma", 8.25F)
            Margin = New Padding(0)
            Name = "WoWProfileChecker"
            Size = New Size(1026, 462)
            ResumeLayout(False)

        End Sub
        Private StatusLabel As Label
        Private WithEvents MainListResults As PoesShared.UserControls.ListResults
        Private WithEvents MainBackgroundWorker As System.ComponentModel.BackgroundWorker
        Private WithEvents ClearButton As Button
        Private WithEvents BjornButton As Button
        Private WithEvents NixButton As Button
        Private WithEvents BothButton As Button
        Private WithEvents FontsButton As Button
        Private WithEvents FailedButton As Button
        Private WithEvents SavedVariablesCheckBox As CheckBox
        Private WithEvents IncludeTemplatesCheckBox As CheckBox
    End Class

End Namespace