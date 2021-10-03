Public Class PersonalDetailsForm
    Public userId As Integer
    Public user As DataRow

    Public I As App.Injector

    Private Sub PersonalDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = My.Application.I

        ' Get the database
        Dim DB = I.DB
        Dim Hasher = I.Hasher
        Dim Authentication = I.Authentication

        ' Check if the id is zero, if it is then edit
        If userId <> 0 Then
            ' Create the query
            Dim SQL As String = "SELECT * FROM users WHERE "
            SQL += " id = '" + userId.ToString() + "'"

            ' Execute
            Dim table As DataTable = DB.GetQuery(SQL)

            ' In edit mode, so must populate fields
            user = table.Rows(0)

            FirstNameTextBox.Text = user("first_name")
            LastNameTextBox.Text = user("last_name")
            GenderComboBox.Text = user("gender")
            ' Put into variable for variable type
            Dim dob As Long = user("date_of_birth")
            DateOfBirthDateTimePicker.Value = New Date(dob)

            Line1TextBox.Text = user("address_line_1")
            Line2TextBox.Text = user("address_line_2")
            Line3TextBox.Text = user("address_line_3")
            TownTextBox.Text = user("address_town")
            CountyTextBox.Text = user("address_county")
            PostcodeTextBox.Text = user("address_postcode")

            EmailTextBox.Text = user("email_address")
            PhoneTextBox.Text = user("phone_number")
            AltPhoneTextBox.Text = user("alt_phone_number")

            UsernameTextBox.Text = user("username")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Function validateForm() As Boolean
        Try
            App.Validation.validateField(FirstNameTextBox.Text, "First Name", New Dictionary(Of String, Object) From {{"required", Nothing}})
            App.Validation.validateField(LastNameTextBox.Text, "Last Name", New Dictionary(Of String, Object) From {{"required", Nothing}})
            App.Validation.validateField(GenderComboBox.Text, "Gender", New Dictionary(Of String, Object) From {{"is_in", {"Male", "Female", "Other"}}})
            App.Validation.validateField(DateOfBirthDateTimePicker.Value, "Date of Birth", New Dictionary(Of String, Object) From {{"<", Now()}})

            App.Validation.validateField(Line1TextBox.Text, "Address Line 1", New Dictionary(Of String, Object) From {{"required", Nothing}})
            App.Validation.validateField(TownTextBox.Text, "Address Town", New Dictionary(Of String, Object) From {{"required", Nothing}})
            App.Validation.validateField(PostcodeTextBox.Text, "Address Postcode", New Dictionary(Of String, Object) From {{"required", Nothing}})

            App.Validation.validateField(EmailTextBox.Text, "Email Address", New Dictionary(Of String, Object) From {{"required", Nothing}, {"email", Nothing}})
            App.Validation.validateField(PhoneTextBox.Text, "Phone Number", New Dictionary(Of String, Object) From {{"required", Nothing}})
            App.Validation.validateField(AltPhoneTextBox.Text, "Alternative Phone Number", New Dictionary(Of String, Object) From {{"required", Nothing}})

            App.Validation.validateField(UsernameTextBox.Text, "Username", New Dictionary(Of String, Object) From {{"required", Nothing}})

            ' Require password if creating a new user
            If userId = 0 Then
                App.Validation.validateField(PasswordTextBox.Text, "Password", New Dictionary(Of String, Object) From {{"required", Nothing}})
            End If

            Dim Authentication = I.Authentication

            ' Uniqueness checks for the username and email fields
            Dim user As DataRow
            user = Authentication.getUser(EmailTextBox.Text)

            ' Check if there is a user
            If (Not user Is Nothing) Then
                ' Check that it isn't the current user
                If user("id") <> userId Then
                    Throw New System.Exception("A user with that email address already exists")
                End If
            End If

            ' Do the same with the username
            user = Authentication.getUser(UsernameTextBox.Text)
            If (Not user Is Nothing) Then
                ' Check that the found user isnt the current user
                If user("id") <> Me.userId Then
                    Throw New System.Exception("A user with that username already exists")
                End If
            End If

            ' Check the password fields are the same and are of appropriate length
            If PasswordTextBox.Text <> "" Or RetypePasswordTextBox.Text <> "" Then
                App.Validation.validateField(PasswordTextBox.Text, "Password", New Dictionary(Of String, Object) From {{"min_length", 8}})

                If PasswordTextBox.Text <> RetypePasswordTextBox.Text Then
                    Throw New System.Exception("The passwords do not match")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ' Validate the form
        If validateForm() Then
            ' Put data into dictionary
            Dim data As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            data("first_name") = FirstNameTextBox.Text
            data("last_name") = LastNameTextBox.Text
            data("gender") = GenderComboBox.Text
            data("date_of_birth") = DateOfBirthDateTimePicker.Value.Ticks
            data("address_line_1") = Line1TextBox.Text
            data("address_line_2") = Line2TextBox.Text
            data("address_line_3") = Line3TextBox.Text
            data("address_town") = TownTextBox.Text
            data("address_county") = CountyTextBox.Text
            data("address_postcode") = PostcodeTextBox.Text

            data("email_address") = EmailTextBox.Text
            data("phone_number") = PhoneTextBox.Text
            data("alt_phone_number") = AltPhoneTextBox.Text
            data("username") = UsernameTextBox.Text

            ' Only set the password if a password has been entered and in edit mode
            If PasswordTextBox.Text <> "" Then
                Dim Hasher = I.Hasher

                data("password") = Hasher.HashPassword(PasswordTextBox.Text)
            End If

            Dim DB = I.DB

            If userId = 0 Then
                ' Create user
                userId = DB.insert("users", data)
            Else
                ' Edit user
                DB.edit("users", userId, data)
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

End Class