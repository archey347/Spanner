Public Class PersonalMembershipForm

    Public userId As Integer
    Public user As DataRow

    Public I As App.Injector

    Private Sub PersonalMembership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the injector service
        I = My.Application.I
        ' Refresh the table
        refreshTable()

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MembershipsDataGridView.CellFormatting
        If e.ColumnIndex = 3 Then
            ' If date field, format the data
            Dim expires = New DateTime(CLng(e.Value))
            e.Value = expires.ToShortDateString()
        ElseIf {4, 5}.Contains(e.ColumnIndex) Then
            ' If boolean field, then convert to a readable yes/no
            If e.Value = 0 Then
                e.Value = "No"
            Else
                e.Value = "Yes"
            End If
        End If
    End Sub

    Public Sub refreshTable()
        Dim DB = I.DB

        user = DB.getRecord("users", userId)

        ' Load the memberships
        ' Gen SQL
        Dim SQL As String
        SQL = "SELECT memberships.id, clubs.club_name, membership_types.name, memberships.expires, memberships.is_banned, memberships.is_canceled "
        SQL += "FROM memberships, clubs, membership_types WHERE "
        SQL += "memberships.type_id = membership_types.id AND "
        SQL += "memberships.club_id = clubs.id AND "
        SQL += "memberships.is_canceled = 0 AND "
        SQL += "memberships.user_id = " + userId.ToString()

        ' Get data from db
        Dim memberships As DataTable = DB.GetQuery(SQL)

        MembershipsDataGridView.DataSource = memberships

        ' Add the columns
        MembershipsDataGridView.Columns(0).HeaderText = "ID"
        MembershipsDataGridView.Columns(1).HeaderText = "Club Name"
        MembershipsDataGridView.Columns(1).Width = 200
        MembershipsDataGridView.Columns(2).HeaderText = "Type"
        MembershipsDataGridView.Columns(3).HeaderText = "Expires"
        MembershipsDataGridView.Columns(4).HeaderText = "Is Banned"
        MembershipsDataGridView.Columns(5).HeaderText = "Is Canceled"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        ' Get the form service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showPersonalNewMembership(userId)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RenewButton.Click
        ' Get the form service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showPersonalMembershipRenew(MembershipsDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub PersonalMembership_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh the table if the form becomes active again
        refreshTable()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showPersonalMembershipRequests(MembershipsDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dim id = MembershipsDataGridView.CurrentRow.Cells(0).Value
        ' Verify with the user
        If MsgBox("Are you sure you want to cancel your membership?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            ' Cancel the membership
            Dim data = New Dictionary(Of String, Object)
            data("is_canceled") = 1
            Dim DB = I.DB
            DB.edit("memberships", id, data)
            refreshTable()
        End If
    End Sub

End Class