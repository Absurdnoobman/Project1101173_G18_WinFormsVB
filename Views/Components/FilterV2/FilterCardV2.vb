Public Class FilterCardV2

	Sub New(attributes As List(Of EntityAttribute))
		' This call is required by the designer.
		InitializeComponent()

		AttributeComboBox.DataSource = attributes
		AttributeComboBox.DisplayMember = "Name"
		AttributeComboBox.ValueMember = "SearchMode"

	End Sub


	Private Sub FilterCardV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AddHandler AttributeComboBox.SelectedIndexChanged, AddressOf AttributeComboBox_SelectedIndexChanged
		AttributeComboBox_SelectedIndexChanged(Nothing, Nothing)
	End Sub

	Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
		Dispose()
	End Sub

	Private Sub AttributeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
		Select Case AttributeComboBox.SelectedValue
			Case SearchMode.Text
				Dim s As New FilterTextSearchMode
				SlotFLP.Controls.Add(s)
			Case SearchMode.Numeric
				Dim s As New FilterNumberSearchMode
				SlotFLP.Controls.Add(s)
			Case SearchMode.DateTime
				Dim s As New FilterDateSearchMode
				SlotFLP.Controls.Add(s)
			Case Else
				Exit Sub
		End Select
	End Sub

	Public Function GetQueryString(mapping As Dictionary(Of String, String), Optional whenNotValid As String = "")
		If AttributeComboBox.SelectedIndex = -1 Then Return whenNotValid

		Dim attribute_diplay = DirectCast(AttributeComboBox.SelectedItem, EntityAttribute).Name

		Dim attribute = mapping(attribute_diplay)

		Select Case AttributeComboBox.SelectedValue
			Case SearchMode.Text
				Return SlotFLP.Controls.Cast(Of FilterTextSearchMode).First.GetQueryString(attribute)
			Case SearchMode.Numeric
				Return SlotFLP.Controls.Cast(Of FilterNumberSearchMode).First.GetQueryString(attribute)
			Case SearchMode.DateTime
				Return SlotFLP.Controls.Cast(Of FilterDateSearchMode).First.GetQueryString(attribute)
			Case Else
				Return whenNotValid
		End Select

	End Function


End Class
