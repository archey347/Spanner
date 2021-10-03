Namespace App
    ' This service will store any required session data, such as the id of the user that is logged in
    Public Class Session

        ' Authentication Service
        Public Authentication As App.Authentication

        ' Place to store the user
        Public user As DataRow

        Public Sub New(Authentication As App.Authentication)
            Me.Authentication = Authentication
        End Sub

        ' lgin
        ' Check if the given user credentials are correct, and set session if credentials are correct
        '
        ' String userIdentifier - An email address or username
        ' String password       - A password
        '
        ' Returns true on success
        Public Function login(userIdentifier As String, password As String)
            user = Authentication.checkCredentials(userIdentifier, password)

            ' Return false if authentication failed
            Return Not (user Is Nothing)
        End Function

        ' logout
        ' Remove the logged in user from the session
        Public Sub logout()
            ' Clear the user from the session
            user = Nothing
        End Sub

    End Class

End Namespace