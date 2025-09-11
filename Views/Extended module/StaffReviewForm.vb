Public Class StaffReviewForm

	Private Sub StaffReviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TypeComboBox.SelectedIndex = 0

		CommSkillComboBox.SelectedIndex = 0
		AnalyticSkillComboBox.SelectedIndex = 0
		KnowledgeComboBox.SelectedIndex = 0
		PlanSkillComboBox.SelectedIndex = 0
		PhysicalSkillComboBox.SelectedIndex = 0
		PatientCareComboBox.SelectedIndex = 0
		PolicyComboBox.SelectedIndex = 0
		FinanceComboBox.SelectedIndex = 0
		LeadershipComboBox.SelectedIndex = 0
		InfoComboBox.SelectedIndex = 0
		ResearchComboBox.SelectedIndex = 0
		FreeComboBox.SelectedIndex = 0
		PhysicalEffortComboBox.SelectedIndex = 0
		MentalEffortComboBox.SelectedIndex = 0
		EmoEffortComboBox.SelectedIndex = 0
		WorkConComboBox.SelectedIndex = 0

		AddHandler CommSkillComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler AnalyticSkillComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler KnowledgeComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler PlanSkillComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler PhysicalSkillComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler PatientCareComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler PolicyComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler FinanceComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler LeadershipComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler InfoComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler ResearchComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler FreeComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler PhysicalEffortComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler MentalEffortComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler EmoEffortComboBox.SelectedIndexChanged, AddressOf HandleComboBox
		AddHandler WorkConComboBox.SelectedIndexChanged, AddressOf HandleComboBox

		HandleComboBox()

	End Sub

	Private Sub SelectConsultantButton_Click(sender As Object, e As EventArgs) Handles SelectConsultantButton.Click
		Dim f As New PickStaffDialog
		Dim result = f.ShowDialog
		If result = DialogResult.Abort OrElse result = DialogResult.Cancel Then Exit Sub

		Dim staff = f.result.FirstOrDefault
		If staff Is Nothing Then Exit Sub

		StaffNumberLabel.Text = staff.staff_number
		StaffNameLabel.Text = $"{staff.firstname} {staff.surname}"

		StaffNumberLabel.Show()
		StaffNameLabel.Show()

	End Sub

	Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click

		Dim sum_skills = SumSkillsScore()
		Dim sum_respons = SumResponsibilityScore()
		Dim free = NHSJobEvaluation.Evaluations("Freedom to act")(FreeComboBox.SelectedIndex)
		Dim knowledge = NHSJobEvaluation.Evaluations("Knowledge, training and experience")(KnowledgeComboBox.SelectedIndex)

		Dim sum_score = sum_respons + sum_skills + free + knowledge

		Dim reviewer = Auth.User

		Dim db As New Schema
		Try
			Dim id = db.QuerySingle(Of Integer, Object)(
				"INSERT INTO Reviews
				OUTPUT INSERTED.review_id
				VALUES (@sn, @d, @t, @s, @c, @r);
				", New With {
					.sn = StaffNumberLabel.Text,
					.d = ReviewDateDTP.Value,
					.t = TypeComboBox.SelectedItem,
					.s = sum_score,
					.c = CommentTextBox.Text,
					.r = reviewer.staff_number
				}
			)
			For Each kpv In NHSJobEvaluation.Evaluations
				db.Query(Of Object)(
					"INSERT INTO ReviewDetails VALUES (@id, @fac, @s)",
					New With {
						.id = id,
						.fac = kpv.Key,
						.s = kpv.Value(GetLevelIndex(kpv.Key))
					}
				)
			Next

			MessageBox.Show("Insert Successful.")
			Dispose()

		Catch ex As Exception
			MessageBox.Show($"Error: {ex.Message}" & vbNewLine & $"{ex.StackTrace}")
		End Try
	End Sub


	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Process.Start("https://www.nhsemployers.org/publications/nhs-job-evaluation-handbook")
	End Sub

	Private Sub HandleComboBox()
		Dim sum_skills = SumSkillsScore()
		Dim sum_respons = SumResponsibilityScore()
		Dim free = NHSJobEvaluation.Evaluations("Freedom to act")(FreeComboBox.SelectedIndex)
		Dim knowledge = NHSJobEvaluation.Evaluations("Knowledge, training and experience")(KnowledgeComboBox.SelectedIndex)

		ScoreLabel.Text = $"{sum_respons + sum_skills + free + knowledge}/1000"

	End Sub

	Private Function SumSkillsScore() As Integer
		Return _
			NHSJobEvaluation.Evaluations("Communication and relationship skills")(CommSkillComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Analytical skills")(AnalyticSkillComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Planning and organisation skills")(PlanSkillComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Physical skills")(PhysicalSkillComboBox.SelectedIndex)
	End Function

	Private Function SumResponsibilityScore() As Integer
		Return _
			NHSJobEvaluation.Evaluations("Responsibility – patient/client care")(PatientCareComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Responsibility – policy and service")(PolicyComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Responsibility – finance and physical")(FinanceComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Responsibility – staff/HR/leadership/training")(LeadershipComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Responsibility – information resources")(InfoComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Responsibility – research and development")(ResearchComboBox.SelectedIndex)
	End Function

	Private Function SumEnviromentalAndEffortScore() As Integer
		Return _
			NHSJobEvaluation.Evaluations("Physical effort")(PhysicalEffortComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Mental effort")(MentalEffortComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Emotional effort")(EmoEffortComboBox.SelectedIndex) +
			NHSJobEvaluation.Evaluations("Working conditions")(WorkConComboBox.SelectedIndex)
	End Function

	Private Function GetLevelIndex(factor As String) As Integer
		Select Case factor
			Case "Communication and relationship skills"
				Return CommSkillComboBox.SelectedIndex
			Case "Knowledge, training and experience"
				Return KnowledgeComboBox.SelectedIndex
			Case "Analytical skills"
				Return AnalyticSkillComboBox.SelectedIndex
			Case "Planning and organisation skills"
				Return PlanSkillComboBox.SelectedIndex
			Case "Physical skills"
				Return PhysicalSkillComboBox.SelectedIndex
			Case "Responsibility – patient/client care"
				Return PatientCareComboBox.SelectedIndex
			Case "Responsibility – policy and service"
				Return PolicyComboBox.SelectedIndex
			Case "Responsibility – finance and physical"
				Return FinanceComboBox.SelectedIndex
			Case "Responsibility – staff/HR/leadership/training"
				Return LeadershipComboBox.SelectedIndex
			Case "Responsibility – information resources"
				Return InfoComboBox.SelectedIndex
			Case "Responsibility – research and development"
				Return ResearchComboBox.SelectedIndex
			Case "Freedom to act"
				Return FreeComboBox.SelectedIndex
			Case "Physical effort"
				Return PhysicalEffortComboBox.SelectedIndex
			Case "Mental effort"
				Return MentalEffortComboBox.SelectedIndex
			Case "Emotional effort"
				Return EmoEffortComboBox.SelectedIndex
			Case "Working conditions"
				Return WorkConComboBox.SelectedIndex
			Case Else
				Return -1
		End Select
	End Function

	Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
		CommentTextBox.Clear()
	End Sub
End Class