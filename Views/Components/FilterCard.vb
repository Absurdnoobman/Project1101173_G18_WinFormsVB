Imports System.Text

Public Class FilterCard

    Dim _fields As New Dictionary(Of String, List(Of EntityAttribute))

    'Public Event FilterActivated(sender As Object)
    Sub New(
           entities As List(Of String),
           fields As Dictionary(Of String, List(Of EntityAttribute))
    )
        ' This call is required by the designer.
        InitializeComponent()

        EntityComboBox.Items.AddRange(entities.ToArray())

        _fields = fields

    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dispose()
    End Sub

    Private Sub EntityComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EntityComboBox.SelectedIndexChanged
        FieldComboBox.DataSource = _fields(EntityComboBox.SelectedItem)
        FieldComboBox.DisplayMember = "Name"
        FieldComboBox.ValueMember = "Name"
    End Sub

    Private Sub FieldComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FieldComboBox.SelectedIndexChanged
        Dim item = DirectCast(FieldComboBox.SelectedItem, EntityAttribute)
        CustomSearchSlotFLP.Controls.Clear()

        Select Case item.SearchMode
            Case SearchMode.Text
                Dim txt_box As New TextBox With {
                    .Dock = DockStyle.Fill,
                    .Margin = New Padding(0),
                    .Size = New Size(163, 25),
                    .AutoCompleteMode = AutoCompleteMode.Suggest,
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                }
                CustomSearchSlotFLP.Controls.Add(txt_box)
                txt_box.AutoCompleteCustomSource.AddRange(item.Suggestions.ToArray)
            Case Else
        End Select
    End Sub

    'Public Function GetDbQueryString() As String
    '    ' TODO
    'End Function

    Public Function GetDbQueryString(customTableNameMapping As Dictionary(Of String, String)) As (command As String, params As Object)
        ' Check for the given custom name mapping keys (Display name) that is NOT in the EntityComboBox's Items List. 
        If customTableNameMapping.Keys.Any(Function(n) Not EntityComboBox.Items.Cast(Of String).Contains(n)) Then
            Throw New ArgumentException("The customTableNameMapping's keys is not in EntityComboBox's Items")
        End If

        Dim table As String = customTableNameMapping(EntityComboBox.SelectedItem)
        Dim attribute As String = FieldComboBox.SelectedValue

        Dim search As String = ""

        Select Case CustomSearchSlotFLP.Controls(0).GetType
            Case GetType(TextBox)
                search = DirectCast(CustomSearchSlotFLP.Controls(0), TextBox).Text
            Case GetType(DateTimePicker)
                search = DirectCast(CustomSearchSlotFLP.Controls(0), DateTimePicker).Value
        End Select

        If String.IsNullOrEmpty(search) Then
            Return ("", Nothing)
        Else
            Return ($"SELECT * FROM {table} WHERE {attribute} = @ss", New With {.ss = search})
        End If

    End Function

    Public Function IsActive() As Boolean
        Return Not (EntityComboBox.SelectedIndex = -1 OrElse FieldComboBox.SelectedIndex = -1) ' === ~(A v B) === ~A ^ ~B
    End Function
End Class
