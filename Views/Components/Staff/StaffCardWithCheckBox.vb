Public Class StaffCardWithCheckBox
    Public isSelected As Boolean = False
    Public Sub SetData(staff As Staff)
        StaffNumberLabel.Text = staff.Id
        FirstnameLabel.Text = staff.firstname
        SurnameLabel.Text = staff.surname
    End Sub

    Private Sub SelectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectCheckBox.CheckedChanged
        isSelected = SelectCheckBox.Checked
    End Sub
End Class
