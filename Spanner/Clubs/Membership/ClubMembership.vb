Public Class ClubMembershipForm

    Private I As App.Injector

    Public clubId As Integer

    Private Sub Membership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the service injector
        I = My.Application.I
        Dim DB = I.DB

        refreshTable()
    End Sub

    Public Function getQuery() As DataTable
        ' Generate SQL
        Dim SQL = "SELECT memberships.id, users.first_name, users.last_name, membership_types.name, memberships.expires, memberships.is_banned, memberships.is_canceled FROM memberships, users, membership_types WHERE "
        SQL += "memberships.type_id = membership_types.id AND "
        SQL += "users.id = memberships.user_id AND "
        SQL += "memberships.club_id = " + clubId.ToString()

        ' Go through the filters
        If Not FilterBannedCheckbox.Checked Then
            SQL += " AND is_banned = 0"
        End If

        If Not FilterCanceledCheckbox.Checked Then
            SQL += " AND is_canceled = 0"
        End If

        If Not FilterLapsedCheckbox.Checked Then
            ' Membership is valid if the expiry date is in the future
            SQL += " AND expires > " + Now().Ticks.ToString()
        End If

        Dim DB = I.DB

        ' Get the data
        Return DB.GetQuery(SQL)
    End Function

    Public Sub refreshTable()

        ' Fetch the data
        Dim table = getQuery()

        ' Add to grid
        MembershipsDataGridView.DataSource = table

        ' Set the columns
        MembershipsDataGridView.Columns(0).HeaderText = "ID"
        MembershipsDataGridView.Columns(1).HeaderText = "First Name"
        MembershipsDataGridView.Columns(2).HeaderText = "Last Name"
        MembershipsDataGridView.Columns(3).HeaderText = "Type"
        MembershipsDataGridView.Columns(3).Width = 50
        MembershipsDataGridView.Columns(4).HeaderText = "Expires"
        MembershipsDataGridView.Columns(4).Width = 75
        MembershipsDataGridView.Columns(5).HeaderText = "Is Banned"
        MembershipsDataGridView.Columns(6).HeaderText = "Is Canceled"

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MembershipsDataGridView.CellFormatting
        If e.ColumnIndex = 4 Then
            ' If it is the expires column, then format the date
            Dim expires = New DateTime(CLng(e.Value))
            e.Value = expires.ToShortDateString()
        ElseIf {5, 6}.Contains(e.ColumnIndex) Then
            ' If boolean convert to yes/no
            If e.Value = 0 Then
                e.Value = "No"
            Else
                e.Value = "Yes"
            End If

        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles MembershipsDataGridView.SelectionChanged

        ' Update ban/unban user buttons
        If MembershipsDataGridView.CurrentRow.Cells(5).Value = 0 Then
            BanUserButton.Text = "Ban Selected User"
        Else
            BanUserButton.Text = "Unban Selected User"
        End If

        If MembershipsDataGridView.CurrentRow.Cells(6).Value = 0 Then
            CancelButton.Text = "Cancel Memberhsip"
        Else
            CancelButton.Text = "Uncancel Membership"
        End If
    End Sub

    Private Sub BtnBan_Click(sender As Object, e As EventArgs) Handles BanUserButton.Click
        ' Get their name
        Dim name As String = MembershipsDataGridView.CurrentRow.Cells(1).Value + " " + MembershipsDataGridView.CurrentRow.Cells(2).Value
        Dim memberId = MembershipsDataGridView.CurrentRow.Cells(0).Value

        Dim result As MsgBoxResult

        Dim is_banned = MembershipsDataGridView.CurrentRow.Cells(5).Value

        If is_banned = 0 Then
            ' Ban The user
            result = MsgBox("Are you sure you want to ban " + name + "?", MsgBoxStyle.YesNo)
            is_banned = 1
        Else
            ' Unban the user
            result = MsgBox("Are you sure you want to unban " + name + "?", MsgBoxStyle.YesNo)
            is_banned = 0
        End If

        ' Only change if user selected Yes
        If result = MsgBoxResult.Yes Then

            ' Create the array
            Dim data As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            data("is_banned") = is_banned

            Dim DB = I.DB

            ' Save
            DB.edit("memberships", memberId, data)

            ' Refresh
            refreshTable()
        End If
    End Sub

    Private Sub FilterLapsed_CheckedChanged(sender As Object, e As EventArgs) Handles FilterLapsedCheckbox.CheckedChanged, FilterBannedCheckbox.CheckedChanged, FilterCanceledCheckbox.CheckedChanged
        ' Refresh
        refreshTable()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Get their name
        Dim name As String = MembershipsDataGridView.CurrentRow.Cells(1).Value + " " + MembershipsDataGridView.CurrentRow.Cells(2).Value
        Dim memberId = MembershipsDataGridView.CurrentRow.Cells(0).Value

        Dim result As MsgBoxResult

        Dim canceled = MembershipsDataGridView.CurrentRow.Cells(6).Value

        If canceled = 0 Then
            ' Ban The user
            result = MsgBox("Are you sure you want to cancel the membership for " + name + "?", MsgBoxStyle.YesNo)
            canceled = 1
        Else
            ' Uncancel the user
            result = MsgBox("Are you sure you want to uncancel the membership for " + name + "?", MsgBoxStyle.YesNo)
            canceled = 0
        End If

        ' Only change if user selected Yes
        If result = MsgBoxResult.Yes Then

            ' Create the array
            Dim data As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            data("is_canceled") = canceled

            Dim DB = I.DB

            ' Save
            DB.edit("memberships", memberId, data)

            ' Refresh
            refreshTable()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewUserButton.Click
        Dim DB = I.DB

        ' Need to get the user id
        ' Fetch the membership
        Dim membership As DataRow = DB.getRecord("memberships", MembershipsDataGridView.CurrentRow.Cells(0).Value)

        Dim Forms = I.Forms

        ' Show the form
        Forms.showPersonalDetails(membership("user_id"))
    End Sub

    Private Sub ClubMembership_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        refreshTable()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExportMembershipCardButton.Click

        Dim DB = I.DB

        ' Get all of the entities
        Dim membership As DataRow = DB.getRecord("memberships", MembershipsDataGridView.CurrentRow.Cells(0).Value)
        Dim club As DataRow = DB.getRecord("clubs", membership("club_id"))
        Dim membership_type As DataRow = DB.getRecord("membership_types", membership("type_id"))
        Dim user As DataRow = DB.getRecord("users", membership("user_id"))

        ' Common information used
        Dim expires = New Date(membership("expires")).ToShortDateString()
        Dim name = user("first_name") + " " + user("last_name")

        ' Get the user to select where they want to save the file
        Dim selectFile As SaveFileDialog = New SaveFileDialog

        ' Set filter
        selectFile.Filter = "PDF (*.pdf)|*.pdf"
        ' Set suggested filename
        selectFile.FileName = club("abbreviation") + " " + name + " Membership Card"

        If Not selectFile.ShowDialog() = DialogResult.OK Then
            Exit Sub
        End If

        Dim html = "
