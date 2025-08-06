Public Class CreateSupplyForm
	Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
		SupplyIdTextBox.Clear()
		NameTextBox.Clear()
		TypeComboBox.SelectedIndex = 0

	End Sub
End Class