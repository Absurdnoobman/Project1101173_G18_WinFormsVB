<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterDateSearchMode
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
		Me.OperatorComboBox = New System.Windows.Forms.ComboBox()
		Me.InputDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.SuspendLayout()
		'
		'OperatorComboBox
		'
		Me.OperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.OperatorComboBox.FormattingEnabled = True
		Me.OperatorComboBox.Items.AddRange(New Object() {"On", "Before", "After"})
		Me.OperatorComboBox.Location = New System.Drawing.Point(1, 0)
		Me.OperatorComboBox.Name = "OperatorComboBox"
		Me.OperatorComboBox.Size = New System.Drawing.Size(77, 25)
		Me.OperatorComboBox.TabIndex = 2
		'
		'InputDateTimePicker
		'
		Me.InputDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.InputDateTimePicker.Location = New System.Drawing.Point(85, 0)
		Me.InputDateTimePicker.Name = "InputDateTimePicker"
		Me.InputDateTimePicker.Size = New System.Drawing.Size(147, 25)
		Me.InputDateTimePicker.TabIndex = 3
		'
		'FilterDateSearchMode
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.InputDateTimePicker)
		Me.Controls.Add(Me.OperatorComboBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "FilterDateSearchMode"
		Me.Size = New System.Drawing.Size(235, 25)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents OperatorComboBox As ComboBox
	Friend WithEvents InputDateTimePicker As DateTimePicker
End Class
