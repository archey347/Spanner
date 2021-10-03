<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubMembershipRequestsForm
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
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.RejectButton = New System.Windows.Forms.Button()
        Me.ApproveButton = New System.Windows.Forms.Button()
        Me.MembershipRequestsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MembershipRequestsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1010, 68)
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
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Membership Requests"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CreateButton)
        Me.Panel2.Controls.Add(Me.RejectButton)
        Me.Panel2.Controls.Add(Me.ApproveButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 55)
        Me.Panel2.TabIndex = 2
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(352, 6)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(164, 30)
        Me.CreateButton.TabIndex = 6
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'RejectButton
        '
        Me.RejectButton.Location = New System.Drawing.Point(182, 6)
        Me.RejectButton.Name = "RejectButton"
        Me.RejectButton.Size = New System.Drawing.Size(164, 30)
        Me.RejectButton.TabIndex = 5
        Me.RejectButton.Text = "Reject"
        Me.RejectButton.UseVisualStyleBackColor = True
        '
        'ApproveButton
        '
        Me.ApproveButton.Location = New System.Drawing.Point(12, 6)
        Me.ApproveButton.Name = "ApproveButton"
        Me.ApproveButton.Size = New System.Drawing.Size(164, 30)
        Me.ApproveButton.TabIndex = 4
        Me.ApproveButton.Text = "Approve"
        Me.ApproveButton.UseVisualStyleBackColor = True
        '
        'MembershipRequestsDataGridView
        '
        Me.MembershipRequestsDataGridView.AllowUserToAddRows = False
        Me.MembershipRequestsDataGridView.AllowUserToDeleteRows = False
        Me.MembershipRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MembershipRequestsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MembershipRequestsDataGridView.Location = New System.Drawing.Point(0, 68)
        Me.MembershipRequestsDataGridView.Name = "MembershipRequestsDataGridView"
        Me.MembershipRequestsDataGridView.ReadOnly = True
        Me.MembershipRequestsDataGridView.RowHeadersWidth = 51
        Me.MembershipRequestsDataGridView.RowTemplate.Height = 24
        Me.MembershipRequestsDataGridView.Size = New System.Drawing.Size(1010, 354)
        Me.MembershipRequestsDataGridView.TabIndex = 3
        '
        'ClubMembershipRequestsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 477)
        Me.Controls.Add(Me.MembershipRequestsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClubMembershipRequestsForm"
        Me.Text = "Membership Requests"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.MembershipRequestsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MembershipRequestsDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateButton As Button
    Friend WithEvents RejectButton As Button
    Friend WithEvents ApproveButton As Button
End Class
