Imports Microsoft.VisualBasic.ApplicationServices

Public Class AppointmentList
	Private Sub AppointmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SearchByComboBox.SelectedIndex = 0

		renderDataGridView()

	End Sub
	Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

		renderDataGridView()

	End Sub

	Private Sub SearchByComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchByComboBox.SelectedIndexChanged

		renderDataGridView()

	End Sub

	Private Sub MakeAppointmentButton_Click(sender As Object, e As EventArgs) Handles MakeAppointmentButton.Click
		Dim user = Auth.User

		If user.position <> "Charge Nurse" AndAlso user.position <> "System Administrator" Then
			MessageBox.Show("Can not access due to your position.")
			Exit Sub
		End If

		Dim f As New NewAppointmentForm
		f.ShowDialog()
		renderDataGridView()
	End Sub


	Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
		SearchTextBox.Clear()

		renderDataGridView()
	End Sub

	Private Sub renderDataGridView()
		Dim search = SearchTextBox.Text
		Dim where_clause = ""

		Select Case CStr(SearchByComboBox.SelectedItem)
			Case "Patient Number"
				where_clause = "WHERE [Patient Number] LIKE @s"
			Case "Fullname"
				where_clause = "WHERE [Patient Name] LIKE @s"
		End Select

		Dim db As New Schema
		Try
			Dim dt_set As DataSet = db.GetDataSet($"SELECT * FROM appointment_view {where_clause}", New Dictionary(Of String, Object) From {{"@s", $"%{search}%"}})
			AppointmentDGV.DataSource = dt_set.Tables(0)

			AppointmentDGV.Columns("Date/Time").DefaultCellStyle.Format = "dd'/'MM'/'yyyy HH:mm"

			AppointmentDGV.Refresh()
		Catch ex As Exception
			MessageBox.Show("Error: can not get the appointment list." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
		End Try
	End Sub

	Private Sub AppointmentDGV_SelectionChanged(sender As Object, e As EventArgs) Handles AppointmentDGV.SelectionChanged
		EditButton.Enabled = True
		DeleteButton.Enabled = True
	End Sub

	Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
		If AppointmentDGV.SelectedRows.Count = 0 Then Exit Sub

		If Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
			MessageBox.Show("Can not access due to your position.")
			Exit Sub
		End If

		Dim selected_row As DataGridViewRow = AppointmentDGV.SelectedRows(0)

		Dim db As New Schema

		If Not db.NonSelectQuery(
			"DELETE FROM Appointments WHERE patient_num = @p AND appointment_date_time = @d",
			New With {.p = selected_row.Cells("Patient Number").Value, .d = selected_row.Cells("Date/Time").Value}
		) Then
			MessageBox.Show($"Error: can not delete the record patient_num = {selected_row.Cells("Patient Number").Value}, appointment_date_time = {selected_row.Cells("Date/Time").Value}")
			Exit Sub
		End If

		renderDataGridView()
	End Sub

	Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
		If AppointmentDGV.SelectedRows.Count = 0 Then Exit Sub

		If Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
			MessageBox.Show("Can not access due to your position.")
			Exit Sub
		End If

		Dim selected_row As DataGridViewRow = AppointmentDGV.SelectedRows(0)

		Dim db As New Schema
		Try
			Dim result = db.Query(Of Patient, Object)(
				"SELECT * FROM Patients WHERE patient_number = @n",
				New With {.n = selected_row.Cells("Patient Number").Value}
			)

			If result.Count = 0 Then
				MessageBox.Show($"Patient Not Found. patient_number = {selected_row.Cells("Patient Number").Value}")
				Exit Sub
			End If

			Dim patient = result.First
			Dim appointed_date_time = selected_row.Cells("Date/Time").Value

			Dim f As New EditAppointmentForm(patient, appointed_date_time)
			Dim f_result = f.ShowDialog
			If f_result = DialogResult.Abort Or f_result = DialogResult.Cancel Then Exit Sub

			renderDataGridView()

		Catch ex As Exception
			MessageBox.Show("Error: Can not get a full patient record." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))

		End Try
	End Sub
End Class