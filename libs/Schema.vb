Imports Dapper
Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Configuration
Imports SqlConnection = Microsoft.Data.SqlClient.SqlConnection
Imports SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter

''' <summary>
''' All-in-one solution for database access in this project. Powered By <see cref="Dapper"/>
''' </summary>
Public Class Schema
	Private ReadOnly _connectionString As String

	Public Sub New()

		Dim config = New ConfigurationBuilder() _
			.AddUserSecrets(Of Schema)() _
			.Build()

		Dim env As String = Environment.GetEnvironmentVariable("CONNECTION_STRING")
		Dim l_env As String = Environment.GetEnvironmentVariable("LOCAL_CONNECTION_STRING")

		If String.IsNullOrEmpty(env) And String.IsNullOrEmpty(l_env) Then
			Throw New InvalidOperationException("CONNECTION_STRING environment variable not set.")
		End If

		If Not String.IsNullOrEmpty(l_env) Then
			_connectionString = l_env
			Exit Sub
		End If

		If Not String.IsNullOrEmpty(env) Then
			_connectionString = env
			Exit Sub
		End If

		If String.IsNullOrEmpty(config("ConnectionStrings:default")) Then
			Throw New InvalidOperationException("Connection string missing in user-secrets.")
		Else
			_connectionString = config("ConnectionStrings:default")
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
	'''  So much stuff going on.
	''' </summary>
	''' <typeparam name="TModel1"> Owner Class </typeparam>
	''' <typeparam name="TModel2"> Class </typeparam>
	''' <typeparam name="TReturnModel"> Model Class to return </typeparam>
	''' <typeparam name="TParam"></typeparam>
	''' <param name="command"></param>
	''' <param name="mapFunc"></param>
	''' <param name="fk"> foreign key of TModel2 that is a primary key of TModel1 (Default is "Id") </param>
	''' <param name="param"></param>
	''' <returns></returns>
	Public Function QueryMulti(Of TModel1, TModel2, TReturnModel, TParam)(
		command As String,
		mapFunc As Func(Of TModel1, TModel2, TReturnModel),
		Optional fk As String = "Id",
		Optional param As TParam = Nothing
	) As List(Of TReturnModel)
		Dim result As New List(Of TReturnModel)
		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = command

				db_conn.Open()

				result = db_conn.Query(
					sql:=cmd.CommandText,
					map:=mapFunc,
					param:=param,
					splitOn:=fk
					).ToList()

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
	'''		return <see langword="True"/> if success
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
			Return False
		End Try
	End Function

	Public Function SelectQuery(
		fromTable As String,
		Optional columns As String = "*",
		Optional whereClauseStr As String = "",
		Optional selectOption As String = ""
	) As List(Of Dictionary(Of String, Object))

		Dim result As IEnumerable(Of Object)

		If Not String.IsNullOrEmpty(whereClauseStr) Then
			whereClauseStr = $"WHERE {whereClauseStr}"
		End If

		Try
			Using db_conn As New SqlConnection(_connectionString)
				Dim cmd = db_conn.CreateCommand()
				cmd.CommandText = $"SELECT {selectOption}  {columns} FROM {fromTable} {whereClauseStr}"

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

	''' <summary>
	''' Insert Short-handed with all columns. <br />
	''' Can not insert some columns.
	''' </summary>
	''' <typeparam name="T">anonymous type or model class</typeparam>
	''' <param name="intoTable">Table name</param>
	''' <param name="values"> a list of anonymous type or model object that has values for insertion.</param>
	''' <returns>
	'''		return <see langword="True"/> if success.
	''' </returns>
	Public Function FullInsert(Of T)(
		intoTable As String,
		values As List(Of T)
	) As Boolean

		Dim props As List(Of String) = GetType(T).GetProperties().Select(Function(p) p.Name).ToList()
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

	Public Function Delete(Of T)(fromTable As String, record_identifier As String, id_value As T) As Boolean
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

	Public Function Update(Of T)(
		fromTable As String,
		record_identifier As String, id_value As T,
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

	Public Function GetDataSet(selectCommand As String, Optional params As Dictionary(Of String, Object) = Nothing) As DataSet
		Dim cmd As New SqlCommand With {
			.Connection = New SqlConnection(_connectionString),
			.CommandText = selectCommand
		}

		If params IsNot Nothing Then
			For Each param In params
				cmd.Parameters.AddWithValue(param.Key, param.Value)
			Next
		End If

		Dim adapter As New SqlDataAdapter(cmd)

		Dim source As New DataSet
		adapter.Fill(source)
		Return source
	End Function
End Class
