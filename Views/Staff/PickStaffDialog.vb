Public Class PickStaffDialog

    Private _isMultiplePick As Boolean
    Private _filterByColumn As String
    Private _filterValue As Object

    Private _staffs As List(Of Staff)

    Public result As List(Of Staff)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        _isMultiplePick = False
        _filterByColumn = ""

        SearchByLabel.Hide()
        SearchByComboBox.SelectedIndex = 0
    End Sub

    Private Sub New(isMultiple As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        _isMultiplePick = isMultiple

        SearchByLabel.Hide()
        SearchByComboBox.SelectedIndex = 0
    End Sub


    Private Sub New(column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = False
        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = $"Filter: {column} == {value}"
        SearchByComboBox.SelectedIndex = 0
    End Sub

    Private Sub New(isMultiple As Boolean, column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = isMultiple
        _filterByColumn = column

        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = $"Filter: {column} == {value}"
        SearchByComboBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    '''     Return A <see cref="Form"/> which allow user to choose a multiple staff
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function MultiplePick() As PickStaffDialog
        Return New PickStaffDialog(True)
    End Function

    Public Shared Function FilterByPosition(position As String) As PickStaffDialog
        Return New PickStaffDialog("position", position)
    End Function


    Private Sub PickStaffDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffFLP.Controls.Clear()

        If _isMultiplePick Then
            Text = "Pick Staff"
        Else
            Text = "Pick one staff"
        End If

        Try
            Dim db As New Schema

            _staffs = db.Query(Of Staff, Object)(
                "SELECT * FROM Staffs"
            )
            If _filterByColumn IsNot Nothing And _filterValue IsNot Nothing Then
                _staffs = db.Query(Of Staff, Object)(
                    $"SELECT * FROM Staffs WHERE {_filterByColumn} = @v", New With {.v = _filterValue}
                )
            End If

            For Each staff In _staffs
                Dim card As New StaffCardWithCheckBox
                card.SetData(staff)
                StaffFLP.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show(text:="Can not create a list.", caption:="Fatal Error")
            DialogResult = DialogResult.Abort
            Dispose()
        End Try

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        Dim selected_card As List(Of StaffCardWithCheckBox) = StaffFLP.Controls.Cast(Of StaffCardWithCheckBox).ToList().FindAll(
            Function(c) c.isSelected
        )

        If selected_card.Count = 0 Then
            DialogResult = DialogResult.Cancel
            Close()
            Exit Sub
        End If

        If Not _isMultiplePick And selected_card.Count > 1 Then
            MessageBox.Show("Plaese pick only one staff." & vbNewLine & "CheckBoxDisablingUnimplemented")
            Exit Sub
        End If

        Dim selected_staff_num As List(Of String) = selected_card.Select(
            Function(c) c.StaffNumberLabel.Text
        ).ToList()

        result = _staffs.FindAll(
            Function(s) selected_staff_num.Contains(s.staff_number)
        )

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub SearchByComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchByComboBox.SelectedIndexChanged
        Dim search = SearchTextBox.Text
        If String.IsNullOrEmpty(search) OrElse String.IsNullOrWhiteSpace(search) Then Exit Sub

        RerenderList()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If String.IsNullOrEmpty(SearchTextBox.Text) OrElse String.IsNullOrWhiteSpace(SearchTextBox.Text) Then
            Dim db As New Schema
            Try
                RemoveNotSelectedCard()

                _staffs = db.Query(Of Staff, Object)("SELECT * FROM Staffs")
                If _filterByColumn IsNot Nothing And _filterValue IsNot Nothing Then
                    _staffs = db.Query(Of Staff, Object)(
                        $"SELECT * FROM Staffs WHERE {_filterByColumn} = @v", New With {.v = _filterValue}
                    )
                End If

                Dim selected_staff_nums As New HashSet(Of String)(
                    StaffFLP.Controls.OfType(Of StaffCardWithCheckBox)().
                        Where(Function(c) c.isSelected).
                        Select(Function(c) c.StaffNumberLabel.Text))


                For Each staff In _staffs
                    If selected_staff_nums.Contains(staff.staff_number) Then Continue For
                    Dim card As New StaffCardWithCheckBox
                    card.SetData(staff)
                    StaffFLP.Controls.Add(card)
                Next

                Exit Sub
            Catch ex As Exception
                MessageBox.Show(text:="Can not create a list.", caption:="Fatal Error")
                DialogResult = DialogResult.Abort
                Close()
            End Try
        End If

        RerenderList()
    End Sub




    Private Sub RemoveNotSelectedCard()
        For i As Integer = StaffFLP.Controls.Count - 1 To 0 Step -1
            Dim card = TryCast(StaffFLP.Controls(i), StaffCardWithCheckBox)
            If card IsNot Nothing AndAlso Not card.isSelected Then
                StaffFLP.Controls.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub RerenderList()
        RemoveNotSelectedCard()

        Dim search = SearchTextBox.Text
        Dim search_clause = ""

        Select Case SearchByComboBox.SelectedItem
            Case "Staff Number"
                search_clause = "WHERE staff_number LIKE @s"
            Case "Name"
                search_clause = "WHERE firstname + ' ' + surname LIKE @s"
            Case "Firstname"
                search_clause = "WHERE firstname LIKE @s"
            Case "Lastname"
                search_clause = "WHERE surname LIKE @s"
        End Select

        Dim db As New Schema
        Try
            _staffs = db.Query(Of Staff, Object)($"SELECT * FROM Staffs {search_clause}", New With {.s = $"%{search}%"})
            If _filterByColumn IsNot Nothing And _filterValue IsNot Nothing And Not String.IsNullOrEmpty(search_clause) Then
                _staffs = db.Query(Of Staff, Object)(
                    $"SELECT * FROM Staffs {search_clause} AND {_filterByColumn} = @v", New With {.v = _filterValue, .s = $"%{search}%"}
                )
            End If

            Dim selected_staff_nums As New HashSet(Of String)(
                    StaffFLP.Controls.OfType(Of StaffCardWithCheckBox)().
                        Where(Function(c) c.isSelected).
                        Select(Function(c) c.StaffNumberLabel.Text))

            For Each staff In _staffs
                If selected_staff_nums.Contains(staff.staff_number) Then Continue For
                Dim card As New StaffCardWithCheckBox
                card.SetData(staff)
                StaffFLP.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show(text:="Can not create a list." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""), caption:="Fatal Error")
            DialogResult = DialogResult.Abort
            Dispose()
        End Try
    End Sub

End Class