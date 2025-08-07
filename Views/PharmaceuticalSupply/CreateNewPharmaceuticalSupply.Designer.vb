<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewPharmaceuticalSupply
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
		Me.SupplyIdTextBox = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.NameTextBox = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DescTextBox = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.DosageTextBox = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.UnitComboBox = New System.Windows.Forms.ComboBox()
		Me.TextBox = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.CreateButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'SupplyIdTextBox
		'
		Me.SupplyIdTextBox.Location = New System.Drawing.Point(419, 11)
		Me.SupplyIdTextBox.Name = "SupplyIdTextBox"
		Me.SupplyIdTextBox.Size = New System.Drawing.Size(132, 25)
		Me.SupplyIdTextBox.TabIndex = 5
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(350, 14)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 17)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Supply ID"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(11, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(281, 28)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Create a New Supply Record"
		'
		'NameTextBox
		'
		Me.NameTextBox.Location = New System.Drawing.Point(93, 61)
		Me.NameTextBox.Name = "NameTextBox"
		Me.NameTextBox.Size = New System.Drawing.Size(552, 25)
		Me.NameTextBox.TabIndex = 7
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(13, 64)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(43, 17)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Name"
		'
		'DescTextBox
		'
		Me.DescTextBox.Location = New System.Drawing.Point(93, 100)
		Me.DescTextBox.Multiline = True
		Me.DescTextBox.Name = "DescTextBox"
		Me.DescTextBox.Size = New System.Drawing.Size(552, 70)
		Me.DescTextBox.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(13, 103)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(74, 17)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Description"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(13, 188)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(53, 17)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Dosage"
		'
		'DosageTextBox
		'
		Me.DosageTextBox.Location = New System.Drawing.Point(93, 185)
		Me.DosageTextBox.Name = "DosageTextBox"
		Me.DosageTextBox.Size = New System.Drawing.Size(116, 25)
		Me.DosageTextBox.TabIndex = 11
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(325, 188)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(158, 17)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Method of Administration"
		'
		'UnitComboBox
		'
		Me.UnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.UnitComboBox.FormattingEnabled = True
		Me.UnitComboBox.Items.AddRange(New Object() {"mg/mL"})
		Me.UnitComboBox.Location = New System.Drawing.Point(215, 185)
		Me.UnitComboBox.Name = "UnitComboBox"
		Me.UnitComboBox.Size = New System.Drawing.Size(91, 25)
		Me.UnitComboBox.TabIndex = 13
		'
		'TextBox
		'
		Me.TextBox.Location = New System.Drawing.Point(485, 185)
		Me.TextBox.Name = "TextBox"
		Me.TextBox.Size = New System.Drawing.Size(160, 25)
		Me.TextBox.TabIndex = 14
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(102, 225)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(138, 25)
		Me.TextBox3.TabIndex = 15
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(13, 228)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(86, 17)
		Me.Label7.TabIndex = 16
		Me.Label7.Text = "Reorder level"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(246, 228)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(49, 17)
		Me.Label8.TabIndex = 17
		Me.Label8.Text = "Quatity"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(396, 228)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(85, 17)
		Me.Label9.TabIndex = 18
		Me.Label9.Text = "Cost per Unit"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(301, 225)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(89, 25)
		Me.TextBox4.TabIndex = 19
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(485, 225)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(160, 25)
		Me.TextBox5.TabIndex = 20
		'
		'CreateButton
		'
		Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.CreateButton.Location = New System.Drawing.Point(564, 276)
		Me.CreateButton.Name = "CreateButton"
		Me.CreateButton.Size = New System.Drawing.Size(81, 26)
		Me.CreateButton.TabIndex = 21
		Me.CreateButton.Text = "Create"
		Me.CreateButton.UseVisualStyleBackColor = True
		'
		'ResetButton
		'
		Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.ResetButton.Location = New System.Drawing.Point(11, 276)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(81, 26)
		Me.ResetButton.TabIndex = 22
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'CreateNewPharmaceuticalSupply
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(656, 313)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.CreateButton)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox)
		Me.Controls.Add(Me.UnitComboBox)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.DosageTextBox)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.DescTextBox)
		Me.Controls.Add(Me.NameTextBox)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.SupplyIdTextBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "CreateNewPharmaceuticalSupply"
		Me.Padding = New System.Windows.Forms.Padding(8)
		Me.Text = "Create a New Pharmaceutical Supply"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SupplyIdTextBox As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents NameTextBox As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents DescTextBox As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents DosageTextBox As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents UnitComboBox As ComboBox
	Friend WithEvents TextBox As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents CreateButton As Button
	Friend WithEvents ResetButton As Button
End Class
