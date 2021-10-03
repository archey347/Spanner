<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubEventBookingsForm
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
        Me.CreateBookingButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RejectBookingButton = New System.Windows.Forms.Button()
        Me.ApproveBookingButton = New System.Windows.Forms.Button()
        Me.ViewUserButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FilterRejectCheckbox = New System.Windows.Forms.CheckBox()
        Me.BookingsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BookingsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1283, 71)
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
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Manage Bookings"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1283, 85)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CreateBookingButton)
        Me.GroupBox3.Location = New System.Drawing.Point(771, 6)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(184, 60)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Actions"
        '
        'CreateBookingButton
        '
        Me.CreateBookingButton.Location = New System.Drawing.Point(5, 20)
        Me.CreateBookingButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateBookingButton.Name = "CreateBookingButton"
        Me.CreateBookingButton.Size = New System.Drawing.Size(164, 30)
        Me.CreateBookingButton.TabIndex = 1
        Me.CreateBookingButton.Text = "Create Booking"
        Me.CreateBookingButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RejectBookingButton)
        Me.GroupBox2.Controls.Add(Me.ApproveBookingButton)
        Me.GroupBox2.Controls.Add(Me.ViewUserButton)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(520, 60)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selected User Actions"
        '
        'RejectBookingButton
        '
        Me.RejectBookingButton.Location = New System.Drawing.Point(345, 21)
        Me.RejectBookingButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RejectBookingButton.Name = "RejectBookingButton"
        Me.RejectBookingButton.Size = New System.Drawing.Size(164, 30)
        Me.RejectBookingButton.TabIndex = 5
        Me.RejectBookingButton.Text = "Reject Booking"
        Me.RejectBookingButton.UseVisualStyleBackColor = True
        '
        'ApproveBookingButton
        '
        Me.ApproveBookingButton.Location = New System.Drawing.Point(176, 21)
        Me.ApproveBookingButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ApproveBookingButton.Name = "ApproveBookingButton"
        Me.ApproveBookingButton.Size = New System.Drawing.Size(164, 30)
        Me.ApproveBookingButton.TabIndex = 4
        Me.ApproveBookingButton.Text = "Approve Booking"
        Me.ApproveBookingButton.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FilterRejectCheckbox)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(235, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'FilterRejectCheckbox
        '
        Me.FilterRejectCheckbox.AutoSize = True
        Me.FilterRejectCheckbox.Location = New System.Drawing.Point(15, 25)
        Me.FilterRejectCheckbox.Margin = New System.Windows.Forms.Padding(4)
        Me.FilterRejectCheckbox.Name = "FilterRejectCheckbox"
        Me.FilterRejectCheckbox.Size = New System.Drawing.Size(148, 21)
        Me.FilterRejectCheckbox.TabIndex = 0
        Me.FilterRejectCheckbox.Text = "Rejected Bookings"
        Me.FilterRejectCheckbox.UseVisualStyleBackColor = True
        '
        'BookingsDataGridView
        '
        Me.BookingsDataGridView.AllowUserToAddRows = False
        Me.BookingsDataGridView.AllowUserToDeleteRows = False
        Me.BookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookingsDataGridView.Location = New System.Drawing.Point(0, 71)
        Me.BookingsDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BookingsDataGridView.Name = "BookingsDataGridView"
        Me.BookingsDataGridView.ReadOnly = True
        Me.BookingsDataGridView.RowHeadersWidth = 51
        Me.BookingsDataGridView.RowTemplate.Height = 24
        Me.BookingsDataGridView.Size = New System.Drawing.Size(1283, 351)
        Me.BookingsDataGridView.TabIndex = 2
        '
        'ClubEventBookingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 507)
        Me.Controls.Add(Me.BookingsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ClubEventBookingsForm"
        Me.Text = "Club Event Bookings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BookingsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BookingsDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FilterRejectCheckbox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CreateBookingButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ApproveBookingButton As Button
    Friend WithEvents ViewUserButton As Button
    Friend WithEvents RejectBookingButton As Button
End Class
