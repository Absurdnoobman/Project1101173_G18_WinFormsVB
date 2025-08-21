Public Class NewWorkExperienceCard
    Public index As Integer
    Public Event OnRemoveButtonPressed(sender As Object)
    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dispose()
        RaiseEvent OnRemoveButtonPressed(Me)
    End Sub

    Public Sub SetData(workExp As StaffWorkExperience, index As Integer)
        Me.index = index
        PositionLabel.Text = $"As a(n) {workExp.position}"
        OrganisationLabel.Text = $"In {workExp.organisation}"
        StartDateLabel.Text = $"Start: {workExp.start_date.ToLongDateString}"
        EndDateLabel.Text = $"Finish: {workExp.end_date.ToLongDateString}"
    End Sub

End Class
