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

	Public Sub New(connectionString As String)
		_connectionString = connectionString
	End Sub

	''' <summary>
	'''		Query a database with the type casting capability.
	''' </summary>
	''' <typeparam name="TModel">Type constraint of Model to cast</typeparam>
	''' <typeparam name="TParam"> Can pass an Object</typeparam>
	''' <param name="command"></param>
	''' <param name="param"></param>
	''' <returns>
	''' 
	''' </returns>
	Public Function Query(Of TModel, TParam)(command As String, Optional param As TParam = Nothing) As List(Of TModel)
		Dim result As New List(Of TModel)
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = command

				db_conn.Open()

				result = db_conn.Query(Of TModel)(cmd.CommandText, param).ToList()

				db_conn.Close()
			End Using
		Catch ex As Exception
			If Debugger.IsAttached Then MessageBox.Show(ex.Message, "DEBUG")
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
			If Debugger.IsAttached Then MessageBox.Show(ex.Message, "DEBUG")
			Throw ex
		End Try
		Return False
	End Function

	Public Function QuerySelect(
		fromTable As String,
		Optional columns As String = "*",
		Optional whereClauseStr As String = ""
	) As List(Of Dictionary(Of String, Object))

		Dim result As IEnumerable(Of Object)

		If Not String.IsNullOrEmpty(whereClauseStr) Then
			whereClauseStr = $"WHERE {whereClauseStr}"
		End If

		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"SELECT {columns} FROM {fromTable} {whereClauseStr}"

				db_conn.Open()

				result = db_conn.Query(cmd.CommandText)

				db_conn.Close()
			End Using
		Catch ex As Exception
			If Debugger.IsAttached Then MessageBox.Show(ex.Message, "DEBUG")
			Throw ex
		End Try

		' create a new dic to copy the value. slow but mutable 
		Return result.Select(
			Function(row) New Dictionary(Of String, Object)(CType(row, IDictionary(Of String, Object)))
		).ToList()

	End Function

	Public Function Insert(Of TValues)(
		intoTable As String,
		values As List(Of TValues)
	) As Boolean

		Dim props As List(Of String) = GetType(TValues).GetProperties().Select(Function(p) p.Name).ToList()
		Dim colNames As String = String.Join(", ", props)
		Dim paramNames = String.Join(", ", props.Select(Function(p) $"@{p}"))

		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"INSERT INTO {intoTable} ({colNames}) VALUES ({paramNames})"

				db_conn.Open()

				Dim count = db_conn.Execute(cmd.CommandText, values)

				db_conn.Close()

				Return count = values.Count
			End Using

		Catch ex As Exception
			If Debugger.IsAttached Then MessageBox.Show(ex.Message, "DEBUG")
			Throw ex
		End Try
		Return False
	End Function

	Public Function Delete(Of TValue)(fromTable As String, record_identifier As String, id_value As TValue) As Boolean
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"DELETE FROM {fromTable} WHERE {record_identifier} = @v"

				db_conn.Open()

				db_conn.Execute(cmd.CommandText, New With {.v = id_value})

				db_conn.Close()
			End Using

			Return True

		Catch ex As Exception
			If Debugger.IsAttached Then MessageBox.Show(ex.Message, "DEBUG")
			Throw ex
		End Try
		Return False
	End Function

	Public Function Update(Of TValue)(
		fromTable As String,
		record_identifier As String, id_value As TValue,
		updates As Dictionary(Of String, Object)
	) As Boolean
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim setClauses = String.Join(", ", updates.Keys.Select(Function(k) $"{k} = @{k}"))

				Dim sql = $"UPDATE {fromTable} SET {setClauses} WHERE {record_identifier} = @id"

				' DynamicParameters Class Provided By Dapper
				Dim parameters = New DynamicParameters(updates)
				parameters.Add("@id", id_value)

				db_conn.Open()

				db_conn.Execute(sql, parameters)

				db_conn.Close()

				Return True
			End Using

		Catch ex As Exception
			If Debugger.IsAttached Then MessageBox.Show(ex.Message)
			Throw
			Return False
		End Try
	End Function
End Class
