Public Class StaffWardAssignmentForm

    Private Sub StaffWardAssignmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New Schema
        Try
            Dim wards = db.QueryMulti(Of Ward, Staff, Ward, Object)(
                "SELECT * FROM Wards LEFT JOIN Staffs ON Staffs.staff_number = Wards.charge_nurse ORDER BY Wards.ward_number",
                Function(w, s) Maps.WardChargeNurse(w, s),
                fk:="charge_nurse"
            )

            Dim ward_items As List(Of WardComboBoxItem) =
                wards.Select(
                    Function(w)
                        Dim ward_str As String = $"Ward {w.ward_number}: {w.name}"
                        Return New WardComboBoxItem(ward_str, w)
                    End Function
                ).ToList()

            WardsComboBox.DataSource = ward_items
            WardsComboBox.DisplayMember = "Display"
            WardsComboBox.ValueMember = "Ward"

        Catch ex As Exception
            MessageBox.Show("Internal SQL error.")
            Dispose()
        End Try
    End Sub

    Private Sub PickStaffButton_Click(sender As Object, e As EventArgs) Handles PickStaffButton.Click
        Dim d As PickStaffDialog = PickStaffDialog.MultiplePick()
        Dim result = d.ShowDialog()
        If result = DialogResult.OK Then
            RederStaffCard(d.result)
        End If
    End Sub

    Private Sub RederStaffCard(staffs As List(Of Staff))
        StaffFLP.Controls.Clear()

        For Each staff In staffs
            Dim card As New SelectedStaffCardWithShift
            card.SetData(staff)
            StaffFLP.Controls.Add(card)
        Next
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        StaffFLP.Controls.Clear()

        WardsComboBox.SelectedIndex = -1

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If WardsComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select ward.")
            Exit Sub
        End If

        Dim selected_card = StaffFLP.Controls.Cast(Of SelectedStaffCardWithShift).ToList()
        Dim selected_staff As Dictionary(Of Staff, String) = selected_card _
            .ToDictionary(Function(c) c.Staff, Function(c) c.shift)

        Dim ward_title = WardsComboBox.SelectedItem.ToString()

        ' ward_title format will be "Ward nn: name" where nn is ward_num
        '                                 ^^
        ' use Substring to get nn    0123456

        Dim ward_id As Integer = ward_title.Substring(5, 2)

        Dim db As New Schema
        Try
            For Each row In selected_staff
                db.NonSelectQuery(
                "INSERT INTO Works_in VALUES (@staff_num, @ward_num, @shift, @week_beginning)",
                    New With {
                        .staff_num = row.Key.staff_number,
                        .ward_num = ward_id,
                        .shift = row.Value,
                        .week_beginning = DateWeekBeginingDTP.Value
                    }
                )
            Next
            MessageBox.Show("Insert Successful.")
            Dispose()
        Catch ex As Exception
            If Debugger.IsAttached Then MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class