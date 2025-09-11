Public Class FilterNumberSearchMode
	Implements IFilter

	Public Function GetQueryString(attribute As String) As String Implements IFilter.GetQueryString
		Dim mode As String = OperatorComboBox.SelectedItem

		If OperatorComboBox.SelectedIndex = -1 Then Return ""

		Select Case mode
			Case "=="
				Return $"{attribute} = {InputNumericUpDown.Value}"
			Case "!="
				Return $"{attribute} <> {InputNumericUpDown.Value}"
			Case "<"
				Return $"{attribute} < {InputNumericUpDown.Value}"
			Case "<="
				Return $"{attribute} <= {InputNumericUpDown.Value}"
			Case ">"
				Return $"{attribute} > {InputNumericUpDown.Value}"
			Case ">="
				Return $"{attribute} >= {InputNumericUpDown.Value}"
		End Select

		Return ""
	End Function
End Class
