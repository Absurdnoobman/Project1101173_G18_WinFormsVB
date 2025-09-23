Public Class MedicationReport
	Private Sub MedicationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ToggleVisibilityElements(Visibility.Hidden)
	End Sub

	Private Sub ToggleVisibilityElements(status As Visibility)
		Select Case status
			Case Visibility.Hidden
				PlzLabel.Show()
				MedicationsDGV.Hide()
				PatientNumberLabel.Hide()
				PatientNameLabel.Hide()

				WardLabel.Hide()
				BedNumberLabel.Hide()

				FilterFLP.Hide()
				AddFilterButton.Hide()
				ApplyFilterButton.Hide()
				RefreshButton.Hide()
				FilterLabel.Hide()

			Case Visibility.Shown
				PlzLabel.Hide()
				MedicationsDGV.Show()
				PatientNumberLabel.Show()
				PatientNameLabel.Show()

				WardLabel.Show()
				BedNumberLabel.Show()

				FilterFLP.Show()
				AddFilterButton.Show()
				ApplyFilterButton.Show()
				RefreshButton.Show()
				FilterLabel.Show()

		End Select
	End Sub

	Private Sub PickPatientButton_Click(sender As Object, e As EventArgs) Handles PickPatientButton.Click
		Dim f As New PickPatientDialog
		Dim result = f.ShowDialog

		If result = DialogResult.Abort OrElse result = DialogResult.Cancel Then Exit Sub

		Dim patient = f.result.First

		PatientNumberLabel.Text = patient.patient_number
		PatientNameLabel.Text = $"{patient.firstname} {patient.surname}"

		Dim db As New Schema
		Try
			Dim dt_set = db.GetDataSet(
				"
				SELECT
				m.drug_num AS ""Drug Number"",
				d.name AS ""Name"",
				d.[description] AS ""Description"",
				d.dosage AS ""Dosage (mg/mL)"",
				d.method AS ""Method Of Admin"",
				m.unit_per_day AS ""Units per Day"",
				m.start_date AS ""Start Date"",
				m.end_date AS ""Finish Date""
				FROM MedicationRecords m JOIN PharmaceuticalSupplies d ON m.drug_num = d.drug_number
				WHERE m.patient_num = @pn
				", New Dictionary(Of String, Object) From {{"@pn", patient.patient_number}}
			)

			RerenderMedicationsList(dt_set)

			Dim admission_result = db.SelectQuery(
				fromTable:="Admissions",
				whereClauseStr:=$"patient_num = '{patient.patient_number}'",
				selectOption:="TOP 1",
				orderByColumns:="admission_date",
				orderOption:="DESC"
			)

			If admission_result.Count = 0 Then
				BedNumberLabel.Text = ""
				WardLabel.Text = "Have not been in admission."
			Else
				Dim ward_num = admission_result.First.Item("ward_num")
				Dim ward_info = db.Query(Of Object)("SELECT ward_number, name FROM Wards WHERE ward_number = @w", New With {.w = ward_num}).FirstOrDefault
				WardLabel.Text = $"Recently: resided at ward {ward_info("ward_number")} ({ward_info("name")})"
				BedNumberLabel.Text = $"Bed Number: {admission_result.First.Item("bed_number")}"
			End If

			ToggleVisibilityElements(Visibility.Shown)
		Catch ex As Exception
			MessageBox.Show("Error: SQL error" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try

	End Sub

	Private Sub AddFilterButton_Click(sender As Object, e As EventArgs) Handles AddFilterButton.Click
		Dim filter_card As New FilterCardV2(New List(Of EntityAttribute) From {
			New EntityAttribute("drug name", SearchMode.Text),
			New EntityAttribute("drug description", SearchMode.Text),
			New EntityAttribute("start date", SearchMode.DateTime)
		})
		FilterFLP.Controls.Add(filter_card)

	End Sub

	Private Sub ApplyFilterButton_Click(sender As Object, e As EventArgs) Handles ApplyFilterButton.Click

		If FilterFLP.Controls.Count = 0 Then Exit Sub

		Dim whereClause As New List(Of String)

		Dim map As New Dictionary(Of String, String) From {
			{"drug name", "d.name"},
			{"drug description", "d.[description]"},
			{"start date", "m.start_date"}
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
				m.drug_num AS ""Drug Number"",
				d.name AS ""Name"",
				d.[description] AS ""Description"",
				d.dosage AS ""Dosage (mg/mL)"",
				d.method AS ""Method Of Admin"",
				m.unit_per_day AS ""Units per Day"",
				m.start_date AS ""Start Date"",
				m.end_date AS ""Finish Date""
				FROM MedicationRecords m JOIN PharmaceuticalSupplies d ON m.drug_num = d.drug_number
				WHERE m.patient_num = @pn AND {query}
				", New Dictionary(Of String, Object) From {{"@pn", PatientNumberLabel.Text}}
			)

			RerenderMedicationsList(dt_set)

		Catch ex As Exception
			MessageBox.Show("Error: SQL query" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try

	End Sub

	Private Sub RerenderMedicationsList(dt As DataSet)
		MedicationsDGV.DataSource = dt.Tables(0)

		With MedicationsDGV
			.Columns("Dosage (mg/mL)").DefaultCellStyle.Format = "0.##"
			.Columns("Start Date").DefaultCellStyle.Format = "dd'/'MM'/'yyyy"
			.Columns("Finish Date").DefaultCellStyle.Format = "dd'/'MM'/'yyyy"
		End With

		MedicationsDGV.Refresh()
	End Sub

	Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
		FilterFLP.Controls.Clear()

		Dim db As New Schema
		Try
			Dim dt_set = db.GetDataSet(
				"
				SELECT
				m.drug_num AS ""Drug Number"",
				d.name AS ""Name"",
				d.[description] AS ""Description"",
				d.dosage AS ""Dosage (mg/mL)"",
				d.method AS ""Method Of Admin"",
				m.unit_per_day AS ""Units per Day"",
				m.start_date AS ""Start Date"",
				m.end_date AS ""Finish Date""
				FROM MedicationRecords m JOIN PharmaceuticalSupplies d ON m.drug_num = d.drug_number
				WHERE m.patient_num = @pn
				", New Dictionary(Of String, Object) From {{"@pn", PatientNumberLabel.Text}}
			)

			RerenderMedicationsList(dt_set)

		Catch ex As Exception
			MessageBox.Show("Error: SQL error" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try

	End Sub

	Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
		Dim f As New SaveFileDialog
		f.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
		f.FileName = $"{PatientNumberLabel.Text}_Medication_{Date.Today:dd-MM-yyyy}.csv"
		Dim result = f.ShowDialog()
		If result = DialogResult.Abort OrElse result = DialogResult.Cancel Then Exit Sub

		Dim fullpath = f.FileName
		Dim data = MedicationsDGV

		Try
			Export.ToCSV(data, fullpath)
			MessageBox.Show("Successfully save CSV file.")
		Catch ex As Exception
			MessageBox.Show("Can not create a CSV file." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
		End Try

	End Sub
End Class