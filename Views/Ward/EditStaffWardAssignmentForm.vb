Public Class EditStaffWardAssignmentForm
    Dim origin_staff_shift As New Dictionary(Of Staff, List(Of String))
    Dim ward_num As Integer

    Sub New(staff_with_shift As Dictionary(Of Staff, List(Of String)), ward_number As Integer, week_beginning As Date)
        ' This call is required by the designer.
        InitializeComponent()

        origin_staff_shift = staff_with_shift

        For Each kpv In staff_with_shift
            For Each shift In kpv.Value
                Dim card As New StaffCardWithShift
                card.SetData(kpv.Key, shift)
                card.RemoveButton.Enabled = False
                StaffFLP.Controls.Add(card)
            Next
        Next

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

            DateWeekBeginingDTP.Value = week_beginning

            For Each item As WardComboBoxItem In WardsComboBox.Items
                If item.Ward.ward_number = ward_number Then
                    WardsComboBox.SelectedItem = item
                    Exit For
                End If
            Next

            ward_num = ward_number

        Catch ex As Exception
            MessageBox.Show("Internal SQL error.")
            Dispose()
        End Try

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim week_begin = DateWeekBeginingDTP.Value

        Dim failed_staff As New List(Of String)

        Dim db As New Schema
        For Each kpv In origin_staff_shift
            For Each shift In kpv.Value
                If Not db.NonSelectQuery(
                "
                DELETE FROM Works_in 
                WHERE ward_num = @w 
                AND week_beginning = @d 
                AND staff_num = @n
                AND shift = @s
                ",
                New With {
                    .w = ward_num,
                    .d = week_begin,
                    .n = kpv.Key.staff_number,
                    .s = shift
                }
            ) Then
                    MessageBox.Show($"Can not update record ward_num = {ward_num}, week_beginning = {week_begin}, staff_name = {kpv.Key.staff_number}, shift = {kpv.Value}" & vbNewLine & "Skipping Update")
                    failed_staff.Add(kpv.Key.staff_number)
                End If
            Next
        Next

        For Each card In StaffFLP.Controls.Cast(Of StaffCardWithShift).ToList
            If failed_staff.Contains(card.Staff.staff_number) Then Continue For

            If Not db.NonSelectQuery(
                "
                INSERT INTO Works_in (staff_num, ward_num, week_beginning, shift) VALUES (@staff, @ward, @week, @shift)
                ",
                New With {.ward = ward_num, .week = week_begin, .staff = card.Staff.staff_number, .shift = card.shift}
            ) Then
                MessageBox.Show($"Can not insert record ward_num = {ward_num}, week_beginning = {week_begin}, staff_name = {card.Staff.staff_number}, shift = {card.shift}")
            End If
        Next

        DialogResult = DialogResult.OK
        Close()

    End Sub
End Class