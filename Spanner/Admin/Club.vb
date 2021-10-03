Public Class Club
    Public club As DataRow
    Public clubId As Integer
    Private I As App.Injector

    Public Function validateForm() As Boolean
        Try
            ' Validate each of the fields
            App.Validation.validateField(NameTextBox.Text, "Club Name", New Dictionary(Of String, Object) From {{"required", Nothing}, {"max_length", 50}})
            App.Validation.validateField(AbbreviationTextBox.Text, "Abbreviation", New Dictionary(Of String, Object) From {{"required", Nothing}, {"max_length", 20}})
        Catch ex As Exception
            ' Show the error to the user
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim DB = I.DB

        ' Validate form
        If validateForm() Then
            ' Save data
            Dim data = New Dictionary(Of String, Object)

            ' Set form data
            data("club_name") = NameTextBox.Text
            data("abbreviation") = AbbreviationTextBox.Text
            data("website") = URLTextBox.Text

            ' If no club id set, insert a new one
            If clubId = 0 Then
                ' Insert new club
                DB.insert("clubs", data)
            Else
                ' Edit existing club
                DB.edit("clubs", clubId, data)
            End If

            ' Refresh clubs form
            ClubsForm.onLoad()

            ' Close Form
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub Club_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = My.Application.I

        Dim DB = I.DB

        If clubId = 0 Then
            ' New Club mode

            ' Change button caption
            OKButton.Text = "Add"
        Else
            ' Edit club mode

            ' Change button caption
            OKButton.Text = "Update"

            ' Get the club
            club = DB.getRecord("clubs", clubId)

            ' Populate the fields
            NameTextBox.Text = club("club_name")
            AbbreviationTextBox.Text = club("abbreviation")
            URLTextBox.Text = club("website")
        End If

    End Sub

End Class