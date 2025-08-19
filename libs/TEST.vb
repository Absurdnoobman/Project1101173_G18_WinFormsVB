''' <summary>
''' FOR TESTING PURPOSE ONLY!!!!
''' </summary>
Public Class TEST
	Public Shared Function TEST_FindStaff(id As String) As Staff
		Select Case id
			Case "S000"
				Dim pwd = Hash.Make("admin")
				Return New Staff With {
					.Id = "S000",
					.PasswordHash = pwd.Hash, 'Hard Coded password is no go
					.Salt = pwd.Salt,
					.firstname = "AdminTemp",
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

	Public Shared Function TEST_FindStaffFromDB(id As String) As Staff
		Dim db As New Schema()
		Try
			Dim user = db.Query(Of Staff, Object)(
				"SELECT * FROM Staffs WHERE staff_number = @staff_num",
				New With {.staff_num = id}
			).First()

			Dim password = db.QuerySelect("Passwords", "salt, hashed", $"staff_num = '{user.staff_number}'").First

			user.Salt = password("salt")
			user.PasswordHash = password("hashed")

			Return user
		Catch ex As Exception
			MessageBox.Show(
				icon:=MessageBoxIcon.Error,
				caption:="Failed!",
				text:="Internal Logic Error",
				buttons:=MessageBoxButtons.OK
			)
		End Try

		Return Nothing
	End Function
End Class
