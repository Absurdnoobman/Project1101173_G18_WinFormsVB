Public Class StaffCardWithCheckBox
    Public Sub SetData(staff As Staff)
        StaffNumberLabel.Text = staff.Id
        FirstnameLabel.Text = staff.firstname
        SurnameLabel.Text = staff.surname
    End Sub
End Class
