Imports System.Data.SqlClient

''' <summary>
''' FOR TESTING PURPOSE ONLY!
''' </summary>
Public Class TEST
	Public Shared Function TEST_FindStaff(id As String) As Staff
		Select Case id
			Case "S999"
				Dim pwd = Hash.Make("admin")
				Return New Staff With {
					.Id = "S999",
					.PasswordHash = pwd.Hash, 'Hard Coded password is no go
					.Salt = pwd.Salt,
					.firstname = "Admin",
					.surname = "sur",
					.position = "susadmin"
				}
			Case "S123"
				Dim pwd = Hash.Make("charge_nurse")
				Return New Staff With {
					.Id = "S123",
					.PasswordHash = pwd.Hash,
					.Salt = pwd.Salt,
					.firstname = "Zoe",
					.surname = "Alone",
					.position = "charge_nurse"
				}
			Case Else
				Return Nothing
		End Select
		Return Nothing
	End Function

	Public Function TEST_FindStaffFromDB(id As String)
		Dim db As New Schema()

		Return db.Query(Of Staff, Object)(
			"SELECT * FROM Staffs WHERE staff_number = @staff_num",
			New With {.staff_num = id}
		).First()

	End Function
End Class
