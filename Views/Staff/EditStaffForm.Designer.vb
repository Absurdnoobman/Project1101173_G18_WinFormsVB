<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditStaffForm
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
		Me.StaffNumberTextBox = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.AddNewWorkExpButton = New System.Windows.Forms.Button()
		Me.WorksFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.QualificationFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.AddNewQualiButton = New System.Windows.Forms.Button()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.HPWTextBox = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.ContractTypeComboBox = New System.Windows.Forms.ComboBox()
		Me.PaymentTypeComboBox = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.SalaryTextBox = New System.Windows.Forms.TextBox()
		Me.PositionComboBox = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.NINTextBox = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
		Me.DateOfBrithDTP = New System.Windows.Forms.DateTimePicker()
		Me.SexComboBox = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.AddressTextBox = New System.Windows.Forms.TextBox()
		Me.SurnameTextBox = New System.Windows.Forms.TextBox()
		Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
		Me.SaveButton = New System.Windows.Forms.Button()
		Me.SalaryScaleComboBox = New System.Windows.Forms.ComboBox()
		Me.ShowPwdCheckBox = New System.Windows.Forms.CheckBox()
		Me.PasswordTextBox = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'StaffNumberTextBox
		'
		Me.StaffNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.StaffNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.StaffNumberTextBox.Location = New System.Drawing.Point(444, 15)
		Me.StaffNumberTextBox.Name = "StaffNumberTextBox"
		Me.StaffNumberTextBox.ReadOnly = True
		Me.StaffNumberTextBox.Size = New System.Drawing.Size(98, 25)
		Me.StaffNumberTextBox.TabIndex = 75
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(350, 18)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(86, 17)
		Me.Label16.TabIndex = 74
		Me.Label16.Text = "Staff Number"
		'
		'AddNewWorkExpButton
		'
		Me.AddNewWorkExpButton.Location = New System.Drawing.Point(39, 452)
		Me.AddNewWorkExpButton.Name = "AddNewWorkExpButton"
		Me.AddNewWorkExpButton.Size = New System.Drawing.Size(135, 56)
		Me.AddNewWorkExpButton.TabIndex = 71
		Me.AddNewWorkExpButton.Text = "Add a new Work Experience"
		Me.AddNewWorkExpButton.UseVisualStyleBackColor = True
		'
		'WorksFLP
		'
		Me.WorksFLP.AutoScroll = True
		Me.WorksFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.WorksFLP.Location = New System.Drawing.Point(178, 452)
		Me.WorksFLP.Name = "WorksFLP"
		Me.WorksFLP.Size = New System.Drawing.Size(482, 139)
		Me.WorksFLP.TabIndex = 73
		Me.WorksFLP.WrapContents = False
		'
		'QualificationFLP
		'
		Me.QualificationFLP.AutoScroll = True
		Me.QualificationFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.QualificationFLP.Location = New System.Drawing.Point(178, 307)
		Me.QualificationFLP.Name = "QualificationFLP"
		Me.QualificationFLP.Size = New System.Drawing.Size(482, 139)
		Me.QualificationFLP.TabIndex = 72
		Me.QualificationFLP.WrapContents = False
		'
		'AddNewQualiButton
		'
		Me.AddNewQualiButton.Location = New System.Drawing.Point(37, 307)
		Me.AddNewQualiButton.Name = "AddNewQualiButton"
		Me.AddNewQualiButton.Size = New System.Drawing.Size(135, 59)
		Me.AddNewQualiButton.TabIndex = 70
		Me.AddNewQualiButton.Text = "Add a new qualification"
		Me.AddNewQualiButton.UseVisualStyleBackColor = True
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(32, 9)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(170, 28)
		Me.Label15.TabIndex = 69
		Me.Label15.Text = "Edit Staff Profile"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(36, 257)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(106, 17)
		Me.Label14.TabIndex = 68
		Me.Label14.Text = "Hours per weeks"
		'
		'HPWTextBox
		'
		Me.HPWTextBox.Location = New System.Drawing.Point(153, 254)
		Me.HPWTextBox.Name = "HPWTextBox"
		Me.HPWTextBox.Size = New System.Drawing.Size(173, 25)
		Me.HPWTextBox.TabIndex = 67
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(36, 226)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(88, 17)
		Me.Label13.TabIndex = 66
		Me.Label13.Text = "Contract Type"
		'
		'ContractTypeComboBox
		'
		Me.ContractTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ContractTypeComboBox.FormattingEnabled = True
		Me.ContractTypeComboBox.Items.AddRange(New Object() {"Temporary", "Permanent"})
		Me.ContractTypeComboBox.Location = New System.Drawing.Point(153, 223)
		Me.ContractTypeComboBox.Name = "ContractTypeComboBox"
		Me.ContractTypeComboBox.Size = New System.Drawing.Size(173, 25)
		Me.ContractTypeComboBox.TabIndex = 65
		'
		'PaymentTypeComboBox
		'
		Me.PaymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PaymentTypeComboBox.FormattingEnabled = True
		Me.PaymentTypeComboBox.Items.AddRange(New Object() {"Test", "Monthly", "Weekly"})
		Me.PaymentTypeComboBox.Location = New System.Drawing.Point(444, 254)
		Me.PaymentTypeComboBox.Name = "PaymentTypeComboBox"
		Me.PaymentTypeComboBox.Size = New System.Drawing.Size(173, 25)
		Me.PaymentTypeComboBox.TabIndex = 64
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(350, 257)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(88, 17)
		Me.Label12.TabIndex = 63
		Me.Label12.Text = "Payment Type"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(350, 226)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(77, 17)
		Me.Label11.TabIndex = 62
		Me.Label11.Text = "Salary Scale"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(350, 195)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(90, 17)
		Me.Label10.TabIndex = 60
		Me.Label10.Text = "Current Salary"
		'
		'SalaryTextBox
		'
		Me.SalaryTextBox.Location = New System.Drawing.Point(444, 192)
		Me.SalaryTextBox.Name = "SalaryTextBox"
		Me.SalaryTextBox.Size = New System.Drawing.Size(173, 25)
		Me.SalaryTextBox.TabIndex = 59
		'
		'PositionComboBox
		'
		Me.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PositionComboBox.FormattingEnabled = True
		Me.PositionComboBox.Items.AddRange(New Object() {"Medical Director", "Consultant", "Specialty Doctor", "Junior Doctor", "Staff Nurse", "Senior Staff Nurse", "Charge Nurse", "Advanced Nurse Practitioner", "Healthcare Support Worker", "Midwife", "Physiotherapist", "Occupational Therapist", "Pharmacist", "Personnel Officer", "System Administrator", "Auxiliary"})
		Me.PositionComboBox.Location = New System.Drawing.Point(153, 192)
		Me.PositionComboBox.Name = "PositionComboBox"
		Me.PositionComboBox.Size = New System.Drawing.Size(173, 25)
		Me.PositionComboBox.TabIndex = 58
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(36, 195)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(54, 17)
		Me.Label9.TabIndex = 57
		Me.Label9.Text = "Position"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(350, 151)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(31, 17)
		Me.Label8.TabIndex = 56
		Me.Label8.Text = "NIN"
		'
		'NINTextBox
		'
		Me.NINTextBox.Location = New System.Drawing.Point(443, 148)
		Me.NINTextBox.Name = "NINTextBox"
		Me.NINTextBox.Size = New System.Drawing.Size(173, 25)
		Me.NINTextBox.TabIndex = 55
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(34, 151)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(79, 17)
		Me.Label7.TabIndex = 54
		Me.Label7.Text = "Tel. Number"
		'
		'TelephoneTextBox
		'
		Me.TelephoneTextBox.Location = New System.Drawing.Point(153, 148)
		Me.TelephoneTextBox.Name = "TelephoneTextBox"
		Me.TelephoneTextBox.Size = New System.Drawing.Size(173, 25)
		Me.TelephoneTextBox.TabIndex = 53
		'
		'DateOfBrithDTP
		'
		Me.DateOfBrithDTP.AllowDrop = True
		Me.DateOfBrithDTP.Location = New System.Drawing.Point(443, 117)
		Me.DateOfBrithDTP.Name = "DateOfBrithDTP"
		Me.DateOfBrithDTP.Size = New System.Drawing.Size(217, 25)
		Me.DateOfBrithDTP.TabIndex = 52
		'
		'SexComboBox
		'
		Me.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SexComboBox.FormattingEnabled = True
		Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
		Me.SexComboBox.Location = New System.Drawing.Point(443, 84)
		Me.SexComboBox.Name = "SexComboBox"
		Me.SexComboBox.Size = New System.Drawing.Size(173, 25)
		Me.SexComboBox.TabIndex = 51
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(350, 123)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.TabIndex = 50
		Me.Label6.Text = "Date of Brith"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(350, 87)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(28, 17)
		Me.Label5.TabIndex = 49
		Me.Label5.Text = "Sex"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(34, 87)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 17)
		Me.Label4.TabIndex = 48
		Me.Label4.Text = "Address"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(350, 57)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(59, 17)
		Me.Label3.TabIndex = 47
		Me.Label3.Text = "Surname"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(34, 57)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(64, 17)
		Me.Label2.TabIndex = 46
		Me.Label2.Text = "Firstname"
		'
		'AddressTextBox
		'
		Me.AddressTextBox.Location = New System.Drawing.Point(153, 84)
		Me.AddressTextBox.Multiline = True
		Me.AddressTextBox.Name = "AddressTextBox"
		Me.AddressTextBox.Size = New System.Drawing.Size(173, 58)
		Me.AddressTextBox.TabIndex = 45
		'
		'SurnameTextBox
		'
		Me.SurnameTextBox.Location = New System.Drawing.Point(443, 54)
		Me.SurnameTextBox.Name = "SurnameTextBox"
		Me.SurnameTextBox.Size = New System.Drawing.Size(173, 25)
		Me.SurnameTextBox.TabIndex = 44
		'
		'FirstnameTextBox
		'
		Me.FirstnameTextBox.Location = New System.Drawing.Point(153, 54)
		Me.FirstnameTextBox.Name = "FirstnameTextBox"
		Me.FirstnameTextBox.Size = New System.Drawing.Size(173, 25)
		Me.FirstnameTextBox.TabIndex = 43
		'
		'SaveButton
		'
		Me.SaveButton.Location = New System.Drawing.Point(597, 633)
		Me.SaveButton.Name = "SaveButton"
		Me.SaveButton.Size = New System.Drawing.Size(91, 26)
		Me.SaveButton.TabIndex = 76
		Me.SaveButton.Text = "Save"
		Me.SaveButton.UseVisualStyleBackColor = True
		'
		'SalaryScaleComboBox
		'
		Me.SalaryScaleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SalaryScaleComboBox.FormattingEnabled = True
		Me.SalaryScaleComboBox.Items.AddRange(New Object() {"Brand 1", "Brand 2", "Brand 3", "Brand 4", "Brand 5", "Brand 6", "Brand 7", "Brand 8", "Brand 8a", "Brand 8b", "Brand 8c", "Brand 8d", "Brand 8e", "Brand 9"})
		Me.SalaryScaleComboBox.Location = New System.Drawing.Point(444, 223)
		Me.SalaryScaleComboBox.Name = "SalaryScaleComboBox"
		Me.SalaryScaleComboBox.Size = New System.Drawing.Size(174, 25)
		Me.SalaryScaleComboBox.TabIndex = 77
		'
		'ShowPwdCheckBox
		'
		Me.ShowPwdCheckBox.AutoSize = True
		Me.ShowPwdCheckBox.Location = New System.Drawing.Point(539, 604)
		Me.ShowPwdCheckBox.Name = "ShowPwdCheckBox"
		Me.ShowPwdCheckBox.Size = New System.Drawing.Size(121, 21)
		Me.ShowPwdCheckBox.TabIndex = 80
		Me.ShowPwdCheckBox.Text = "Show Password"
		Me.ShowPwdCheckBox.UseVisualStyleBackColor = True
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.Location = New System.Drawing.Point(137, 602)
		Me.PasswordTextBox.Name = "PasswordTextBox"
		Me.PasswordTextBox.Size = New System.Drawing.Size(385, 25)
		Me.PasswordTextBox.TabIndex = 79
		Me.PasswordTextBox.UseSystemPasswordChar = True
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(34, 605)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(97, 17)
		Me.Label17.TabIndex = 78
		Me.Label17.Text = "New Password"
		'
		'EditStaffForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 671)
		Me.Controls.Add(Me.ShowPwdCheckBox)
		Me.Controls.Add(Me.PasswordTextBox)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.SalaryScaleComboBox)
		Me.Controls.Add(Me.SaveButton)
		Me.Controls.Add(Me.StaffNumberTextBox)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.AddNewWorkExpButton)
		Me.Controls.Add(Me.WorksFLP)
		Me.Controls.Add(Me.QualificationFLP)
		Me.Controls.Add(Me.AddNewQualiButton)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.HPWTextBox)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.ContractTypeComboBox)
		Me.Controls.Add(Me.PaymentTypeComboBox)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.SalaryTextBox)
		Me.Controls.Add(Me.PositionComboBox)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.NINTextBox)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TelephoneTextBox)
		Me.Controls.Add(Me.DateOfBrithDTP)
		Me.Controls.Add(Me.SexComboBox)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.AddressTextBox)
		Me.Controls.Add(Me.SurnameTextBox)
		Me.Controls.Add(Me.FirstnameTextBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "EditStaffForm"
		Me.Text = "Edit a Staff Profile"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents StaffNumberTextBox As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents AddNewWorkExpButton As Button
	Friend WithEvents WorksFLP As FlowLayoutPanel
	Friend WithEvents QualificationFLP As FlowLayoutPanel
	Friend WithEvents AddNewQualiButton As Button
	Friend WithEvents Label15 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents HPWTextBox As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents ContractTypeComboBox As ComboBox
	Friend WithEvents PaymentTypeComboBox As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents SalaryTextBox As TextBox
	Friend WithEvents PositionComboBox As ComboBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents NINTextBox As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents TelephoneTextBox As TextBox
	Friend WithEvents DateOfBrithDTP As DateTimePicker
	Friend WithEvents SexComboBox As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents AddressTextBox As TextBox
	Friend WithEvents SurnameTextBox As TextBox
	Friend WithEvents FirstnameTextBox As TextBox
	Friend WithEvents SaveButton As Button
	Friend WithEvents SalaryScaleComboBox As ComboBox
	Friend WithEvents ShowPwdCheckBox As CheckBox
	Friend WithEvents PasswordTextBox As TextBox
	Friend WithEvents Label17 As Label
End Class
