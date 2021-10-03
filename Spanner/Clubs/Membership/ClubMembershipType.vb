Public Class ClubMembershipTypeForm

    Public membershipTypeId As Integer
    Public clubId As Integer

    Private I As App.Injector

    Private Sub ClubMembershipType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = My.Application.I

        If membershipTypeId = 0 Then
            ' Create mode
            PriceTextBox.Text = 0
            JoinPriceTextBox.Text = 0
        Else
            Dim DB = I.DB

            ' Get the membership type
            Dim type = DB.getRecord("membership_types", membershipTypeId)

            ' Set the values
            NameTextBox.Text = type("name")
            PriceTextBox.Text = type("price")
            JoinPriceTextBox.Text = type("join_price")
        End If
    End Sub

    Public Function validateForm() As Boolean
        Try
            ' Validate each of the inputs
            App.Validation.validateField(NameTextBox.Text, "Name", New Dictionary(Of String, Object) From {{"required", Nothing}, {"max_length", 30}})
            App.Validation.validateField(PriceTextBox.Text, "Price", New Dictionary(Of String, Object) From {{"required", Nothing}, {"float", Nothing}})
            App.Validation.validateField(JoinPriceTextBox.Text, "Join Price", New Dictionary(Of String, Object) From {{"required", Nothing}, {"float", Nothing}})
        Catch ex As Exception
            ' Warn the user if validation failed
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ' Validate the form
        If validateForm() Then
            ' Set data
            Dim data As New Dictionary(Of String, Object)

            data("name") = NameTextBox.Text
            data("price") = PriceTextBox.Text
            data("join_price") = JoinPriceTextBox.Text
            data("club_id") = clubId

            Dim DB = I.DB

            If membershipTypeId = 0 Then
                ' Insert
                DB.insert("membership_types", data)
            Else
                ' Edit
                DB.edit("membership_types", membershipTypeId, data)
            End If
            ' Close the form
            Me.Close()
        End If
    End Sub

End Class