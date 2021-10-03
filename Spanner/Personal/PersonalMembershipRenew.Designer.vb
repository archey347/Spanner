<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalMembershipRenewForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MembershipTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.RenewButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
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
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Renew Booking"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Membership Type"
        '
        'MembershipTypeComboBox
        '
        Me.MembershipTypeComboBox.FormattingEnabled = True
        Me.MembershipTypeComboBox.Location = New System.Drawing.Point(17, 70)
        Me.MembershipTypeComboBox.Name = "MembershipTypeComboBox"
        Me.MembershipTypeComboBox.Size = New System.Drawing.Size(221, 24)
        Me.MembershipTypeComboBox.TabIndex = 10
        '
        'RenewButton
        '
        Me.RenewButton.Location = New System.Drawing.Point(17, 134)
        Me.RenewButton.Name = "RenewButton"
        Me.RenewButton.Size = New System.Drawing.Size(75, 23)
        Me.RenewButton.TabIndex = 11
        Me.RenewButton.Text = "Renew"
        Me.RenewButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(98, 134)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 12
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PersonalMembershipRenewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 182)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.RenewButton)
        Me.Controls.Add(Me.MembershipTypeComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PersonalMembershipRenewForm"
        Me.Text = "Renew Membership"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MembershipTypeComboBox As ComboBox
    Friend WithEvents RenewButton As Button
    Friend WithEvents CancelButton As Button
End Class
