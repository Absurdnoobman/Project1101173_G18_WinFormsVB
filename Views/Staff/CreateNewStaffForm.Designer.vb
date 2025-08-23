<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewStaffForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
		Me.SurnameTextBox = New System.Windows.Forms.TextBox()
		Me.AddressTextBox = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.SexComboBox = New System.Windows.Forms.ComboBox()
		Me.DateOfBrithDTP = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.NINTextBox = New System.Windows.Forms.TextBox()
		Me.PositionComboBox = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.SalaryTextBox = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.PaymentTypeComboBox = New System.Windows.Forms.ComboBox()
		Me.ContractTypeComboBox = New System.Windows.Forms.ComboBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.HPWTextBox = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.AddNewQualiButton = New System.Windows.Forms.Button()
		Me.AddNewWorkExpButton = New System.Windows.Forms.Button()
		Me.CreateButton = New System.Windows.Forms.Button()
		Me.WorksFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.QualificationFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.StaffNumberTextBox = New System.Windows.Forms.TextBox()
		Me.SalaryScaleComboBox = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.PasswordTextBox = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.ShowPwdCheckBox = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 652)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(132, 23)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Work in Progress"
		'
		'FirstnameTextBox
		'
		Me.FirstnameTextBox.Location = New System.Drawing.Point(144, 54)
		Me.FirstnameTextBox.Name = "FirstnameTextBox"
		Me.FirstnameTextBox.Size = New System.Drawing.Size(173, 25)
		Me.FirstnameTextBox.TabIndex = 4
		'
		'SurnameTextBox
		'
		Me.SurnameTextBox.Location = New System.Drawing.Point(434, 54)
		Me.SurnameTextBox.Name = "SurnameTextBox"
		Me.SurnameTextBox.Size = New System.Drawing.Size(173, 25)
		Me.SurnameTextBox.TabIndex = 5
		'
		'AddressTextBox
		'
		Me.AddressTextBox.Location = New System.Drawing.Point(144, 84)
		Me.AddressTextBox.Multiline = True
		Me.AddressTextBox.Name = "AddressTextBox"
		Me.AddressTextBox.Size = New System.Drawing.Size(173, 58)
		Me.AddressTextBox.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(25, 57)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(64, 17)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Firstname"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(341, 57)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(59, 17)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Surname"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(25, 87)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 17)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Address"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(341, 87)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(28, 17)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "Sex"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(341, 123)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "Date of Brith"
		'
		'SexComboBox
		'
		Me.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SexComboBox.FormattingEnabled = True
		Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
		Me.SexComboBox.Location = New System.Drawing.Point(434, 84)
		Me.SexComboBox.Name = "SexComboBox"
		Me.SexComboBox.Size = New System.Drawing.Size(173, 25)
		Me.SexComboBox.TabIndex = 14
		'
		'DateOfBrithDTP
		'
		Me.DateOfBrithDTP.AllowDrop = True
		Me.DateOfBrithDTP.Location = New System.Drawing.Point(434, 117)
		Me.DateOfBrithDTP.Name = "DateOfBrithDTP"
		Me.DateOfBrithDTP.Size = New System.Drawing.Size(217, 25)
		Me.DateOfBrithDTP.TabIndex = 15
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(25, 151)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(79, 17)
		Me.Label7.TabIndex = 17
		Me.Label7.Text = "Tel. Number"
		'
		'TelephoneTextBox
		'
		Me.TelephoneTextBox.Location = New System.Drawing.Point(144, 148)
		Me.TelephoneTextBox.Name = "TelephoneTextBox"
		Me.TelephoneTextBox.Size = New System.Drawing.Size(173, 25)
		Me.TelephoneTextBox.TabIndex = 16
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(341, 151)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(31, 17)
		Me.Label8.TabIndex = 19
		Me.Label8.Text = "NIN"
		'
		'NINTextBox
		'
		Me.NINTextBox.Location = New System.Drawing.Point(434, 148)
		Me.NINTextBox.Name = "NINTextBox"
		Me.NINTextBox.Size = New System.Drawing.Size(173, 25)
		Me.NINTextBox.TabIndex = 18
		'
		'PositionComboBox
		'
		Me.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PositionComboBox.FormattingEnabled = True
		Me.PositionComboBox.Items.AddRange(New Object() {"Charge Nurse", "Staff Nurse", "Nurse", "Personnel Officer", "Medical Director", "Staff", "Consultant", "Doctor", "Other"})
		Me.PositionComboBox.Location = New System.Drawing.Point(144, 192)
		Me.PositionComboBox.Name = "PositionComboBox"
		Me.PositionComboBox.Size = New System.Drawing.Size(173, 25)
		Me.PositionComboBox.TabIndex = 21
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(27, 195)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(54, 17)
		Me.Label9.TabIndex = 20
		Me.Label9.Text = "Position"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(341, 195)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(90, 17)
		Me.Label10.TabIndex = 23
		Me.Label10.Text = "Current Salary"
		'
		'SalaryTextBox
		'
		Me.SalaryTextBox.Location = New System.Drawing.Point(435, 192)
		Me.SalaryTextBox.Name = "SalaryTextBox"
		Me.SalaryTextBox.Size = New System.Drawing.Size(173, 25)
		Me.SalaryTextBox.TabIndex = 22
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(341, 226)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(77, 17)
		Me.Label11.TabIndex = 28
		Me.Label11.Text = "Salary Scale"
		'
		'PaymentTypeComboBox
		'
		Me.PaymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PaymentTypeComboBox.FormattingEnabled = True
		Me.PaymentTypeComboBox.Items.AddRange(New Object() {"Test", "Mounthly", "Weekly"})
		Me.PaymentTypeComboBox.Location = New System.Drawing.Point(435, 254)
		Me.PaymentTypeComboBox.Name = "PaymentTypeComboBox"
		Me.PaymentTypeComboBox.Size = New System.Drawing.Size(173, 25)
		Me.PaymentTypeComboBox.TabIndex = 30
		'
		'ContractTypeComboBox
		'
		Me.ContractTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ContractTypeComboBox.FormattingEnabled = True
		Me.ContractTypeComboBox.Items.AddRange(New Object() {"Temporary", "Permanent"})
		Me.ContractTypeComboBox.Location = New System.Drawing.Point(144, 223)
		Me.ContractTypeComboBox.Name = "ContractTypeComboBox"
		Me.ContractTypeComboBox.Size = New System.Drawing.Size(173, 25)
		Me.ContractTypeComboBox.TabIndex = 31
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(27, 226)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(88, 17)
		Me.Label13.TabIndex = 32
		Me.Label13.Text = "Contract Type"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(27, 257)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(106, 17)
		Me.Label14.TabIndex = 34
		Me.Label14.Text = "Hours per weeks"
		'
		'HPWTextBox
		'
		Me.HPWTextBox.Location = New System.Drawing.Point(144, 254)
		Me.HPWTextBox.Name = "HPWTextBox"
		Me.HPWTextBox.Size = New System.Drawing.Size(173, 25)
		Me.HPWTextBox.TabIndex = 33
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(23, 9)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(260, 28)
		Me.Label15.TabIndex = 35
		Me.Label15.Text = "Create a New Staff Profile"
		'
		'AddNewQualiButton
		'
		Me.AddNewQualiButton.Location = New System.Drawing.Point(28, 307)
		Me.AddNewQualiButton.Name = "AddNewQualiButton"
		Me.AddNewQualiButton.Size = New System.Drawing.Size(135, 59)
		Me.AddNewQualiButton.TabIndex = 36
		Me.AddNewQualiButton.Text = "Add a new qualification"
		Me.AddNewQualiButton.UseVisualStyleBackColor = True
		'
		'AddNewWorkExpButton
		'
		Me.AddNewWorkExpButton.Location = New System.Drawing.Point(30, 452)
		Me.AddNewWorkExpButton.Name = "AddNewWorkExpButton"
		Me.AddNewWorkExpButton.Size = New System.Drawing.Size(135, 56)
		Me.AddNewWorkExpButton.TabIndex = 37
		Me.AddNewWorkExpButton.Text = "Add a new Work Experience"
		Me.AddNewWorkExpButton.UseVisualStyleBackColor = True
		'
		'CreateButton
		'
		Me.CreateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CreateButton.Location = New System.Drawing.Point(597, 646)
		Me.CreateButton.Name = "CreateButton"
		Me.CreateButton.Size = New System.Drawing.Size(91, 26)
		Me.CreateButton.TabIndex = 40
		Me.CreateButton.Text = "Create"
		Me.CreateButton.UseVisualStyleBackColor = True
		'
		'WorksFLP
		'
		Me.WorksFLP.AutoScroll = True
		Me.WorksFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.WorksFLP.Location = New System.Drawing.Point(169, 452)
		Me.WorksFLP.Name = "WorksFLP"
		Me.WorksFLP.Size = New System.Drawing.Size(482, 139)
		Me.WorksFLP.TabIndex = 39
		Me.WorksFLP.WrapContents = False
		'
		'QualificationFLP
		'
		Me.QualificationFLP.AutoScroll = True
		Me.QualificationFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.QualificationFLP.Location = New System.Drawing.Point(169, 307)
		Me.QualificationFLP.Name = "QualificationFLP"
		Me.QualificationFLP.Size = New System.Drawing.Size(482, 139)
		Me.QualificationFLP.TabIndex = 38
		Me.QualificationFLP.WrapContents = False
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(341, 18)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(89, 17)
		Me.Label16.TabIndex = 41
		Me.Label16.Text = "Staff Number"
		'
		'StaffNumberTextBox
		'
		Me.StaffNumberTextBox.Location = New System.Drawing.Point(435, 15)
		Me.StaffNumberTextBox.Name = "StaffNumberTextBox"
		Me.StaffNumberTextBox.Size = New System.Drawing.Size(98, 25)
		Me.StaffNumberTextBox.TabIndex = 42
		'
		'SalaryScaleComboBox
		'
		Me.SalaryScaleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SalaryScaleComboBox.FormattingEnabled = True
		Me.SalaryScaleComboBox.Items.AddRange(New Object() {"Brand 1", "Brand 2", "Brand 3", "Brand 4", "Brand 5", "Brand 6", "Brand 7", "Brand 8", "Brand 8a", "Brand 8b", "Brand 8c", "Brand 8d", "Brand 8e", "Brand 9"})
		Me.SalaryScaleComboBox.Location = New System.Drawing.Point(434, 223)
		Me.SalaryScaleComboBox.Name = "SalaryScaleComboBox"
		Me.SalaryScaleComboBox.Size = New System.Drawing.Size(174, 25)
		Me.SalaryScaleComboBox.TabIndex = 43
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(341, 257)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(88, 17)
		Me.Label12.TabIndex = 29
		Me.Label12.Text = "Payment Type"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(25, 610)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(66, 17)
		Me.Label17.TabIndex = 44
		Me.Label17.Text = "Password"
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.Location = New System.Drawing.Point(97, 607)
		Me.PasswordTextBox.Name = "PasswordTextBox"
		Me.PasswordTextBox.Size = New System.Drawing.Size(416, 25)
		Me.PasswordTextBox.TabIndex = 45
		Me.PasswordTextBox.UseSystemPasswordChar = True
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(539, 18)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(128, 17)
		Me.Label18.TabIndex = 46
		Me.Label18.Text = "(Can not be changed)"
		'
		'ShowPwdCheckBox
		'
		Me.ShowPwdCheckBox.AutoSize = True
		Me.ShowPwdCheckBox.Location = New System.Drawing.Point(530, 609)
		Me.ShowPwdCheckBox.Name = "ShowPwdCheckBox"
		Me.ShowPwdCheckBox.Size = New System.Drawing.Size(121, 21)
		Me.ShowPwdCheckBox.TabIndex = 47
		Me.ShowPwdCheckBox.Text = "Show Password"
		Me.ShowPwdCheckBox.UseVisualStyleBackColor = True
		'
		'CreateNewStaffForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 684)
		Me.Controls.Add(Me.ShowPwdCheckBox)
		Me.Controls.Add(Me.Label18)
		Me.Controls.Add(Me.PasswordTextBox)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.SalaryScaleComboBox)
		Me.Controls.Add(Me.StaffNumberTextBox)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.AddNewWorkExpButton)
		Me.Controls.Add(Me.CreateButton)
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
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "CreateNewStaffForm"
		Me.Text = "Create a New Staff Profile"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents DateOfBrithDTP As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NINTextBox As TextBox
    Friend WithEvents PositionComboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SalaryTextBox As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents PaymentTypeComboBox As ComboBox
	Friend WithEvents ContractTypeComboBox As ComboBox
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents HPWTextBox As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents AddNewQualiButton As Button
	Friend WithEvents AddNewWorkExpButton As Button
	Friend WithEvents CreateButton As Button
	Friend WithEvents WorksFLP As FlowLayoutPanel
	Friend WithEvents QualificationFLP As FlowLayoutPanel
	Friend WithEvents Label16 As Label
	Friend WithEvents StaffNumberTextBox As TextBox
	Friend WithEvents SalaryScaleComboBox As ComboBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents PasswordTextBox As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents ShowPwdCheckBox As CheckBox
End Class
