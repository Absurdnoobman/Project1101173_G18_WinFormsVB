Public Class StaffScoreCard
	Sub New(staffNumber As String, firstname As String, surname As String, score As Integer)
		' This call is required by the designer.
		InitializeComponent()

		StaffNumberLabel.Text = staffNumber
		StaffNameLabel.Text = $"{firstname} {surname}"
		ScoreLabel.Text = score

	End Sub
End Class
