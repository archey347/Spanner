Public Class PersonalEventBookingForm

    Public bookingId

    Private I As App.Injector

    Public Sub refreshClasses()
        Dim DB = I.DB

        ' Get the classes
        Dim classes = DB.GetQuery("Select id, (name || "" - "" || description) As display FROM vehicle_classes")

        ClassComboBox.DataSource = classes
        ClassComboBox.DisplayMember = "display"
        ClassComboBox.ValueMember = "id"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ' Save the class
        Dim data = New Dictionary(Of String, Object)
        data("vehicle_class_id") = ClassComboBox.SelectedValue

        Dim DB = I.DB
        DB.edit("event_bookings", bookingId, data)

        Me.Close()
    End Sub

    Private Sub PersonalEventBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = My.Application.I

        ' Load classes
        refreshClasses()

        ' Get the booking
        Dim DB = I.DB
        Dim booking = DB.getRecord("event_bookings", bookingId)

        ' Set the class
        ClassComboBox.SelectedValue = booking("vehicle_class_id")
    End Sub

End Class