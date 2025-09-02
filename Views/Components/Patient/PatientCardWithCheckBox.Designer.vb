<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientCardWithCheckBox
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Me.SurnameLabel = New System.Windows.Forms.Label()
		Me.FirstnameLabel = New System.Windows.Forms.Label()
		Me.PatientNumberLabel = New System.Windows.Forms.Label()
		Me.SelectCheckBox = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'SurnameLabel
		'
		Me.SurnameLabel.AutoSize = True
		Me.SurnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SurnameLabel.Location = New System.Drawing.Point(181, 29)
		Me.SurnameLabel.Name = "SurnameLabel"
		Me.SurnameLabel.Size = New System.Drawing.Size(62, 17)
		Me.SurnameLabel.TabIndex = 7
		Me.SurnameLabel.Text = "Surname"
		'
		'FirstnameLabel
		'
		Me.FirstnameLabel.AutoSize = True
		Me.FirstnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FirstnameLabel.Location = New System.Drawing.Point(86, 29)
		Me.FirstnameLabel.Name = "FirstnameLabel"
		Me.FirstnameLabel.Size = New System.Drawing.Size(68, 17)
		Me.FirstnameLabel.TabIndex = 6
		Me.FirstnameLabel.Text = "Firstname"
		'
		'PatientNumberLabel
		'
		Me.PatientNumberLabel.AutoSize = True
		Me.PatientNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PatientNumberLabel.Location = New System.Drawing.Point(13, 26)
		Me.PatientNumberLabel.Name = "PatientNumberLabel"
		Me.PatientNumberLabel.Size = New System.Drawing.Size(48, 23)
		Me.PatientNumberLabel.TabIndex = 5
		Me.PatientNumberLabel.Text = "P----"
		'
		'SelectCheckBox
		'
		Me.SelectCheckBox.AutoSize = True
		Me.SelectCheckBox.Location = New System.Drawing.Point(558, 29)
		Me.SelectCheckBox.Name = "SelectCheckBox"
		Me.SelectCheckBox.Size = New System.Drawing.Size(64, 21)
		Me.SelectCheckBox.TabIndex = 4
		Me.SelectCheckBox.Text = "Select"
		Me.SelectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SelectCheckBox.UseVisualStyleBackColor = True
		'
		'PatientCardWithCheckBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.SurnameLabel)
		Me.Controls.Add(Me.FirstnameLabel)
		Me.Controls.Add(Me.PatientNumberLabel)
		Me.Controls.Add(Me.SelectCheckBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "PatientCardWithCheckBox"
		Me.Padding = New System.Windows.Forms.Padding(6)
		Me.Size = New System.Drawing.Size(635, 76)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SurnameLabel As Label
	Friend WithEvents FirstnameLabel As Label
	Friend WithEvents PatientNumberLabel As Label
	Friend WithEvents SelectCheckBox As CheckBox
End Class
