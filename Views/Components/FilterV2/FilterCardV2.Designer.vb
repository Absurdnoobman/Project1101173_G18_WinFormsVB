<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterCardV2
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
		Me.AttributeComboBox = New System.Windows.Forms.ComboBox()
		Me.RemoveButton = New System.Windows.Forms.Button()
		Me.SlotFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.SuspendLayout()
		'
		'AttributeComboBox
		'
		Me.AttributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.AttributeComboBox.FormattingEnabled = True
		Me.AttributeComboBox.Location = New System.Drawing.Point(5, 5)
		Me.AttributeComboBox.Name = "AttributeComboBox"
		Me.AttributeComboBox.Size = New System.Drawing.Size(99, 25)
		Me.AttributeComboBox.TabIndex = 0
		'
		'RemoveButton
		'
		Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.RemoveButton.Location = New System.Drawing.Point(351, 6)
		Me.RemoveButton.Name = "RemoveButton"
		Me.RemoveButton.Size = New System.Drawing.Size(66, 24)
		Me.RemoveButton.TabIndex = 8
		Me.RemoveButton.Text = "Remove"
		Me.RemoveButton.UseVisualStyleBackColor = True
		'
		'SlotFLP
		'
		Me.SlotFLP.Location = New System.Drawing.Point(110, 5)
		Me.SlotFLP.Name = "SlotFLP"
		Me.SlotFLP.Size = New System.Drawing.Size(235, 25)
		Me.SlotFLP.TabIndex = 10
		Me.SlotFLP.WrapContents = False
		'
		'FilterCardV2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.SlotFLP)
		Me.Controls.Add(Me.RemoveButton)
		Me.Controls.Add(Me.AttributeComboBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "FilterCardV2"
		Me.Padding = New System.Windows.Forms.Padding(2)
		Me.Size = New System.Drawing.Size(422, 45)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents AttributeComboBox As ComboBox
	Friend WithEvents RemoveButton As Button
	Friend WithEvents SlotFLP As FlowLayoutPanel
End Class
