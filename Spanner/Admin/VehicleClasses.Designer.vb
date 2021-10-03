<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleClassesForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EditClassButton = New System.Windows.Forms.Button()
        Me.AddClassButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VehicleClassesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.VehicleClassesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Vehicle Classes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 57)
        Me.Panel1.TabIndex = 7
        '
        'EditClassButton
        '
        Me.EditClassButton.Location = New System.Drawing.Point(134, 14)
        Me.EditClassButton.Name = "EditClassButton"
        Me.EditClassButton.Size = New System.Drawing.Size(116, 35)
        Me.EditClassButton.TabIndex = 1
        Me.EditClassButton.Text = "Edit Class"
        Me.EditClassButton.UseVisualStyleBackColor = True
        '
        'AddClassButton
        '
        Me.AddClassButton.Location = New System.Drawing.Point(12, 14)
        Me.AddClassButton.Name = "AddClassButton"
        Me.AddClassButton.Size = New System.Drawing.Size(116, 35)
        Me.AddClassButton.TabIndex = 0
        Me.AddClassButton.Text = "Add Class"
        Me.AddClassButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EditClassButton)
        Me.Panel2.Controls.Add(Me.AddClassButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 420)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(883, 66)
        Me.Panel2.TabIndex = 8
        '
        'VehicleClassesDataGridView
        '
        Me.VehicleClassesDataGridView.AllowUserToAddRows = False
        Me.VehicleClassesDataGridView.AllowUserToDeleteRows = False
        Me.VehicleClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehicleClassesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VehicleClassesDataGridView.Location = New System.Drawing.Point(0, 57)
        Me.VehicleClassesDataGridView.Name = "VehicleClassesDataGridView"
        Me.VehicleClassesDataGridView.ReadOnly = True
        Me.VehicleClassesDataGridView.RowHeadersWidth = 51
        Me.VehicleClassesDataGridView.RowTemplate.Height = 24
        Me.VehicleClassesDataGridView.Size = New System.Drawing.Size(883, 363)
        Me.VehicleClassesDataGridView.TabIndex = 9
        '
        'VehicleClassesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 486)
        Me.Controls.Add(Me.VehicleClassesDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VehicleClassesForm"
        Me.Text = "Vehicle Classes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.VehicleClassesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EditClassButton As Button
    Friend WithEvents AddClassButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VehicleClassesDataGridView As DataGridView
End Class
