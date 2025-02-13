Namespace UserControls.ModelGenerator

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FromSQL
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
            DatabaseLabel = New Label()
            ServerComboBox = New ComboBox()
            ServerLabel = New Label()
            DatabaseComboBox = New ComboBox()
            SuspendLayout()
            ' 
            ' DatabaseLabel
            ' 
            DatabaseLabel.Cursor = Cursors.Hand
            DatabaseLabel.Font = New Font("Tahoma", 8.25F)
            DatabaseLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            DatabaseLabel.Location = New Point(5, 31)
            DatabaseLabel.Margin = New Padding(5, 0, 5, 5)
            DatabaseLabel.Name = "DatabaseLabel"
            DatabaseLabel.Size = New Size(80, 21)
            DatabaseLabel.TabIndex = 20
            DatabaseLabel.Text = "Database"
            DatabaseLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' ServerComboBox
            ' 
            ServerComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            ServerComboBox.BackColor = Color.MediumSlateBlue
            ServerComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            ServerComboBox.Font = New Font("Tahoma", 8.25F)
            ServerComboBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ServerComboBox.FormattingEnabled = True
            ServerComboBox.Location = New Point(90, 5)
            ServerComboBox.Margin = New Padding(0, 5, 5, 5)
            ServerComboBox.Name = "ServerComboBox"
            ServerComboBox.Size = New Size(605, 21)
            ServerComboBox.TabIndex = 0
            ' 
            ' ServerLabel
            ' 
            ServerLabel.Cursor = Cursors.Hand
            ServerLabel.Font = New Font("Tahoma", 8.25F)
            ServerLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            ServerLabel.Location = New Point(5, 5)
            ServerLabel.Margin = New Padding(5)
            ServerLabel.Name = "ServerLabel"
            ServerLabel.Size = New Size(80, 21)
            ServerLabel.TabIndex = 36
            ServerLabel.Text = "Server"
            ServerLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' DatabaseComboBox
            ' 
            DatabaseComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            DatabaseComboBox.BackColor = Color.MediumSlateBlue
            DatabaseComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            DatabaseComboBox.Font = New Font("Tahoma", 8.25F)
            DatabaseComboBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            DatabaseComboBox.FormattingEnabled = True
            DatabaseComboBox.Location = New Point(90, 31)
            DatabaseComboBox.Margin = New Padding(0, 0, 5, 5)
            DatabaseComboBox.Name = "DatabaseComboBox"
            DatabaseComboBox.Size = New Size(605, 21)
            DatabaseComboBox.TabIndex = 1
            ' 
            ' FromSQL
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(DatabaseComboBox)
            Controls.Add(ServerLabel)
            Controls.Add(ServerComboBox)
            Controls.Add(DatabaseLabel)
            Font = New Font("Tahoma", 8.25F)
            Name = "FromSQL"
            Size = New Size(700, 220)
            ResumeLayout(False)

        End Sub
        Private WithEvents DatabaseLabel As Label
        Private WithEvents ServerComboBox As ComboBox
        Private WithEvents ServerLabel As Label
        Private WithEvents DatabaseComboBox As ComboBox
    End Class

End Namespace