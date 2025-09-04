<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPatientAllocationForm
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
		Me.PatientsFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PickPatientsButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComfirmButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.WardComboBox = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'PatientsFLP
		'
		Me.PatientsFLP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PatientsFLP.AutoScroll = True
		Me.PatientsFLP.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.PatientsFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PatientsFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.PatientsFLP.Location = New System.Drawing.Point(13, 50)
		Me.PatientsFLP.Name = "PatientsFLP"
		Me.PatientsFLP.Size = New System.Drawing.Size(810, 354)
		Me.PatientsFLP.TabIndex = 0
		Me.PatientsFLP.WrapContents = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(13, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(244, 28)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Create a new allocations"
		'
		'PickPatientsButton
		'
		Me.PickPatientsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PickPatientsButton.Location = New System.Drawing.Point(702, 16)
		Me.PickPatientsButton.Name = "PickPatientsButton"
		Me.PickPatientsButton.Size = New System.Drawing.Size(121, 28)
		Me.PickPatientsButton.TabIndex = 2
		Me.PickPatientsButton.Text = "Pick Patients"
		Me.PickPatientsButton.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(439, 423)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "To Ward"
		'
		'ComfirmButton
		'
		Me.ComfirmButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ComfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.ComfirmButton.Location = New System.Drawing.Point(702, 419)
		Me.ComfirmButton.Name = "ComfirmButton"
		Me.ComfirmButton.Size = New System.Drawing.Size(120, 28)
		Me.ComfirmButton.TabIndex = 5
		Me.ComfirmButton.Text = "Confirm"
		Me.ComfirmButton.UseVisualStyleBackColor = True
		'
		'ResetButton
		'
		Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.ResetButton.Location = New System.Drawing.Point(12, 420)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(101, 28)
		Me.ResetButton.TabIndex = 6
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'WardComboBox
		'
		Me.WardComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WardComboBox.FormattingEnabled = True
		Me.WardComboBox.Location = New System.Drawing.Point(502, 420)
		Me.WardComboBox.Name = "WardComboBox"
		Me.WardComboBox.Size = New System.Drawing.Size(184, 25)
		Me.WardComboBox.TabIndex = 7
		'
		'NewPatientAllocationForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(835, 459)
		Me.Controls.Add(Me.WardComboBox)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ComfirmButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PickPatientsButton)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PatientsFLP)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "NewPatientAllocationForm"
		Me.Text = "Create a new Patient Allocation"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PatientsFLP As FlowLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents PickPatientsButton As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents ComfirmButton As Button
	Friend WithEvents ResetButton As Button
	Friend WithEvents WardComboBox As ComboBox
End Class
