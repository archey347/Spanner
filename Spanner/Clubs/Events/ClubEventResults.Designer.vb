<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubEventResultsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ManageSectionsButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ResultsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1086, 51)
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
        Me.Label1.Size = New System.Drawing.Size(208, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Manage Event Results"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ManageSectionsButton)
        Me.Panel2.Controls.Add(Me.ExportButton)
        Me.Panel2.Controls.Add(Me.ClearButton)
        Me.Panel2.Controls.Add(Me.SaveButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 324)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1086, 50)
        Me.Panel2.TabIndex = 1
        '
        'ManageSectionsButton
        '
        Me.ManageSectionsButton.Location = New System.Drawing.Point(431, 6)
        Me.ManageSectionsButton.Name = "ManageSectionsButton"
        Me.ManageSectionsButton.Size = New System.Drawing.Size(183, 32)
        Me.ManageSectionsButton.TabIndex = 3
        Me.ManageSectionsButton.Text = "Manage Sections"
        Me.ManageSectionsButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(293, 6)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(132, 32)
        Me.ExportButton.TabIndex = 2
        Me.ExportButton.Text = "Export Results"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(155, 6)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(132, 32)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear Changes"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(12, 6)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(137, 32)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Save Changes"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ResultsDataGridView
        '
        Me.ResultsDataGridView.AllowUserToAddRows = False
        Me.ResultsDataGridView.AllowUserToDeleteRows = False
        Me.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsDataGridView.Location = New System.Drawing.Point(0, 51)
        Me.ResultsDataGridView.Name = "ResultsDataGridView"
        Me.ResultsDataGridView.RowHeadersWidth = 51
        Me.ResultsDataGridView.RowTemplate.Height = 24
        Me.ResultsDataGridView.Size = New System.Drawing.Size(1086, 273)
        Me.ResultsDataGridView.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ClubEventResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 374)
        Me.Controls.Add(Me.ResultsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClubEventResultsForm"
        Me.Text = "Event Results"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResultsDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExportButton As Button
    Friend WithEvents ManageSectionsButton As Button
End Class
