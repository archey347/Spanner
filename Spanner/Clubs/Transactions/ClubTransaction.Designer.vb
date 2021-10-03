<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubTransactionForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReferenceTextBox = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BankedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date Banked"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Transaction"
        '
        'ReferenceTextBox
        '
        Me.ReferenceTextBox.Location = New System.Drawing.Point(12, 73)
        Me.ReferenceTextBox.Name = "ReferenceTextBox"
        Me.ReferenceTextBox.Size = New System.Drawing.Size(245, 22)
        Me.ReferenceTextBox.TabIndex = 11
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(12, 184)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 12
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Reference"
        '
        'BankedDateTimePicker
        '
        Me.BankedDateTimePicker.Location = New System.Drawing.Point(12, 128)
        Me.BankedDateTimePicker.Name = "BankedDateTimePicker"
        Me.BankedDateTimePicker.Size = New System.Drawing.Size(245, 22)
        Me.BankedDateTimePicker.TabIndex = 14
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(93, 184)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 15
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ClubTransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 230)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.BankedDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.ReferenceTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClubTransactionForm"
        Me.Text = "Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReferenceTextBox As TextBox
    Friend WithEvents OKButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BankedDateTimePicker As DateTimePicker
    Friend WithEvents CancelButton As Button
End Class
