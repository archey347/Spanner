Public Class ClubEventForm

    Private I As App.Injector

    Public eventId As Integer
    Public clubId As Integer

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim DB = I.DB

        If validateForm() Then
            ' Create data array
            Dim data = New Dictionary(Of String, Object)

            data("name") = NameTextBox.Text
            data("start_date") = StartDateTimePicker.Value.Ticks
            data("end_date") = EndDateTimePicker.Value.Ticks
            If CompetitiveCheckbox.Checked Then
                data("is_competitive") = 1
            Else
                data("is_competitive") = 0
            End If
            data("price") = PriceTextBox.Text

            If eventId = 0 Then
                data("club_id") = clubId
                ' Create new event
                DB.insert("events", data)
            Else
                ' Edit existing events
                DB.edit("events", eventId, data)
            End If
            ' Close the form
            Me.Close()
        End If
    End Sub

    Private Sub ClubEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the service injector
        I = My.Application.I
        Dim DB = I.DB

        ' If no event given, then insert
        If eventId <> 0 Then
            ' Get the event
            Dim clubEvent = DB.getRecord("events", eventId)

            ' Set fields
            NameTextBox.Text = clubEvent("name")
            StartDateTimePicker.Value = New DateTime(clubEvent("start_date"))
            EndDateTimePicker.Value = New DateTime(clubEvent("end_date"))
            CompetitiveCheckbox.Checked = clubEvent("is_competitive")
            PriceTextBox.Text = clubEvent("price")

        End If
    End Sub

    Public Function validateForm() As Boolean
        Try
            ' Name is required and max length
            App.Validation.validateField(NameTextBox.Text, "Name", New Dictionary(Of String, Object) From {{"required", Nothing}, {"max_length", 100}})
            ' Needs to be after today
            App.Validation.validateField(StartDateTimePicker.Value, "Start Date", New Dictionary(Of String, Object) From {{">", Now}})
            ' After date needs to be before start date
            App.Validation.validateField(EndDateTimePicker.Value, "End Date", New Dictionary(Of String, Object) From {{"=>", StartDateTimePicker.Value}})

            App.Validation.validateField(PriceTextBox.Text, "Price", New Dictionary(Of String, Object) From {{"required", Nothing}, {"float", Nothing}})
        Catch ex As Exception
            ' Inform user if validation failed
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

End Class