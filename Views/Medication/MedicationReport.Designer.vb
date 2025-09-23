<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedicationReport
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicationReport))
		Me.PickPatientButton = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
		Me.PatientNumberLabel = New System.Windows.Forms.Label()
		Me.PatientNameLabel = New System.Windows.Forms.Label()
		Me.MedicationsDGV = New System.Windows.Forms.DataGridView()
		Me.PlzLabel = New System.Windows.Forms.Label()
		Me.WardLabel = New System.Windows.Forms.Label()
		Me.BedNumberLabel = New System.Windows.Forms.Label()
		Me.ApplyFilterButton = New System.Windows.Forms.Button()
		Me.RefreshButton = New System.Windows.Forms.Button()
		Me.FilterLabel = New System.Windows.Forms.Label()
		Me.AddFilterButton = New System.Windows.Forms.Button()
		Me.FilterFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.ExportButton = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel.SuspendLayout()
		CType(Me.MedicationsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PickPatientButton
		'
		Me.PickPatientButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PickPatientButton.Location = New System.Drawing.Point(673, 14)
		Me.PickPatientButton.Name = "PickPatientButton"
		Me.PickPatientButton.Size = New System.Drawing.Size(108, 60)
		Me.PickPatientButton.TabIndex = 0
		Me.PickPatientButton.Text = "Pick the Patient"
		Me.PickPatientButton.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel
		'
		Me.FlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.FlowLayoutPanel.Controls.Add(Me.PatientNumberLabel)
		Me.FlowLayoutPanel.Controls.Add(Me.PatientNameLabel)
		Me.FlowLayoutPanel.Location = New System.Drawing.Point(15, 15)
		Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
		Me.FlowLayoutPanel.Padding = New System.Windows.Forms.Padding(24, 16, 0, 4)
		Me.FlowLayoutPanel.Size = New System.Drawing.Size(652, 59)
		Me.FlowLayoutPanel.TabIndex = 1
		'
		'PatientNumberLabel
		'
		Me.PatientNumberLabel.AutoSize = True
		Me.PatientNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PatientNumberLabel.Location = New System.Drawing.Point(27, 16)
		Me.PatientNumberLabel.Name = "PatientNumberLabel"
		Me.PatientNumberLabel.Size = New System.Drawing.Size(138, 23)
		Me.PatientNumberLabel.TabIndex = 0
		Me.PatientNumberLabel.Text = "Patient Number"
		'
		'PatientNameLabel
		'
		Me.PatientNameLabel.AutoSize = True
		Me.PatientNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PatientNameLabel.Location = New System.Drawing.Point(171, 16)
		Me.PatientNameLabel.Name = "PatientNameLabel"
		Me.PatientNameLabel.Size = New System.Drawing.Size(88, 23)
		Me.PatientNameLabel.TabIndex = 1
		Me.PatientNameLabel.Text = "Full name"
		'
		'MedicationsDGV
		'
		Me.MedicationsDGV.AllowUserToAddRows = False
		Me.MedicationsDGV.AllowUserToDeleteRows = False
		Me.MedicationsDGV.AllowUserToOrderColumns = True
		Me.MedicationsDGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.MedicationsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.MedicationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.MedicationsDGV.Location = New System.Drawing.Point(15, 197)
		Me.MedicationsDGV.Name = "MedicationsDGV"
		Me.MedicationsDGV.ReadOnly = True
		Me.MedicationsDGV.RowHeadersWidth = 51
		Me.MedicationsDGV.RowTemplate.Height = 24
		Me.MedicationsDGV.Size = New System.Drawing.Size(766, 300)
		Me.MedicationsDGV.TabIndex = 2
		'
		'PlzLabel
		'
		Me.PlzLabel.AutoSize = True
		Me.PlzLabel.Location = New System.Drawing.Point(325, 262)
		Me.PlzLabel.Name = "PlzLabel"
		Me.PlzLabel.Size = New System.Drawing.Size(148, 17)
		Me.PlzLabel.TabIndex = 3
		Me.PlzLabel.Text = "Please Select the Patient"
		Me.PlzLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'WardLabel
		'
		Me.WardLabel.AutoSize = True
		Me.WardLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.WardLabel.Location = New System.Drawing.Point(15, 87)
		Me.WardLabel.Name = "WardLabel"
		Me.WardLabel.Size = New System.Drawing.Size(210, 23)
		Me.WardLabel.TabIndex = 4
		Me.WardLabel.Text = "Currently: reside at ward"
		'
		'BedNumberLabel
		'
		Me.BedNumberLabel.AutoSize = True
		Me.BedNumberLabel.Location = New System.Drawing.Point(460, 91)
		Me.BedNumberLabel.Name = "BedNumberLabel"
		Me.BedNumberLabel.Size = New System.Drawing.Size(82, 17)
		Me.BedNumberLabel.TabIndex = 5
		Me.BedNumberLabel.Text = "Bed Number"
		'
		'ApplyFilterButton
		'
		Me.ApplyFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.ApplyFilterButton.Location = New System.Drawing.Point(673, 125)
		Me.ApplyFilterButton.Name = "ApplyFilterButton"
		Me.ApplyFilterButton.Size = New System.Drawing.Size(108, 31)
		Me.ApplyFilterButton.TabIndex = 16
		Me.ApplyFilterButton.Text = "Apply"
		Me.ApplyFilterButton.UseVisualStyleBackColor = True
		'
		'RefreshButton
		'
		Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.RefreshButton.Location = New System.Drawing.Point(673, 157)
		Me.RefreshButton.Name = "RefreshButton"
		Me.RefreshButton.Size = New System.Drawing.Size(108, 31)
		Me.RefreshButton.TabIndex = 17
		Me.RefreshButton.Text = "Refresh"
		Me.RefreshButton.UseVisualStyleBackColor = True
		'
		'FilterLabel
		'
		Me.FilterLabel.AutoSize = True
		Me.FilterLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FilterLabel.Location = New System.Drawing.Point(16, 125)
		Me.FilterLabel.Name = "FilterLabel"
		Me.FilterLabel.Size = New System.Drawing.Size(44, 20)
		Me.FilterLabel.TabIndex = 18
		Me.FilterLabel.Text = "Filter"
		'
		'AddFilterButton
		'
		Me.AddFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.AddFilterButton.Location = New System.Drawing.Point(15, 157)
		Me.AddFilterButton.Name = "AddFilterButton"
		Me.AddFilterButton.Size = New System.Drawing.Size(75, 31)
		Me.AddFilterButton.TabIndex = 19
		Me.AddFilterButton.Text = "Add"
		Me.AddFilterButton.UseVisualStyleBackColor = True
		'
		'FilterFLP
		'
		Me.FilterFLP.AutoScroll = True
		Me.FilterFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.FilterFLP.Location = New System.Drawing.Point(96, 125)
		Me.FilterFLP.Name = "FilterFLP"
		Me.FilterFLP.Padding = New System.Windows.Forms.Padding(3)
		Me.FilterFLP.Size = New System.Drawing.Size(571, 63)
		Me.FilterFLP.TabIndex = 15
		Me.FilterFLP.WrapContents = False
		'
		'ExportButton
		'
		Me.ExportButton.Location = New System.Drawing.Point(666, 503)
		Me.ExportButton.Name = "ExportButton"
		Me.ExportButton.Size = New System.Drawing.Size(114, 23)
		Me.ExportButton.TabIndex = 20
		Me.ExportButton.Text = "Export to CSV"
		Me.ExportButton.UseVisualStyleBackColor = True
		'
		'MedicationReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(796, 540)
		Me.Controls.Add(Me.ExportButton)
		Me.Controls.Add(Me.AddFilterButton)
		Me.Controls.Add(Me.FilterLabel)
		Me.Controls.Add(Me.RefreshButton)
		Me.Controls.Add(Me.ApplyFilterButton)
		Me.Controls.Add(Me.FilterFLP)
		Me.Controls.Add(Me.BedNumberLabel)
		Me.Controls.Add(Me.WardLabel)
		Me.Controls.Add(Me.PlzLabel)
		Me.Controls.Add(Me.MedicationsDGV)
		Me.Controls.Add(Me.FlowLayoutPanel)
		Me.Controls.Add(Me.PickPatientButton)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "MedicationReport"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Patient Medication Report"
		Me.FlowLayoutPanel.ResumeLayout(False)
		Me.FlowLayoutPanel.PerformLayout()
		CType(Me.MedicationsDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PickPatientButton As Button
	Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
	Friend WithEvents PatientNumberLabel As Label
	Friend WithEvents PatientNameLabel As Label
	Friend WithEvents MedicationsDGV As DataGridView
	Friend WithEvents PlzLabel As Label
	Friend WithEvents WardLabel As Label
	Friend WithEvents BedNumberLabel As Label
	Friend WithEvents ApplyFilterButton As Button
	Friend WithEvents RefreshButton As Button
	Friend WithEvents FilterLabel As Label
	Friend WithEvents AddFilterButton As Button
	Friend WithEvents FilterFLP As FlowLayoutPanel
	Friend WithEvents ExportButton As Button
End Class
