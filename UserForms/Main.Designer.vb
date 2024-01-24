Namespace UserForms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Main
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
            Me.ControlsPanel = New System.Windows.Forms.Panel()
            Me.ButtonsPanel = New System.Windows.Forms.Panel()
            Me.MainNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
            Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.SolutionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MainContextMenuStrip.SuspendLayout()
            Me.SuspendLayout()
            '
            'ControlsPanel
            '
            Me.ControlsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ControlsPanel.Location = New System.Drawing.Point(174, 14)
            Me.ControlsPanel.Margin = New System.Windows.Forms.Padding(5)
            Me.ControlsPanel.Name = "ControlsPanel"
            Me.ControlsPanel.Size = New System.Drawing.Size(612, 422)
            Me.ControlsPanel.TabIndex = 0
            '
            'ButtonsPanel
            '
            Me.ButtonsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.ButtonsPanel.AutoScroll = True
            Me.ButtonsPanel.Location = New System.Drawing.Point(14, 14)
            Me.ButtonsPanel.Margin = New System.Windows.Forms.Padding(5)
            Me.ButtonsPanel.Name = "ButtonsPanel"
            Me.ButtonsPanel.Size = New System.Drawing.Size(150, 422)
            Me.ButtonsPanel.TabIndex = 1
            '
            'MainNotifyIcon
            '
            Me.MainNotifyIcon.ContextMenuStrip = Me.MainContextMenuStrip
            Me.MainNotifyIcon.Icon = CType(resources.GetObject("MainNotifyIcon.Icon"), System.Drawing.Icon)
            Me.MainNotifyIcon.Visible = True
            '
            'MainContextMenuStrip
            '
            Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolutionsToolStripMenuItem, Me.ExitToolStripMenuItem})
            Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
            Me.MainContextMenuStrip.Size = New System.Drawing.Size(124, 48)
            '
            'SolutionsToolStripMenuItem
            '
            Me.SolutionsToolStripMenuItem.Name = "SolutionsToolStripMenuItem"
            Me.SolutionsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
            Me.SolutionsToolStripMenuItem.Text = "Solutions"
            '
            'ExitToolStripMenuItem
            '
            Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
            Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
            Me.ExitToolStripMenuItem.Text = "Exit"
            '
            'Main
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.ButtonsPanel)
            Me.Controls.Add(Me.ControlsPanel)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "Main"
            Me.Text = "Main"
            Me.MainContextMenuStrip.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents ControlsPanel As Panel
        Private WithEvents ButtonsPanel As Panel
        Private WithEvents MainNotifyIcon As NotifyIcon
        Private WithEvents MainContextMenuStrip As ContextMenuStrip
        Private WithEvents SolutionsToolStripMenuItem As ToolStripMenuItem
        Private WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    End Class

End Namespace