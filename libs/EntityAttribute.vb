Public Class EntityAttribute
	Public Property Name As String

	Public Property SearchMode As SearchMode

	Public Property Suggestions As List(Of String)

	Sub New(name As String, searchMode As SearchMode, Optional suggestions As List(Of String) = Nothing)
		Me.Name = name
		Me.SearchMode = searchMode

		If suggestions Is Nothing Then Me.Suggestions = New List(Of String)

		Me.Suggestions = suggestions
	End Sub
End Class
