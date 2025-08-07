Public Class Authenticatable
    Public Property id As String
    Public Property PasswordHash As String

    Public Property Salt As String

    Public Function AttemptLogin(password As String) As Boolean
        Return Hash.Check(password, Salt, PasswordHash)
    End Function

End Class
