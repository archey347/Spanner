<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalBookingsForm
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
        Me.EventResultsButton = New System.Windows.Forms.Button()
        Me.CancelBookingButton = New System.Windows.Forms.Button()
        Me.NewBookingButton = New System.Windows.Forms.Button()
        Me.EditBookingForm = New System.Windows.Forms.Button()
        Me.BookingsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BookingsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1150, 61)
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
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bookings"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EventResultsButton)
        Me.Panel2.Controls.Add(Me.CancelBookingButton)
        Me.Panel2.Controls.Add(Me.NewBookingButton)
        Me.Panel2.Controls.Add(Me.EditBookingForm)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 392)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1150, 45)
        Me.Panel2.TabIndex = 1
        '
        'EventResultsButton
        '
        Me.EventResultsButton.Location = New System.Drawing.Point(520, 6)
        Me.EventResultsButton.Name = "EventResultsButton"
        Me.EventResultsButton.Size = New System.Drawing.Size(150, 31)
        Me.EventResultsButton.TabIndex = 5
        Me.EventResultsButton.Text = "Event Results"
        Me.EventResultsButton.UseVisualStyleBackColor = True
        '
        'CancelBookingButton
        '
        Me.CancelBookingButton.Location = New System.Drawing.Point(324, 6)
        Me.CancelBookingButton.Name = "CancelBookingButton"
        Me.CancelBookingButton.Size = New System.Drawing.Size(150, 31)
        Me.CancelBookingButton.TabIndex = 4
        Me.CancelBookingButton.Text = "Cancel Booking"
        Me.CancelBookingButton.UseVisualStyleBackColor = True
        '
        'NewBookingButton
        '
        Me.NewBookingButton.Location = New System.Drawing.Point(12, 6)
        Me.NewBookingButton.Name = "NewBookingButton"
        Me.NewBookingButton.Size = New System.Drawing.Size(150, 31)
        Me.NewBookingButton.TabIndex = 3
        Me.NewBookingButton.Text = "New Booking"
        Me.NewBookingButton.UseVisualStyleBackColor = True
        '
        'EditBookingForm
        '
        Me.EditBookingForm.Location = New System.Drawing.Point(168, 6)
        Me.EditBookingForm.Name = "EditBookingForm"
        Me.EditBookingForm.Size = New System.Drawing.Size(150, 31)
        Me.EditBookingForm.TabIndex = 2
        Me.EditBookingForm.Text = "Edit Booking"
        Me.EditBookingForm.UseVisualStyleBackColor = True
        '
        'BookingsDataGridView
        '
        Me.BookingsDataGridView.AllowUserToAddRows = False
        Me.BookingsDataGridView.AllowUserToDeleteRows = False
        Me.BookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookingsDataGridView.Location = New System.Drawing.Point(0, 61)
        Me.BookingsDataGridView.Name = "BookingsDataGridView"
        Me.BookingsDataGridView.ReadOnly = True
        Me.BookingsDataGridView.RowHeadersWidth = 51
        Me.BookingsDataGridView.RowTemplate.Height = 24
        Me.BookingsDataGridView.Size = New System.Drawing.Size(1150, 331)
        Me.BookingsDataGridView.TabIndex = 2
        '
        'PersonalBookingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 437)
        Me.Controls.Add(Me.BookingsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PersonalBookingsForm"
        Me.Text = "Personal Bookings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BookingsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BookingsDataGridView As DataGridView
    Friend WithEvents EventResultsButton As Button
    Friend WithEvents CancelBookingButton As Button
    Friend WithEvents NewBookingButton As Button
    Friend WithEvents EditBookingForm As Button
End Class
