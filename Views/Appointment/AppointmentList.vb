Public Class AppointmentList
	Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

	End Sub


	Private Sub MakeAppointmentButton_Click(sender As Object, e As EventArgs) Handles MakeAppointmentButton.Click
		Dim f As New NewAppointmentForm
		f.ShowDialog()
	End Sub

	Private Sub AppointmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		renderDataGridView()
		AppointmentDGV.Refresh()
	End Sub

	Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
		renderDataGridView()
		AppointmentDGV.Refresh()
	End Sub

	Private Sub renderDataGridView()
		Dim db As New Schema
		Try
			Dim dt_set As DataSet = db.GetDataSet("SELECT * FROM appointment_view")
			AppointmentDGV.DataSource = dt_set.Tables(0)
			AppointmentDGV.Refresh()
		Catch ex As Exception
			MessageBox.Show("Error: can not get the appointment list." & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
		End Try
	End Sub
End Class