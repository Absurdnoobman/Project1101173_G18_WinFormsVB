Public Class NewQualificationCard
    Public index As Integer
    Public Event OnRemoveButtonPressed(sender As Object)
    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dispose()
        RaiseEvent OnRemoveButtonPressed(Me)
    End Sub

    Public Sub SetData(qualification As StaffQualification, index As Integer)
        Me.index = index
        TypeLabel.Text = qualification.type
        InstitutionLabel.Text = qualification.institution
        DateLabel.Text = qualification.QualificationDate.ToLongDateString
    End Sub

End Class
