Public Class EntityAttribute
	Public Property Name As String

	Public Property SearchMode As SearchMode

	Public Property Suggestions As List(Of String)

	Sub New(name As String, searchMode As SearchMode, suggestions As List(Of String))
		Me.Name = name
		Me.SearchMode = searchMode
		Me.Suggestions = suggestions
	End Sub
End Class
