Public Class PatientExaminationList
    Private Sub FindPatientButton_Click(sender As Object, e As EventArgs) Handles FindPatientButton.Click
        Dim f As New PickPatientDialog
        Dim result = f.ShowDialog()
    End Sub
End Class