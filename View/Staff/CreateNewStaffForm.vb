Public Class CreateNewStaffForm

    Public qualifications As New List(Of StaffQualification)
    Public workExperiences As New List(Of StaffWorkExperience)

    Private Sub AddNewQualiButton_Click(sender As Object, e As EventArgs) Handles AddNewQualiButton.Click
        Dim AddnewQualiForm As New AddNewQualificationForm

        Dim result = AddnewQualiForm.ShowDialog()
        If result = DialogResult.Cancel Then Return

        Dim newQualification As New StaffQualification With {
            .type = AddnewQualiForm.TypeTextBox.Text,
            .institution = AddnewQualiForm.InstitutionTextBox.Text,
            .QualificationDate = AddnewQualiForm.DateTimePicker.Value
        }

        qualifications.Add(newQualification)

        Dim card As New NewQualificationCard With {.index = qualifications.Count() - 1}
        card.TypeLabel.Text = newQualification.type
        card.InstitutionLabel.Text = newQualification.institution
        card.DateLabel.Text = newQualification.QualificationDate.ToLongDateString

        AddHandler card.OnRemoveButtonPressed, AddressOf HandleQualiCardRemoveEvent

        QualificationFLP.Controls.Add(card)

    End Sub

    Private Sub AddNewWorkExpButton_Click(sender As Object, e As EventArgs) Handles AddNewWorkExpButton.Click
        Dim AddNewWorkExpForm As New AddNewWorkExperienceForm

        Dim result = AddNewWorkExpForm.ShowDialog()
        If result = DialogResult.Cancel Then Return

        Dim newWorkExp As New StaffWorkExperience With {
            .position = AddNewWorkExpForm.PositionTextBox.Text,
            .organisation = AddNewWorkExpForm.OrganisationTextBox.Text,
            .startDate = AddNewWorkExpForm.StartDateTimePicker.Value,
            .endDate = AddNewWorkExpForm.EndDateTimePicker.Value
        }

        workExperiences.Add(newWorkExp)

        Dim card As New NewWorkExperienceCard With {.index = workExperiences.Count() - 1}
        card.PositionLabel.Text = newWorkExp.position
        card.OrganisationLabel.Text = newWorkExp.organisation
        card.StartDateLabel.Text = newWorkExp.startDate.ToLongDateString
        card.EndDateLabel.Text = newWorkExp.endDate.ToLongDateString

        AddHandler card.OnRemoveButtonPressed, AddressOf HandleWorkExpCardRemoveEvent

        WorksFLP.Controls.Add(card)


    End Sub

    Private Sub HandleQualiCardRemoveEvent(sender As Object)
        Using card = DirectCast(sender, NewQualificationCard)
            qualifications.RemoveAt(card.index)
        End Using
    End Sub

    Private Sub HandleWorkExpCardRemoveEvent(sender As Object)
        Using card = DirectCast(sender, NewWorkExperienceCard)
            qualifications.RemoveAt(card.index)
        End Using
    End Sub


End Class