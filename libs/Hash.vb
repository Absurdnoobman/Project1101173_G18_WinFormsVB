Imports System.Security.Cryptography

Public Class Hash

	''' <summary>
	''' Make a hashed and salted password 
	''' </summary>
	''' <param name="password"></param>
	''' <returns> a <see cref="Tuple(Of String)"/> comprises of the Salt and a hashed password redy for use</returns>
	Public Shared Function Make(password As String) As (Salt As String, Hash As String)

		' Gen the salt
		Dim saltBytes(15) As Byte
		Using rng As New RNGCryptoServiceProvider()
			rng.GetBytes(saltBytes)
		End Using

		' Combine
		Dim salt As String = Convert.ToBase64String(saltBytes)

		' Hash the salted password
		Using pbkdf2 As New Rfc2898DeriveBytes(password, saltBytes, My.Settings.iteration_count)
			' Gen the hash (output size can increase for stronger security)
			Dim hashBytes As Byte() = pbkdf2.GetBytes(64)
			Dim hash As String = Convert.ToBase64String(hashBytes)

			' Return the salt and hash as Base64 strings
			Return (salt, hash)
		End Using
	End Function

	Public Shared Function Check(plainPassword As String, salt As String, storedHash As String) As Boolean
		Dim saltBytes As Byte() = Convert.FromBase64String(salt)
		Using pbkdf2 As New Rfc2898DeriveBytes(plainPassword, saltBytes, My.Settings.iteration_count)
			Dim hashByte As Byte() = pbkdf2.GetBytes(64)
			Dim hash As String = Convert.ToBase64String(hashByte)

			Return hash = storedHash 'Check??!!

		End Using
	End Function
End Class
