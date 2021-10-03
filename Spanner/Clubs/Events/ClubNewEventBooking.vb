Public Class ClubNewEventBooking

    Public eventId

    Private I As App.Injector

    Private Sub ClubNewEventBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get injector service
        I = My.Application.I

        ' Refresh table
        refreshPeople()

        ' get DB service
        Dim DB = I.DB

        ' Load event entity
        Dim ev = DB.getRecord("events", eventId)

        ' IF event is competetive, show class select box
        If ev("is_competitive") = 0 Then
            ClassComboBox.Enabled = False
        End If

        ' Load the classes
        refreshClasses()
    End Sub

    Private Sub refreshPeople()
        ' Generate SQL
        Dim SQL = "SELECT users.id, users.first_name, users.last_name, users.gender, users.email_address, users.address_postcode FROM users"
        Dim SQLwhere = ""
        If FilterFirstNameTextBox.Text.Trim() <> "" Then
            ' If firstname isn't empty, add to the SQL
            SQLwhere += " WHERE users.first_name LIKE ""%" + FilterFirstNameTextBox.Text + "%"""
        End If
        If FilterLastNameTextBox.Text.Trim() <> "" Then
            ' Add an AND if the sql is not empty
            If SQLwhere = "" Then
                SQLwhere = " WHERE "
            Else
                SQLwhere = " AND "
            End If
            SQL += "users.last_name LIKE ""%" + FilterLastNameTextBox.Text + "%"""
        End If

        Dim DB = I.DB

        ' Load the data
        Dim data = DB.getQuery(SQL)

        ' Put data into the grid
        UsersDataGridView.DataSource = data

        ' Set the columns
        UsersDataGridView.Columns(0).HeaderText = "ID"
        UsersDataGridView.Columns(1).HeaderText = "First Name"
        UsersDataGridView.Columns(2).HeaderText = "Last Name"
        UsersDataGridView.Columns(3).HeaderText = "Gender"
        UsersDataGridView.Columns(3).HeaderText = "Email"
        UsersDataGridView.Columns(3).HeaderText = "Postcode"

    End Sub

    Public Sub refreshClasses()
        Dim DB = I.DB

        ' Get the classes
        Dim classes = DB.GetQuery("Select id, (name || "" - "" || description) As display FROM vehicle_classes")

        ' Load classes into select box
        ClassComboBox.DataSource = classes
        ClassComboBox.DisplayMember = "display"
        ClassComboBox.ValueMember = "id"
    End Sub

    Private Sub InpFirstName_TextChanged(sender As Object, e As EventArgs) Handles FilterFirstNameTextBox.TextChanged
        ' refresh table when first name search box is changed
        refreshPeople()
    End Sub

    Private Sub GridSearchUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellDoubleClick
        ' Changes selected user id when a different row is selected
        IDTextBox.Text = UsersDataGridView.Rows(e.RowIndex).Cells(0).Value
        FirstNameTextBox.Text = UsersDataGridView.Rows(e.RowIndex).Cells(1).Value
        LastNameTextBox.Text = UsersDataGridView.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim DB = I.DB
        Dim Payments = I.Payments

        ' Create booking
        Dim data = New Dictionary(Of String, Object)

        ' Get membership service
        Dim Membership As App.Membership = I.Membership

        ' Make sure user is selected
        If IDTextBox.Text = "" Then
            MsgBox("Please select a user")
            Exit Sub
        End If

        ' Get the user id
        Dim userId = CInt(IDTextBox.Text)

        ' Make sure an existing booking doesn't exist
        Dim SQL = "SELECT * FROM event_bookings WHERE "
        SQL += "user_id = " + userId.ToString()
        SQL += " AND event_id = " + eventId.ToString()

        Dim result = DB.GetQuery(SQL)

        If result.Rows.Count > 0 Then
            ' There is an existing booking, but it has been rejected, so deliver slightly different message
            If result.Rows(0)("is_rejected") = 1 Then
                MsgBox("This user already has a booking for this event, but it has been rejected.")
            Else
                MsgBox("This user already has a booking for this event")
            End If
            ' Stop to prevent duplicate booking
            Exit Sub
        End If

        ' Set data
        data("user_id") = userId
        data("event_id") = eventId
        data("club_id") = Membership.getClubs(userId).Rows(0)("id")
        data("is_approved") = 0
        data("is_rejected") = 0
        data("is_retired") = 0
        data("is_competing") = 0
        data("total_score") = 0
        data("vehicle_class_id") = ClassComboBox.SelectedValue

        Dim id = DB.insert("event_bookings", data)

        Dim ev = DB.getRecord("events", eventId)
        ' Get the event

        ' Create payment
        Payments.create(userId, ev("club_id"), ev("price"), "event", id)

        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class