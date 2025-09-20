<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreatePatientForm
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
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
		Me.SurnameTextBox = New System.Windows.Forms.TextBox()
		Me.PatientNumberTextBox = New System.Windows.Forms.TextBox()
		Me.AddressTextBox = New System.Windows.Forms.TextBox()
		Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
		Me.SexComboBox = New System.Windows.Forms.ComboBox()
		Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
		Me.DateOfBirthDTP = New System.Windows.Forms.DateTimePicker()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ResetNextOfKinButton = New System.Windows.Forms.Button()
		Me.AddressNOKTextBox = New System.Windows.Forms.TextBox()
		Me.TelephoneNOKTextBox = New System.Windows.Forms.TextBox()
		Me.RelationshipNOKTextBox = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.FullnameNOKTextBox = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.AddButton = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.ResetLocalDoctorButton = New System.Windows.Forms.Button()
		Me.AddressLDTTextBox = New System.Windows.Forms.TextBox()
		Me.TelephoneLDTTextBox = New System.Windows.Forms.TextBox()
		Me.ClinicNumberLDTTextBox = New System.Windows.Forms.TextBox()
		Me.FullnameLDTTextBox = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(15, 12)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(281, 28)
		Me.Label15.TabIndex = 36
		Me.Label15.Text = "Create a New Petient Profile"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(20, 55)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(64, 17)
		Me.Label1.TabIndex = 37
		Me.Label1.Text = "Firstname"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(20, 85)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 17)
		Me.Label2.TabIndex = 38
		Me.Label2.Text = "Address"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(310, 90)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(28, 17)
		Me.Label3.TabIndex = 39
		Me.Label3.Text = "Sex"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(310, 58)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(59, 17)
		Me.Label4.TabIndex = 40
		Me.Label4.Text = "Surname"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(310, 125)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(81, 17)
		Me.Label5.TabIndex = 41
		Me.Label5.Text = "Date of Birth"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(20, 159)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 17)
		Me.Label7.TabIndex = 43
		Me.Label7.Text = "Telephone"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(310, 159)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(88, 17)
		Me.Label8.TabIndex = 44
		Me.Label8.Text = "Marital Status"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(340, 21)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(99, 17)
		Me.Label10.TabIndex = 46
		Me.Label10.Text = "Patient Number"
		'
		'FirstnameTextBox
		'
		Me.FirstnameTextBox.Location = New System.Drawing.Point(97, 55)
		Me.FirstnameTextBox.Name = "FirstnameTextBox"
		Me.FirstnameTextBox.Size = New System.Drawing.Size(185, 25)
		Me.FirstnameTextBox.TabIndex = 47
		'
		'SurnameTextBox
		'
		Me.SurnameTextBox.Location = New System.Drawing.Point(422, 55)
		Me.SurnameTextBox.Name = "SurnameTextBox"
		Me.SurnameTextBox.Size = New System.Drawing.Size(231, 25)
		Me.SurnameTextBox.TabIndex = 48
		'
		'PatientNumberTextBox
		'
		Me.PatientNumberTextBox.Location = New System.Drawing.Point(447, 18)
		Me.PatientNumberTextBox.Name = "PatientNumberTextBox"
		Me.PatientNumberTextBox.Size = New System.Drawing.Size(100, 25)
		Me.PatientNumberTextBox.TabIndex = 49
		'
		'AddressTextBox
		'
		Me.AddressTextBox.Location = New System.Drawing.Point(97, 87)
		Me.AddressTextBox.Multiline = True
		Me.AddressTextBox.Name = "AddressTextBox"
		Me.AddressTextBox.Size = New System.Drawing.Size(185, 57)
		Me.AddressTextBox.TabIndex = 50
		'
		'TelephoneTextBox
		'
		Me.TelephoneTextBox.Location = New System.Drawing.Point(97, 156)
		Me.TelephoneTextBox.Name = "TelephoneTextBox"
		Me.TelephoneTextBox.Size = New System.Drawing.Size(185, 25)
		Me.TelephoneTextBox.TabIndex = 51
		'
		'SexComboBox
		'
		Me.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SexComboBox.FormattingEnabled = True
		Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female", "Orther"})
		Me.SexComboBox.Location = New System.Drawing.Point(422, 87)
		Me.SexComboBox.Name = "SexComboBox"
		Me.SexComboBox.Size = New System.Drawing.Size(231, 25)
		Me.SexComboBox.TabIndex = 52
		'
		'MaritalStatusComboBox
		'
		Me.MaritalStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.MaritalStatusComboBox.FormattingEnabled = True
		Me.MaritalStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Single (Divorced)"})
		Me.MaritalStatusComboBox.Location = New System.Drawing.Point(422, 156)
		Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
		Me.MaritalStatusComboBox.Size = New System.Drawing.Size(231, 25)
		Me.MaritalStatusComboBox.TabIndex = 53
		'
		'DateOfBirthDTP
		'
		Me.DateOfBirthDTP.Location = New System.Drawing.Point(422, 119)
		Me.DateOfBirthDTP.Name = "DateOfBirthDTP"
		Me.DateOfBirthDTP.Size = New System.Drawing.Size(231, 25)
		Me.DateOfBirthDTP.TabIndex = 54
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ResetNextOfKinButton)
		Me.GroupBox1.Controls.Add(Me.AddressNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.TelephoneNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.RelationshipNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.FullnameNOKTextBox)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox1.Location = New System.Drawing.Point(15, 198)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
		Me.GroupBox1.Size = New System.Drawing.Size(670, 132)
		Me.GroupBox1.TabIndex = 57
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Next-Of-Kin Details"
		'
		'ResetNextOfKinButton
		'
		Me.ResetNextOfKinButton.Location = New System.Drawing.Point(575, 87)
		Me.ResetNextOfKinButton.Name = "ResetNextOfKinButton"
		Me.ResetNextOfKinButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetNextOfKinButton.TabIndex = 8
		Me.ResetNextOfKinButton.Text = "Reset"
		Me.ResetNextOfKinButton.UseVisualStyleBackColor = True
		'
		'AddressNOKTextBox
		'
		Me.AddressNOKTextBox.Location = New System.Drawing.Point(363, 21)
		Me.AddressNOKTextBox.Multiline = True
		Me.AddressNOKTextBox.Name = "AddressNOKTextBox"
		Me.AddressNOKTextBox.Size = New System.Drawing.Size(197, 87)
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
		'AddButton
		'
		Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.AddButton.Location = New System.Drawing.Point(600, 485)
		Me.AddButton.Name = "AddButton"
		Me.AddButton.Size = New System.Drawing.Size(85, 30)
		Me.AddButton.TabIndex = 58
		Me.AddButton.Text = "Add"
		Me.AddButton.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.ResetLocalDoctorButton)
		Me.GroupBox2.Controls.Add(Me.AddressLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.TelephoneLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.ClinicNumberLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.FullnameLDTTextBox)
		Me.GroupBox2.Controls.Add(Me.Label18)
		Me.GroupBox2.Controls.Add(Me.Label17)
		Me.GroupBox2.Controls.Add(Me.Label16)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Location = New System.Drawing.Point(15, 337)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
		Me.GroupBox2.Size = New System.Drawing.Size(670, 136)
		Me.GroupBox2.TabIndex = 59
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Local Doctor Details"
		'
		'ResetLocalDoctorButton
		'
		Me.ResetLocalDoctorButton.Location = New System.Drawing.Point(575, 92)
		Me.ResetLocalDoctorButton.Name = "ResetLocalDoctorButton"
		Me.ResetLocalDoctorButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetLocalDoctorButton.TabIndex = 9
		Me.ResetLocalDoctorButton.Text = "Reset"
		Me.ResetLocalDoctorButton.UseVisualStyleBackColor = True
		'
		'AddressLDTTextBox
		'
		Me.AddressLDTTextBox.Location = New System.Drawing.Point(360, 25)
		Me.AddressLDTTextBox.Multiline = True
		Me.AddressLDTTextBox.Name = "AddressLDTTextBox"
		Me.AddressLDTTextBox.Size = New System.Drawing.Size(200, 89)
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
		'ResetButton
		'
		Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ResetButton.Location = New System.Drawing.Point(509, 485)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(85, 30)
		Me.ResetButton.TabIndex = 60
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(557, 23)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(128, 17)
		Me.Label6.TabIndex = 61
		Me.Label6.Text = "(Can not be changed)"
		'
		'CreatePatientForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 522)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.AddButton)
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
		Me.Name = "CreatePatientForm"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Create a New Patient Record"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents FirstnameTextBox As TextBox
	Friend WithEvents SurnameTextBox As TextBox
	Friend WithEvents PatientNumberTextBox As TextBox
	Friend WithEvents AddressTextBox As TextBox
	Friend WithEvents TelephoneTextBox As TextBox
	Friend WithEvents SexComboBox As ComboBox
	Friend WithEvents MaritalStatusComboBox As ComboBox
	Friend WithEvents DateOfBirthDTP As DateTimePicker
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents FullnameNOKTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents AddressNOKTextBox As TextBox
    Friend WithEvents TelephoneNOKTextBox As TextBox
    Friend WithEvents RelationshipNOKTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AddressLDTTextBox As TextBox
    Friend WithEvents TelephoneLDTTextBox As TextBox
    Friend WithEvents ClinicNumberLDTTextBox As TextBox
    Friend WithEvents FullnameLDTTextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents ResetNextOfKinButton As Button
    Friend WithEvents ResetLocalDoctorButton As Button
	Friend WithEvents Label6 As Label
End Class
