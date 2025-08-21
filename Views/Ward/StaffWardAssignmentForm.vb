Public Class StaffWardAssignmentForm
    Private Sub PickStaffButton_Click(sender As Object, e As EventArgs) Handles PickStaffButton.Click
        Dim d As PickStaffDialog = PickStaffDialog.MultiplePick()
        Dim result = d.ShowDialog()
        If result = DialogResult.OK Then
            rederStaffCard(d.result)
        End If
    End Sub

    Private Sub rederStaffCard(staffs As List(Of Staff))
        StaffFLP.Controls.Clear()

        For Each staff In staffs
            Dim card As New SelectedStaffCardWithShift
            card.SetData(staff)
            StaffFLP.Controls.Add(card)
        Next
    End Sub

End Class