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
            MainListResults = New Aprotec.UserControls.ListResultsBorder()
            MainBackgroundWorker = New ComponentModel.BackgroundWorker()
            ClearButton = New Aprotec.UserControls.Button()
            BjornButton = New Aprotec.UserControls.Button()
            NixButton = New Aprotec.UserControls.Button()
            BothButton = New Aprotec.UserControls.Button()
            SavedVariablesCheckBox = New Aprotec.UserControls.CheckBox()
            IncludeTemplatesCheckBox = New Aprotec.UserControls.CheckBox()
            FontsButton = New Aprotec.UserControls.Button()
            SuspendLayout()
            ' 
            ' StatusLabel
            ' 
            StatusLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            StatusLabel.Font = New Font("Microsoft Sans Serif", 11F)
            StatusLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            StatusLabel.ImageAlign = ContentAlignment.MiddleLeft
            StatusLabel.Location = New Point(0, 0)
            StatusLabel.Margin = New Padding(0, 0, 0, 5)
            StatusLabel.Name = "StatusLabel"
            StatusLabel.Size = New Size(1026, 23)
            StatusLabel.TabIndex = 44
            StatusLabel.Text = "Status"
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' MainListResults
            ' 
            MainListResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            MainListResults.BackColor = SystemColors.Window
            MainListResults.BorderColor = Color.MediumSlateBlue
            MainListResults.BorderFocusColor = Color.HotPink
            MainListResults.BorderRadius = 0
            MainListResults.BorderSize = 2
            MainListResults.Font = New Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            MainListResults.ForeColor = Color.DimGray
            MainListResults.Indent = 0
            MainListResults.Location = New Point(0, 28)
            MainListResults.Margin = New Padding(0, 0, 0, 5)
            MainListResults.Name = "MainListResults"
            MainListResults.Padding = New Padding(12, 8, 12, 8)
            MainListResults.Size = New Size(1026, 399)
            MainListResults.TabIndex = 45
            MainListResults.UnderlinedStyle = False
            ' 
            ' MainBackgroundWorker
            ' 
            ' 
            ' ClearButton
            ' 
            ClearButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            ClearButton.BackColor = Color.MediumSlateBlue
            ClearButton.BorderColor = Color.PaleVioletRed
            ClearButton.BorderRadius = 0
            ClearButton.BorderSize = 1
            ClearButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            ClearButton.FlatStyle = FlatStyle.Flat
            ClearButton.Font = New Font("Microsoft Sans Serif", 11F)
            ClearButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ClearButton.Location = New Point(946, 432)
            ClearButton.Margin = New Padding(0)
            ClearButton.Name = "ClearButton"
            ClearButton.Size = New Size(80, 30)
            ClearButton.TabIndex = 46
            ClearButton.Text = "Clear"
            ClearButton.UseVisualStyleBackColor = True
            ' 
            ' BjornButton
            ' 
            BjornButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            BjornButton.BackColor = Color.MediumSlateBlue
            BjornButton.BorderColor = Color.PaleVioletRed
            BjornButton.BorderRadius = 0
            BjornButton.BorderSize = 1
            BjornButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            BjornButton.FlatStyle = FlatStyle.Flat
            BjornButton.Font = New Font("Microsoft Sans Serif", 11F)
            BjornButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            BjornButton.Location = New Point(0, 432)
            BjornButton.Margin = New Padding(0, 0, 5, 0)
            BjornButton.Name = "BjornButton"
            BjornButton.Size = New Size(80, 30)
            BjornButton.TabIndex = 47
            BjornButton.Text = "Bjorn"
            BjornButton.UseVisualStyleBackColor = True
            ' 
            ' NixButton
            ' 
            NixButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            NixButton.BackColor = Color.MediumSlateBlue
            NixButton.BorderColor = Color.PaleVioletRed
            NixButton.BorderRadius = 0
            NixButton.BorderSize = 1
            NixButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            NixButton.FlatStyle = FlatStyle.Flat
            NixButton.Font = New Font("Microsoft Sans Serif", 11F)
            NixButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            NixButton.Location = New Point(85, 432)
            NixButton.Margin = New Padding(0, 0, 5, 0)
            NixButton.Name = "NixButton"
            NixButton.Size = New Size(80, 30)
            NixButton.TabIndex = 48
            NixButton.Text = "Nix"
            NixButton.UseVisualStyleBackColor = True
            ' 
            ' BothButton
            ' 
            BothButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            BothButton.BackColor = Color.MediumSlateBlue
            BothButton.BorderColor = Color.PaleVioletRed
            BothButton.BorderRadius = 0
            BothButton.BorderSize = 1
            BothButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            BothButton.FlatStyle = FlatStyle.Flat
            BothButton.Font = New Font("Microsoft Sans Serif", 11F)
            BothButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            BothButton.Location = New Point(170, 432)
            BothButton.Margin = New Padding(0, 0, 5, 0)
            BothButton.Name = "BothButton"
            BothButton.Size = New Size(80, 30)
            BothButton.TabIndex = 49
            BothButton.Text = "Both"
            BothButton.UseVisualStyleBackColor = True
            ' 
            ' SavedVariablesCheckBox
            ' 
            SavedVariablesCheckBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            SavedVariablesCheckBox.AutoSize = True
            SavedVariablesCheckBox.CheckedColor = Color.MediumSlateBlue
            SavedVariablesCheckBox.Location = New Point(391, 439)
            SavedVariablesCheckBox.Margin = New Padding(0, 0, 5, 0)
            SavedVariablesCheckBox.MinimumSize = New Size(0, 21)
            SavedVariablesCheckBox.Name = "SavedVariablesCheckBox"
            SavedVariablesCheckBox.Padding = New Padding(10, 0, 0, 0)
            SavedVariablesCheckBox.Size = New Size(158, 21)
            SavedVariablesCheckBox.TabIndex = 50
            SavedVariablesCheckBox.Text = "Include Saved Variables"
            SavedVariablesCheckBox.UncheckedColor = Color.Gray
            SavedVariablesCheckBox.UseTick = False
            SavedVariablesCheckBox.UseVisualStyleBackColor = True
            ' 
            ' IncludeTemplatesCheckBox
            ' 
            IncludeTemplatesCheckBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            IncludeTemplatesCheckBox.AutoSize = True
            IncludeTemplatesCheckBox.CheckedColor = Color.MediumSlateBlue
            IncludeTemplatesCheckBox.Location = New Point(255, 439)
            IncludeTemplatesCheckBox.Margin = New Padding(0, 0, 5, 0)
            IncludeTemplatesCheckBox.MinimumSize = New Size(0, 21)
            IncludeTemplatesCheckBox.Name = "IncludeTemplatesCheckBox"
            IncludeTemplatesCheckBox.Padding = New Padding(10, 0, 0, 0)
            IncludeTemplatesCheckBox.Size = New Size(131, 21)
            IncludeTemplatesCheckBox.TabIndex = 51
            IncludeTemplatesCheckBox.Text = "Include Templates"
            IncludeTemplatesCheckBox.UncheckedColor = Color.Gray
            IncludeTemplatesCheckBox.UseTick = False
            IncludeTemplatesCheckBox.UseVisualStyleBackColor = True
            ' 
            ' FontsButton
            ' 
            FontsButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            FontsButton.BackColor = Color.MediumSlateBlue
            FontsButton.BorderColor = Color.PaleVioletRed
            FontsButton.BorderRadius = 0
            FontsButton.BorderSize = 1
            FontsButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            FontsButton.FlatStyle = FlatStyle.Flat
            FontsButton.Font = New Font("Microsoft Sans Serif", 11F)
            FontsButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            FontsButton.Location = New Point(554, 432)
            FontsButton.Margin = New Padding(0, 0, 5, 0)
            FontsButton.Name = "FontsButton"
            FontsButton.Size = New Size(80, 30)
            FontsButton.TabIndex = 52
            FontsButton.Text = "Fonts"
            FontsButton.UseVisualStyleBackColor = True
            ' 
            ' WoWProfileChecker
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
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
            Margin = New Padding(0)
            Name = "WoWProfileChecker"
            Size = New Size(1026, 462)
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Private StatusLabel As Label
        Private WithEvents MainListResults As Aprotec.UserControls.ListResultsBorder
        Private WithEvents MainBackgroundWorker As System.ComponentModel.BackgroundWorker
        Private WithEvents ClearButton As Aprotec.UserControls.Button
        Private WithEvents BjornButton As Aprotec.UserControls.Button
        Private WithEvents NixButton As Aprotec.UserControls.Button
        Private WithEvents BothButton As Aprotec.UserControls.Button
        Friend WithEvents SavedVariablesCheckBox As Aprotec.UserControls.CheckBox
        Friend WithEvents IncludeTemplatesCheckBox As Aprotec.UserControls.CheckBox
        Private WithEvents FontsButton As Aprotec.UserControls.Button
    End Class

End Namespace