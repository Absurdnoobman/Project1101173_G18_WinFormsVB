Public Class EditStaffForm
	Public qualifications As New List(Of StaffQualification)
	Public workExperiences As New List(Of StaffWorkExperience)

	Private Sub New(staff As Staff)
		' This call is required by the designer.
		InitializeComponent()

		StaffNumberTextBox.Text = staff.staff_number
		FirstnameTextBox.Text = staff.firstname
		SurnameTextBox.Text = staff.surname

		AddressTextBox.Text = staff.address
		TelephoneTextBox.Text = staff.telephone
		SexComboBox.SelectedItem = staff.sex
		DateOfBrithDTP.Value = staff.date_of_birth
		NINTextBox.Text = staff.national_insurance_num

		SalaryTextBox.Text = CStr(staff.salary)
		PositionComboBox.SelectedItem = staff.position
		SalaryScaleComboBox.SelectedItem = staff.salary_scale
		ContractTypeComboBox.SelectedItem = staff.contract_type
		PaymentTypeComboBox.SelectedItem = staff.payment_type
		HPWTextBox.Text = CStr(staff.hours_per_week)

	End Sub

	Public Shared Function WithData(staff As Staff) As EditStaffForm
		Return New EditStaffForm(staff)
	End Function

	Private Sub AddNewQualiButton_Click(sender As Object, e As EventArgs)
		Dim AddnewQualiForm As New AddNewQualificationForm

		Dim result = AddnewQualiForm.ShowDialog()
		If result = DialogResult.Cancel Then Return

		Dim newQualification As New StaffQualification With {
			.type = AddnewQualiForm.TypeTextBox.Text,
			.institution = AddnewQualiForm.InstitutionTextBox.Text,
			.qualified_date = AddnewQualiForm.DateTimePicker.Value
		}

		qualifications.Add(newQualification)

		Dim card As New NewQualificationCard
		card.SetData(newQualification, qualifications.Count() - 1)
		AddHandler card.OnRemoveButtonPressed, AddressOf HandleQualiCardRemoveEvent

		QualificationFLP.Controls.Add(card)

	End Sub

	Private Sub AddNewWorkExpButton_Click(sender As Object, e As EventArgs)
		Dim AddNewWorkExpForm As New AddNewWorkExperienceForm

		Dim result = AddNewWorkExpForm.ShowDialog()
		If result = DialogResult.Cancel Then Return

		Dim newWorkExp As New StaffWorkExperience With {
			.position = AddNewWorkExpForm.PositionTextBox.Text,
			.organisation = AddNewWorkExpForm.OrganisationTextBox.Text,
			.start_date = AddNewWorkExpForm.StartDateTimePicker.Value,
			.end_date = AddNewWorkExpForm.EndDateTimePicker.Value
		}

		workExperiences.Add(newWorkExp)

		Dim card As New NewWorkExperienceCard
		card.SetData(newWorkExp, workExperiences.Count() - 1)
		AddHandler card.OnRemoveButtonPressed, AddressOf HandleWorkExpCardRemoveEvent

		WorksFLP.Controls.Add(card)


	End Sub

	Private Sub HandleQualiCardRemoveEvent(sender As Object)
		Using card = DirectCast(sender, NewQualificationCard)
			qualifications.RemoveAt(card.index)
		End Using
	End Sub

	Private Sub HandleWorkExpCardRemoveEvent(sender As Object)
		Using card = DirectCast(sender, NewWorkExperienceCard)
			workExperiences.RemoveAt(card.index)
		End Using
	End Sub

	Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
		Dim staff_num = StaffNumberTextBox.Text
		Dim firstname = FirstnameTextBox.Text
		Dim surname = SurnameTextBox.Text
		Dim sex = SexComboBox.SelectedItem
		Dim dob = DateOfBrithDTP.Value
		Dim address = AddressTextBox.Text
		Dim telephone = TelephoneTextBox.Text
		Dim nin = NINTextBox.Text

		Dim position = PositionComboBox.SelectedItem
		Dim contract = ContractTypeComboBox.SelectedItem
		Dim hours_per_week = HPWTextBox.Text
		Dim payment = PaymentTypeComboBox.SelectedItem
		Dim salary_scale = SalaryScaleComboBox.SelectedItem
		Dim salary = SalaryTextBox.Text

		Dim db As New Schema

		If Not db.Update("Staffs", "staff_number", staff_num,
				New Dictionary(Of String, Object) From {
					{"firstname", firstname},
					{"surname", surname},
					{"sex", sex},
					{"address", address},
					{"date_of_birth", dob},
					{"telephone", telephone},
					{"national_insurance_num", nin},
					{"position", position},
					{"contract_type", contract},
					{"salary", salary},
					{"salary_scale", salary_scale},
					{"hours_per_week", hours_per_week},
					{"payment_type", payment}
				}
			) Then
			MessageBox.Show("Fail to update")
			Exit Sub
		Else
			MessageBox.Show("Update Successful")

			Dispose()
		End If



	End Sub
End Class