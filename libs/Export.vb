Imports Newtonsoft.Json
Imports System.IO

Public Class Export

    Public Shared Sub ToCSV(dgv As DataGridView, filePath As String)
        Using sw As New IO.StreamWriter(filePath)
            ' Write headers
            Dim headers = dgv.Columns.Cast(Of DataGridViewColumn)().Select(Function(c) c.HeaderText)
            sw.WriteLine(String.Join(",", headers))

            ' Write rows
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    Dim cells = row.Cells.Cast(Of DataGridViewCell)().Select(Function(c) c.Value?.ToString())
                    sw.WriteLine(String.Join(",", cells))
                End If
            Next
        End Using
    End Sub


    Public Shared Sub ToJSON(dgv As DataGridView, filePath As String)
        Dim rows As New List(Of Dictionary(Of String, Object))()

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim dict As New Dictionary(Of String, Object)
                For Each cell As DataGridViewCell In row.Cells
                    dict(dgv.Columns(cell.ColumnIndex).HeaderText) = cell.Value
                Next
                rows.Add(dict)
            End If
        Next

        Dim json As String = JsonConvert.SerializeObject(rows, Formatting.Indented)
        File.WriteAllText(filePath, json)
    End Sub


End Class
