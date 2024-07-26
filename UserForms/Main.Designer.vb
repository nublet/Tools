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
            components = New ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
            ControlsPanel = New Panel()
            ButtonsPanel = New Panel()
            MainNotifyIcon = New NotifyIcon(components)
            MainContextMenuStrip = New ContextMenuStrip(components)
            SolutionsToolStripMenuItem = New ToolStripMenuItem()
            ExitToolStripMenuItem = New ToolStripMenuItem()
            MainContextMenuStrip.SuspendLayout()
            SuspendLayout()
            ' 
            ' ControlsPanel
            ' 
            ControlsPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            ControlsPanel.Location = New Point(214, 9)
            ControlsPanel.Margin = New Padding(0)
            ControlsPanel.Name = "ControlsPanel"
            ControlsPanel.Size = New Size(577, 432)
            ControlsPanel.TabIndex = 0
            ' 
            ' ButtonsPanel
            ' 
            ButtonsPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
            ButtonsPanel.AutoScroll = True
            ButtonsPanel.Location = New Point(9, 9)
            ButtonsPanel.Margin = New Padding(0, 0, 5, 0)
            ButtonsPanel.Name = "ButtonsPanel"
            ButtonsPanel.Size = New Size(200, 432)
            ButtonsPanel.TabIndex = 1
            ' 
            ' MainNotifyIcon
            ' 
            MainNotifyIcon.ContextMenuStrip = MainContextMenuStrip
            MainNotifyIcon.Icon = CType(resources.GetObject("MainNotifyIcon.Icon"), Icon)
            MainNotifyIcon.Visible = True
            ' 
            ' MainContextMenuStrip
            ' 
            MainContextMenuStrip.Items.AddRange(New ToolStripItem() {SolutionsToolStripMenuItem, ExitToolStripMenuItem})
            MainContextMenuStrip.Name = "MainContextMenuStrip"
            MainContextMenuStrip.Size = New Size(124, 48)
            ' 
            ' SolutionsToolStripMenuItem
            ' 
            SolutionsToolStripMenuItem.Name = "SolutionsToolStripMenuItem"
            SolutionsToolStripMenuItem.Size = New Size(123, 22)
            SolutionsToolStripMenuItem.Text = "Solutions"
            ' 
            ' ExitToolStripMenuItem
            ' 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
            ExitToolStripMenuItem.Size = New Size(123, 22)
            ExitToolStripMenuItem.Text = "Exit"
            ' 
            ' Main
            ' 
            AutoScaleMode = AutoScaleMode.None
            BackColor = Color.FromArgb(CByte(24), CByte(28), CByte(63))
            ClientSize = New Size(800, 450)
            Controls.Add(ButtonsPanel)
            Controls.Add(ControlsPanel)
            DoubleBuffered = True
            Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Name = "Main"
            Text = "Main"
            MainContextMenuStrip.ResumeLayout(False)
            ResumeLayout(False)

        End Sub

        Private WithEvents ControlsPanel As Panel
        Private WithEvents ButtonsPanel As Panel
        Private WithEvents MainNotifyIcon As NotifyIcon
        Private WithEvents MainContextMenuStrip As ContextMenuStrip
        Private WithEvents SolutionsToolStripMenuItem As ToolStripMenuItem
        Private WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    End Class

End Namespace