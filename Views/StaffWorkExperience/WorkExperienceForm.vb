Public Class WorkExperienceForm

    Public workExp As StaffWorkExperience

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        PositionTextBox.ResetText()
        OrganisationTextBox.ResetText()
        StartDateTimePicker.Value = Date.Today
        EndDateTimePicker.Value = Date.Today
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        DialogResult = DialogResult.OK
        workExp = New StaffWorkExperience With {
            .position = PositionTextBox.Text,
            .organisation = OrganisationTextBox.Text,
            .start_date = StartDateTimePicker.Value,
            .end_date = EndDateTimePicker.Value
        }

        Close()
    End Sub
End Class