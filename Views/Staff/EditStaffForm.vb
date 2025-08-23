Imports System.Runtime.Remoting.Channels

Public Class EditStaffForm
	Public thisStaff As Staff
	Public qualifications As New List(Of StaffQualification)
	Public workExperiences As New List(Of StaffWorkExperience)

	Private Sub New(staff As Staff, quali As List(Of StaffQualification), workExps As List(Of StaffWorkExperience))
		' This call is required by the designer.
		InitializeComponent()

		thisStaff = staff

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

		qualifications = quali
		workExperiences = workExps

		For Each qualification In qualifications
			Dim card As New NewQualificationCard
			card.SetData(qualification, qualifications.Count() - 1)
			AddHandler card.OnRemoveButtonPressed, AddressOf HandleQualiCardRemoveEvent
			QualificationFLP.Controls.Add(card)
		Next

		For Each workExp In workExperiences
			Dim card As New NewWorkExperienceCard
			card.SetData(workExp, workExperiences.Count() - 1)
			AddHandler card.OnRemoveButtonPressed, AddressOf HandleWorkExpCardRemoveEvent
			WorksFLP.Controls.Add(card)
		Next
	End Sub

	Public Shared Function WithData(staff As Staff, qualifications As List(Of StaffQualification), workExps As List(Of StaffWorkExperience)) As EditStaffForm
		Return New EditStaffForm(staff, qualifications, workExps)
	End Function

	Private Sub AddNewQualiButton_Click(sender As Object, e As EventArgs)
		Dim AddnewQualiForm As New QualificationForm

		Dim result = AddnewQualiForm.ShowDialog()
		If result = DialogResult.Cancel Then Exit Sub

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
		Dim AddNewWorkExpForm As New WorkExperienceForm

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

	Private Sub HandleQualiCardEditEvent(sender As Object)
		'Using card = DirectCast(sender, NewQualificationCard)
		'	Dim d As New QualificationForm
		'	d.AddButton.Text = "Edit"
		'	d.TypeTextBox.Text = card.thisQualification.type
		'	d.InstitutionTextBox.Text = card.thisQualification.institution
		'	d.DateTimePicker.Value = card.thisQualification.qualified_date

		'	Dim result = d.qualification


		'End Using
	End Sub

	Private Sub HandleWorkExpCardEditEvent(sender As Object)
		' TODO
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