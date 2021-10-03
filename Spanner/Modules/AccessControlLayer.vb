Namespace App
    ' This module is responsible for checking that a user is authorized to access the different sections
    Public Class AccessControlLayer

        Public DB As App.Database
        Public Membership As App.Membership

        Public Sub New(DB As App.Database, Membership As App.Membership)
            ' Add required services
            Me.DB = DB
            Me.Membership = Membership
        End Sub

        ' getAdminClubs
        ' Get a list of clubs the user has admin access to
        '
        ' Integer userId - The user to check for
        '
        ' Returns an array of clubs
        Public Function getAdminClubs(userId As Integer)
            ' Generate SQL
            Dim SQL = ""

            ' Check if admin user
            Dim user = DB.getRecord("users", userId)

            If user("is_admin") = 1 Then
                ' Just give all of the clubs
                SQL = "SELECT * FROM clubs"
            Else
                ' Only show the clubs the user has an admin permission for
                SQL = "SELECT DISTINCT clubs.id, clubs.club_name FROM clubs, roles_users_clubs "
                SQL += "WHERE clubs.id = roles_users_clubs.club_id AND roles_users_clubs.user_id = " + userId.ToString()
            End If

            Dim table = DB.GetQuery(SQL)
            ' Create new empty table to edit
            Dim result As DataTable = table.Copy()
            result.Rows.Clear()

            ' Loop through each club
            If user("is_admin") = 0 Then
                ' Not a system admin, so needs to look at roles
                For Each club As DataRow In table.Rows
                    Dim membership = Me.Membership.getMembership(userId, club("id"), True, True)

                    ' If is a valid member, add to result
                    If Not membership Is Nothing Then
                        result.Rows.Add(club.ItemArray)
                    End If

                Next
            Else
                ' If the user is a system admin, return all of the users
                result = table
            End If

            Return result

        End Function

        ' hasRole
        ' Check to see if a user has a role for a specific club
        '
        ' Integer userId - The user to check on
        ' Integer clubId - The club being checked access for
        ' Integer roleId - The role being checked access for
        '
        ' Returns true if authorized
        Public Function hasRole(userId As Integer, clubId As Integer, roles As String())
            ' Make sure the user isn't an admin
            Dim user = DB.getRecord("users", userId)
            If user("is_admin") Then
                ' Always return true if system admin
                Return True
            End If

            ' Make sure the user is a valid member of the club
            Dim membership = Me.Membership.getMembership(userId, clubId, True, True)

            If membership Is Nothing Then
                ' Fail if their membership is invalid
                Return False
            End If

            ' Convert array to SQL
            Dim rolesSQL As String = "("

            For Each role In roles
                ' Add comma if not empty
                If rolesSQL <> "(" Then
                    rolesSQL += ", "
                End If

                ' Add role
                rolesSQL += "'" + role + "'"
            Next

            rolesSQL += ")"

            Dim SQL = "SELECT * FROM roles_users_clubs, roles, memberships WHERE "
            SQL += "roles.id = roles_users_clubs.role_id And "
            SQL += "roles_users_clubs.user_id = " + userId.ToString() + " And "
            SQL += "roles.name In " + rolesSQL

            ' Execute Query
            Dim table As DataTable = DB.GetQuery(SQL)

            ' Return true if they have a database entry matching the club, user and role
            Return table.Rows.Count > 0
        End Function

    End Class

End Namespace