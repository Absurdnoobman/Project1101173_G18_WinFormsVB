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

        For Each staff In staffs
            Dim card As New StaffCardWithShift
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

        Dim selected_card = StaffFLP.Controls.Cast(Of StaffCardWithShift).ToList()
        Dim ward_id As Integer = CType(WardsComboBox.SelectedItem, WardComboBoxItem).Ward.ward_number

        Dim db As New Schema
        Try
            For Each card In selected_card
                If Not db.NonSelectQuery(
                "INSERT INTO Works_in VALUES (@staff_num, @ward_num, @shift, @week_beginning)",
                    New With {
                        .staff_num = card.Staff.staff_number,
                        .ward_num = ward_id,
                        .shift = card.shift,
                        .week_beginning = DateWeekBeginingDTP.Value
                    }
                ) Then
                    MessageBox.Show($"Can not insert a record for staff_num = {card.Staff.staff_number}, shift = {card.shift}" & vbNewLine & "Skipping Insert")
                End If
            Next
            MessageBox.Show("Insert Successful.")
            Dispose()
        Catch ex As Exception
            If Debugger.IsAttached Then MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class