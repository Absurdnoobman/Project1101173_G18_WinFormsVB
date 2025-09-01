Public Class StaffConsultantCard
	Public thisStaff As Staff

	Sub New(staff As Staff, Optional ward As Ward = Nothing, Optional week As Date = Nothing)
		' This call is required by the designer.
		InitializeComponent()

		thisStaff = staff

		StaffNumberLabel.Text = staff.staff_number
		FullnameLabel.Text = $"{staff.firstname} {staff.surname}"
		AddressLabel.Text = staff.address
		TelephoneLabel.Text = staff.telephone

		If ward IsNot Nothing Then
			WardLabel.Text = $"Ward {ward.ward_number}: {ward.name}"
			WeekLabel.Text = $"{week.ToShortDateString}"
		Else
			WardLabel.Text = "Currently has not been Assign to ward."
			WeekLabel.Text = ""
		End If
	End Sub

End Class
