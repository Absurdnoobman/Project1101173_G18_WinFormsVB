Public Class PickPatientDialog
    Private _isMultiplePick As Boolean
    Private _filterByColumn As String
    Private _filterValue As Object

    Private _patients As List(Of Patient)

    Public result As List(Of Patient)

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

        Dim db As New Schema
        Try
            _patients = db.Query(Of Patient, Object)("SELECT * FROM Patients")
            If _filterByColumn IsNot Nothing And _filterValue IsNot Nothing Then
                _patients = db.Query(Of Patient, Object)(
                    $"SELECT * FROM Patients WHERE {_filterByColumn} = @v", New With {.v = _filterValue}
                )
            End If

            For Each patient In _patients
                Dim card As New PatientCardWithCheckBox
                card.SetData(patient)
                PatientFLP.Controls.Add(card)
            Next
        Catch ex As Exception
            MessageBox.Show(text:="Can not create a list.", caption:="Fatal Error")
            DialogResult = DialogResult.Abort
            Dispose()
        End Try

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim selected_card As List(Of PatientCardWithCheckBox) = PatientFLP.Controls.Cast(Of PatientCardWithCheckBox).ToList().FindAll(
            Function(c) c.isSelected
        )

        If selected_card.Count = 0 Then
            DialogResult = DialogResult.Cancel
            Close()
            Exit Sub
        End If

        Dim selected_patient_num As List(Of String) = selected_card.Select(
            Function(c) c.PatientNumberLabel.Text
        ).ToList()

        result = _patients.FindAll(
            Function(p) selected_patient_num.Contains(p.patient_number)
        )

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub SearchByComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchByComboBox.SelectedIndexChanged

    End Sub
End Class