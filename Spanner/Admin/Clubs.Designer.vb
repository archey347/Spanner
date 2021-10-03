<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubsForm
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
        Me.DeleteClubButton = New System.Windows.Forms.Button()
        Me.FilterDeletedCheckbox = New System.Windows.Forms.CheckBox()
        Me.EditClubButton = New System.Windows.Forms.Button()
        Me.AddClubButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ClubDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ClubDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 54)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Clubs"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DeleteClubButton)
        Me.Panel2.Controls.Add(Me.FilterDeletedCheckbox)
        Me.Panel2.Controls.Add(Me.EditClubButton)
        Me.Panel2.Controls.Add(Me.AddClubButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 421)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1023, 73)
        Me.Panel2.TabIndex = 7
        '
        'DeleteClubButton
        '
        Me.DeleteClubButton.Location = New System.Drawing.Point(256, 14)
        Me.DeleteClubButton.Name = "DeleteClubButton"
        Me.DeleteClubButton.Size = New System.Drawing.Size(116, 35)
        Me.DeleteClubButton.TabIndex = 3
        Me.DeleteClubButton.Text = "Delete Club"
        Me.DeleteClubButton.UseVisualStyleBackColor = True
        '
        'FilterDeletedCheckbox
        '
        Me.FilterDeletedCheckbox.AutoSize = True
        Me.FilterDeletedCheckbox.Location = New System.Drawing.Point(389, 22)
        Me.FilterDeletedCheckbox.Name = "FilterDeletedCheckbox"
        Me.FilterDeletedCheckbox.Size = New System.Drawing.Size(156, 21)
        Me.FilterDeletedCheckbox.TabIndex = 2
        Me.FilterDeletedCheckbox.Text = "Show Deleted Clubs"
        Me.FilterDeletedCheckbox.UseVisualStyleBackColor = True
        '
        'EditClubButton
        '
        Me.EditClubButton.Location = New System.Drawing.Point(134, 14)
        Me.EditClubButton.Name = "EditClubButton"
        Me.EditClubButton.Size = New System.Drawing.Size(116, 35)
        Me.EditClubButton.TabIndex = 1
        Me.EditClubButton.Text = "Edit Club"
        Me.EditClubButton.UseVisualStyleBackColor = True
        '
        'AddClubButton
        '
        Me.AddClubButton.Location = New System.Drawing.Point(12, 14)
        Me.AddClubButton.Name = "AddClubButton"
        Me.AddClubButton.Size = New System.Drawing.Size(116, 35)
        Me.AddClubButton.TabIndex = 0
        Me.AddClubButton.Text = "Add Club"
        Me.AddClubButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ClubDataGridView)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1023, 367)
        Me.Panel3.TabIndex = 8
        '
        'ClubDataGridView
        '
        Me.ClubDataGridView.AllowUserToAddRows = False
        Me.ClubDataGridView.AllowUserToDeleteRows = False
        Me.ClubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClubDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClubDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ClubDataGridView.MultiSelect = False
        Me.ClubDataGridView.Name = "ClubDataGridView"
        Me.ClubDataGridView.ReadOnly = True
        Me.ClubDataGridView.RowHeadersWidth = 51
        Me.ClubDataGridView.RowTemplate.Height = 24
        Me.ClubDataGridView.Size = New System.Drawing.Size(1023, 367)
        Me.ClubDataGridView.TabIndex = 6
        '
        'ClubsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 494)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClubsForm"
        Me.Text = "Clubs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ClubDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EditClubButton As Button
    Friend WithEvents AddClubButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ClubDataGridView As DataGridView
    Friend WithEvents DeleteClubButton As Button
    Friend WithEvents FilterDeletedCheckbox As CheckBox
End Class
