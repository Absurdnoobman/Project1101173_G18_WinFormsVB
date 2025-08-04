Public Class StaffCard
    Public Sub SetData(s As Staff)
        FirstNameLabel.Text = s.firstname
        SurnameLabel.Text = s.surname
        StaffIdLabel.Text = s.id
        PositionLabel.Text = s.position
    End Sub

    Private Function Test() As Integer

        Return 69
    End Function

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim f As New EditStaffForm
        f.ShowDialog()
    End Sub

End Class
