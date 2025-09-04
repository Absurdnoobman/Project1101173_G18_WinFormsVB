Public Class NewPatientAllocationForm
	Private Sub NewPatientAllocationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim db As New Schema
		Try
			Dim wards = db.QueryMulti(Of Ward, Staff, Ward, Object)(
				"SELECT * FROM Wards LEFT JOIN Staffs ON Staffs.staff_number = Wards.charge_nurse ORDER BY Wards.ward_number",
				Function(w, s) Maps.WardChargeNurse(w, s),
				fk:="charge_nurse"
			)

			Dim ward_items As List(Of WardComboBoxItem) =
				wards.Select(
					Function(w)
						Dim ward_str As String = $"Ward {w.ward_number}: {w.name}"
						Return New WardComboBoxItem(ward_str, w)
					End Function
				).ToList()

			WardComboBox.DataSource = ward_items
			WardComboBox.DisplayMember = "Display"
			WardComboBox.ValueMember = "Ward"

		Catch ex As Exception
			MessageBox.Show("Internal error." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Dispose()
		End Try
	End Sub

	Private Sub PickPatientsButton_Click(sender As Object, e As EventArgs) Handles PickPatientsButton.Click
		Dim f = PickPatientDialog.MultiplePick()
		Dim result = f.ShowDialog()
		If result = DialogResult.Cancel OrElse result = DialogResult.Abort Then Exit Sub

		Dim picked_patients = f.result

		RerenderList(picked_patients, HandleEmptyMode.ForcedDisplayEmpty)

	End Sub

	Private Sub RerenderList(patients As List(Of Patient), Optional handleEmpty As HandleEmptyMode = HandleEmptyMode.MaintainOrigin)
		If patients.Count = 0 Then
			Select Case handleEmpty
				Case HandleEmptyMode.MaintainOrigin
					Exit Sub
				Case HandleEmptyMode.ForcedDisplayEmpty
					PatientsFLP.Controls.Clear()
					Exit Sub
				Case HandleEmptyMode.ThrowException
					Throw New Exception
			End Select
		End If


		For Each patient In patients
			Dim card As New PatientAllocationCardWithOption(patient)
			PatientsFLP.Controls.Add(card)
		Next

	End Sub

	Private Function ValidateInput() As Boolean
		If WardComboBox.SelectedIndex = -1 Then
			MessageBox.Show("Please Select Ward.")
			Return False
		End If
		' TODO
		Return True
	End Function

	Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
		PatientsFLP.Controls.Clear()
		WardComboBox.SelectedIndex = -1
	End Sub

	Private Sub ComfirmButton_Click(sender As Object, e As EventArgs) Handles ComfirmButton.Click
		If Not ValidateInput() Then Exit Sub

		Dim selected_ward As Ward = CType(WardComboBox.SelectedValue, Ward)

		Dim admissions As List(Of Admission) = PatientsFLP.Controls _
			.Cast(Of PatientAllocationCardWithOption) _
			.Select(
				Function(c)
					Dim dt = c.GetInputData()
					Return New Admission With {
						.patient = c.thisPatient,
						.ward = selected_ward,
						.admission_date = dt("date_placed"),
						.bed_number = dt("bed_number"),
						.expected_duration_days = dt("expected_duration_days")
					}
				End Function
			).ToList

		Dim db As New Schema
		For Each admission In admissions
			If Not db.NonSelectQuery(
				"INSERT INTO Admissions 
				(patient_num, ward_num, admission_date, bed_number, expected_duration_days) 
				VALUES (@p, @w, @d, @b, @e)",
				New With {
					.p = admission.patient.patient_number,
					.w = admission.ward.ward_number,
					.d = admission.admission_date,
					.b = admission.bed_number,
					.e = admission.expected_duration_days
				}
			) Then
				MessageBox.Show("Can Not Insert.")
				Exit Sub
			End If
		Next

		MessageBox.Show("Insert Successful.")
		Dispose()
	End Sub
End Class