<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubNewEventBooking
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
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FilterFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FilterLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "New Event Booking"
        '
        'UsersDataGridView
        '
        Me.UsersDataGridView.AllowUserToAddRows = False
        Me.UsersDataGridView.AllowUserToDeleteRows = False
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Location = New System.Drawing.Point(17, 82)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.ReadOnly = True
        Me.UsersDataGridView.RowHeadersWidth = 51
        Me.UsersDataGridView.RowTemplate.Height = 24
        Me.UsersDataGridView.Size = New System.Drawing.Size(926, 165)
        Me.UsersDataGridView.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Search Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Search First Name"
        '
        'FilterFirstNameTextBox
        '
        Me.FilterFirstNameTextBox.Location = New System.Drawing.Point(17, 54)
        Me.FilterFirstNameTextBox.Name = "FilterFirstNameTextBox"
        Me.FilterFirstNameTextBox.Size = New System.Drawing.Size(167, 22)
        Me.FilterFirstNameTextBox.TabIndex = 38
        '
        'FilterLastNameTextBox
        '
        Me.FilterLastNameTextBox.Location = New System.Drawing.Point(190, 54)
        Me.FilterLastNameTextBox.Name = "FilterLastNameTextBox"
        Me.FilterLastNameTextBox.Size = New System.Drawing.Size(167, 22)
        Me.FilterLastNameTextBox.TabIndex = 39
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(14, 328)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(92, 17)
        Me.lblClass.TabIndex = 41
        Me.lblClass.Text = "Vehicle Class"
        '
        'ClassComboBox
        '
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Location = New System.Drawing.Point(17, 348)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(309, 24)
        Me.ClassComboBox.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Selected User"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(17, 287)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(69, 22)
        Me.IDTextBox.TabIndex = 43
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(94, 287)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.ReadOnly = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(193, 22)
        Me.FirstNameTextBox.TabIndex = 44
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(293, 287)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.ReadOnly = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(155, 22)
        Me.LastNameTextBox.TabIndex = 45
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(17, 407)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(94, 23)
        Me.OKButton.TabIndex = 46
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(117, 407)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(94, 23)
        Me.CancelButton.TabIndex = 47
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ClubNewEventBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 445)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.ClassComboBox)
        Me.Controls.Add(Me.FilterLastNameTextBox)
        Me.Controls.Add(Me.FilterFirstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UsersDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClubNewEventBooking"
        Me.Text = "New Booking"
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FilterFirstNameTextBox As TextBox
    Friend WithEvents FilterLastNameTextBox As TextBox
    Friend WithEvents lblClass As Label
    Friend WithEvents ClassComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
End Class
