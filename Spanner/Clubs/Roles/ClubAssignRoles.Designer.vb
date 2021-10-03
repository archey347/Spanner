<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubAssignRolesForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AssignedUsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.RemoveUserButton = New System.Windows.Forms.Button()
        Me.SearchUsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddUserButton = New System.Windows.Forms.Button()
        CType(Me.AssignedUsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchUsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Assign Roles"
        '
        'AssignedUsersDataGridView
        '
        Me.AssignedUsersDataGridView.AllowUserToAddRows = False
        Me.AssignedUsersDataGridView.AllowUserToDeleteRows = False
        Me.AssignedUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssignedUsersDataGridView.Location = New System.Drawing.Point(17, 53)
        Me.AssignedUsersDataGridView.Name = "AssignedUsersDataGridView"
        Me.AssignedUsersDataGridView.ReadOnly = True
        Me.AssignedUsersDataGridView.RowHeadersWidth = 51
        Me.AssignedUsersDataGridView.RowTemplate.Height = 24
        Me.AssignedUsersDataGridView.Size = New System.Drawing.Size(868, 150)
        Me.AssignedUsersDataGridView.TabIndex = 9
        '
        'RemoveUserButton
        '
        Me.RemoveUserButton.Location = New System.Drawing.Point(17, 209)
        Me.RemoveUserButton.Name = "RemoveUserButton"
        Me.RemoveUserButton.Size = New System.Drawing.Size(157, 30)
        Me.RemoveUserButton.TabIndex = 10
        Me.RemoveUserButton.Text = "Remove User"
        Me.RemoveUserButton.UseVisualStyleBackColor = True
        '
        'SearchUsersDataGridView
        '
        Me.SearchUsersDataGridView.AllowUserToAddRows = False
        Me.SearchUsersDataGridView.AllowUserToDeleteRows = False
        Me.SearchUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchUsersDataGridView.Location = New System.Drawing.Point(17, 330)
        Me.SearchUsersDataGridView.Name = "SearchUsersDataGridView"
        Me.SearchUsersDataGridView.ReadOnly = True
        Me.SearchUsersDataGridView.RowHeadersWidth = 51
        Me.SearchUsersDataGridView.RowTemplate.Height = 24
        Me.SearchUsersDataGridView.Size = New System.Drawing.Size(680, 127)
        Me.SearchUsersDataGridView.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 258)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 24)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Add User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Search First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Search Last Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(17, 302)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(157, 22)
        Me.FirstNameTextBox.TabIndex = 31
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(180, 302)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(157, 22)
        Me.LastNameTextBox.TabIndex = 32
        '
        'AddUserButton
        '
        Me.AddUserButton.Location = New System.Drawing.Point(17, 463)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(171, 30)
        Me.AddUserButton.TabIndex = 33
        Me.AddUserButton.Text = "Add Selected User"
        Me.AddUserButton.UseVisualStyleBackColor = True
        '
        'ClubAssignRolesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 523)
        Me.Controls.Add(Me.AddUserButton)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SearchUsersDataGridView)
        Me.Controls.Add(Me.RemoveUserButton)
        Me.Controls.Add(Me.AssignedUsersDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClubAssignRolesForm"
        Me.Text = "Assign Roles"
        CType(Me.AssignedUsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchUsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AssignedUsersDataGridView As DataGridView
    Friend WithEvents RemoveUserButton As Button
    Friend WithEvents SearchUsersDataGridView As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddUserButton As Button
End Class
