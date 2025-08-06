Imports System.Security.Cryptography
Imports System.Text

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
        Dim saltedPassword As String = salt & password

        ' Hash the salted password
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword))
            Dim hash = Convert.ToBase64String(hashBytes)

            Return (salt, hash)
        End Using
    End Function

    Public Shared Function Check(plainPassword As String, salt As String, storedHash As String) As Boolean
        Dim saltedPassword = salt & plainPassword
        Using sha256 As SHA256 = SHA256.Create()
            Dim computedHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword))
            Dim computed = Convert.ToBase64String(computedHash)

            Return computed = storedHash 'Important check

        End Using
    End Function
End Class
