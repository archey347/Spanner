Public Class ClubMembershipRequestNewForm

    Private I As App.Injector

    Public clubId As Integer
    Public membershipId As Integer = 0

    Private Sub ClubMembershipRequestNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = My.Application.I

        Dim DB = I.DB

        ' If membership not set, get user to select one
        If membershipId = 0 Then
            refreshUsers()
            RequestTypeComboBox.Text = "New"
        Else
            DataGridView1.Enabled = False
            ' Get membership and display
            Dim membership = DB.getRecord("memberships", membershipId)
            Dim user = DB.getRecord("users", membership("user_id"))
            Dim type = DB.getRecord("membership_types", membership("type_id"))
            IDTextBox.Text = membership("id")
            FirstNameTextBox.Text = user("first_name")
            LastNameTextBox.Text = user("last_name")
            TypeTextBox.Text = type("name")

        End If

        refreshTypes()

    End Sub

    Public Sub refreshUsers()
        ' Generate SQL
        Dim SQL = "SELECT memberships.id, users.first_name, users.last_name, membership_types.name, memberships.expires "
        SQL += "FROM memberships, users, membership_types WHERE "
        SQL += "memberships.user_id = users.id and "
        SQL += "memberships.type_id = membership_types.id and "
        SQL += "memberships.expires < " + Now().Ticks().ToString()
        ' Only filter if text valid
        If FilterFirstNameTextBox.Text.Trim() <> "" Then
            SQL += " AND users.first_name LIKE ""%" + FilterFirstNameTextBox.Text + "%"""
        End If
        If FilterLastNameTextBox.Text.Trim() <> "" Then
            SQL += " AND users.last_name LIKE ""%" + FilterLastNameTextBox.Text + "%"""
        End If
        SQL += " AND memberships.club_id = " + clubId.ToString()

        Dim DB = I.DB

        ' Get the data
        Dim data = DB.getQuery(SQL)

        ' Load into grid view
        DataGridView1.DataSource = data

        ' Set the columns
        DataGridView1.Columns(0).HeaderText = "Membership ID"
        DataGridView1.Columns(1).HeaderText = "First Name"
        DataGridView1.Columns(2).HeaderText = "Last Name"
        DataGridView1.Columns(3).HeaderText = "Type"
        DataGridView1.Columns(4).HeaderText = "Expires"

    End Sub

    Public Sub refreshTypes()
        ' Generate the SQL
        Dim SQL = ""
        ' Add join fee to price if not a renewal
        If RequestTypeComboBox.SelectedItem = "Renew" Then
            SQL = "SELECT membership_types.id, (membership_types.name || "" (£"" || membership_types.price || "")"") As display FROM membership_types WHERE membership_types.club_id = " + clubId.ToString()
        Else
            SQL = "SELECT membership_types.id, (membership_types.name || "" (£"" || (membership_types.price + membership_types.join_price) || "")"") As display FROM membership_types WHERE membership_types.club_id = " + clubId.ToString()
        End If

        Dim DB = I.DB

        ' Get data
        Dim table = DB.getQuery(SQL)

        ' Update the membership type selection box
        MembershipTypeComboBox.DataSource = table
        MembershipTypeComboBox.DisplayMember = "display"
        MembershipTypeComboBox.ValueMember = "id"

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 4 Then
            If IsDBNull(e.Value) Then
                ' Ignore empty rows
                e.Value = ""
            Else
                ' Convert to a readable date value
                Dim expires = New Date(e.Value)
                e.Value = expires.ToShortDateString()
            End If
        End If
    End Sub

    Private Sub FilterFirstName_TextChanged(sender As Object, e As EventArgs) Handles FilterFirstNameTextBox.TextChanged
        ' Redo search on textbox change
        refreshUsers()
    End Sub

    Private Sub FilterLastName_TextChanged(sender As Object, e As EventArgs) Handles FilterLastNameTextBox.TextChanged
        ' Redo search on textbox change
        refreshUsers()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Update selected member on grid click
        IDTextBox.Text = DataGridView1.CurrentRow.Cells(0).Value
        FirstNameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value
        LastNameTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value
        TypeTextBox.Text = DataGridView1.CurrentRow.Cells(3).Value

        Dim DB = I.DB

        ' Get the membership
        Dim membership = DB.getRecord("memberships", IDTextBox.Text.ToString())

        If membership("type_id") <> 0 Then
            ' If there is an existing membership type, select that as the default value
            MembershipTypeComboBox.SelectedValue = membership("type_id")
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ' Make sure a member is selected
        If IDTextBox.Text = "" Then
            MsgBox("Please select a member")
            Exit Sub
        End If

        Dim DB = I.DB

        ' Get the membership
        Dim membership = DB.getRecord("memberships", IDTextBox.Text.ToString())

        ' Create request
        Dim data = New Dictionary(Of String, Object)

        data("membership_id") = membership("id")
        If RequestTypeComboBox.Text = "Renew" Then
            data("request_type") = "renew"
        Else
            data("request_type") = "new"
        End If
        data("type_id") = MembershipTypeComboBox.SelectedValue
        data("time_submitted") = Now().Ticks
        data("is_approved") = 0
        data("is_rejected") = 0

        ' Save data
        Dim id = DB.insert("membership_requests", data)

        ' Get membership type
        Dim type = DB.getRecord("membership_types", MembershipTypeComboBox.SelectedValue)

        Dim price = 0

        If RequestTypeComboBox.Text = "Renew" Then
            price = type("price")
        Else
            price = type("price") + type("join_price")
        End If

        Dim Payments = I.Payments

        Payments.create(membership("user_id"), membership("club_id"), price, "membership", id)

        ' Close
        Me.Close()

        MsgBox("The user has been added. Please approve in the membership requests window")

    End Sub

    Private Sub InpRequestType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles RequestTypeComboBox.SelectionChangeCommitted
        ' Redo search on request type change
        refreshTypes()

    End Sub

End Class