<html>
    <table style='width: 100%; height: 200px; border-collapse: collapse;'>
        <tr>
            <td style='border: 2px solid #3c3c3c; width: 50%; padding: 5px;'>
                <h3>Membership Card</h3>
                <h4>" + club("club_name") + "</h4>
                <p>" + name + "</p>
                <p>Expires: " + expires + "</p>
            </td>
            <td style='border: 2px solid #3c3c3c; width: 50%; padding: 5px;'>
            <p>
                This is to certify that " + user("first_name") + " " + user("last_name") + " is a duly elected member paid up for " + expires + "
                and is therefore, authorised by Motorsport UK to take part as a driver/passenger in all competitions confined to members of this
                club or defined up to the Clubman's events under Motorsport UK regulations of the Motorsport UK and ALRC regulations
            </p>
            <p>
                Signature of Member:
            </p>
            </td>
    </table>
</html>
"

        ' Convert HTML to PDF
        Dim converter = New NReco.PdfGenerator.HtmlToPdfConverter()

        converter.GeneratePdf(html, "", selectFile.FileName)

        ' Open PDF file
        Process.Start(selectFile.FileName)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ExportMembershipListButton.Click
        ' Create the save file dialog
        Dim selectFile As SaveFileDialog = New SaveFileDialog

        Dim DB = I.DB

        Dim club = DB.getRecord("clubs", clubId)

        ' Setup the filter and filename for the save file dialog
        selectFile.Filter = "PDF (*.pdf)|*.pdf"
        selectFile.FileName = Now().Year().ToString + "_" + Now().Month().ToString + "_" + Now().Day().ToString + " " + club("abbreviation") + " Membership List"

        ' Exit if canceled
        If Not selectFile.ShowDialog() = DialogResult.OK Then
            Exit Sub
        End If

        ' Fetch the data with filters
        Dim table = getQuery()


        ' Generate Headers
        Dim html = "
