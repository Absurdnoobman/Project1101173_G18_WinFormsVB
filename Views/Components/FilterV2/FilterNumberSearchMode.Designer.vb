<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterNumberSearchMode
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
		Me.InputNumericUpDown = New System.Windows.Forms.NumericUpDown()
		CType(Me.InputNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'OperatorComboBox
		'
		Me.OperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.OperatorComboBox.FormattingEnabled = True
		Me.OperatorComboBox.Items.AddRange(New Object() {"==", "!=", "<", "<=", ">", ">="})
		Me.OperatorComboBox.Location = New System.Drawing.Point(0, 0)
		Me.OperatorComboBox.Name = "OperatorComboBox"
		Me.OperatorComboBox.Size = New System.Drawing.Size(77, 25)
		Me.OperatorComboBox.TabIndex = 1
		'
		'InputNumericUpDown
		'
		Me.InputNumericUpDown.Location = New System.Drawing.Point(84, 0)
		Me.InputNumericUpDown.Name = "InputNumericUpDown"
		Me.InputNumericUpDown.Size = New System.Drawing.Size(148, 25)
		Me.InputNumericUpDown.TabIndex = 2
		Me.InputNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'FilterNumberSearchMode
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.InputNumericUpDown)
		Me.Controls.Add(Me.OperatorComboBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "FilterNumberSearchMode"
		Me.Size = New System.Drawing.Size(235, 25)
		CType(Me.InputNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents OperatorComboBox As ComboBox
	Friend WithEvents InputNumericUpDown As NumericUpDown
End Class
