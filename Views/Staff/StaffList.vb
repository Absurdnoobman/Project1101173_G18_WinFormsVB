Public Class StaffList

    Private _staffs As List(Of Staff)
    Dim inStaffNumberList As New List(Of String)

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchByComboBox.SelectedIndex = -1 Then Exit Sub
        If String.IsNullOrEmpty(SearchTextBox.Text) Then RenderStaffList(_staffs)

        Dim db As New Schema
        Try
            Dim search = $"%{SearchTextBox.Text}%"
            Dim result As New List(Of Staff)
            Select Case CStr(SearchByComboBox.SelectedItem)
                Case "Fullname"
                    result = db.Query(Of Staff, Object)($"SELECT * FROM Staffs WHERE (firstname LIKE @s OR surname LIKE @s)", New With {.s = search})
                    RenderStaffList(result)
                Case "Firstname"
                    result = db.Query(Of Staff, Object)($"SELECT * FROM Staffs WHERE firstname LIKE @s", New With {.s = search})
                    RenderStaffList(result)
                Case "Lastname"
                    result = db.Query(Of Staff, Object)($"SELECT * FROM Staffs WHERE surname LIKE @s", New With {.s = search})
                    RenderStaffList(result)
                Case "Staff Number"
                    result = db.Query(Of Staff, Object)($"SELECT * FROM Staffs WHERE staff_number LIKE @s", New With {.s = search})
                    RenderStaffList(result)
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


        OrderByComboBox.DataSource = New List(Of Object) From {
            New With {.displayName = "Staff Number", .value = "staff_number"},
            New With {.displayname = "Name", .value = "firstname, surname"}
        }

        OrderByComboBox.DisplayMember = "displayName"
        OrderByComboBox.ValueMember = "value"

        OrderByComboBox.SelectedIndex = 0

        OrderComboBox.DataSource = New List(Of Object) From {
            New With {.displayName = "Ascending", .value = "ASC"},
            New With {.displayName = "Descending", .value = "DESC"}
        }

        OrderComboBox.DisplayMember = "displayName"
        OrderComboBox.ValueMember = "value"

        OrderComboBox.SelectedIndex = 0

        Dim order_by = $"ORDER BY {OrderByComboBox.SelectedValue} {OrderComboBox.SelectedValue}"

        Dim db As New Schema
        Try
            _staffs = db.Query(Of Staff, Object)(
                $"SELECT * FROM Staffs {order_by}"
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

        SearchByComboBox.SelectedIndex = 0
        AddHandler OrderComboBox.SelectedIndexChanged, AddressOf OrderComboBox_SelectedIndexChanged

    End Sub

    Private Sub CreateStaffButton_Click(sender As Object, e As EventArgs) Handles CreateStaffButton.Click
        Dim f As New CreateNewStaffForm
        f.ShowDialog()
        RefreshButton_Click(Nothing, Nothing)
    End Sub

    Private Sub AddFilterButton_Click(sender As Object, e As EventArgs) Handles AddFilterButton.Click
        Dim entities As New List(Of String) From {"Qualification", "Work Experience"}
        Dim quali_attributes As New List(Of EntityAttribute) From {
            New EntityAttribute("type", SearchMode.Text, GetSuggestions("Qualifications", "type")),
            New EntityAttribute("institution", SearchMode.Text, GetSuggestions("Qualifications", "institution"))
        }
        Dim work_attributes As New List(Of EntityAttribute) From {
            New EntityAttribute("position", SearchMode.Text, GetSuggestions("WorkExperiences", "position")),
            New EntityAttribute("organisation", SearchMode.Text, GetSuggestions("WorkExperiences", "organisation"))
        }
        Dim entityAttributes As New Dictionary(Of String, List(Of EntityAttribute)) From {
            {"Qualification", quali_attributes},
            {"Work Experience", work_attributes}
        }

        Dim card As New FilterCard(entities, entityAttributes)
        FilterFLP.Controls.Add(card)

    End Sub


    Private Sub RenderStaffList(staffs As List(Of Staff))
        StaffFLP.Controls.Clear()

        For Each staff In staffs
            Dim card As New StaffCard
            card.SetData(staff)
            StaffFLP.Controls.Add(card)
        Next
    End Sub

    Private Function GetSuggestions(table As String, attribute As String) As List(Of String)
        Dim db As New Schema
        Try
            Dim result = db.SelectQuery(table, attribute, selectOption:="DISTINCT")
            If result.Count = 0 Then Return New List(Of String)
            Return result.Select(Function(r) r(attribute).ToString).ToList()
        Catch ex As Exception
            MessageBox.Show("Error: Can not get an attribute from table " & vbNewLine & $"{table}.{attribute}" & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine} {ex.StackTrace}", ""))
            Return New List(Of String)
        End Try
    End Function


    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        FilterFLP.Controls.Clear()
        inStaffNumberList.Clear()

        Dim order_by = $"ORDER BY {OrderByComboBox.SelectedValue} {OrderComboBox.SelectedValue}"
        Dim db As New Schema
        Try
            _staffs = db.Query(Of Staff, Object)(
                $"
                SELECT * FROM Staffs {order_by}
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

    Private Sub ApplyFilterButton_Click(sender As Object, e As EventArgs) Handles ApplyFilterButton.Click
        Dim db As New Schema
        For Each c In FilterFLP.Controls
            Dim card = DirectCast(c, FilterCard)
            If Not card.IsActive() Then Continue For

            Try
                Dim sql = card.GetDbQueryString(New Dictionary(Of String, String) From {
                    {"Qualification", "Qualifications"},
                    {"Work Experience", "WorkExperiences"}
                })

                Dim result = db.Query(sql.command, sql.params)

                Dim result_numbers = result.Select(Function(r) r("staff_num")).ToList.Cast(Of String).ToList
                inStaffNumberList.RemoveAll(Function(num) result_numbers.Contains(num))
                inStaffNumberList.AddRange(result_numbers)

            Catch ex As Exception
                MessageBox.Show("Error: Internal Logic." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message}{vbNewLine}{ex.StackTrace}", ""))
            End Try
        Next

        Try
            Dim cmd = $"SELECT * FROM Staffs WHERE staff_number IN @list ORDER BY {OrderByComboBox.SelectedValue} {OrderComboBox.SelectedValue}"
            Dim result_staffs = db.Query(Of Staff, Object)(cmd, New With {.list = inStaffNumberList})
            RenderStaffList(result_staffs)
        Catch ex As Exception
            MessageBox.Show("Error: SQL can not get a list of staff." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
        End Try

    End Sub

    Private Sub OrderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        If OrderComboBox.SelectedIndex = -1 Then Exit Sub
        Dim db As New Schema
        If FilterFLP.Controls.Count = 0 Then
            Try
                Dim result = db.Query(Of Staff, Object)($"SELECT * FROM Staffs ORDER BY {OrderByComboBox.SelectedValue} {OrderComboBox.SelectedValue}")
                RenderStaffList(result)
            Catch ex As Exception
                MessageBox.Show("Error: SQL query." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
                Exit Sub
            End Try
        Else
            ApplyFilterButton_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub LogicModeButton_Click(sender As Object, e As EventArgs) Handles LogicModeButton.Click
        ' Toggle Filter Logic Mode OR / AND
        Select Case LogicModeButton.Text
            Case "AND"
                LogicModeButton.Text = "OR"
            Case "OR"
                LogicModeButton.Text = "AND"
        End Select
    End Sub
End Class