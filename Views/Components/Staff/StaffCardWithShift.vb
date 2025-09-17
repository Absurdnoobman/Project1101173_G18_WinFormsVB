Public Class StaffCardWithShift

    Private _staff As Staff

    Public Property Staff As Staff
        Get
            Return _staff
        End Get
        Set(value As Staff)
            _staff = value
        End Set
    End Property

    Public shift As String

    Public Sub SetData(staff As Staff, Optional shift As String = "Early")
        _staff = staff
        StaffNumberLabel.Text = staff.staff_number
        FullNameLabel.Text = $"{staff.firstname} {staff.surname}"

        ShiftComboBox.SelectedItem = shift
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dispose()

    End Sub

    Private Sub ShiftComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShiftComboBox.SelectedIndexChanged
        shift = ShiftComboBox.SelectedItem
    End Sub
End Class
