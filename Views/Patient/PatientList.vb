Public Class PatientList
	Private Sub PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SearchByComboBox.SelectedIndex = 0

		EditButton.Enabled = False
		DeleteButton.Enabled = False

		rerenderList()

	End Sub

	Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
		Dim f As New CreatePatientForm
		f.ShowDialog()
		rerenderList()
	End Sub



	Private Sub rerenderList()
		Dim search = SearchTextBox.Text
		Dim where_clause As String = ""
		If Not (String.IsNullOrEmpty(search) And String.IsNullOrWhiteSpace(search)) Then
			Dim search_by = CStr(SearchByComboBox.SelectedItem)
			Select Case search_by
				Case "Patient Number"
					where_clause = "WHERE [Patient Number] LIKE @s"
				Case "Fullname"
					where_clause = "WHERE [Patient Name] LIKE @s"
				Case "Firstname"
					where_clause = "WHERE firstname LIKE @s"
				Case "Lastname"
					where_clause = "WHERE surname LIKE @s"
			End Select
		End If

		Dim db As New Schema
		Try
			Dim result = db.GetDataSet($"SELECT * FROM [patients_view] {where_clause}", New Dictionary(Of String, Object) From {{"@s", $"%{search}%"}})

			PatientsDGV.DataSource = result.Tables(0)

			If PatientsDGV.Columns.Contains("firstname") Then
				PatientsDGV.Columns("firstname").Visible = False
			End If
			If PatientsDGV.Columns.Contains("surname") Then
				PatientsDGV.Columns("surname").Visible = False
			End If

			PatientsDGV.Refresh()

		Catch ex As Exception
			MessageBox.Show("Error: can not get patient list." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			DialogResult = DialogResult.Abort
			Close()
		End Try
	End Sub

	Private Sub SearchByComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchByComboBox.SelectedIndexChanged
		Dim search = SearchTextBox.Text
		If String.IsNullOrEmpty(search) OrElse String.IsNullOrWhiteSpace(search) Then Exit Sub

		rerenderList()
	End Sub

	Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
		rerenderList()
	End Sub

	Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
		If PatientsDGV.SelectedRows.Count = 0 Then Exit Sub

		Dim row = PatientsDGV.SelectedRows(0)

		Dim db As New Schema
		If Not db.NonSelectQuery("DELETE FROM Patients WHERE patient_number = @n", New With {.n = row.Cells("Patient Number").Value}) Then
			MessageBox.Show("Can not delete a record.")
			Exit Sub
		End If

		rerenderList()
	End Sub



	Private Sub PatientsDGV_SelectionChanged(sender As Object, e As EventArgs) Handles PatientsDGV.SelectionChanged
		EditButton.Enabled = True
		DeleteButton.Enabled = False
	End Sub
End Class