Public Class PatientAllocationList
    Private _wards As List(Of Ward)
    Private Sub PatientAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToggleVisibilityWardElements(Visibility.Hidden)
        AllocationDGV.Hide()
        OnDateComboBox.Enabled = False

        Dim db As New Schema
        Try
            _wards = db.QueryMulti(Of Ward, Staff, Ward, Object)(
                "SELECT * FROM Wards LEFT JOIN Staffs ON Staffs.staff_number = Wards.charge_nurse ORDER BY Wards.ward_number",
                Function(w, s) Maps.WardChargeNurse(w, s),
                fk:="charge_nurse"
            )

            WardComboBox.Items.AddRange(_wards.Select(
                Function(w) $"{w.ward_number}"
            ).ToArray())

        Catch ex As Exception
            MessageBox.Show("Error: Can not get a list of ward.")
            Exit Sub
        End Try
    End Sub

    Private Sub WardComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WardComboBox.SelectedIndexChanged
        If WardComboBox.SelectedIndex = -1 Then Exit Sub ' Exit if not selected any ward

        ToggleVisibilityWardElements(Visibility.Shown)

        SetWardDetail(WardComboBox.SelectedItem)

        OnDateComboBox.Enabled = True

        Dim db As New Schema
        Try
            Dim result = db.SelectQuery("Admissions", "admission_date", $"ward_num = {WardComboBox.SelectedItem}", "DISTINCT")
            Dim dates = result.Select(
                Function(r) r("admission_date")
            ).ToArray()

            OnDateComboBox.Items.AddRange(dates)
            OnDateComboBox.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Internal Error." & vbNewLine & If(Debugger.IsAttached, ex.Message, ""))
            Exit Sub
        End Try

    End Sub

    Private Sub SetWardDetail(ward_num As Integer)
        Dim ward = _wards.Find(Function(w) w.ward_number = ward_num)

        WardNameLabel.Text = ward.name
        LocationLabel.Text = ward.location

        ChargeNurseStaffNumLabel.Text = ward.charge_nurse.staff_number
        ChargeNurseFullnameLabel.Text = $"{ward.charge_nurse.firstname} {ward.charge_nurse.surname}"
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

    Private Sub OnDateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OnDateComboBox.SelectedIndexChanged
        EmptyLabel.Hide()

        RenderList()

        AllocationDGV.Show()
    End Sub

    Private Sub AllocationDGV_DataSourceChanged(sender As Object, e As EventArgs) Handles AllocationDGV.DataSourceChanged
        RecordsNumberLabel.Text = $"Records: {AllocationDGV.RowCount}"
    End Sub

    Private Sub AllocationDGV_VisibleChanged(sender As Object, e As EventArgs) Handles AllocationDGV.VisibleChanged
        RecordsNumberLabel.Visible = AllocationDGV.Visible
    End Sub

    Private Sub AllocationDGV_SelectionChanged(sender As Object, e As EventArgs) Handles AllocationDGV.SelectionChanged
        If AllocationDGV.SelectedRows.Count = 0 Then Exit Sub

        EditButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If AllocationDGV.SelectedRows.Count = 0 Then Exit Sub

        Dim row = AllocationDGV.SelectedRows(0)

        Dim dict As New Dictionary(Of String, Object)

        For Each cell As DataGridViewCell In row.Cells
            dict.Add(row.Cells(cell.ColumnIndex).OwningColumn.Name, cell.Value)
        Next

        Dim f As New EditPatientAllocationForm(
            dict("Patient Number"), dict("Patient Fullname"), WardComboBox.SelectedItem, dict
        )
        Dim result = f.ShowDialog
        If result = DialogResult.Abort OrElse result = DialogResult.Cancel Then Exit Sub

        RenderList()

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If AllocationDGV.SelectedRows.Count = 0 Then Exit Sub

        Dim row = AllocationDGV.SelectedRows(0)

        Dim db As New Schema
        If Not db.NonSelectQuery(
            "
            DELETE FROM Admission 
            WHERE patient_num = @p AND ward_num = @w AND admission_date = @ad
            ", New With {
                .p = CStr(row.Cells("Patient Number").Value),
                .w = WardComboBox.SelectedItem,
                .ad = Date.Parse(row.Cells("Date Placed").Value)
            }
        ) Then
            MessageBox.Show("Can not delete a record.")
            Exit Sub
        End If

        RenderList()
    End Sub

    Private Sub RenderList()
        Dim db As New Schema
        Try
            Dim data_set = db.GetDataSet("
                SELECT 
                    a.patient_num AS [Patient Number], 
                    p.firstname + ' ' + p.surname AS [Patient Fullname],
                    a.bed_number  AS [Bed Number],
                    CAST(a.admission_date AS datetime) AS [Date Placed],
                    a.expected_duration_days AS [Expected Stay (Days)],
                    CAST(DATEADD(DAY, a.expected_duration_days, a.admission_date) AS datetime) AS [Date Leave],
                    CAST(a.actual_discharge_date AS datetime) AS [Actual Leave]
                FROM Admissions a
                JOIN Patients p ON a.patient_num = p.patient_number
                WHERE ward_num = @w AND admission_date = @d;",
                New Dictionary(Of String, Object) From {
                    {"@w", WardComboBox.SelectedItem.ToString},
                    {"@d", Date.Parse(OnDateComboBox.SelectedItem)}
                }
            )

            AllocationDGV.DataSource = data_set.Tables(0)

            With AllocationDGV
                .Columns("Date Placed").DefaultCellStyle.Format = "dddd dd'/'MM'/'yyyy"
                .Columns("Date Leave").DefaultCellStyle.Format = "dddd dd'/'MM'/'yyyy"
                .Columns("Actual Leave").DefaultCellStyle.Format = "dddd dd'/'MM'/'yyyy"
                .Columns("Actual Leave").DefaultCellStyle.NullValue = "Not Leave Yet"
            End With

            AllocationDGV.Refresh()

        Catch ex As Exception
            MessageBox.Show("Internal Error." & vbNewLine & If(Debugger.IsAttached, ex.Message, ""))
        End Try
    End Sub


End Class