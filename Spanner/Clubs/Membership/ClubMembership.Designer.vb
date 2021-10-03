<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubMembershipForm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AddUserButton = New System.Windows.Forms.Button()
        Me.EditMembershipTypesButton = New System.Windows.Forms.Button()
        Me.CreateUserButton = New System.Windows.Forms.Button()
        Me.ExportMembershipListButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ExportMembershipCardButton = New System.Windows.Forms.Button()
        Me.MembershipRequestsButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ViewUserButton = New System.Windows.Forms.Button()
        Me.BanUserButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FilterCanceledCheckbox = New System.Windows.Forms.CheckBox()
        Me.FilterBannedCheckbox = New System.Windows.Forms.CheckBox()
        Me.FilterLapsedCheckbox = New System.Windows.Forms.CheckBox()
        Me.MembershipsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MembershipsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 56)
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
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Manage Membership"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 271)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1205, 213)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AddUserButton)
        Me.GroupBox3.Controls.Add(Me.EditMembershipTypesButton)
        Me.GroupBox3.Controls.Add(Me.CreateUserButton)
        Me.GroupBox3.Controls.Add(Me.ExportMembershipListButton)
        Me.GroupBox3.Location = New System.Drawing.Point(795, 7)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(385, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Actions"
        '
        'AddUserButton
        '
        Me.AddUserButton.Location = New System.Drawing.Point(204, 57)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(164, 30)
        Me.AddUserButton.TabIndex = 10
        Me.AddUserButton.Text = "Add Existing User"
        Me.AddUserButton.UseVisualStyleBackColor = True
        '
        'EditMembershipTypesButton
        '
        Me.EditMembershipTypesButton.Location = New System.Drawing.Point(5, 57)
        Me.EditMembershipTypesButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditMembershipTypesButton.Name = "EditMembershipTypesButton"
        Me.EditMembershipTypesButton.Size = New System.Drawing.Size(193, 30)
        Me.EditMembershipTypesButton.TabIndex = 9
        Me.EditMembershipTypesButton.Text = "Edit Membership Types"
        Me.EditMembershipTypesButton.UseVisualStyleBackColor = True
        '
        'CreateUserButton
        '
        Me.CreateUserButton.Location = New System.Drawing.Point(204, 21)
        Me.CreateUserButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateUserButton.Name = "CreateUserButton"
        Me.CreateUserButton.Size = New System.Drawing.Size(164, 30)
        Me.CreateUserButton.TabIndex = 7
        Me.CreateUserButton.Text = "Create New User"
        Me.CreateUserButton.UseVisualStyleBackColor = True
        '
        'ExportMembershipListButton
        '
        Me.ExportMembershipListButton.Location = New System.Drawing.Point(5, 21)
        Me.ExportMembershipListButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExportMembershipListButton.Name = "ExportMembershipListButton"
        Me.ExportMembershipListButton.Size = New System.Drawing.Size(193, 30)
        Me.ExportMembershipListButton.TabIndex = 6
        Me.ExportMembershipListButton.Text = "Export Membership List"
        Me.ExportMembershipListButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ExportMembershipCardButton)
        Me.GroupBox2.Controls.Add(Me.MembershipRequestsButton)
        Me.GroupBox2.Controls.Add(Me.CancelButton)
        Me.GroupBox2.Controls.Add(Me.ViewUserButton)
        Me.GroupBox2.Controls.Add(Me.BanUserButton)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(528, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selected User Actions"
        '
        'ExportMembershipCardButton
        '
        Me.ExportMembershipCardButton.Location = New System.Drawing.Point(347, 20)
        Me.ExportMembershipCardButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExportMembershipCardButton.Name = "ExportMembershipCardButton"
        Me.ExportMembershipCardButton.Size = New System.Drawing.Size(164, 67)
        Me.ExportMembershipCardButton.TabIndex = 5
        Me.ExportMembershipCardButton.Text = "Export Membership Card"
        Me.ExportMembershipCardButton.UseVisualStyleBackColor = True
        '
        'MembershipRequestsButton
        '
        Me.MembershipRequestsButton.Location = New System.Drawing.Point(176, 21)
        Me.MembershipRequestsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MembershipRequestsButton.Name = "MembershipRequestsButton"
        Me.MembershipRequestsButton.Size = New System.Drawing.Size(164, 30)
        Me.MembershipRequestsButton.TabIndex = 4
        Me.MembershipRequestsButton.Text = "Membership Requests"
        Me.MembershipRequestsButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(176, 57)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(164, 30)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel Membership"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ViewUserButton
        '
        Me.ViewUserButton.Location = New System.Drawing.Point(5, 20)
        Me.ViewUserButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ViewUserButton.Name = "ViewUserButton"
        Me.ViewUserButton.Size = New System.Drawing.Size(164, 30)
        Me.ViewUserButton.TabIndex = 1
        Me.ViewUserButton.Text = "View Selected User"
        Me.ViewUserButton.UseVisualStyleBackColor = True
        '
        'BanUserButton
        '
        Me.BanUserButton.Location = New System.Drawing.Point(5, 57)
        Me.BanUserButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BanUserButton.Name = "BanUserButton"
        Me.BanUserButton.Size = New System.Drawing.Size(164, 30)
        Me.BanUserButton.TabIndex = 2
        Me.BanUserButton.Text = "Ban Selected User"
        Me.BanUserButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FilterCanceledCheckbox)
        Me.GroupBox1.Controls.Add(Me.FilterBannedCheckbox)
        Me.GroupBox1.Controls.Add(Me.FilterLapsedCheckbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(241, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'FilterCanceledCheckbox
        '
        Me.FilterCanceledCheckbox.AutoSize = True
        Me.FilterCanceledCheckbox.Location = New System.Drawing.Point(5, 75)
        Me.FilterCanceledCheckbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FilterCanceledCheckbox.Name = "FilterCanceledCheckbox"
        Me.FilterCanceledCheckbox.Size = New System.Drawing.Size(189, 21)
        Me.FilterCanceledCheckbox.TabIndex = 2
        Me.FilterCanceledCheckbox.Text = "Show Canceled Members"
        Me.FilterCanceledCheckbox.UseVisualStyleBackColor = True
        '
        'FilterBannedCheckbox
        '
        Me.FilterBannedCheckbox.AutoSize = True
        Me.FilterBannedCheckbox.Location = New System.Drawing.Point(5, 48)
        Me.FilterBannedCheckbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FilterBannedCheckbox.Name = "FilterBannedCheckbox"
        Me.FilterBannedCheckbox.Size = New System.Drawing.Size(179, 21)
        Me.FilterBannedCheckbox.TabIndex = 1
        Me.FilterBannedCheckbox.Text = "Show Banned Members"
        Me.FilterBannedCheckbox.UseVisualStyleBackColor = True
        '
        'FilterLapsedCheckbox
        '
        Me.FilterLapsedCheckbox.AutoSize = True
        Me.FilterLapsedCheckbox.Location = New System.Drawing.Point(5, 21)
        Me.FilterLapsedCheckbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FilterLapsedCheckbox.Name = "FilterLapsedCheckbox"
        Me.FilterLapsedCheckbox.Size = New System.Drawing.Size(177, 21)
        Me.FilterLapsedCheckbox.TabIndex = 0
        Me.FilterLapsedCheckbox.Text = "Show Lapsed Members"
        Me.FilterLapsedCheckbox.UseVisualStyleBackColor = True
        '
        'MembershipsDataGridView
        '
        Me.MembershipsDataGridView.AllowUserToAddRows = False
        Me.MembershipsDataGridView.AllowUserToDeleteRows = False
        Me.MembershipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MembershipsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MembershipsDataGridView.Location = New System.Drawing.Point(0, 56)
        Me.MembershipsDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MembershipsDataGridView.MultiSelect = False
        Me.MembershipsDataGridView.Name = "MembershipsDataGridView"
        Me.MembershipsDataGridView.ReadOnly = True
        Me.MembershipsDataGridView.RowHeadersWidth = 51
        Me.MembershipsDataGridView.RowTemplate.Height = 24
        Me.MembershipsDataGridView.Size = New System.Drawing.Size(1205, 215)
        Me.MembershipsDataGridView.TabIndex = 2
        '
        'ClubMembershipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 484)
        Me.Controls.Add(Me.MembershipsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ClubMembershipForm"
        Me.Text = "Membership"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MembershipsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MembershipsDataGridView As DataGridView
    Friend WithEvents ViewUserButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FilterBannedCheckbox As CheckBox
    Friend WithEvents FilterLapsedCheckbox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EditMembershipTypesButton As Button
    Friend WithEvents CreateUserButton As Button
    Friend WithEvents ExportMembershipListButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ExportMembershipCardButton As Button
    Friend WithEvents MembershipRequestsButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents BanUserButton As Button
    Friend WithEvents FilterCanceledCheckbox As CheckBox
    Friend WithEvents AddUserButton As Button
End Class
