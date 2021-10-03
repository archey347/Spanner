Public Class ClubMembershipRequestsForm

    Private I As App.Injector

    Public clubId As Integer

    Private Sub ClubMembershipRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get Services Injector
        I = My.Application.I

        ' Refresh table
        refreshRequests()
    End Sub

    Private Sub refreshRequests()
        ' Generate SQL
        Dim SQL = "SELECT membership_requests.id, users.first_name, users.last_name, membership_types.name, membership_requests.time_submitted FROM membership_requests, memberships, users, membership_types WHERE "
        SQL += "membership_requests.type_id = membership_types.id AND "
        SQL += "membership_requests.membership_id = memberships.id AND "
        SQL += "memberships.user_id = users.id AND "
        SQL += "membership_requests.is_approved = 0 AND "
        SQL += "membership_requests.is_rejected = 0 AND "
        SQL += "memberships.club_id = " + clubId.ToString()

        Dim DB = I.DB

        ' Get the data
        Dim data = DB.getQuery(SQL)

        ' Load to grid
        MembershipRequestsDataGridView.DataSource = data

        ' Set columns
        MembershipRequestsDataGridView.Columns(0).HeaderText = "ID"
        MembershipRequestsDataGridView.Columns(0).Width = 50
        MembershipRequestsDataGridView.Columns(1).HeaderText = "First Name"
        MembershipRequestsDataGridView.Columns(2).HeaderText = "Last Name"
        MembershipRequestsDataGridView.Columns(3).HeaderText = "Type"
        MembershipRequestsDataGridView.Columns(4).HeaderText = "Time"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        ' Get forms service
        Dim Forms = I.Forms
        ' Show form
        Forms.showClubMembershipRequestNew(clubId)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles ApproveButton.Click
        ' Get forms and DB service
        Dim Forms = I.Forms
        Dim DB = I.DB

        ' Get related entities
        Dim membership_request = DB.getRecord("membership_requests", MembershipRequestsDataGridView.CurrentRow.Cells(0).Value)
        Dim membership = DB.getRecord("memberships", membership_request("membership_id"))

        Dim expires = New Date(membership("expires"))

        Dim suggestedExpiry = Now()

        If (expires > suggestedExpiry) Then
            ' If membership hasn't expired yet, use expiry date
            suggestedExpiry = expires
        End If

        ' Add a year onto suggested expiry
        suggestedExpiry = suggestedExpiry.AddYears(1)

        ' Ask user to select date
        expires = Forms.selectDate("Select an expiry date", suggestedExpiry)

        If expires = Nothing Then
            Exit Sub
        ElseIf expires < Now() Then
            MsgBox("The expiry date must be after today")
            Exit Sub
        End If

        Dim data = New Dictionary(Of String, Object)
        data("is_approved") = 1

        ' Save to database
        DB.edit("membership_requests", membership_request("id"), data)

        ' Update membership expiry date and type
        data = New Dictionary(Of String, Object)
        data("expires") = expires.Ticks()
        data("type_id") = membership_request("type_id")

        ' Save
        DB.edit("memberships", membership_request("membership_id"), data)

        refreshRequests()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MembershipRequestsDataGridView.CellFormatting
        ' Format date col
        If e.ColumnIndex = 4 Then
            Dim submitted = New DateTime(e.Value)
            e.Value = submitted.ToShortTimeString() + " " + submitted.ToShortDateString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RejectButton.Click
        Dim data = New Dictionary(Of String, Object)
        data("is_rejected") = 1

        Dim DB = I.DB

        ' Save to database
        DB.edit("membership_requests", MembershipRequestsDataGridView.CurrentRow.Cells(0).Value, data)

        ' refresh table
        refreshRequests()
    End Sub

    Private Sub ClubMembershipRequests_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh table when the form is put into focus
        refreshRequests()
    End Sub

End Class