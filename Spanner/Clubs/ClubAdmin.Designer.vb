<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubAdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ClubNameLabel = New System.Windows.Forms.Label()
        Me.ClubAbbreviationLabel = New System.Windows.Forms.Label()
        Me.URLLabel = New System.Windows.Forms.Label()
        Me.ClubActionsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'ClubNameLabel
        '
        Me.ClubNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClubNameLabel.AutoSize = True
        Me.ClubNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClubNameLabel.Location = New System.Drawing.Point(12, 9)
        Me.ClubNameLabel.Name = "ClubNameLabel"
        Me.ClubNameLabel.Size = New System.Drawing.Size(110, 25)
        Me.ClubNameLabel.TabIndex = 6
        Me.ClubNameLabel.Text = "Club Name"
        '
        'ClubAbbreviationLabel
        '
        Me.ClubAbbreviationLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClubAbbreviationLabel.AutoSize = True
        Me.ClubAbbreviationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClubAbbreviationLabel.Location = New System.Drawing.Point(14, 34)
        Me.ClubAbbreviationLabel.Name = "ClubAbbreviationLabel"
        Me.ClubAbbreviationLabel.Size = New System.Drawing.Size(27, 17)
        Me.ClubAbbreviationLabel.TabIndex = 7
        Me.ClubAbbreviationLabel.Text = "CN"
        '
        'URLLabel
        '
        Me.URLLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URLLabel.AutoSize = True
        Me.URLLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLLabel.Location = New System.Drawing.Point(101, 34)
        Me.URLLabel.Name = "URLLabel"
        Me.URLLabel.Size = New System.Drawing.Size(96, 17)
        Me.URLLabel.TabIndex = 8
        Me.URLLabel.Text = "https://cn.com"
        '
        'ClubActionsFlowLayoutPanel
        '
        Me.ClubActionsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ClubActionsFlowLayoutPanel.Location = New System.Drawing.Point(12, 64)
        Me.ClubActionsFlowLayoutPanel.Name = "ClubActionsFlowLayoutPanel"
        Me.ClubActionsFlowLayoutPanel.Size = New System.Drawing.Size(322, 207)
        Me.ClubActionsFlowLayoutPanel.TabIndex = 9
        '
        'ClubAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 285)
        Me.Controls.Add(Me.ClubActionsFlowLayoutPanel)
        Me.Controls.Add(Me.URLLabel)
        Me.Controls.Add(Me.ClubAbbreviationLabel)
        Me.Controls.Add(Me.ClubNameLabel)
        Me.Name = "ClubAdminForm"
        Me.Text = "Club Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClubNameLabel As Label
    Friend WithEvents ClubAbbreviationLabel As Label
    Friend WithEvents URLLabel As Label
    Friend WithEvents ClubActionsFlowLayoutPanel As FlowLayoutPanel
End Class
