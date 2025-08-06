Public Class AppointmentList
	Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

	End Sub

	Private Sub AddFilterButton_Click(sender As Object, e As EventArgs) Handles AddFilterButton.Click
		Dim filterCard As New FilterCard
		FilterFLP.Controls.Add(filterCard)
	End Sub


End Class