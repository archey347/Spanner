Public Class ClubsForm

    Private I As App.Injector

    Public table As DataTable

    Public Function onLoad()

        ' Load the services injector
        I = My.Application.I

        ' Get the database service
        Dim DB = I.DB

        ' Generate SQL
        Dim SQL = "Select * from clubs"
        If Not FilterDeletedCheckbox.Checked Then
            SQL += " WHERE is_deleted = 0"
        End If

        ' Get the data
        table = DB.GetQuery(SQL)

        ' Put data into the table
        ClubDataGridView.DataSource = table

        ' Update the column names and widths
        ClubDataGridView.Columns.Item(0).HeaderCell.Value = "ID"
        ClubDataGridView.Columns.Item(1).HeaderCell.Value = "Name"
        ClubDataGridView.Columns.Item(1).Width = 250
        ClubDataGridView.Columns.Item(2).HeaderCell.Value = "Abbreviation"
        ClubDataGridView.Columns.Item(3).HeaderCell.Value = "Website URL"
        ClubDataGridView.Columns.Item(3).Width = 250
    End Function

    Private Sub Clubs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Run onLoad function
        onLoad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddClubButton.Click
        ' Get the forms service and show the form
        Dim forms = I.Forms
        forms.showClub(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EditClubButton.Click
        ' Get the forms servce
        Dim Forms = I.Forms
        ' Show the club
        Forms.showClub(ClubDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClubDataGridView.CellDoubleClick
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the club
        Forms.showClub(ClubDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub Clubs_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh the table if form has come back into focus
        onLoad()
    End Sub

    Private Sub FilterDeleted_CheckedChanged(sender As Object, e As EventArgs) Handles FilterDeletedCheckbox.CheckedChanged
        ' Refresh the table if the filter has been changed
        onLoad()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeleteClubButton.Click
        ' Get the club
        Dim DB = I.DB
        Dim id = ClubDataGridView.CurrentRow.Cells(0).Value
        Dim club = DB.getRecord("clubs", id)

        ' If the club is already deleted, then undelete it
        If club("is_deleted") = 1 Then
            Dim data = New Dictionary(Of String, Object)
            data("is_deleted") = 0
            DB.edit("clubs", id, data)
        Else
            ' Verify with the user
            If MsgBox("Are you sure you want to delete " + club("club_name"), MsgBoxStyle.YesNo) = DialogResult.Yes Then
                ' Delete the club
                Dim data = New Dictionary(Of String, Object)
                data("is_deleted") = 1
                DB.edit("clubs", id, data)
            End If
        End If

        ' Refresh the table
        onLoad()

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ClubDataGridView.CellEnter
        ' Get the club
        Dim DB = I.DB
        Dim id = ClubDataGridView.CurrentRow.Cells(0).Value
        Dim club = DB.getRecord("clubs", id)

        ' Check if club deleted
        If club("is_deleted") = 1 Then
            ' Setup the buttons for a deleted club
            AddClubButton.Enabled = False
            EditClubButton.Enabled = False
            DeleteClubButton.Text = "Undelete Club"
        Else
            ' Setup the buttons for a club that is not deleted
            AddClubButton.Enabled = True
            EditClubButton.Enabled = True
            DeleteClubButton.Text = "Delete Club"
        End If
    End Sub

End Class