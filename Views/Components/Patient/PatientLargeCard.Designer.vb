<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientLargeCard
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
		Me.FullnameLabel = New System.Windows.Forms.Label()
		Me.PatientNumberLabel = New System.Windows.Forms.Label()
		Me.TelephoneLabel = New System.Windows.Forms.Label()
		Me.AddressLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'FullnameLabel
		'
		Me.FullnameLabel.AutoEllipsis = True
		Me.FullnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FullnameLabel.Location = New System.Drawing.Point(130, 15)
		Me.FullnameLabel.Name = "FullnameLabel"
		Me.FullnameLabel.Size = New System.Drawing.Size(341, 23)
		Me.FullnameLabel.TabIndex = 3
		Me.FullnameLabel.Text = "Fullname"
		Me.FullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PatientNumberLabel
		'
		Me.PatientNumberLabel.AutoEllipsis = True
		Me.PatientNumberLabel.Font = New System.Drawing.Font("Cascadia Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PatientNumberLabel.Location = New System.Drawing.Point(15, 11)
		Me.PatientNumberLabel.Name = "PatientNumberLabel"
		Me.PatientNumberLabel.Size = New System.Drawing.Size(84, 27)
		Me.PatientNumberLabel.TabIndex = 2
		Me.PatientNumberLabel.Text = "P-----"
		Me.PatientNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TelephoneLabel
		'
		Me.TelephoneLabel.AutoEllipsis = True
		Me.TelephoneLabel.Location = New System.Drawing.Point(17, 89)
		Me.TelephoneLabel.Name = "TelephoneLabel"
		Me.TelephoneLabel.Size = New System.Drawing.Size(454, 17)
		Me.TelephoneLabel.TabIndex = 5
		Me.TelephoneLabel.Text = "Telephone"
		Me.TelephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'AddressLabel
		'
		Me.AddressLabel.AutoEllipsis = True
		Me.AddressLabel.Location = New System.Drawing.Point(17, 58)
		Me.AddressLabel.Name = "AddressLabel"
		Me.AddressLabel.Size = New System.Drawing.Size(454, 17)
		Me.AddressLabel.TabIndex = 4
		Me.AddressLabel.Text = "Address"
		Me.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PatientLargeCard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TelephoneLabel)
		Me.Controls.Add(Me.AddressLabel)
		Me.Controls.Add(Me.FullnameLabel)
		Me.Controls.Add(Me.PatientNumberLabel)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "PatientLargeCard"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Size = New System.Drawing.Size(529, 141)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FullnameLabel As Label
	Friend WithEvents PatientNumberLabel As Label
	Friend WithEvents TelephoneLabel As Label
	Friend WithEvents AddressLabel As Label
End Class
