Public Class PersonalMembershipRenewForm

    Private I As App.Injector

    Public membershipId

    Private Sub PersonalMembershipRenew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the injector service
        I = My.Application.I

        Dim DB = I.DB

        ' Get any related entities
        Dim membership = DB.getRecord("memberships", membershipId)
        Dim club = DB.getRecord("clubs", membership("club_id"))

        ' Generate SQL
        Dim SQL = ""
        SQL = "SELECT membership_types.id, (membership_types.name || "" (£"" || membership_types.price || "")"") As display FROM membership_types WHERE membership_types.club_id = " + club("id").ToString()

        ' Get data
        Dim table = DB.getQuery(SQL)

        ' Load the membership types into the combobox
        MembershipTypeComboBox.DataSource = table
        MembershipTypeComboBox.DisplayMember = "display"
        MembershipTypeComboBox.ValueMember = "id"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RenewButton.Click
        ' Create a membership request
        Dim data = New Dictionary(Of String, Object)

        data("membership_id") = membershipId
        data("request_type") = "renew"
        data("type_id") = MembershipTypeComboBox.SelectedValue
        data("time_submitted") = Now().Ticks()
        data("is_approved") = 0
        data("is_rejected") = 0

        ' Save to database
        Dim DB = I.DB
        DB.insert("membership_requests", data)

        ' Inform the user
        MsgBox("Your membership request has been sent")

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()

    End Sub

End Class