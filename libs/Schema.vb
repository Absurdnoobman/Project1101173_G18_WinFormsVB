Imports System.Data.SqlClient
Imports Dapper
Imports Microsoft.Extensions.Configuration

Public Class Schema
	Private ReadOnly _connectionString As String

	Public Sub New()

		Dim config = New ConfigurationBuilder() _
			.AddUserSecrets(Of Schema)() _
			.Build()

		Dim env = Environment.GetEnvironmentVariable("CONNECTION_STRING")
		If String.IsNullOrEmpty(env) Then
			Throw New InvalidOperationException("CONNECTION_STRING environment variable not set.")
		Else
			_connectionString = env
			Exit Sub
		End If


		If String.IsNullOrEmpty(config("ConnectionStrings:default")) Then
			Throw New InvalidOperationException("Connection string missing in user-secrets.")
		End If

	End Sub

	Public Function Query(Of TModel, TParam)(command As String, Optional param As TParam = Nothing) As List(Of TModel)
		Dim result As New List(Of TModel)
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = command

				db_conn.Open()

				result = db_conn.Query(Of TModel)(command, param).ToList()

				db_conn.Close()
			End Using
		Catch ex As Exception
			MessageBox.Show(
				text:=$"{ex.Message} {ex.HelpLink}",
				icon:=MessageBoxIcon.Error,
				caption:="Failed Internal SQL",
				buttons:=MessageBoxButtons.OK
				)
			Throw
		End Try
		Return result
	End Function

	''' <summary>
	''' Same as <c> SqlCommand.ExecuteNonQuery() </c>
	''' </summary>
	''' <param name="command"></param>
	''' <param name="param"></param>
	''' <returns>
	'''		return True if success
	''' </returns>
	Public Function NonSelectQuery(command As String, Optional param As Object = Nothing) As Boolean
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = command

				db_conn.Open()

				db_conn.Execute(command, param)

				db_conn.Close()
			End Using
			Return True
		Catch ex As Exception
			MessageBox.Show(
				text:=$"{ex.Message} \n {ex.HelpLink}",
				icon:=MessageBoxIcon.Error,
				caption:="Failed Internal SQL",
				buttons:=MessageBoxButtons.OK
			)
			Return False
			Throw
		End Try
	End Function

	Public Function QuerySelect(fromTable As String, Optional columns As String = "*") As List(Of Dictionary(Of String, Object))
		Dim result As New List(Of Dictionary(Of String, Object))

		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"SELECT {columns} FROM {fromTable}"

				db_conn.Open()

				result = db_conn.Query(Command)

				db_conn.Close()
			End Using
		Catch ex As Exception
			MessageBox.Show(
				text:=$"{ex.Message} \n {ex.HelpLink}",
				icon:=MessageBoxIcon.Error,
				caption:="Failed Internal SQL",
				buttons:=MessageBoxButtons.OK
				)
			Throw
		End Try
		Return result

	End Function

	Public Function QueryInsert(intoTable As String, values As List(Of Tuple)) As Boolean
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"INSERT INTO {intoTable} VALUES {values}"

				db_conn.Open()

				cmd.ExecuteNonQuery()

				db_conn.Close()
			End Using
		Catch ex As Exception
			MessageBox.Show(
				text:=$"{ex.Message} \n {ex.HelpLink}",
				icon:=MessageBoxIcon.Error,
				caption:="Failed Internal SQL",
				buttons:=MessageBoxButtons.OK
				)
			Throw
		End Try
		Return False
	End Function
End Class
