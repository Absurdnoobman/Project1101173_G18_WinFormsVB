Imports Project1101173_G18_WinFormsVB.TEST

Public Class Auth
	Public Shared LoggedInUser As Staff = Nothing

	''' <summary>
	''' Attempt to login with a given credential and return true.
	''' </summary>
	''' <param name="staffNumber"></param>
	''' <param name="password"></param>
	''' <returns> return false if can not login or incorrect credential. </returns>
	Public Shared Function Attempt(staffNumber As String, password As String) As Boolean
		Dim user As Staff = TEST_FindStaff(staffNumber)

		If user IsNot Nothing AndAlso user.AttemptLogin(password) Then
			LoggedInUser = user
			Return True
		End If

		Return False
	End Function

	Public Shared Sub Logout()
		LoggedInUser = Nothing
	End Sub

	''' <summary>
	''' Get the Logged in Staff instance.
	''' </summary>
	''' <returns></returns>
	Public Shared Function User() As Staff
		If LoggedInUser IsNot Nothing Then
			Return LoggedInUser
		Else
			Throw New Exception("User is not log in.")
		End If
	End Function
End Class
