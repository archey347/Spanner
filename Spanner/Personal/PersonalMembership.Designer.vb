<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalMembershipForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.RenewButton = New System.Windows.Forms.Button()
        Me.MembershipsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MembershipsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 54)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Membership"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.HistoryButton)
        Me.Panel2.Controls.Add(Me.NewButton)
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Controls.Add(Me.RenewButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 55)
        Me.Panel2.TabIndex = 1
        '
        'HistoryButton
        '
        Me.HistoryButton.Location = New System.Drawing.Point(332, 12)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(158, 30)
        Me.HistoryButton.TabIndex = 4
        Me.HistoryButton.Text = "Request History"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(496, 12)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(158, 31)
        Me.NewButton.TabIndex = 3
        Me.NewButton.Text = "Get New Membership"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(168, 12)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(158, 31)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel Membership"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'RenewButton
        '
        Me.RenewButton.Location = New System.Drawing.Point(12, 12)
        Me.RenewButton.Name = "RenewButton"
        Me.RenewButton.Size = New System.Drawing.Size(150, 31)
        Me.RenewButton.TabIndex = 1
        Me.RenewButton.Text = "Renew Membership"
        Me.RenewButton.UseVisualStyleBackColor = True
        '
        'MembershipsDataGridView
        '
        Me.MembershipsDataGridView.AllowUserToAddRows = False
        Me.MembershipsDataGridView.AllowUserToDeleteRows = False
        Me.MembershipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MembershipsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MembershipsDataGridView.Location = New System.Drawing.Point(0, 54)
        Me.MembershipsDataGridView.Name = "MembershipsDataGridView"
        Me.MembershipsDataGridView.ReadOnly = True
        Me.MembershipsDataGridView.RowHeadersWidth = 51
        Me.MembershipsDataGridView.RowTemplate.Height = 24
        Me.MembershipsDataGridView.Size = New System.Drawing.Size(875, 162)
        Me.MembershipsDataGridView.TabIndex = 2
        '
        'PersonalMembershipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 271)
        Me.Controls.Add(Me.MembershipsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PersonalMembershipForm"
        Me.Text = "Personal Membership"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.MembershipsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MembershipsDataGridView As DataGridView
    Friend WithEvents NewButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents RenewButton As Button
    Friend WithEvents HistoryButton As Button
End Class
