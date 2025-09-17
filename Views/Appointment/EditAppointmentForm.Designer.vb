<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAppointmentForm
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
		Me.MeetTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.AppointmentDTP = New System.Windows.Forms.DateTimePicker()
		Me.ConfirmButton = New System.Windows.Forms.Button()
		Me.PatientFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.SelectPatientButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'MeetTimeDateTimePicker
		'
		Me.MeetTimeDateTimePicker.CustomFormat = "HH:mm"
		Me.MeetTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.MeetTimeDateTimePicker.Location = New System.Drawing.Point(311, 165)
		Me.MeetTimeDateTimePicker.Name = "MeetTimeDateTimePicker"
		Me.MeetTimeDateTimePicker.ShowUpDown = True
		Me.MeetTimeDateTimePicker.Size = New System.Drawing.Size(91, 25)
		Me.MeetTimeDateTimePicker.TabIndex = 24
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(286, 168)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(19, 17)
		Me.Label3.TabIndex = 23
		Me.Label3.Text = "at"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(11, 169)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(54, 17)
		Me.Label1.TabIndex = 22
		Me.Label1.Text = "on Date"
		'
		'AppointmentDTP
		'
		Me.AppointmentDTP.Checked = False
		Me.AppointmentDTP.CustomFormat = ""
		Me.AppointmentDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.AppointmentDTP.Location = New System.Drawing.Point(71, 165)
		Me.AppointmentDTP.Name = "AppointmentDTP"
		Me.AppointmentDTP.Size = New System.Drawing.Size(209, 25)
		Me.AppointmentDTP.TabIndex = 21
		'
		'ConfirmButton
		'
		Me.ConfirmButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ConfirmButton.Location = New System.Drawing.Point(557, 166)
		Me.ConfirmButton.Name = "ConfirmButton"
		Me.ConfirmButton.Size = New System.Drawing.Size(98, 26)
		Me.ConfirmButton.TabIndex = 19
		Me.ConfirmButton.Text = "Confirm"
		Me.ConfirmButton.UseVisualStyleBackColor = True
		'
		'PatientFLP
		'
		Me.PatientFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PatientFLP.Location = New System.Drawing.Point(8, 14)
		Me.PatientFLP.Name = "PatientFLP"
		Me.PatientFLP.Size = New System.Drawing.Size(523, 135)
		Me.PatientFLP.TabIndex = 18
		'
		'SelectPatientButton
		'
		Me.SelectPatientButton.Enabled = False
		Me.SelectPatientButton.Location = New System.Drawing.Point(537, 13)
		Me.SelectPatientButton.Name = "SelectPatientButton"
		Me.SelectPatientButton.Size = New System.Drawing.Size(121, 63)
		Me.SelectPatientButton.TabIndex = 17
		Me.SelectPatientButton.Text = "Select a Patient"
		Me.SelectPatientButton.UseVisualStyleBackColor = True
		'
		'EditAppointmentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(667, 204)
		Me.Controls.Add(Me.MeetTimeDateTimePicker)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.AppointmentDTP)
		Me.Controls.Add(Me.ConfirmButton)
		Me.Controls.Add(Me.PatientFLP)
		Me.Controls.Add(Me.SelectPatientButton)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "EditAppointmentForm"
		Me.Text = "Edit an Appointment Form"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MeetTimeDateTimePicker As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents AppointmentDTP As DateTimePicker
	Friend WithEvents ConfirmButton As Button
	Friend WithEvents PatientFLP As FlowLayoutPanel
	Friend WithEvents SelectPatientButton As Button
End Class
