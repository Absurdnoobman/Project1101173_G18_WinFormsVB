Public Class PatientLargeCard
	Public thisPatient As Patient

	Sub New(patient As Patient)
		' This call is required by the designer.
		InitializeComponent()

		thisPatient = patient
		' Add any initialization after the InitializeComponent() call.
		PatientNumberLabel.Text = patient.patient_number
		FullnameLabel.Text = $"{patient.firstname} {patient.surname}"
		AddressLabel.Text = patient.address
		TelephoneLabel.Text = patient.telephone
	End Sub


End Class
