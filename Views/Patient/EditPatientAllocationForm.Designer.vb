<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPatientAllocationForm
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
		Me.DurationTextBox = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.PlacedDTP = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.BedNumberTextBox = New System.Windows.Forms.TextBox()
		Me.PatientNumberLabel = New System.Windows.Forms.Label()
		Me.PatientNameLabel = New System.Windows.Forms.Label()
		Me.SaveButton = New System.Windows.Forms.Button()
		Me.ActualLeaveDTP = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.isLeftCheckBox = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'DurationTextBox
		'
		Me.DurationTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DurationTextBox.Location = New System.Drawing.Point(570, 56)
		Me.DurationTextBox.Name = "DurationTextBox"
		Me.DurationTextBox.Size = New System.Drawing.Size(92, 25)
		Me.DurationTextBox.TabIndex = 13
		'
		'Label5
		'
		Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(427, 59)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(137, 17)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "Expeted Stay Duration"
		'
		'PlacedDTP
		'
		Me.PlacedDTP.Enabled = False
		Me.PlacedDTP.Location = New System.Drawing.Point(103, 56)
		Me.PlacedDTP.Name = "PlacedDTP"
		Me.PlacedDTP.Size = New System.Drawing.Size(239, 25)
		Me.PlacedDTP.TabIndex = 11
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(20, 60)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(77, 17)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Date Placed"
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(482, 21)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(82, 17)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Bed Number"
		'
		'BedNumberTextBox
		'
		Me.BedNumberTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BedNumberTextBox.BackColor = System.Drawing.SystemColors.Window
		Me.BedNumberTextBox.Location = New System.Drawing.Point(570, 18)
		Me.BedNumberTextBox.Name = "BedNumberTextBox"
		Me.BedNumberTextBox.Size = New System.Drawing.Size(92, 25)
		Me.BedNumberTextBox.TabIndex = 8
		'
		'PatientNumberLabel
		'
		Me.PatientNumberLabel.AutoSize = True
		Me.PatientNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PatientNumberLabel.Location = New System.Drawing.Point(19, 17)
		Me.PatientNumberLabel.Name = "PatientNumberLabel"
		Me.PatientNumberLabel.Size = New System.Drawing.Size(70, 23)
		Me.PatientNumberLabel.TabIndex = 14
		Me.PatientNumberLabel.Text = "P12345"
		'
		'PatientNameLabel
		'
		Me.PatientNameLabel.AutoEllipsis = True
		Me.PatientNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PatientNameLabel.Location = New System.Drawing.Point(95, 17)
		Me.PatientNameLabel.Name = "PatientNameLabel"
		Me.PatientNameLabel.Size = New System.Drawing.Size(316, 23)
		Me.PatientNameLabel.TabIndex = 15
		Me.PatientNameLabel.Text = "Name Fullname"
		Me.PatientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SaveButton
		'
		Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SaveButton.Location = New System.Drawing.Point(570, 96)
		Me.SaveButton.Name = "SaveButton"
		Me.SaveButton.Size = New System.Drawing.Size(91, 37)
		Me.SaveButton.TabIndex = 16
		Me.SaveButton.Text = "Save"
		Me.SaveButton.UseVisualStyleBackColor = True
		'
		'ActualLeaveDTP
		'
		Me.ActualLeaveDTP.Location = New System.Drawing.Point(103, 100)
		Me.ActualLeaveDTP.Name = "ActualLeaveDTP"
		Me.ActualLeaveDTP.Size = New System.Drawing.Size(239, 25)
		Me.ActualLeaveDTP.TabIndex = 18
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(20, 104)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(77, 17)
		Me.Label6.TabIndex = 17
		Me.Label6.Text = "Actual leave"
		'
		'isLeftCheckBox
		'
		Me.isLeftCheckBox.AutoSize = True
		Me.isLeftCheckBox.Location = New System.Drawing.Point(362, 104)
		Me.isLeftCheckBox.Name = "isLeftCheckBox"
		Me.isLeftCheckBox.Size = New System.Drawing.Size(115, 21)
		Me.isLeftCheckBox.TabIndex = 19
		Me.isLeftCheckBox.Text = "Patient has left"
		Me.isLeftCheckBox.UseVisualStyleBackColor = True
		'
		'EditPatientAllocationForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 145)
		Me.Controls.Add(Me.isLeftCheckBox)
		Me.Controls.Add(Me.ActualLeaveDTP)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.SaveButton)
		Me.Controls.Add(Me.PatientNameLabel)
		Me.Controls.Add(Me.PatientNumberLabel)
		Me.Controls.Add(Me.DurationTextBox)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.PlacedDTP)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.BedNumberTextBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "EditPatientAllocationForm"
		Me.Text = "Edit Patient Allocation Form"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DurationTextBox As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents PlacedDTP As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents BedNumberTextBox As TextBox
	Friend WithEvents PatientNumberLabel As Label
	Friend WithEvents PatientNameLabel As Label
	Friend WithEvents SaveButton As Button
	Friend WithEvents ActualLeaveDTP As DateTimePicker
	Friend WithEvents Label6 As Label
	Friend WithEvents isLeftCheckBox As CheckBox
End Class
