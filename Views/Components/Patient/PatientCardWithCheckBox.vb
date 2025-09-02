Public Class PatientCardWithCheckBox
    Public isSelected As Boolean = False
    Public Sub SetData(patient As Patient)
        PatientNumberLabel.Text = patient.patient_number
        FirstnameLabel.Text = patient.firstname
        SurnameLabel.Text = patient.surname
    End Sub

    Private Sub SelectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectCheckBox.CheckedChanged
        isSelected = SelectCheckBox.Checked
    End Sub
End Class
