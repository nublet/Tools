Namespace Tools.UserControls.Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ModelGenerator
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
            Me.GeneratorLabel = New System.Windows.Forms.Label()
            Me.OutputDirectoryLabel = New System.Windows.Forms.Label()
            Me.NamespaceLabel = New System.Windows.Forms.Label()
            Me.MainPanel = New System.Windows.Forms.Panel()
            Me.OpenOutputButton = New CommonRoutines.Controls.Button()
            Me.GenerateButton = New CommonRoutines.Controls.Button()
            Me.MainListResults = New CommonRoutines.Controls.ListResults()
            Me.GeneratorComboBox = New CommonRoutines.Controls.ComboBox()
            Me.OutputDirectoryButton = New CommonRoutines.Controls.Button()
            Me.OutputDirectoryTextBox = New CommonRoutines.Controls.TextBox()
            Me.NamespaceTextBox = New CommonRoutines.Controls.TextBox()
            Me.SuspendLayout()
            '
            'GeneratorLabel
            '
            Me.GeneratorLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GeneratorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.GeneratorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.GeneratorLabel.Location = New System.Drawing.Point(5, 5)
            Me.GeneratorLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.GeneratorLabel.Name = "GeneratorLabel"
            Me.GeneratorLabel.Size = New System.Drawing.Size(125, 33)
            Me.GeneratorLabel.TabIndex = 27
            Me.GeneratorLabel.Text = "Generator"
            Me.GeneratorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'OutputDirectoryLabel
            '
            Me.OutputDirectoryLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.OutputDirectoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.OutputDirectoryLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.OutputDirectoryLabel.Location = New System.Drawing.Point(5, 48)
            Me.OutputDirectoryLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.OutputDirectoryLabel.Name = "OutputDirectoryLabel"
            Me.OutputDirectoryLabel.Size = New System.Drawing.Size(125, 33)
            Me.OutputDirectoryLabel.TabIndex = 26
            Me.OutputDirectoryLabel.Text = "Output Directory"
            Me.OutputDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'NamespaceLabel
            '
            Me.NamespaceLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NamespaceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.NamespaceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.NamespaceLabel.Location = New System.Drawing.Point(5, 91)
            Me.NamespaceLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.NamespaceLabel.Name = "NamespaceLabel"
            Me.NamespaceLabel.Size = New System.Drawing.Size(125, 33)
            Me.NamespaceLabel.TabIndex = 25
            Me.NamespaceLabel.Text = "Namespace"
            Me.NamespaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MainPanel
            '
            Me.MainPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MainPanel.Location = New System.Drawing.Point(5, 134)
            Me.MainPanel.Margin = New System.Windows.Forms.Padding(5)
            Me.MainPanel.Name = "MainPanel"
            Me.MainPanel.Size = New System.Drawing.Size(682, 220)
            Me.MainPanel.TabIndex = 35
            '
            'OpenOutputButton
            '
            Me.OpenOutputButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.OpenOutputButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.OpenOutputButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.OpenOutputButton.BorderRadius = 0
            Me.OpenOutputButton.BorderSize = 1
            Me.OpenOutputButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OpenOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.OpenOutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.OpenOutputButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.OpenOutputButton.Location = New System.Drawing.Point(5, 531)
            Me.OpenOutputButton.Margin = New System.Windows.Forms.Padding(5)
            Me.OpenOutputButton.Name = "OpenOutputButton"
            Me.OpenOutputButton.Size = New System.Drawing.Size(110, 30)
            Me.OpenOutputButton.TabIndex = 38
            Me.OpenOutputButton.Text = "Open Output"
            Me.OpenOutputButton.UseVisualStyleBackColor = True
            '
            'GenerateButton
            '
            Me.GenerateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GenerateButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.GenerateButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.GenerateButton.BorderRadius = 0
            Me.GenerateButton.BorderSize = 1
            Me.GenerateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.GenerateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.GenerateButton.Location = New System.Drawing.Point(607, 531)
            Me.GenerateButton.Margin = New System.Windows.Forms.Padding(5)
            Me.GenerateButton.Name = "GenerateButton"
            Me.GenerateButton.Size = New System.Drawing.Size(80, 30)
            Me.GenerateButton.TabIndex = 37
            Me.GenerateButton.Text = "Generate"
            Me.GenerateButton.UseVisualStyleBackColor = True
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
            Me.MainListResults.BorderSize = 1
            Me.MainListResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MainListResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MainListResults.ForeColor = System.Drawing.Color.DimGray
            Me.MainListResults.Indent = 0
            Me.MainListResults.Location = New System.Drawing.Point(5, 364)
            Me.MainListResults.Margin = New System.Windows.Forms.Padding(5)
            Me.MainListResults.Name = "MainListResults"
            Me.MainListResults.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.MainListResults.Size = New System.Drawing.Size(682, 157)
            Me.MainListResults.TabIndex = 36
            Me.MainListResults.UnderlinedStyle = False
            '
            'GeneratorComboBox
            '
            Me.GeneratorComboBox.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.GeneratorComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.GeneratorComboBox.BorderSize = 1
            Me.GeneratorComboBox.DataSource = Nothing
            Me.GeneratorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.GeneratorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GeneratorComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.GeneratorComboBox.FormattingEnabled = True
            Me.GeneratorComboBox.IconColor = System.Drawing.Color.Crimson
            Me.GeneratorComboBox.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.GeneratorComboBox.ListForeColor = System.Drawing.Color.DimGray
            Me.GeneratorComboBox.Location = New System.Drawing.Point(140, 5)
            Me.GeneratorComboBox.Margin = New System.Windows.Forms.Padding(5)
            Me.GeneratorComboBox.Name = "GeneratorComboBox"
            Me.GeneratorComboBox.Padding = New System.Windows.Forms.Padding(1)
            Me.GeneratorComboBox.Size = New System.Drawing.Size(200, 33)
            Me.GeneratorComboBox.TabIndex = 32
            '
            'OutputDirectoryButton
            '
            Me.OutputDirectoryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.OutputDirectoryButton.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.OutputDirectoryButton.BorderColor = System.Drawing.Color.PaleVioletRed
            Me.OutputDirectoryButton.BorderRadius = 0
            Me.OutputDirectoryButton.BorderSize = 1
            Me.OutputDirectoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OutputDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.OutputDirectoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.OutputDirectoryButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.OutputDirectoryButton.Location = New System.Drawing.Point(654, 48)
            Me.OutputDirectoryButton.Margin = New System.Windows.Forms.Padding(5)
            Me.OutputDirectoryButton.Name = "OutputDirectoryButton"
            Me.OutputDirectoryButton.Size = New System.Drawing.Size(33, 33)
            Me.OutputDirectoryButton.TabIndex = 28
            Me.OutputDirectoryButton.Text = "..."
            Me.OutputDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.OutputDirectoryButton.UseVisualStyleBackColor = True
            '
            'OutputDirectoryTextBox
            '
            Me.OutputDirectoryTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.OutputDirectoryTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.OutputDirectoryTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.OutputDirectoryTextBox.BorderFocusColor = System.Drawing.Color.HotPink
            Me.OutputDirectoryTextBox.BorderRadius = 0
            Me.OutputDirectoryTextBox.BorderSize = 1
            Me.OutputDirectoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OutputDirectoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.OutputDirectoryTextBox.Location = New System.Drawing.Point(140, 48)
            Me.OutputDirectoryTextBox.Margin = New System.Windows.Forms.Padding(5)
            Me.OutputDirectoryTextBox.Multiline = False
            Me.OutputDirectoryTextBox.Name = "OutputDirectoryTextBox"
            Me.OutputDirectoryTextBox.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.OutputDirectoryTextBox.PasswordChar = False
            Me.OutputDirectoryTextBox.PlaceHolderColor = System.Drawing.Color.DarkGray
            Me.OutputDirectoryTextBox.PlaceHolderText = ""
            Me.OutputDirectoryTextBox.Size = New System.Drawing.Size(547, 33)
            Me.OutputDirectoryTextBox.TabIndex = 29
            Me.OutputDirectoryTextBox.UnderlinedStyle = False
            '
            'NamespaceTextBox
            '
            Me.NamespaceTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.NamespaceTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.NamespaceTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.NamespaceTextBox.BorderFocusColor = System.Drawing.Color.HotPink
            Me.NamespaceTextBox.BorderRadius = 0
            Me.NamespaceTextBox.BorderSize = 1
            Me.NamespaceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NamespaceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.NamespaceTextBox.Location = New System.Drawing.Point(140, 91)
            Me.NamespaceTextBox.Margin = New System.Windows.Forms.Padding(5)
            Me.NamespaceTextBox.Multiline = False
            Me.NamespaceTextBox.Name = "NamespaceTextBox"
            Me.NamespaceTextBox.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.NamespaceTextBox.PasswordChar = False
            Me.NamespaceTextBox.PlaceHolderColor = System.Drawing.Color.DarkGray
            Me.NamespaceTextBox.PlaceHolderText = ""
            Me.NamespaceTextBox.Size = New System.Drawing.Size(547, 33)
            Me.NamespaceTextBox.TabIndex = 30
            Me.NamespaceTextBox.UnderlinedStyle = False
            '
            'ModelGenerator
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.Controls.Add(Me.OpenOutputButton)
            Me.Controls.Add(Me.GenerateButton)
            Me.Controls.Add(Me.MainListResults)
            Me.Controls.Add(Me.MainPanel)
            Me.Controls.Add(Me.GeneratorComboBox)
            Me.Controls.Add(Me.OutputDirectoryButton)
            Me.Controls.Add(Me.OutputDirectoryTextBox)
            Me.Controls.Add(Me.NamespaceTextBox)
            Me.Controls.Add(Me.GeneratorLabel)
            Me.Controls.Add(Me.OutputDirectoryLabel)
            Me.Controls.Add(Me.NamespaceLabel)
            Me.DoubleBuffered = True
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "ModelGenerator"
            Me.Size = New System.Drawing.Size(692, 566)
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents OutputDirectoryButton As CommonRoutines.Controls.Button
        Private WithEvents GeneratorLabel As Label
        Private WithEvents OutputDirectoryLabel As Label
        Private WithEvents NamespaceLabel As Label
        Private WithEvents GeneratorComboBox As CommonRoutines.Controls.ComboBox
        Private WithEvents OutputDirectoryTextBox As CommonRoutines.Controls.TextBox
        Private WithEvents NamespaceTextBox As CommonRoutines.Controls.TextBox
        Private WithEvents MainPanel As Panel
        Private WithEvents MainListResults As CommonRoutines.Controls.ListResults
        Private WithEvents GenerateButton As CommonRoutines.Controls.Button
        Private WithEvents OpenOutputButton As CommonRoutines.Controls.Button
    End Class

End Namespace