<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalDetailsForm
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
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Line2TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Line1TextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TownTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Line3TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CountyTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AltPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RetypePasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
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
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Personal Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(12, 75)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(233, 22)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(12, 121)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(233, 22)
        Me.LastNameTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.GenderComboBox.Location = New System.Drawing.Point(12, 167)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 24)
        Me.GenderComboBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender"
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(12, 215)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(233, 22)
        Me.DateOfBirthDateTimePicker.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date of Birth"
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(9, 619)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 12
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(90, 619)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address"
        '
        'Line2TextBox
        '
        Me.Line2TextBox.Location = New System.Drawing.Point(12, 345)
        Me.Line2TextBox.Name = "Line2TextBox"
        Me.Line2TextBox.Size = New System.Drawing.Size(233, 22)
        Me.Line2TextBox.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Line 2"
        '
        'Line1TextBox
        '
        Me.Line1TextBox.Location = New System.Drawing.Point(12, 299)
        Me.Line1TextBox.Name = "Line1TextBox"
        Me.Line1TextBox.Size = New System.Drawing.Size(233, 22)
        Me.Line1TextBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Line 1"
        '
        'TownTextBox
        '
        Me.TownTextBox.Location = New System.Drawing.Point(12, 439)
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(233, 22)
        Me.TownTextBox.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Town/City"
        '
        'Line3TextBox
        '
        Me.Line3TextBox.Location = New System.Drawing.Point(12, 393)
        Me.Line3TextBox.Name = "Line3TextBox"
        Me.Line3TextBox.Size = New System.Drawing.Size(233, 22)
        Me.Line3TextBox.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Line 3"
        '
        'PostcodeTextBox
        '
        Me.PostcodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PostcodeTextBox.Location = New System.Drawing.Point(12, 534)
        Me.PostcodeTextBox.Name = "PostcodeTextBox"
        Me.PostcodeTextBox.Size = New System.Drawing.Size(121, 22)
        Me.PostcodeTextBox.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 515)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Postcode"
        '
        'CountyTextBox
        '
        Me.CountyTextBox.Location = New System.Drawing.Point(12, 488)
        Me.CountyTextBox.Name = "CountyTextBox"
        Me.CountyTextBox.Size = New System.Drawing.Size(233, 22)
        Me.CountyTextBox.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 469)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "County"
        '
        'AltPhoneTextBox
        '
        Me.AltPhoneTextBox.Location = New System.Drawing.Point(285, 195)
        Me.AltPhoneTextBox.Name = "AltPhoneTextBox"
        Me.AltPhoneTextBox.Size = New System.Drawing.Size(233, 22)
        Me.AltPhoneTextBox.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(285, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Alternative Phone Number"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(285, 147)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(233, 22)
        Me.PhoneTextBox.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(285, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 17)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Phone Number"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(285, 101)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(233, 22)
        Me.EmailTextBox.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(285, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Email Address"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(285, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 24)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Contact Details"
        '
        'RetypePasswordTextBox
        '
        Me.RetypePasswordTextBox.Location = New System.Drawing.Point(285, 377)
        Me.RetypePasswordTextBox.Name = "RetypePasswordTextBox"
        Me.RetypePasswordTextBox.Size = New System.Drawing.Size(233, 22)
        Me.RetypePasswordTextBox.TabIndex = 40
        Me.RetypePasswordTextBox.UseSystemPasswordChar = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(285, 358)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 17)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Retype Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(285, 329)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(233, 22)
        Me.PasswordTextBox.TabIndex = 38
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(285, 310)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 17)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(285, 283)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(233, 22)
        Me.UsernameTextBox.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(285, 264)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 17)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Username"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(285, 238)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 24)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Login Details"
        '
        'PersonalDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 654)
        Me.Controls.Add(Me.RetypePasswordTextBox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.AltPhoneTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PostcodeTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CountyTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TownTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Line3TextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Line2TextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Line1TextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PersonalDetailsForm"
        Me.Text = "Personal Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Line2TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Line1TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TownTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Line3TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PostcodeTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CountyTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AltPhoneTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents RetypePasswordTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
