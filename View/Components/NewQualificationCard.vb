Public Class NewQualificationCard
    Public index As Integer
    Public Event OnRemoveButtonPressed(sender As Object)
    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dispose()
        RaiseEvent OnRemoveButtonPressed(Me)
    End Sub

End Class
