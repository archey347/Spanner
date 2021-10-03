Public Class PersonalNewMembershipForm

    Public userId As Integer

    Private I As App.Injector

    Public Sub refreshTable()
        Dim DB = I.DB

        ' Get list of clubs
        Dim clubs = DB.GetQuery("SELECT clubs.id, clubs.club_name FROM clubs WHERE is_deleted = 0")

        ' Load data into table and edit the columns
        ClubsDataGridView.DataSource = clubs
        ClubsDataGridView.Columns(0).HeaderText = "ID"
        ClubsDataGridView.Columns(0).Width = 50
        ClubsDataGridView.Columns(1).HeaderText = "Club Name"
        ClubsDataGridView.Columns(1).Width = 200

    End Sub

    Private Sub PersonalNewMembership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the service injector
        I = My.Application.I


        ' Refresh the table
        refreshTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClubsDataGridView.CellClick
        ' On cell click, change the selected club
        IDTextBox.Text = ClubsDataGridView.CurrentRow.Cells(0).Value
        NameTextBox.Text = ClubsDataGridView.CurrentRow.Cells(1).Value

        ' SQL for getting membership types
        Dim Sql = "SELECT membership_types.id, (membership_types.name || "" (£"" || (membership_types.price + membership_types.join_price) || "")"") As display FROM membership_types WHERE membership_types.club_id = " + IDTextBox.Text

        Dim DB = I.DB

        ' Get data
        Dim table = DB.GetQuery(Sql)

        ' Load membership types into the select box
        MembershipTypeComboBox.DataSource = table
        MembershipTypeComboBox.DisplayMember = "display"
        MembershipTypeComboBox.ValueMember = "id"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Check that they are not already a member
        Dim SQL = "SELECT * FROM memberships WHERE "
        SQL += "user_id = " + userId.ToString()
        SQL += " AND club_id = " + IDTextBox.Text

        Dim DB = I.DB

        Dim memberships = DB.GetQuery(SQL)

        If memberships.Rows.Count > 0 Then
            ' Membership already exists
            Dim membership = memberships.Rows(0)
            If membership("is_canceled") = 1 Then
                MsgBox("You already have an existing membership with this club except that it has been canceled. Please contact the membership secretary to uncancel it")
            Else
                MsgBox("You already have a membership with this club")
            End If
            Exit Sub
        End If

        Dim user = DB.getRecord("users", userId)

        ' Create new membership
        Dim data = New Dictionary(Of String, Object)
        data("user_id") = userId
        data("club_id") = IDTextBox.Text
        data("type_id") = MembershipTypeComboBox.SelectedValue
        data("expires") = user("date_of_birth")
        data("is_banned") = 0
        data("is_canceled") = 0

        Dim membershipId = DB.insert("memberships", data)

        ' Create a new membership request
        data = New Dictionary(Of String, Object)

        data("membership_id") = membershipId
        data("request_type") = "renew"
        data("type_id") = MembershipTypeComboBox.SelectedValue
        data("time_submitted") = Now().Ticks()
        data("is_approved") = 0
        data("is_rejected") = 0

        ' Save to database
        DB.insert("membership_requests", data)

        MsgBox("Your membership request has been sent")

        Me.Close()

    End Sub

End Class