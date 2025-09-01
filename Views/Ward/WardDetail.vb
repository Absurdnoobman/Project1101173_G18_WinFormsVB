Public Class WardDetailForm
	Private _wards As List(Of Ward)

	Private Sub WardDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim db As New Schema
		Try
			_wards = db.QueryMulti(Of Ward, Staff, Ward, Object)(
				"SELECT * FROM Wards LEFT JOIN Staffs ON Staffs.staff_number = Wards.charge_nurse ORDER BY Wards.ward_number",
				Function(w, s) Maps.WardChargeNurse(w, s),
				fk:="charge_nurse"
			)

			WardComboBox.Items.AddRange(_wards.Select(
				Function(w) $"{w.ward_number}"
			).ToArray())

		Catch ex As Exception
			MessageBox.Show("Internal Error." & vbNewLine & If(Debugger.IsAttached, ex.Message, ""))
			Exit Sub
		End Try
	End Sub

	Private Sub WardComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WardComboBox.SelectedIndexChanged
		If WardComboBox.SelectedIndex = -1 Then Exit Sub

		WeekBeginingComboBox.Enabled = True

		DisplayWardDetail(WardComboBox.SelectedItem)

		Dim db As New Schema
		Try
			Dim result = db.SelectQuery("Works_in", "week_beginning", $" ward_num = {CInt(WardComboBox.SelectedItem)}", "DISTINCT")
			Dim weeks = result.Select(
				Function(r) r("week_beginning")
			).ToArray()

			WeekBeginingComboBox.Items.AddRange(weeks)
			WeekBeginingComboBox.SelectedIndex = -1
		Catch ex As Exception
			MessageBox.Show("Internal Error." & vbNewLine & If(Debugger.IsAttached, ex.Message, ""))
			Exit Sub
		End Try
	End Sub

	Private Sub DisplayWardDetail(ward_num As Integer)
		Dim ward = _wards.Find(Function(w) w.ward_number = ward_num)
		NameLabel.Text = $"Name: {ward.name}"
		LocationLabel.Text = $"Location: {ward.location}"
		ExtNumberLabel.Text = $"Telephone Ext. : {ward.telephone_ext}"

		ChargeNurseLabel.Text = $"Charge Nurse: {ward.charge_nurse.firstname} {ward.charge_nurse.surname}"

	End Sub

	Private Sub WeekBeginingComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WeekBeginingComboBox.SelectedIndexChanged
		Dim db As New Schema
		Try
			Dim dt_set = db.GetDataSet(
				$"
				SELECT w.staff_num AS ""Staff No."", s.firstname + ' ' + s.surname AS ""Name"", s.address AS ""Address"", s.telephone AS ""Tel No."", s.position AS ""Position"", w.shift AS ""Shift""
				FROM Works_in w, Staffs s
				WHERE w.staff_num = s.staff_number AND week_beginning = @week 
				", New Dictionary(Of String, Object) From {
					{"@week", Date.Parse(WeekBeginingComboBox.SelectedItem)}
				}
			)

			StaffDataGridView.DataSource = dt_set.Tables.Item(0)

			StaffDataGridView.Refresh()

			CountRecord()

		Catch ex As Exception
			MessageBox.Show("Internal Error." & vbNewLine & If(Debugger.IsAttached, ex.Message, ""))
		End Try
	End Sub

	Private Sub CountRecord()
		RecordCountLabel.Text = $"Records: {StaffDataGridView.RowCount}"
	End Sub

	Private Sub EditAssignmentButton_Click(sender As Object, e As EventArgs) Handles EditAssignmentButton.Click
		' TODO
	End Sub

End Class