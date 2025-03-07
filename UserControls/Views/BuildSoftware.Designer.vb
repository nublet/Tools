Namespace UserControls.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class BuildSoftware
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
            SoftwareVersionTextBox = New TextBox()
            SoftwareVersionLabel = New Label()
            OutputListResults = New PoesShared.UserControls.ListResults()
            StatusLabel = New Label()
            ErrorListResults = New PoesShared.UserControls.ListResults()
            OutputLabel = New Label()
            ErrorsLabel = New Label()
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
            ClearButton.TabIndex = 4
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
            ProcessButton.TabIndex = 3
            ProcessButton.Text = "Process"
            ProcessButton.UseVisualStyleBackColor = True
            ' 
            ' SoftwareVersionTextBox
            ' 
            SoftwareVersionTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            SoftwareVersionTextBox.BackColor = SystemColors.Window
            SoftwareVersionTextBox.Font = New Font("Tahoma", 8.25F)
            SoftwareVersionTextBox.ForeColor = Color.DimGray
            SoftwareVersionTextBox.Location = New Point(110, 5)
            SoftwareVersionTextBox.Margin = New Padding(0, 5, 5, 5)
            SoftwareVersionTextBox.Name = "SoftwareVersionTextBox"
            SoftwareVersionTextBox.Size = New Size(80, 21)
            SoftwareVersionTextBox.TabIndex = 0
            SoftwareVersionTextBox.Text = "25.0.2.201"
            ' 
            ' SoftwareVersionLabel
            ' 
            SoftwareVersionLabel.Font = New Font("Tahoma", 8.25F)
            SoftwareVersionLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            SoftwareVersionLabel.Location = New Point(5, 5)
            SoftwareVersionLabel.Margin = New Padding(5)
            SoftwareVersionLabel.Name = "SoftwareVersionLabel"
            SoftwareVersionLabel.Size = New Size(100, 21)
            SoftwareVersionLabel.TabIndex = 64
            SoftwareVersionLabel.Text = "Software Version"
            SoftwareVersionLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' OutputListResults
            ' 
            OutputListResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            OutputListResults.BackColor = SystemColors.Window
            OutputListResults.BorderColor = Color.MediumSlateBlue
            OutputListResults.BorderSize = New Padding(2)
            OutputListResults.Font = New Font("Tahoma", 8.25F)
            OutputListResults.Indent = 0
            OutputListResults.Location = New Point(5, 57)
            OutputListResults.Margin = New Padding(5, 0, 5, 5)
            OutputListResults.Name = "OutputListResults"
            OutputListResults.Padding = New Padding(2)
            OutputListResults.Size = New Size(749, 520)
            OutputListResults.TabIndex = 1
            ' 
            ' StatusLabel
            ' 
            StatusLabel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            StatusLabel.Font = New Font("Tahoma", 8.25F)
            StatusLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            StatusLabel.Location = New Point(90, 863)
            StatusLabel.Margin = New Padding(0, 0, 5, 5)
            StatusLabel.Name = "StatusLabel"
            StatusLabel.Size = New Size(579, 23)
            StatusLabel.TabIndex = 65
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' ErrorListResults
            ' 
            ErrorListResults.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            ErrorListResults.BackColor = SystemColors.Window
            ErrorListResults.BorderColor = Color.MediumSlateBlue
            ErrorListResults.BorderSize = New Padding(2)
            ErrorListResults.Font = New Font("Tahoma", 8.25F)
            ErrorListResults.Indent = 0
            ErrorListResults.Location = New Point(5, 608)
            ErrorListResults.Margin = New Padding(5, 0, 5, 5)
            ErrorListResults.Name = "ErrorListResults"
            ErrorListResults.Padding = New Padding(2)
            ErrorListResults.Size = New Size(749, 250)
            ErrorListResults.TabIndex = 2
            ' 
            ' OutputLabel
            ' 
            OutputLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            OutputLabel.Font = New Font("Tahoma", 8.25F)
            OutputLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            OutputLabel.Location = New Point(5, 31)
            OutputLabel.Margin = New Padding(5, 0, 5, 5)
            OutputLabel.Name = "OutputLabel"
            OutputLabel.Size = New Size(749, 21)
            OutputLabel.TabIndex = 67
            OutputLabel.Text = "Output"
            OutputLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' ErrorsLabel
            ' 
            ErrorsLabel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            ErrorsLabel.Font = New Font("Tahoma", 8.25F)
            ErrorsLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ErrorsLabel.Location = New Point(5, 582)
            ErrorsLabel.Margin = New Padding(5, 0, 5, 5)
            ErrorsLabel.Name = "ErrorsLabel"
            ErrorsLabel.Size = New Size(749, 21)
            ErrorsLabel.TabIndex = 68
            ErrorsLabel.Text = "Errors"
            ErrorsLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' BuildSoftware
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(ErrorsLabel)
            Controls.Add(OutputLabel)
            Controls.Add(ErrorListResults)
            Controls.Add(StatusLabel)
            Controls.Add(OutputListResults)
            Controls.Add(SoftwareVersionLabel)
            Controls.Add(SoftwareVersionTextBox)
            Controls.Add(ProcessButton)
            Controls.Add(ClearButton)
            DoubleBuffered = True
            Font = New Font("Tahoma", 8.25F)
            Margin = New Padding(0)
            Name = "BuildSoftware"
            Size = New Size(759, 891)
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Private WithEvents MainBackgroundWorker As System.ComponentModel.BackgroundWorker
        Private WithEvents ClearButton As Button
        Private WithEvents ProcessButton As Button
        Private WithEvents SoftwareVersionLabel As Label
        Private WithEvents OutputListResults As PoesShared.UserControls.ListResults
        Private WithEvents SoftwareVersionTextBox As TextBox
        Private WithEvents StatusLabel As Label
        Private WithEvents ErrorListResults As PoesShared.UserControls.ListResults
        Private WithEvents OutputLabel As Label
        Private WithEvents ErrorsLabel As Label
    End Class

End Namespace