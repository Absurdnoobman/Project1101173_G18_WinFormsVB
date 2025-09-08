Public Class NewAppointmentForm
	Private Sub SelectPatientButton_Click(sender As Object, e As EventArgs) Handles SelectPatientButton.Click
		Dim f As New PickPatientDialog
		Dim result = f.ShowDialog()
		If result = DialogResult.Abort OrElse result = DialogResult.Cancel Then Exit Sub

		Dim picked_patient = f.result.First

		Dim card As New PatientLargeCard(picked_patient)

		PatientFLP.Controls.Add(card)
	End Sub

	Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
		PatientFLP.Controls.Clear()
		AppointmentDTP.Value = Date.Today
		MeetTimeDateTimePicker.Value = Date.Now
		ClinicIdTextBox.Clear()
	End Sub

	Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
		If PatientFLP.Controls.Count = 0 Then
			MessageBox.Show("Please Select a patient.")
			Exit Sub
		End If
		If String.IsNullOrEmpty(ClinicIdTextBox.Text) OrElse String.IsNullOrWhiteSpace(ClinicIdTextBox.Text) Then
			MessageBox.Show("Please enter a clinic number.")
			Exit Sub
		End If

		Dim patient As Patient = PatientFLP.Controls.Cast(Of PatientLargeCard).First.thisPatient
		Dim clinic_id As String = ClinicIdTextBox.Text
		Dim appointed_date As DateTime = AppointmentDTP.Value
		Dim appointed_time As DateTime = MeetTimeDateTimePicker.Value

		Dim appointed_date_time As New DateTime(
			appointed_date.Year, appointed_date.Month, appointed_date.Day,
			appointed_time.Hour, appointed_time.Minute, appointed_time.Second,
			DateTimeKind.Utc
		)

		Dim db As New Schema

		If db.NonSelectQuery("INSERT INTO Appointments VALUES (@p, @d, @c)", New With {.p = patient.patient_number, .d = appointed_date_time.ToUniversalTime, .c = clinic_id}) Then
			MessageBox.Show("Insert Successful.")
			Dispose()
		Else
			MessageBox.Show("Insertion Failed.")
		End If

	End Sub
End Class