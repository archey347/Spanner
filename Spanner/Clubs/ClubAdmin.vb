Public Class ClubAdminForm

    Public clubId As Integer
    Public club As DataRow

    Private I As App.Injector

    Public MembershipButton, EventsButton, RolesButton, PaymentsButton, ExitButton As Button

    Private Sub ClubAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = My.Application.I

        Dim DB = I.DB
        Dim ACL = I.ACL
        Dim Session = I.Session

        club = DB.getRecord("clubs", clubId)

        ' Update the title
        ClubNameLabel.Text = club("club_name")
        ClubAbbreviationLabel.Text = club("abbreviation")
        URLLabel.Text = club("website")

        ' Clear the existing buttons
        ClubActionsFlowLayoutPanel.Controls.Clear()

        ' Show the buttons

        ' Add the membership button if they have permission
        If ACL.hasRole(Session.user("id"), clubId, {"Membership Secretary", "Chairman"}) Then
            MembershipButton = New Button()
            ' Set the size
            MembershipButton.Size = New Drawing.Size(200, 25)
            ' Set the caption
            MembershipButton.Text = "Membership"
            ' Bind onclick event
            AddHandler MembershipButton.Click, AddressOf onMembershipClick
            ' Add to form
            ClubActionsFlowLayoutPanel.Controls.Add(MembershipButton)
        End If
        ' Add the events button if they have permission
        If ACL.hasRole(Session.user("id"), clubId, {"Competition Secretary", "Chairman"}) Then
            EventsButton = New Button()
            ' Set the size
            EventsButton.Size = New Drawing.Size(200, 25)
            ' Set the caption
            EventsButton.Text = "Events"
            ' Bind onclick event
            AddHandler EventsButton.Click, AddressOf onEventsClick
            ' Add to form
            ClubActionsFlowLayoutPanel.Controls.Add(EventsButton)
        End If
        ' Add the roles button if they have permission
        If ACL.hasRole(Session.user("id"), clubId, {"Chairman"}) Then
            RolesButton = New Button()
            ' Set the size
            RolesButton.Size = New Drawing.Size(200, 25)
            ' Set the caption
            RolesButton.Text = "Roles"
            ' Bind onclick event
            AddHandler RolesButton.Click, AddressOf onRolesClick
            ' Add to form
            ClubActionsFlowLayoutPanel.Controls.Add(RolesButton)
        End If
        ' Add the payments button if they have permission
        If ACL.hasRole(Session.user("id"), clubId, {"Chairman", "Treasurer", "Competition Secretary", "Membership Secretary"}) Then
            PaymentsButton = New Button()
            ' Set the size
            PaymentsButton.Size = New Drawing.Size(200, 25)
            ' Set the caption
            PaymentsButton.Text = "Payments"
            ' Bind onclick event
            AddHandler PaymentsButton.Click, AddressOf onPaymentsClick
            ' Add to form
            ClubActionsFlowLayoutPanel.Controls.Add(PaymentsButton)
        End If
        ' Finally a close button
        ExitButton = New Button()
        ' Set the size
        ExitButton.Size = New Drawing.Size(200, 25)
        ' Set the caption
        ExitButton.Text = "Exit"
        ' Add the onclick event
        AddHandler ExitButton.Click, AddressOf onExitClick
        ' Add to the form
        ClubActionsFlowLayoutPanel.Controls.Add(ExitButton)

    End Sub

    Public Sub onMembershipClick(sender As Object, e As EventArgs)
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the membership
        Forms.showMembership(clubId)
    End Sub

    Private Sub ClubActionsFlowLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles ClubActionsFlowLayoutPanel.Paint

    End Sub

    Public Sub onEventsClick(sender As Object, e As EventArgs)
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the events
        Forms.showEvents(clubId)
    End Sub

    Public Sub onRolesClick(sender As Object, e As EventArgs)
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the roles
        Forms.showRoles(clubId)
    End Sub

    Public Sub onPaymentsClick(sender As Object, e As EventArgs)
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the transactions
        Forms.showClubTransactions(clubId)
    End Sub

    Public Sub onExitClick(sender As Object, e As EventArgs)
        ' Close the form
        Me.Close()
    End Sub

End Class