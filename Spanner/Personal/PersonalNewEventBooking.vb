Public Class PersonalNewEventBookingForm

    Public I As App.Injector

    Public userId As Integer

    Private Sub PersonalNewEventBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get injector service
        I = My.Application.I

        ' Refresh all of the tables/select boxes
        refreshClubs()
        refreshEventsTable()
        refreshClasses()
    End Sub

    Public Sub refreshClubs()
        Dim DB = I.DB

        ' Get the clubs
        Dim clubs = DB.GetQuery("Select * From clubs")

        ' Load clubs into the select box
        FilterClubComboBox.DataSource = clubs
        FilterClubComboBox.DisplayMember = "club_name"
        FilterClubComboBox.ValueMember = "id"

    End Sub

    Public Sub refreshEventsTable()
        ' Generate SQL
        Dim SQL = "SELECT events.id, events.name, clubs.abbreviation, events.start_date, events.end_date, events.price, events.is_competitive FROM events, clubs WHERE "
        SQL += " clubs.id = events.club_id AND "
        SQL += "start_date > " + Now.Ticks.ToString()
        ' Filter by club if enabled
        If FilterClubCheckbox.Checked Then
            SQL += " AND club_id = " + FilterClubComboBox.SelectedValue.ToString()
        End If
        SQL += " ORDER BY start_date DESC"

        Dim DB = I.DB

        ' Get the events
        Dim events = DB.GetQuery(SQL)

        ' Load the data
        EventsDataGridView.DataSource = events

        ' Set the columns
        EventsDataGridView.Columns(0).HeaderText = "ID"
        EventsDataGridView.Columns(0).Width = 50
        EventsDataGridView.Columns(1).HeaderText = "Name"
        EventsDataGridView.Columns(1).Width = 200
        EventsDataGridView.Columns(2).HeaderText = "Club"
        EventsDataGridView.Columns(2).Width = 75
        EventsDataGridView.Columns(3).HeaderText = "Start Date"
        EventsDataGridView.Columns(4).HeaderText = "End Date"
        EventsDataGridView.Columns(5).HeaderText = "Price"
        EventsDataGridView.Columns(6).HeaderText = "Is Competitive"

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles FilterClubCheckbox.CheckedChanged
        ' Refresh events when the filter has been changed
        refreshEventsTable()
    End Sub

    Private Sub FilterClub_TextChanged(sender As Object, e As EventArgs) Handles FilterClubComboBox.TextChanged
        ' refresh the events when the filter options have changed
        refreshEventsTable()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles EventsDataGridView.CellFormatting
        If {3, 4}.Contains(e.ColumnIndex) Then
            ' Date field
            e.Value = New Date(e.Value).ToShortDateString
        ElseIf e.ColumnIndex = 5 Then
            ' Price column
            Dim price As Decimal = CDec(e.Value)
            e.Value = price.ToString("C2")
        ElseIf e.ColumnIndex = 6 Then
            ' Boolean field, so convert to yes/no
            If e.Value = 0 Then
                e.Value = "No"
            Else
                e.Value = "Yes"
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EventsDataGridView.CellDoubleClick
        ' Change the selected event on cell click

        IDTextBox.Text = EventsDataGridView.CurrentRow.Cells(0).Value
        NameTextBox.Text = EventsDataGridView.CurrentRow.Cells(1).Value
        PriceTextBox.Text = CDec(EventsDataGridView.CurrentRow.Cells(5).Value).ToString("C2")

        ' Make class selection visible if it is a competitive event
        ClassComboBox.Visible = (EventsDataGridView.CurrentRow.Cells(6).Value = 1)
        lblClass.Visible = (EventsDataGridView.CurrentRow.Cells(6).Value = 1)

    End Sub

    Public Function validateForm()
        ' Validate the form
        If IDTextBox.Text = "" Then
            MsgBox("Please select an event to book into")
            Return False
        End If
        Return True
    End Function

    Public Sub refreshClasses()
        Dim DB = I.DB

        ' Get the classes
        Dim classes = DB.GetQuery("Select id, (name || "" - "" || description) As display FROM vehicle_classes")

        ' Load the classes into the select box
        ClassComboBox.DataSource = classes
        ClassComboBox.DisplayMember = "display"
        ClassComboBox.ValueMember = "id"
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim Membership = I.Membership
        Dim DB = I.DB

        ' Make sure a booking doesn't exist already
        Dim booking = DB.GetQuery("SELECT * FROM memberships WHERE event_id = " + IDTextBox.Text + " AND user_id = " + userId.ToString())

        ' Inform the user if so
        If booking.Rows.Count > 0 Then
            MsgBox("You already have a booking for this event")
            Exit Sub
        End If

        ' Validate the form
        If validateForm() Then
            ' Create the event booking
            Dim data As New Dictionary(Of String, Object)

            data("event_id") = IDTextBox.Text
            data("user_id") = userId
            data("club_id") = Membership.getClubs(userId).Rows(0)("id")
            data("is_approved") = 0
            data("is_rejected") = 0
            data("is_retired") = 0
            data("total_score") = 0
            data("vehicle_class_id") = ClassComboBox.SelectedValue

            ' Save the data
            DB.insert("event_bookings", data)

            ' Close the form
            Me.Close()

        End If
    End Sub

End Class