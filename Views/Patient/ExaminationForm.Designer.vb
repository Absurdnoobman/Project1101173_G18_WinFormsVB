<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExaminationForm
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
		Me.SelectPatientButton = New System.Windows.Forms.Button()
		Me.PatientFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.SelectConsultantButton = New System.Windows.Forms.Button()
		Me.ConsultantFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.AppointmentDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.MeetRoomTextBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ConfirmButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.MeetTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.SuspendLayout()
		'
		'SelectPatientButton
		'
		Me.SelectPatientButton.Location = New System.Drawing.Point(548, 12)
		Me.SelectPatientButton.Name = "SelectPatientButton"
		Me.SelectPatientButton.Size = New System.Drawing.Size(113, 59)
		Me.SelectPatientButton.TabIndex = 0
		Me.SelectPatientButton.Text = "Select a Patient"
		Me.SelectPatientButton.UseVisualStyleBackColor = True
		'
		'PatientFLP
		'
		Me.PatientFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PatientFLP.Location = New System.Drawing.Point(12, 13)
		Me.PatientFLP.Name = "PatientFLP"
		Me.PatientFLP.Size = New System.Drawing.Size(529, 141)
		Me.PatientFLP.TabIndex = 1
		'
		'SelectConsultantButton
		'
		Me.SelectConsultantButton.Location = New System.Drawing.Point(548, 160)
		Me.SelectConsultantButton.Name = "SelectConsultantButton"
		Me.SelectConsultantButton.Size = New System.Drawing.Size(113, 59)
		Me.SelectConsultantButton.TabIndex = 2
		Me.SelectConsultantButton.Text = "Select a Consultant"
		Me.SelectConsultantButton.UseVisualStyleBackColor = True
		'
		'ConsultantFLP
		'
		Me.ConsultantFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ConsultantFLP.Location = New System.Drawing.Point(12, 160)
		Me.ConsultantFLP.Name = "ConsultantFLP"
		Me.ConsultantFLP.Size = New System.Drawing.Size(529, 136)
		Me.ConsultantFLP.TabIndex = 2
		'
		'AppointmentDateTimePicker
		'
		Me.AppointmentDateTimePicker.Checked = False
		Me.AppointmentDateTimePicker.CustomFormat = ""
		Me.AppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.AppointmentDateTimePicker.Location = New System.Drawing.Point(72, 305)
		Me.AppointmentDateTimePicker.Name = "AppointmentDateTimePicker"
		Me.AppointmentDateTimePicker.Size = New System.Drawing.Size(187, 25)
		Me.AppointmentDateTimePicker.TabIndex = 3
		'
		'MeetRoomTextBox
		'
		Me.MeetRoomTextBox.Location = New System.Drawing.Point(479, 305)
		Me.MeetRoomTextBox.Name = "MeetRoomTextBox"
		Me.MeetRoomTextBox.Size = New System.Drawing.Size(181, 25)
		Me.MeetRoomTextBox.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 308)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(54, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "on Date"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(430, 308)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(43, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Room"
		'
		'ConfirmButton
		'
		Me.ConfirmButton.Location = New System.Drawing.Point(548, 354)
		Me.ConfirmButton.Name = "ConfirmButton"
		Me.ConfirmButton.Size = New System.Drawing.Size(112, 24)
		Me.ConfirmButton.TabIndex = 7
		Me.ConfirmButton.Text = "Confirm"
		Me.ConfirmButton.UseVisualStyleBackColor = True
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(12, 354)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(112, 24)
		Me.ResetButton.TabIndex = 8
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(285, 308)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(19, 17)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "at"
		'
		'MeetTimeDateTimePicker
		'
		Me.MeetTimeDateTimePicker.CustomFormat = "HH:mm"
		Me.MeetTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.MeetTimeDateTimePicker.Location = New System.Drawing.Point(310, 305)
		Me.MeetTimeDateTimePicker.Name = "MeetTimeDateTimePicker"
		Me.MeetTimeDateTimePicker.ShowUpDown = True
		Me.MeetTimeDateTimePicker.Size = New System.Drawing.Size(103, 25)
		Me.MeetTimeDateTimePicker.TabIndex = 10
		'
		'ExaminationForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(673, 392)
		Me.Controls.Add(Me.MeetTimeDateTimePicker)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ConfirmButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MeetRoomTextBox)
		Me.Controls.Add(Me.AppointmentDateTimePicker)
		Me.Controls.Add(Me.ConsultantFLP)
		Me.Controls.Add(Me.SelectConsultantButton)
		Me.Controls.Add(Me.PatientFLP)
		Me.Controls.Add(Me.SelectPatientButton)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "ExaminationForm"
		Me.Text = "Make an Examination"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SelectPatientButton As Button
    Friend WithEvents PatientFLP As FlowLayoutPanel
    Friend WithEvents SelectConsultantButton As Button
    Friend WithEvents ConsultantFLP As FlowLayoutPanel
    Friend WithEvents AppointmentDateTimePicker As DateTimePicker
    Friend WithEvents MeetRoomTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents MeetTimeDateTimePicker As DateTimePicker
End Class
