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

	''' <summary>
	'''		Query Database with the type casting capability.
	''' </summary>
	''' <typeparam name="TModel">Type constraint of Model to cast</typeparam>
	''' <typeparam name="TParam"> Can pass an Object</typeparam>
	''' <param name="command"></param>
	''' <param name="param"></param>
	''' <returns></returns>
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
			Throw ex
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
	Public Function NonSelectQuery(
		command As String,
		Optional param As Object = Nothing
	) As Boolean
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
			MessageBox.Show(ex.Message)
		End Try
		Return False
	End Function

	Public Function QuerySelect(
		fromTable As String,
		Optional columns As String = "*",
		Optional whereClauseStr As String = ""
	) As List(Of Dictionary(Of String, Object))
		Dim result As New List(Of Dictionary(Of String, Object))

		If Not String.IsNullOrEmpty(whereClauseStr) Then
			whereClauseStr = $"WHERE {whereClauseStr}"
		End If

		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"SELECT {columns} FROM {fromTable} {whereClauseStr}"

				db_conn.Open()

				result = db_conn.Query(Command)

				db_conn.Close()
			End Using
		Catch ex As Exception
			Throw ex
		End Try
		Return result

	End Function

	Public Function QueryInsert(
		intoTable As String,
		values As Object
	) As Boolean

		Dim props As List(Of String) = values.GetType().GetProperties().Select(Function(p) p.Name).ToList()
		Dim colNames As String = String.Join(", ", props)
		Dim paramNames = String.Join(", ", props.Select(Function(p) $"@{p}"))

		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"INSERT INTO {intoTable} ({colNames}) VALUES {paramNames}"

				db_conn.Open()

				db_conn.Execute(cmd.CommandText, values)

				db_conn.Close()
			End Using

			Return True

		Catch ex As Exception
			Throw ex
		End Try
		Return False
	End Function

	Public Function Delete(fromTable As String, record_identifier As String, id_value As Object) As Boolean
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"DELETE FROM {fromTable} WHERE {record_identifier} = {id_value}"

				db_conn.Open()

				db_conn.Execute(cmd.CommandText)

				db_conn.Close()
			End Using

			Return True

		Catch ex As Exception
			Throw ex
		End Try
		Return False
	End Function
End Class
