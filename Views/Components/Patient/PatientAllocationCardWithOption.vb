Public Class PatientAllocationCardWithOption

	Public thisPatient As Patient

	Sub New(patient As Patient)
		' This call is required by the designer.
		InitializeComponent()

		thisPatient = patient

		PatientNumberLabel.Text = patient.patient_number
		FullnameLabel.Text = $"{patient.firstname} {patient.surname}"

	End Sub

	Sub New(patient As Patient, placedDate As Date, bed As Integer, duration As Integer, Optional allowAdmissionDateEditting As Boolean = True)
		' This call is required by the designer.
		InitializeComponent()

		thisPatient = patient

		PatientNumberLabel.Text = patient.patient_number
		FullnameLabel.Text = $"{patient.firstname} {patient.surname}"

		PlacedDTP.Value = placedDate
		PlacedDTP.Enabled = allowAdmissionDateEditting

		BedNumberTextBox.Text = bed
		DurationTextBox.Text = duration

	End Sub


	Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
		Dispose()
	End Sub

	Private Function ValidateInput() As Boolean
		' TODO 
		Return True
	End Function

	Public Function GetInputData() As Dictionary(Of String, Object)
		Dim result As New Dictionary(Of String, Object)

		If Not ValidateInput() Then Return result

		result("bed_number") = BedNumberTextBox.Text
		result("date_placed") = PlacedDTP.Value
		result("expected_duration_days") = DurationTextBox.Text

		Return result
	End Function
End Class
