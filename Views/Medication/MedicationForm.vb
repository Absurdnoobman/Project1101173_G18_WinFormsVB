Public Class MedicationForm
	Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
		Dim card As New PharmaceuticalSupplyCardWithOption
		MedicationFLP.Controls.Add(card)
	End Sub

	Private Sub SelectPatientButton_Click(sender As Object, e As EventArgs) Handles SelectPatientButton.Click
		Dim result = PickPatientDialog.ShowDialog()
	End Sub
End Class