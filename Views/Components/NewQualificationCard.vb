Public Class NewQualificationCard
    Public index As Integer

    Public thisQualification As StaffQualification

    Public Event OnRemoveButtonPressed(sender As Object)
    Public Event OnEditButtonPressed(sender As Object)

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dispose()
        RaiseEvent OnRemoveButtonPressed(Me)
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dispose()
        RaiseEvent OnEditButtonPressed(Me)
    End Sub

    Public Sub SetData(qualification As StaffQualification, index As Integer)
        thisQualification = qualification

        Me.index = index
        TypeLabel.Text = qualification.type
        InstitutionLabel.Text = qualification.institution
        DateLabel.Text = qualification.qualified_date.ToLongDateString
    End Sub


End Class
