<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PharmaceuticalCardWithCheckBox
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
		Me.SurnameLabel = New System.Windows.Forms.Label()
		Me.NameLabel = New System.Windows.Forms.Label()
		Me.DrugNumberLabel = New System.Windows.Forms.Label()
		Me.SelectCheckBox = New System.Windows.Forms.CheckBox()
		Me.MethodLabel = New System.Windows.Forms.Label()
		Me.DosageLabel = New System.Windows.Forms.Label()
		Me.DescriptionLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'SurnameLabel
		'
		Me.SurnameLabel.AutoSize = True
		Me.SurnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SurnameLabel.Location = New System.Drawing.Point(180, 28)
		Me.SurnameLabel.Name = "SurnameLabel"
		Me.SurnameLabel.Size = New System.Drawing.Size(0, 17)
		Me.SurnameLabel.TabIndex = 11
		'
		'NameLabel
		'
		Me.NameLabel.AutoSize = True
		Me.NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NameLabel.Location = New System.Drawing.Point(88, 14)
		Me.NameLabel.Name = "NameLabel"
		Me.NameLabel.Size = New System.Drawing.Size(44, 17)
		Me.NameLabel.TabIndex = 10
		Me.NameLabel.Text = "Name"
		'
		'DrugNumberLabel
		'
		Me.DrugNumberLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.DrugNumberLabel.AutoSize = True
		Me.DrugNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DrugNumberLabel.Location = New System.Drawing.Point(15, 25)
		Me.DrugNumberLabel.Name = "DrugNumberLabel"
		Me.DrugNumberLabel.Size = New System.Drawing.Size(45, 23)
		Me.DrugNumberLabel.TabIndex = 9
		Me.DrugNumberLabel.Text = "-----"
		'
		'SelectCheckBox
		'
		Me.SelectCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SelectCheckBox.AutoSize = True
		Me.SelectCheckBox.Location = New System.Drawing.Point(557, 28)
		Me.SelectCheckBox.Name = "SelectCheckBox"
		Me.SelectCheckBox.Size = New System.Drawing.Size(64, 21)
		Me.SelectCheckBox.TabIndex = 8
		Me.SelectCheckBox.Text = "Select"
		Me.SelectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SelectCheckBox.UseVisualStyleBackColor = True
		'
		'MethodLabel
		'
		Me.MethodLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.MethodLabel.Location = New System.Drawing.Point(368, 14)
		Me.MethodLabel.Name = "MethodLabel"
		Me.MethodLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MethodLabel.Size = New System.Drawing.Size(166, 17)
		Me.MethodLabel.TabIndex = 12
		Me.MethodLabel.Text = "method"
		Me.MethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'DosageLabel
		'
		Me.DosageLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DosageLabel.Location = New System.Drawing.Point(319, 44)
		Me.DosageLabel.Name = "DosageLabel"
		Me.DosageLabel.Size = New System.Drawing.Size(214, 17)
		Me.DosageLabel.TabIndex = 13
		Me.DosageLabel.Text = "dosage"
		Me.DosageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'DescriptionLabel
		'
		Me.DescriptionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.DescriptionLabel.AutoEllipsis = True
		Me.DescriptionLabel.Location = New System.Drawing.Point(88, 42)
		Me.DescriptionLabel.Name = "DescriptionLabel"
		Me.DescriptionLabel.Size = New System.Drawing.Size(225, 21)
		Me.DescriptionLabel.TabIndex = 14
		Me.DescriptionLabel.Text = "desc"
		Me.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PharmaceuticalCardWithCheckBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.DescriptionLabel)
		Me.Controls.Add(Me.DosageLabel)
		Me.Controls.Add(Me.MethodLabel)
		Me.Controls.Add(Me.SurnameLabel)
		Me.Controls.Add(Me.NameLabel)
		Me.Controls.Add(Me.DrugNumberLabel)
		Me.Controls.Add(Me.SelectCheckBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "PharmaceuticalCardWithCheckBox"
		Me.Padding = New System.Windows.Forms.Padding(6)
		Me.Size = New System.Drawing.Size(633, 74)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SurnameLabel As Label
	Friend WithEvents NameLabel As Label
	Friend WithEvents DrugNumberLabel As Label
	Friend WithEvents SelectCheckBox As CheckBox
	Friend WithEvents MethodLabel As Label
	Friend WithEvents DosageLabel As Label
	Friend WithEvents DescriptionLabel As Label
End Class
