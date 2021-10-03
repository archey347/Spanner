<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PersonalEventBookingsButton = New System.Windows.Forms.Button()
        Me.PersonalMembershipButton = New System.Windows.Forms.Button()
        Me.PersonalDetailsButton = New System.Windows.Forms.Button()
        Me.BoxClubs = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BoxAdmin = New System.Windows.Forms.GroupBox()
        Me.VehicleClassesAdminButton = New System.Windows.Forms.Button()
        Me.ClubsAdminButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.BoxClubs.SuspendLayout()
        Me.BoxAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 121)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Main Menu"
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(729, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 32)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutButton.Location = New System.Drawing.Point(648, 12)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 32)
        Me.LogoutButton.TabIndex = 4
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelStatus, Me.StatusName, Me.StatusUsername})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(816, 26)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelStatus
        '
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(101, 20)
        Me.LabelStatus.Text = "Logged in as: "
        '
        'StatusName
        '
        Me.StatusName.Name = "StatusName"
        Me.StatusName.Size = New System.Drawing.Size(49, 20)
        Me.StatusName.Text = "Name"
        '
        'StatusUsername
        '
        Me.StatusUsername.Name = "StatusUsername"
        Me.StatusUsername.Size = New System.Drawing.Size(75, 20)
        Me.StatusUsername.Text = "Username"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PersonalEventBookingsButton)
        Me.GroupBox1.Controls.Add(Me.PersonalMembershipButton)
        Me.GroupBox1.Controls.Add(Me.PersonalDetailsButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 212)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal"
        '
        'PersonalEventBookingsButton
        '
        Me.PersonalEventBookingsButton.Location = New System.Drawing.Point(6, 93)
        Me.PersonalEventBookingsButton.Name = "PersonalEventBookingsButton"
        Me.PersonalEventBookingsButton.Size = New System.Drawing.Size(188, 30)
        Me.PersonalEventBookingsButton.TabIndex = 2
        Me.PersonalEventBookingsButton.Text = "Event Bookings"
        Me.PersonalEventBookingsButton.UseVisualStyleBackColor = True
        '
        'PersonalMembershipButton
        '
        Me.PersonalMembershipButton.Location = New System.Drawing.Point(6, 57)
        Me.PersonalMembershipButton.Name = "PersonalMembershipButton"
        Me.PersonalMembershipButton.Size = New System.Drawing.Size(188, 30)
        Me.PersonalMembershipButton.TabIndex = 1
        Me.PersonalMembershipButton.Text = "Membership"
        Me.PersonalMembershipButton.UseVisualStyleBackColor = True
        '
        'PersonalDetailsButton
        '
        Me.PersonalDetailsButton.Location = New System.Drawing.Point(6, 21)
        Me.PersonalDetailsButton.Name = "PersonalDetailsButton"
        Me.PersonalDetailsButton.Size = New System.Drawing.Size(188, 30)
        Me.PersonalDetailsButton.TabIndex = 0
        Me.PersonalDetailsButton.Text = "Personal Details"
        Me.PersonalDetailsButton.UseVisualStyleBackColor = True
        '
        'BoxClubs
        '
        Me.BoxClubs.AutoSize = True
        Me.BoxClubs.Controls.Add(Me.FlowLayoutPanel1)
        Me.BoxClubs.Location = New System.Drawing.Point(218, 157)
        Me.BoxClubs.Name = "BoxClubs"
        Me.BoxClubs.Size = New System.Drawing.Size(392, 212)
        Me.BoxClubs.TabIndex = 8
        Me.BoxClubs.TabStop = False
        Me.BoxClubs.Text = "Clubs"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(386, 191)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'BoxAdmin
        '
        Me.BoxAdmin.Controls.Add(Me.VehicleClassesAdminButton)
        Me.BoxAdmin.Controls.Add(Me.ClubsAdminButton)
        Me.BoxAdmin.Location = New System.Drawing.Point(616, 157)
        Me.BoxAdmin.Name = "BoxAdmin"
        Me.BoxAdmin.Size = New System.Drawing.Size(200, 212)
        Me.BoxAdmin.TabIndex = 9
        Me.BoxAdmin.TabStop = False
        Me.BoxAdmin.Text = "Admin"
        '
        'VehicleClassesAdminButton
        '
        Me.VehicleClassesAdminButton.Location = New System.Drawing.Point(6, 57)
        Me.VehicleClassesAdminButton.Name = "VehicleClassesAdminButton"
        Me.VehicleClassesAdminButton.Size = New System.Drawing.Size(188, 30)
        Me.VehicleClassesAdminButton.TabIndex = 4
        Me.VehicleClassesAdminButton.Text = "Vehicle Classes"
        Me.VehicleClassesAdminButton.UseVisualStyleBackColor = True
        '
        'ClubsAdminButton
        '
        Me.ClubsAdminButton.Location = New System.Drawing.Point(6, 21)
        Me.ClubsAdminButton.Name = "ClubsAdminButton"
        Me.ClubsAdminButton.Size = New System.Drawing.Size(188, 30)
        Me.ClubsAdminButton.TabIndex = 3
        Me.ClubsAdminButton.Text = "Clubs"
        Me.ClubsAdminButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 450)
        Me.Controls.Add(Me.BoxAdmin)
        Me.Controls.Add(Me.BoxClubs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainForm"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.BoxClubs.ResumeLayout(False)
        Me.BoxAdmin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LabelStatus As ToolStripStatusLabel
    Friend WithEvents StatusName As ToolStripStatusLabel
    Friend WithEvents StatusUsername As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BoxClubs As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BoxAdmin As GroupBox
    Friend WithEvents PersonalEventBookingsButton As Button
    Friend WithEvents PersonalMembershipButton As Button
    Friend WithEvents PersonalDetailsButton As Button
    Friend WithEvents VehicleClassesAdminButton As Button
    Friend WithEvents ClubsAdminButton As Button
End Class
