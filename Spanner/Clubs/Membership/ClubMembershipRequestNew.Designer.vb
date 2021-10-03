<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubMembershipRequestNewForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FilterFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FilterLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MembershipTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.RequestTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 130)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 157)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "New Membership Request"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Select User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Search Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Search First Name"
        '
        'FilterFirstNameTextBox
        '
        Me.FilterFirstNameTextBox.Location = New System.Drawing.Point(12, 102)
        Me.FilterFirstNameTextBox.Name = "FilterFirstNameTextBox"
        Me.FilterFirstNameTextBox.Size = New System.Drawing.Size(160, 22)
        Me.FilterFirstNameTextBox.TabIndex = 37
        '
        'FilterLastNameTextBox
        '
        Me.FilterLastNameTextBox.Location = New System.Drawing.Point(178, 102)
        Me.FilterLastNameTextBox.Name = "FilterLastNameTextBox"
        Me.FilterLastNameTextBox.Size = New System.Drawing.Size(158, 22)
        Me.FilterLastNameTextBox.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Selected User"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(13, 324)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(69, 22)
        Me.IDTextBox.TabIndex = 40
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(88, 324)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.FirstNameTextBox.TabIndex = 41
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(274, 324)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.LastNameTextBox.TabIndex = 42
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(460, 324)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(123, 22)
        Me.TypeTextBox.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Membership Type"
        '
        'MembershipTypeComboBox
        '
        Me.MembershipTypeComboBox.FormattingEnabled = True
        Me.MembershipTypeComboBox.Location = New System.Drawing.Point(12, 445)
        Me.MembershipTypeComboBox.Name = "MembershipTypeComboBox"
        Me.MembershipTypeComboBox.Size = New System.Drawing.Size(179, 24)
        Me.MembershipTypeComboBox.TabIndex = 45
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(93, 496)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 47
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(12, 496)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 46
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'RequestTypeComboBox
        '
        Me.RequestTypeComboBox.FormattingEnabled = True
        Me.RequestTypeComboBox.Items.AddRange(New Object() {"Renew", "New"})
        Me.RequestTypeComboBox.Location = New System.Drawing.Point(13, 389)
        Me.RequestTypeComboBox.Name = "RequestTypeComboBox"
        Me.RequestTypeComboBox.Size = New System.Drawing.Size(130, 24)
        Me.RequestTypeComboBox.TabIndex = 49
        Me.RequestTypeComboBox.Text = "Renew"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Request Type"
        '
        'ClubMembershipRequestNewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 557)
        Me.Controls.Add(Me.RequestTypeComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.MembershipTypeComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FilterLastNameTextBox)
        Me.Controls.Add(Me.FilterFirstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ClubMembershipRequestNewForm"
        Me.Text = "New Membership Request"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents inpLastName As TextBox
    Friend WithEvents inpFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FilterFirstNameTextBox As TextBox
    Friend WithEvents FilterLastNameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MembershipTypeComboBox As ComboBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents RequestTypeComboBox As ComboBox
    Friend WithEvents Label7 As Label
End Class
