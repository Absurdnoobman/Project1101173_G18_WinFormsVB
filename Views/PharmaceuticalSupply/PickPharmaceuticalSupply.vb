Public Class PickPharmaceuticalSupply
    Private _isMultiplePick As Boolean
    Private _filterByColumn As String
    Private _filterValue As Object

    Private _drugs As New List(Of PharmaceuticalSupply)

    Public result As New List(Of PharmaceuticalSupply)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        _isMultiplePick = False

    End Sub

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
    Public Shared Function MultiplePick() As PickPharmaceuticalSupply
        Return New PickPharmaceuticalSupply(True)
    End Function

    Private Sub PickPharmaceuticalSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _isMultiplePick Then
            Text = "Pick Medicine(s)"
        Else
            Text = "Pick a Medicine"
        End If

        Dim db As New Schema
        Try
            Dim result = db.Query(Of Object)("SELECT * FROM PharmaceuticalSupplies")
            If result.Count = 0 Then Exit Sub

            For Each row In result
                Dim supplier = db.Query(Of Supplier, Object)(
                    "SELECT * FROM Suppliers WHERE supplier_number = @sn",
                    New With {.sn = row("supplier_num")}
                )

                _drugs.Add(
                    New PharmaceuticalSupply With {
                        .drug_number = row("drug_number"),
                        .name = row("name"),
                        .description = row("description"),
                        .dosage = row("dosage"),
                        .method = row("method"),
                        .quantity = row("quantity"),
                        .cost_per_unit = row("cost_per_unit"),
                        .reorder_level = row("reorder_level"),
                        .supplier = supplier.FirstOrDefault
                    }
                )
            Next

            For Each drug In _drugs
                Dim card As New PharmaceuticalCardWithCheckBox(drug)
                DrugsFLP.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: SQL failed." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
            Close()
        End Try
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim selected_cards = DrugsFLP.Controls.Cast(Of PharmaceuticalCardWithCheckBox).ToList _
            .FindAll(Function(c) c.isSelected)

        If selected_cards.Count = 0 Then
            DialogResult = DialogResult.Cancel
            Close()
            Exit Sub
        End If

        If Not _isMultiplePick And selected_cards.Count > 1 Then
            MessageBox.Show("Plaese pick only one pharmaceutical supply (drug)." & vbNewLine & "CheckBoxDisablingUnimplemented")
            Exit Sub
        End If

        Dim selected_drug_num As List(Of String) = selected_cards.Select(
            Function(c) c.DrugNumberLabel.Text
        ).ToList()

        result = _drugs.FindAll(
            Function(d) selected_drug_num.Contains(d.drug_number)
        )

        DialogResult = DialogResult.OK
        Close()

    End Sub
End Class