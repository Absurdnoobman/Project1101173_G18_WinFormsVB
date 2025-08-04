Public Class PickStaffDialog

    Private _isMultiplePick As Boolean
    Private _filterByColumn As String
    Private _filterValue As Object

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

        SearchByLabel.Text = "Filter: '" & column & "' == '" & value & "'"
        SearchByComboBox.Hide()
    End Sub

    Private Sub New(isMultiple As Boolean, column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = isMultiple
        _filterByColumn = column

        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = "Filter: '" & column & "' == '" & value & "'"
        SearchByComboBox.Hide()
    End Sub

    ''' <summary>
    '''     Return A <see cref="Form"/> which allow user to choose a multiple staff
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function MultiplePick() As PickStaffDialog
        Return New PickStaffDialog(True)
    End Function

    Public Shared Function FilterByRole(role As String) As PickStaffDialog
        Return New PickStaffDialog("role", role)
    End Function


    Private Sub PickStaffDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffFLP.Controls.Clear()

        If _isMultiplePick Then
            Text = "Pick Staff"
        Else
            Text = "Pick one staff"
        End If

        Dim dt As New List(Of Staff) From {
            New Staff With {.id = "S990", .firstname = "Mannee", .surname = "jolo in squad"},
            New Staff With {.id = "S490", .firstname = "GG", .surname = "WP"}
        }

        For Each staff In dt
            Dim card As New StaffCardWithCheckBox
            card.SetData(staff)
            StaffFLP.Controls.Add(card)
        Next

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

    End Sub
End Class