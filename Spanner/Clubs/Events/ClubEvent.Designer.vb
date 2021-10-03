<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClubEventForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CompetitiveCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Event"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(15, 72)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(300, 22)
        Me.NameTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Start Date"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Location = New System.Drawing.Point(15, 126)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(167, 22)
        Me.StartDateTimePicker.TabIndex = 11
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.Location = New System.Drawing.Point(17, 181)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(167, 22)
        Me.EndDateTimePicker.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "End Date"
        '
        'CompetitiveCheckbox
        '
        Me.CompetitiveCheckbox.AutoSize = True
        Me.CompetitiveCheckbox.Location = New System.Drawing.Point(15, 222)
        Me.CompetitiveCheckbox.Name = "CompetitiveCheckbox"
        Me.CompetitiveCheckbox.Size = New System.Drawing.Size(143, 21)
        Me.CompetitiveCheckbox.TabIndex = 14
        Me.CompetitiveCheckbox.Text = "Competitive Event"
        Me.CompetitiveCheckbox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Price (£)"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(15, 277)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(143, 22)
        Me.PriceTextBox.TabIndex = 35
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(93, 326)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 40
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(12, 326)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 39
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ClubEventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 361)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CompetitiveCheckbox)
        Me.Controls.Add(Me.EndDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StartDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClubEventForm"
        Me.Text = "Club Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StartDateTimePicker As DateTimePicker
    Friend WithEvents EndDateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CompetitiveCheckbox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
End Class
