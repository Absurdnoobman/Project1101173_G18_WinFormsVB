Imports Microsoft.VisualBasic.ApplicationServices

Public Class MainMenuForm
    '
    'f.ShowDialog() Prevents Main Menu Interaction until the f form closed
    '

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New LoginForm
        Dim result = f.ShowDialog()
        If result = DialogResult.No Or result = DialogResult.Cancel Then
            Dispose()
        End If

        If Auth.User() IsNot Nothing Then
            UserLabel.Text = $"User: {Auth.User.firstname} {Auth.User.surname}"
            PositionLabel.Text = $"Login as a(n) {Auth.User.position}"
        End If

        renderStats()

    End Sub
    Private Sub OpenStaffListButton_Click(sender As Object, e As EventArgs) Handles OpenStaffListButton.Click
        If Auth.User.position <> "Personnel Officer" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New StaffList
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub OpenWardButton_Click(sender As Object, e As MouseEventArgs) Handles OpenWardButton.Click
        If Auth.User.position <> "Personnel Officer" AndAlso Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New WardDetailForm
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub WardAssignmentButton_Click(sender As Object, e As EventArgs) Handles WardAssignmentButton.Click
        If Auth.User.position <> "Personnel Officer" AndAlso Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New StaffWardAssignmentForm
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub OpenPatientButton_Click(sender As Object, e As EventArgs) Handles OpenPatientButton.Click
        Dim f As New PatientList
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub MakeAppointmentButton_Click(sender As Object, e As EventArgs) Handles MakeAppointmentButton.Click
        Dim f As New ExaminationForm
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub AllocationButton_Click(sender As Object, e As EventArgs) Handles AllocationButton.Click
        If Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "Medical Director" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If


        Dim f As New PatientAllocationList
        f.Show()

        renderStats()
    End Sub

    Private Sub MedicationButton_Click(sender As Object, e As EventArgs) Handles MedicationButton.Click
        If Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New MedicationForm
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub ReviewStaffButton_Click(sender As Object, e As EventArgs) Handles ReviewStaffButton.Click
        If Auth.User.position <> "Personnel Officer" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If


        Dim f As New StaffReviewForm
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub AppointmentButton_Click(sender As Object, e As EventArgs) Handles AppointmentButton.Click
        Dim user = Auth.User

        If user.position <> "Charge Nurse" AndAlso user.position <> "Medical Director" AndAlso user.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New AppointmentList
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub NewAllocationButton_Click(sender As Object, e As EventArgs) Handles NewAllocationButton.Click
        If Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New NewPatientAllocationForm
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub MedicationReportButton_Click(sender As Object, e As EventArgs) Handles MedicationReportButton.Click
        If Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New MedicationReport
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub ReviewSumButton_Click(sender As Object, e As EventArgs) Handles ReviewSumButton.Click
        If Auth.User.position <> "Personnel Officer" AndAlso Auth.User.position <> "System Administrator" Then
            MessageBox.Show("Can not access due to your position.")
            Exit Sub
        End If

        Dim f As New ReviewSummaryForm
        f.ShowDialog()

        renderStats()
    End Sub

    Private Sub LoguotButton_Click(sender As Object, e As EventArgs) Handles LoguotButton.Click
        If MessageBox.Show("Do you want to logout and restart the program now?", "Restart", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Auth.Logout()
            Application.Restart()
        End If
    End Sub

    Private Sub renderStats()

        Dim db As New Schema
        Try
            Dim staff_count = db.QuerySingle(Of Integer, Object)("SELECT COUNT(*) FROM Staffs")
            TotalStaffLabel.Text = staff_count
        Catch ex As Exception
            MessageBox.Show("Error: Can not get 'staff total number' stats." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
            TotalStaffLabel.Text = "error"
        End Try

        Try
            Dim admission_count = db.QuerySingle(Of Integer, Object)("SELECT COUNT(*) FROM Admissions WHERE actual_discharge_date IS NULL")
            InPatientsLabel.Text = admission_count
        Catch ex As Exception
            MessageBox.Show("Error: Can not get 'admission' stats." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
            InPatientsLabel.Text = "error"
        End Try

        Try
            Dim today_appointments = db.QuerySingle(Of Integer, Object)("SELECT COUNT(*) FROM Appointments WHERE CAST(appointment_date_time AS DATE) = CAST( GETDATE() AS DATE)")
            TodayAppointmentLabel.Text = today_appointments
        Catch ex As Exception
            MessageBox.Show("Error: Can not get 'today appointment' stats." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
            TodayAppointmentLabel.Text = "error"
        End Try

        Try
            Dim medications = db.QuerySingle(Of Integer, Object)("SELECT COUNT(*) FROM MedicationRecords WHERE start_date = CAST( GETDATE() AS date)")
            TodayMedicationLabel.Text = medications
        Catch ex As Exception
            MessageBox.Show("Error: Can not get 'today prescriptions' stats." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
            TodayMedicationLabel.Text = "error"
        End Try
    End Sub

End Class