<html>
    <h2>Membership List - " + club("club_name") + "</h2>
    <p>Printed " + Now().ToShortDateString + "</p>
    <table style='border-collapse: collapse; width: 100%;'>
        <tr>
            <th style='border: 1px solid black; padding: 4px;'>First Name</th>
            <th style='border: 1px solid black; padding: 4px;'>Last Name</th>
            <th style='border: 1px solid black; padding: 4px;'>Type</th>
            <th style='border: 1px solid black; padding: 4px;'>Expires</th>
            <th style='border: 1px solid black; padding: 4px;'>Is Banned</th>
            <th style='border: 1px solid black; padding: 4px;'>Is Canceled</th>
        </tr>
"
        ' Add row for each member
        For Each row In table.Rows
            Dim expires = New Date(row("expires")).ToShortDateString

            Dim is_banned, is_canceled

            ' Banned Column
            If row("is_banned") = 1 Then
                is_banned = "Yes"
            Else
                is_banned = "No"
            End If

            ' Canceled Column
            If row("is_canceled") = 1 Then
                is_canceled = "Yes"
            Else
                is_canceled = "No"
            End If

            ' Generate row HTML
            Dim rowHTML = "<tr>
                <td style='border: 1px solid black; padding: 4px;'>" + row("first_name") + "</td>
                <td style='border: 1px solid black; padding: 4px;'>" + row("last_name") + "</td>
                <td style='border: 1px solid black; padding: 4px;'>" + row("name") + "</td>
                <td style='border: 1px solid black; padding: 4px;'>" + expires + "</td>
                <td style='border: 1px solid black; padding: 4px;'>" + is_banned + "</td>
                <td style='border: 1px solid black; padding: 4px;'>" + is_canceled + "</td>

            </tr>
"           ' Add to table
            html += rowHTML
        Next
        ' Close html tags
        html += "</table></html>"

        ' Convert to PDF
        Dim converter = New NReco.PdfGenerator.HtmlToPdfConverter()

        converter.GeneratePdf(html, "", selectFile.FileName)
        ' Open PDF
        Process.Start(selectFile.FileName)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles EditMembershipTypesButton.Click
        ' Get Forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showMembershipTypes(clubId)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles CreateUserButton.Click
        Dim Forms = I.Forms
        ' Create the user
        Dim userId = Forms.showPersonalDetailsAsDialog(0).ToString()

        ' Only continue if a user was created
        If userId <> 0 Then
            Dim DB = I.DB

            ' Get the user
            Dim user = DB.getRecord("users", userId)

            ' Create the membership
            Dim data = New Dictionary(Of String, Object)

            ' Will need a membership request create thingy here

            data("user_id") = userId
            data("club_id") = clubId
            data("type_id") = 0
            data("expires") = user("date_of_birth")
            data("is_banned") = 0
            data("is_canceled") = 0

            Dim membershipId = DB.insert("memberships", data)

            ' Create a membership request
            Forms.showClubMembershipRequestNewWithUser(clubId, membershipId)

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MembershipRequestsButton.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the form
        Forms.showClubMembershipRequests(clubId)
    End Sub

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        Dim Forms = I.Forms
        ' Create the user
        Dim userId = Forms.showClubMembershipSelectUser(clubId)

        ' Only continue if a user was selected
        If userId <> 0 Then
            Dim DB = I.DB

            ' Get the user
            Dim user = DB.getRecord("users", userId)

            ' Create the membership
            Dim data = New Dictionary(Of String, Object)

            ' Will need a membership request create thingy here

            data("user_id") = userId
            data("club_id") = clubId
            data("type_id") = 0
            data("expires") = user("date_of_birth")
            data("is_banned") = 0
            data("is_canceled") = 0

            Dim membershipId = DB.insert("memberships", data)

            ' Create a membership request
            Forms.showClubMembershipRequestNewWithUser(clubId, membershipId)

        End If
    End Sub
End Class