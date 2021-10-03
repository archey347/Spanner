Namespace App

    Public Class Membership

        Public DB As App.Database

        Public Sub New(DB As App.Database)
            ' Load the database service
            Me.DB = DB
        End Sub

        ' getMembership
        ' Get a membership
        '
        ' Integer userId    - The id of the user
        ' Integer clubId    - The id of the club
        ' Boolean isAllowed - should the user be not banned/canceled
        ' Boolean isActive  - should the user not be expired
        Public Function getMembership(userId As Integer, clubId As Integer, isAllowed As Boolean, isActive As Boolean) As DataRow
            ' Generate SQL
            Dim SQL = "SELECT * FROM users, memberships WHERE "
            SQL += "users.id = memberships.user_id AND "
            SQL += "memberships.user_id = " + userId.ToString() + " AND "
            SQL += "memberships.club_id = " + clubId.ToString() + " "

            ' If isActive required, add expires condition
            If isActive Then
                SQL += "AND memberships.expires > " + Now.Ticks.ToString() + " "
            End If

            ' if isAllowed required, check for banend and cancelation status
            If isAllowed Then
                SQL += "AND memberships.is_banned = 0 "
                SQL += "AND memberships.canceled = 0"
            End If

            ' Run query
            Dim records = DB.GetQuery(SQL)

            ' Return nothing if no records returned
            If records.Rows.Count = 0 Then
                Return Nothing
            End If

            Return records.Rows(0)
        End Function

        ' getClubs
        ' Get the clubs a user is a member of
        '
        ' Integer userId - The id of the user to check
        '
        ' Returns a DataTable of clubs
        Public Function getClubs(userId As Integer) As DataTable
            ' Generate SQL
            Dim SQL = "SELECT clubs.* FROM memberships, clubs WHERE "
            SQL += " Clubs.id = memberships.club_id AND"
            SQL += " memberships.user_id = " + userId.ToString()

            ' Execute
            Return DB.getQuery(SQL)
        End Function

    End Class

End Namespace