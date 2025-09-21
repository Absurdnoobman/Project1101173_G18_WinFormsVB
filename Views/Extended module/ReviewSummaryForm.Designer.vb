<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewSummaryForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReviewSummaryForm))
		Me.Top3FLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TypeComboBox = New System.Windows.Forms.ComboBox()
		Me.YearPicker = New System.Windows.Forms.DateTimePicker()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.StaffAboveAvgLabel = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.AverageLabel = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.StaffReviewedLabel = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.HighestBrandLabel = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.ReviewsDGV = New System.Windows.Forms.DataGridView()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.SearchTextBox = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.SearchByComboBox = New System.Windows.Forms.ComboBox()
		Me.DeleteRowButton = New System.Windows.Forms.Button()
		Me.EditRowButton = New System.Windows.Forms.Button()
		Me.ByBrandChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.NewButton = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.ReviewsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ByBrandChart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Top3FLP
		'
		Me.Top3FLP.AutoScroll = True
		Me.Top3FLP.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Top3FLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Top3FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.Top3FLP.Location = New System.Drawing.Point(13, 54)
		Me.Top3FLP.Margin = New System.Windows.Forms.Padding(4)
		Me.Top3FLP.Name = "Top3FLP"
		Me.Top3FLP.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
		Me.Top3FLP.Size = New System.Drawing.Size(335, 200)
		Me.Top3FLP.TabIndex = 4
		Me.Top3FLP.WrapContents = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(8, 12)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(197, 28)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "TOP 3 Staff by Score"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(453, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 17)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Type"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(634, 21)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(33, 17)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Year"
		'
		'TypeComboBox
		'
		Me.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.TypeComboBox.FormattingEnabled = True
		Me.TypeComboBox.Items.AddRange(New Object() {"Annual", "Mid-Year", "Probation"})
		Me.TypeComboBox.Location = New System.Drawing.Point(494, 18)
		Me.TypeComboBox.Name = "TypeComboBox"
		Me.TypeComboBox.Size = New System.Drawing.Size(121, 25)
		Me.TypeComboBox.TabIndex = 8
		'
		'YearPicker
		'
		Me.YearPicker.CustomFormat = " yyyy"
		Me.YearPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
		Me.YearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.YearPicker.Location = New System.Drawing.Point(674, 18)
		Me.YearPicker.Name = "YearPicker"
		Me.YearPicker.Size = New System.Drawing.Size(137, 25)
		Me.YearPicker.TabIndex = 9
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(356, 54)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(455, 200)
		Me.TableLayoutPanel1.TabIndex = 10
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel4.Controls.Add(Me.StaffAboveAvgLabel)
		Me.Panel4.Controls.Add(Me.Label11)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel4.Location = New System.Drawing.Point(227, 100)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(225, 97)
		Me.Panel4.TabIndex = 1
		'
		'StaffAboveAvgLabel
		'
		Me.StaffAboveAvgLabel.AutoSize = True
		Me.StaffAboveAvgLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffAboveAvgLabel.Location = New System.Drawing.Point(23, 54)
		Me.StaffAboveAvgLabel.Name = "StaffAboveAvgLabel"
		Me.StaffAboveAvgLabel.Size = New System.Drawing.Size(35, 23)
		Me.StaffAboveAvgLabel.TabIndex = 12
		Me.StaffAboveAvgLabel.Text = "100"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(23, 19)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(164, 23)
		Me.Label11.TabIndex = 11
		Me.Label11.Text = "Staff above average"
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel3.Controls.Add(Me.AverageLabel)
		Me.Panel3.Controls.Add(Me.Label7)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel3.Location = New System.Drawing.Point(227, 3)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(225, 94)
		Me.Panel3.TabIndex = 11
		'
		'AverageLabel
		'
		Me.AverageLabel.AutoSize = True
		Me.AverageLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AverageLabel.Location = New System.Drawing.Point(23, 51)
		Me.AverageLabel.Name = "AverageLabel"
		Me.AverageLabel.Size = New System.Drawing.Size(35, 23)
		Me.AverageLabel.TabIndex = 3
		Me.AverageLabel.Text = "100"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(23, 16)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(120, 23)
		Me.Label7.TabIndex = 2
		Me.Label7.Text = "Average Score"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel1.Controls.Add(Me.StaffReviewedLabel)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(3, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(221, 94)
		Me.Panel1.TabIndex = 0
		'
		'StaffReviewedLabel
		'
		Me.StaffReviewedLabel.AutoSize = True
		Me.StaffReviewedLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffReviewedLabel.Location = New System.Drawing.Point(17, 51)
		Me.StaffReviewedLabel.Name = "StaffReviewedLabel"
		Me.StaffReviewedLabel.Size = New System.Drawing.Size(35, 23)
		Me.StaffReviewedLabel.TabIndex = 1
		Me.StaffReviewedLabel.Text = "100"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(17, 16)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(125, 23)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Staff Reviewed"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel2.Controls.Add(Me.HighestBrandLabel)
		Me.Panel2.Controls.Add(Me.Label9)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(3, 100)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(221, 97)
		Me.Panel2.TabIndex = 1
		'
		'HighestBrandLabel
		'
		Me.HighestBrandLabel.AutoSize = True
		Me.HighestBrandLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.HighestBrandLabel.Location = New System.Drawing.Point(17, 54)
		Me.HighestBrandLabel.Name = "HighestBrandLabel"
		Me.HighestBrandLabel.Size = New System.Drawing.Size(35, 23)
		Me.HighestBrandLabel.TabIndex = 12
		Me.HighestBrandLabel.Text = "100"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(17, 19)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(119, 23)
		Me.Label9.TabIndex = 11
		Me.Label9.Text = "Highest Brand"
		'
		'ReviewsDGV
		'
		Me.ReviewsDGV.AllowUserToAddRows = False
		Me.ReviewsDGV.AllowUserToDeleteRows = False
		Me.ReviewsDGV.AllowUserToOrderColumns = True
		Me.ReviewsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.ReviewsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.ReviewsDGV.Location = New System.Drawing.Point(468, 313)
		Me.ReviewsDGV.MultiSelect = False
		Me.ReviewsDGV.Name = "ReviewsDGV"
		Me.ReviewsDGV.ReadOnly = True
		Me.ReviewsDGV.RowHeadersWidth = 51
		Me.ReviewsDGV.RowTemplate.Height = 24
		Me.ReviewsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.ReviewsDGV.Size = New System.Drawing.Size(343, 200)
		Me.ReviewsDGV.TabIndex = 11
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(465, 276)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(47, 17)
		Me.Label12.TabIndex = 12
		Me.Label12.Text = "Search"
		'
		'SearchTextBox
		'
		Me.SearchTextBox.Location = New System.Drawing.Point(518, 273)
		Me.SearchTextBox.Name = "SearchTextBox"
		Me.SearchTextBox.Size = New System.Drawing.Size(116, 25)
		Me.SearchTextBox.TabIndex = 13
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(656, 276)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(64, 17)
		Me.Label13.TabIndex = 14
		Me.Label13.Text = "Search By"
		'
		'SearchByComboBox
		'
		Me.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SearchByComboBox.FormattingEnabled = True
		Me.SearchByComboBox.Items.AddRange(New Object() {"Staff Number", "Staff Name", "Firstname", "Lastname"})
		Me.SearchByComboBox.Location = New System.Drawing.Point(726, 273)
		Me.SearchByComboBox.Name = "SearchByComboBox"
		Me.SearchByComboBox.Size = New System.Drawing.Size(85, 25)
		Me.SearchByComboBox.TabIndex = 15
		'
		'DeleteRowButton
		'
		Me.DeleteRowButton.Enabled = False
		Me.DeleteRowButton.Location = New System.Drawing.Point(726, 520)
		Me.DeleteRowButton.Name = "DeleteRowButton"
		Me.DeleteRowButton.Size = New System.Drawing.Size(84, 32)
		Me.DeleteRowButton.TabIndex = 16
		Me.DeleteRowButton.Text = "Delete"
		Me.DeleteRowButton.UseVisualStyleBackColor = True
		'
		'EditRowButton
		'
		Me.EditRowButton.Enabled = False
		Me.EditRowButton.Location = New System.Drawing.Point(636, 520)
		Me.EditRowButton.Name = "EditRowButton"
		Me.EditRowButton.Size = New System.Drawing.Size(84, 32)
		Me.EditRowButton.TabIndex = 17
		Me.EditRowButton.Text = "Edit"
		Me.EditRowButton.UseVisualStyleBackColor = True
		'
		'ByBrandChart
		'
		Me.ByBrandChart.BackColor = System.Drawing.SystemColors.Control
		ChartArea1.Name = "ChartArea1"
		Me.ByBrandChart.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.ByBrandChart.Legends.Add(Legend1)
		Me.ByBrandChart.Location = New System.Drawing.Point(13, 276)
		Me.ByBrandChart.Name = "ByBrandChart"
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
		Series1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Series1.Legend = "Legend1"
		Series1.Name = "Score"
		Series1.YValuesPerPoint = 2
		Me.ByBrandChart.Series.Add(Series1)
		Me.ByBrandChart.Size = New System.Drawing.Size(435, 276)
		Me.ByBrandChart.TabIndex = 18
		Me.ByBrandChart.Text = "Brand"
		Title1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Title1.Name = "title"
		Title1.Text = "Brand Distribution"
		Me.ByBrandChart.Titles.Add(Title1)
		'
		'NewButton
		'
		Me.NewButton.Enabled = False
		Me.NewButton.Location = New System.Drawing.Point(468, 519)
		Me.NewButton.Name = "NewButton"
		Me.NewButton.Size = New System.Drawing.Size(84, 32)
		Me.NewButton.TabIndex = 19
		Me.NewButton.Text = "New"
		Me.NewButton.UseVisualStyleBackColor = True
		'
		'ReviewSummaryForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(826, 567)
		Me.Controls.Add(Me.NewButton)
		Me.Controls.Add(Me.ByBrandChart)
		Me.Controls.Add(Me.EditRowButton)
		Me.Controls.Add(Me.DeleteRowButton)
		Me.Controls.Add(Me.SearchByComboBox)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.SearchTextBox)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.ReviewsDGV)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.YearPicker)
		Me.Controls.Add(Me.TypeComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Top3FLP)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "ReviewSummaryForm"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Review Summary"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.ReviewsDGV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ByBrandChart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Top3FLP As FlowLayoutPanel
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TypeComboBox As ComboBox
	Friend WithEvents YearPicker As DateTimePicker
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents StaffAboveAvgLabel As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents AverageLabel As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents StaffReviewedLabel As Label
	Friend WithEvents HighestBrandLabel As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents ReviewsDGV As DataGridView
	Friend WithEvents Label12 As Label
	Friend WithEvents SearchTextBox As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents SearchByComboBox As ComboBox
	Friend WithEvents DeleteRowButton As Button
	Friend WithEvents EditRowButton As Button
	Friend WithEvents ByBrandChart As DataVisualization.Charting.Chart
	Friend WithEvents NewButton As Button
End Class
