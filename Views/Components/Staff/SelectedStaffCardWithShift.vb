Public Class SelectedStaffCardWithShift

    Private _staff As Staff

    Public Property NewProperty() As Staff
        Get
            Return _staff
        End Get
        Set(value As Staff)
            _staff = value
        End Set
    End Property

    Public Sub SetData(staff As Staff)
        _staff = staff
        StaffNumberLabel.Text = staff.staff_number
        FullNameLabel.Text = $"{staff.firstname} {staff.surname}"
    End Sub

    Private Sub SelectedStaffCardWithShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShiftComboBox.SelectedIndex = 0
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dispose()

    End Sub
End Class
