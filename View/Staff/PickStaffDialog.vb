Public Class PickStaffDialog

    Private _isMultiplePick As Boolean
    Private _filterByColumn As String
    Private _filterValue

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

        SearchByLabel.Hide()
        SearchByComboBox.Hide()
    End Sub

    Private Sub New(isMultiple As Boolean, column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = isMultiple
        _filterByColumn = column

        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Hide()
        SearchByComboBox.Hide()
    End Sub

    ''' <summary>
    '''     Return A Form with allow user to choose a multiple objects
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


End Class