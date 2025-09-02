Public Class ExaminationForm
    Private patient As Patient
    Private consultant As Staff

    Private Sub SelectPatientButton_Click(sender As Object, e As EventArgs) Handles SelectPatientButton.Click
        Dim f As New PickPatientDialog
        Dim result = f.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub

        Dim patient = f.result.First

        Dim card As New PatientLargeCard(patient)

        PatientFLP.Controls.Add(card)
    End Sub

    Private Sub SelectConsultantButton_Click(sender As Object, e As EventArgs) Handles SelectConsultantButton.Click
        Dim f As PickStaffDialog = PickStaffDialog.FilterByPosition("consultant")
        Dim result = f.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub

        Dim staff = f.result.First()

        Dim db As New Schema
        Dim query = db.SelectQuery(
            "Works_in",
            whereClauseStr:=$"staff_num = '{staff.staff_number}'",
            selectOption:="TOP 1",
            orderByColumns:="week_beginning",
            orderOption:="DESC"
        )

        If query.Count > 0 Then
            Dim data = query.First()
            Dim w = db.Query(Of Ward, Object)("SELECT ward_number, name, location, telephone_ext, number_of_beds FROM Wards WHERE ward_number = @n", New With {.n = data("ward_num")})

            If w.Count = 0 Then
                MessageBox.Show($"Can NOT find ward with number {data("ward_num")}")
                Exit Sub
            End If

            Dim card As New StaffConsultantCard(staff, w.First, data("week_beginning"))

            ConsultantFLP.Controls.Add(card)
        End If


    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If PatientFLP.Controls.Count = 0 Then
            Exit Sub
        Else
            patient = New Patient
            PatientFLP.Controls.Clear()
        End If

        If ConsultantFLP.Controls.Count = 0 Then
            Exit Sub
        Else
            consultant = New Staff
            ConsultantFLP.Controls.Clear()
        End If

    End Sub

End Class