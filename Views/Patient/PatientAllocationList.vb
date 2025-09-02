Public Class PatientAllocationList
    Private Sub PatientAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToggleVisibilityWardElements(Visibility.Hidden)
        AllocationDGV.Hide()
        OnDateComboBox.Enabled = False

        Dim db As New Schema
        Try
            Dim result = db.SelectQuery("Admissions", "ward_num")
            If result.Count = 0 Then Exit Sub
            Dim ward_nums = result.Select(Function(r) r("ward_num")).ToArray
            WardComboBox.Items.AddRange(ward_nums)
        Catch ex As Exception
            MessageBox.Show("Error: Can not get a list of ward.")
            Exit Sub
        End Try
    End Sub

    Private Sub WardComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WardComboBox.SelectedIndexChanged
        If WardComboBox.SelectedIndex = -1 Then Exit Sub ' Exit if not selected any ward

        ToggleVisibilityWardElements(Visibility.Shown)

        OnDateComboBox.Enabled = True

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

    Private Sub WeekComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OnDateComboBox.SelectedIndexChanged
        EmptyLabel.Hide()
        AllocationDGV.Show()
    End Sub
End Class