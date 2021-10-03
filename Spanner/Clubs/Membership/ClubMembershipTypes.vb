Public Class ClubMembershipTypesForm

    Public clubId As Integer

    Private I As App.Injector

    Private Sub ClubMembershipTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get injector service
        I = My.Application.I

        ' Load table
        refreshTable()
    End Sub

    Public Sub refreshTable()
        ' Generate SQL
        Dim SQL = "SELECT id, name, price, join_price FROM membership_types WHERE "
        SQL += "membership_types.deleted = 0 AND "
        SQL += "membership_types.club_id = " + clubId.ToString()

        Dim DB = I.DB

        ' Get the data
        Dim table As DataTable = DB.GetQuery(SQL)

        ' Load data into table
        MembershipTypesDataGridView.DataSource = table

        ' Set columns
        MembershipTypesDataGridView.Columns(0).HeaderText = "ID"
        MembershipTypesDataGridView.Columns(0).Width = 25
        MembershipTypesDataGridView.Columns(1).HeaderText = "Name"
        MembershipTypesDataGridView.Columns(2).HeaderText = "Price"
        MembershipTypesDataGridView.Columns(3).HeaderText = "Joining Price"

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MembershipTypesDataGridView.CellFormatting
        If {2, 3}.Contains(e.ColumnIndex) Then
            ' Convert cell value to currency
            Dim price As Decimal = CDec(e.Value)

            e.Value = "" + price.ToString("C2")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ' Get forms service
        Dim Forms = I.Forms
        ' Show form
        Forms.showMembershipType(MembershipTypesDataGridView.CurrentRow.Cells(0).Value, clubId)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ' Get forms service
        Dim Forms = I.Forms
        ' Show forms
        Forms.showMembershipType(0, clubId)
    End Sub

    Private Sub ClubMembershipTypes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh table when form comes into focus
        refreshTable()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim DB = I.DB

        ' Ask the user to confirm choice
        Dim typeId = MembershipTypesDataGridView.CurrentRow.Cells(0).Value
        If MsgBox("Are you sure you want to delete " + MembershipTypesDataGridView.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            ' Edit data
            Dim data = New Dictionary(Of String, Object)
            data("deleted") = 1

            ' save changes
            DB.edit("membership_types", typeId, data)

            ' Refresh data
            refreshTable()
        End If

    End Sub

End Class