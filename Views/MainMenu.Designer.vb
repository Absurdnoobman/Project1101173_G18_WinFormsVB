<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
		Me.OpenStaffListButton = New System.Windows.Forms.Button()
		Me.OpenWardButton = New System.Windows.Forms.Button()
		Me.OpenPatientButton = New System.Windows.Forms.Button()
		Me.WardAssignmentButton = New System.Windows.Forms.Button()
		Me.MakeAppointmentButton = New System.Windows.Forms.Button()
		Me.AppointmentButton = New System.Windows.Forms.Button()
		Me.AllocationButton = New System.Windows.Forms.Button()
		Me.UserLabel = New System.Windows.Forms.Label()
		Me.MedicationButton = New System.Windows.Forms.Button()
		Me.ReviewStaffButton = New System.Windows.Forms.Button()
		Me.NewAllocationButton = New System.Windows.Forms.Button()
		Me.MedicationReportButton = New System.Windows.Forms.Button()
		Me.ReviewSumButton = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LoguotButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.TodayMedicationLabel = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.TodayAppointmentLabel = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.InPatientsLabel = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TotalStaffLabel = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PositionLabel = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'OpenStaffListButton
		'
		Me.OpenStaffListButton.Location = New System.Drawing.Point(46, 191)
		Me.OpenStaffListButton.Name = "OpenStaffListButton"
		Me.OpenStaffListButton.Size = New System.Drawing.Size(102, 54)
		Me.OpenStaffListButton.TabIndex = 0
		Me.OpenStaffListButton.Text = "Staff"
		Me.OpenStaffListButton.UseVisualStyleBackColor = True
		'
		'OpenWardButton
		'
		Me.OpenWardButton.Location = New System.Drawing.Point(152, 191)
		Me.OpenWardButton.Name = "OpenWardButton"
		Me.OpenWardButton.Size = New System.Drawing.Size(102, 54)
		Me.OpenWardButton.TabIndex = 1
		Me.OpenWardButton.Text = "Staff Allocation"
		Me.OpenWardButton.UseVisualStyleBackColor = True
		'
		'OpenPatientButton
		'
		Me.OpenPatientButton.Location = New System.Drawing.Point(44, 99)
		Me.OpenPatientButton.Name = "OpenPatientButton"
		Me.OpenPatientButton.Size = New System.Drawing.Size(102, 54)
		Me.OpenPatientButton.TabIndex = 3
		Me.OpenPatientButton.Text = "Patients"
		Me.OpenPatientButton.UseVisualStyleBackColor = True
		'
		'WardAssignmentButton
		'
		Me.WardAssignmentButton.Location = New System.Drawing.Point(260, 191)
		Me.WardAssignmentButton.Name = "WardAssignmentButton"
		Me.WardAssignmentButton.Size = New System.Drawing.Size(102, 54)
		Me.WardAssignmentButton.TabIndex = 4
		Me.WardAssignmentButton.Text = "Assign Staff to Ward"
		Me.WardAssignmentButton.UseVisualStyleBackColor = True
		'
		'MakeAppointmentButton
		'
		Me.MakeAppointmentButton.Location = New System.Drawing.Point(152, 99)
		Me.MakeAppointmentButton.Name = "MakeAppointmentButton"
		Me.MakeAppointmentButton.Size = New System.Drawing.Size(102, 54)
		Me.MakeAppointmentButton.TabIndex = 5
		Me.MakeAppointmentButton.Text = "Make a Examination"
		Me.MakeAppointmentButton.UseVisualStyleBackColor = True
		'
		'AppointmentButton
		'
		Me.AppointmentButton.Location = New System.Drawing.Point(260, 99)
		Me.AppointmentButton.Name = "AppointmentButton"
		Me.AppointmentButton.Size = New System.Drawing.Size(102, 54)
		Me.AppointmentButton.TabIndex = 6
		Me.AppointmentButton.Text = "Appointments"
		Me.AppointmentButton.UseVisualStyleBackColor = True
		'
		'AllocationButton
		'
		Me.AllocationButton.Location = New System.Drawing.Point(692, 99)
		Me.AllocationButton.Name = "AllocationButton"
		Me.AllocationButton.Size = New System.Drawing.Size(102, 54)
		Me.AllocationButton.TabIndex = 7
		Me.AllocationButton.Text = "Patient Allocation"
		Me.AllocationButton.UseVisualStyleBackColor = True
		'
		'UserLabel
		'
		Me.UserLabel.AutoEllipsis = True
		Me.UserLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.UserLabel.Location = New System.Drawing.Point(148, 19)
		Me.UserLabel.Name = "UserLabel"
		Me.UserLabel.Size = New System.Drawing.Size(309, 28)
		Me.UserLabel.TabIndex = 9
		Me.UserLabel.Text = "User"
		Me.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'MedicationButton
		'
		Me.MedicationButton.Location = New System.Drawing.Point(368, 99)
		Me.MedicationButton.Name = "MedicationButton"
		Me.MedicationButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MedicationButton.Size = New System.Drawing.Size(102, 54)
		Me.MedicationButton.TabIndex = 10
		Me.MedicationButton.Text = "Medication Record"
		Me.MedicationButton.UseVisualStyleBackColor = True
		'
		'ReviewStaffButton
		'
		Me.ReviewStaffButton.Location = New System.Drawing.Point(368, 191)
		Me.ReviewStaffButton.Name = "ReviewStaffButton"
		Me.ReviewStaffButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ReviewStaffButton.Size = New System.Drawing.Size(102, 54)
		Me.ReviewStaffButton.TabIndex = 12
		Me.ReviewStaffButton.Text = "Review Staff"
		Me.ReviewStaffButton.UseVisualStyleBackColor = True
		'
		'NewAllocationButton
		'
		Me.NewAllocationButton.Location = New System.Drawing.Point(584, 99)
		Me.NewAllocationButton.Name = "NewAllocationButton"
		Me.NewAllocationButton.Size = New System.Drawing.Size(102, 54)
		Me.NewAllocationButton.TabIndex = 13
		Me.NewAllocationButton.Text = "New Allocation"
		Me.NewAllocationButton.UseVisualStyleBackColor = True
		'
		'MedicationReportButton
		'
		Me.MedicationReportButton.Location = New System.Drawing.Point(476, 99)
		Me.MedicationReportButton.Name = "MedicationReportButton"
		Me.MedicationReportButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MedicationReportButton.Size = New System.Drawing.Size(102, 54)
		Me.MedicationReportButton.TabIndex = 14
		Me.MedicationReportButton.Text = "Medication Report"
		Me.MedicationReportButton.UseVisualStyleBackColor = True
		'
		'ReviewSumButton
		'
		Me.ReviewSumButton.Location = New System.Drawing.Point(476, 191)
		Me.ReviewSumButton.Name = "ReviewSumButton"
		Me.ReviewSumButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ReviewSumButton.Size = New System.Drawing.Size(102, 53)
		Me.ReviewSumButton.TabIndex = 15
		Me.ReviewSumButton.Text = "Review Staff Summary"
		Me.ReviewSumButton.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(40, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(99, 28)
		Me.Label1.TabIndex = 16
		Me.Label1.Text = "Welcome"
		'
		'LoguotButton
		'
		Me.LoguotButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LoguotButton.Location = New System.Drawing.Point(719, 27)
		Me.LoguotButton.Name = "LoguotButton"
		Me.LoguotButton.Size = New System.Drawing.Size(75, 25)
		Me.LoguotButton.TabIndex = 17
		Me.LoguotButton.Text = "Logout"
		Me.LoguotButton.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(43, 72)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(96, 17)
		Me.Label2.TabIndex = 18
		Me.Label2.Text = "Patient Menus"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(43, 165)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 17)
		Me.Label3.TabIndex = 19
		Me.Label3.Text = "Staff Menus"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 4
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 3, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(46, 270)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(748, 81)
		Me.TableLayoutPanel1.TabIndex = 20
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel4.Controls.Add(Me.TodayMedicationLabel)
		Me.Panel4.Controls.Add(Me.Label7)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel4.Location = New System.Drawing.Point(564, 3)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Padding = New System.Windows.Forms.Padding(4)
		Me.Panel4.Size = New System.Drawing.Size(181, 75)
		Me.Panel4.TabIndex = 21
		'
		'TodayMedicationLabel
		'
		Me.TodayMedicationLabel.AutoSize = True
		Me.TodayMedicationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TodayMedicationLabel.Location = New System.Drawing.Point(17, 42)
		Me.TodayMedicationLabel.Name = "TodayMedicationLabel"
		Me.TodayMedicationLabel.Size = New System.Drawing.Size(17, 20)
		Me.TodayMedicationLabel.TabIndex = 25
		Me.TodayMedicationLabel.Text = "0"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(17, 14)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(142, 20)
		Me.Label7.TabIndex = 24
		Me.Label7.Text = "Today Prescriptions"
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel3.Controls.Add(Me.TodayAppointmentLabel)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel3.Location = New System.Drawing.Point(377, 3)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Padding = New System.Windows.Forms.Padding(4)
		Me.Panel3.Size = New System.Drawing.Size(184, 75)
		Me.Panel3.TabIndex = 1
		'
		'TodayAppointmentLabel
		'
		Me.TodayAppointmentLabel.AutoSize = True
		Me.TodayAppointmentLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TodayAppointmentLabel.Location = New System.Drawing.Point(17, 42)
		Me.TodayAppointmentLabel.Name = "TodayAppointmentLabel"
		Me.TodayAppointmentLabel.Size = New System.Drawing.Size(17, 20)
		Me.TodayAppointmentLabel.TabIndex = 24
		Me.TodayAppointmentLabel.Text = "0"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(17, 14)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(144, 20)
		Me.Label6.TabIndex = 23
		Me.Label6.Text = "Today Appointment"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel2.Controls.Add(Me.InPatientsLabel)
		Me.Panel2.Controls.Add(Me.Label5)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(190, 3)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Padding = New System.Windows.Forms.Padding(4)
		Me.Panel2.Size = New System.Drawing.Size(184, 75)
		Me.Panel2.TabIndex = 21
		'
		'InPatientsLabel
		'
		Me.InPatientsLabel.AutoSize = True
		Me.InPatientsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.InPatientsLabel.Location = New System.Drawing.Point(17, 42)
		Me.InPatientsLabel.Name = "InPatientsLabel"
		Me.InPatientsLabel.Size = New System.Drawing.Size(17, 20)
		Me.InPatientsLabel.TabIndex = 23
		Me.InPatientsLabel.Text = "0"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(17, 14)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(74, 20)
		Me.Label5.TabIndex = 22
		Me.Label5.Text = "In Patient"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel1.Controls.Add(Me.TotalStaffLabel)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(3, 3)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Padding = New System.Windows.Forms.Padding(4)
		Me.Panel1.Size = New System.Drawing.Size(184, 75)
		Me.Panel1.TabIndex = 0
		'
		'TotalStaffLabel
		'
		Me.TotalStaffLabel.AutoSize = True
		Me.TotalStaffLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TotalStaffLabel.Location = New System.Drawing.Point(17, 42)
		Me.TotalStaffLabel.Name = "TotalStaffLabel"
		Me.TotalStaffLabel.Size = New System.Drawing.Size(17, 20)
		Me.TotalStaffLabel.TabIndex = 22
		Me.TotalStaffLabel.Text = "0"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(17, 14)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(77, 20)
		Me.Label4.TabIndex = 21
		Me.Label4.Text = "Staff Total"
		'
		'PositionLabel
		'
		Me.PositionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PositionLabel.Location = New System.Drawing.Point(490, 33)
		Me.PositionLabel.Name = "PositionLabel"
		Me.PositionLabel.Size = New System.Drawing.Size(225, 16)
		Me.PositionLabel.TabIndex = 21
		Me.PositionLabel.Text = "Login As position: ---"
		Me.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'MainMenuForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(838, 387)
		Me.Controls.Add(Me.PositionLabel)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.LoguotButton)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ReviewSumButton)
		Me.Controls.Add(Me.MedicationReportButton)
		Me.Controls.Add(Me.NewAllocationButton)
		Me.Controls.Add(Me.ReviewStaffButton)
		Me.Controls.Add(Me.MedicationButton)
		Me.Controls.Add(Me.UserLabel)
		Me.Controls.Add(Me.AllocationButton)
		Me.Controls.Add(Me.AppointmentButton)
		Me.Controls.Add(Me.MakeAppointmentButton)
		Me.Controls.Add(Me.WardAssignmentButton)
		Me.Controls.Add(Me.OpenPatientButton)
		Me.Controls.Add(Me.OpenWardButton)
		Me.Controls.Add(Me.OpenStaffListButton)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "MainMenuForm"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Main Menu"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents OpenStaffListButton As Button
    Friend WithEvents OpenWardButton As Button
	Friend WithEvents OpenPatientButton As Button
	Friend WithEvents WardAssignmentButton As Button
    Friend WithEvents MakeAppointmentButton As Button
    Friend WithEvents AppointmentButton As Button
    Friend WithEvents AllocationButton As Button
	Friend WithEvents UserLabel As Label
	Friend WithEvents MedicationButton As Button
	Friend WithEvents ReviewStaffButton As Button
	Friend WithEvents NewAllocationButton As Button
	Friend WithEvents MedicationReportButton As Button
	Friend WithEvents ReviewSumButton As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents LoguotButton As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TodayMedicationLabel As Label
	Friend WithEvents TodayAppointmentLabel As Label
	Friend WithEvents InPatientsLabel As Label
	Friend WithEvents TotalStaffLabel As Label
	Friend WithEvents PositionLabel As Label
End Class
