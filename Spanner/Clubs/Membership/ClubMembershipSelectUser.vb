Imports Spanner.My

Public Class ClubMembershipSelectUser

    Public clubId As Integer

    Private I As App.Injector

    Private Sub ClubMembershipSelectUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the service injector
        I = My.Application.I

        ' Refresh the user selection box
        refresh()
    End Sub

    Public Sub refresh()
        ' Get the DB service
        Dim DB = I.DB

        ' Get a list of users who have a membership
        Dim usersSQL = "SELECT user_id FROM memberships WHERE club_id = " + clubId.ToString()

        ' Generate the SQL
        Dim SQL = "SELECT id, first_name, last_name, address_postcode FROM users WHERE NOT id IN (" + usersSQL + ")"
        If FilterFirstNameTextBox.Text.Trim <> "" Then
            SQL += " AND first_name = " + FilterFirstNameTextBox.Text
        End If

        If FilterLastNameTextBox.Text.Trim <> "" Then
            SQL += " AND last_name = " + FilterLastNameTextBox.Text
        End If

        ' Run the query
        Dim data = DB.getQuery(SQL)

        ' Load into the grid
        UsersDataGridView.DataSource = data

        ' Set the columns
        UsersDataGridView.Columns(0).Width = 50
        UsersDataGridView.Columns(0).HeaderText = "ID"
        UsersDataGridView.Columns(0).HeaderText = "First Name"
        UsersDataGridView.Columns(0).HeaderText = "Last Name"
        UsersDataGridView.Columns(0).HeaderText = "Postcode"

    End Sub

    Private Sub FilterFirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FilterFirstNameTextBox.TextChanged, FilterLastNameTextBox.TextChanged
        ' Refresh the table when the search has been changed
        refresh()
    End Sub

    Private Sub UsersDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellDoubleClick
        ' Load selected user into input boxes
        IDTextBox.Text = UsersDataGridView.Rows(e.RowIndex).Cells(0).Value
        FirstNameTextBox.Text = UsersDataGridView.Rows(e.RowIndex).Cells(1).Value
        LastNameTextBox.Text = UsersDataGridView.Rows(e.RowIndex).Cells(2).Value

    End Sub
End Class