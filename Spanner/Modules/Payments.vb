Namespace App
    ' This service handles the creation of any payments
    Public Class Payments

        Private DB As App.Database

        Public Sub New(DB As App.Database)
            Me.DB = DB
        End Sub

        ' create
        '
        ' Integer userId   - The id of the user paying
        ' Integer clubId   - The club who is being paid
        ' Double  amount   - The amount being paid
        ' String  itemType - The type of item being paid for (event or membership)
        ' Integer itemId   - The id of the item being paid for
        '
        ' Returns the id of the payment
        Public Function create(userId As Integer, clubId As Integer, amount As Double, itemType As String, itemId As Integer)

            Dim data = New Dictionary(Of String, Object)

            data("user_id") = userId
            data("club_id") = clubId
            data("amount") = amount
            data("item_type") = itemType
            data("item_id") = itemId
            data("transaction_id") = 0

            Return DB.insert("payments", data)
        End Function

        ' getItemName
        ' Gets a readable name for a payment item
        ' 
        ' String  type - the type of item (membership or event)
        ' Integer id   - the id of the item
        '
        ' Returns a readable string
        Function getItemName(type As String, id As Integer) As String
            If type = "membership" Then
                Dim request = DB.getRecord("membership_requests", id)
                Dim mem_type = DB.getRecord("membership_types", request("type_id"))
                Return mem_type("name")
            ElseIf type = "event" Then
                Dim booking = DB.getRecord("event_bookings", id)
                Dim ev = DB.getRecord("events", booking("event_id"))
                Return ev("name")
            End If
            Return ""
        End Function

    End Class

End Namespace