Public Class EditPatientAllocationForm

	Private _original_data As New Dictionary(Of String, Object)
	Private _ward_num As Integer

	Sub New(patient_num As String, patient_name As String, ward_number As Integer, original_data As Dictionary(Of String, Object))
		' This call is required by the designer.
		InitializeComponent()

		_original_data = original_data
		_ward_num = ward_number

		PatientNumberLabel.Text = patient_num
		PatientNameLabel.Text = patient_name

	End Sub

	Private Sub EditPatientAllocationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		BedNumberTextBox.Text = _original_data("Bed Number")
		DurationTextBox.Text = _original_data("Expected Stay (Days)")

		PlacedDTP.Value = Date.Parse(_original_data("Date Placed"))

		ActualLeaveDTP.Enabled = isLeftCheckBox.Checked

		If _original_data.ContainsKey("Actual Leave") And _original_data("Actual Leave") Is Nothing Then

			isLeftCheckBox.Checked = False
			ActualLeaveDTP.Value = PlacedDTP.Value.AddDays(_original_data("Expected Stay (Days)"))

		ElseIf _original_data.ContainsKey("Actual Leave") And _original_data("Actual Leave") IsNot Nothing Then

			isLeftCheckBox.Checked = True
			isLeftCheckBox.Enabled = False
			ActualLeaveDTP.Value = _original_data("Actual Leave")

		Else
			isLeftCheckBox.Checked = False
			ActualLeaveDTP.Value = PlacedDTP.Value.AddDays(_original_data("Expected Stay (Days)"))
		End If



	End Sub

	Private Sub isLeftCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles isLeftCheckBox.CheckedChanged
		ActualLeaveDTP.Enabled = isLeftCheckBox.Checked
	End Sub

	Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
		Dim bed_num As Integer
		If Not Integer.TryParse(BedNumberTextBox.Text, bed_num) _
			Or String.IsNullOrEmpty(BedNumberTextBox.Text) _
			Or String.IsNullOrWhiteSpace(BedNumberTextBox.Text) Then
			MessageBox.Show("Please enter bed number and it must be a whole number.")
			Exit Sub
		End If

		Dim duration As Integer
		If Not Integer.TryParse(DurationTextBox.Text, duration) _
			Or String.IsNullOrEmpty(BedNumberTextBox.Text) _
			Or String.IsNullOrWhiteSpace(DurationTextBox.Text) Then
			MessageBox.Show("Please enter duration and it must be a whole number.")
			Exit Sub
		End If

		Dim date_leave As Date?
		If isLeftCheckBox.Checked Then
			date_leave = ActualLeaveDTP.Value
		Else
			date_leave = Nothing
		End If

		Dim db As New Schema
		If Not db.NonSelectQuery(
			"
			UPDATE Admissions 
			SET bed_number = @bed , expected_duration_days = @day, actual_discharge_date = @leave 
			WHERE patient_num = @p AND ward_num = @w AND admission_date = @ad
			",
			New With {
				.p = PatientNumberLabel.Text, .w = _ward_num, .ad = Date.Parse(_original_data("Date Placed")),
				.bed = bed_num, .day = duration, .leave = date_leave
			}
		) Then
			MessageBox.Show("Can not update a record.")
			Exit Sub
		End If

		DialogResult = DialogResult.OK
		Close()
	End Sub
End Class