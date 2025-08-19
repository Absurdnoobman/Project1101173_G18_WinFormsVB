Public Class StaffCard
    Dim thisStaff As Staff
    Public Sub SetData(s As Staff)
        thisStaff = s
        FirstNameLabel.Text = s.firstname
        SurnameLabel.Text = s.surname
        StaffIdLabel.Text = s.staff_number
        PositionLabel.Text = s.position
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim f = EditStaffForm.WithData(thisStaff)
        f.ShowDialog()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim db As New Schema
        If Not db.Delete("Staffs", "staff_number", thisStaff.staff_number) Then
            MessageBox.Show("Failed to delete a record.")
        End If
        Dispose()
    End Sub
End Class
