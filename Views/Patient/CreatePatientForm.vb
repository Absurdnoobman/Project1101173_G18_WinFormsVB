Public Class CreatePatientForm
    Private Sub ResetNextOfKinButton_Click(sender As Object, e As EventArgs) Handles ResetNextOfKinButton.Click
        FullnameNOKTextBox.Clear()
        RelationshipNOKTextBox.Clear()
        TelephoneNOKTextBox.Clear()
        AddressNOKTextBox.Clear()
    End Sub

    Private Sub ResetLocalDoctorButton_Click(sender As Object, e As EventArgs) Handles ResetLocalDoctorButton.Click
        FullnameLDTTextBox.Clear()
        ClinicNumberLDTTextBox.Clear()
        TelephoneLDTTextBox.Clear()
        AddressLDTTextBox.Clear()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ' CLEAR all Text input

        PatientNumberTextBox.Clear()

        FirstnameTextBox.Clear()
        SurnameTextBox.Clear()
        AddressTextBox.Clear()
        SexComboBox.SelectedIndex = -1
        AddressTextBox.Clear()
        MaritalStatusComboBox.SelectedIndex = -1
        TelephoneTextBox.Clear()
        DateOfBirthDTP.Value = Date.Today
        DateRegisteredDTP.Value = Date.Today

        ' CLEAR all Text input in Next-of-kin Detail
        FullnameNOKTextBox.Clear()
        RelationshipNOKTextBox.Clear()
        TelephoneNOKTextBox.Clear()
        AddressNOKTextBox.Clear()

        ' CLEAR all Text input in Local Doctor Detail
        FullnameLDTTextBox.Clear()
        ClinicNumberLDTTextBox.Clear()
        TelephoneLDTTextBox.Clear()
        AddressLDTTextBox.Clear()
    End Sub
End Class