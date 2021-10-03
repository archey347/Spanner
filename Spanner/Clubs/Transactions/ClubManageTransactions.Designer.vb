<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubManageTransactionsForm
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
        Me.ManagePaymentsButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TransactionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 72)
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
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Manage Transactions"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ManagePaymentsButton)
        Me.Panel2.Controls.Add(Me.CreateButton)
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 400)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 50)
        Me.Panel2.TabIndex = 1
        '
        'ManagePaymentsButton
        '
        Me.ManagePaymentsButton.Location = New System.Drawing.Point(350, 6)
        Me.ManagePaymentsButton.Name = "ManagePaymentsButton"
        Me.ManagePaymentsButton.Size = New System.Drawing.Size(164, 30)
        Me.ManagePaymentsButton.TabIndex = 8
        Me.ManagePaymentsButton.Text = "Manage Payments"
        Me.ManagePaymentsButton.UseVisualStyleBackColor = True
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(180, 6)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(164, 30)
        Me.CreateButton.TabIndex = 7
        Me.CreateButton.Text = "Create Transaction"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(10, 6)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(164, 30)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "Edit Transaction"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TransactionsDataGridView
        '
        Me.TransactionsDataGridView.AllowUserToAddRows = False
        Me.TransactionsDataGridView.AllowUserToDeleteRows = False
        Me.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionsDataGridView.Location = New System.Drawing.Point(0, 72)
        Me.TransactionsDataGridView.Name = "TransactionsDataGridView"
        Me.TransactionsDataGridView.RowHeadersWidth = 51
        Me.TransactionsDataGridView.RowTemplate.Height = 24
        Me.TransactionsDataGridView.Size = New System.Drawing.Size(800, 328)
        Me.TransactionsDataGridView.TabIndex = 2
        '
        'ClubManageTransactionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TransactionsDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClubManageTransactionsForm"
        Me.Text = "Transactions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TransactionsDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ManagePaymentsButton As Button
End Class
