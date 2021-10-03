Public Class ClubEventResultsForm

    Public eventId As Integer
    Public readMode As Boolean

    Private I As App.Injector

    ' Get the sections for an event
    Private Function getSections() As DataTable
        Dim DB = I.DB
        Return DB.GetQuery("SELECT * FROM event_sections WHERE event_id = " + eventId.ToString())
    End Function

    Private Sub ClubEventResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = My.Application.I

        If readMode Then
            ' Only put in preview mode
            ResultsDataGridView.ReadOnly = True
            SaveButton.Visible = False
            ClearButton.Visible = False
            ManageSectionsButton.Visible = False
            Label1.Text = "Event Results"
        End If

        ' Set the columns for the datagrid view
        ResultsDataGridView.Columns.Add("id", "ID")
        ResultsDataGridView.Columns(0).Width = 40
        ResultsDataGridView.Columns(0).ReadOnly = True
        ResultsDataGridView.Columns.Add("name", "Name")
        ResultsDataGridView.Columns(1).ReadOnly = True
        ResultsDataGridView.Columns.Add("abbreviation", "Club")
        ResultsDataGridView.Columns(2).ReadOnly = True
        ResultsDataGridView.Columns.Add("class", "Class")
        ResultsDataGridView.Columns(3).ReadOnly = True
        ResultsDataGridView.Columns(3).Width = 40

        Dim column_competing = New DataGridViewComboBoxColumn()
        column_competing.DataSource = {"Y", "N"}
        column_competing.HeaderText = "Is Competing"
        column_competing.Width = 60

        ResultsDataGridView.Columns.Add(column_competing)

        Dim column_ret = New DataGridViewComboBoxColumn()
        column_ret.DataSource = {"Y", "N"}
        column_ret.HeaderText = "Is Retired"
        column_ret.Width = 50

        ResultsDataGridView.Columns.Add(column_ret)

        ' Get the sections
        Dim sections = getSections()

        ' Add column for each section
        Dim c = 6
        For Each section In sections.Rows
            ResultsDataGridView.Columns.Add("section_" + section("id").ToString(), section("id").ToString())
            ResultsDataGridView.Columns(c).Width = 40
            c += 1
        Next

        ResultsDataGridView.Columns.Add("total", "Total")
        ResultsDataGridView.Columns(c).Width = 40

        ' Load table data
        refreshTable()
    End Sub

    Public Sub refreshTable()
        ' Generate the SQL
        Dim SQL = "SELECT event_bookings.id, (users.first_name || "" "" || users.last_name) As name, clubs.abbreviation, vehicle_classes.name As class, event_bookings.is_retired, event_bookings.is_competing FROM users, clubs, event_bookings, vehicle_classes WHERE "
        SQL += "event_bookings.user_id = users.id AND "
        SQL += "event_bookings.club_id = clubs.id AND "
        SQL += "event_bookings.vehicle_class_id = vehicle_classes.id AND "
        SQL += "event_bookings.event_id = " + eventId.ToString() + " AND "
        SQL += "event_bookings.is_approved = 1"

        ' Clear table
        ResultsDataGridView.Rows.Clear()

        Dim DB = I.DB

        ' Get Data
        Dim table = DB.GetQuery(SQL)

        ' Get sections
        Dim sections = getSections()

        Dim colCount = sections.Rows.Count + 6

        ' Loop through each record and add to grid
        For Each entrant In table.Rows
            Dim row(colCount) As String
            row(0) = entrant("id")
            row(1) = entrant("name")
            row(2) = entrant("abbreviation")
            row(3) = entrant("class")
            If entrant("is_competing") = 0 Then
                row(4) = "N"
            Else
                row(4) = "Y"
            End If

            If entrant("is_retired") = 0 Then
                row(5) = "N"
            Else
                row(5) = "Y"
            End If

            ' Loop through each section
            Dim c = 6
            Dim total = 0
            For Each section In sections.Rows
                Dim Results = I.Results

                ' Get the score
                Dim score = Results.getSectionResult(section("id"), entrant("id"))("score")
                ' Add to total
                total += score
                ' Save to array
                row(c) = score.ToString()
                c += 1
            Next

            ' Add total, or RET if retired
            If entrant("is_retired") = 1 Then
                row(c) = "RET"
            ElseIf entrant("is_competing") = 0 Then
                row(c) = "DNS"
            Else
                row(c) = total.ToString()
            End If

            ' Add row to data grid
            ResultsDataGridView.Rows.Add(row)

        Next

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ResultsDataGridView.CellValueChanged
        ' If score or RET/DNS value changed, update total
        If e.ColumnIndex > 3 And e.ColumnIndex <> ResultsDataGridView.DisplayedColumnCount(True) - 1 Then
            Dim total = calculateTotal(ResultsDataGridView.Rows(e.RowIndex))

            Dim totalId = ResultsDataGridView.DisplayedColumnCount(True) - 1

            ResultsDataGridView.Rows(e.RowIndex).Cells(totalId).Value = total.ToString()
        End If

    End Sub

    ' Calculate the total score for a record
    Private Function calculateTotal(row As DataGridViewRow) As String
        Dim total = 0

        ' If they didn't finish
        If row.Cells(4).Value = "N" Then
            Return "DNS"
        End If

        ' If they retired
        If row.Cells(5).Value = "Y" Then
            Return "RET"
        End If

        ' Loop through each section result
        For Counter = 6 To ResultsDataGridView.DisplayedColumnCount(True) - 2
            Try
                total += row.Cells(Counter).Value
            Catch ex As Exception
                ' Invalid number has been entered
                MsgBox("An invalid number has been entered")
                Return "ERR"

            End Try

        Next

        Return total.ToString()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Refresh the table
        refreshTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim DB = I.DB

        ' Get sections
        Dim sections = getSections()

        Dim colCount = sections.Rows.Count + 6

        ' Loop through each row
        For Each row As DataGridViewRow In ResultsDataGridView.Rows
            ' Loop through each row to make sure that there are no errors
            If row.Cells(colCount).Value = "ERR" Then
                MsgBox("The data can't be saved as it is invalid")
                Exit Sub
            End If
        Next

        ' Loop through each row
        For Each row As DataGridViewRow In ResultsDataGridView.Rows

            Dim bookingId = row.Cells(0).Value

            ' Save the is_retired and is_competing fields

            Dim entrant = New Dictionary(Of String, Object)
            If row.Cells(4).Value = "Y" Then
                entrant("is_competing") = 1
            Else
                entrant("is_competing") = 0
            End If
            If row.Cells(5).Value = "Y" Then
                entrant("is_retired") = 1
            Else
                entrant("is_retired") = 0
            End If
            DB.edit("event_bookings", bookingId, entrant)

            ' Loop through each section and save result
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        ' Get results service
        Dim Results = I.Results
        ' Export results
        Results.export(eventId)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ManageSectionsButton.Click
        ' Get Forms service
        Dim Forms = I.Forms
        ' Show form
        Forms.showEventSections(eventId)
    End Sub

End Class