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
        Dim f As New PatientList
        f.ShowDialog()
    End Sub

    Private Sub MakeAppointmentButton_Click(sender As Object, e As EventArgs) Handles MakeAppointmentButton.Click
        Dim f As New ExaminationForm
        f.ShowDialog()
    End Sub

    Private Sub AllocationButton_Click(sender As Object, e As EventArgs) Handles AllocationButton.Click
        Dim f As New PatientAllocationList
        f.Show()
    End Sub

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New LoginForm
        Dim result = f.ShowDialog()
        If result = DialogResult.No Or result = DialogResult.Cancel Then
            Dispose()
        End If

        If Auth.User() IsNot Nothing Then
            Label2.Text = $"Welcome {Auth.User.firstname}, Position: {Auth.User.position}"
        End If

    End Sub

    Private Sub NewSupplyButton_Click(sender As Object, e As EventArgs)
        Dim f As New CreateSupplyForm
        f.ShowDialog()
    End Sub

    Private Sub MedicationButton_Click(sender As Object, e As EventArgs) Handles MedicationButton.Click
        Dim f As New MedicationForm
        f.ShowDialog()
    End Sub

    Private Sub NewPharmaSupplyButton_Click(sender As Object, e As EventArgs)
        Dim f As New CreateNewPharmaceuticalSupply
        f.ShowDialog()
    End Sub

    Private Sub ReviewStaffButton_Click(sender As Object, e As EventArgs) Handles ReviewStaffButton.Click
        Dim f As New StaffReviewForm
        f.ShowDialog()
    End Sub

    Private Sub AppointmentButton_Click(sender As Object, e As EventArgs) Handles AppointmentButton.Click
        Dim f As New AppointmentList
        f.ShowDialog()
    End Sub

    Private Sub NewAllocationButton_Click(sender As Object, e As EventArgs) Handles NewAllocationButton.Click
        Dim f As New NewPatientAllocationForm
        f.ShowDialog()
    End Sub

    Private Sub MedicationReportButton_Click(sender As Object, e As EventArgs) Handles MedicationReportButton.Click
        Dim f As New MedicationReport
        f.ShowDialog()
    End Sub

    Private Sub ReviewSumButton_Click(sender As Object, e As EventArgs) Handles ReviewSumButton.Click
        Dim f As New ReviewSummaryForm
        f.ShowDialog()
    End Sub
End Class
