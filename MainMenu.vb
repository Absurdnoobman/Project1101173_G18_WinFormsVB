Public Class MainMenuForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OpenStaffListButton.Click
        'MessageBox.Show("L in the Chat", "Ling gang guli guli gu li wa sha", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Dim f As New StaffList
        f.ShowDialog() 'Prevent Main Menu Interaction until the form closed


    End Sub

End Class
