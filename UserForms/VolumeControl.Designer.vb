Namespace UserForms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class VolumeControl
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            SetMuteButton = New Button()
            Set10Button = New Button()
            Set20Button = New Button()
            CurrentVolumeLabel = New Label()
            Set30Button = New Button()
            Set40Button = New Button()
            SuspendLayout()
            ' 
            ' SetMuteButton
            ' 
            SetMuteButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            SetMuteButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
            SetMuteButton.FlatStyle = FlatStyle.Flat
            SetMuteButton.Image = My.Resources.Resources.Mute
            SetMuteButton.Location = New Point(120, 0)
            SetMuteButton.Margin = New Padding(0)
            SetMuteButton.Name = "SetMuteButton"
            SetMuteButton.Size = New Size(30, 30)
            SetMuteButton.TabIndex = 7
            SetMuteButton.UseVisualStyleBackColor = False
            ' 
            ' Set10Button
            ' 
            Set10Button.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
            Set10Button.FlatStyle = FlatStyle.Flat
            Set10Button.Location = New Point(0, 0)
            Set10Button.Margin = New Padding(0)
            Set10Button.Name = "Set10Button"
            Set10Button.Size = New Size(30, 30)
            Set10Button.TabIndex = 8
            Set10Button.Text = "10"
            Set10Button.UseVisualStyleBackColor = False
            ' 
            ' Set20Button
            ' 
            Set20Button.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
            Set20Button.FlatStyle = FlatStyle.Flat
            Set20Button.Location = New Point(30, 0)
            Set20Button.Margin = New Padding(0)
            Set20Button.Name = "Set20Button"
            Set20Button.Size = New Size(30, 30)
            Set20Button.TabIndex = 9
            Set20Button.Text = "20"
            Set20Button.UseVisualStyleBackColor = False
            ' 
            ' CurrentVolumeLabel
            ' 
            CurrentVolumeLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            CurrentVolumeLabel.ForeColor = Color.WhiteSmoke
            CurrentVolumeLabel.Location = New Point(150, 0)
            CurrentVolumeLabel.Margin = New Padding(0)
            CurrentVolumeLabel.Name = "CurrentVolumeLabel"
            CurrentVolumeLabel.Size = New Size(35, 30)
            CurrentVolumeLabel.TabIndex = 10
            CurrentVolumeLabel.Text = "100%"
            CurrentVolumeLabel.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' Set30Button
            ' 
            Set30Button.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
            Set30Button.FlatStyle = FlatStyle.Flat
            Set30Button.Location = New Point(60, 0)
            Set30Button.Margin = New Padding(0)
            Set30Button.Name = "Set30Button"
            Set30Button.Size = New Size(30, 30)
            Set30Button.TabIndex = 11
            Set30Button.Text = "30"
            Set30Button.UseVisualStyleBackColor = False
            ' 
            ' Set40Button
            ' 
            Set40Button.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
            Set40Button.FlatStyle = FlatStyle.Flat
            Set40Button.Location = New Point(90, 0)
            Set40Button.Margin = New Padding(0)
            Set40Button.Name = "Set40Button"
            Set40Button.Size = New Size(30, 30)
            Set40Button.TabIndex = 12
            Set40Button.Text = "40"
            Set40Button.UseVisualStyleBackColor = False
            ' 
            ' VolumeControl
            ' 
            AutoScaleDimensions = New SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(24), CByte(28), CByte(63))
            ClientSize = New Size(185, 30)
            Controls.Add(Set40Button)
            Controls.Add(Set30Button)
            Controls.Add(CurrentVolumeLabel)
            Controls.Add(Set20Button)
            Controls.Add(Set10Button)
            Controls.Add(SetMuteButton)
            DoubleBuffered = True
            Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            FormBorderStyle = FormBorderStyle.None
            MaximumSize = New Size(185, 30)
            MinimumSize = New Size(185, 30)
            Name = "VolumeControl"
            ShowInTaskbar = False
            ResumeLayout(False)

        End Sub
        Private WithEvents SetMuteButton As Button
        Private WithEvents Set10Button As Button
        Private WithEvents Set20Button As Button
        Private WithEvents CurrentVolumeLabel As Label
        Private WithEvents Set30Button As Button
        Private WithEvents Set40Button As Button
    End Class

End Namespace