<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientAllocationCardWithOption
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
		Me.PatientNumberLabel = New System.Windows.Forms.Label()
		Me.FullnameLabel = New System.Windows.Forms.Label()
		Me.BedNumberTextBox = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PlacedDTP = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.DurationTextBox = New System.Windows.Forms.TextBox()
		Me.WaitingListStatusLabel = New System.Windows.Forms.Label()
		Me.RemoveButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'PatientNumberLabel
		'
		Me.PatientNumberLabel.AutoSize = True
		Me.PatientNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PatientNumberLabel.Location = New System.Drawing.Point(27, 18)
		Me.PatientNumberLabel.Name = "PatientNumberLabel"
		Me.PatientNumberLabel.Size = New System.Drawing.Size(48, 23)
		Me.PatientNumberLabel.TabIndex = 0
		Me.PatientNumberLabel.Text = "P----"
		'
		'FullnameLabel
		'
		Me.FullnameLabel.AutoSize = True
		Me.FullnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FullnameLabel.Location = New System.Drawing.Point(112, 22)
		Me.FullnameLabel.Name = "FullnameLabel"
		Me.FullnameLabel.Size = New System.Drawing.Size(63, 17)
		Me.FullnameLabel.TabIndex = 1
		Me.FullnameLabel.Text = "Fullname"
		'
		'BedNumberTextBox
		'
		Me.BedNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.BedNumberTextBox.BackColor = System.Drawing.SystemColors.Window
		Me.BedNumberTextBox.Location = New System.Drawing.Point(387, 19)
		Me.BedNumberTextBox.Name = "BedNumberTextBox"
		Me.BedNumberTextBox.Size = New System.Drawing.Size(92, 25)
		Me.BedNumberTextBox.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(299, 22)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(82, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Bed Number"
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(299, 61)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(77, 17)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Date Placed"
		'
		'PlacedDTP
		'
		Me.PlacedDTP.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.PlacedDTP.Location = New System.Drawing.Point(387, 58)
		Me.PlacedDTP.Name = "PlacedDTP"
		Me.PlacedDTP.Size = New System.Drawing.Size(239, 25)
		Me.PlacedDTP.TabIndex = 5
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(526, 22)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(137, 17)
		Me.Label5.TabIndex = 6
		Me.Label5.Text = "Expeted Stay Duration"
		'
		'DurationTextBox
		'
		Me.DurationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.DurationTextBox.Location = New System.Drawing.Point(669, 19)
		Me.DurationTextBox.Name = "DurationTextBox"
		Me.DurationTextBox.Size = New System.Drawing.Size(92, 25)
		Me.DurationTextBox.TabIndex = 7
		'
		'WaitingListStatusLabel
		'
		Me.WaitingListStatusLabel.AutoSize = True
		Me.WaitingListStatusLabel.Location = New System.Drawing.Point(28, 64)
		Me.WaitingListStatusLabel.Name = "WaitingListStatusLabel"
		Me.WaitingListStatusLabel.Size = New System.Drawing.Size(100, 17)
		Me.WaitingListStatusLabel.TabIndex = 8
		Me.WaitingListStatusLabel.Text = "Unimplemented"
		'
		'RemoveButton
		'
		Me.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.RemoveButton.Location = New System.Drawing.Point(686, 55)
		Me.RemoveButton.Name = "RemoveButton"
		Me.RemoveButton.Size = New System.Drawing.Size(75, 29)
		Me.RemoveButton.TabIndex = 9
		Me.RemoveButton.Text = "Remove"
		Me.RemoveButton.UseVisualStyleBackColor = True
		'
		'PatientAllocationCardWithOption
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.RemoveButton)
		Me.Controls.Add(Me.WaitingListStatusLabel)
		Me.Controls.Add(Me.DurationTextBox)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.PlacedDTP)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.BedNumberTextBox)
		Me.Controls.Add(Me.FullnameLabel)
		Me.Controls.Add(Me.PatientNumberLabel)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "PatientAllocationCardWithOption"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Size = New System.Drawing.Size(782, 99)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PatientNumberLabel As Label
	Friend WithEvents FullnameLabel As Label
	Friend WithEvents BedNumberTextBox As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents PlacedDTP As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents DurationTextBox As TextBox
	Friend WithEvents WaitingListStatusLabel As Label
	Friend WithEvents RemoveButton As Button
End Class
