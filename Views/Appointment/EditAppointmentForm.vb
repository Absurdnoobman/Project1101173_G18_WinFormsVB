Public Class EditAppointmentForm
	Private _original_date_time As DateTime

	Sub New(patient As Patient, appointed_date_time As Date)

		' This call is required by the designer.
		InitializeComponent()

		Dim card As New PatientLargeCard(patient)
		PatientFLP.Controls.Add(card)

		AppointmentDTP.Value = appointed_date_time.Date
		MeetTimeDateTimePicker.Value = appointed_date_time

		_original_date_time = appointed_date_time

	End Sub

	Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
		Dim patient As Patient = PatientFLP.Controls.Cast(Of PatientLargeCard).First.thisPatient
		Dim appointed_date As DateTime = AppointmentDTP.Value
		Dim appointed_time As DateTime = MeetTimeDateTimePicker.Value

		Dim appointed_date_time As New DateTime(
			appointed_date.Year, appointed_date.Month, appointed_date.Day,
			appointed_time.Hour, appointed_time.Minute, appointed_time.Second,
			DateTimeKind.Utc
		)

		Dim db As New Schema
		If Not db.NonSelectQuery(
			"DELETE FROM Appointments WHERE patient_number = @p AND appointment_date_time = @d",
			New With {.p = patient.patient_number, .d = _original_date_time}
		) Then
			MessageBox.Show("Error: Deletion Failed. Abort")
			Exit Sub
		End If

		If Not db.NonSelectQuery(
			"UPDATE Appointments SET appointment_date_time = @v WHERE patient_num = @p AND appointment_date_time = @d",
			New With {.v = appointed_date_time, .p = patient.patient_number, .d = _original_date_time}
		) Then
			MessageBox.Show("Error: Insert Failed. Abort")
			Exit Sub
		End If

		DialogResult = DialogResult.OK
		Close()

	End Sub
End Class