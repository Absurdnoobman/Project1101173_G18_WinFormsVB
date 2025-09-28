Imports System.Text.RegularExpressions

Public Class CreateNewStaffForm

	Private Sub AddNewQualiButton_Click(sender As Object, e As EventArgs) Handles AddNewQualiButton.Click
		Dim AddnewQualiForm As New QualificationForm

		Dim result = AddnewQualiForm.ShowDialog()
		If result = DialogResult.Cancel Then Return

		Dim newQualification = AddnewQualiForm.qualification

		Dim card As New NewQualificationCard(newQualification, CardStatus.NewlyAdded)
		QualificationFLP.Controls.Add(card)

	End Sub

	Private Sub AddNewWorkExpButton_Click(sender As Object, e As EventArgs) Handles AddNewWorkExpButton.Click
		Dim AddNewWorkExpForm As New WorkExperienceForm

		Dim result = AddNewWorkExpForm.ShowDialog()
		If result = DialogResult.Cancel Then Return

		Dim newWorkExp = AddNewWorkExpForm.workExp

		Dim card As New NewWorkExperienceCard(newWorkExp, CardStatus.NewlyAdded)
		WorksFLP.Controls.Add(card)

	End Sub

	Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
		If Not ValidateInput() Then Exit Sub

		Dim staff_num = StaffNumberTextBox.Text.ToUpper
		Dim firstname = FirstnameTextBox.Text
		Dim surname = SurnameTextBox.Text
		Dim sex = SexComboBox.SelectedItem
		Dim dob = DateOfBrithDTP.Value
		Dim address = AddressTextBox.Text
		Dim telephone = TelephoneTextBox.Text
		Dim nin = NINTextBox.Text.ToUpper()

		Dim position = PositionComboBox.SelectedItem
		Dim contract = ContractTypeComboBox.SelectedItem
		Dim hours_per_week = HPWNumericUpDown.Value
		Dim payment = PaymentTypeComboBox.SelectedItem
		Dim salary_scale = SalaryScaleComboBox.SelectedItem
		Dim salary = SalaryNumericUpDown.Value

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

		For Each card In QualificationFLP.Controls
			Dim qualification = DirectCast(card, NewQualificationCard).thisQualification
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

		For Each card In WorksFLP.Controls.Cast(Of NewWorkExperienceCard)
			Dim workExp = card.thisWorkExp
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

	Public Function ValidateInput() As Boolean
		If String.IsNullOrWhiteSpace(StaffNumberTextBox.Text) Then
			MessageBox.Show("Please Enter Staff Number.")
			Return False
		End If
		If Not Regex.IsMatch(StaffNumberTextBox.Text, "(?i)^S\d{3}$") Then
			MessageBox.Show("Invalid Forat: Staff number must not exceed 4 characters and Start with 'S'.")
			Return False
		End If

		If String.IsNullOrWhiteSpace(FirstnameTextBox.Text) Then
			MessageBox.Show("Please Enter firstname.")
			Return False
		End If
		If String.IsNullOrWhiteSpace(SurnameTextBox.Text) Then
			MessageBox.Show("Please Enter surname.")
			Return False
		End If
		If FirstnameTextBox.TextLength > 255 OrElse SurnameTextBox.TextLength > 255 Then
			MessageBox.Show("Firstname and Surname must not exceed 255 characters.")
			Return False
		End If

		If SexComboBox.SelectedIndex = -1 Then
			MessageBox.Show("Please select gender.")
			Return False
		End If

		If String.IsNullOrWhiteSpace(AddressTextBox.Text) Then
			MessageBox.Show("Please Enter address.")
			Return False
		End If

		If String.IsNullOrWhiteSpace(TelephoneTextBox.Text) Then
			MessageBox.Show("Please Enter Telephone Number.")
			Return False
		End If
		If TelephoneTextBox.TextLength > 20 Then
			MessageBox.Show("Telephone Number must not exceed 20 characters.")
			Return False
		End If

		If Not Regex.IsMatch(NINTextBox.Text, "^[A-CEGHJ-PR-TW-Z]{2}\d{6}[A-D]$") Then
			MessageBox.Show("Invalid National Insurance Number format")
			Return False
		End If

		If PositionComboBox.SelectedIndex = -1 Then
			MessageBox.Show("Please Select Position.")
			Return False
		End If

		If ContractTypeComboBox.SelectedIndex = -1 Then
			MessageBox.Show("Please Select Contract type.")
			Return False
		End If

		If SalaryScaleComboBox.SelectedIndex = -1 Then
			MessageBox.Show("Please Select Salary scale.")
			Return False
		End If

		If PaymentTypeComboBox.SelectedIndex = -1 Then
			MessageBox.Show("Please Select payment type.")
			Return False
		End If

		If QualificationFLP.Controls.Count = 0 Then
			MessageBox.Show("Staff must have at least 1 qualification.")
			Return False
		End If

		If String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
			MessageBox.Show("Password must be set.")
			Return False
		End If

		Return True
	End Function

	Private Sub ShowPwdCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPwdCheckBox.CheckedChanged
		PasswordTextBox.UseSystemPasswordChar = Not ShowPwdCheckBox.Checked ' Toggle Show Password
	End Sub
End Class