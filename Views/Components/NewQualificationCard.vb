Public Class NewQualificationCard
    Public thisQualification As StaffQualification
    Public status As CardStatus

    Public Event OnRemove(sender As Object)
    Sub New(qualification As StaffQualification, s As CardStatus)
        ' This call is required by the designer.
        InitializeComponent()

        thisQualification = qualification

        status = s

        TypeLabel.Text = qualification.type
        InstitutionLabel.Text = qualification.institution
        DateLabel.Text = qualification.qualified_date.ToLongDateString
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        RaiseEvent OnRemove(Me)
        Dispose()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim d As New QualificationForm
        d.AddButton.Text = "Edit"
        d.TypeTextBox.Text = thisQualification.type
        d.InstitutionTextBox.Text = thisQualification.institution
        d.DateTimePicker.Value = thisQualification.qualified_date

        Dim d_result = d.ShowDialog()
        If d_result = DialogResult.Cancel Then Exit Sub

        thisQualification = d.qualification

        status = CardStatus.Edited

        TypeLabel.Text = thisQualification.type
        InstitutionLabel.Text = thisQualification.institution
        DateLabel.Text = thisQualification.qualified_date.ToLongDateString

    End Sub

End Class
