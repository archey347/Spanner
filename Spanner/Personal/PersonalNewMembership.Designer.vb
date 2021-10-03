<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalNewMembershipForm
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
        Me.ClubsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MembershipTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.ClubsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Clubs"
        '
        'ClubsDataGridView
        '
        Me.ClubsDataGridView.AllowUserToAddRows = False
        Me.ClubsDataGridView.AllowUserToDeleteRows = False
        Me.ClubsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClubsDataGridView.Location = New System.Drawing.Point(17, 63)
        Me.ClubsDataGridView.Name = "ClubsDataGridView"
        Me.ClubsDataGridView.RowHeadersWidth = 51
        Me.ClubsDataGridView.RowTemplate.Height = 24
        Me.ClubsDataGridView.Size = New System.Drawing.Size(549, 184)
        Me.ClubsDataGridView.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select Club"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Selected Club"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Name"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(17, 309)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(58, 22)
        Me.IDTextBox.TabIndex = 12
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(81, 309)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(209, 22)
        Me.NameTextBox.TabIndex = 13
        '
        'MembershipTypeComboBox
        '
        Me.MembershipTypeComboBox.FormattingEnabled = True
        Me.MembershipTypeComboBox.Location = New System.Drawing.Point(17, 369)
        Me.MembershipTypeComboBox.Name = "MembershipTypeComboBox"
        Me.MembershipTypeComboBox.Size = New System.Drawing.Size(224, 24)
        Me.MembershipTypeComboBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Select Membership Type"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(17, 429)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 16
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(102, 429)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 17
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PersonalNewMembershipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 473)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MembershipTypeComboBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ClubsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PersonalNewMembershipForm"
        Me.Text = "New Membership"
        CType(Me.ClubsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ClubsDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MembershipTypeComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CancelButton As Button
End Class
