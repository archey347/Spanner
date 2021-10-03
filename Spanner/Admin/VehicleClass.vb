Public Class VehicleClassForm

    Public vehicleClassId As Integer
    Public vehicleClass As DataRow

    Private I As App.Injector

    Private Sub VehicleClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get service injector
        I = My.Application.I

        Dim DB = I.DB

        If vehicleClassId = 0 Then
            ' Insert mode

            ' Update btn caption
            OKButton.Text = "Add"
        Else
            ' Update mode

            ' Update btn caption 
            OKButton.Text = "Update"

            ' Get the class
            vehicleClass = DB.getRecord("vehicle_classes", vehicleClassId)

            ' Populate fields
            NameTextBox.Text = vehicleClass("name")
            DescriptionTextBox.Text = vehicleClass("description")


        End If
    End Sub

    Public Function validateForm() As Boolean
        Try
            ' validate each of the fields
            App.Validation.validateField(NameTextBox.Text, "Name", New Dictionary(Of String, Object) From {{"required", Nothing}})
            App.Validation.validateField(DescriptionTextBox.Text, "Description", New Dictionary(Of String, Object) From {{"required", Nothing}})
        Catch ex As Exception
            ' Display message if an exception was thrown
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim DB = I.DB

        ' Validate the form
        If validateForm() Then
            ' Save data
            Dim data = New Dictionary(Of String, Object)

            data("name") = NameTextBox.Text
            data("description") = DescriptionTextBox.Text

            If vehicleClassId = 0 Then
                ' Insert the record
                DB.insert("vehicle_classes", data)
            Else
                ' Edit the existing record
                DB.edit("vehicle_classes", vehicleClassId, data)
            End If
            ' Refresh grid
            VehicleClassesForm.onLoad()

            ' Close the form
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Close the form
        Me.Close()
    End Sub
End Class