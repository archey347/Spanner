<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubRolesForm
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
        Me.RolesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AssignButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.RolesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 54)
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
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Roles"
        '
        'RolesDataGridView
        '
        Me.RolesDataGridView.AllowUserToAddRows = False
        Me.RolesDataGridView.AllowUserToDeleteRows = False
        Me.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RolesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RolesDataGridView.Location = New System.Drawing.Point(0, 54)
        Me.RolesDataGridView.Name = "RolesDataGridView"
        Me.RolesDataGridView.ReadOnly = True
        Me.RolesDataGridView.RowHeadersWidth = 51
        Me.RolesDataGridView.RowTemplate.Height = 24
        Me.RolesDataGridView.Size = New System.Drawing.Size(421, 192)
        Me.RolesDataGridView.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AssignButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 246)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(421, 49)
        Me.Panel2.TabIndex = 3
        '
        'AssignButton
        '
        Me.AssignButton.Location = New System.Drawing.Point(12, 6)
        Me.AssignButton.Name = "AssignButton"
        Me.AssignButton.Size = New System.Drawing.Size(117, 31)
        Me.AssignButton.TabIndex = 0
        Me.AssignButton.Text = "Assign Role"
        Me.AssignButton.UseVisualStyleBackColor = True
        '
        'ClubRolesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 295)
        Me.Controls.Add(Me.RolesDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClubRolesForm"
        Me.Text = "Roles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RolesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RolesDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AssignButton As Button
End Class
