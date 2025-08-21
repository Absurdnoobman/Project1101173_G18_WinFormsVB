<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectedStaffCardWithShift
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
		Me.StaffNumberLabel = New System.Windows.Forms.Label()
		Me.FullNameLabel = New System.Windows.Forms.Label()
		Me.RemoveButton = New System.Windows.Forms.Button()
		Me.ShiftComboBox = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'StaffNumberLabel
		'
		Me.StaffNumberLabel.AutoSize = True
		Me.StaffNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffNumberLabel.Location = New System.Drawing.Point(13, 6)
		Me.StaffNumberLabel.Name = "StaffNumberLabel"
		Me.StaffNumberLabel.Size = New System.Drawing.Size(40, 23)
		Me.StaffNumberLabel.TabIndex = 0
		Me.StaffNumberLabel.Text = "S---"
		'
		'FullNameLabel
		'
		Me.FullNameLabel.AutoSize = True
		Me.FullNameLabel.Location = New System.Drawing.Point(77, 10)
		Me.FullNameLabel.Name = "FullNameLabel"
		Me.FullNameLabel.Size = New System.Drawing.Size(59, 17)
		Me.FullNameLabel.TabIndex = 1
		Me.FullNameLabel.Text = "Fullname"
		'
		'RemoveButton
		'
		Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.RemoveButton.Location = New System.Drawing.Point(332, 10)
		Me.RemoveButton.Name = "RemoveButton"
		Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
		Me.RemoveButton.TabIndex = 2
		Me.RemoveButton.Text = "Remove"
		Me.RemoveButton.UseVisualStyleBackColor = True
		'
		'ShiftComboBox
		'
		Me.ShiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ShiftComboBox.FormattingEnabled = True
		Me.ShiftComboBox.Items.AddRange(New Object() {"Early", "Late", "Night"})
		Me.ShiftComboBox.Location = New System.Drawing.Point(240, 10)
		Me.ShiftComboBox.Name = "ShiftComboBox"
		Me.ShiftComboBox.Size = New System.Drawing.Size(86, 25)
		Me.ShiftComboBox.TabIndex = 3
		'
		'SelectedStaffCardWithShift
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.ShiftComboBox)
		Me.Controls.Add(Me.RemoveButton)
		Me.Controls.Add(Me.FullNameLabel)
		Me.Controls.Add(Me.StaffNumberLabel)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "SelectedStaffCardWithShift"
		Me.Padding = New System.Windows.Forms.Padding(10, 6, 10, 6)
		Me.Size = New System.Drawing.Size(420, 46)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents StaffNumberLabel As Label
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ShiftComboBox As ComboBox
End Class
