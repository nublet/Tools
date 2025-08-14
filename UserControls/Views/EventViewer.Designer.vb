Namespace UserControls.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class EventViewer
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
            RefreshButton = New Button()
            MainListResults = New PoesShared.UserControls.ListResults()
            WipeButton = New Button()
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
            ' RefreshButton
            ' 
            RefreshButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            RefreshButton.BackColor = Color.MediumSlateBlue
            RefreshButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            RefreshButton.FlatStyle = FlatStyle.Flat
            RefreshButton.Font = New Font("Tahoma", 8.25F)
            RefreshButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            RefreshButton.Location = New Point(5, 863)
            RefreshButton.Margin = New Padding(5, 0, 5, 5)
            RefreshButton.Name = "RefreshButton"
            RefreshButton.Size = New Size(80, 23)
            RefreshButton.TabIndex = 5
            RefreshButton.Text = "Refresh"
            RefreshButton.UseVisualStyleBackColor = True
            ' 
            ' MainListResults
            ' 
            MainListResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            MainListResults.BackColor = SystemColors.Window
            MainListResults.BorderColor = Color.MediumSlateBlue
            MainListResults.BorderSize = New Padding(2)
            MainListResults.Font = New Font("Tahoma", 8.25F)
            MainListResults.Indent = 0
            MainListResults.Location = New Point(5, 5)
            MainListResults.Margin = New Padding(5)
            MainListResults.Name = "MainListResults"
            MainListResults.Padding = New Padding(2)
            MainListResults.Size = New Size(749, 853)
            MainListResults.TabIndex = 4
            ' 
            ' WipeButton
            ' 
            WipeButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            WipeButton.BackColor = Color.MediumSlateBlue
            WipeButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            WipeButton.FlatStyle = FlatStyle.Flat
            WipeButton.Font = New Font("Tahoma", 8.25F)
            WipeButton.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            WipeButton.Location = New Point(90, 863)
            WipeButton.Margin = New Padding(0, 0, 5, 5)
            WipeButton.Name = "WipeButton"
            WipeButton.Size = New Size(80, 23)
            WipeButton.TabIndex = 9
            WipeButton.Text = "Wipe"
            WipeButton.UseVisualStyleBackColor = True
            ' 
            ' EventViewer
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(WipeButton)
            Controls.Add(MainListResults)
            Controls.Add(RefreshButton)
            Controls.Add(ClearButton)
            DoubleBuffered = True
            Font = New Font("Tahoma", 8.25F)
            Margin = New Padding(0)
            Name = "EventViewer"
            Size = New Size(759, 891)
            ResumeLayout(False)

        End Sub
        Private WithEvents MainBackgroundWorker As System.ComponentModel.BackgroundWorker
        Private WithEvents ClearButton As Button
        Private WithEvents RefreshButton As Button
        Private WithEvents MainListResults As PoesShared.UserControls.ListResults
        Private WithEvents WipeButton As Button
    End Class

End Namespace