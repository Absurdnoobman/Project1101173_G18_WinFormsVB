<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilterCard
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
		Me.RemoveButton = New System.Windows.Forms.Button()
		Me.FieldComboBox = New System.Windows.Forms.ComboBox()
		Me.EntityComboBox = New System.Windows.Forms.ComboBox()
		Me.CustomSearchSlotFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.SuspendLayout()
		'
		'RemoveButton
		'
		Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.RemoveButton.Location = New System.Drawing.Point(353, 5)
		Me.RemoveButton.Name = "RemoveButton"
		Me.RemoveButton.Size = New System.Drawing.Size(66, 24)
		Me.RemoveButton.TabIndex = 7
		Me.RemoveButton.Text = "Remove"
		Me.RemoveButton.UseVisualStyleBackColor = True
		'
		'FieldComboBox
		'
		Me.FieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.FieldComboBox.FormattingEnabled = True
		Me.FieldComboBox.Location = New System.Drawing.Point(103, 4)
		Me.FieldComboBox.Name = "FieldComboBox"
		Me.FieldComboBox.Size = New System.Drawing.Size(78, 25)
		Me.FieldComboBox.TabIndex = 5
		'
		'EntityComboBox
		'
		Me.EntityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.EntityComboBox.FormattingEnabled = True
		Me.EntityComboBox.Location = New System.Drawing.Point(5, 4)
		Me.EntityComboBox.Name = "EntityComboBox"
		Me.EntityComboBox.Size = New System.Drawing.Size(92, 25)
		Me.EntityComboBox.TabIndex = 4
		'
		'CustomSearchSlotFLP
		'
		Me.CustomSearchSlotFLP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CustomSearchSlotFLP.Location = New System.Drawing.Point(184, 5)
		Me.CustomSearchSlotFLP.Margin = New System.Windows.Forms.Padding(0)
		Me.CustomSearchSlotFLP.Name = "CustomSearchSlotFLP"
		Me.CustomSearchSlotFLP.Size = New System.Drawing.Size(163, 25)
		Me.CustomSearchSlotFLP.TabIndex = 8
		Me.CustomSearchSlotFLP.WrapContents = False
		'
		'FilterCard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.CustomSearchSlotFLP)
		Me.Controls.Add(Me.RemoveButton)
		Me.Controls.Add(Me.FieldComboBox)
		Me.Controls.Add(Me.EntityComboBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "FilterCard"
		Me.Size = New System.Drawing.Size(422, 45)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents RemoveButton As Button
	Friend WithEvents FieldComboBox As ComboBox
	Friend WithEvents EntityComboBox As ComboBox
	Friend WithEvents CustomSearchSlotFLP As FlowLayoutPanel
End Class
