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
		Me.WIPLabel = New System.Windows.Forms.Label()
		Me.OpenPatientButton = New System.Windows.Forms.Button()
		Me.WardAssignmentButton = New System.Windows.Forms.Button()
		Me.MakeAppointmentButton = New System.Windows.Forms.Button()
		Me.AppointmentButton = New System.Windows.Forms.Button()
		Me.AllocationButton = New System.Windows.Forms.Button()
		Me.NewSupplyButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.MedicationButton = New System.Windows.Forms.Button()
		Me.NewPharmaSupplyButton = New System.Windows.Forms.Button()
		Me.ReviewStaffButton = New System.Windows.Forms.Button()
		Me.NewAllocationButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'OpenStaffListButton
		'
		Me.OpenStaffListButton.Location = New System.Drawing.Point(44, 41)
		Me.OpenStaffListButton.Name = "OpenStaffListButton"
		Me.OpenStaffListButton.Size = New System.Drawing.Size(102, 54)
		Me.OpenStaffListButton.TabIndex = 0
		Me.OpenStaffListButton.Text = "Staff"
		Me.OpenStaffListButton.UseVisualStyleBackColor = True
		'
		'OpenWardButton
		'
		Me.OpenWardButton.Location = New System.Drawing.Point(44, 101)
		Me.OpenWardButton.Name = "OpenWardButton"
		Me.OpenWardButton.Size = New System.Drawing.Size(102, 54)
		Me.OpenWardButton.TabIndex = 1
		Me.OpenWardButton.Text = "Ward"
		Me.OpenWardButton.UseVisualStyleBackColor = True
		'
		'WIPLabel
		'
		Me.WIPLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WIPLabel.AutoSize = True
		Me.WIPLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.WIPLabel.Location = New System.Drawing.Point(562, 523)
		Me.WIPLabel.Name = "WIPLabel"
		Me.WIPLabel.Size = New System.Drawing.Size(132, 23)
		Me.WIPLabel.TabIndex = 2
		Me.WIPLabel.Text = "Work in Progress"
		'
		'OpenPatientButton
		'
		Me.OpenPatientButton.Location = New System.Drawing.Point(44, 161)
		Me.OpenPatientButton.Name = "OpenPatientButton"
		Me.OpenPatientButton.Size = New System.Drawing.Size(102, 54)
		Me.OpenPatientButton.TabIndex = 3
		Me.OpenPatientButton.Text = "Create a Patient Record"
		Me.OpenPatientButton.UseVisualStyleBackColor = True
		'
		'WardAssignmentButton
		'
		Me.WardAssignmentButton.Location = New System.Drawing.Point(152, 101)
		Me.WardAssignmentButton.Name = "WardAssignmentButton"
		Me.WardAssignmentButton.Size = New System.Drawing.Size(102, 54)
		Me.WardAssignmentButton.TabIndex = 4
		Me.WardAssignmentButton.Text = "Assign Staff to Ward"
		Me.WardAssignmentButton.UseVisualStyleBackColor = True
		'
		'MakeAppointmentButton
		'
		Me.MakeAppointmentButton.Location = New System.Drawing.Point(152, 162)
		Me.MakeAppointmentButton.Name = "MakeAppointmentButton"
		Me.MakeAppointmentButton.Size = New System.Drawing.Size(102, 53)
		Me.MakeAppointmentButton.TabIndex = 5
		Me.MakeAppointmentButton.Text = "Make a Examination"
		Me.MakeAppointmentButton.UseVisualStyleBackColor = True
		'
		'AppointmentButton
		'
		Me.AppointmentButton.Location = New System.Drawing.Point(260, 162)
		Me.AppointmentButton.Name = "AppointmentButton"
		Me.AppointmentButton.Size = New System.Drawing.Size(102, 53)
		Me.AppointmentButton.TabIndex = 6
		Me.AppointmentButton.Text = "Appointments"
		Me.AppointmentButton.UseVisualStyleBackColor = True
		'
		'AllocationButton
		'
		Me.AllocationButton.Location = New System.Drawing.Point(44, 221)
		Me.AllocationButton.Name = "AllocationButton"
		Me.AllocationButton.Size = New System.Drawing.Size(102, 53)
		Me.AllocationButton.TabIndex = 7
		Me.AllocationButton.Text = "Patient Allocation"
		Me.AllocationButton.UseVisualStyleBackColor = True
		'
		'NewSupplyButton
		'
		Me.NewSupplyButton.Location = New System.Drawing.Point(44, 339)
		Me.NewSupplyButton.Name = "NewSupplyButton"
		Me.NewSupplyButton.Size = New System.Drawing.Size(102, 70)
		Me.NewSupplyButton.TabIndex = 8
		Me.NewSupplyButton.Text = "Create a Supply"
		Me.NewSupplyButton.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 527)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(46, 17)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Label2"
		'
		'MedicationButton
		'
		Me.MedicationButton.Location = New System.Drawing.Point(44, 280)
		Me.MedicationButton.Name = "MedicationButton"
		Me.MedicationButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MedicationButton.Size = New System.Drawing.Size(102, 53)
		Me.MedicationButton.TabIndex = 10
		Me.MedicationButton.Text = "Medication Record"
		Me.MedicationButton.UseVisualStyleBackColor = True
		'
		'NewPharmaSupplyButton
		'
		Me.NewPharmaSupplyButton.Location = New System.Drawing.Point(152, 339)
		Me.NewPharmaSupplyButton.Name = "NewPharmaSupplyButton"
		Me.NewPharmaSupplyButton.Size = New System.Drawing.Size(102, 70)
		Me.NewPharmaSupplyButton.TabIndex = 11
		Me.NewPharmaSupplyButton.Text = "Create a Pharmaticeul Supply"
		Me.NewPharmaSupplyButton.UseVisualStyleBackColor = True
		'
		'ReviewStaffButton
		'
		Me.ReviewStaffButton.Location = New System.Drawing.Point(44, 415)
		Me.ReviewStaffButton.Name = "ReviewStaffButton"
		Me.ReviewStaffButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ReviewStaffButton.Size = New System.Drawing.Size(102, 53)
		Me.ReviewStaffButton.TabIndex = 12
		Me.ReviewStaffButton.Text = "Review Staff"
		Me.ReviewStaffButton.UseVisualStyleBackColor = True
		'
		'NewAllocationButton
		'
		Me.NewAllocationButton.Location = New System.Drawing.Point(152, 221)
		Me.NewAllocationButton.Name = "NewAllocationButton"
		Me.NewAllocationButton.Size = New System.Drawing.Size(102, 53)
		Me.NewAllocationButton.TabIndex = 13
		Me.NewAllocationButton.Text = "New Allocation"
		Me.NewAllocationButton.UseVisualStyleBackColor = True
		'
		'MainMenuForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(706, 555)
		Me.Controls.Add(Me.NewAllocationButton)
		Me.Controls.Add(Me.ReviewStaffButton)
		Me.Controls.Add(Me.NewPharmaSupplyButton)
		Me.Controls.Add(Me.MedicationButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.NewSupplyButton)
		Me.Controls.Add(Me.AllocationButton)
		Me.Controls.Add(Me.AppointmentButton)
		Me.Controls.Add(Me.MakeAppointmentButton)
		Me.Controls.Add(Me.WardAssignmentButton)
		Me.Controls.Add(Me.OpenPatientButton)
		Me.Controls.Add(Me.WIPLabel)
		Me.Controls.Add(Me.OpenWardButton)
		Me.Controls.Add(Me.OpenStaffListButton)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(724, 525)
		Me.Name = "MainMenuForm"
		Me.Text = "Main Menu (DEBUG)"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents OpenStaffListButton As Button
    Friend WithEvents OpenWardButton As Button
    Friend WithEvents WIPLabel As Label
    Friend WithEvents OpenPatientButton As Button
    Friend WithEvents WardAssignmentButton As Button
    Friend WithEvents MakeAppointmentButton As Button
    Friend WithEvents AppointmentButton As Button
    Friend WithEvents AllocationButton As Button
    Friend WithEvents NewSupplyButton As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents MedicationButton As Button
	Friend WithEvents NewPharmaSupplyButton As Button
	Friend WithEvents ReviewStaffButton As Button
	Friend WithEvents NewAllocationButton As Button
End Class
