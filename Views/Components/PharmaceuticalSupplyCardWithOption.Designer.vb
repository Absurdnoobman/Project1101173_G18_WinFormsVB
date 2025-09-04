<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmaceuticalSupplyCardWithOption
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.RemoveButton = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(20, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(56, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Name"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 49)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Method"
		'
		'RemoveButton
		'
		Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.RemoveButton.Location = New System.Drawing.Point(529, 46)
		Me.RemoveButton.Name = "RemoveButton"
		Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
		Me.RemoveButton.TabIndex = 2
		Me.RemoveButton.Text = "Remove"
		Me.RemoveButton.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(21, 75)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Dosage"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(297, 18)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(200, 25)
		Me.DateTimePicker1.TabIndex = 4
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(256, 22)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(35, 17)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Start"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(256, 53)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(40, 17)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Finish"
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker2.Location = New System.Drawing.Point(297, 49)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(200, 25)
		Me.DateTimePicker2.TabIndex = 6
		'
		'PharmaceuticalSupplyCardWithOption
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.DateTimePicker2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.RemoveButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "PharmaceuticalSupplyCardWithOption"
		Me.Size = New System.Drawing.Size(623, 108)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents RemoveButton As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
