Public Class StaffList
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub StaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffFLP.Controls.Clear()
        FilterFLP.Controls.Clear()

        RenderStaffList()

        ' TODO: Query WorkExp and Qualification

    End Sub

    Private Sub CreateStaffButton_Click(sender As Object, e As EventArgs) Handles CreateStaffButton.Click
        Dim f As New CreateNewStaffForm
        f.ShowDialog()
    End Sub

    Private Sub AddFilterButton_Click(sender As Object, e As EventArgs) Handles AddFilterButton.Click
        Dim filterCard As New FilterCard
        FilterFLP.Controls.Add(filterCard)
    End Sub

    Private Sub RenderStaffList()
        StaffFLP.Controls.Clear()

        Dim db As New Schema
        Dim data As List(Of Staff) = db.Query(Of Staff, Object)(
            "
            SELECT * FROM Staffs
            "
        )

        For Each staff In data
            Dim card As New StaffCard
            card.SetData(staff)
            StaffFLP.Controls.Add(card)
        Next

    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RenderStaffList()
    End Sub
End Class