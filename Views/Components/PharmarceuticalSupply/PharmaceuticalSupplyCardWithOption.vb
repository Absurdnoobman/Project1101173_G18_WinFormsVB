Public Class PharmaceuticalSupplyCardWithOption
	Public thisDrug As PharmaceuticalSupply
	Public Property cardStatus As CardStatus = CardStatus.NewlyAdded

	Private original_data = New Dictionary(Of String, Object)

	Sub New(drug As PharmaceuticalSupply, Optional status As CardStatus = CardStatus.NewlyAdded)
		' This call is required by the designer.
		InitializeComponent()

		thisDrug = drug
		cardStatus = status

		NameLabel.Text = drug.name
		MethodLabel.Text = $"Method of Admin: {drug.method}"
		DosageLabel.Text = $"Dosage: {drug.dosage:0.##} mg/mL"

	End Sub

	Sub New(drug As PharmaceuticalSupply, start As Date, finish As Date, unit_per_day As Integer, Optional status As CardStatus = CardStatus.Original)
		' This call is required by the designer.
		InitializeComponent()

		thisDrug = drug
		cardStatus = status

		NameLabel.Text = drug.name
		MethodLabel.Text = $"Method of Admin: {drug.method}"
		DosageLabel.Text = $"Dosage: {drug.dosage:0.##} mg/mL"

		StartDateTimePicker.Value = start
		StartDateTimePicker.Enabled = False

		FinishDateTimePicker.Value = finish
		UnitPerDayNumericUpDown.Value = unit_per_day

		original_data("start_date") = start
		original_data("finish_date") = finish
		original_data("unit_per_day") = unit_per_day

	End Sub

	Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
		Dispose()
	End Sub

	Public Sub CheckStatus()
		If StartDateTimePicker.Value <> CDate(original_data("start_date")) OrElse
			FinishDateTimePicker.Value <> CDate(original_data("finish_date")) OrElse
			UnitPerDayNumericUpDown.Value <> CDec(original_data("unit_per_day")) _
		Then
			cardStatus = CardStatus.Edited
		End If
	End Sub

End Class
