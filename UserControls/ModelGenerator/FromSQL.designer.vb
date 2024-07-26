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
            Me.DatabaseLabel = New System.Windows.Forms.Label()
            Me.ServerComboBox = New Aprotec.UserControls.ComboBox()
            Me.ServerLabel = New System.Windows.Forms.Label()
            Me.DatabaseComboBox = New Aprotec.UserControls.ComboBox()
            Me.SuspendLayout()
            '
            'DatabaseLabel
            '
            Me.DatabaseLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.DatabaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.DatabaseLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.DatabaseLabel.Location = New System.Drawing.Point(5, 48)
            Me.DatabaseLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.DatabaseLabel.Name = "DatabaseLabel"
            Me.DatabaseLabel.Size = New System.Drawing.Size(100, 33)
            Me.DatabaseLabel.TabIndex = 20
            Me.DatabaseLabel.Text = "Database"
            Me.DatabaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ServerComboBox
            '
            Me.ServerComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ServerComboBox.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.ServerComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.ServerComboBox.BorderSize = 1
            Me.ServerComboBox.DataSource = Nothing
            Me.ServerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ServerComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ServerComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.ServerComboBox.FormattingEnabled = True
            Me.ServerComboBox.IconColor = System.Drawing.Color.Crimson
            Me.ServerComboBox.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.ServerComboBox.ListForeColor = System.Drawing.Color.DimGray
            Me.ServerComboBox.Location = New System.Drawing.Point(115, 5)
            Me.ServerComboBox.Margin = New System.Windows.Forms.Padding(5)
            Me.ServerComboBox.Name = "ServerComboBox"
            Me.ServerComboBox.Padding = New System.Windows.Forms.Padding(1)
            Me.ServerComboBox.Size = New System.Drawing.Size(580, 33)
            Me.ServerComboBox.TabIndex = 34
            '
            'ServerLabel
            '
            Me.ServerLabel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.ServerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
            Me.ServerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.ServerLabel.Location = New System.Drawing.Point(5, 5)
            Me.ServerLabel.Margin = New System.Windows.Forms.Padding(5)
            Me.ServerLabel.Name = "ServerLabel"
            Me.ServerLabel.Size = New System.Drawing.Size(100, 33)
            Me.ServerLabel.TabIndex = 36
            Me.ServerLabel.Text = "Server"
            Me.ServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'DatabaseComboBox
            '
            Me.DatabaseComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DatabaseComboBox.BackColor = System.Drawing.Color.MediumSlateBlue
            Me.DatabaseComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue
            Me.DatabaseComboBox.BorderSize = 1
            Me.DatabaseComboBox.DataSource = Nothing
            Me.DatabaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.DatabaseComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DatabaseComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.DatabaseComboBox.FormattingEnabled = True
            Me.DatabaseComboBox.IconColor = System.Drawing.Color.Crimson
            Me.DatabaseComboBox.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.DatabaseComboBox.ListForeColor = System.Drawing.Color.DimGray
            Me.DatabaseComboBox.Location = New System.Drawing.Point(115, 48)
            Me.DatabaseComboBox.Margin = New System.Windows.Forms.Padding(5)
            Me.DatabaseComboBox.Name = "DatabaseComboBox"
            Me.DatabaseComboBox.Padding = New System.Windows.Forms.Padding(1)
            Me.DatabaseComboBox.Size = New System.Drawing.Size(580, 33)
            Me.DatabaseComboBox.TabIndex = 39
            '
            'FromSQL
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(86, Byte), Integer))
            Me.Controls.Add(Me.DatabaseComboBox)
            Me.Controls.Add(Me.ServerLabel)
            Me.Controls.Add(Me.ServerComboBox)
            Me.Controls.Add(Me.DatabaseLabel)
            Me.Name = "FromSQL"
            Me.Size = New System.Drawing.Size(700, 220)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DatabaseLabel As Label
        Private WithEvents ServerComboBox As Aprotec.UserControls.ComboBox
        Private WithEvents ServerLabel As Label
        Private WithEvents DatabaseComboBox As Aprotec.UserControls.ComboBox
    End Class

End Namespace