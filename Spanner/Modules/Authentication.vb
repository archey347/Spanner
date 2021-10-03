Namespace App
    ' This service handles any user authentication processing
    Public Class Authentication

        Public Database As App.Database
        Public Hasher As BCrypt.Net.BCrypt

        Public Sub New(Database As App.Database, Hasher As BCrypt.Net.BCrypt)
            ' Load any required services
            Me.Database = Database
            Me.Hasher = Hasher
        End Sub

        ' getUser
        ' Check to see if a user exists
        '
        ' String userIdentifier - An email or username to try
        '
        ' Returns a user if successful
        Public Function getUser(userIdentifier As String) As DataRow
            Dim fieldName As String
            ' Test whether it is an email address
            If App.Validation.testEmail(userIdentifier) Then
                ' It is, so search in the email address column
                fieldName = "email_address"
            Else
                ' It isn't, so search in the username column
                fieldName = "username"
            End If

            ' Generate the SQL
            Dim SQL As String = "SELECT * FROM users WHERE "
            SQL += fieldName + " = '" + userIdentifier + "'"

            ' Send Query
            Dim table As DataTable = Database.GetQuery(SQL)

            ' Check if any records returned
            If table.Rows.Count = 0 Then
                ' Return nothing if no user has been found
                Return Nothing
            End If

            ' Return user if one has been found
            Return table.Rows(0)
        End Function

        ' checkCredentials
        ' Check if the given user credentials are correct
        '
        ' String userIdentifier - An email address or username
        ' String password       - A password
        '
        ' Returns a user record on success, or Nothing if failed
        Public Function checkCredentials(userIdentifier As String, password As String) As DataRow

            ' Get the user from the database
            Dim user As DataRow = getUser(userIdentifier)

            ' User does not exist, so return nothing
            If user Is Nothing Then
                Return Nothing
            End If

            ' Check the password
            If Me.Hasher.Verify(password, user("password")) Then
                ' Return the user if the password is correct
                Return user
            End If

            ' Return nothing if the password is incorrect
            Return Nothing

        End Function

    End Class

End Namespace