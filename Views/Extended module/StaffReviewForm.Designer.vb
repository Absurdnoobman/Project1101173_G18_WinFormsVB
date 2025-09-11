<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffReviewForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.StaffFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.StaffNumberLabel = New System.Windows.Forms.Label()
		Me.StaffNameLabel = New System.Windows.Forms.Label()
		Me.SelectConsultantButton = New System.Windows.Forms.Button()
		Me.ReviewDateDTP = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.CreateButton = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TypeComboBox = New System.Windows.Forms.ComboBox()
		Me.ScoreLabel = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CommSkillComboBox = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.KnowledgeComboBox = New System.Windows.Forms.ComboBox()
		Me.AnalyticSkillComboBox = New System.Windows.Forms.ComboBox()
		Me.PlanSkillComboBox = New System.Windows.Forms.ComboBox()
		Me.PhysicalSkillComboBox = New System.Windows.Forms.ComboBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.FinanceComboBox = New System.Windows.Forms.ComboBox()
		Me.PolicyComboBox = New System.Windows.Forms.ComboBox()
		Me.PatientCareComboBox = New System.Windows.Forms.ComboBox()
		Me.ResearchComboBox = New System.Windows.Forms.ComboBox()
		Me.LeadershipComboBox = New System.Windows.Forms.ComboBox()
		Me.InfoComboBox = New System.Windows.Forms.ComboBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.FreeComboBox = New System.Windows.Forms.ComboBox()
		Me.EmoEffortComboBox = New System.Windows.Forms.ComboBox()
		Me.MentalEffortComboBox = New System.Windows.Forms.ComboBox()
		Me.PhysicalEffortComboBox = New System.Windows.Forms.ComboBox()
		Me.WorkConComboBox = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.CommentTextBox = New System.Windows.Forms.TextBox()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.StaffFLP.SuspendLayout()
		Me.SuspendLayout()
		'
		'StaffFLP
		'
		Me.StaffFLP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.StaffFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.StaffFLP.Controls.Add(Me.StaffNumberLabel)
		Me.StaffFLP.Controls.Add(Me.StaffNameLabel)
		Me.StaffFLP.Location = New System.Drawing.Point(12, 12)
		Me.StaffFLP.Name = "StaffFLP"
		Me.StaffFLP.Padding = New System.Windows.Forms.Padding(12, 16, 0, 0)
		Me.StaffFLP.Size = New System.Drawing.Size(683, 59)
		Me.StaffFLP.TabIndex = 0
		'
		'StaffNumberLabel
		'
		Me.StaffNumberLabel.AutoSize = True
		Me.StaffNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffNumberLabel.Location = New System.Drawing.Point(15, 16)
		Me.StaffNumberLabel.Name = "StaffNumberLabel"
		Me.StaffNumberLabel.Size = New System.Drawing.Size(121, 23)
		Me.StaffNumberLabel.TabIndex = 2
		Me.StaffNumberLabel.Text = "Staff Number"
		Me.StaffNumberLabel.Visible = False
		'
		'StaffNameLabel
		'
		Me.StaffNameLabel.AutoSize = True
		Me.StaffNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffNameLabel.Location = New System.Drawing.Point(142, 16)
		Me.StaffNameLabel.Name = "StaffNameLabel"
		Me.StaffNameLabel.Size = New System.Drawing.Size(88, 23)
		Me.StaffNameLabel.TabIndex = 3
		Me.StaffNameLabel.Text = "Full name"
		Me.StaffNameLabel.Visible = False
		'
		'SelectConsultantButton
		'
		Me.SelectConsultantButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SelectConsultantButton.Location = New System.Drawing.Point(701, 12)
		Me.SelectConsultantButton.Name = "SelectConsultantButton"
		Me.SelectConsultantButton.Size = New System.Drawing.Size(113, 59)
		Me.SelectConsultantButton.TabIndex = 3
		Me.SelectConsultantButton.Text = "Select a Staff"
		Me.SelectConsultantButton.UseVisualStyleBackColor = True
		'
		'ReviewDateDTP
		'
		Me.ReviewDateDTP.Location = New System.Drawing.Point(394, 92)
		Me.ReviewDateDTP.Name = "ReviewDateDTP"
		Me.ReviewDateDTP.Size = New System.Drawing.Size(280, 25)
		Me.ReviewDateDTP.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(305, 95)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(83, 17)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Review Date "
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(433, 517)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(125, 23)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Overall Rating"
		'
		'CreateButton
		'
		Me.CreateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CreateButton.Location = New System.Drawing.Point(701, 511)
		Me.CreateButton.Name = "CreateButton"
		Me.CreateButton.Size = New System.Drawing.Size(113, 37)
		Me.CreateButton.TabIndex = 13
		Me.CreateButton.Text = "Create"
		Me.CreateButton.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(29, 95)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 17)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Type"
		'
		'TypeComboBox
		'
		Me.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.TypeComboBox.FormattingEnabled = True
		Me.TypeComboBox.Items.AddRange(New Object() {"Annual", "Mid-Year", "Probation"})
		Me.TypeComboBox.Location = New System.Drawing.Point(86, 92)
		Me.TypeComboBox.Name = "TypeComboBox"
		Me.TypeComboBox.Size = New System.Drawing.Size(121, 25)
		Me.TypeComboBox.TabIndex = 18
		'
		'ScoreLabel
		'
		Me.ScoreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ScoreLabel.AutoSize = True
		Me.ScoreLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ScoreLabel.Location = New System.Drawing.Point(578, 519)
		Me.ScoreLabel.Name = "ScoreLabel"
		Me.ScoreLabel.Size = New System.Drawing.Size(53, 20)
		Me.ScoreLabel.TabIndex = 19
		Me.ScoreLabel.Text = "0/1000"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(29, 156)
		Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 12)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(227, 17)
		Me.Label4.TabIndex = 20
		Me.Label4.Text = "Communication and relationship skills"
		'
		'CommSkillComboBox
		'
		Me.CommSkillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CommSkillComboBox.FormattingEnabled = True
		Me.CommSkillComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6"})
		Me.CommSkillComboBox.Location = New System.Drawing.Point(262, 153)
		Me.CommSkillComboBox.Name = "CommSkillComboBox"
		Me.CommSkillComboBox.Size = New System.Drawing.Size(121, 25)
		Me.CommSkillComboBox.TabIndex = 21
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(29, 187)
		Me.Label5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 12)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(217, 17)
		Me.Label5.TabIndex = 22
		Me.Label5.Text = "Knowledge, training and experience"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(29, 218)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(93, 17)
		Me.Label6.TabIndex = 23
		Me.Label6.Text = "Analytical skills"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(29, 249)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(191, 17)
		Me.Label7.TabIndex = 24
		Me.Label7.Text = "Planning and organisation skills"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(29, 280)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(84, 17)
		Me.Label8.TabIndex = 25
		Me.Label8.Text = "Physical skills"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(29, 311)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(207, 17)
		Me.Label9.TabIndex = 26
		Me.Label9.Text = "Responsibility – patient/client care"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(29, 342)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(211, 17)
		Me.Label10.TabIndex = 27
		Me.Label10.Text = "Responsibility – policy and service "
		'
		'KnowledgeComboBox
		'
		Me.KnowledgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.KnowledgeComboBox.FormattingEnabled = True
		Me.KnowledgeComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Level 7", "Level 8"})
		Me.KnowledgeComboBox.Location = New System.Drawing.Point(262, 184)
		Me.KnowledgeComboBox.Name = "KnowledgeComboBox"
		Me.KnowledgeComboBox.Size = New System.Drawing.Size(121, 25)
		Me.KnowledgeComboBox.TabIndex = 28
		'
		'AnalyticSkillComboBox
		'
		Me.AnalyticSkillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.AnalyticSkillComboBox.FormattingEnabled = True
		Me.AnalyticSkillComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5"})
		Me.AnalyticSkillComboBox.Location = New System.Drawing.Point(262, 215)
		Me.AnalyticSkillComboBox.Name = "AnalyticSkillComboBox"
		Me.AnalyticSkillComboBox.Size = New System.Drawing.Size(121, 25)
		Me.AnalyticSkillComboBox.TabIndex = 29
		'
		'PlanSkillComboBox
		'
		Me.PlanSkillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PlanSkillComboBox.FormattingEnabled = True
		Me.PlanSkillComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5"})
		Me.PlanSkillComboBox.Location = New System.Drawing.Point(262, 246)
		Me.PlanSkillComboBox.Name = "PlanSkillComboBox"
		Me.PlanSkillComboBox.Size = New System.Drawing.Size(121, 25)
		Me.PlanSkillComboBox.TabIndex = 30
		'
		'PhysicalSkillComboBox
		'
		Me.PhysicalSkillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PhysicalSkillComboBox.FormattingEnabled = True
		Me.PhysicalSkillComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5"})
		Me.PhysicalSkillComboBox.Location = New System.Drawing.Point(262, 277)
		Me.PhysicalSkillComboBox.Name = "PhysicalSkillComboBox"
		Me.PhysicalSkillComboBox.Size = New System.Drawing.Size(121, 25)
		Me.PhysicalSkillComboBox.TabIndex = 31
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(410, 156)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(265, 17)
		Me.Label11.TabIndex = 32
		Me.Label11.Text = "Responsibility – staff/HR/leadership/training"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(410, 280)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(89, 17)
		Me.Label12.TabIndex = 33
		Me.Label12.Text = "Physical effort"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(29, 373)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(224, 17)
		Me.Label13.TabIndex = 34
		Me.Label13.Text = "Responsibility – finance and physical "
		'
		'FinanceComboBox
		'
		Me.FinanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.FinanceComboBox.FormattingEnabled = True
		Me.FinanceComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6"})
		Me.FinanceComboBox.Location = New System.Drawing.Point(262, 370)
		Me.FinanceComboBox.Name = "FinanceComboBox"
		Me.FinanceComboBox.Size = New System.Drawing.Size(121, 25)
		Me.FinanceComboBox.TabIndex = 35
		'
		'PolicyComboBox
		'
		Me.PolicyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PolicyComboBox.FormattingEnabled = True
		Me.PolicyComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6"})
		Me.PolicyComboBox.Location = New System.Drawing.Point(262, 339)
		Me.PolicyComboBox.Name = "PolicyComboBox"
		Me.PolicyComboBox.Size = New System.Drawing.Size(121, 25)
		Me.PolicyComboBox.TabIndex = 36
		'
		'PatientCareComboBox
		'
		Me.PatientCareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PatientCareComboBox.FormattingEnabled = True
		Me.PatientCareComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Level 7", "Level 8"})
		Me.PatientCareComboBox.Location = New System.Drawing.Point(262, 308)
		Me.PatientCareComboBox.Name = "PatientCareComboBox"
		Me.PatientCareComboBox.Size = New System.Drawing.Size(121, 25)
		Me.PatientCareComboBox.TabIndex = 37
		'
		'ResearchComboBox
		'
		Me.ResearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ResearchComboBox.FormattingEnabled = True
		Me.ResearchComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6"})
		Me.ResearchComboBox.Location = New System.Drawing.Point(681, 215)
		Me.ResearchComboBox.Name = "ResearchComboBox"
		Me.ResearchComboBox.Size = New System.Drawing.Size(121, 25)
		Me.ResearchComboBox.TabIndex = 38
		'
		'LeadershipComboBox
		'
		Me.LeadershipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.LeadershipComboBox.FormattingEnabled = True
		Me.LeadershipComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6"})
		Me.LeadershipComboBox.Location = New System.Drawing.Point(681, 153)
		Me.LeadershipComboBox.Name = "LeadershipComboBox"
		Me.LeadershipComboBox.Size = New System.Drawing.Size(121, 25)
		Me.LeadershipComboBox.TabIndex = 39
		'
		'InfoComboBox
		'
		Me.InfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.InfoComboBox.FormattingEnabled = True
		Me.InfoComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Level 7"})
		Me.InfoComboBox.Location = New System.Drawing.Point(681, 184)
		Me.InfoComboBox.Name = "InfoComboBox"
		Me.InfoComboBox.Size = New System.Drawing.Size(121, 25)
		Me.InfoComboBox.TabIndex = 40
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(410, 187)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(231, 17)
		Me.Label14.TabIndex = 41
		Me.Label14.Text = "Responsibility – information resources"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(410, 218)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(259, 17)
		Me.Label15.TabIndex = 42
		Me.Label15.Text = "Responsibility – research and development"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(410, 249)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(97, 17)
		Me.Label16.TabIndex = 43
		Me.Label16.Text = "Freedom to act"
		'
		'FreeComboBox
		'
		Me.FreeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.FreeComboBox.FormattingEnabled = True
		Me.FreeComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6"})
		Me.FreeComboBox.Location = New System.Drawing.Point(681, 246)
		Me.FreeComboBox.Name = "FreeComboBox"
		Me.FreeComboBox.Size = New System.Drawing.Size(121, 25)
		Me.FreeComboBox.TabIndex = 44
		'
		'EmoEffortComboBox
		'
		Me.EmoEffortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.EmoEffortComboBox.FormattingEnabled = True
		Me.EmoEffortComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4"})
		Me.EmoEffortComboBox.Location = New System.Drawing.Point(681, 339)
		Me.EmoEffortComboBox.Name = "EmoEffortComboBox"
		Me.EmoEffortComboBox.Size = New System.Drawing.Size(121, 25)
		Me.EmoEffortComboBox.TabIndex = 45
		'
		'MentalEffortComboBox
		'
		Me.MentalEffortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.MentalEffortComboBox.FormattingEnabled = True
		Me.MentalEffortComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5"})
		Me.MentalEffortComboBox.Location = New System.Drawing.Point(681, 308)
		Me.MentalEffortComboBox.Name = "MentalEffortComboBox"
		Me.MentalEffortComboBox.Size = New System.Drawing.Size(121, 25)
		Me.MentalEffortComboBox.TabIndex = 46
		'
		'PhysicalEffortComboBox
		'
		Me.PhysicalEffortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PhysicalEffortComboBox.FormattingEnabled = True
		Me.PhysicalEffortComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5"})
		Me.PhysicalEffortComboBox.Location = New System.Drawing.Point(681, 277)
		Me.PhysicalEffortComboBox.Name = "PhysicalEffortComboBox"
		Me.PhysicalEffortComboBox.Size = New System.Drawing.Size(121, 25)
		Me.PhysicalEffortComboBox.TabIndex = 47
		'
		'WorkConComboBox
		'
		Me.WorkConComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WorkConComboBox.FormattingEnabled = True
		Me.WorkConComboBox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5"})
		Me.WorkConComboBox.Location = New System.Drawing.Point(681, 370)
		Me.WorkConComboBox.Name = "WorkConComboBox"
		Me.WorkConComboBox.Size = New System.Drawing.Size(121, 25)
		Me.WorkConComboBox.TabIndex = 48
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(410, 311)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(84, 17)
		Me.Label17.TabIndex = 49
		Me.Label17.Text = "Mental effort"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(410, 342)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(106, 17)
		Me.Label18.TabIndex = 50
		Me.Label18.Text = "Emotional effort "
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(410, 373)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(120, 17)
		Me.Label19.TabIndex = 51
		Me.Label19.Text = "Working conditions"
		'
		'LinkLabel1
		'
		Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel1.Location = New System.Drawing.Point(29, 523)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(163, 17)
		Me.LinkLabel1.TabIndex = 53
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "For more info: refer to this"
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.Location = New System.Drawing.Point(29, 423)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(68, 17)
		Me.Label20.TabIndex = 54
		Me.Label20.Text = "Comment"
		'
		'CommentTextBox
		'
		Me.CommentTextBox.Location = New System.Drawing.Point(103, 420)
		Me.CommentTextBox.Multiline = True
		Me.CommentTextBox.Name = "CommentTextBox"
		Me.CommentTextBox.Size = New System.Drawing.Size(699, 78)
		Me.CommentTextBox.TabIndex = 55
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(32, 474)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(65, 23)
		Me.ResetButton.TabIndex = 56
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'StaffReviewForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(826, 560)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.CommentTextBox)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.LinkLabel1)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.Label18)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.WorkConComboBox)
		Me.Controls.Add(Me.PhysicalEffortComboBox)
		Me.Controls.Add(Me.MentalEffortComboBox)
		Me.Controls.Add(Me.EmoEffortComboBox)
		Me.Controls.Add(Me.FreeComboBox)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.InfoComboBox)
		Me.Controls.Add(Me.LeadershipComboBox)
		Me.Controls.Add(Me.ResearchComboBox)
		Me.Controls.Add(Me.PatientCareComboBox)
		Me.Controls.Add(Me.PolicyComboBox)
		Me.Controls.Add(Me.FinanceComboBox)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.PhysicalSkillComboBox)
		Me.Controls.Add(Me.PlanSkillComboBox)
		Me.Controls.Add(Me.AnalyticSkillComboBox)
		Me.Controls.Add(Me.KnowledgeComboBox)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.CommSkillComboBox)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.ScoreLabel)
		Me.Controls.Add(Me.TypeComboBox)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CreateButton)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ReviewDateDTP)
		Me.Controls.Add(Me.SelectConsultantButton)
		Me.Controls.Add(Me.StaffFLP)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "StaffReviewForm"
		Me.Text = "Review a Staff"
		Me.StaffFLP.ResumeLayout(False)
		Me.StaffFLP.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents StaffFLP As FlowLayoutPanel
	Friend WithEvents SelectConsultantButton As Button
	Friend WithEvents ReviewDateDTP As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents CreateButton As Button
	Friend WithEvents StaffNumberLabel As Label
	Friend WithEvents StaffNameLabel As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TypeComboBox As ComboBox
	Friend WithEvents ScoreLabel As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents CommSkillComboBox As ComboBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents KnowledgeComboBox As ComboBox
	Friend WithEvents AnalyticSkillComboBox As ComboBox
	Friend WithEvents PlanSkillComboBox As ComboBox
	Friend WithEvents PhysicalSkillComboBox As ComboBox
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents FinanceComboBox As ComboBox
	Friend WithEvents PolicyComboBox As ComboBox
	Friend WithEvents PatientCareComboBox As ComboBox
	Friend WithEvents ResearchComboBox As ComboBox
	Friend WithEvents LeadershipComboBox As ComboBox
	Friend WithEvents InfoComboBox As ComboBox
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents FreeComboBox As ComboBox
	Friend WithEvents EmoEffortComboBox As ComboBox
	Friend WithEvents MentalEffortComboBox As ComboBox
	Friend WithEvents PhysicalEffortComboBox As ComboBox
	Friend WithEvents WorkConComboBox As ComboBox
	Friend WithEvents Label17 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents LinkLabel1 As LinkLabel
	Friend WithEvents Label20 As Label
	Friend WithEvents CommentTextBox As TextBox
	Friend WithEvents ResetButton As Button
End Class
