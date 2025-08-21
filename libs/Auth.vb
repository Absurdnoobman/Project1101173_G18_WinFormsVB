Public Class Auth
	Public Shared LoggedInUser As Staff = Nothing

	''' <summary>
	''' Attempt to login with a given credential and return true.
	''' </summary>
	''' <param name="staffNumber"></param>
	''' <param name="password"></param>
	''' <returns> return false if can not login or incorrect credential. </returns>
	Public Shared Function Attempt(staffNumber As String, password As String) As Boolean

		'Get User in Database
		Dim db As New Schema()
		Try
			Dim user = db.Query(Of Staff, Object)(
				"SELECT * FROM Staffs WHERE staff_number = @staff_num",
				New With {.staff_num = staffNumber}
			).First()

			Dim pwd = db.SelectQuery("Passwords", "salt, hashed", $"staff_num = '{user.staff_number}'").First

			user.Salt = pwd("salt")
			user.PasswordHash = pwd("hashed")

			If Not user.AttemptLogin(password) Then
				Return False
			End If

			LoggedInUser = user
			Return True
		Catch ex As Exception
			MessageBox.Show(
				icon:=MessageBoxIcon.Error,
				caption:="Failed!",
				text:="Internal Logic Error" & vbNewLine,
				buttons:=MessageBoxButtons.OK
			)
			Return False
		End Try
	End Function

	Public Shared Sub Logout()
		LoggedInUser = Nothing
	End Sub

	''' <summary>
	''' Get the currently Logged in user with <see cref="Staff"/> instance.
	''' </summary>
	''' <returns></returns>
	Public Shared Function User() As Staff
		If LoggedInUser IsNot Nothing Then
			Return LoggedInUser
		Else
			Throw New Exception("User is not logged in.")
		End If
	End Function
End Class
