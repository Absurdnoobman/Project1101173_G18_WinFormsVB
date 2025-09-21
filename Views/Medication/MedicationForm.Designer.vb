<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicationForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicationForm))
		Me.SelectPatientButton = New System.Windows.Forms.Button()
		Me.PatientFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.MedicationFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.AddButton = New System.Windows.Forms.Button()
		Me.SaveButton = New System.Windows.Forms.Button()
		Me.CancelButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'SelectPatientButton
		'
		Me.SelectPatientButton.Location = New System.Drawing.Point(551, 9)
		Me.SelectPatientButton.Name = "SelectPatientButton"
		Me.SelectPatientButton.Size = New System.Drawing.Size(113, 59)
		Me.SelectPatientButton.TabIndex = 1
		Me.SelectPatientButton.Text = "Select a Patient"
		Me.SelectPatientButton.UseVisualStyleBackColor = True
		'
		'PatientFLP
		'
		Me.PatientFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PatientFLP.Location = New System.Drawing.Point(9, 9)
		Me.PatientFLP.Name = "PatientFLP"
		Me.PatientFLP.Size = New System.Drawing.Size(529, 144)
		Me.PatientFLP.TabIndex = 2
		'
		'MedicationFLP
		'
		Me.MedicationFLP.AutoScroll = True
		Me.MedicationFLP.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.MedicationFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.MedicationFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.MedicationFLP.Location = New System.Drawing.Point(9, 213)
		Me.MedicationFLP.Name = "MedicationFLP"
		Me.MedicationFLP.Size = New System.Drawing.Size(655, 301)
		Me.MedicationFLP.TabIndex = 3
		Me.MedicationFLP.WrapContents = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(9, 177)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(115, 23)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Medication(s)"
		'
		'AddButton
		'
		Me.AddButton.Enabled = False
		Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.AddButton.Location = New System.Drawing.Point(551, 172)
		Me.AddButton.Name = "AddButton"
		Me.AddButton.Size = New System.Drawing.Size(113, 28)
		Me.AddButton.TabIndex = 5
		Me.AddButton.Text = "Add"
		Me.AddButton.UseVisualStyleBackColor = True
		'
		'SaveButton
		'
		Me.SaveButton.Location = New System.Drawing.Point(565, 532)
		Me.SaveButton.Name = "SaveButton"
		Me.SaveButton.Size = New System.Drawing.Size(92, 32)
		Me.SaveButton.TabIndex = 6
		Me.SaveButton.Text = "Save"
		Me.SaveButton.UseVisualStyleBackColor = True
		'
		'CancelButton
		'
		Me.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
		Me.CancelButton.Location = New System.Drawing.Point(467, 532)
		Me.CancelButton.Name = "CancelButton"
		Me.CancelButton.Size = New System.Drawing.Size(92, 32)
		Me.CancelButton.TabIndex = 7
		Me.CancelButton.Text = "Cancel"
		Me.CancelButton.UseVisualStyleBackColor = True
		'
		'MedicationForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(673, 573)
		Me.Controls.Add(Me.CancelButton)
		Me.Controls.Add(Me.SaveButton)
		Me.Controls.Add(Me.AddButton)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MedicationFLP)
		Me.Controls.Add(Me.PatientFLP)
		Me.Controls.Add(Me.SelectPatientButton)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "MedicationForm"
		Me.Padding = New System.Windows.Forms.Padding(6)
		Me.Text = "Medication Record"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SelectPatientButton As Button
	Friend WithEvents PatientFLP As FlowLayoutPanel
	Friend WithEvents MedicationFLP As FlowLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents AddButton As Button
	Friend WithEvents SaveButton As Button
	Friend WithEvents CancelButton As Button
End Class
