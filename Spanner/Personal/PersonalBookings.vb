Public Class PersonalBookingsForm

    Public I As App.Injector

    Public userId As Integer

    Private Sub PersonalBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the injector service
        I = My.Application.I

        ' Refresh the table
        refreshTable()
    End Sub

    Public Sub refreshTable()
        Dim DB = I.DB

        ' Get the current user
        Dim user = DB.getRecord("users", userId)

        ' Generate SQL
        Dim SQL = "SELECT event_bookings.id, events.name, events.is_canceled, events.start_date, events.end_date, vehicle_classes.name, event_bookings.is_approved, event_bookings.is_rejected FROM events, event_bookings, vehicle_classes WHERE "
        SQL += "event_bookings.vehicle_class_id = vehicle_classes.id AND "
        SQL += "event_bookings.event_id = events.id AND "
        SQL += "event_bookings.user_id = " + userId.ToString()
        SQL += " ORDER BY events.start_date DESC"

        ' Get the data
        Dim data = DB.GetQuery(SQL)

        ' Load data into datagrid
        BookingsDataGridView.DataSource = data

        ' Set the columns
        BookingsDataGridView.Columns(0).HeaderText = "Booking ID"
        BookingsDataGridView.Columns(0).Width = 50
        BookingsDataGridView.Columns(1).HeaderText = "Event Name"
        BookingsDataGridView.Columns(1).Width = 200
        BookingsDataGridView.Columns(2).HeaderText = "Is Canceled"
        BookingsDataGridView.Columns(3).HeaderText = "Start Date"
        BookingsDataGridView.Columns(4).HeaderText = "End Date"
        BookingsDataGridView.Columns(5).HeaderText = "Vehicle Class"
        BookingsDataGridView.Columns(6).HeaderText = "Is Approved"
        BookingsDataGridView.Columns(7).HeaderText = "Is Rejected"

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles BookingsDataGridView.CellFormatting
        If {3, 4}.Contains(e.ColumnIndex) Then
            ' Date field
            e.Value = New Date(e.Value).ToShortDateString()
        ElseIf {2, 6, 7}.Contains(e.ColumnIndex) Then
            ' Boolean value
            If e.Value = 0 Then
                e.Value = "No"
            Else
                e.Value = "Yes"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles NewBookingButton.Click
        ' Load the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showPersonalNewEventBooking(userId)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EditBookingForm.Click
        ' Load the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showPersonalEventBooking(BookingsDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub PersonalBookings_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' refresh the table if the form comes back into focus
        refreshTable()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles BookingsDataGridView.CellEnter
        ' Show edit booking if it is a competitive event
        Dim DB = I.DB
        Dim booking = DB.getRecord("event_bookings", BookingsDataGridView.CurrentRow.Cells(0).Value)
        Dim ev = DB.getRecord("events", booking("event_id"))
        EditBookingForm.Enabled = (ev("is_competitive") = 1)
        EventResultsButton.Enabled = (ev("is_competitive") = 1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelBookingButton.Click
        ' Get the id before showing the dialog to prevent the refresh "forgetting" the selection
        Dim id = BookingsDataGridView.CurrentRow.Cells(0).Value

        ' Verify with the user
        Dim result = MsgBox("Are you sure you want to cancel this booking?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Dim data = New Dictionary(Of String, Object)

            ' Set the data
            data("is_approved") = 0
            data("is_rejected") = 1
            data("is_competing") = 0

            ' Save to the database

            Dim DB = I.DB
            DB.edit("event_bookings", id, data)

            ' refresh table
            refreshTable()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles EventResultsButton.Click
        ' Get the current booking
        Dim id = BookingsDataGridView.CurrentRow.Cells(0).Value
        Dim DB = I.DB
        Dim booking = DB.getRecord("event_bookings", id)
        ' Get the current event
        Dim eventId = booking("event_id")

        ' Show the results form
        Dim Forms = I.Forms
        Forms.showClubEventResultsRead(eventId)

    End Sub

End Class