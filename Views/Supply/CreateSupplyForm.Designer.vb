<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSupplyForm
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SupplyIdTextBox = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.NameTextBox = New System.Windows.Forms.TextBox()
		Me.DescTextBox = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.ReorderLevelTextBox = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.QuatityTextBox = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TypeComboBox = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.CostPerUnitTextBox = New System.Windows.Forms.TextBox()
		Me.CreateButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(11, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(281, 28)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Create a New Supply Record"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(349, 17)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Supply ID"
		'
		'SupplyIdTextBox
		'
		Me.SupplyIdTextBox.Location = New System.Drawing.Point(418, 14)
		Me.SupplyIdTextBox.Name = "SupplyIdTextBox"
		Me.SupplyIdTextBox.Size = New System.Drawing.Size(132, 25)
		Me.SupplyIdTextBox.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(25, 56)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(43, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Name"
		'
		'NameTextBox
		'
		Me.NameTextBox.Location = New System.Drawing.Point(123, 53)
		Me.NameTextBox.Name = "NameTextBox"
		Me.NameTextBox.Size = New System.Drawing.Size(226, 25)
		Me.NameTextBox.TabIndex = 4
		'
		'DescTextBox
		'
		Me.DescTextBox.Location = New System.Drawing.Point(123, 96)
		Me.DescTextBox.Multiline = True
		Me.DescTextBox.Name = "DescTextBox"
		Me.DescTextBox.Size = New System.Drawing.Size(435, 70)
		Me.DescTextBox.TabIndex = 6
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(25, 96)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(74, 17)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Description"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(25, 186)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(89, 17)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Reorder Level"
		'
		'ReorderLevelTextBox
		'
		Me.ReorderLevelTextBox.Location = New System.Drawing.Point(123, 183)
		Me.ReorderLevelTextBox.Name = "ReorderLevelTextBox"
		Me.ReorderLevelTextBox.Size = New System.Drawing.Size(132, 25)
		Me.ReorderLevelTextBox.TabIndex = 8
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(323, 186)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(49, 17)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Quatity"
		'
		'QuatityTextBox
		'
		Me.QuatityTextBox.Location = New System.Drawing.Point(378, 183)
		Me.QuatityTextBox.Name = "QuatityTextBox"
		Me.QuatityTextBox.Size = New System.Drawing.Size(132, 25)
		Me.QuatityTextBox.TabIndex = 10
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(375, 56)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(35, 17)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Type"
		'
		'TypeComboBox
		'
		Me.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.TypeComboBox.FormattingEnabled = True
		Me.TypeComboBox.Items.AddRange(New Object() {"Surgical", "Non-surgical"})
		Me.TypeComboBox.Location = New System.Drawing.Point(418, 53)
		Me.TypeComboBox.Name = "TypeComboBox"
		Me.TypeComboBox.Size = New System.Drawing.Size(140, 25)
		Me.TypeComboBox.TabIndex = 12
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(25, 223)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(85, 17)
		Me.Label8.TabIndex = 13
		Me.Label8.Text = "Cost per Unit"
		'
		'CostPerUnitTextBox
		'
		Me.CostPerUnitTextBox.Location = New System.Drawing.Point(123, 220)
		Me.CostPerUnitTextBox.Name = "CostPerUnitTextBox"
		Me.CostPerUnitTextBox.Size = New System.Drawing.Size(132, 25)
		Me.CostPerUnitTextBox.TabIndex = 14
		'
		'CreateButton
		'
		Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.CreateButton.Location = New System.Drawing.Point(495, 267)
		Me.CreateButton.Name = "CreateButton"
		Me.CreateButton.Size = New System.Drawing.Size(81, 26)
		Me.CreateButton.TabIndex = 15
		Me.CreateButton.Text = "Create"
		Me.CreateButton.UseVisualStyleBackColor = True
		'
		'ResetButton
		'
		Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.ResetButton.Location = New System.Drawing.Point(28, 267)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(81, 26)
		Me.ResetButton.TabIndex = 16
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'CreateSupplyForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(587, 304)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.CreateButton)
		Me.Controls.Add(Me.CostPerUnitTextBox)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.TypeComboBox)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.QuatityTextBox)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.ReorderLevelTextBox)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.DescTextBox)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.NameTextBox)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.SupplyIdTextBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "CreateSupplyForm"
		Me.Padding = New System.Windows.Forms.Padding(8)
		Me.Text = "Create a new Supply"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents SupplyIdTextBox As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents NameTextBox As TextBox
	Friend WithEvents DescTextBox As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents ReorderLevelTextBox As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents QuatityTextBox As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents TypeComboBox As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents CostPerUnitTextBox As TextBox
	Friend WithEvents CreateButton As Button
	Friend WithEvents ResetButton As Button
End Class
