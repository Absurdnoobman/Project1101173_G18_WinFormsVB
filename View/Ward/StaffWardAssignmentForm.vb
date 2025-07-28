Public Class StaffWardAssignmentForm
    Private Sub PickStaffButton_Click(sender As Object, e As EventArgs) Handles PickStaffButton.Click
        Dim d As New PickStaffDialog
        Dim result = d.ShowDialog()

    End Sub
End Class