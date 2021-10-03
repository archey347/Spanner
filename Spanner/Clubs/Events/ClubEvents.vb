Public Class ClubEvents

    Public clubId As Integer

    Private I As App.Injector

    Private Sub ClubEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load service injector
        I = My.Application.I

        ' Refresh Table
        refreshTable()
    End Sub

    Public Sub refreshTable()
        Dim DB = I.DB

        ' Prepare SQL
        Dim SQL = "SELECT id, name, start_date, end_date, price, is_competitive, is_canceled FROM `events` WHERE club_id = " + clubId.ToString()
        ' Get data
        Dim table As DataTable = DB.GetQuery(SQL)

        ' Load data to table
        DataGridView1.DataSource = table

        ' Set the columns
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).HeaderText = "Start Date"
        DataGridView1.Columns(3).HeaderText = "End Date"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Is Competitive"
        DataGridView1.Columns(6).HeaderText = "Is Canceled"

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If {2, 3}.Contains(e.ColumnIndex) Then
            ' Must be date field
            ' Convert to date
            Dim dateValue = New Date(e.Value)
            ' Export as readable string
            e.Value = dateValue.ToShortDateString()
        ElseIf e.ColumnIndex = 4 Then
            Dim value As Integer = e.Value
            e.Value = value.ToString("C2")
        ElseIf e.ColumnIndex = 5 Or e.ColumnIndex = 6 Then
            ' Yes/No Field
            If e.Value = 0 Then
                e.Value = "No"
            Else
                e.Value = "Yes"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showEvent(0, clubId)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Get forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showEvent(DataGridView1.CurrentRow.Cells(0).Value, clubId)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showEvent(DataGridView1.CurrentRow.Cells(0).Value, clubId)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showClubEventBookings(DataGridView1.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the forms
        Forms.showClubEventResults(DataGridView1.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub ClubEvents_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh the table when the form comes into focus
        refreshTable()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.CurrentRow.Cells(6).Value = 1 Then
            ' If the event is canceled, change cancel button to uncancel
            btnCancel.Text = "Uncancel Event"
        Else
            ' If not, then show cancel button
            btnCancel.Text = "Cancel Event"
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Get event
        Dim DB = I.DB
        Dim id = DataGridView1.CurrentRow.Cells(0).Value
        Dim ev = DB.getRecord("events", id)

        ' Check current state
        If ev("is_canceled") = 0 Then
            ' Verify with the user they want to cancel the event
            If MsgBox("Are you sure you want to cancel " + ev("name") + "?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                Dim data = New Dictionary(Of String, Object)
                data("is_canceled") = 1
                ' Edit
                DB.edit("events", id, data)
            End If
        Else
            ' Set as uncanceled
            Dim data = New Dictionary(Of String, Object)
            data("is_canceled") = 0
            ' Update
            DB.edit("events", id, data)
        End If

        ' Refresh the table
        refreshTable()
    End Sub

End Class