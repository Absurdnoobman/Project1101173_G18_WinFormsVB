Public Class PatientAllocation
    Private Sub PatientAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToggleVisibilityWardElements(Visibility.Hidden)
        AllocationFLP.Hide()
        WeekComboBox.Enabled = False
    End Sub

    Private Sub WardComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WardComboBox.SelectedIndexChanged
        If WardComboBox.SelectedIndex = -1 Then Exit Sub ' Exit if not selected any ward

        ToggleVisibilityWardElements(Visibility.Shown)

        WeekComboBox.Enabled = True

    End Sub

    Private Sub ToggleVisibilityWardElements(state As Visibility)

        Select Case state

            Case Visibility.Shown
                WardNameLabel.Show()
                LocationLabel.Show()
                ChargeNurseLabel.Show()
                ChargeNurseFLP.Show()

            Case Visibility.Hidden
                WardNameLabel.Hide()
                LocationLabel.Hide()
                ChargeNurseLabel.Hide()
                ChargeNurseFLP.Hide()

        End Select

    End Sub

    Private Sub WeekComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WeekComboBox.SelectedIndexChanged
        EmptyLabel.Hide()
        AllocationFLP.Show()
    End Sub
End Class