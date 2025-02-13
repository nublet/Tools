Namespace UserControls.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ModelGenerator
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
            GeneratorLabel = New Label()
            OutputDirectoryLabel = New Label()
            NamespaceLabel = New Label()
            MainPanel = New Panel()
            OpenOutputButton = New Button()
            GenerateButton = New Button()
            MainListResults = New PoesShared.UserControls.ListResults()
            GeneratorComboBox = New ComboBox()
            OutputDirectoryButton = New Button()
            OutputDirectoryTextBox = New TextBox()
            NamespaceTextBox = New TextBox()
            SuspendLayout()
            ' 
            ' GeneratorLabel
            ' 
            GeneratorLabel.Cursor = Cursors.Hand
            GeneratorLabel.Font = New Font("Tahoma", 8.25F)
            GeneratorLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            GeneratorLabel.Location = New Point(5, 5)
            GeneratorLabel.Margin = New Padding(5)
            GeneratorLabel.Name = "GeneratorLabel"
            GeneratorLabel.Size = New Size(125, 21)
            GeneratorLabel.TabIndex = 27
            GeneratorLabel.Text = "Generator"
            GeneratorLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' OutputDirectoryLabel
            ' 
            OutputDirectoryLabel.Cursor = Cursors.Hand
            OutputDirectoryLabel.Font = New Font("Tahoma", 8.25F)
            OutputDirectoryLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            OutputDirectoryLabel.Location = New Point(5, 31)
            OutputDirectoryLabel.Margin = New Padding(5, 0, 5, 5)
            OutputDirectoryLabel.Name = "OutputDirectoryLabel"
            OutputDirectoryLabel.Size = New Size(125, 21)
            OutputDirectoryLabel.TabIndex = 26
            OutputDirectoryLabel.Text = "Output Directory"
            OutputDirectoryLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' NamespaceLabel
            ' 
            NamespaceLabel.Cursor = Cursors.Hand
            NamespaceLabel.Font = New Font("Tahoma", 8.25F)
            NamespaceLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            NamespaceLabel.Location = New Point(5, 57)
            NamespaceLabel.Margin = New Padding(5, 0, 5, 5)
            NamespaceLabel.Name = "NamespaceLabel"
            NamespaceLabel.Size = New Size(125, 21)
            NamespaceLabel.TabIndex = 25
            NamespaceLabel.Text = "Namespace"
            NamespaceLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' MainPanel
            ' 
            MainPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            MainPanel.BorderStyle = BorderStyle.FixedSingle
            MainPanel.Font = New Font("Tahoma", 8.25F)
            MainPanel.Location = New Point(5, 83)
            MainPanel.Margin = New Padding(5, 0, 5, 5)
            MainPanel.Name = "MainPanel"
            MainPanel.Size = New Size(682, 220)
            MainPanel.TabIndex = 4
            ' 
            ' OpenOutputButton
            ' 
            OpenOutputButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            OpenOutputButton.BackColor = Color.MediumSlateBlue
            OpenOutputButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            OpenOutputButton.FlatStyle = FlatStyle.Flat
            OpenOutputButton.Font = New Font("Tahoma", 8.25F)
            OpenOutputButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            OpenOutputButton.Location = New Point(5, 538)
            OpenOutputButton.Margin = New Padding(5, 0, 5, 5)
            OpenOutputButton.Name = "OpenOutputButton"
            OpenOutputButton.Size = New Size(110, 23)
            OpenOutputButton.TabIndex = 6
            OpenOutputButton.Text = "Open Output"
            OpenOutputButton.UseVisualStyleBackColor = True
            ' 
            ' GenerateButton
            ' 
            GenerateButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            GenerateButton.BackColor = Color.MediumSlateBlue
            GenerateButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            GenerateButton.FlatStyle = FlatStyle.Flat
            GenerateButton.Font = New Font("Tahoma", 8.25F)
            GenerateButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            GenerateButton.Location = New Point(607, 538)
            GenerateButton.Margin = New Padding(5, 0, 5, 5)
            GenerateButton.Name = "GenerateButton"
            GenerateButton.Size = New Size(80, 23)
            GenerateButton.TabIndex = 7
            GenerateButton.Text = "Generate"
            GenerateButton.UseVisualStyleBackColor = True
            ' 
            ' MainListResults
            ' 
            MainListResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            MainListResults.BackColor = SystemColors.Window
            MainListResults.BorderColor = Color.MediumSlateBlue
            MainListResults.BorderSize = New Padding(2)
            MainListResults.BorderStyle = BorderStyle.FixedSingle
            MainListResults.Font = New Font("Tahoma", 8.25F)
            MainListResults.Indent = 0
            MainListResults.Location = New Point(5, 308)
            MainListResults.Margin = New Padding(5, 0, 5, 5)
            MainListResults.Name = "MainListResults"
            MainListResults.Padding = New Padding(2)
            MainListResults.Size = New Size(682, 225)
            MainListResults.TabIndex = 5
            ' 
            ' GeneratorComboBox
            ' 
            GeneratorComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            GeneratorComboBox.BackColor = Color.MediumSlateBlue
            GeneratorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            GeneratorComboBox.Font = New Font("Tahoma", 8.25F)
            GeneratorComboBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            GeneratorComboBox.FormattingEnabled = True
            GeneratorComboBox.Location = New Point(135, 5)
            GeneratorComboBox.Margin = New Padding(0, 5, 5, 5)
            GeneratorComboBox.Name = "GeneratorComboBox"
            GeneratorComboBox.Size = New Size(517, 21)
            GeneratorComboBox.TabIndex = 0
            ' 
            ' OutputDirectoryButton
            ' 
            OutputDirectoryButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            OutputDirectoryButton.BackColor = Color.MediumSlateBlue
            OutputDirectoryButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            OutputDirectoryButton.FlatStyle = FlatStyle.Flat
            OutputDirectoryButton.Font = New Font("Tahoma", 8.25F)
            OutputDirectoryButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            OutputDirectoryButton.Location = New Point(657, 31)
            OutputDirectoryButton.Margin = New Padding(0, 0, 5, 5)
            OutputDirectoryButton.Name = "OutputDirectoryButton"
            OutputDirectoryButton.Size = New Size(30, 21)
            OutputDirectoryButton.TabIndex = 2
            OutputDirectoryButton.Text = "..."
            OutputDirectoryButton.UseVisualStyleBackColor = True
            ' 
            ' OutputDirectoryTextBox
            ' 
            OutputDirectoryTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            OutputDirectoryTextBox.BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            OutputDirectoryTextBox.Font = New Font("Tahoma", 8.25F)
            OutputDirectoryTextBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            OutputDirectoryTextBox.Location = New Point(135, 31)
            OutputDirectoryTextBox.Margin = New Padding(0, 0, 5, 5)
            OutputDirectoryTextBox.Name = "OutputDirectoryTextBox"
            OutputDirectoryTextBox.Size = New Size(517, 21)
            OutputDirectoryTextBox.TabIndex = 1
            ' 
            ' NamespaceTextBox
            ' 
            NamespaceTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            NamespaceTextBox.BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            NamespaceTextBox.Font = New Font("Tahoma", 8.25F)
            NamespaceTextBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            NamespaceTextBox.Location = New Point(135, 57)
            NamespaceTextBox.Margin = New Padding(0, 0, 5, 5)
            NamespaceTextBox.Name = "NamespaceTextBox"
            NamespaceTextBox.Size = New Size(517, 21)
            NamespaceTextBox.TabIndex = 3
            ' 
            ' ModelGenerator
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(OpenOutputButton)
            Controls.Add(GenerateButton)
            Controls.Add(MainListResults)
            Controls.Add(MainPanel)
            Controls.Add(GeneratorComboBox)
            Controls.Add(OutputDirectoryButton)
            Controls.Add(OutputDirectoryTextBox)
            Controls.Add(NamespaceTextBox)
            Controls.Add(GeneratorLabel)
            Controls.Add(OutputDirectoryLabel)
            Controls.Add(NamespaceLabel)
            DoubleBuffered = True
            Font = New Font("Tahoma", 8.25F)
            Margin = New Padding(0)
            Name = "ModelGenerator"
            Size = New Size(692, 566)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Private WithEvents OutputDirectoryButton As Button
        Private WithEvents GeneratorLabel As Label
        Private WithEvents OutputDirectoryLabel As Label
        Private WithEvents NamespaceLabel As Label
        Private WithEvents GeneratorComboBox As ComboBox
        Private WithEvents OutputDirectoryTextBox As TextBox
        Private WithEvents NamespaceTextBox As TextBox
        Private WithEvents MainPanel As Panel
        Private WithEvents MainListResults As PoesShared.UserControls.ListResults
        Private WithEvents GenerateButton As Button
        Private WithEvents OpenOutputButton As Button
    End Class

End Namespace