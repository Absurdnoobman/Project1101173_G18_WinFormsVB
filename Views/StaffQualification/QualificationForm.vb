Public Class QualificationForm

    Public qualification As StaffQualification

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If Not IsFormValid() Then
            MessageBox.Show("Invalid Form")
            Return
        End If

        DialogResult = DialogResult.OK
        qualification = New StaffQualification With {
            .type = TypeTextBox.Text,
            .institution = InstitutionTextBox.Text,
            .qualified_date = DateTimePicker.Value
        }
        Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        TypeTextBox.ResetText()
        InstitutionTextBox.ResetText()
        DateTimePicker.Value = Date.Today
    End Sub

    Private Function IsFormValid() As Boolean
        Return Not TypeTextBox.Text = String.Empty And Not InstitutionTextBox.Text = String.Empty
    End Function
End Class