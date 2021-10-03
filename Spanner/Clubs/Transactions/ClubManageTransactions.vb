Public Class ClubManageTransactionsForm

    Private I As App.Injector

    Public clubId As Integer

    Private Sub ClubTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the service injector
        I = My.Application.I

        refreshTable()
    End Sub

    Private Sub refreshTable()
        ' Generate the SQL
        Dim SQL = "SELECT transactions.id, transactions.name, (users.first_name || "" "" || users.last_name), transactions.date_paid, transactions.total As name FROM transactions, users WHERE "
        SQL += "transactions.paid_in_by = users.id"

        Dim DB = I.DB

        ' Run the query
        Dim transactions = DB.getQuery(SQL)

        ' Load into the table
        TransactionsDataGridView.DataSource = transactions

        ' Set the columns
        TransactionsDataGridView.Columns(0).HeaderText = "ID"
        TransactionsDataGridView.Columns(1).HeaderText = "Reference"
        TransactionsDataGridView.Columns(2).HeaderText = "Paid in by"
        TransactionsDataGridView.Columns(3).HeaderText = "Date Paid"
        TransactionsDataGridView.Columns(4).HeaderText = "Total"

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showTransaction(TransactionsDataGridView.CurrentRow.Cells(0).Value, clubId)
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TransactionsDataGridView.CellFormatting
        If Not e.Value Is Nothing Then
            If e.ColumnIndex = 3 Then
                ' Format Date
                Dim date_paid = New DateTime(CLng(e.Value))
                e.Value = date_paid.ToShortDateString()
            ElseIf e.ColumnIndex = 4 Then
                ' Format as currency
                Dim total As Double = e.Value
                e.Value = "" + total.ToString("C2")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showTransaction(0, clubId)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ManagePaymentsButton.Click
        ' Get teh forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showManageTransaction(TransactionsDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub ClubManageTransactions_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh the table when the form comes into focus
        refreshTable()
    End Sub

End Class