Imports Dapper

Public Class StaffList
    'Private Function filter(s As Staff) As Boolean

    'End Function

    Private _staffs As List(Of Staff)
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchByComboBox.SelectedIndex = -1 Then Exit Sub
        If String.IsNullOrEmpty(SearchTextBox.Text) Then RenderStaffList(_staffs)

        Dim db As New Schema
        Try
            Dim search = $"%{SearchTextBox.Text}%"
            Dim result As New List(Of Staff)
            Select Case CStr(SearchByComboBox.SelectedItem)
                Case "Name"
                    result = db.Query(Of Staff, Object)("SELECT * FROM Staffs WHERE firstname LIKE @s OR surname LIKE @s", New With {.s = search})
                    RenderStaffList(result)
                Case "Firstname"

                Case "Lastname"

                Case Else
                    Exit Sub
            End Select
        Catch ex As Exception
            MessageBox.Show(
                text:="Can not search",
                caption:="Fatal Error!",
                icon:=MessageBoxIcon.Error,
                buttons:=MessageBoxButtons.OK
            )
        End Try
    End Sub

    Private Sub StaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffFLP.Controls.Clear()
        FilterFLP.Controls.Clear()

        Dim db As New Schema
        Try
            _staffs = db.Query(Of Staff, Object)(
                "
                SELECT * FROM Staffs
                "
            )

        Catch ex As Exception
            MessageBox.Show(
                text:="Can not get a list of staff from database.",
                caption:="Fatal Error!",
                icon:=MessageBoxIcon.Error,
                buttons:=MessageBoxButtons.OK
            )
            Dispose()
        End Try

        RenderStaffList(_staffs)

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

    Private Sub RenderStaffList(staffs As List(Of Staff))
        StaffFLP.Controls.Clear()

        For Each staff In staffs
            Dim card As New StaffCard
            card.SetData(staff)
            StaffFLP.Controls.Add(card)
        Next
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim db As New Schema
        Try
            _staffs = db.Query(Of Staff, Object)(
                "
                SELECT * FROM Staffs
                "
            )
        Catch ex As Exception
            MessageBox.Show(
                text:="Can not get a list of staff from database.",
                caption:="Fatal Error!",
                icon:=MessageBoxIcon.Error,
                buttons:=MessageBoxButtons.OK
            )
            Dispose()
        End Try

        RenderStaffList(_staffs)
    End Sub
End Class