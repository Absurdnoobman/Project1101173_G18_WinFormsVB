Public Class MainMenuForm
    '
    'f.ShowDialog() Prevents Main Menu Interaction until the f form closed
    '
    Private Sub OpenStaffListButton_Click(sender As Object, e As EventArgs) Handles OpenStaffListButton.Click
        Dim f As New StaffList
        f.ShowDialog()
    End Sub

    Private Sub OpenWardButton_Click(sender As Object, e As MouseEventArgs) Handles OpenWardButton.Click
        Dim f As New WardDetailForm
        f.ShowDialog()
    End Sub

    Private Sub WardAssignmentButton_Click(sender As Object, e As EventArgs) Handles WardAssignmentButton.Click
        Dim f As New StaffWardAssignmentForm
        f.ShowDialog()
    End Sub

    Private Sub OpenPatientButton_Click(sender As Object, e As EventArgs) Handles OpenPatientButton.Click
        Dim f As New CreatePatientForm
        f.ShowDialog()
    End Sub

    Private Sub MakeAppointmentButton_Click(sender As Object, e As EventArgs) Handles MakeAppointmentButton.Click
        Dim f As New ExamineAppointmentForm
        f.ShowDialog()
    End Sub

    Private Sub AllocationButton_Click(sender As Object, e As EventArgs) Handles AllocationButton.Click
        Dim f As New PatientAllocationList
        f.Show()
    End Sub
End Class
