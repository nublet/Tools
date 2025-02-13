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
            MainListResults = New PoesShared.UserControls.ListResults()
            StatusLabel = New Label()
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
            ClearButton.TabIndex = 3
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
            ProcessButton.TabIndex = 2
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
            ' MainListResults
            ' 
            MainListResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            MainListResults.BackColor = SystemColors.Window
            MainListResults.BorderColor = Color.MediumSlateBlue
            MainListResults.BorderSize = New Padding(2)
            MainListResults.Font = New Font("Tahoma", 8.25F)
            MainListResults.Indent = 0
            MainListResults.Location = New Point(5, 31)
            MainListResults.Margin = New Padding(5, 0, 5, 5)
            MainListResults.Name = "MainListResults"
            MainListResults.Padding = New Padding(2)
            MainListResults.Size = New Size(749, 827)
            MainListResults.TabIndex = 1
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
            ' BuildSoftware
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(StatusLabel)
            Controls.Add(MainListResults)
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
        Private WithEvents MainListResults As PoesShared.UserControls.ListResults
        Private WithEvents SoftwareVersionTextBox As TextBox
        Private WithEvents StatusLabel As Label
    End Class

End Namespace