<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffWardAssignmentForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.StaffFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.PickStaffButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.WardsComboBox = New System.Windows.Forms.ComboBox()
		Me.ConfirmButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DateWeekBeginingDTP = New System.Windows.Forms.DateTimePicker()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(15, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(115, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Selected Staff"
		'
		'StaffFLP
		'
		Me.StaffFLP.AutoScroll = True
		Me.StaffFLP.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.StaffFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.StaffFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.StaffFLP.Location = New System.Drawing.Point(16, 38)
		Me.StaffFLP.Name = "StaffFLP"
		Me.StaffFLP.Size = New System.Drawing.Size(457, 425)
		Me.StaffFLP.TabIndex = 1
		Me.StaffFLP.WrapContents = False
		'
		'PickStaffButton
		'
		Me.PickStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.PickStaffButton.Location = New System.Drawing.Point(337, 9)
		Me.PickStaffButton.Name = "PickStaffButton"
		Me.PickStaffButton.Size = New System.Drawing.Size(136, 23)
		Me.PickStaffButton.TabIndex = 2
		Me.PickStaffButton.Text = "Pick staff"
		Me.PickStaffButton.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(489, 100)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(122, 23)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Assign to ward"
		'
		'WardsComboBox
		'
		Me.WardsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WardsComboBox.FormattingEnabled = True
		Me.WardsComboBox.Location = New System.Drawing.Point(493, 126)
		Me.WardsComboBox.Name = "WardsComboBox"
		Me.WardsComboBox.Size = New System.Drawing.Size(237, 25)
		Me.WardsComboBox.TabIndex = 5
		'
		'ConfirmButton
		'
		Me.ConfirmButton.Location = New System.Drawing.Point(493, 167)
		Me.ConfirmButton.Name = "ConfirmButton"
		Me.ConfirmButton.Size = New System.Drawing.Size(237, 28)
		Me.ConfirmButton.TabIndex = 6
		Me.ConfirmButton.Text = "Confirm"
		Me.ConfirmButton.UseVisualStyleBackColor = True
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(493, 201)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(237, 28)
		Me.ResetButton.TabIndex = 7
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(489, 37)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(123, 23)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Week Begining"
		'
		'DateWeekBeginingDTP
		'
		Me.DateWeekBeginingDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateWeekBeginingDTP.Location = New System.Drawing.Point(493, 64)
		Me.DateWeekBeginingDTP.Name = "DateWeekBeginingDTP"
		Me.DateWeekBeginingDTP.Size = New System.Drawing.Size(237, 25)
		Me.DateWeekBeginingDTP.TabIndex = 9
		'
		'StaffWardAssignmentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(754, 478)
		Me.Controls.Add(Me.DateWeekBeginingDTP)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ConfirmButton)
		Me.Controls.Add(Me.WardsComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PickStaffButton)
		Me.Controls.Add(Me.StaffFLP)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "StaffWardAssignmentForm"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Assign Staff to a Ward"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents StaffFLP As FlowLayoutPanel
    Friend WithEvents PickStaffButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents WardsComboBox As ComboBox
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateWeekBeginingDTP As DateTimePicker
End Class
