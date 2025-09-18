Public Class EditPatientForm
	Private _thisPatient As Patient
	Private _doctor As PatientLocalDoctor
	Private _nextOfKin As PatientNextOfKin
	Sub New(patient As Patient, doctor As PatientLocalDoctor, nextOfKin As PatientNextOfKin)
		' This call is required by the designer.
		InitializeComponent()

		_thisPatient = patient
		_doctor = doctor
		_nextOfKin = nextOfKin

	End Sub

	Private Sub EditPatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PatientNumberTextBox.Text = _thisPatient.patient_number
		FirstnameTextBox.Text = _thisPatient.firstname
		SurnameTextBox.Text = _thisPatient.surname
		AddressTextBox.Text = _thisPatient.address
		SexComboBox.SelectedItem = _thisPatient.sex
		DateOfBirthDTP.Value = _thisPatient.date_of_birth
		TelephoneTextBox.Text = _thisPatient.telephone
		MaritalStatusComboBox.SelectedItem = _thisPatient.marital_status

		' Next Of kin
		FullnameNOKTextBox.Text = _nextOfKin.fullname
		RelationshipNOKTextBox.Text = _nextOfKin.relationship
		AddressNOKTextBox.Text = _nextOfKin.address
		TelephoneNOKTextBox.Text = _nextOfKin.telephone

		' local doctor
		FullnameLDTTextBox.Text = _doctor.fullname
		ClinicNumberLDTTextBox.Text = _doctor.clinic_id
		AddressLDTTextBox.Text = _doctor.address
		TelephoneLDTTextBox.Text = _doctor.telephone

	End Sub

	Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
		' Patient
		Dim patient_number = PatientNumberTextBox.Text
		Dim firstname = FirstnameTextBox.Text
		Dim surname = SurnameTextBox.Text
		Dim address = AddressTextBox.Text
		Dim sex As String = SexComboBox.SelectedItem
		Dim telephone = TelephoneTextBox.Text
		Dim dob = DateOfBirthDTP.Value
		Dim marital_status As String = MaritalStatusComboBox.SelectedItem
		'Dim date_registered As Date = DateRegisteredDTP.Value

		' Next of kin
		Dim fullnameNOK = FullnameNOKTextBox.Text
		Dim relationship = RelationshipNOKTextBox.Text
		Dim addressNOK = AddressNOKTextBox.Text
		Dim telephoneNOK = TelephoneNOKTextBox.Text

		' local doctor
		Dim fullnameLDT = FullnameLDTTextBox.Text
		Dim clinic_number = ClinicNumberLDTTextBox.Text
		Dim addressLDT = AddressLDTTextBox.Text
		Dim telephoneLDT = TelephoneLDTTextBox.Text

		Dim db As New Schema
		If Not db.Update(
			"Patients", "patient_number", patient_number,
			New Dictionary(Of String, Object) From {
				{"firstname", firstname},
				{"surname", surname},
				{"address", address},
				{"sex", sex},
				{"telephone", telephone},
				{"date_of_birth", dob},
				{"marital_status", marital_status}
			}
		) Then
			MessageBox.Show("Can not update a record.")
			Exit Sub
		End If

		If Not db.Update(
			"LocalDoctors", "id", _doctor.id,
			New Dictionary(Of String, Object) From {
				{"fullname", fullnameLDT},
				{"clinic_id", clinic_number},
				{"address", addressLDT},
				{"telephone", telephoneLDT}
			}
		) Then
			MessageBox.Show("Can not update Local doctor record")
			Exit Sub
		End If

		If Not db.Update(
			"NextOfKins", "id", _nextOfKin.id,
			New Dictionary(Of String, Object) From {
				{"fullname", fullnameNOK},
				{"relation", relationship},
				{"address", addressNOK},
				{"telephone", telephoneNOK}
			}
		) Then
			MessageBox.Show("Can not update next-of-kin record.")
			Exit Sub
		End If

		DialogResult = DialogResult.OK
		Close()
	End Sub
End Class