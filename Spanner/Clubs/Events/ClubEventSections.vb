Public Class ClubEventSectionsForm

    Private I As App.Injector

    Public eventId As Integer

    Private Sub ClubEventSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the service injector
        I = My.Application.I

        ' Refresh the sections
        refreshSections()
    End Sub

    Public Sub refreshSections()
        ' Generate the SQL
        Dim SQL = "SELECT id, section_name FROM event_sections WHERE event_id = " + eventId.ToString() + " ORDER BY section_name ASC"

        ' Get the DB service
        Dim DB = I.DB

        ' Run the query
        Dim data = DB.getQuery(SQL)

        ' Add to the grid
        SectionsDataGridView.DataSource = data

        ' Set the columns
        SectionsDataGridView.Columns(0).HeaderText = "ID"
        SectionsDataGridView.Columns(1).HeaderText = "Section Name"
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles SectionsDataGridView.CellDoubleClick
        ' Change the selected section
        IDTextBox.Text = SectionsDataGridView.CurrentRow.Cells(0).Value
        SectionNameTextBox.Text = SectionsDataGridView.CurrentRow.Cells(1).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        ' Clear the input boxes
        IDTextBox.Text = ""
        SectionNameTextBox.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Clear the textbox if empty, or reset the value
        If IDTextBox.Text = "" Then
            SectionNameTextBox.Text = ""
        Else
            SectionNameTextBox.Text = SectionsDataGridView.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Set data
        Try
            ' Validate
            App.Validation.validateField(SectionNameTextBox.Text, "Name", New Dictionary(Of String, Object) From {{"required", Nothing}, {"max_length", 20}})
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        ' Put data into array
        Dim data = New Dictionary(Of String, Object)
        data("section_name") = SectionNameTextBox.Text
        data("event_id") = eventId

        Dim DB = I.DB

        ' New section
        If IDTextBox.Text = "" Then
            DB.insert("event_sections", data)
        Else
            ' If not, edit existing one
            DB.edit("event_sections", CInt(IDTextBox.Text), data)
        End If

        ' Refresh table
        refreshSections()
    End Sub

End Class