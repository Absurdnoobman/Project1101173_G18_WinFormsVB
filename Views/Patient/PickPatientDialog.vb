Public Class PickPatientDialog
    Private _isMultiplePick As Boolean
    Private _filterByColumn As String
    Private _filterValue As Object

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _isMultiplePick = False
        _filterByColumn = ""

        SearchByComboBox.SelectedIndex = 0
    End Sub

    Private Sub New(isMultiple As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        _isMultiplePick = isMultiple

        SearchByComboBox.SelectedIndex = 0
    End Sub


    Private Sub New(column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = False
        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = $"Filter: '{column}' == '{value}'"
        SearchByComboBox.Hide()
    End Sub

    Private Sub New(isMultiple As Boolean, column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = isMultiple
        _filterByColumn = column

        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = $"Filter: '{column}' == '{value}'"
        SearchByComboBox.Hide()
    End Sub

    ''' <summary>
    '''     Return A <see cref="Form"/> which allow user to choose a multiple patients
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function MultiplePick() As PickPatientDialog
        Return New PickPatientDialog(True)
    End Function

    Private Sub PickStaffDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PatientFLP.Controls.Clear()

        If _isMultiplePick Then
            Text = "Pick Patients"
        Else
            Text = "Pick a Patient"
        End If

        Dim dt As New List(Of Patient) From {
            New Patient With {.id = "2344", .Firstname = "Mannee", .Surname = "jolo in squad"},
            New Patient With {.id = "4433", .Firstname = "GG", .Surname = "WP"}
        }

        For Each patient In dt

        Next

    End Sub

End Class