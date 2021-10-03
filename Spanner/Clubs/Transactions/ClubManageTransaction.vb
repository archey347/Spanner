Public Class ClubManageTransactionForm

    Public transactionId As Integer

    Private I As App.Injector

    Private Sub ClubManageTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load injector
        I = My.Application.I

        ' Get the transaction
        Dim DB = I.DB
        Dim transaction = DB.getRecord("transactions", transactionId)

        ' Set form title
        Me.Text = "Manage Payments for '" + transaction("name") + "'"

        ' Update tables
        refreshPayments()
        refreshSearch()
    End Sub

    Public Sub refreshPayments()
        ' Generate SQL
        Dim SQL = "SELECT payments.id, (users.first_name || "" "" || users.last_name) As name, payments.item_type, payments.item_id, payments.amount FROM users, payments WHERE "
        SQL += "payments.user_id = users.id AND "
        SQL += "payments.transaction_id = " + transactionId.ToString()

        ' Get the DB service
        Dim DB = I.DB

        ' Run the query
        Dim data = DB.getQuery(SQL)

        ' Load the grid
        AssignedPaymentsDataGridView.DataSource = data

        ' Set the columns
        AssignedPaymentsDataGridView.Columns(0).HeaderText = "ID"
        AssignedPaymentsDataGridView.Columns(0).Width = 50
        AssignedPaymentsDataGridView.Columns(1).HeaderText = "Name"
        AssignedPaymentsDataGridView.Columns(2).HeaderText = "Type"
        AssignedPaymentsDataGridView.Columns(3).HeaderText = "Item"
        AssignedPaymentsDataGridView.Columns(3).Width = 200
        AssignedPaymentsDataGridView.Columns(4).HeaderText = "Amount"

    End Sub

    Private Sub GridPayments_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles AssignedPaymentsDataGridView.CellFormatting, SearchPaymentsDataGridView.CellFormatting
        ' Skip if empty row
        If Not (IsDBNull(e.Value) Or e.Value Is Nothing) Then

            If e.ColumnIndex = 2 Then
                ' Uppercase the type
                Dim type As String = e.Value
                e.Value = UCase(type.Substring(0, 1)) + type.Substring(1)
            ElseIf e.ColumnIndex = 3 Then
                ' Get a name for the payment item
                Dim id As Integer = e.Value
                Dim Payments = I.Payments
                e.Value = Payments.getItemName(sender.Rows(e.RowIndex).Cells(2).Value, id)
            ElseIf e.ColumnIndex = 4 Then
                ' Convert to currency
                Dim total As Double = e.Value
                e.Value = "" + total.ToString("C2")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RemovePaymentButton.Click
        ' Verify with the user
        Dim result = MsgBox("Are you sure you want to remove this payment?", MsgBoxStyle.YesNo)

        If result = DialogResult.Yes Then
            ' Set transaction id to 0
            Dim data = New Dictionary(Of String, Object)
            data("transaction_id") = 0

            Dim id = AssignedPaymentsDataGridView.CurrentRow.Cells(0).Value

            Dim DB = I.DB

            ' Edit the payment
            DB.edit("payments", id, data)

            ' Subtract the amount from the transactions total
            Dim amount = DB.getRecord("transactions", transactionId)("total") - DB.getRecord("payments", id)("amount")
            data = New Dictionary(Of String, Object)
            data("total") = amount
            DB.edit("transactions", transactionId, data)

            ' Update the table
            refreshPayments()
            refreshSearch()
        End If
    End Sub

    Public Sub refreshSearch()
        Dim DB = I.DB

        ' Get the club id
        Dim transaction = DB.getRecord("transactions", transactionId)
        Dim clubId = transaction("club_id")

        ' Generate the SQL
        Dim SQL = "SELECT payments.id, (users.first_name || "" "" || users.last_name) As name, payments.item_type, payments.item_id, payments.amount FROM users, payments WHERE "
        SQL += "payments.user_id = users.id AND "
        SQL += "payments.transaction_id = 0 AND "
        SQL += "payments.club_id = " + clubId.ToString() + " "
        ' Only filter if text valid
        If FirstNameTextBox.Text.Trim() <> "" Then
            SQL += " AND users.first_name LIKE ""%" + FirstNameTextBox.Text + "%"""
        End If
        If LastNameTextBox.Text.Trim() <> "" Then
            SQL += " AND users.last_name LIKE ""%" + LastNameTextBox.Text + "%"""
        End If

        ' Get the query
        Dim data = DB.GetQuery(SQL)

        ' Load to the datagridview
        SearchPaymentsDataGridView.DataSource = data

        ' Set the columns
        SearchPaymentsDataGridView.Columns(0).HeaderText = "ID"
        SearchPaymentsDataGridView.Columns(0).Width = 50
        SearchPaymentsDataGridView.Columns(1).HeaderText = "Name"
        SearchPaymentsDataGridView.Columns(2).HeaderText = "Type"
        SearchPaymentsDataGridView.Columns(3).HeaderText = "Item"
        SearchPaymentsDataGridView.Columns(3).Width = 200
        SearchPaymentsDataGridView.Columns(4).HeaderText = "Amount"
    End Sub

    Private Sub InpFirstName_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
        ' Redo search on edit box change
        refreshSearch()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddPaymentButton.Click

        ' Set transaction id to this transaction
        Dim data = New Dictionary(Of String, Object)
        data("transaction_id") = transactionId

        Dim id = SearchPaymentsDataGridView.CurrentRow.Cells(0).Value

        Dim DB = I.DB

        DB.edit("payments", id, data)

        ' Add the amount to the total
        Dim amount = DB.getRecord("transactions", transactionId)("total") + DB.getRecord("payments", id)("amount")
        data = New Dictionary(Of String, Object)
        data("total") = amount
        DB.edit("transactions", transactionId, data)

        ' Refresh the tables
        refreshPayments()
        refreshSearch()
    End Sub

    Private Sub InpLastName_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged
        ' Refresh the search when the input box is changed
        refreshSearch()
    End Sub

End Class