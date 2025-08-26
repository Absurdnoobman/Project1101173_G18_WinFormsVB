Public Class EditStaffForm
	Public thisStaff As Staff
	Private toRemoveQualifications As New List(Of Integer)
	Private toRemoveWorkExperiences As New List(Of Integer)

	Private Sub New(staff As Staff, qualifications As List(Of StaffQualification), workExperiences As List(Of StaffWorkExperience))
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

		For Each qualification In qualifications
			Dim card As New NewQualificationCard(qualification, CardStatus.Original)
			AddHandler card.OnRemove, AddressOf HandleQualiOnRemoveEvent
			QualificationFLP.Controls.Add(card)
		Next

		For Each workExp In workExperiences
			Dim card As New NewWorkExperienceCard(workExp, CardStatus.Original)
			AddHandler card.OnRemove, AddressOf HandleWorkExpOnRemoveEvent
			WorksFLP.Controls.Add(card)
		Next

	End Sub

	Public Shared Function WithData(staff As Staff, qualifications As List(Of StaffQualification), workExps As List(Of StaffWorkExperience)) As EditStaffForm
		Return New EditStaffForm(staff, qualifications, workExps)
	End Function

	Private Sub HandleQualiOnRemoveEvent(sender As Object)
		Using card = DirectCast(sender, NewQualificationCard)
			toRemoveQualifications.Add(card.thisQualification.id)
		End Using
	End Sub

	Private Sub HandleWorkExpOnRemoveEvent(sender As Object)
		Using card = DirectCast(sender, NewWorkExperienceCard)
			toRemoveWorkExperiences.Add(card.thisWorkExp.id)
		End Using
	End Sub

	Private Sub AddNewQualiButton_Click(sender As Object, e As EventArgs) Handles AddNewQualiButton.Click
		Dim AddnewQualiForm As New QualificationForm

		Dim result = AddnewQualiForm.ShowDialog()
		If result = DialogResult.Cancel Then Exit Sub

		Dim newQualification = AddnewQualiForm.qualification

		Dim card As New NewQualificationCard(newQualification, CardStatus.NewlyAdded)
		QualificationFLP.Controls.Add(card)

	End Sub

	Private Sub AddNewWorkExpButton_Click(sender As Object, e As EventArgs) Handles AddNewWorkExpButton.Click
		Dim AddNewWorkExpForm As New WorkExperienceForm

		Dim result = AddNewWorkExpForm.ShowDialog()
		If result = DialogResult.Cancel Then Exit Sub

		Dim newWorkExp = AddNewWorkExpForm.workExp

		Dim card As New NewWorkExperienceCard(newWorkExp, CardStatus.NewlyAdded)
		WorksFLP.Controls.Add(card)

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
		End If

		Dim qualification_cards = QualificationFLP.Controls.Cast(Of NewQualificationCard).ToList

		Dim quali_in_db = db.Query(Of StaffQualification, Object)("SELECT id FROM Qualifications WHERE staff_num = @staff", New With {.staff = staff_num})
		Dim quali_in_db_id = quali_in_db.Select(Function(q) q.id).ToList

		' Remove Qualification Records.
		If toRemoveQualifications.Count > 0 Then
			For Each id In toRemoveQualifications
				If Not quali_in_db_id.Contains(id) Then Continue For
				If Not db.Delete("Qualifications", "id", id) Then
					MessageBox.Show("Can not delete.")
					Exit Sub
				End If
			Next
		End If

		' Add or Update Qualification Records.
		If qualification_cards.Count > 0 Then
			For Each card In qualification_cards
				Select Case card.status
					Case CardStatus.Original
						Continue For
					Case CardStatus.NewlyAdded
						InsertNewQualification(staff_num, card.thisQualification)
					Case CardStatus.Edited
						UpdateQualification(card.thisQualification)
				End Select
			Next
		End If
		Dim workExp_cards = WorksFLP.Controls.Cast(Of NewWorkExperienceCard).ToList

		Dim works_in_db = db.Query(Of StaffWorkExperience, Object)("SELECT id FROM WorkExperiences WHERE staff_num = @staff", New With {.staff = staff_num})
		Dim works_in_db_id = works_in_db.Select(Function(w) w.id).ToList

		' Delete WorkExperiences Records.
		If toRemoveWorkExperiences.Count > 0 Then
			For Each id In toRemoveWorkExperiences
				If Not works_in_db_id.Contains(id) Then Continue For
				If Not db.Delete("WorkExperiences", "id", id) Then
					MessageBox.Show("Can not delete.")
					Exit Sub
				End If
			Next
		End If
		' Add or Update records.
		If workExp_cards.Count > 0 Then
			For Each card In workExp_cards
				Select Case card.status
					Case CardStatus.Original
						Continue For
					Case CardStatus.NewlyAdded
						InsertNewWorkExperiences(staff_num, card.thisWorkExp)
					Case CardStatus.Edited
						UpdateWorkExperience(card.thisWorkExp)
				End Select
			Next
		End If

		MessageBox.Show("Add and Update both Qualifications and work experiences Succesfully.")
		Close()
	End Sub

	Private Sub InsertNewQualification(staff_num As String, qualification As StaffQualification)
		Dim db As New Schema
		If Not db.NonSelectQuery(
			"INSERT INTO Qualifications VALUES (@s, @t, @i, @d)",
			New With {
				.s = staff_num,
				.t = qualification.type,
				.i = qualification.institution,
				.d = qualification.qualified_date
			}) Then
			MessageBox.Show("Can not insert qualification." & vbNewLine & $"type: '{qualification.type}'")
		End If
	End Sub

	Private Sub InsertNewWorkExperiences(staff_num As String, workExperience As StaffWorkExperience)
		Dim db As New Schema
		If Not db.NonSelectQuery(
			"INSERT INTO WorkExperiences VALUES (@s, @p, @o, @start, @end)",
			New With {
				.s = staff_num,
				.p = workExperience.position,
				.o = workExperience.organisation,
				.start = workExperience.start_date,
				.end = workExperience.end_date
			}
		) Then
			MessageBox.Show("Can not insert qualification." & vbNewLine & $"type: '{workExperience.position}'")
		End If
	End Sub

	Private Sub UpdateQualification(qualification As StaffQualification)
		Dim db As New Schema
		If Not db.Update("Qualifications", "id", qualification.id,
			New Dictionary(Of String, Object) From {
				{"type", qualification.type},
				{"institution", qualification.institution},
				{"qualified_date", qualification.qualified_date}
			}
		) Then
			MessageBox.Show("Update Failed." & vbNewLine & $"type: '{qualification.type}'")
		End If
	End Sub

	Private Sub UpdateWorkExperience(workExperience As StaffWorkExperience)
		Dim db As New Schema
		If Not db.Update("WorkExperiences", "id", workExperience.id,
			New Dictionary(Of String, Object) From {
				{"position", workExperience.position},
				{"organisation", workExperience.organisation},
				{"start_date", workExperience.start_date},
				{"end_date", workExperience.end_date}
			}
		) Then
			MessageBox.Show("Update Failed." & vbNewLine & $"type: '{workExperience.position}'")
		End If
	End Sub
End Class