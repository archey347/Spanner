Public Class VehicleClassesForm

    Private I As App.Injector

    Private Sub VehicleClasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the services injector
        I = My.Application.I

        ' Load the table
        onLoad()
    End Sub

    Public Sub onLoad()
        Dim DB = I.DB

        ' Get the vehicle classes
        Dim SQL As String = "SELECT * FROM vehicle_classes"
        Dim data As DataTable = DB.GetQuery(SQL)

        ' Load into the data grid view
        VehicleClassesDataGridView.DataSource = data

        ' Update columns
        VehicleClassesDataGridView.Columns(0).HeaderText = "ID"
        VehicleClassesDataGridView.Columns(1).HeaderText = "Name"
        VehicleClassesDataGridView.Columns(2).HeaderText = "Description"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddClassButton.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Shoe the vehicle class
        Forms.showVehicleClass(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EditClassButton.Click
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the vehicle class
        Forms.showVehicleClass(VehicleClassesDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VehicleClassesDataGridView.CellDoubleClick
        ' Get the forms service
        Dim Forms = I.Forms
        ' Show the vehicle class
        Forms.showVehicleClass(VehicleClassesDataGridView.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub VehicleClasses_Enter(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh the table when the form comes into focus
        onLoad()
    End Sub

End Class