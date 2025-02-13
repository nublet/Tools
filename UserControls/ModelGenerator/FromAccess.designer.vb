Namespace UserControls.ModelGenerator

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FromAccess
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
            PasswordLabel = New Label()
            UsernameLabel = New Label()
            DatabaseLabel = New Label()
            DatabaseButton = New Button()
            DatabaseTextBox = New TextBox()
            UsernameTextBox = New TextBox()
            PasswordTextBox = New TextBox()
            SuspendLayout()
            ' 
            ' PasswordLabel
            ' 
            PasswordLabel.Cursor = Cursors.Hand
            PasswordLabel.Font = New Font("Tahoma", 8.25F)
            PasswordLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            PasswordLabel.Location = New Point(5, 57)
            PasswordLabel.Margin = New Padding(5, 0, 5, 5)
            PasswordLabel.Name = "PasswordLabel"
            PasswordLabel.Size = New Size(80, 21)
            PasswordLabel.TabIndex = 18
            PasswordLabel.Text = "Password"
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' UsernameLabel
            ' 
            UsernameLabel.Cursor = Cursors.Hand
            UsernameLabel.Font = New Font("Tahoma", 8.25F)
            UsernameLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            UsernameLabel.Location = New Point(5, 31)
            UsernameLabel.Margin = New Padding(5, 0, 5, 5)
            UsernameLabel.Name = "UsernameLabel"
            UsernameLabel.Size = New Size(80, 21)
            UsernameLabel.TabIndex = 19
            UsernameLabel.Text = "Username"
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' DatabaseLabel
            ' 
            DatabaseLabel.Cursor = Cursors.Hand
            DatabaseLabel.Font = New Font("Tahoma", 8.25F)
            DatabaseLabel.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            DatabaseLabel.Location = New Point(5, 5)
            DatabaseLabel.Margin = New Padding(5)
            DatabaseLabel.Name = "DatabaseLabel"
            DatabaseLabel.Size = New Size(80, 21)
            DatabaseLabel.TabIndex = 20
            DatabaseLabel.Text = "Database"
            DatabaseLabel.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' DatabaseButton
            ' 
            DatabaseButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            DatabaseButton.BackColor = Color.MediumSlateBlue
            DatabaseButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(83), CByte(255))
            DatabaseButton.FlatStyle = FlatStyle.Flat
            DatabaseButton.Font = New Font("Tahoma", 8.25F)
            DatabaseButton.ForeColor = Color.Red
            DatabaseButton.Location = New Point(663, 5)
            DatabaseButton.Margin = New Padding(0, 5, 5, 5)
            DatabaseButton.Name = "DatabaseButton"
            DatabaseButton.Size = New Size(30, 21)
            DatabaseButton.TabIndex = 1
            DatabaseButton.Text = "..."
            DatabaseButton.UseVisualStyleBackColor = True
            ' 
            ' DatabaseTextBox
            ' 
            DatabaseTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            DatabaseTextBox.BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            DatabaseTextBox.Font = New Font("Tahoma", 8.25F)
            DatabaseTextBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            DatabaseTextBox.Location = New Point(90, 5)
            DatabaseTextBox.Margin = New Padding(0, 5, 5, 5)
            DatabaseTextBox.Name = "DatabaseTextBox"
            DatabaseTextBox.Size = New Size(568, 21)
            DatabaseTextBox.TabIndex = 0
            ' 
            ' UsernameTextBox
            ' 
            UsernameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            UsernameTextBox.BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            UsernameTextBox.Font = New Font("Tahoma", 8.25F)
            UsernameTextBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            UsernameTextBox.Location = New Point(90, 31)
            UsernameTextBox.Margin = New Padding(0, 0, 5, 5)
            UsernameTextBox.Name = "UsernameTextBox"
            UsernameTextBox.Size = New Size(568, 21)
            UsernameTextBox.TabIndex = 2
            ' 
            ' PasswordTextBox
            ' 
            PasswordTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            PasswordTextBox.BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            PasswordTextBox.Font = New Font("Tahoma", 8.25F)
            PasswordTextBox.ForeColor = Color.FromArgb(CByte(124), CByte(141), CByte(181))
            PasswordTextBox.Location = New Point(90, 57)
            PasswordTextBox.Margin = New Padding(0, 0, 5, 5)
            PasswordTextBox.Name = "PasswordTextBox"
            PasswordTextBox.Size = New Size(568, 21)
            PasswordTextBox.TabIndex = 3
            ' 
            ' FromAccess
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(86))
            Controls.Add(DatabaseButton)
            Controls.Add(DatabaseTextBox)
            Controls.Add(PasswordTextBox)
            Controls.Add(UsernameTextBox)
            Controls.Add(DatabaseLabel)
            Controls.Add(UsernameLabel)
            Controls.Add(PasswordLabel)
            Font = New Font("Tahoma", 8.25F)
            Name = "FromAccess"
            Size = New Size(698, 111)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Private WithEvents PasswordLabel As Label
        Private WithEvents UsernameLabel As Label
        Private WithEvents DatabaseLabel As Label
        Private WithEvents DatabaseButton As Button
        Private WithEvents DatabaseTextBox As TextBox
        Private WithEvents UsernameTextBox As TextBox
        Private WithEvents PasswordTextBox As TextBox
    End Class

End Namespace