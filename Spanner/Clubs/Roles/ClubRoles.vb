Public Class ClubRolesForm

    Public clubId As Integer

    Private I As App.Injector

    Private Sub Roles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get Injector service
        I = My.Application.I

        Dim DB = I.DB

        ' Get the club
        Dim club = DB.getRecord("clubs", clubId)

        ' Update the form title
        Me.Text = "Roles - " + club("club_name")

        ' Get data for grid
        Dim roles As DataTable

        ' Execute query and load rows into the grid
        roles = DB.getQuery("SELECT * FROM roles")
        RolesDataGridView.DataSource = roles

        ' Edit the columns
        RolesDataGridView.Columns(0).HeaderText = "ID"
        RolesDataGridView.Columns(1).HeaderText = "Name"
        RolesDataGridView.Columns(1).Width = 150

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AssignButton.Click
        ' Get the form service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showClubAssignRoles(RolesDataGridView.CurrentRow.Cells(0).Value, clubId)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RolesDataGridView.CellDoubleClick
        ' Get the form service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showClubAssignRoles(RolesDataGridView.CurrentRow.Cells(0).Value, clubId)
    End Sub

End Class