Public Class ClubAssignRolesForm
    Public clubId As Integer
    Public roleId As Integer

    Private I As App.Injector

    Public notIn As String

    Private Sub ClubAssignRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the service injector
        I = My.Application.I

        ' refresh the tables
        refreshAssignedUsers()
        searchUsers()

    End Sub

    Private Sub refreshAssignedUsers()
        ' Generate SQL
        Dim SQL = "SELECT roles_users_clubs.id, users.id As user_id, users.first_name, users.last_name FROM roles_users_clubs, users WHERE "
        SQL += "roles_users_clubs.user_id = users.id AND "
        SQL += "roles_users_clubs.club_id = " + clubId.ToString() + " AND "
        SQL += "roles_users_clubs.role_id = " + roleId.ToString()

        Dim DB = I.DB

        ' Get data
        Dim data = DB.GetQuery(SQL)

        ' Load data
        AssignedUsersDataGridView.DataSource = data

        ' Add columns
        AssignedUsersDataGridView.Columns(0).HeaderText = "ID"
        AssignedUsersDataGridView.Columns(0).Width = 50
        AssignedUsersDataGridView.Columns(1).HeaderText = "User ID"
        AssignedUsersDataGridView.Columns(1).Width = 50
        AssignedUsersDataGridView.Columns(2).HeaderText = "First Name"
        AssignedUsersDataGridView.Columns(3).HeaderText = "Last Name"

        notIn = "("
        For Each row In data.Rows
            If notIn <> "(" Then
                notIn += ","
            End If
            notIn += row("user_id").ToString()
        Next

        notIn += ")"

    End Sub

    Private Sub searchUsers()
        Dim DB = I.DB

        Dim SQL = "SELECT users.id, users.first_name, users.last_name FROM users, memberships WHERE "
        SQL += "memberships.user_id = users.id"
        SQL += " AND memberships.club_id = " + clubId.ToString()
        SQL += " AND users.id NOT IN " + notIn
        ' Only filter if text valid
        If FirstNameTextBox.Text.Trim() <> "" Then
            SQL += " AND users.first_name LIKE ""%" + FirstNameTextBox.Text + "%"""
        End If
        If LastNameTextBox.Text.Trim() <> "" Then
            SQL += " AND users.last_name LIKE ""%" + LastNameTextBox.Text + "%"""
        End If

        ' Get the data
        Dim data = DB.GetQuery(SQL)

        ' Load to grid
        SearchUsersDataGridView.DataSource = data

        ' Set columns
        SearchUsersDataGridView.Columns(0).HeaderText = "ID"
        SearchUsersDataGridView.Columns(0).Width = 50
        SearchUsersDataGridView.Columns(1).HeaderText = "First Name"
        SearchUsersDataGridView.Columns(2).HeaderText = "Last Name"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged, LastNameTextBox.TextChanged
        searchUsers()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        ' Get the id of the user
        Dim userId = SearchUsersDataGridView.CurrentRow.Cells(0).Value

        ' Create the new perm record
        Dim data = New Dictionary(Of String, Object)
        data("user_id") = userId
        data("role_id") = roleId
        data("club_id") = clubId

        Dim DB = I.DB

        ' Save to database
        DB.insert("roles_users_clubs", data)

        ' Refresh tables
        refreshAssignedUsers()
        searchUsers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RemoveUserButton.Click
        ' Get the id of the row to delete
        Dim rowId = AssignedUsersDataGridView.CurrentRow.Cells(0).Value

        ' Double check with the user they want to delete
        If MsgBox("Are you sure you want to remove this role?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            Dim DB = I.DB

            DB.delete("roles_users_clubs", rowId)
        End If

        ' Refresh table
        refreshAssignedUsers()
        searchUsers()

    End Sub

End Class