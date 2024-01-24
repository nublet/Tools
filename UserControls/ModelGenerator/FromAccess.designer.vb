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
            Me.PasswordLabel = New System.Windows.Forms.Label()
            Me.UsernameLabel = New System.Windows.Forms.Label()
            Me.DatabaseLabel = New System.Windows.Forms.Label()
            Me.DatabaseButton = New CommonRoutines.UserControls.Button()
            Me.DatabaseTextBox = New CommonRoutines.UserControls.TextBox()
            Me.UsernameTextBox = New CommonRoutines.UserControls.TextBox()
            Me.PasswordTextBox = New CommonRoutines.UserControls.TextBox()
            Me.SuspendLayout()
            '
            'PasswordLabel
            '
            Me.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.PasswordLabel.Location = New System.Drawing.Point(5, 91)
            Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.PasswordLabel.Name = "PasswordLabel"
            Me.PasswordLabel.Size = New System.Drawing.Size(100, 33)
            Me.PasswordLabel.TabIndex = 18
            Me.PasswordLabel.Text = "Password"
            Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'UsernameLabel
            '
            Me.UsernameLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.UsernameLabel.Location = New System.Drawing.Point(5, 48)
            Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.UsernameLabel.Name = "UsernameLabel"
            Me.UsernameLabel.Size = New System.Drawing.Size(100, 33)
            Me.UsernameLabel.TabIndex = 19
            Me.UsernameLabel.Text = "Username"
            Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'DatabaseLabel
            '
            Me.DatabaseLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.DatabaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.DatabaseLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.DatabaseLabel.Location = New System.Drawing.Point(5, 5)
            Me.DatabaseLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.DatabaseLabel.Name = "DatabaseLabel"
            Me.DatabaseLabel.Size = New System.Drawing.Size(100, 33)
            Me.DatabaseLabel.TabIndex = 20
            Me.DatabaseLabel.Text = "Database"
            Me.DatabaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'DatabaseButton
            '
            Me.DatabaseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DatabaseButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.DatabaseButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.DatabaseButton.BorderRadius = 0
            Me.DatabaseButton.BorderSize = 1
            Me.DatabaseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.DatabaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.DatabaseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.DatabaseButton.Location = New System.Drawing.Point(665, 5)
            Me.DatabaseButton.Margin = New System.Windows.Forms.Padding(5)
            Me.DatabaseButton.Name = "DatabaseButton"
            Me.DatabaseButton.Size = New System.Drawing.Size(33, 33)
            Me.DatabaseButton.TabIndex = 21
            Me.DatabaseButton.Text = "..."
            Me.DatabaseButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.DatabaseButton.UseVisualStyleBackColor = True
            '
            'DatabaseTextBox
            '
            Me.DatabaseTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DatabaseTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.DatabaseTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.DatabaseTextBox.BorderFocusColor = System.Drawing.Color.HotPink
            Me.DatabaseTextBox.BorderRadius = 0
            Me.DatabaseTextBox.BorderSize = 1
            Me.DatabaseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DatabaseTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.DatabaseTextBox.Location = New System.Drawing.Point(115, 5)
            Me.DatabaseTextBox.Margin = New System.Windows.Forms.Padding(5)
            Me.DatabaseTextBox.Multiline = False
            Me.DatabaseTextBox.Name = "DatabaseTextBox"
            Me.DatabaseTextBox.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.DatabaseTextBox.PasswordChar = False
            Me.DatabaseTextBox.PlaceHolderColor = System.Drawing.Color.DarkGray
            Me.DatabaseTextBox.PlaceHolderText = ""
            Me.DatabaseTextBox.Size = New System.Drawing.Size(583, 33)
            Me.DatabaseTextBox.TabIndex = 22
            Me.DatabaseTextBox.UnderlinedStyle = False
            '
            'UsernameTextBox
            '
            Me.UsernameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.UsernameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.UsernameTextBox.BorderFocusColor = System.Drawing.Color.HotPink
            Me.UsernameTextBox.BorderRadius = 0
            Me.UsernameTextBox.BorderSize = 1
            Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.UsernameTextBox.Location = New System.Drawing.Point(115, 48)
            Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(5)
            Me.UsernameTextBox.Multiline = False
            Me.UsernameTextBox.Name = "UsernameTextBox"
            Me.UsernameTextBox.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.UsernameTextBox.PasswordChar = False
            Me.UsernameTextBox.PlaceHolderColor = System.Drawing.Color.DarkGray
            Me.UsernameTextBox.PlaceHolderText = ""
            Me.UsernameTextBox.Size = New System.Drawing.Size(583, 33)
            Me.UsernameTextBox.TabIndex = 23
            Me.UsernameTextBox.UnderlinedStyle = False
            '
            'PasswordTextBox
            '
            Me.PasswordTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.PasswordTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.PasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink
            Me.PasswordTextBox.BorderRadius = 0
            Me.PasswordTextBox.BorderSize = 1
            Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.PasswordTextBox.Location = New System.Drawing.Point(115, 91)
            Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(5)
            Me.PasswordTextBox.Multiline = False
            Me.PasswordTextBox.Name = "PasswordTextBox"
            Me.PasswordTextBox.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.PasswordTextBox.PasswordChar = False
            Me.PasswordTextBox.PlaceHolderColor = System.Drawing.Color.DarkGray
            Me.PasswordTextBox.PlaceHolderText = ""
            Me.PasswordTextBox.Size = New System.Drawing.Size(583, 33)
            Me.PasswordTextBox.TabIndex = 24
            Me.PasswordTextBox.UnderlinedStyle = False
            '
            'FromAccess
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.Controls.Add(Me.DatabaseButton)
            Me.Controls.Add(Me.DatabaseTextBox)
            Me.Controls.Add(Me.PasswordTextBox)
            Me.Controls.Add(Me.UsernameTextBox)
            Me.Controls.Add(Me.DatabaseLabel)
            Me.Controls.Add(Me.UsernameLabel)
            Me.Controls.Add(Me.PasswordLabel)
            Me.Name = "FromAccess"
            Me.Size = New System.Drawing.Size(703, 135)
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents PasswordLabel As Label
        Private WithEvents UsernameLabel As Label
        Private WithEvents DatabaseLabel As Label
        Private WithEvents DatabaseButton As CommonRoutines.UserControls.Button
        Friend WithEvents DatabaseTextBox As CommonRoutines.UserControls.TextBox
        Friend WithEvents UsernameTextBox As CommonRoutines.UserControls.TextBox
        Friend WithEvents PasswordTextBox As CommonRoutines.UserControls.TextBox
    End Class

End Namespace