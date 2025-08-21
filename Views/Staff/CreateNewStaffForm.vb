Public Class CreateNewStaffForm

	Public qualifications As New List(Of StaffQualification)
	Public workExperiences As New List(Of StaffWorkExperience)

	Private Sub AddNewQualiButton_Click(sender As Object, e As EventArgs) Handles AddNewQualiButton.Click
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

	Private Sub AddNewWorkExpButton_Click(sender As Object, e As EventArgs) Handles AddNewWorkExpButton.Click
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

	Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
		ValidateInput()

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

		Dim password = Hash.Make(PasswordTextBox.Text)

		Dim db As New Schema()
		If Not db.NonSelectQuery(
			   "
               INSERT INTO Staffs VALUES
               (@staff_num, @firstname, @surname, @address, @telephone, @dob, @sex, @nin, @position, @salary, @salary_scale, @payment, @contract, @hours_per_week);
               ", New With {
					.staff_num = staff_num,
					.firstname = firstname, .surname = surname,
					.address = address, .telephone = telephone,
					.dob = dob, .sex = sex, .nin = nin,
					.position = position,
					.salary = salary, .salary_scale = salary_scale,
					.payment = payment, .contract = contract,
					.hours_per_week = hours_per_week
			   }
			) Then
			MessageBox.Show("Failed to insert.")
			Exit Sub
		End If

		If Not db.NonSelectQuery(
			"
            INSERT INTO Passwords VALUES
            (@staff_num, @salt, @hash)
            ", New With {
				.staff_num = staff_num, .salt = password.Salt, .hash = password.Hash
			}
		) Then
			MessageBox.Show("Failed to insert.")
			Exit Sub
		End If

		' TODO: WorkExp and Qualification

		For Each qualification In qualifications
			If Not db.NonSelectQuery(
					"INSERT INTO Qualifications VALUES (@staff_num, @type, @institution, @qualified_date)",
					New With {
						.staff_num = staff_num,
						.type = qualification.type,
						.institution = qualification.institution,
						.qualified_date = qualification.qualified_date
					}
				) Then
				MessageBox.Show($"Failed to insert qualification.{vbNewLine}{qualification.institution} {qualification.type}")
			End If
		Next

		For Each workExp In workExperiences
			If Not db.NonSelectQuery(
					"INSERT INTO WorkExperiences VALUES (@staff_num, @position, @organisation, @start_date, @end_date)",
					New With {
						.staff_num = staff_num,
						.position = workExp.position,
						.organisation = workExp.organisation,
						.start_date = workExp.start_date,
						.end_date = workExp.end_date
					}
				) Then
				MessageBox.Show($"Failed to insert qualification.{vbNewLine}{workExp.position}, {workExp.organisation}")
			End If
		Next

		Dispose()
	End Sub

	Public Sub ValidateInput()
		If StaffNumberTextBox.TextLength > 4 OrElse Not StaffNumberTextBox.Text.StartsWith("S") Then
			MessageBox.Show("Staff number must not exceed 4 characters and Start with 'S'")
		End If
		If FirstnameTextBox.TextLength > 255 OrElse SurnameTextBox.TextLength > 255 Then
			MessageBox.Show("Firstname and Surname exceeded 255 characters")
		End If
		' More to come 
	End Sub
End Class