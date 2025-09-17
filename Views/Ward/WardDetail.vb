Public Class WardDetailForm
	Private _wards As List(Of Ward)
	Private original_dt_table As DataTable

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
		FilterFLP.Controls.Clear()

		Dim db As New Schema
		Try
			Dim dt_set = db.GetDataSet(
				$"
				SELECT 
				w.staff_num AS [Staff No.], 
				s.firstname + ' ' + s.surname AS [Name], 
				s.address AS [Address], 
				s.telephone AS [Tel No.], 
				s.position AS [Position], 
				w.shift AS [Shift]
				FROM Works_in w JOIN Staffs s ON w.staff_num = s.staff_number
				WHERE week_beginning = @week AND ward_num = @ward
				", New Dictionary(Of String, Object) From {
					{"@week", Date.Parse(WeekBeginingComboBox.SelectedItem)},
					{"@ward", CInt(WardComboBox.SelectedItem)}
				}
			)



			original_dt_table = dt_set.Tables(0)

			WorkInDGV.DataSource = dt_set.Tables.Item(0)

			WorkInDGV.Refresh()

		Catch ex As Exception
			MessageBox.Show("Internal Error." & vbNewLine & If(Debugger.IsAttached, ex.Message, ""))
			Exit Sub
		End Try

		AddFilterButton.Enabled = True
		ApplyFilterButton.Enabled = True
		RefreshButton.Enabled = True

	End Sub

	Private Sub EditAssignmentButton_Click(sender As Object, e As EventArgs) Handles EditAssignmentButton.Click
		Dim staff_shift As Dictionary(Of Staff, List(Of String)) = original_dt_table.Rows _
			.Cast(Of DataRow)() _
			.GroupBy(
				Function(r)
					Dim names = CStr(r("Name")).Split(" "c) ' c in the end mean it's a character not a string

					Dim first = names(0)
					Dim sur = If(names.Length > 1, names(names.Length - 1), String.Empty)
					Return New Staff With {.staff_number = CStr(r("Staff No.")), .firstname = first, .surname = sur}
				End Function,
				Function(r) CStr(r("Shift"))
			) _
			.ToDictionary(
				Function(g) g.Key, ' The staff 
				Function(g) g.ToList() ' The list of shifts
			)


		Dim f As New EditStaffWardAssignmentForm(
			staff_shift,
			WardComboBox.SelectedItem,
			Date.Parse(WeekBeginingComboBox.SelectedItem))

		Dim result = f.ShowDialog
		If result = DialogResult.Cancel OrElse result = DialogResult.Abort Then Exit Sub

		If FilterFLP.Controls.Count <> 0 Then
			ApplyFilterButton_Click(Nothing, Nothing)
		Else
			RefreshButton_Click(Nothing, Nothing)
		End If


	End Sub

	Private Sub StaffDataGridView_DataSourceChanged(sender As Object, e As EventArgs) Handles WorkInDGV.DataSourceChanged
		RecordCountLabel.Text = $"Records: {WorkInDGV.RowCount}"
	End Sub

	Private Sub AddFilterButton_Click(sender As Object, e As EventArgs) Handles AddFilterButton.Click
		Dim filter_card As New FilterCardV2(New List(Of EntityAttribute) From {
			New EntityAttribute("staff number", SearchMode.Text),
			New EntityAttribute("staff name", SearchMode.Text),
			New EntityAttribute("telephone", SearchMode.Text)
		})
		FilterFLP.Controls.Add(filter_card)
	End Sub

	Private Sub ApplyFilterButton_Click(sender As Object, e As EventArgs) Handles ApplyFilterButton.Click
		If FilterFLP.Controls.Count = 0 Then Exit Sub

		Dim week_begin = Date.Parse(WeekBeginingComboBox.SelectedItem)

		Dim whereClause As New List(Of String)

		Dim map As New Dictionary(Of String, String) From {
			{"staff number", "w.staff_num"},
			{"staff name", "s.firstname + ' ' + s.surname"},
			{"telephone", "s.telephone"}
		}

		For Each filter_card In FilterFLP.Controls.Cast(Of FilterCardV2).ToList
			whereClause.Add(filter_card.GetQueryString(map))
		Next

		Dim query As String

		If whereClause.Count = 1 Then
			query = whereClause(0)
		Else
			Dim inner = String.Join(
				" AND ",
				whereClause.FindAll(
					Function(s)
						Return Not (String.IsNullOrEmpty(s) OrElse String.IsNullOrWhiteSpace(s))
					End Function ' Not include the empty or whitespace string
				)
			)
			query = $" ( {inner} ) "
		End If

		Dim db As New Schema
		Try
			Dim dt_set = db.GetDataSet(
				$"
				SELECT 
				w.staff_num AS [Staff No.], 
				s.firstname + ' ' + s.surname AS [Name], 
				s.address AS [Address], 
				s.telephone AS [Tel No.], 
				s.position AS [Position], 
				w.shift AS [Shift]
				FROM Works_in w JOIN Staffs s ON w.staff_num = s.staff_number
				WHERE week_beginning = @week AND ward_num = @ward AND {query}
				", New Dictionary(Of String, Object) From {{"@week", week_begin}, {"@ward", CInt(WardComboBox.SelectedItem)}}
			)

			WorkInDGV.DataSource = dt_set.Tables(0)

			WorkInDGV.Refresh()

		Catch ex As Exception
			MessageBox.Show("Error: SQL query" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try

	End Sub

	Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
		FilterFLP.Controls.Clear()

		Dim db As New Schema
		Try
			Dim dt_set = db.GetDataSet(
				"
				SELECT 
				w.staff_num AS [Staff No.], 
				s.firstname + ' ' + s.surname AS [Name], 
				s.address AS [Address], 
				s.telephone AS [Tel No.], 
				s.position AS [Position], 
				w.shift AS [Shift]
				FROM Works_in w JOIN Staffs s ON w.staff_num = s.staff_number
				WHERE week_beginning = @week AND ward_num = @ward
				", New Dictionary(Of String, Object) From {
					{"@week", Date.Parse(WeekBeginingComboBox.SelectedItem)},
					{"@ward", CInt(WardComboBox.SelectedItem)}
				}
			)
			original_dt_table = dt_set.Tables(0)

			WorkInDGV.DataSource = dt_set.Tables(0)

			WorkInDGV.Refresh()

		Catch ex As Exception
			MessageBox.Show("Internal Error." & vbNewLine & If(Debugger.IsAttached, ex.Message, ""))
		End Try
	End Sub

	Private Sub RemoveRecordButton_Click(sender As Object, e As EventArgs) Handles RemoveRecordButton.Click
		If WorkInDGV.SelectedRows.Count <> 1 Then Exit Sub
		Dim row = WorkInDGV.SelectedRows(0)

		Dim db As New Schema
		If Not db.NonSelectQuery(
				"
                DELETE FROM Works_in 
                WHERE ward_num = @w 
                AND week_beginning = @d 
                AND staff_num = @n
                AND shift = @s
                ",
				New With {
					.w = WardComboBox.SelectedItem,
					.d = Date.Parse(WeekBeginingComboBox.SelectedItem),
					.n = CStr(row.Cells("Staff No.").Value),
					.s = CStr(row.Cells("Shift").Value)
				}
		) Then
			MessageBox.Show("Failed to delete.")
			Exit Sub
		End If

		If FilterFLP.Controls.Count <> 0 Then
			ApplyFilterButton_Click(Nothing, Nothing)
		Else
			RefreshButton_Click(Nothing, Nothing)
		End If

	End Sub
End Class