<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPatientForm
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
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.AddressLDTTextBox = New System.Windows.Forms.TextBox()
		Me.TelephoneLDTTextBox = New System.Windows.Forms.TextBox()
		Me.ClinicNumberLDTTextBox = New System.Windows.Forms.TextBox()
		Me.FullnameLDTTextBox = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.SaveButton = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.AddressNOKTextBox = New System.Windows.Forms.TextBox()
		Me.TelephoneNOKTextBox = New System.Windows.Forms.TextBox()
		Me.RelationshipNOKTextBox = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.FullnameNOKTextBox = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.DateOfBirthDTP = New System.Windows.Forms.DateTimePicker()
		Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
		Me.SexComboBox = New System.Windows.Forms.ComboBox()
		Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
		Me.AddressTextBox = New System.Windows.Forms.TextBox()
		Me.PatientNumberTextBox = New System.Windows.Forms.TextBox()
		Me.SurnameTextBox = New System.Windows.Forms.TextBox()
		Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.AddressLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.TelephoneLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.ClinicNumberLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.FullnameLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.Label18)
		Me.GroupBox2.Controls.Add(Me.Label17)
		Me.GroupBox2.Controls.Add(Me.Label16)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Location = New System.Drawing.Point(15, 335)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
		Me.GroupBox2.Size = New System.Drawing.Size(670, 136)
		Me.GroupBox2.TabIndex = 80
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Local Doctor Details"
		'
		'AddressLDTTextBox
		'
		Me.AddressLDTTextBox.Location = New System.Drawing.Point(360, 25)
		Me.AddressLDTTextBox.Multiline = True
		Me.AddressLDTTextBox.Name = "AddressLDTTextBox"
		Me.AddressLDTTextBox.Size = New System.Drawing.Size(278, 89)
		Me.AddressLDTTextBox.TabIndex = 7
		'
		'TelephoneLDTTextBox
		'
		Me.TelephoneLDTTextBox.Location = New System.Drawing.Point(99, 89)
		Me.TelephoneLDTTextBox.Name = "TelephoneLDTTextBox"
		Me.TelephoneLDTTextBox.Size = New System.Drawing.Size(182, 25)
		Me.TelephoneLDTTextBox.TabIndex = 6
		'
		'ClinicNumberLDTTextBox
		'
		Me.ClinicNumberLDTTextBox.Location = New System.Drawing.Point(99, 57)
		Me.ClinicNumberLDTTextBox.Name = "ClinicNumberLDTTextBox"
		Me.ClinicNumberLDTTextBox.Size = New System.Drawing.Size(182, 25)
		Me.ClinicNumberLDTTextBox.TabIndex = 5
		'
		'FullnameLDTTextBox
		'
		Me.FullnameLDTTextBox.Location = New System.Drawing.Point(99, 25)
		Me.FullnameLDTTextBox.Name = "FullnameLDTTextBox"
		Me.FullnameLDTTextBox.Size = New System.Drawing.Size(182, 25)
		Me.FullnameLDTTextBox.TabIndex = 4
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(10, 92)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(68, 17)
		Me.Label18.TabIndex = 3
		Me.Label18.Text = "Telephone"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(301, 30)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(56, 17)
		Me.Label17.TabIndex = 2
		Me.Label17.Text = "Address"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(10, 60)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(90, 17)
		Me.Label16.TabIndex = 1
		Me.Label16.Text = "Clinic Number"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(10, 28)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(59, 17)
		Me.Label14.TabIndex = 0
		Me.Label14.Text = "Fullname"
		'
		'SaveButton
		'
		Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SaveButton.Location = New System.Drawing.Point(600, 483)
		Me.SaveButton.Name = "SaveButton"
		Me.SaveButton.Size = New System.Drawing.Size(85, 30)
		Me.SaveButton.TabIndex = 79
		Me.SaveButton.Text = "Save"
		Me.SaveButton.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.AddressNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.TelephoneNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.RelationshipNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.FullnameNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox1.Location = New System.Drawing.Point(15, 196)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
		Me.GroupBox1.Size = New System.Drawing.Size(670, 132)
		Me.GroupBox1.TabIndex = 78
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Next-Of-Kin Details"
		'
		'AddressNOKTextBox
		'
		Me.AddressNOKTextBox.Location = New System.Drawing.Point(363, 21)
		Me.AddressNOKTextBox.Multiline = True
		Me.AddressNOKTextBox.Name = "AddressNOKTextBox"
		Me.AddressNOKTextBox.Size = New System.Drawing.Size(275, 87)
		Me.AddressNOKTextBox.TabIndex = 7
		'
		'TelephoneNOKTextBox
		'
		Me.TelephoneNOKTextBox.Location = New System.Drawing.Point(99, 84)
		Me.TelephoneNOKTextBox.Name = "TelephoneNOKTextBox"
		Me.TelephoneNOKTextBox.Size = New System.Drawing.Size(182, 25)
		Me.TelephoneNOKTextBox.TabIndex = 6
		'
		'RelationshipNOKTextBox
		'
		Me.RelationshipNOKTextBox.Location = New System.Drawing.Point(99, 52)
		Me.RelationshipNOKTextBox.Name = "RelationshipNOKTextBox"
		Me.RelationshipNOKTextBox.Size = New System.Drawing.Size(182, 25)
		Me.RelationshipNOKTextBox.TabIndex = 5
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(9, 87)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(68, 17)
		Me.Label13.TabIndex = 4
		Me.Label13.Text = "Telephone"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(10, 55)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(79, 17)
		Me.Label12.TabIndex = 3
		Me.Label12.Text = "Relationship"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(301, 24)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(56, 17)
		Me.Label11.TabIndex = 2
		Me.Label11.Text = "Address"
		'
		'FullnameNOKTextBox
		'
		Me.FullnameNOKTextBox.Location = New System.Drawing.Point(99, 21)
		Me.FullnameNOKTextBox.Name = "FullnameNOKTextBox"
		Me.FullnameNOKTextBox.Size = New System.Drawing.Size(182, 25)
		Me.FullnameNOKTextBox.TabIndex = 1
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(9, 24)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(59, 17)
		Me.Label9.TabIndex = 0
		Me.Label9.Text = "Fullname"
		'
		'DateOfBirthDTP
		'
		Me.DateOfBirthDTP.Location = New System.Drawing.Point(422, 117)
		Me.DateOfBirthDTP.Name = "DateOfBirthDTP"
		Me.DateOfBirthDTP.Size = New System.Drawing.Size(231, 25)
		Me.DateOfBirthDTP.TabIndex = 77
		'
		'MaritalStatusComboBox
		'
		Me.MaritalStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.MaritalStatusComboBox.FormattingEnabled = True
		Me.MaritalStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Single (Divorced)"})
		Me.MaritalStatusComboBox.Location = New System.Drawing.Point(422, 154)
		Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
		Me.MaritalStatusComboBox.Size = New System.Drawing.Size(231, 25)
		Me.MaritalStatusComboBox.TabIndex = 76
		'
		'SexComboBox
		'
		Me.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SexComboBox.FormattingEnabled = True
		Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female", "Orther"})
		Me.SexComboBox.Location = New System.Drawing.Point(422, 85)
		Me.SexComboBox.Name = "SexComboBox"
		Me.SexComboBox.Size = New System.Drawing.Size(231, 25)
		Me.SexComboBox.TabIndex = 75
		'
		'TelephoneTextBox
		'
		Me.TelephoneTextBox.Location = New System.Drawing.Point(97, 154)
		Me.TelephoneTextBox.Name = "TelephoneTextBox"
		Me.TelephoneTextBox.Size = New System.Drawing.Size(185, 25)
		Me.TelephoneTextBox.TabIndex = 74
		'
		'AddressTextBox
		'
		Me.AddressTextBox.Location = New System.Drawing.Point(97, 85)
		Me.AddressTextBox.Multiline = True
		Me.AddressTextBox.Name = "AddressTextBox"
		Me.AddressTextBox.Size = New System.Drawing.Size(185, 57)
		Me.AddressTextBox.TabIndex = 73
		'
		'PatientNumberTextBox
		'
		Me.PatientNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.PatientNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PatientNumberTextBox.Location = New System.Drawing.Point(506, 16)
		Me.PatientNumberTextBox.Name = "PatientNumberTextBox"
		Me.PatientNumberTextBox.ReadOnly = True
		Me.PatientNumberTextBox.Size = New System.Drawing.Size(100, 25)
		Me.PatientNumberTextBox.TabIndex = 72
		'
		'SurnameTextBox
		'
		Me.SurnameTextBox.Location = New System.Drawing.Point(422, 53)
		Me.SurnameTextBox.Name = "SurnameTextBox"
		Me.SurnameTextBox.Size = New System.Drawing.Size(231, 25)
		Me.SurnameTextBox.TabIndex = 71
		'
		'FirstnameTextBox
		'
		Me.FirstnameTextBox.Location = New System.Drawing.Point(97, 53)
		Me.FirstnameTextBox.Name = "FirstnameTextBox"
		Me.FirstnameTextBox.Size = New System.Drawing.Size(185, 25)
		Me.FirstnameTextBox.TabIndex = 70
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(399, 19)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(99, 17)
		Me.Label10.TabIndex = 69
		Me.Label10.Text = "Patient Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(310, 157)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(88, 17)
		Me.Label8.TabIndex = 68
		Me.Label8.Text = "Marital Status"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(20, 157)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 17)
		Me.Label7.TabIndex = 67
		Me.Label7.Text = "Telephone"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(310, 123)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(81, 17)
		Me.Label5.TabIndex = 66
		Me.Label5.Text = "Date of Birth"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(310, 56)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(59, 17)
		Me.Label4.TabIndex = 65
		Me.Label4.Text = "Surname"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(310, 88)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(28, 17)
		Me.Label3.TabIndex = 64
		Me.Label3.Text = "Sex"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(20, 83)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 17)
		Me.Label2.TabIndex = 63
		Me.Label2.Text = "Address"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(20, 53)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(64, 17)
		Me.Label1.TabIndex = 62
		Me.Label1.Text = "Firstname"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(15, 10)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(208, 28)
		Me.Label15.TabIndex = 61
		Me.Label15.Text = "Edit a Petient Profile"
		'
		'EditPatientForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 522)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.SaveButton)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.DateOfBirthDTP)
		Me.Controls.Add(Me.MaritalStatusComboBox)
		Me.Controls.Add(Me.SexComboBox)
		Me.Controls.Add(Me.TelephoneTextBox)
		Me.Controls.Add(Me.AddressTextBox)
		Me.Controls.Add(Me.PatientNumberTextBox)
		Me.Controls.Add(Me.SurnameTextBox)
		Me.Controls.Add(Me.FirstnameTextBox)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label15)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "EditPatientForm"
		Me.Text = "EditPatientForm"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents AddressLDTTextBox As TextBox
	Friend WithEvents TelephoneLDTTextBox As TextBox
	Friend WithEvents ClinicNumberLDTTextBox As TextBox
	Friend WithEvents FullnameLDTTextBox As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents SaveButton As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents AddressNOKTextBox As TextBox
	Friend WithEvents TelephoneNOKTextBox As TextBox
	Friend WithEvents RelationshipNOKTextBox As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents FullnameNOKTextBox As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents DateOfBirthDTP As DateTimePicker
	Friend WithEvents MaritalStatusComboBox As ComboBox
	Friend WithEvents SexComboBox As ComboBox
	Friend WithEvents TelephoneTextBox As TextBox
	Friend WithEvents AddressTextBox As TextBox
	Friend WithEvents PatientNumberTextBox As TextBox
	Friend WithEvents SurnameTextBox As TextBox
	Friend WithEvents FirstnameTextBox As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label15 As Label
End Class
