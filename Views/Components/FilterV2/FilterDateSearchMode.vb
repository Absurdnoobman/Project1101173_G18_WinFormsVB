Public Class FilterDateSearchMode
	Implements IFilter

	Public Function GetQueryString(attribute As String) As String Implements IFilter.GetQueryString
		Dim mode As String = OperatorComboBox.SelectedItem

		If OperatorComboBox.SelectedIndex = -1 Then Return ""

		Select Case mode
			Case "On"
				Return $"{attribute} = '{InputDateTimePicker.Value:dd-MMM-yyyy}'"
			Case "Before"
				Return $"{attribute} < '{InputDateTimePicker.Value:dd-MMM-yyyy}'"
			Case "After"
				Return $"{attribute} > '{InputDateTimePicker.Value:dd-MMM-yyyy}'"
		End Select

		Return ""
	End Function
End Class
