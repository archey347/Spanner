Public Class PersonalMembershipRequestsForm

    Public membershipId As Integer

    Private I As App.Injector

    Private Sub PersonalMembershipRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the injector interface
        I = My.Application.I

        ' Refresh the table
        refreshTable()
    End Sub

    Private Sub refreshTable()
        Dim DB = I.DB

        ' Generate the SQL for the table
        Dim SQL = "SELECT membership_requests.id, membership_types.name, membership_requests.time_submitted, membership_requests.is_approved, membership_requests.is_rejected FROM membership_requests, membership_types WHERE "
        SQL += "membership_requests.type_id = membership_types.id ORDER BY membership_requests.time_submitted DESC"

        ' Get the data
        Dim data = DB.GetQuery(SQL)

        ' Load data into the table
        RequestsDataGridView.DataSource = data
        RequestsDataGridView.Columns(0).HeaderText = "ID"
        RequestsDataGridView.Columns(1).HeaderText = "Type"
        RequestsDataGridView.Columns(2).HeaderText = "Time Submitted"
        RequestsDataGridView.Columns(3).HeaderText = "Is Accepted"
        RequestsDataGridView.Columns(4).HeaderText = "Is Rejected"

    End Sub

    Private Sub PersonalMembershipRequests_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ' Refresh the table when the form comes into focus
        refreshTable()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles RequestsDataGridView.CellFormatting
        If e.ColumnIndex = 2 Then
            ' Date column, convert to readable date
            Dim submitted = New Date(e.Value)
            e.Value = submitted.ToShortDateString()
        ElseIf {3, 4}.Contains(e.ColumnIndex) Then
            ' Boolean column, convert to yes/no
            If e.Value = "0" Then
                e.Value = "No"
            Else
                e.Value = "Yes"
            End If
        End If
    End Sub

End Class