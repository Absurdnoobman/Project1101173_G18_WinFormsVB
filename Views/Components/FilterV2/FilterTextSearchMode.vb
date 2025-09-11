Public Class FilterTextSearchMode
	Implements IFilter

	Public Function GetQueryString(attribute As String) As String Implements IFilter.GetQueryString
		Dim mode As String = OperatorComboBox.SelectedItem

		If OperatorComboBox.SelectedIndex = -1 Then Return ""

		Select Case mode
			Case "Contains"
				Return $"{attribute} LIKE '%{InputTextBox.Text}%'"
			Case "Not Contain"
				Return $"NOT {attribute} LIKE '%{InputTextBox.Text}%'"
			Case "Start With"
				Return $"{attribute} LIKE '{InputTextBox.Text}%'"
			Case "Not Start With"
				Return $"NOT {attribute} LIKE '{InputTextBox.Text}%'"
			Case "End With"
				Return $"{attribute} LIKE '%{InputTextBox.Text}'"
			Case "Not End With"
				Return $"NOT {attribute} LIKE '%{InputTextBox.Text}'"
		End Select

		Return ""
	End Function
End Class
