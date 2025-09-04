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
        'DateRegisteredDTP.Value = Date.Today

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

    Private Sub ValidateInput()
        ' TODO
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        ValidateInput()

        ' Patient
        Dim patient_number = PatientNumberTextBox.Text
        Dim firstname = FirstnameTextBox.Text
        Dim surname = SurnameTextBox.Text
        Dim address = AddressTextBox.Text
        Dim sex As String = SexComboBox.SelectedItem
        Dim telephone = TelephoneTextBox.Text
        Dim dob = DateOfBirthDTP.Value
        Dim marital_status As String = MaritalStatusComboBox.SelectedItem
        'Dim date_registered As Date = DateRegisteredDTP.Value

        ' Next of kin
        Dim fullnameNOK = FullnameNOKTextBox.Text
        Dim relationship = RelationshipNOKTextBox.Text
        Dim addressNOK = AddressNOKTextBox.Text
        Dim telephoneNOK = TelephoneNOKTextBox.Text

        ' local doctor
        Dim fullnameLDT = FullnameLDTTextBox.Text
        Dim clinic_number = ClinicNumberLDTTextBox.Text
        Dim addressLDT = AddressLDTTextBox.Text
        Dim telephoneLDT = TelephoneLDTTextBox.Text

        Dim db As New Schema
        If Not db.NonSelectQuery(
            "
            INSERT INTO Patients VALUES (
                @patient_num, @first, @sur, @addr, @phone, @dob, @sex, @marital
            )
            ", New With {
                .patient_num = patient_number,
                .first = firstname,
                .sur = surname,
                .addr = address,
                .phone = telephone,
                .dob = dob,
                .sex = sex,
                .marital = marital_status
            }
        ) Then
            MessageBox.Show("Failed to insert.")
            Exit Sub
        End If

        If Not db.NonSelectQuery(
            "
            INSERT INTO NextOfKins VALUES (@patient, @name, @relation, @addr, @phone)
            ", New With {
                .patient = patient_number,
                .name = fullnameNOK,
                .relation = relationship,
                .addr = addressNOK,
                .phone = telephoneNOK
            }
        ) Then
            MessageBox.Show("Failed to insert the next-of-kin record.")
            Exit Sub
        End If

        If Not db.NonSelectQuery(
            "
            INSERT INTO LocalDoctors VALUES (@patient, @name, @clinic, @addr, @phone)
            ", New With {
                .patient = patient_number,
                .name = fullnameLDT,
                .clinic = clinic_number,
                .addr = addressLDT,
                .phone = telephoneLDT
            }
        ) Then
            MessageBox.Show("Failed to insert the Local Doctor record.")
            Exit Sub
        End If

        Dispose()
    End Sub
End Class