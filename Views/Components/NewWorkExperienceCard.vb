Public Class NewWorkExperienceCard
    Public thisWorkExp As StaffWorkExperience
    Public status As CardStatus

    Public Event OnRemove(sender As Object)
    Sub New(workExp As StaffWorkExperience, s As CardStatus)
        ' This call is required by the designer.
        InitializeComponent()

        thisWorkExp = workExp
        status = s

        PositionLabel.Text = $"As a(n) {workExp.position}"
        OrganisationLabel.Text = $"In {workExp.organisation}"
        StartDateLabel.Text = $"Start: {workExp.start_date.ToLongDateString}"
        EndDateLabel.Text = $"Finish: {workExp.end_date.ToLongDateString}"
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        RaiseEvent OnRemove(Me)
        Dispose()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim d As New WorkExperienceForm
        d.AddButton.Text = "Edit"
        d.PositionTextBox.Text = thisWorkExp.position
        d.OrganisationTextBox.Text = thisWorkExp.organisation
        d.StartDateTimePicker.Value = thisWorkExp.start_date
        d.EndDateTimePicker.Value = thisWorkExp.end_date

        Dim d_result = d.ShowDialog()

        If d_result = DialogResult.Cancel Then Exit Sub

        thisWorkExp = d.workExp
        status = CardStatus.Edited

        PositionLabel.Text = $"As a(n) {thisWorkExp.position}"
        OrganisationLabel.Text = $"In {thisWorkExp.organisation}"
        StartDateLabel.Text = $"Start: {thisWorkExp.start_date.ToLongDateString}"
        EndDateLabel.Text = $"Finish: {thisWorkExp.end_date.ToLongDateString}"
        Refresh()
    End Sub

End Class
