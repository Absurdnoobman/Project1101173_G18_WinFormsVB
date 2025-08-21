Imports System.Runtime.Remoting.Messaging

Public Class PickStaffDialog

    Private _isMultiplePick As Boolean
    Private _filterByColumn As String
    Private _filterValue As Object

    Private _staffs As List(Of Staff)

    Public result As List(Of Staff)

    Private Sub New(isMultiple As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        _isMultiplePick = isMultiple

    End Sub


    Private Sub New(column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = False
        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = $"Filter: {column} == {value}"
        SearchByComboBox.Hide()
    End Sub

    Private Sub New(isMultiple As Boolean, column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = isMultiple
        _filterByColumn = column

        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = $"Filter: {column} == {value}"
        SearchByComboBox.Hide()
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
        Dim selected_staff_num As List(Of String) = selected_card.Select(
            Function(c) c.StaffNumberLabel.Text
        )

        result = _staffs.FindAll(Function(s) selected_staff_num.Contains(s.staff_number))

        Close()
    End Sub
End Class