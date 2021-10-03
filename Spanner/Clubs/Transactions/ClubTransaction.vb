Public Class ClubTransactionForm

    Public transactionId As Integer
    Public clubId As Integer

    Private I As App.Injector

    Private Sub ClubTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the injector service
        I = My.Application.I
        ' Load the DB service
        Dim DB = I.DB

        ' If transactionID isn't zero, then load the transaction from the DB
        If transactionId <> 0 Then
            Dim transaction = DB.getRecord("transactions", transactionId)

            ' Populate fields with transaction
            ReferenceTextBox.Text = transaction("name")
            BankedDateTimePicker.Value = New Date(CLng(transaction("date_paid")))
        End If
    End Sub

    Private Function validateForm() As Boolean
        ' Validate the form
        Try
            App.Validation.validateField(ReferenceTextBox.Text, "Reference", New Dictionary(Of String, Object) From {{"required", Nothing}, {"max_length", 100}})
        Catch ex As Exception
            ' Inform the user if there was an error
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ' Validate form
        If validateForm() Then
            ' Add data to array
            Dim data = New Dictionary(Of String, Object)
            data("name") = ReferenceTextBox.Text
            data("date_paid") = BankedDateTimePicker.Value.Ticks
            data("club_id") = clubId

            ' Get the DB service
            Dim DB = I.DB

            ' Check if edit or insert
            If transactionId = 0 Then
                ' Set some other values
                data("total") = 0

                ' Get the current  session
                Dim Session = I.Session

                ' Set who accepted the payment
                data("paid_in_by") = Session.user("id")
                DB.insert("transactions", data)
            Else
                DB.edit("transactions", transactionId, data)
            End If
            ' Close
            Me.Close()
        End If
    End Sub

End Class