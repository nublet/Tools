Namespace Tools.UserControls.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class WoWThingUpload
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
            Me.StatusLabel = New System.Windows.Forms.Label()
            Me.MainListResults = New CommonRoutines.Controls.ListResults()
            Me.SuspendLayout()
            '
            'StatusLabel
            '
            Me.StatusLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.StatusLabel.Cursor = System.Windows.Forms.Cursors.Default
            Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.StatusLabel.Location = New System.Drawing.Point(5, 5)
            Me.StatusLabel.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.StatusLabel.Name = "StatusLabel"
            Me.StatusLabel.Size = New System.Drawing.Size(749, 28)
            Me.StatusLabel.TabIndex = 44
            Me.StatusLabel.Text = "Status"
            Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'MainListResults
            '
            Me.MainListResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MainListResults.BackColor = System.Drawing.SystemColors.Window
            Me.MainListResults.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.MainListResults.BorderFocusColor = System.Drawing.Color.HotPink
            Me.MainListResults.BorderRadius = 0
            Me.MainListResults.BorderSize = 2
            Me.MainListResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MainListResults.ForeColor = System.Drawing.Color.DimGray
            Me.MainListResults.Indent = 0
            Me.MainListResults.Location = New System.Drawing.Point(8, 38)
            Me.MainListResults.Margin = New System.Windows.Forms.Padding(0, 0, 5, 5)
            Me.MainListResults.Name = "MainListResults"
            Me.MainListResults.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.MainListResults.Size = New System.Drawing.Size(746, 848)
            Me.MainListResults.TabIndex = 45
            Me.MainListResults.UnderlinedStyle = False
            '
            'WoWThingUpload
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.Controls.Add(Me.MainListResults)
            Me.Controls.Add(Me.StatusLabel)
            Me.DoubleBuffered = True
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "WoWThingUpload"
            Me.Size = New System.Drawing.Size(759, 891)
            Me.ResumeLayout(False)

        End Sub
        Private StatusLabel As Label
        Private WithEvents MainListResults As CommonRoutines.Controls.ListResults
    End Class

End Namespace