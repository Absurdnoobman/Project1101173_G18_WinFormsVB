<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAppointmentForm
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
		Me.PatientFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.SelectPatientButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.ConfirmButton = New System.Windows.Forms.Button()
		Me.MeetTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ClinicIdTextBox = New System.Windows.Forms.TextBox()
		Me.AppointmentDTP = New System.Windows.Forms.DateTimePicker()
		Me.SuspendLayout()
		'
		'PatientFLP
		'
		Me.PatientFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PatientFLP.Location = New System.Drawing.Point(10, 13)
		Me.PatientFLP.Name = "PatientFLP"
		Me.PatientFLP.Size = New System.Drawing.Size(523, 135)
		Me.PatientFLP.TabIndex = 3
		'
		'SelectPatientButton
		'
		Me.SelectPatientButton.Location = New System.Drawing.Point(539, 12)
		Me.SelectPatientButton.Name = "SelectPatientButton"
		Me.SelectPatientButton.Size = New System.Drawing.Size(121, 63)
		Me.SelectPatientButton.TabIndex = 2
		Me.SelectPatientButton.Text = "Select a Patient"
		Me.SelectPatientButton.UseVisualStyleBackColor = True
		'
		'ResetButton
		'
		Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ResetButton.Location = New System.Drawing.Point(10, 201)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(98, 26)
		Me.ResetButton.TabIndex = 10
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'ConfirmButton
		'
		Me.ConfirmButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ConfirmButton.Location = New System.Drawing.Point(557, 201)
		Me.ConfirmButton.Name = "ConfirmButton"
		Me.ConfirmButton.Size = New System.Drawing.Size(98, 26)
		Me.ConfirmButton.TabIndex = 9
		Me.ConfirmButton.Text = "Confirm"
		Me.ConfirmButton.UseVisualStyleBackColor = True
		'
		'MeetTimeDateTimePicker
		'
		Me.MeetTimeDateTimePicker.CustomFormat = "HH:mm"
		Me.MeetTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.MeetTimeDateTimePicker.Location = New System.Drawing.Point(313, 164)
		Me.MeetTimeDateTimePicker.Name = "MeetTimeDateTimePicker"
		Me.MeetTimeDateTimePicker.ShowUpDown = True
		Me.MeetTimeDateTimePicker.Size = New System.Drawing.Size(91, 25)
		Me.MeetTimeDateTimePicker.TabIndex = 16
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(288, 167)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(19, 17)
		Me.Label3.TabIndex = 15
		Me.Label3.Text = "at"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(422, 167)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 17)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Clinic ID"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 168)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(54, 17)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "on Date"
		'
		'ClinicIdTextBox
		'
		Me.ClinicIdTextBox.Location = New System.Drawing.Point(482, 164)
		Me.ClinicIdTextBox.Name = "ClinicIdTextBox"
		Me.ClinicIdTextBox.Size = New System.Drawing.Size(173, 25)
		Me.ClinicIdTextBox.TabIndex = 12
		'
		'AppointmentDTP
		'
		Me.AppointmentDTP.CustomFormat = ""
		Me.AppointmentDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.AppointmentDTP.Location = New System.Drawing.Point(73, 164)
		Me.AppointmentDTP.Name = "AppointmentDTP"
		Me.AppointmentDTP.Size = New System.Drawing.Size(209, 25)
		Me.AppointmentDTP.TabIndex = 11
		Me.AppointmentDTP.Value = New Date(2025, 7, 30, 0, 0, 0, 0)
		'
		'NewAppointmentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(667, 240)
		Me.Controls.Add(Me.MeetTimeDateTimePicker)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ClinicIdTextBox)
		Me.Controls.Add(Me.AppointmentDTP)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ConfirmButton)
		Me.Controls.Add(Me.PatientFLP)
		Me.Controls.Add(Me.SelectPatientButton)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "NewAppointmentForm"
		Me.ShowIcon = False
		Me.Text = "Create a New Appointment"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PatientFLP As FlowLayoutPanel
	Friend WithEvents SelectPatientButton As Button
	Friend WithEvents ResetButton As Button
	Friend WithEvents ConfirmButton As Button
	Friend WithEvents MeetTimeDateTimePicker As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents ClinicIdTextBox As TextBox
	Friend WithEvents AppointmentDTP As DateTimePicker
End Class
