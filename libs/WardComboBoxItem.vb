Public Class WardComboBoxItem
	Public Property Display As String
	Public Property Ward As Ward

	Sub New(display_name As String, ward As Ward)
		Display = display_name
		Me.Ward = ward
	End Sub
End Class
