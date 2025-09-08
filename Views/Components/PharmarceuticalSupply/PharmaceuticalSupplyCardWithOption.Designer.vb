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
		Me.NameLabel = New System.Windows.Forms.Label()
		Me.MethodLabel = New System.Windows.Forms.Label()
		Me.RemoveButton = New System.Windows.Forms.Button()
		Me.DosageLabel = New System.Windows.Forms.Label()
		Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.FinishDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.UnitPerDayNumericUpDown = New System.Windows.Forms.NumericUpDown()
		CType(Me.UnitPerDayNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'NameLabel
		'
		Me.NameLabel.AutoSize = True
		Me.NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NameLabel.Location = New System.Drawing.Point(20, 16)
		Me.NameLabel.Name = "NameLabel"
		Me.NameLabel.Size = New System.Drawing.Size(56, 23)
		Me.NameLabel.TabIndex = 0
		Me.NameLabel.Text = "Name"
		'
		'MethodLabel
		'
		Me.MethodLabel.AutoSize = True
		Me.MethodLabel.Location = New System.Drawing.Point(20, 55)
		Me.MethodLabel.Name = "MethodLabel"
		Me.MethodLabel.Size = New System.Drawing.Size(54, 17)
		Me.MethodLabel.TabIndex = 1
		Me.MethodLabel.Text = "Method"
		'
		'RemoveButton
		'
		Me.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.RemoveButton.Location = New System.Drawing.Point(529, 46)
		Me.RemoveButton.Name = "RemoveButton"
		Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
		Me.RemoveButton.TabIndex = 2
		Me.RemoveButton.Text = "Remove"
		Me.RemoveButton.UseVisualStyleBackColor = True
		'
		'DosageLabel
		'
		Me.DosageLabel.AutoSize = True
		Me.DosageLabel.Location = New System.Drawing.Point(21, 84)
		Me.DosageLabel.Name = "DosageLabel"
		Me.DosageLabel.Size = New System.Drawing.Size(53, 17)
		Me.DosageLabel.TabIndex = 3
		Me.DosageLabel.Text = "Dosage"
		'
		'StartDateTimePicker
		'
		Me.StartDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.StartDateTimePicker.Location = New System.Drawing.Point(297, 18)
		Me.StartDateTimePicker.Name = "StartDateTimePicker"
		Me.StartDateTimePicker.Size = New System.Drawing.Size(200, 25)
		Me.StartDateTimePicker.TabIndex = 4
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(256, 22)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(35, 17)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Start"
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(256, 53)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(40, 17)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Finish"
		'
		'FinishDateTimePicker
		'
		Me.FinishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.FinishDateTimePicker.Location = New System.Drawing.Point(297, 49)
		Me.FinishDateTimePicker.Name = "FinishDateTimePicker"
		Me.FinishDateTimePicker.Size = New System.Drawing.Size(200, 25)
		Me.FinishDateTimePicker.TabIndex = 6
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(256, 84)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(80, 17)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "Unit Per Day"
		'
		'UnitPerDayNumericUpDown
		'
		Me.UnitPerDayNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.UnitPerDayNumericUpDown.Location = New System.Drawing.Point(342, 82)
		Me.UnitPerDayNumericUpDown.Name = "UnitPerDayNumericUpDown"
		Me.UnitPerDayNumericUpDown.Size = New System.Drawing.Size(155, 25)
		Me.UnitPerDayNumericUpDown.TabIndex = 10
		Me.UnitPerDayNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.UnitPerDayNumericUpDown.ThousandsSeparator = True
		'
		'PharmaceuticalSupplyCardWithOption
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.UnitPerDayNumericUpDown)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.FinishDateTimePicker)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.StartDateTimePicker)
		Me.Controls.Add(Me.DosageLabel)
		Me.Controls.Add(Me.RemoveButton)
		Me.Controls.Add(Me.MethodLabel)
		Me.Controls.Add(Me.NameLabel)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "PharmaceuticalSupplyCardWithOption"
		Me.Size = New System.Drawing.Size(623, 119)
		CType(Me.UnitPerDayNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents NameLabel As Label
	Friend WithEvents MethodLabel As Label
	Friend WithEvents RemoveButton As Button
	Friend WithEvents DosageLabel As Label
	Friend WithEvents StartDateTimePicker As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents FinishDateTimePicker As DateTimePicker
	Friend WithEvents Label6 As Label
	Friend WithEvents UnitPerDayNumericUpDown As NumericUpDown
End Class
