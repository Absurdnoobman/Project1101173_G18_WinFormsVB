Public Class ExaminationForm
    Private patient As Patient
    Private consultant As Staff

    Private Sub SelectPatientButton_Click(sender As Object, e As EventArgs) Handles SelectPatientButton.Click

    End Sub

    Private Sub SelectConsultantButton_Click(sender As Object, e As EventArgs) Handles SelectConsultantButton.Click
        Dim f As PickStaffDialog = PickStaffDialog.FilterByRole("consultant")
        Dim result = f.ShowDialog()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If PatientFLP.Controls.Count = 0 Then
            Exit Sub
        Else
            patient = New Patient
            PatientFLP.Controls.Clear()
        End If

        If ConsultantFLP.Controls.Count = 0 Then
            Exit Sub
        Else
            consultant = New Staff
            ConsultantFLP.Controls.Clear()
        End If

    End Sub
End Class