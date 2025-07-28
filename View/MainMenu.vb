Public Class MainMenuForm

    Private Sub OpenStaffListButton_Click(sender As Object, e As EventArgs) Handles OpenStaffListButton.Click
        ' MessageBox.Show("L in the Chat", "Ling gang guli guli gu li wa sha", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Dim f As New StaffList
        f.ShowDialog() 'Prevent Main Menu Interaction until the form closed


    End Sub

    Private Sub OpenWardButton_Click(sender As Object, e As MouseEventArgs) Handles OpenWardButton.Click
        Dim f As New WardDetailForm
        f.ShowDialog()
    End Sub

    Private Sub WardAssignmentButton_Click(sender As Object, e As EventArgs) Handles WardAssignmentButton.Click
        Dim f As New StaffWardAssignmentForm
        f.ShowDialog()
    End Sub
End Class
