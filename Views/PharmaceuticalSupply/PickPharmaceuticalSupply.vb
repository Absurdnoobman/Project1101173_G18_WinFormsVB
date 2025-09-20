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

        SearchByComboBox.SelectedIndex = 0

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

    Private Sub SearchByComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchByComboBox.SelectedIndexChanged
        Dim search = SearchTextBox.Text
        If String.IsNullOrEmpty(search) OrElse String.IsNullOrWhiteSpace(search) Then Exit Sub

        renderList()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim search = SearchTextBox.Text
        Dim db As New Schema

        If String.IsNullOrEmpty(search) OrElse
            String.IsNullOrWhiteSpace(search) Then
            Try
                RemoveNotSelectedCard

                Dim result = db.Query(Of Object)("SELECT * FROM PharmaceuticalSupplies")
                If result.Count = 0 Then
                    DrugsFLP.Controls.Clear()
                    Exit Sub
                End If

                _drugs.Clear()
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

                Dim selected_drug_nums As New HashSet(Of String)(
                    DrugsFLP.Controls.OfType(Of PharmaceuticalCardWithCheckBox)().
                        Where(Function(c) c.isSelected).
                        Select(Function(c) c.DrugNumberLabel.Text))

                For Each drug In _drugs
                    If selected_drug_nums.Contains(drug.drug_number) Then Continue For
                    Dim card As New PharmaceuticalCardWithCheckBox(drug)
                    DrugsFLP.Controls.Add(card)
                Next

            Catch ex As Exception
                MessageBox.Show("Error: SQL failed." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
                Close()
            End Try
        End If

        renderList()
    End Sub

    Private Sub RemoveNotSelectedCard()
        For i As Integer = DrugsFLP.Controls.Count - 1 To 0 Step -1
            Dim card = TryCast(DrugsFLP.Controls(i), PharmaceuticalCardWithCheckBox)
            If card IsNot Nothing AndAlso Not card.isSelected Then
                DrugsFLP.Controls.RemoveAt(i)
            End If
        Next
    End Sub
    Private Sub renderList()

        RemoveNotSelectedCard()

        Dim search = SearchTextBox.Text

        Dim db As New Schema

        Dim where_clause = ""
        Select Case CStr(SearchByComboBox.SelectedItem)
            Case "Drug Number"
                where_clause = "WHERE drug_number LIKE @s"
            Case "Name"
                where_clause = "WHERE name LIKE @s"
            Case "Description"
                where_clause = "WHERE description LIKE @s"
            Case "Method"
                where_clause = "WHERE method LIKE @s"
        End Select

        Try
            Dim result = db.Query(Of Object)($"SELECT * FROM PharmaceuticalSupplies {where_clause}", New With {.s = $"%{search}%"})
            If result.Count = 0 Then
                RemoveNotSelectedCard()
                Exit Sub
            End If

            _drugs.Clear()
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

            Dim selected_drug_nums As New HashSet(Of String)(
                    DrugsFLP.Controls.OfType(Of PharmaceuticalCardWithCheckBox)().
                        Where(Function(c) c.isSelected).
                        Select(Function(c) c.DrugNumberLabel.Text))

            For Each drug In _drugs
                If selected_drug_nums.Contains(drug.drug_number) Then Continue For
                Dim card As New PharmaceuticalCardWithCheckBox(drug)
                DrugsFLP.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show(text:="Can not render a list." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""), caption:="Fatal Error")
            DialogResult = DialogResult.Abort
            Dispose()
        End Try

    End Sub


End Class