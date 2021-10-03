<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonalNewEventBookingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FilterClubComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EventsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.FilterClubCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        CType(Me.EventsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter by Club"
        '
        'FilterClubComboBox
        '
        Me.FilterClubComboBox.FormattingEnabled = True
        Me.FilterClubComboBox.Location = New System.Drawing.Point(36, 74)
        Me.FilterClubComboBox.Name = "FilterClubComboBox"
        Me.FilterClubComboBox.Size = New System.Drawing.Size(499, 24)
        Me.FilterClubComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Event Booking"
        '
        'EventsDataGridView
        '
        Me.EventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventsDataGridView.Location = New System.Drawing.Point(12, 137)
        Me.EventsDataGridView.Name = "EventsDataGridView"
        Me.EventsDataGridView.ReadOnly = True
        Me.EventsDataGridView.RowHeadersWidth = 51
        Me.EventsDataGridView.RowTemplate.Height = 24
        Me.EventsDataGridView.Size = New System.Drawing.Size(1053, 181)
        Me.EventsDataGridView.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Select Event"
        '
        'ClassComboBox
        '
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Location = New System.Drawing.Point(12, 412)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(309, 24)
        Me.ClassComboBox.TabIndex = 10
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(9, 392)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(92, 17)
        Me.lblClass.TabIndex = 11
        Me.lblClass.Text = "Vehicle Class"
        '
        'FilterClubCheckbox
        '
        Me.FilterClubCheckbox.AutoSize = True
        Me.FilterClubCheckbox.Location = New System.Drawing.Point(12, 78)
        Me.FilterClubCheckbox.Name = "FilterClubCheckbox"
        Me.FilterClubCheckbox.Size = New System.Drawing.Size(18, 17)
        Me.FilterClubCheckbox.TabIndex = 12
        Me.FilterClubCheckbox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Selected Event"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(14, 360)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(63, 22)
        Me.IDTextBox.TabIndex = 14
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(83, 360)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(240, 22)
        Me.NameTextBox.TabIndex = 15
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(329, 360)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(75, 22)
        Me.PriceTextBox.TabIndex = 16
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(92, 451)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 42
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(11, 451)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 41
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'PersonalNewEventBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 486)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FilterClubCheckbox)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.ClassComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EventsDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FilterClubComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PersonalNewEventBookingForm"
        Me.Text = "New Event Booking"
        CType(Me.EventsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FilterClubComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EventsDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents ClassComboBox As ComboBox
    Friend WithEvents lblClass As Label
    Friend WithEvents FilterClubCheckbox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
End Class
