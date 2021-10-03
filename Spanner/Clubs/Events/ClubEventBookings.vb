Public Class ClubEventBookingsForm

    Public eventId As Integer

    Private I As App.Injector

    Private Sub ClubEventBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the services injector
        I = My.Application.I

        ' refresh the table
        refreshTable()
    End Sub

    Public Sub refreshTable()
        Dim DB = I.DB

        ' Get the event
        Dim club_event = DB.getRecord("events", eventId)

        Dim class_col = ""
        Dim class_table = ""
        Dim class_where = ""
        If club_event("is_competitive") = 1 Then
            ' Add the vehicle_class column if the event is competitive
            class_col = ", vehicle_classes.name"
            class_table = ", vehicle_classes"
            class_where = "vehicle_classes.id = event_bookings.vehicle_class_id AND "
        End If

        ' Generate SQL
        Dim SQL = "SELECT event_bookings.id, (users.first_name || "" "" || users.last_name) As name, clubs.abbreviation, event_bookings.is_approved, event_bookings.is_rejected" + class_col + " FROM event_bookings, users, clubs" + class_table + " WHERE " + class_where
        SQL += "event_bookings.club_id = clubs.id AND "
        SQL += "users.id = event_bookings.user_id AND "
        SQL += "event_bookings.event_id = " + eventId.ToString()

        ' If reject filter enabled, add condition
        If Not FilterRejectCheckbox.Checked Then
            SQL += " AND event_bookings.is_rejected = 0 "
        End If

        ' Order by approved status, so that those yet to be processed are at the top
        SQL += " ORDER BY is_approved ASC, event_bookings.id DESC"

        ' Get the data
        Dim table = DB.GetQuery(SQL)

        ' Save to grid
        BookingsDataGridView.DataSource = table

        ' Set columns
        BookingsDataGridView.Columns(0).HeaderText = "ID"
        BookingsDataGridView.Columns(0).Width = 100
        BookingsDataGridView.Columns(1).HeaderText = "Name"
        BookingsDataGridView.Columns(1).Width = 100
        BookingsDataGridView.Columns(2).HeaderText = "Abbreviation"
        BookingsDataGridView.Columns(3).HeaderText = "Approved"
        BookingsDataGridView.Columns(4).HeaderText = "Rejected"

        ' If a competitive event, show the vehicle class column
        If club_event("is_competitive") = 1 Then
            BookingsDataGridView.Columns(5).HeaderText = "Vehicle Class"
        End If

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles BookingsDataGridView.CellFormatting
        If {3, 4}.Contains(e.ColumnIndex) Then
            ' Yesno field
            If e.Value = 0 Then
                e.Value = "No"
            Else
                e.Value = "Yes"
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles FilterRejectCheckbox.CheckedChanged
        refreshTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewUserButton.Click
        Dim DB = I.DB
        Dim Forms = I.Forms

        ' Get booking from

        Dim booking_id = BookingsDataGridView.CurrentRow.Cells(0).Value

        Dim booking = DB.getRecord("event_bookings", booking_id)

        ' Show the personal details
        Forms.showPersonalDetails(booking("user_id"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RejectBookingButton.Click
        Dim DB = I.DB

        Dim data = New Dictionary(Of String, Object)

        ' Get the booking ID
        Dim bookingId = BookingsDataGridView.CurrentRow.Cells(0).Value

        If BookingsDataGridView.CurrentRow.Cells(4).Value = 0 Then
            ' If not rejected, set as rejected
            data("is_rejected") = 1
            data("is_approved") = 0
        Else
            ' If rejected, set as not rejected
            data("is_rejected") = 0
        End If

        ' Save changes
        DB.edit("event_bookings", bookingId, data)

        ' Refresh the table
        refreshTable()

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles BookingsDataGridView.SelectionChanged
        If BookingsDataGridView.CurrentRow.Cells(3).Value = 1 Then
            If BookingsDataGridView.CurrentRow.Cells(4).Value = 0 Then
                ' Update buttons if selected booking is accepted
                ApproveBookingButton.Enabled = True
                ApproveBookingButton.Text = "Unapprove Booking"
                RejectBookingButton.Text = "Reject Booking"
            End If
        Else
            If BookingsDataGridView.CurrentRow.Cells(4).Value = 0 Then
                ' Update buttons if selected booking is neither approved or rejected
                ApproveBookingButton.Enabled = True
                ApproveBookingButton.Text = "Approve booking"
                RejectBookingButton.Text = "Reject Booking"
            Else
                ' Update buttons if selected booking is rejected
                ApproveBookingButton.Enabled = False
                ApproveBookingButton.Text = "Approve booking"
                RejectBookingButton.Text = "Undo Rejection"
            End If
        End If
    End Sub

    Private Sub BtnApprove_Click(sender As Object, e As EventArgs) Handles ApproveBookingButton.Click
        Dim data = New Dictionary(Of String, Object)

        ' Get the selected booking id
        Dim bookingId = BookingsDataGridView.CurrentRow.Cells(0).Value
        ' If approved, unapprove and vice versa
        If BookingsDataGridView.CurrentRow.Cells(3).Value = 0 Then
            data("is_approved") = 1
        Else
            data("is_approved") = 0
        End If

        Dim DB = I.DB

        ' Edit database
        DB.edit("event_bookings", bookingId, data)

        refreshTable()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookingsDataGridView.CellContentDoubleClick
        Dim Forms = I.Forms
        Dim DB = I.DB

        ' Get the user id
        Dim booking_id = BookingsDataGridView.CurrentRow.Cells(0).Value
        Dim booking = DB.getRecord("event_bookings", booking_id)

        ' Show the personal details
        Forms.showPersonalDetails(booking("user_id"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CreateBookingButton.Click
        ' Get the forms servce
        Dim forms = I.Forms
        ' Show new event booking form
        forms.showClubNewEventBooking(eventId)
    End Sub

    Private Sub ClubEventBookings_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh the table when the form comes back into focus
        refreshTable()
    End Sub

End Class