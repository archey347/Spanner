Namespace App

    Public Class Forms

        Public Session As App.Session

        Public Sub New(Session As App.Session)
            Me.Session = Session
        End Sub

        Public Sub login()
            ' Somewhere to store the dialog result
            Dim result As DialogResult

            ' Create an instance of the login form
            Dim loginFrm As LoginForm
            loginFrm = New LoginForm()

            ' Will start a loop that will run until the user has been authenticated
            While True

                ' Show the form and store the resulting button press
                result = loginFrm.ShowDialog()

                ' Check if the Login button was pressed
                If result = DialogResult.OK Then
                    ' Attempt to authenicate the user
                    If Session.login(loginFrm.UsernameTextBox.Text, loginFrm.PasswordTextBox.Text) Then
                        ' Authentication successful, exit loop
                        Exit While
                    Else
                        ' Failed
                        MsgBox("Invalid Credentials")
                    End If
                Else
                    ' User canceled, so exit application
                    Application.Exit()
                    End
                End If
            End While
        End Sub

        Public Sub showPersonalDetails(userId As Integer)
            PersonalDetailsForm.userId = userId
            PersonalDetailsForm.Show()
        End Sub

        Public Function showPersonalDetailsAsDialog(userId As Integer) As Integer
            PersonalDetailsForm.userId = userId
            If PersonalDetailsForm.ShowDialog() = DialogResult.OK Then
                Return PersonalDetailsForm.userId
            End If
            Return 0
        End Function

        Public Sub showPersonalMembership(userId As Integer)
            PersonalMembershipForm.userId = userId
            PersonalMembershipForm.Show()
        End Sub

        Public Sub showClubs()
            ClubsForm.Show()
        End Sub

        Public Sub showClub(clubId As Integer)
            ' Create form instance
            Dim frm As Club = New Club()
            ' Set id of object to edit
            frm.clubId = clubId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showVehicleClasses()
            VehicleClassesForm.Show()
        End Sub

        Public Sub showVehicleClass(vehicleClassId As Integer)
            ' Create instance of form
            Dim frm As VehicleClassForm = New VehicleClassForm()
            ' set id of class to edit
            frm.vehicleClassId = vehicleClassId
            ' Show the form
            frm.Show()

        End Sub

        Public Sub showClubAdmin(clubId As Integer)
            ' Create the form instance
            Dim frm = New ClubAdminForm()
            ' Set the club ID
            frm.clubId = clubId
            ' Show the form
            frm.Show()

        End Sub

        Public Sub showRoles(clubId As Integer)
            ' Create the form instance
            Dim frm = New ClubRolesForm()
            ' Set the club ID
            frm.clubId = clubId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showMembership(clubId As Integer)
            ' Create the form instance
            Dim frm = New ClubMembershipForm()
            ' Set the club ID
            frm.clubId = clubId
            ' Show the form
            frm.Show()

        End Sub

        Public Sub showMembershipTypes(clubId As Integer)
            ' Create the form instance
            Dim frm = New ClubMembershipTypesForm()
            ' Set the club ID
            frm.clubId = clubId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showMembershipType(typeId As Integer, clubId As Integer)
            ' Create a form instance
            Dim frm = New ClubMembershipTypeForm()
            ' Set the id of the type
            frm.membershipTypeId = typeId
            ' Set the club ID
            frm.clubId = clubId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showEvents(clubId As Integer)
            ' Create form instance
            Dim frm = New ClubEvents()
            ' Set the club id
            frm.clubId = clubId
            ' Show the form
            frm.Show()

        End Sub

        Public Sub showEvent(eventId As Integer, clubId As Integer)
            ' Create the form instance
            Dim frm = New ClubEventForm()
            ' Set the ids
            frm.clubId = clubId
            frm.eventId = eventId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showPersonalEvents(userId As Integer)
            PersonalBookingsForm.userId = userId
            PersonalBookingsForm.Show()
        End Sub

        Public Sub showPersonalNewEventBooking(userId As Integer)
            ' Create form instance
            Dim frm = New PersonalNewEventBookingForm()
            ' Set the user id
            frm.userId = userId
            ' show the form
            frm.Show()
        End Sub

        Public Sub showClubEventBookings(eventId As Integer)
            ' Create form instance
            Dim frm = New ClubEventBookingsForm()
            ' Set the event id
            frm.eventId = eventId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showClubEventResults(eventId As Integer)
            ' Create form instance
            Dim frm = New ClubEventResultsForm()
            ' Set the event id
            frm.eventId = eventId
            ' Set read mode
            frm.readMode = False
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showClubEventResultsRead(eventId As Integer)
            ' Create form instance
            Dim frm = New ClubEventResultsForm()
            ' Set the event id
            frm.eventId = eventId
            ' Set read only mode
            frm.readMode = True
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showClubAssignRoles(roleId As Integer, clubId As Integer)
            ' Create form instance
            Dim frm = New ClubAssignRolesForm()
            ' Set variables
            frm.clubId = clubId
            frm.roleId = roleId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showClubMembershipRequests(clubId As Integer)
            ' Create form instance
            Dim frm = New ClubMembershipRequestsForm()
            ' Set club
            frm.clubId = clubId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showClubMembershipRequestNew(clubId As Integer)
            ' Create form instance
            Dim frm = New ClubMembershipRequestNewForm()
            ' Set club
            frm.clubId = clubId
            ' Show the form
            frm.Show()
        End Sub

        Public Sub showClubMembershipRequestNewWithUser(clubId As Integer, membershipId As Integer)
            ' Create form instance
            Dim frm = New ClubMembershipRequestNewForm()
            ' Set club
            frm.clubId = clubId
            ' Set the membership
            frm.membershipId = membershipId
            ' Show the form
            frm.Show()
        End Sub

        Public Function selectDate(caption As String, default_date As DateTime) As DateTime
            Dim frm = New DateDialogForm()
            frm.lblCaption.Text = caption
            frm.DateTimePicker.Value = default_date
            If frm.ShowDialog() = DialogResult.OK Then
                Return frm.DateTimePicker.Value
            Else
                Return Nothing
            End If
        End Function

        Public Sub showEventSections(eventId As Integer)
            Dim frm = New ClubEventSectionsForm()
            frm.eventId = eventId
            frm.Show()
        End Sub

        Public Sub showClubTransactions(clubId As Integer)
            Dim frm = New ClubManageTransactionsForm()
            frm.clubId = clubId
            frm.Show()
        End Sub

        Public Sub showTransaction(transactionId As Integer, clubId As Integer)
            Dim frm = New ClubTransactionForm()
            frm.clubId = clubId
            frm.transactionId = transactionId
            frm.Show()
        End Sub

        Public Sub showManageTransaction(transactionId As Integer)
            Dim frm = New ClubManageTransactionForm()
            frm.transactionId = transactionId
            frm.Show()
        End Sub

        Public Sub showClubNewEventBooking(eventId As Integer)
            Dim frm = New ClubNewEventBooking()
            frm.eventId = eventId
            frm.Show()
        End Sub

        Public Sub showPersonalEventBooking(bookingId As Integer)
            Dim frm = New PersonalEventBookingForm()
            frm.bookingId = bookingId
            frm.Show()
        End Sub

        Public Sub showPersonalMembershipRenew(membershipId As Integer)
            Dim frm = New PersonalMembershipRenewForm()
            frm.membershipId = membershipId
            frm.Show()
        End Sub

        Public Sub showPersonalMembershipRequests(membershipId As Integer)
            Dim frm = New PersonalMembershipRequestsForm()
            frm.membershipId = membershipId
            frm.Show()
        End Sub

        Public Sub showPersonalNewMembership(userId As Integer)
            Dim frm = New PersonalNewMembershipForm()
            frm.userId = userId
            frm.Show()
        End Sub

        Public Function showClubMembershipSelectUser(clubId As Integer) As Integer
            Dim frm = New ClubMembershipSelectUser()
            frm.clubId = clubId
            If frm.ShowDialog() = DialogResult.OK Then
                Return CInt(frm.IDTextBox.Text)
            Else
                Return 0
            End If
        End Function

    End Class



End Namespace