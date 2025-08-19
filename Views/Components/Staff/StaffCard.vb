Public Class StaffCard
    Dim thisStaff As Staff
    Public Sub SetData(s As Staff)
        thisStaff = s
        FirstNameLabel.Text = s.firstname
        SurnameLabel.Text = s.surname
        StaffIdLabel.Text = s.staff_number
        PositionLabel.Text = s.position
    End Sub

    Private Function Test() As Integer

        Return 69
    End Function

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim f = EditStaffForm.WithData(thisStaff)
        f.ShowDialog()
    End Sub

End Class
