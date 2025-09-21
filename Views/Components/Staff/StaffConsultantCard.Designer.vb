<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffConsultantCard
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Me.StaffNumberLabel = New System.Windows.Forms.Label()
		Me.FullnameLabel = New System.Windows.Forms.Label()
		Me.AddressLabel = New System.Windows.Forms.Label()
		Me.TelephoneLabel = New System.Windows.Forms.Label()
		Me.WardLabel = New System.Windows.Forms.Label()
		Me.WeekLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'StaffNumberLabel
		'
		Me.StaffNumberLabel.AutoEllipsis = True
		Me.StaffNumberLabel.Font = New System.Drawing.Font("Cascadia Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffNumberLabel.Location = New System.Drawing.Point(15, 12)
		Me.StaffNumberLabel.Name = "StaffNumberLabel"
		Me.StaffNumberLabel.Size = New System.Drawing.Size(109, 27)
		Me.StaffNumberLabel.TabIndex = 0
		Me.StaffNumberLabel.Text = "S---"
		Me.StaffNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'FullnameLabel
		'
		Me.FullnameLabel.AutoEllipsis = True
		Me.FullnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FullnameLabel.Location = New System.Drawing.Point(130, 15)
		Me.FullnameLabel.Name = "FullnameLabel"
		Me.FullnameLabel.Size = New System.Drawing.Size(351, 23)
		Me.FullnameLabel.TabIndex = 1
		Me.FullnameLabel.Text = "Fullname"
		Me.FullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'AddressLabel
		'
		Me.AddressLabel.AutoEllipsis = True
		Me.AddressLabel.Location = New System.Drawing.Point(17, 60)
		Me.AddressLabel.Name = "AddressLabel"
		Me.AddressLabel.Size = New System.Drawing.Size(201, 17)
		Me.AddressLabel.TabIndex = 2
		Me.AddressLabel.Text = "Address"
		Me.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TelephoneLabel
		'
		Me.TelephoneLabel.AutoEllipsis = True
		Me.TelephoneLabel.Location = New System.Drawing.Point(17, 91)
		Me.TelephoneLabel.Name = "TelephoneLabel"
		Me.TelephoneLabel.Size = New System.Drawing.Size(201, 17)
		Me.TelephoneLabel.TabIndex = 3
		Me.TelephoneLabel.Text = "Telephone"
		Me.TelephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'WardLabel
		'
		Me.WardLabel.AutoEllipsis = True
		Me.WardLabel.Location = New System.Drawing.Point(239, 60)
		Me.WardLabel.Name = "WardLabel"
		Me.WardLabel.Size = New System.Drawing.Size(242, 17)
		Me.WardLabel.TabIndex = 4
		Me.WardLabel.Text = "Ward"
		Me.WardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'WeekLabel
		'
		Me.WeekLabel.AutoEllipsis = True
		Me.WeekLabel.Location = New System.Drawing.Point(239, 91)
		Me.WeekLabel.Name = "WeekLabel"
		Me.WeekLabel.Size = New System.Drawing.Size(242, 17)
		Me.WeekLabel.TabIndex = 5
		Me.WeekLabel.Text = "WeekBeginning"
		Me.WeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'StaffConsultantCard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.WeekLabel)
		Me.Controls.Add(Me.WardLabel)
		Me.Controls.Add(Me.TelephoneLabel)
		Me.Controls.Add(Me.AddressLabel)
		Me.Controls.Add(Me.FullnameLabel)
		Me.Controls.Add(Me.StaffNumberLabel)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "StaffConsultantCard"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Size = New System.Drawing.Size(529, 141)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents StaffNumberLabel As Label
	Friend WithEvents FullnameLabel As Label
	Friend WithEvents AddressLabel As Label
	Friend WithEvents TelephoneLabel As Label
	Friend WithEvents WardLabel As Label
	Friend WithEvents WeekLabel As Label
End Class
