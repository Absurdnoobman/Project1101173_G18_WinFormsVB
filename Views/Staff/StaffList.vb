Public Class StaffList
    Private Function filter(s As Staff) As Boolean
        Dim search As String = SearchTextBox.Text
        Dim search_by As String = SearchByComboBox.SelectedItem.ToString()

        Dim propInfo = s.GetType().GetField(search_by)
        If propInfo IsNot Nothing Then
            Dim propValue = propInfo.GetValue(s)
            If propValue IsNot Nothing Then
                Dim valueStr As String = propValue.ToString()
                ' Case-insensitive match like SQL LIKE '%search%'
                Return valueStr.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0
            End If
        End If
        Return False
    End Function

    Private _staffs As List(Of Staff)
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchByComboBox.SelectedIndex = -1 Then Exit Sub
        If String.IsNullOrEmpty(SearchTextBox.Text) Then RenderStaffList(_staffs)



        Dim result = _staffs.FindAll(
            Function(s) filter(s)
        )

        RenderStaffList(result)
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


        SearchByComboBox.Items.AddRange(
            GetType(Staff).GetFields.Select(Function(f) f.Name).ToArray
        )

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