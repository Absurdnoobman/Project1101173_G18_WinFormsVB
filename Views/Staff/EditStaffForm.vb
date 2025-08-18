Public Class EditStaffForm
	Public qualifications As New List(Of StaffQualification)
	Public workExperiences As New List(Of StaffWorkExperience)

	Private Sub New(staff As Staff)
		' This call is required by the designer.
		InitializeComponent()

		StaffNumberTextBox.Text = staff.Id
		FirstnameTextBox.Text = staff.firstname
		SurnameTextBox.Text = staff.surname

		AddressTextBox.Text = staff.address
		TelphoneTextBox.Text = staff.telephone
		SexComboBox.SelectedItem = staff.sex
		DateOfBrithDTP.Value = staff.date_of_birth
		NINTextBox.Text = staff.national_insurance_num

		SalaryTextBox.Text = CStr(staff.salary)
		PositionComboBox.SelectedItem = staff.position
		SalaryScaleComboBox.SelectedItem = staff.salary_scale
		ContactTypeComboBox.SelectedItem = staff.contract_type
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
			.QualificationDate = AddnewQualiForm.DateTimePicker.Value
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
			.startDate = AddNewWorkExpForm.StartDateTimePicker.Value,
			.endDate = AddNewWorkExpForm.EndDateTimePicker.Value
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
End Class