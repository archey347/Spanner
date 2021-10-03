Public Class MainForm

    Public I As App.Injector

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Close the application
        Application.Exit()
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click

        Dim Session = I.Session

        ' Logout of session
        Session.logout()

        ' Close all of the forms exluding this one
        For Each Form In My.Application.OpenForms
            If Not Form.Name = Me.Name Then
                Form.Close()
            End If
        Next

        ' Hide this one
        Me.Hide()

        Dim Forms = I.Forms

        ' Show the login form
        Forms.login()

        Me.Show()
    End Sub

    Public Sub onLoad()

        I = My.Application.I

        Dim Session = I.Session
        Dim ACL = I.ACL

        If Me.Visible Then
            ' Load everything needed

            ' Update the status bar with the user's details
            StatusName.Text = Session.user("first_name") + " " + Session.user("last_name")
            StatusUsername.Text = "(" + Session.user("username") + ")"

            ' Show the admin box if admin
            BoxAdmin.Visible = (Session.user("is_admin") = 1)

            ' Clubs
            Dim clubs As DataTable = ACL.getAdminClubs(Session.user("ID"))

            ' Admin with no clubs, so hide clubs box
            BoxClubs.Visible = (clubs.Rows.Count > 0) Or (Session.user("is_admin"))

            ' Clear all previous buttons
            FlowLayoutPanel1.Controls.Clear()

            For Each row In clubs.Rows
                ' Create a new button
                Dim btn As Button = New Button()
                btn.Size = New Drawing.Size(250, 30)
                ' Set the size
                btn.Text = row("club_name")
                ' Store ID in tag so the button knows what club to load
                btn.Tag = row("ID")

                ' Add event handler
                AddHandler btn.Click, AddressOf Club_Click

                ' Add the button to the form
                FlowLayoutPanel1.Controls.Add(btn)

            Next
        Else
            ' Clear the form
            FlowLayoutPanel1.Controls.Clear()
            BoxAdmin.Visible = False
        End If
    End Sub

    Private Sub Main_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Me.onLoad()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PersonalDetailsButton.Click
        Dim Forms = I.Forms
        Dim Session = I.Session

        Forms.showPersonalDetails(Session.user("id"))
    End Sub

    Private Sub Club_Click(sender As Object, e As EventArgs)
        Dim Forms = I.Forms

        Forms.showClubAdmin(sender.Tag)
    End Sub

    Private Sub Main_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Me.onLoad()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.onLoad()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ClubsAdminButton.Click
        Dim Forms = I.Forms
        Forms.showClubs()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles VehicleClassesAdminButton.Click
        Dim Forms = I.Forms
        Forms.showVehicleClasses()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PersonalMembershipButton.Click
        Dim Forms = I.Forms
        Dim Session = I.Session
        Forms.showPersonalMembership(Session.user("id"))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles PersonalEventBookingsButton.Click
        Dim Forms = I.Forms
        Dim Session = I.Session
        Forms.showPersonalEvents(Session.user("id"))
    End Sub

End Class