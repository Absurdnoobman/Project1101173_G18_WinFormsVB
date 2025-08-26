Public Class StaffCard
    Dim thisStaff As Staff
    Public Sub SetData(s As Staff)
        thisStaff = s
        FirstNameLabel.Text = s.firstname
        SurnameLabel.Text = s.surname
        StaffIdLabel.Text = s.staff_number
        PositionLabel.Text = s.position
        AddressLabel.Text = s.address
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim db As New Schema
        Try
            Dim qualifications = db.QueryMulti(Of StaffQualification, Staff, StaffQualification, Object)(
                "SELECT * FROM Staffs_Qualifications WHERE staff_num = @staff",
                Function(q, s) Maps.StaffQualification(s, q),
                fk:="staff_num",
                New With {.staff = thisStaff.staff_number}
            )
            Dim workExps = db.Query(Of StaffWorkExperience, Object)(
                "SELECT * FROM WorkExperiences WHERE staff_num = @staff",
                New With {.staff = thisStaff.staff_number}
            ).Select(Function(w) Maps.StaffWorkExp(thisStaff, w)).ToList


            Dim f = EditStaffForm.WithData(thisStaff, qualifications, workExps)
            f.ShowDialog()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim db As New Schema
        If Not db.Delete("Staffs", "staff_number", thisStaff.staff_number) Then
            MessageBox.Show("Failed to delete a record.")
        End If
        Dispose()
    End Sub
End Class
