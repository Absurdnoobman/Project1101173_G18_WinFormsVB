Imports System.Windows.Forms.DataVisualization.Charting

Public Class ReviewSummaryForm
	Private Sub ReviewSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TypeComboBox.SelectedIndex = 0

		AddHandler TypeComboBox.SelectedIndexChanged, AddressOf HandleTypeComboBox

		SearchByComboBox.SelectedIndex = 0

		AddHandler SearchByComboBox.SelectedIndexChanged, AddressOf HandleSearchByComboBox

		Dim year = Convert.ToInt32(YearPicker.Value.ToString("yyyy"))
		Dim type As String = TypeComboBox.SelectedItem

		RenderTop3ByYearAndType(year, type)
		RenderStatsByYearAndType(year, type)
		RenderDGVByYearAndType(year, type)
		RenderChartByYearAndType(year, type)

	End Sub

	Private Sub RenderTop3ByYearAndType(year As Integer, type As String)
		Top3FLP.Controls.Clear()

		Dim db As New Schema
		Try
			Dim result = db.Query(Of Object)(
				"
				SELECT TOP 3 r.staff_number, s.firstname, s.surname, r.overall_score FROM Reviews r JOIN Staffs s ON r.staff_number = s.staff_number 
				WHERE YEAR(r.review_date) = @y AND r.type = @t
				ORDER BY overall_score DESC
				", New With {.y = year, .t = type}
			)
			If result.Count = 0 Then Exit Sub

			For Each record In result
				Dim card As New StaffScoreCard(
					staffNumber:=record("staff_number"),
					firstname:=record("firstname"),
					surname:=record("surname"),
					score:=record("overall_score")
				)
				Top3FLP.Controls.Add(card)
			Next
		Catch ex As Exception
			MessageBox.Show("Error: can not get top 3." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try
	End Sub

	Private Sub RenderStatsByYearAndType(year As Integer, type As String)
		Dim db As New Schema
		Try
			Dim count = db.Query(Of Object)(
				"
				SELECT COUNT(*) AS TotalReviews
				FROM Reviews
				WHERE YEAR(review_date) = @y AND type = @t
				", New With {.y = year, .t = type}
			)

			StaffReviewedLabel.Text = count.First.Item("TotalReviews")

			Dim avg = db.Query(Of Object)(
				"
				SELECT AVG(overall_score) AS AvgScore
				FROM Reviews
				WHERE YEAR(review_date) = @y AND type = @t;
				", New With {.y = year, .t = type}
			)

			If avg.Count = 0 Then
				AverageLabel.Text = "Not Record Found"
			Else
				AverageLabel.Text = avg.First.Item("AvgScore")
			End If

			Dim highest_brand = db.Query(Of Object)(
				"
				SELECT TOP 1
					CASE
						WHEN overall_score BETWEEN 0 AND 160 THEN 'Band 1'
						WHEN overall_score BETWEEN 161 AND 215 THEN 'Band 2'
						WHEN overall_score BETWEEN 216 AND 270 THEN 'Band 3'
						WHEN overall_score BETWEEN 271 AND 325 THEN 'Band 4'
						WHEN overall_score BETWEEN 326 AND 395 THEN 'Band 5'
						WHEN overall_score BETWEEN 396 AND 465 THEN 'Band 6'
						WHEN overall_score BETWEEN 466 AND 539 THEN 'Band 7'
						WHEN overall_score BETWEEN 540 AND 584 THEN 'Band 8a'
						WHEN overall_score BETWEEN 585 AND 629 THEN 'Band 8b'
						WHEN overall_score BETWEEN 630 AND 674 THEN 'Band 8c'
						WHEN overall_score BETWEEN 675 AND 720 THEN 'Band 8d'
						WHEN overall_score BETWEEN 721 AND 765 THEN 'Band 9'
						ELSE 'Out of Range'
					END AS HighestBand
				FROM Reviews
				WHERE YEAR(review_date) = @y AND type = @t
				ORDER BY overall_score DESC;
				", New With {.y = year, .t = type}
			)

			If highest_brand.Count = 0 Then
				HighestBrandLabel.Text = ""
			Else
				HighestBrandLabel.Text = highest_brand.First.Item("HighestBand")
			End If



			Dim above_avg = db.Query(Of Object)(
				"
				SELECT COUNT(*) AS StaffAboveAverage
				FROM Reviews r
				WHERE YEAR(r.review_date) = @y AND type = @t
				  AND r.overall_score > (
					  SELECT AVG(overall_score)
					  FROM Reviews
					  WHERE YEAR(review_date) = @y AND type = @t
				  );
				", New With {.y = year, .t = type}
			)

			If above_avg.Count = 0 Then
				StaffAboveAvgLabel.Text = "No Record Found"
			Else
				StaffAboveAvgLabel.Text = above_avg.First.Item("StaffAboveAverage")
			End If


		Catch ex As Exception
			MessageBox.Show("Error: can not get stats" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try
	End Sub

	Private Sub RenderDGVByYearAndType(year As Integer, type As String)
		Dim db As New Schema
		Try
			Dim result = db.GetDataSet(
				"
				SELECT 
				r.review_id As [Id],
				r.staff_number AS [Staff Number],
				s.firstname + ' ' + s.surname AS [Staff Name],
				r.overall_score AS [Score],
				r.review_date AS [review_date],
				r.type AS [type],
				r.comment As [comment]
				FROM Reviews r JOIN Staffs s ON r.staff_number = s.staff_number
				WHERE YEAR(r.review_date) = @y AND r.type = @t
				",
				New Dictionary(Of String, Object) From {
					{"@y", year}, {"@t", type}
				}
			)

			ReviewsDGV.DataSource = result.Tables(0)

			If ReviewsDGV.Columns.Contains("Id") Then
				ReviewsDGV.Columns("Id").Visible = False
			End If
			If ReviewsDGV.Columns.Contains("review_date") Then
				ReviewsDGV.Columns("review_date").Visible = False
			End If
			If ReviewsDGV.Columns.Contains("type") Then
				ReviewsDGV.Columns("type").Visible = False
			End If
			If ReviewsDGV.Columns.Contains("comment") Then
				ReviewsDGV.Columns("comment").Visible = False
			End If

			ReviewsDGV.Refresh()
		Catch ex As Exception
			MessageBox.Show("Error: can not get stats" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try
	End Sub

	Private Sub RenderChartByYearAndType(year As Integer, type As String)
		Dim result As DataSet

		Dim db As New Schema
		Try
			result = db.GetDataSet(
				"SELECT * FROM staffs_reviews WHERE [Year] = @y AND [type] = @t",
				New Dictionary(Of String, Object) From {
					{"@y", year}, {"@t", type}
				}
			)
		Catch ex As Exception
			MessageBox.Show("Error: can not get stats" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try

		If result Is Nothing OrElse result.Tables.Count = 0 OrElse result.Tables(0).Rows.Count = 0 Then Exit Sub

		Dim bands As (Name As String, Min As Integer, Max As Integer)() = {
			("Band 1", 0, 160),
			("Band 2", 161, 215),
			("Band 3", 216, 270),
			("Band 4", 271, 325),
			("Band 5", 326, 395),
			("Band 6", 396, 465),
			("Band 7", 466, 539),
			("Band 8a", 540, 584),
			("Band 8b", 585, 629),
			("Band 8c", 630, 674),
			("Band 8d", 675, 720),
			("Band 9", 721, 765)
		}

		' Find staff count for each brand
		Dim bandCounts(bands.Length - 1) As Integer
		For Each row As DataRow In result.Tables(0).Rows
			Dim score = Convert.ToInt32(row("Score"))
			For i = 0 To bands.Length - 1
				If score >= bands(i).Min AndAlso score <= bands(i).Max Then
					bandCounts(i) += 1
					Exit For
				End If
			Next
		Next

		ByBrandChart.Series.Clear()
		ByBrandChart.ChartAreas.Clear()

		Dim chartArea As New ChartArea("MainArea")
		ByBrandChart.ChartAreas.Add(chartArea)

		Dim series As New Series("Review Bands")
		series.ChartType = SeriesChartType.Bar
		series.IsValueShownAsLabel = True
		ByBrandChart.Series.Add(series)

		For i = 0 To bands.Length - 1
			series.Points.AddXY(bands(i).Name, bandCounts(i))
		Next
	End Sub

	Private Sub HandleTypeComboBox()
		Dim year = Convert.ToInt32(YearPicker.Value.ToString("yyyy"))
		Dim type As String = TypeComboBox.SelectedItem

		RenderTop3ByYearAndType(year, type)
		RenderStatsByYearAndType(year, type)
		RenderDGVByYearAndType(year, type)
		RenderChartByYearAndType(year, type)
	End Sub

	Private Sub HandleSearchByComboBox()
		renderDGV()
	End Sub

	Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
		renderDGV()
	End Sub

	Private Sub ReviewsDGV_SelectionChanged(sender As Object, e As EventArgs) Handles ReviewsDGV.SelectionChanged
		EditRowButton.Enabled = True
		DeleteRowButton.Enabled = True
	End Sub

	Private Sub DeleteRowButton_Click(sender As Object, e As EventArgs) Handles DeleteRowButton.Click
		If ReviewsDGV.SelectedRows.Count = 0 Then Exit Sub

		Dim selectedRow As DataGridViewRow = ReviewsDGV.SelectedRows(0)

		Dim db As New Schema
		If Not db.Delete(Of Integer)("Reviews", "review_id", selectedRow.Cells("Id").Value) Then
			MessageBox.Show($"Error: can not delete the record id = {selectedRow.Cells("Id").Value}")
			Exit Sub
		End If

		Dim year = Convert.ToInt32(YearPicker.Value.ToString("yyyy"))
		Dim type As String = TypeComboBox.SelectedItem

		RenderTop3ByYearAndType(year, type)
		RenderStatsByYearAndType(year, type)
		RenderDGVByYearAndType(year, type)
		RenderChartByYearAndType(year, type)

	End Sub

	Private Sub renderDGV()
		Dim year = YearPicker.Value.Year
		Dim type As String = TypeComboBox.SelectedItem

		If String.IsNullOrEmpty(SearchTextBox.Text) OrElse String.IsNullOrWhiteSpace(SearchTextBox.Text) Then
			RenderDGVByYearAndType(year, type)
			Exit Sub
		End If


		Dim search As String = ""

		Select Case CStr(SearchByComboBox.SelectedItem)
			Case "Staff Number"
				search = "AND r.staff_number LIKE @s"
			Case "Staff Name"
				search = "AND (s.firstname LIKE @s OR s.surname LIKE @s)"
			Case "Firstname"
				search = "AND s.firstname LIKE @s"
			Case "Lastname"
				search = "AND s.surname LIKE @s"
		End Select

		Dim db As New Schema
		Try
			Dim result = db.GetDataSet(
				$"
				SELECT 
				r.review_id As [Id],
				r.staff_number AS [Staff Number],
				s.firstname + ' ' + s.surname AS [Staff Name],
				r.overall_score AS [Score],
				r.review_date AS [review_date],
				r.type AS [type],
				r.comment AS [comment]
				FROM Reviews r JOIN Staffs s ON r.staff_number = s.staff_number
				WHERE YEAR(r.review_date) = @y AND r.type = @t {search}
				",
				New Dictionary(Of String, Object) From {
					{"@y", year}, {"@t", type}, {"@s", $"%{SearchTextBox.Text}%"}
				}
			)

			ReviewsDGV.DataSource = result.Tables(0)

			If ReviewsDGV.Columns.Contains("Id") Then
				ReviewsDGV.Columns("Id").Visible = False
			End If
			If ReviewsDGV.Columns.Contains("review_date") Then
				ReviewsDGV.Columns("review_date").Visible = False
			End If
			If ReviewsDGV.Columns.Contains("type") Then
				ReviewsDGV.Columns("type").Visible = False
			End If
			If ReviewsDGV.Columns.Contains("comment") Then
				ReviewsDGV.Columns("comment").Visible = False
			End If

			ReviewsDGV.Refresh()
		Catch ex As Exception
			MessageBox.Show("Error: can not get stats" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try
	End Sub

	Private Sub EditRowButton_Click(sender As Object, e As EventArgs) Handles EditRowButton.Click
		If ReviewsDGV.SelectedRows.Count = 0 Then Exit Sub

		Dim selectedRow As DataGridViewRow = ReviewsDGV.SelectedRows(0)

		Dim staff_num As String = selectedRow.Cells("Staff Number").Value
		Dim staff_name As String = selectedRow.Cells("Staff Name").Value

		Dim review As New Review With {
			.id = Convert.ToInt32(selectedRow.Cells("Id").Value),
			.type = CStr(selectedRow.Cells("type").Value),
			.review_date = selectedRow.Cells("review_date").Value,
			.comment = CStr(selectedRow.Cells("comment").Value)
		}

		Dim f As New StaffReviewForm(staff_num, staff_name, review)
		Dim result = f.ShowDialog()
		If result = DialogResult.Abort OrElse result = DialogResult.Cancel Then Exit Sub

		Dim year = Convert.ToInt32(YearPicker.Value.ToString("yyyy"))
		Dim type As String = TypeComboBox.SelectedItem

		RenderTop3ByYearAndType(year, type)
		RenderStatsByYearAndType(year, type)
		RenderDGVByYearAndType(year, type)
		RenderChartByYearAndType(year, type)

	End Sub

	Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
		Dim f As New StaffReviewForm
		f.ShowDialog()

		Dim year = Convert.ToInt32(YearPicker.Value.ToString("yyyy"))
		Dim type As String = TypeComboBox.SelectedItem

		RenderTop3ByYearAndType(year, type)
		RenderStatsByYearAndType(year, type)
		RenderDGVByYearAndType(year, type)
		RenderChartByYearAndType(year, type)
	End Sub
End Class