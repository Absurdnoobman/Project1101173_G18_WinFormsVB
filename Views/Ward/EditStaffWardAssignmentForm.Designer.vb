<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStaffWardAssignmentForm
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
		Me.DateWeekBeginingDTP = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ConfirmButton = New System.Windows.Forms.Button()
		Me.WardsComboBox = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.StaffFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'DateWeekBeginingDTP
		'
		Me.DateWeekBeginingDTP.Enabled = False
		Me.DateWeekBeginingDTP.Location = New System.Drawing.Point(489, 67)
		Me.DateWeekBeginingDTP.Name = "DateWeekBeginingDTP"
		Me.DateWeekBeginingDTP.Size = New System.Drawing.Size(237, 25)
		Me.DateWeekBeginingDTP.TabIndex = 18
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(485, 40)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(123, 23)
		Me.Label3.TabIndex = 17
		Me.Label3.Text = "Week Begining"
		'
		'ConfirmButton
		'
		Me.ConfirmButton.Location = New System.Drawing.Point(489, 170)
		Me.ConfirmButton.Name = "ConfirmButton"
		Me.ConfirmButton.Size = New System.Drawing.Size(237, 28)
		Me.ConfirmButton.TabIndex = 15
		Me.ConfirmButton.Text = "Confirm"
		Me.ConfirmButton.UseVisualStyleBackColor = True
		'
		'WardsComboBox
		'
		Me.WardsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WardsComboBox.Enabled = False
		Me.WardsComboBox.FormattingEnabled = True
		Me.WardsComboBox.Location = New System.Drawing.Point(489, 129)
		Me.WardsComboBox.Name = "WardsComboBox"
		Me.WardsComboBox.Size = New System.Drawing.Size(237, 25)
		Me.WardsComboBox.TabIndex = 14
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(485, 103)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(122, 23)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Assign to ward"
		'
		'StaffFLP
		'
		Me.StaffFLP.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.StaffFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.StaffFLP.Location = New System.Drawing.Point(12, 41)
		Me.StaffFLP.Name = "StaffFLP"
		Me.StaffFLP.Size = New System.Drawing.Size(457, 425)
		Me.StaffFLP.TabIndex = 11
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(11, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(115, 23)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Selected Staff"
		'
		'EditStaffWardAssignmentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(746, 478)
		Me.Controls.Add(Me.DateWeekBeginingDTP)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ConfirmButton)
		Me.Controls.Add(Me.WardsComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.StaffFLP)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "EditStaffWardAssignmentForm"
		Me.Text = "Edit Staff Ward Assignment"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DateWeekBeginingDTP As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents ConfirmButton As Button
	Friend WithEvents WardsComboBox As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents StaffFLP As FlowLayoutPanel
	Friend WithEvents Label1 As Label
End Class
