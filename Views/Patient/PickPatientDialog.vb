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

        SearchByLabel.Text = $"Filter: '{column}' == '{value}'"
        SearchByComboBox.SelectedIndex = 0
    End Sub

    Private Sub New(isMultiple As Boolean, column As String, value As Object)
        InitializeComponent()

        _isMultiplePick = isMultiple
        _filterByColumn = column

        _filterByColumn = column
        _filterValue = value

        SearchByLabel.Text = $"Filter: '{column}' == '{value}'"
        SearchByComboBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    '''     Return A <see cref="Form"/> which allow user to choose a multiple patients
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function MultiplePick() As PickPatientDialog
        Return New PickPatientDialog(True)
    End Function

    Private Sub PickPatientDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If Not _isMultiplePick And selected_card.Count > 1 Then
            MessageBox.Show("Please pick only one patient." & vbNewLine & "CheckBoxDisablingUnimplemented")
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
        If String.IsNullOrEmpty(SearchTextBox.Text) OrElse String.IsNullOrWhiteSpace(SearchTextBox.Text) Then
            Dim db As New Schema
            Try
                RemoveNotSelectedCard()
                _patients = db.Query(Of Patient, Object)("SELECT * FROM Patients")
                If _filterByColumn IsNot Nothing And _filterValue IsNot Nothing Then
                    _patients = db.Query(Of Patient, Object)(
                        $"SELECT * FROM Patients WHERE {_filterByColumn} = @v", New With {.v = _filterValue}
                    )
                End If

                Dim selected_patient_nums As New HashSet(Of String)(
                    PatientFLP.Controls.OfType(Of PatientCardWithCheckBox)().
                        Where(Function(c) c.isSelected).
                        Select(Function(c) c.PatientNumberLabel.Text))


                For Each patient In _patients
                    If selected_patient_nums.Contains(patient.patient_number) Then Continue For
                    Dim card As New PatientCardWithCheckBox
                    card.SetData(patient)
                    PatientFLP.Controls.Add(card)
                Next

                Exit Sub
            Catch ex As Exception
                MessageBox.Show(text:="Can not create a list.", caption:="Fatal Error")
                DialogResult = DialogResult.Abort
                Dispose()
            End Try
        End If

        RerenderList()
    End Sub

    Private Sub SearchByComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchByComboBox.SelectedIndexChanged
        Dim search = SearchTextBox.Text
        If String.IsNullOrEmpty(search) OrElse String.IsNullOrWhiteSpace(search) Then Exit Sub
    End Sub

    Private Sub RerenderList()
        RemoveNotSelectedCard()

        Dim search = SearchTextBox.Text
        Dim search_clause = ""

        Select Case SearchByComboBox.SelectedItem
            Case "Patient Number"
                search_clause = "WHERE patient_number LIKE @s"
            Case "Name"
                search_clause = "WHERE firstname LIKE @s OR surname LIKE @s"
            Case "Firstname"
                search_clause = "WHERE firstname LIKE @s"
            Case "Lastname"
                search_clause = "WHERE surname LIKE @s"
        End Select

        Dim db As New Schema
        Try
            _patients = db.Query(Of Patient, Object)($"SELECT * FROM Patients {search_clause}", New With {.s = $"%{search}%"})
            If _filterByColumn IsNot Nothing And _filterValue IsNot Nothing And Not String.IsNullOrEmpty(search_clause) Then
                _patients = db.Query(Of Patient, Object)(
                    $"SELECT * FROM Patients {search_clause} AND {_filterByColumn} = @v", New With {.v = _filterValue, .s = $"%{search}%"}
                )
            End If

            Dim selected_patient_nums As New HashSet(Of String)(
                    PatientFLP.Controls.OfType(Of PatientCardWithCheckBox)().
                        Where(Function(c) c.isSelected).
                        Select(Function(c) c.PatientNumberLabel.Text))

            For Each patient In _patients
                If selected_patient_nums.Contains(patient.patient_number) Then Continue For
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

    Private Sub RemoveNotSelectedCard()
        For i As Integer = PatientFLP.Controls.Count - 1 To 0 Step -1
            Dim card = TryCast(PatientFLP.Controls(i), PatientCardWithCheckBox)
            If card IsNot Nothing AndAlso Not card.isSelected Then
                PatientFLP.Controls.RemoveAt(i)
            End If
        Next
    End Sub

End Class